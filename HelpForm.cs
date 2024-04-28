using System;
using System.Windows.Forms;

namespace TFCLab1
{
	public partial class HelpForm : Form
	{
		public HelpForm()
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.FixedSingle; // Запрещает изменение размеров формы
			MaximizeBox = false; // Скрывает кнопку "Развернуть на весь экран"
		}

		private void Help_Load(object sender, EventArgs e)
		{
			string htmlFilePath = @"C:\Users\fallr\source\repos\TFCLab1\ShowHelpHTMLPage.html";

			webBrowserHelp.Navigate(htmlFilePath);
		}
	}
}
