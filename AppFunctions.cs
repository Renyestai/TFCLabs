using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TFCLab1_Copy;

namespace TFCLab1
{
	internal class AppFunctions
	{
		internal static void AboutBox()
		{
			string aboutMessage = "Название программы: Компилятор\nВерсия: 1.0\nАвтор: Каршиганова Азиза\nГод: 2024";
			MessageBox.Show(aboutMessage, "О программе", MessageBoxButtons.OK);
		}

		internal static void ShowHelp()
		{
			HelpForm helpForm = new HelpForm();
			helpForm.ShowDialog();
		}

		public static void CreateNewFile(ref string filePath, ref bool isFileModified, RichTextBox inputBox)
		{
			if (isFileModified)
			{
				DialogResult result = MessageBox.Show("Предыдущий файл не был сохранен. Хотите сохранить изменения?", "Несохраненные изменения", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

				switch (result)
				{
					case DialogResult.Yes:
						SaveFile(ref filePath, ref isFileModified, inputBox);
						inputBox.Clear();
						break;
					case DialogResult.No:
						inputBox.Clear();
						break;
					default:
						break;
				}
			}
			else
			{
				inputBox.ReadOnly = false;
				inputBox.Enabled = true;
				inputBox.Clear();
			}
		}

		public static void OpenFile(ref string filePath, ref bool isFileModified, RichTextBox inputBox)
		{
			if (isFileModified)
			{
				DialogResult result = MessageBox.Show("Предыдущий файл не был сохранен. Хотите сохранить изменения?", "Несохраненные изменения", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

				switch (result)
				{
					case DialogResult.Yes:
						SaveFile(ref filePath, ref isFileModified, inputBox);
						break;
					case DialogResult.No:
						OpenFileDialogue(inputBox, ref filePath);
						break;
					default:
						break;
				}
			}
			else
			{
				OpenFileDialogue(inputBox, ref filePath);
			}
			FileModifiedSaved(ref isFileModified);
		}

		public static void OpenFileDialogue(RichTextBox inputBox, ref string filePath)
		{
			OpenFileDialog openFileWindow = new OpenFileDialog
			{
				Filter = "Текстовые файлы (*.txt)|*.txt|Файлы (*.cs)|*.cs|Все файлы (*.*)|*.*",
				Title = "Открыть",
				DefaultExt = "txt",
			};

			if (openFileWindow.ShowDialog() == DialogResult.OK)
			{
				filePath = openFileWindow.FileName;
				inputBox.LoadFile(openFileWindow.FileName, RichTextBoxStreamType.PlainText);
				inputBox.ReadOnly = false;
				inputBox.Enabled = true;
			}
		}

		public static void SaveAsFileDialogue(ref string filePath, bool isFileModified, RichTextBox inputBox)
		{
			SaveFileDialog saveFileWindow = new SaveFileDialog
			{
				Filter = "Текстовые файлы (*.txt)|*.txt|Файлы (*.cs)|*.cs|Все файлы (*.*)|*.*",
				Title = "Сохранить как"
			};

			if (!string.IsNullOrEmpty(filePath))
			{
				saveFileWindow.FileName = Path.GetFileName(filePath);
			}

			if (saveFileWindow.ShowDialog() == DialogResult.OK)
			{
				filePath = saveFileWindow.FileName;
				SaveExistingFile(ref filePath, ref isFileModified, inputBox);
			}
		}

		public static void SaveExistingFile(ref string filePath, ref bool isFileModified, RichTextBox inputBox)
		{
			inputBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
			FileModifiedSaved(ref isFileModified);
		}

		public static void SaveFile(ref string filePath, ref bool isFileModified, RichTextBox inputBox)
		{
			if (!string.IsNullOrEmpty(filePath))
			{
				SaveExistingFile(ref filePath, ref isFileModified, inputBox);
			}
			else
			{
				SaveAsFileDialogue(ref filePath, isFileModified, inputBox);
			}
		}

		public static void ExitApp(ref string filePath, ref bool isFileModified, RichTextBox inputBox, FormClosingEventArgs e)
		{
			if (isFileModified)
			{
				DialogResult result = MessageBox.Show("Файл не был сохранен. Хотите сохранить?", "Несохраненный файл", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

				switch (result)
				{
					case DialogResult.Yes:
						SaveFile(ref filePath, ref isFileModified, inputBox);
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
						// Для DialogResult.No ничего не делаем, форма будет закрыта без сохранения файла
				}

			}
		}

		public static void FileModifiedSaved(ref bool isFileModified)
		{
			isFileModified = false;
		}

		public static void FileModifiedNotSaved(ref bool isFileModified)
		{
			isFileModified = true;
		}

		public static void UpdateLineNumbers(RichTextBox lineNumbersRichBox, RichTextBox inputRichBox, Rectangle clientRectangle)
		{
			Point pt = new Point(0, 0);

			int charIndex = inputRichBox.GetCharIndexFromPosition(pt);
			int lineIndex = inputRichBox.GetLineFromCharIndex(charIndex);

			pt.X = clientRectangle.Width;
			pt.Y = clientRectangle.Height;

			int charLastIndex = inputRichBox.GetCharIndexFromPosition(pt);
			int lineLastIndex = inputRichBox.GetLineFromCharIndex(charLastIndex);

			lineNumbersRichBox.Text = "";
			lineNumbersRichBox.Width = GetWidth(inputRichBox);
			lineNumbersRichBox.Height = inputRichBox.Height;
			for (int i = lineIndex; i < lineLastIndex + 1; i++)
			{
				lineNumbersRichBox.Text += i + 1 + "\n";
			}
		}

		public static int GetWidth(RichTextBox inputRichBox)
		{
			int w;
			// get total lines of richTextBox1    
			int line = inputRichBox.Lines.Length;

			if (line <= 99)
			{
				w = 20 + (int)inputRichBox.Font.Size;
			}
			else if (line <= 999)
			{
				w = 30 + (int)inputRichBox.Font.Size;
			}
			else
			{
				w = 50 + (int)inputRichBox.Font.Size;
			}

			return w;
		}

		public static void HighlightKeywords(RichTextBox inputRichBox)
		{
			//await Task.Delay(500);
			int originalSelectionStart = inputRichBox.SelectionStart;
			int originalSelectionLength = inputRichBox.SelectionLength;
			// Определяем ключевые слова PHP
			string[] keywords = { "if", "else", "while", "foreach", "function", "class", "return" };

			foreach (var keyword in keywords)
			{
				Regex regex = new Regex("\\b" + Regex.Escape(keyword) + "\\b", RegexOptions.IgnoreCase);
				MatchCollection matches = regex.Matches(inputRichBox.Text);
				foreach (Match match in matches)
				{
					inputRichBox.Select(match.Index, match.Length);
					inputRichBox.SelectionColor = Color.Blue; // Или любой другой цвет
					inputRichBox.SelectionFont = new Font(inputRichBox.Font, FontStyle.Regular);
				}
			}

			inputRichBox.Select(originalSelectionStart, originalSelectionLength);
			inputRichBox.SelectionColor = inputRichBox.ForeColor;
			inputRichBox.SelectionFont = new Font(inputRichBox.Font, FontStyle.Regular);
		}

		public static void RunCompiler(RichTextBox inputRichBox, DataGridView dataGridViewLexer, DataGridView dataGridViewParser, ToolStripStatusLabel toolStripStatusLabelErrors, ToolStripStatusLabel toolStripStatusLabelClean, RichTextBox outputRichBox)
		{
			dataGridViewLexer.Rows.Clear();
			dataGridViewParser.Rows.Clear();

			
			// Лексический анализ
			LexicalAnalyzer lexer = new LexicalAnalyzer(inputRichBox.Text);
			List<Token> tokens = lexer.Tokenize();

			// Синтаксический анализ
			Parser parser = new Parser(tokens);
			List<Token> errorTokens = parser.Parse();
			foreach (Token token in tokens)
			{
				dataGridViewLexer.Rows.Add(token.CodeType, token.Type, token.Value, token.FirstPosition + " - " + token.SecondPosition);
			}

			int numOfErrors = 0;
			if (errorTokens.Any()) // если ошибки есть
			{
				toolStripStatusLabelErrors.Image = Image.FromFile(@"Resources\error.png");
				toolStripStatusLabelErrors.Text = errorTokens.Count.ToString();
				toolStripStatusLabelClean.Image = Image.FromFile(@"Resources\mop.png");

				foreach (Token token in errorTokens)
				{
					dataGridViewParser.Rows.Add(++numOfErrors, token.ErrorString, token.FirstPosition + " - " + token.SecondPosition);
				}

			}
			else
			{
				toolStripStatusLabelErrors.Image = Image.FromFile(@"Resources\correct.png");
				toolStripStatusLabelErrors.Text = "Ошибок не обнаружено";
				toolStripStatusLabelClean.Image = null;
			}

			//StringHelper stringHelper = new StringHelper(inputRichBox.Text);
			//SecParser secparser = new SecParser(inputRichBox.Text);
			//List<ParserError> errorParser = secparser.Parse();

			//foreach (ParserError error in errorParser)
			//{
			//	dataGridViewParser.Rows.Add(++numOfErrors, error.Message, error.Position);
			//}

		}
	}
}
