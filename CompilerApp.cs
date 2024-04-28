using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using TFCLab1_Copy;

namespace TFCLab1
{
	public partial class CompilerApp : Form
	{
		private string filePath; // Путь к текущему открытому файлу

		private bool isFileModified = false; // Был ли изменен файл в окне

		public CompilerApp()

		{
			InitializeComponent();
			FormClosing += new FormClosingEventHandler(CompilerApp_FormClosing);
			inputRichBox.TextChanged += InputRichBox_TextChanged;
			inputRichBox.VScroll += InputRichBox_VScroll;
			inputRichBox.FontChanged += InputRichBox_FontChanged;
			inputRichBox.SelectionChanged += InputRichBox_SelectionChanged;
		}
		private void UndoFile()
		{
			inputRichBox.Undo();
		}

		private void RedoFile()
		{
			inputRichBox.Redo();

		}

		private void InputRichBox_TextChanged(object sender, EventArgs e)
		{
			AppFunctions.FileModifiedNotSaved(ref isFileModified);
			AppFunctions.UpdateLineNumbers(LineNumberTextBox, inputRichBox, ClientRectangle);
			AppFunctions.HighlightKeywords(inputRichBox);

		}

		private void InputRichBox_VScroll(object sender, EventArgs e)
		{
			LineNumberTextBox.Text = "";
			AppFunctions.UpdateLineNumbers(LineNumberTextBox, inputRichBox,ClientRectangle);
			LineNumberTextBox.Invalidate();
		}

		private void InputRichBox_FontChanged(object sender, EventArgs e) //если будет меняться шрифт
		{
			LineNumberTextBox.Font = inputRichBox.Font;
			inputRichBox.Select();
			AppFunctions.UpdateLineNumbers(LineNumberTextBox, inputRichBox, ClientRectangle);
		}

		private void InputRichBox_SelectionChanged(object sender, EventArgs e)
		{
			int cursorPosition = inputRichBox.SelectionStart;
			int currentLine = inputRichBox.GetLineFromCharIndex(cursorPosition) + 1;
			int currentColumn = cursorPosition - inputRichBox.GetFirstCharIndexFromLine(currentLine - 1) +1;
			inputRichBox.Update();
			toolStripStatusLabelRow.Text = "Строка: " + currentLine.ToString() + "  Столбец: " + currentColumn.ToString();
		}


		private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppFunctions.CreateNewFile(ref filePath, ref isFileModified, inputRichBox);
			
		}

		private void CreateFileBtn_Click(object sender, EventArgs e)
		{
			AppFunctions.CreateNewFile(ref filePath, ref isFileModified, inputRichBox);
		}

		private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
		{	
			AppFunctions.OpenFile(ref filePath,ref isFileModified,inputRichBox);
		}

		private void OpenFileBtn_Click(object sender, EventArgs e)
		{
			AppFunctions.OpenFile(ref filePath, ref isFileModified, inputRichBox);
		}

