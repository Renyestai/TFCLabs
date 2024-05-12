using System.Windows.Forms;

namespace TFCLab1
{
	partial class CompilerApp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompilerApp));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ОтменитьStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.постановкаЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.классификацияграмматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.методанализаtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.диагностикаинейтрализацияошибокtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.тестовыйпримерtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списоклитературыtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.исходныйкодпрограммыtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вызовСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.остальныеЛРToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.лабораторнаяРабота5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.лабораторнаяРабота6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.первыйБлокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.второйБлокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.третийБлокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.createFileBtn = new System.Windows.Forms.ToolStripButton();
			this.openFileBtn = new System.Windows.Forms.ToolStripButton();
			this.saveFileBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.undoBtn = new System.Windows.Forms.ToolStripButton();
			this.redoBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.copyBtn = new System.Windows.Forms.ToolStripButton();
			this.cutBtn = new System.Windows.Forms.ToolStripButton();
			this.pasteBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.startBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.helpBtn = new System.Windows.Forms.ToolStripButton();
			this.infoBtn = new System.Windows.Forms.ToolStripButton();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.splitRichBoxContainer = new System.Windows.Forms.SplitContainer();
			this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
			this.inputRichBox = new System.Windows.Forms.RichTextBox();
			this.tabControlOutput = new System.Windows.Forms.TabControl();
			this.tabPageLexer = new System.Windows.Forms.TabPage();
			this.dataGridViewLexer = new System.Windows.Forms.DataGridView();
			this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LexerTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LexemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageParser = new System.Windows.Forms.TabPage();
			this.dataGridViewParser = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageLab6 = new System.Windows.Forms.TabPage();
			this.outputRichBox = new System.Windows.Forms.RichTextBox();
			this.statusStripLines = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelErrors = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelClean = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelMiddle = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelRow = new System.Windows.Forms.ToolStripStatusLabel();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.лабораторнаяРабота7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitRichBoxContainer)).BeginInit();
			this.splitRichBoxContainer.Panel1.SuspendLayout();
			this.splitRichBoxContainer.Panel2.SuspendLayout();
			this.splitRichBoxContainer.SuspendLayout();
			this.tabControlOutput.SuspendLayout();
			this.tabPageLexer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexer)).BeginInit();
			this.tabPageParser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewParser)).BeginInit();
			this.tabPageLab6.SuspendLayout();
			this.statusStripLines.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.остальныеЛРToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(1031, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.создатьToolStripMenuItem.Text = "Создать";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.СоздатьToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
			// 
			// сохранитьКакToolStripMenuItem
			// 
			this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
			this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
			this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.СохранитьКакToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
			// 
			// правкаToolStripMenuItem
			// 
			this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ОтменитьStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
			this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
			this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.правкаToolStripMenuItem.Text = "Правка";
			// 
			// ОтменитьStripMenuItem
			// 
			this.ОтменитьStripMenuItem.Name = "ОтменитьStripMenuItem";
			this.ОтменитьStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.ОтменитьStripMenuItem.Text = "Отменить";
			this.ОтменитьStripMenuItem.Click += new System.EventHandler(this.ОтменитьToolStripMenuItem_Click);
			// 
			// повторитьToolStripMenuItem
			// 
			this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
			this.повторитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.повторитьToolStripMenuItem.Text = "Повторить";
			this.повторитьToolStripMenuItem.Click += new System.EventHandler(this.ПовторитьToolStripMenuItem_Click);
			// 
			// вырезатьToolStripMenuItem
			// 
			this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
			this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.вырезатьToolStripMenuItem.Text = "Вырезать";
			this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.ВырезатьToolStripMenuItem_Click);
			// 
			// копироватьToolStripMenuItem
			// 
			this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
			this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.копироватьToolStripMenuItem.Text = "Копировать";
			this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.КопироватьToolStripMenuItem_Click);
			// 
			// вставитьToolStripMenuItem
			// 
			this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
			this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.вставитьToolStripMenuItem.Text = "Вставить";
			this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.ВставитьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItem_Click);
			// 
			// выделитьВсеToolStripMenuItem
			// 
			this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
			this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
			this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.ВыделитьВсеToolStripMenuItem_Click);
			// 
			// текстToolStripMenuItem
			// 
			this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постановкаЗадачиToolStripMenuItem,
            this.грамматикаToolStripMenuItem,
            this.классификацияграмматикиToolStripMenuItem,
            this.методанализаtoolStripMenuItem,
            this.диагностикаинейтрализацияошибокtoolStripMenuItem,
            this.тестовыйпримерtoolStripMenuItem,
            this.списоклитературыtoolStripMenuItem,
            this.исходныйкодпрограммыtoolStripMenuItem});
			this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
			this.текстToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.текстToolStripMenuItem.Text = "Текст";
			// 
			// постановкаЗадачиToolStripMenuItem
			// 
			this.постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
			this.постановкаЗадачиToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
			this.постановкаЗадачиToolStripMenuItem.Click += new System.EventHandler(this.постановкаЗадачиToolStripMenuItem_Click);
			// 
			// грамматикаToolStripMenuItem
			// 
			this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
			this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.грамматикаToolStripMenuItem.Text = "Грамматика";
			this.грамматикаToolStripMenuItem.Click += new System.EventHandler(this.грамматикаToolStripMenuItem_Click);
			// 
			// классификацияграмматикиToolStripMenuItem
			// 
			this.классификацияграмматикиToolStripMenuItem.Name = "классификацияграмматикиToolStripMenuItem";
			this.классификацияграмматикиToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.классификацияграмматикиToolStripMenuItem.Text = "Классификация грамматики";
			this.классификацияграмматикиToolStripMenuItem.Click += new System.EventHandler(this.классификацияграмматикиToolStripMenuItem_Click);
			// 
			// методанализаtoolStripMenuItem
			// 
			this.методанализаtoolStripMenuItem.Name = "методанализаtoolStripMenuItem";
			this.методанализаtoolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.методанализаtoolStripMenuItem.Text = "Метод анализа";
			this.методанализаtoolStripMenuItem.Click += new System.EventHandler(this.методанализаtoolStripMenuItem_Click);
			// 
			// диагностикаинейтрализацияошибокtoolStripMenuItem
			// 
			this.диагностикаинейтрализацияошибокtoolStripMenuItem.Name = "диагностикаинейтрализацияошибокtoolStripMenuItem";
			this.диагностикаинейтрализацияошибокtoolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.диагностикаинейтрализацияошибокtoolStripMenuItem.Text = "Диагностика и нейтрализация ошибок";
			this.диагностикаинейтрализацияошибокtoolStripMenuItem.Click += new System.EventHandler(this.диагностикаинейтрализацияошибокtoolStripMenuItem_Click);
			// 
			// тестовыйпримерtoolStripMenuItem
			// 
			this.тестовыйпримерtoolStripMenuItem.Name = "тестовыйпримерtoolStripMenuItem";
			this.тестовыйпримерtoolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.тестовыйпримерtoolStripMenuItem.Text = "Тестовый пример";
			this.тестовыйпримерtoolStripMenuItem.Click += new System.EventHandler(this.тестовыйпримерtoolStripMenuItem_Click);
			// 
			// списоклитературыtoolStripMenuItem
			// 
			this.списоклитературыtoolStripMenuItem.Name = "списоклитературыtoolStripMenuItem";
			this.списоклитературыtoolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.списоклитературыtoolStripMenuItem.Text = "Список литературы";
			this.списоклитературыtoolStripMenuItem.Click += new System.EventHandler(this.списоклитературыtoolStripMenuItem_Click);
			// 
			// исходныйкодпрограммыtoolStripMenuItem
			// 
			this.исходныйкодпрограммыtoolStripMenuItem.Name = "исходныйкодпрограммыtoolStripMenuItem";
			this.исходныйкодпрограммыtoolStripMenuItem.Size = new System.Drawing.Size(288, 22);
			this.исходныйкодпрограммыtoolStripMenuItem.Text = "Исходный код программы";
			this.исходныйкодпрограммыtoolStripMenuItem.Click += new System.EventHandler(this.исходныйкодпрограммыtoolStripMenuItem_Click);
			// 
			// пускToolStripMenuItem
			// 
			this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
			this.пускToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.пускToolStripMenuItem.Text = "Пуск";
			this.пускToolStripMenuItem.Click += new System.EventHandler(this.ПускToolStripMenuItem_Click);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызовСправкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// вызовСправкиToolStripMenuItem
			// 
			this.вызовСправкиToolStripMenuItem.Name = "вызовСправкиToolStripMenuItem";
			this.вызовСправкиToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.вызовСправкиToolStripMenuItem.Text = "Вызов справки";
			this.вызовСправкиToolStripMenuItem.Click += new System.EventHandler(this.ВызовСправкиToolStripMenuItem_Click);
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
			// 
			// видToolStripMenuItem
			// 
			this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьШрифтToolStripMenuItem});
			this.видToolStripMenuItem.Name = "видToolStripMenuItem";
			this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.видToolStripMenuItem.Text = "Вид";
			// 
			// изменитьШрифтToolStripMenuItem
			// 
			this.изменитьШрифтToolStripMenuItem.Name = "изменитьШрифтToolStripMenuItem";
			this.изменитьШрифтToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.изменитьШрифтToolStripMenuItem.Text = "Изменить шрифт";
			this.изменитьШрифтToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьШрифтToolStripMenuItem_Click);
			// 
			// остальныеЛРToolStripMenuItem
			// 
			this.остальныеЛРToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лабораторнаяРабота5ToolStripMenuItem,
            this.лабораторнаяРабота6ToolStripMenuItem,
            this.лабораторнаяРабота7ToolStripMenuItem});
			this.остальныеЛРToolStripMenuItem.Name = "остальныеЛРToolStripMenuItem";
			this.остальныеЛРToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.остальныеЛРToolStripMenuItem.Text = "Остальные ЛР";
			// 
			// лабораторнаяРабота5ToolStripMenuItem
			// 
			this.лабораторнаяРабота5ToolStripMenuItem.Name = "лабораторнаяРабота5ToolStripMenuItem";
			this.лабораторнаяРабота5ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.лабораторнаяРабота5ToolStripMenuItem.Text = "Лабораторная работа 5";
			this.лабораторнаяРабота5ToolStripMenuItem.Click += new System.EventHandler(this.лабораторнаяРабота5ToolStripMenuItem_Click);
			// 
			// лабораторнаяРабота6ToolStripMenuItem
			// 
			this.лабораторнаяРабота6ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.первыйБлокToolStripMenuItem,
            this.второйБлокToolStripMenuItem,
            this.третийБлокToolStripMenuItem});
			this.лабораторнаяРабота6ToolStripMenuItem.Name = "лабораторнаяРабота6ToolStripMenuItem";
			this.лабораторнаяРабота6ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.лабораторнаяРабота6ToolStripMenuItem.Text = "Лабораторная работа 6";
			// 
			// первыйБлокToolStripMenuItem
			// 
			this.первыйБлокToolStripMenuItem.Name = "первыйБлокToolStripMenuItem";
			this.первыйБлокToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.первыйБлокToolStripMenuItem.Text = "Первый блок";
			this.первыйБлокToolStripMenuItem.Click += new System.EventHandler(this.первыйБлокToolStripMenuItem_Click);
			// 
			// второйБлокToolStripMenuItem
			// 
			this.второйБлокToolStripMenuItem.Name = "второйБлокToolStripMenuItem";
			this.второйБлокToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.второйБлокToolStripMenuItem.Text = "Второй блок";
			this.второйБлокToolStripMenuItem.Click += new System.EventHandler(this.второйБлокToolStripMenuItem_Click);
			// 
			// третийБлокToolStripMenuItem
			// 
			this.третийБлокToolStripMenuItem.Name = "третийБлокToolStripMenuItem";
			this.третийБлокToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.третийБлокToolStripMenuItem.Text = "Третий блок";
			this.третийБлокToolStripMenuItem.Click += new System.EventHandler(this.третийБлокToolStripMenuItem_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.AutoSize = false;
			this.toolStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFileBtn,
            this.openFileBtn,
            this.saveFileBtn,
            this.toolStripSeparator1,
            this.undoBtn,
            this.redoBtn,
            this.toolStripSeparator2,
            this.copyBtn,
            this.cutBtn,
            this.pasteBtn,
            this.toolStripSeparator4,
            this.startBtn,
            this.toolStripSeparator3,
            this.helpBtn,
            this.infoBtn});
			this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(12, 5, 1, 0);
			this.toolStrip.Size = new System.Drawing.Size(1031, 56);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "controlPanel";
			// 
			// createFileBtn
			// 
			this.createFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.createFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("createFileBtn.Image")));
			this.createFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.createFileBtn.Name = "createFileBtn";
			this.createFileBtn.Size = new System.Drawing.Size(36, 36);
			this.createFileBtn.Text = "Создать";
			this.createFileBtn.ToolTipText = "Создать";
			this.createFileBtn.Click += new System.EventHandler(this.CreateFileBtn_Click);
			// 
			// openFileBtn
			// 
			this.openFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
			this.openFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openFileBtn.Name = "openFileBtn";
			this.openFileBtn.Size = new System.Drawing.Size(36, 36);
			this.openFileBtn.Text = "Открыть";
			this.openFileBtn.ToolTipText = "Открыть";
			this.openFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
			// 
			// saveFileBtn
			// 
			this.saveFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveFileBtn.Image")));
			this.saveFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveFileBtn.Name = "saveFileBtn";
			this.saveFileBtn.Size = new System.Drawing.Size(36, 36);
			this.saveFileBtn.Text = "Сохранить";
			this.saveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
			// 
			// undoBtn
			// 
			this.undoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.undoBtn.Image = ((System.Drawing.Image)(resources.GetObject("undoBtn.Image")));
			this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.undoBtn.Name = "undoBtn";
			this.undoBtn.Size = new System.Drawing.Size(36, 36);
			this.undoBtn.Text = "Отменить";
			this.undoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
			// 
			// redoBtn
			// 
			this.redoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.redoBtn.Image = ((System.Drawing.Image)(resources.GetObject("redoBtn.Image")));
			this.redoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.redoBtn.Name = "redoBtn";
			this.redoBtn.Size = new System.Drawing.Size(36, 36);
			this.redoBtn.Text = "Повторить";
			this.redoBtn.Click += new System.EventHandler(this.RedoBtn_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// copyBtn
			// 
			this.copyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyBtn.Image = ((System.Drawing.Image)(resources.GetObject("copyBtn.Image")));
			this.copyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyBtn.Name = "copyBtn";
			this.copyBtn.Size = new System.Drawing.Size(36, 36);
			this.copyBtn.Text = "Копировать";
			this.copyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
			// 
			// cutBtn
			// 
			this.cutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cutBtn.Image = ((System.Drawing.Image)(resources.GetObject("cutBtn.Image")));
			this.cutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutBtn.Name = "cutBtn";
			this.cutBtn.Size = new System.Drawing.Size(36, 36);
			this.cutBtn.Text = "Вырезать";
			this.cutBtn.Click += new System.EventHandler(this.CutBtn_Click);
			// 
			// pasteBtn
			// 
			this.pasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteBtn.Image")));
			this.pasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteBtn.Name = "pasteBtn";
			this.pasteBtn.Size = new System.Drawing.Size(36, 36);
			this.pasteBtn.Text = "Вставить";
			this.pasteBtn.Click += new System.EventHandler(this.PasteBtn_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AutoSize = false;
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
			// 
			// startBtn
			// 
			this.startBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.startBtn.Image = ((System.Drawing.Image)(resources.GetObject("startBtn.Image")));
			this.startBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(36, 36);
			this.startBtn.Text = "Пуск";
			this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AutoSize = false;
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
			// 
			// helpBtn
			// 
			this.helpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpBtn.Image = ((System.Drawing.Image)(resources.GetObject("helpBtn.Image")));
			this.helpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpBtn.Name = "helpBtn";
			this.helpBtn.Size = new System.Drawing.Size(36, 36);
			this.helpBtn.Text = "Вызов справки";
			this.helpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
			// 
			// infoBtn
			// 
			this.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.infoBtn.Image = ((System.Drawing.Image)(resources.GetObject("infoBtn.Image")));
			this.infoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.infoBtn.Name = "infoBtn";
			this.infoBtn.Size = new System.Drawing.Size(36, 36);
			this.infoBtn.Text = "О программе";
			this.infoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// splitRichBoxContainer
			// 
			this.splitRichBoxContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.splitRichBoxContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitRichBoxContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitRichBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitRichBoxContainer.ForeColor = System.Drawing.SystemColors.Control;
			this.splitRichBoxContainer.Location = new System.Drawing.Point(0, 80);
			this.splitRichBoxContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitRichBoxContainer.Name = "splitRichBoxContainer";
			this.splitRichBoxContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitRichBoxContainer.Panel1
			// 
			this.splitRichBoxContainer.Panel1.Controls.Add(this.LineNumberTextBox);
			this.splitRichBoxContainer.Panel1.Controls.Add(this.inputRichBox);
			this.splitRichBoxContainer.Panel1MinSize = 200;
			// 
			// splitRichBoxContainer.Panel2
			// 
			this.splitRichBoxContainer.Panel2.Controls.Add(this.tabControlOutput);
			this.splitRichBoxContainer.Panel2.Controls.Add(this.statusStripLines);
			this.splitRichBoxContainer.Panel2MinSize = 200;
			this.splitRichBoxContainer.Size = new System.Drawing.Size(1031, 524);
			this.splitRichBoxContainer.SplitterDistance = 200;
			this.splitRichBoxContainer.TabIndex = 0;
			// 
			// LineNumberTextBox
			// 
			this.LineNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.LineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LineNumberTextBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.LineNumberTextBox.DetectUrls = false;
			this.LineNumberTextBox.Enabled = false;
			this.LineNumberTextBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LineNumberTextBox.Location = new System.Drawing.Point(12, 11);
			this.LineNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.LineNumberTextBox.Name = "LineNumberTextBox";
			this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.LineNumberTextBox.Size = new System.Drawing.Size(38, 170);
			this.LineNumberTextBox.TabIndex = 3;
			this.LineNumberTextBox.TabStop = false;
			this.LineNumberTextBox.Text = "";
			// 
			// inputRichBox
			// 
			this.inputRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inputRichBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.inputRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputRichBox.Enabled = false;
			this.inputRichBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputRichBox.Location = new System.Drawing.Point(56, 11);
			this.inputRichBox.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
			this.inputRichBox.MinimumSize = new System.Drawing.Size(100, 0);
			this.inputRichBox.Name = "inputRichBox";
			this.inputRichBox.ReadOnly = true;
			this.inputRichBox.Size = new System.Drawing.Size(961, 170);
			this.inputRichBox.TabIndex = 2;
			this.inputRichBox.Text = "";
			this.inputRichBox.TextChanged += new System.EventHandler(this.InputRichBox_TextChanged);
			// 
			// tabControlOutput
			// 
			this.tabControlOutput.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControlOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlOutput.Controls.Add(this.tabPageLexer);
			this.tabControlOutput.Controls.Add(this.tabPageParser);
			this.tabControlOutput.Controls.Add(this.tabPageLab6);
			this.tabControlOutput.ItemSize = new System.Drawing.Size(80, 19);
			this.tabControlOutput.Location = new System.Drawing.Point(10, 3);
			this.tabControlOutput.Multiline = true;
			this.tabControlOutput.Name = "tabControlOutput";
			this.tabControlOutput.SelectedIndex = 0;
			this.tabControlOutput.Size = new System.Drawing.Size(1007, 290);
			this.tabControlOutput.TabIndex = 7;
			// 
			// tabPageLexer
			// 
			this.tabPageLexer.Controls.Add(this.dataGridViewLexer);
			this.tabPageLexer.Location = new System.Drawing.Point(4, 4);
			this.tabPageLexer.Name = "tabPageLexer";
			this.tabPageLexer.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLexer.Size = new System.Drawing.Size(999, 263);
			this.tabPageLexer.TabIndex = 0;
			this.tabPageLexer.Text = "Лексер";
			this.tabPageLexer.UseVisualStyleBackColor = true;
			// 
			// dataGridViewLexer
			// 
			this.dataGridViewLexer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewLexer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewLexer.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridViewLexer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewLexer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewLexer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLexer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeColumn,
            this.LexerTypeColumn,
            this.LexemColumn,
            this.LocationColumn});
			this.dataGridViewLexer.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewLexer.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewLexer.Name = "dataGridViewLexer";
			this.dataGridViewLexer.ReadOnly = true;
			this.dataGridViewLexer.RowHeadersVisible = false;
			this.dataGridViewLexer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewLexer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
			this.dataGridViewLexer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewLexer.Size = new System.Drawing.Size(999, 267);
			this.dataGridViewLexer.TabIndex = 6;
			// 
			// CodeColumn
			// 
			this.CodeColumn.FillWeight = 30.45685F;
			this.CodeColumn.HeaderText = "Условный код";
			this.CodeColumn.Name = "CodeColumn";
			this.CodeColumn.ReadOnly = true;
			// 
			// LexerTypeColumn
			// 
			this.LexerTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LexerTypeColumn.FillWeight = 151.6004F;
			this.LexerTypeColumn.HeaderText = "Тип лексемы";
			this.LexerTypeColumn.Name = "LexerTypeColumn";
			this.LexerTypeColumn.ReadOnly = true;
			// 
			// LexemColumn
			// 
			this.LexemColumn.FillWeight = 151.6004F;
			this.LexemColumn.HeaderText = "Лексема";
			this.LexemColumn.Name = "LexemColumn";
			this.LexemColumn.ReadOnly = true;
			// 
			// LocationColumn
			// 
			this.LocationColumn.FillWeight = 66.34232F;
			this.LocationColumn.HeaderText = "Местоположение";
			this.LocationColumn.Name = "LocationColumn";
			this.LocationColumn.ReadOnly = true;
			// 
			// tabPageParser
			// 
			this.tabPageParser.Controls.Add(this.dataGridViewParser);
			this.tabPageParser.Location = new System.Drawing.Point(4, 4);
			this.tabPageParser.Name = "tabPageParser";
			this.tabPageParser.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageParser.Size = new System.Drawing.Size(999, 263);
			this.tabPageParser.TabIndex = 1;
			this.tabPageParser.Text = "Парсер";
			this.tabPageParser.UseVisualStyleBackColor = true;
			// 
			// dataGridViewParser
			// 
			this.dataGridViewParser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewParser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewParser.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridViewParser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewParser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewParser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.dataGridViewParser.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewParser.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewParser.Name = "dataGridViewParser";
			this.dataGridViewParser.ReadOnly = true;
			this.dataGridViewParser.RowHeadersVisible = false;
			this.dataGridViewParser.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewParser.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
			this.dataGridViewParser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewParser.Size = new System.Drawing.Size(999, 267);
			this.dataGridViewParser.TabIndex = 7;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn1.FillWeight = 16.31657F;
			this.dataGridViewTextBoxColumn1.HeaderText = "№";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn3.FillWeight = 237.9982F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Неверный фрагмент";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn4.FillWeight = 45.68528F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Местоположение";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// tabPageLab6
			// 
			this.tabPageLab6.Controls.Add(this.outputRichBox);
			this.tabPageLab6.Location = new System.Drawing.Point(4, 4);
			this.tabPageLab6.Name = "tabPageLab6";
			this.tabPageLab6.Size = new System.Drawing.Size(999, 263);
			this.tabPageLab6.TabIndex = 2;
			this.tabPageLab6.Text = "ЛР6";
			this.tabPageLab6.UseVisualStyleBackColor = true;
			// 
			// outputRichBox
			// 
			this.outputRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.outputRichBox.Location = new System.Drawing.Point(0, 0);
			this.outputRichBox.Name = "outputRichBox";
			this.outputRichBox.ReadOnly = true;
			this.outputRichBox.Size = new System.Drawing.Size(999, 263);
			this.outputRichBox.TabIndex = 0;
			this.outputRichBox.Text = "";
			// 
			// statusStripLines
			// 
			this.statusStripLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelErrors,
            this.toolStripStatusLabelClean,
            this.toolStripStatusLabelMiddle,
            this.toolStripStatusLabelRow});
			this.statusStripLines.Location = new System.Drawing.Point(0, 296);
			this.statusStripLines.Name = "statusStripLines";
			this.statusStripLines.Size = new System.Drawing.Size(1029, 22);
			this.statusStripLines.TabIndex = 5;
			// 
			// toolStripStatusLabelErrors
			// 
			this.toolStripStatusLabelErrors.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripStatusLabelErrors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.toolStripStatusLabelErrors.Name = "toolStripStatusLabelErrors";
			this.toolStripStatusLabelErrors.Size = new System.Drawing.Size(142, 17);
			this.toolStripStatusLabelErrors.Text = "Ошибок не обнаружено";
			this.toolStripStatusLabelErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabelClean
			// 
			this.toolStripStatusLabelClean.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripStatusLabelClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.toolStripStatusLabelClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStatusLabelClean.Name = "toolStripStatusLabelClean";
			this.toolStripStatusLabelClean.Size = new System.Drawing.Size(0, 17);
			this.toolStripStatusLabelClean.Text = "toolStripStatusLabel1";
			this.toolStripStatusLabelClean.Click += new System.EventHandler(this.toolStripStatusLabelClean_Click);
			// 
			// toolStripStatusLabelMiddle
			// 
			this.toolStripStatusLabelMiddle.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripStatusLabelMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.toolStripStatusLabelMiddle.Name = "toolStripStatusLabelMiddle";
			this.toolStripStatusLabelMiddle.Size = new System.Drawing.Size(764, 17);
			this.toolStripStatusLabelMiddle.Spring = true;
			this.toolStripStatusLabelMiddle.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabelRow
			// 
			this.toolStripStatusLabelRow.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripStatusLabelRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.toolStripStatusLabelRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.toolStripStatusLabelRow.Name = "toolStripStatusLabelRow";
			this.toolStripStatusLabelRow.Size = new System.Drawing.Size(108, 17);
			this.toolStripStatusLabelRow.Text = "Строка:   Столбец:";
			this.toolStripStatusLabelRow.ToolTipText = "Готово";
			// 
			// лабораторнаяРабота7ToolStripMenuItem
			// 
			this.лабораторнаяРабота7ToolStripMenuItem.Name = "лабораторнаяРабота7ToolStripMenuItem";
			this.лабораторнаяРабота7ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.лабораторнаяРабота7ToolStripMenuItem.Text = "Лабораторная работа 7";
			this.лабораторнаяРабота7ToolStripMenuItem.Click += new System.EventHandler(this.лабораторнаяРабота7ToolStripMenuItem_Click);
			// 
			// CompilerApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 604);
			this.Controls.Add(this.splitRichBoxContainer);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(744, 514);
			this.Name = "CompilerApp";
			this.Text = "Компилятор";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.splitRichBoxContainer.Panel1.ResumeLayout(false);
			this.splitRichBoxContainer.Panel2.ResumeLayout(false);
			this.splitRichBoxContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitRichBoxContainer)).EndInit();
			this.splitRichBoxContainer.ResumeLayout(false);
			this.tabControlOutput.ResumeLayout(false);
			this.tabPageLexer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexer)).EndInit();
			this.tabPageParser.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewParser)).EndInit();
			this.tabPageLab6.ResumeLayout(false);
			this.statusStripLines.ResumeLayout(false);
			this.statusStripLines.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem постановкаЗадачиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ОтменитьStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem повторитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вызовСправкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem классификацияграмматикиToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton createFileBtn;
		private System.Windows.Forms.ToolStripButton openFileBtn;
		private System.Windows.Forms.ToolStripButton saveFileBtn;
		private System.Windows.Forms.ToolStripButton undoBtn;
		private System.Windows.Forms.ToolStripButton redoBtn;
		private System.Windows.Forms.ToolStripButton copyBtn;
		private System.Windows.Forms.ToolStripButton cutBtn;
		private System.Windows.Forms.ToolStripButton pasteBtn;
		private System.Windows.Forms.ToolStripButton startBtn;
		private System.Windows.Forms.ToolStripButton helpBtn;
		private System.Windows.Forms.ToolStripButton infoBtn;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripMenuItem методанализаtoolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem диагностикаинейтрализацияошибокtoolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem тестовыйпримерtoolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списоклитературыtoolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem исходныйкодпрограммыtoolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripSeparator toolStripSeparator3;
		private SplitContainer splitRichBoxContainer;
		private RichTextBox inputRichBox;
		private RichTextBox LineNumberTextBox;
		private StatusStrip statusStripLines;
		private DataGridView dataGridViewLexer;
		private FontDialog fontDialog;
		private ToolStripMenuItem видToolStripMenuItem;
		private ToolStripMenuItem изменитьШрифтToolStripMenuItem;
		private TabControl tabControlOutput;
		private TabPage tabPageLexer;
		private TabPage tabPageParser;
		private DataGridView dataGridViewParser;
		private ToolStripStatusLabel toolStripStatusLabelErrors;
		private ToolStripStatusLabel toolStripStatusLabelMiddle;
		private ToolStripStatusLabel toolStripStatusLabelRow;
		private ToolStripStatusLabel toolStripStatusLabelClean;
		private DataGridViewTextBoxColumn CodeColumn;
		private DataGridViewTextBoxColumn LexerTypeColumn;
		private DataGridViewTextBoxColumn LexemColumn;
		private DataGridViewTextBoxColumn LocationColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private TabPage tabPageLab6;
		private RichTextBox outputRichBox;
		private ToolStripMenuItem остальныеЛРToolStripMenuItem;
		private ToolStripMenuItem лабораторнаяРабота5ToolStripMenuItem;
		private ToolStripMenuItem лабораторнаяРабота6ToolStripMenuItem;
		private ToolStripMenuItem первыйБлокToolStripMenuItem;
		private ToolStripMenuItem второйБлокToolStripMenuItem;
		private ToolStripMenuItem третийБлокToolStripMenuItem;
		private ToolStripMenuItem лабораторнаяРабота7ToolStripMenuItem;
	}
}

