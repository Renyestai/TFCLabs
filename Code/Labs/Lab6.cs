using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace TFCLab1_Copy
{
	internal class Lab6
	{
		public static void BlockOne(RichTextBox inputRichBox, RichTextBox outputRichBox)
		{
			string input = inputRichBox.Text;

			// Регулярное выражение для поиска шестнадцатеричных цветов длиной 6 символов
			string pattern = @"#[0-9A-Fa-f]{6}";

			MatchCollection matches = Regex.Matches(input, pattern);

			string output = "";

			foreach (Match match in matches)
			{
				output += $"Найден шестнадцатеричный код цвета: '{match.Value}', начинается с {match.Index}\n";
			}

			outputRichBox.Text = output;
		}

		public static void BlockTwo(RichTextBox inputRichBox, RichTextBox outputRichBox)
		{
			string input = inputRichBox.Text;
			
			string pattern = @"\b(?:\d[\s-]*){9}[\dX]\b";

			MatchCollection matches = Regex.Matches(input, pattern);

			string output = "";

			foreach (Match match in matches)
			{
				output += $"Найден ISBN-10: '{match.Value}', начинается с {match.Index}\n";
			}

			outputRichBox.Text = output;
		}

		public static void BlockThree(RichTextBox inputRichBox, RichTextBox outputRichBox)
		{
			string input = inputRichBox.Text;

			string pattern = @"<(?:[a-zA-Z0-9_-]+\s*(?:[a-zA-Z0-9_-]+= ""[^""]*""\s*)*|/[a-zA-Z0-9_-]+)>";

			MatchCollection matches = Regex.Matches(input, pattern);

			string output = "";

			foreach (Match match in matches)
			{
				output += $"Найден XML тег: '{match.Value}', начинается с {match.Index}\n";
			}

			outputRichBox.Text = output;
		}

	}
		
}