		private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppFunctions.SaveFile(ref filePath, ref isFileModified, inputRichBox);
		}

		private void SaveFileBtn_Click(object sender, EventArgs e)
		{
			AppFunctions.SaveFile(ref filePath, ref isFileModified, inputRichBox);

		}

		private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppFunctions.SaveAsFileDialogue(ref filePath, isFileModified, inputRichBox);
			//toolStripStatusLabel1.Text = "Файл сохранен";
		}

		private void ОтменитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UndoFile();
		}
		private void UndoBtn_Click(object sender, EventArgs e)
		{
			UndoFile();
		}

		private void ПовторитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RedoFile();
		}

		private void RedoBtn_Click(object sender, EventArgs e)
		{
			RedoFile();
		}

		private void ВырезатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inputRichBox.Cut();
		}

		private void CutBtn_Click(object sender, EventArgs e)
		{
			inputRichBox.Cut();
		}

		private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inputRichBox.Copy();
		}

		private void CopyBtn_Click(object sender, EventArgs e)
		{
			inputRichBox.Copy();
		}

		private void ВставитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inputRichBox.Paste();
		}

		private void PasteBtn_Click(object sender, EventArgs e)
		{
			inputRichBox.Paste();
		}

		private void ВыделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inputRichBox.SelectAll();
		}

		private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inputRichBox.Clear();
		}

		private void ВызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppFunctions.ShowHelp();
		}

		private void HelpBtn_Click(object sender, EventArgs e)
		{
			AppFunctions.ShowHelp();
		}

		private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppFunctions.AboutBox();
		}

		private void InfoBtn_Click(object sender, EventArgs e)
		{
			AppFunctions.AboutBox();
		}

		private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void CompilerApp_FormClosing(object sender, FormClosingEventArgs e)
		{
			AppFunctions.ExitApp(ref filePath, ref isFileModified, inputRichBox, e);
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			AppFunctions.RunCompiler(inputRichBox, dataGridViewLexer, dataGridViewParser, toolStripStatusLabelErrors, toolStripStatusLabelClean, outputRichBox);
		}

		private void ПускToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AppFunctions.RunCompiler(inputRichBox, dataGridViewLexer, dataGridViewParser, toolStripStatusLabelErrors, toolStripStatusLabelClean, outputRichBox);

		}

		private void ИзменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				// Получаем выбранный шрифт из диалога
				Font selectedFont = fontDialog.Font;

				// Устанавливаем выбранный шрифт для элемента управления (например, для TextBox)
				inputRichBox.Font = selectedFont;

				// Устанавливаем выбранный шрифт для всех столбцов DataGridView
				foreach (DataGridViewRow row in dataGridViewLexer.Rows)
				{
					row.DefaultCellStyle.Font = selectedFont;
				}

				// Устанавливаем выбранный шрифт для всех столбцов DataGridView
				foreach (DataGridViewRow row in dataGridViewParser.Rows)
				{
					row.DefaultCellStyle.Font = selectedFont;
				}
			}
		}

		private void постановкаЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HtmlHelper.OpenInBrowser(@"Resources\TaskAssigment.html");
		}

		private void тестовыйпримерtoolStripMenuItem_Click(object sender, EventArgs e)
		{
			string filePath = @"Resources\right_example.txt"; //..\..\Resources\right_example.txt

			try
			{
				// Открываем текстовый файл для чтения
				using (StreamReader sr = new StreamReader(filePath))
				{
					// Читаем текст из файла
					string text = sr.ReadToEnd();

					// Помещаем текст в RichTextBox
					inputRichBox.Text = text;
					inputRichBox.ReadOnly = false;
					inputRichBox.Enabled = true;
				}
			}
			catch (IOException ex)
			{
				// Обработка исключений, связанных с чтением файла
				MessageBox.Show("Ошибка чтения файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			
		}

		private void исходныйкодпрограммыtoolStripMenuItem_Click(object sender, EventArgs e)
		{
			HtmlHelper.OpenInBrowser("https://github.com/Renyestai/Compiler");
		}

		private void грамматикаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HtmlHelper.OpenInBrowser(@"Resources\Grammar.html");
		}

		private void классификацияграмматикиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HtmlHelper.OpenInBrowser(@"Resources\GrammarClassification.html");
		}

		private void методанализаtoolStripMenuItem_Click(object sender, EventArgs e)
		{
			HtmlHelper.OpenInBrowser(@"Resources\MethodofAnalysis.html");
		}

		private void диагностикаинейтрализацияошибокtoolStripMenuItem_Click(object sender, EventArgs e)
		{
			HtmlHelper.OpenInBrowser(@"Resources\NeutrErrors.html");
		}

		private void списоклитературыtoolStripMenuItem_Click(object sender, EventArgs e)
		{
			HtmlHelper.OpenInBrowser(@"Resources\ListOfLiterature.html");
		}

		private void toolStripStatusLabelClean_Click(object sender, EventArgs e) //запуск метода Айронса
		{

		}

		private void первыйБлокToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Lab6.BlockOne(inputRichBox, outputRichBox);
		}

		private void второйБлокToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Lab6.BlockTwo(inputRichBox, outputRichBox);
		}

		private void третийБлокToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Lab6.BlockThree(inputRichBox, outputRichBox);
		}
	}
}