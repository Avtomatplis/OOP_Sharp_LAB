
namespace lab_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CreateObject = new System.Windows.Forms.Button();
            this.CloseProject = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfChildren = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.NumericUpDown();
            this.NumberOfObjects = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CreateException = new System.Windows.Forms.Button();
            this.SeeObject = new System.Windows.Forms.Button();
            this.deleteObject = new System.Windows.Forms.Button();
            this.PrintAll = new System.Windows.Forms.Button();
            this.ShowTime = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenerateObject = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LinqForm = new System.Windows.Forms.Button();
            this.StringForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateObject
            // 
            this.CreateObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateObject.BackColor = System.Drawing.Color.Cornsilk;
            this.CreateObject.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateObject.ForeColor = System.Drawing.Color.Red;
            this.CreateObject.Location = new System.Drawing.Point(917, 219);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(190, 43);
            this.CreateObject.TabIndex = 0;
            this.CreateObject.Text = "Создать обьект";
            this.CreateObject.UseVisualStyleBackColor = false;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // CloseProject
            // 
            this.CloseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseProject.BackColor = System.Drawing.Color.Cyan;
            this.CloseProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseProject.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CloseProject.Location = new System.Drawing.Point(917, 491);
            this.CloseProject.Name = "CloseProject";
            this.CloseProject.Size = new System.Drawing.Size(190, 36);
            this.CloseProject.TabIndex = 4;
            this.CloseProject.Text = "Закрыть проект";
            this.CloseProject.UseVisualStyleBackColor = false;
            this.CloseProject.Click += new System.EventHandler(this.CloseProject_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.Wheat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(753, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Change
            // 
            this.Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Change.BackColor = System.Drawing.Color.Cyan;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.ForeColor = System.Drawing.Color.Indigo;
            this.Change.Location = new System.Drawing.Point(12, 467);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(169, 51);
            this.Change.TabIndex = 6;
            this.Change.Text = "Изменить объект";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(898, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // NewName
            // 
            this.NewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewName.Location = new System.Drawing.Point(988, 8);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(100, 22);
            this.NewName.TabIndex = 8;
            // 
            // SecondName
            // 
            this.SecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondName.Location = new System.Drawing.Point(988, 36);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(100, 22);
            this.SecondName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(898, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // Country
            // 
            this.Country.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Country.Location = new System.Drawing.Point(988, 64);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(100, 22);
            this.Country.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(898, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(839, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество детей";
            // 
            // Age
            // 
            this.Age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Age.Location = new System.Drawing.Point(988, 93);
            this.Age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(120, 22);
            this.Age.TabIndex = 14;
            this.Age.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // Height
            // 
            this.Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Height.Location = new System.Drawing.Point(988, 121);
            this.Height.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(120, 22);
            this.Height.TabIndex = 16;
            this.Height.Value = new decimal(new int[] {
            176,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(898, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Рост";
            // 
            // NumberOfChildren
            // 
            this.NumberOfChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfChildren.Location = new System.Drawing.Point(988, 149);
            this.NumberOfChildren.Name = "NumberOfChildren";
            this.NumberOfChildren.Size = new System.Drawing.Size(120, 22);
            this.NumberOfChildren.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(884, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Возраст";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(898, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Вес";
            // 
            // Weight
            // 
            this.Weight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Weight.Location = new System.Drawing.Point(988, 182);
            this.Weight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(120, 22);
            this.Weight.TabIndex = 20;
            this.Weight.Value = new decimal(new int[] {
            76,
            0,
            0,
            0});
            this.Weight.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // NumberOfObjects
            // 
            this.NumberOfObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfObjects.AutoSize = true;
            this.NumberOfObjects.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfObjects.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NumberOfObjects.Location = new System.Drawing.Point(884, 283);
            this.NumberOfObjects.Name = "NumberOfObjects";
            this.NumberOfObjects.Size = new System.Drawing.Size(166, 16);
            this.NumberOfObjects.TabIndex = 21;
            this.NumberOfObjects.Text = "Добавлено обьектов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 22;
            // 
            // CreateException
            // 
            this.CreateException.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateException.BackColor = System.Drawing.SystemColors.Desktop;
            this.CreateException.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateException.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateException.Location = new System.Drawing.Point(615, 478);
            this.CreateException.Name = "CreateException";
            this.CreateException.Size = new System.Drawing.Size(119, 49);
            this.CreateException.TabIndex = 23;
            this.CreateException.Text = "Не нажимать";
            this.CreateException.UseVisualStyleBackColor = false;
            this.CreateException.Click += new System.EventHandler(this.CreateException_Click);
            // 
            // SeeObject
            // 
            this.SeeObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SeeObject.BackColor = System.Drawing.Color.Lime;
            this.SeeObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeObject.ForeColor = System.Drawing.Color.Blue;
            this.SeeObject.Location = new System.Drawing.Point(206, 467);
            this.SeeObject.Name = "SeeObject";
            this.SeeObject.Size = new System.Drawing.Size(169, 51);
            this.SeeObject.TabIndex = 24;
            this.SeeObject.Text = "Показать объект";
            this.SeeObject.UseVisualStyleBackColor = false;
            this.SeeObject.Click += new System.EventHandler(this.SeeObject_Click);
            // 
            // deleteObject
            // 
            this.deleteObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteObject.BackColor = System.Drawing.Color.Gold;
            this.deleteObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteObject.ForeColor = System.Drawing.Color.Red;
            this.deleteObject.Location = new System.Drawing.Point(206, 387);
            this.deleteObject.Name = "deleteObject";
            this.deleteObject.Size = new System.Drawing.Size(169, 51);
            this.deleteObject.TabIndex = 25;
            this.deleteObject.Text = "Удалить обьект";
            this.deleteObject.UseVisualStyleBackColor = false;
            this.deleteObject.Click += new System.EventHandler(this.deleteObject_Click);
            // 
            // PrintAll
            // 
            this.PrintAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintAll.BackColor = System.Drawing.Color.DarkOrange;
            this.PrintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintAll.ForeColor = System.Drawing.Color.DarkBlue;
            this.PrintAll.Location = new System.Drawing.Point(12, 387);
            this.PrintAll.Name = "PrintAll";
            this.PrintAll.Size = new System.Drawing.Size(169, 51);
            this.PrintAll.TabIndex = 26;
            this.PrintAll.Text = "Вывести все";
            this.PrintAll.UseVisualStyleBackColor = false;
            this.PrintAll.Click += new System.EventHandler(this.PrintAll_Click);
            // 
            // ShowTime
            // 
            this.ShowTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowTime.BackColor = System.Drawing.Color.Crimson;
            this.ShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTime.ForeColor = System.Drawing.Color.Cornsilk;
            this.ShowTime.Location = new System.Drawing.Point(546, 120);
            this.ShowTime.Name = "ShowTime";
            this.ShowTime.Size = new System.Drawing.Size(188, 51);
            this.ShowTime.TabIndex = 27;
            this.ShowTime.Text = "Замер производительности";
            this.ShowTime.UseVisualStyleBackColor = false;
            this.ShowTime.Click += new System.EventHandler(this.ShowTime_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(366, 8);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(489, 107);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Выборка";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stack";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Array";
            this.columnHeader3.Width = 110;
            // 
            // GenerateObject
            // 
            this.GenerateObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateObject.Location = new System.Drawing.Point(917, 338);
            this.GenerateObject.Name = "GenerateObject";
            this.GenerateObject.Size = new System.Drawing.Size(187, 45);
            this.GenerateObject.TabIndex = 29;
            this.GenerateObject.Text = "Сгенерировать объект";
            this.GenerateObject.UseVisualStyleBackColor = true;
            this.GenerateObject.Click += new System.EventHandler(this.GenerateObject_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(720, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 27);
            this.label9.TabIndex = 30;
            this.label9.Text = "Выберите объект";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(12, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Информация об объекте";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(917, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 45);
            this.button1.TabIndex = 32;
            this.button1.Text = "Очистить всё";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LinqForm
            // 
            this.LinqForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LinqForm.Location = new System.Drawing.Point(579, 427);
            this.LinqForm.Name = "LinqForm";
            this.LinqForm.Size = new System.Drawing.Size(187, 45);
            this.LinqForm.TabIndex = 33;
            this.LinqForm.Text = "LINQ Form";
            this.LinqForm.UseVisualStyleBackColor = true;
            this.LinqForm.Click += new System.EventHandler(this.LinqForm_Click);
            // 
            // StringForm
            // 
            this.StringForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StringForm.Location = new System.Drawing.Point(579, 376);
            this.StringForm.Name = "StringForm";
            this.StringForm.Size = new System.Drawing.Size(187, 45);
            this.StringForm.TabIndex = 34;
            this.StringForm.Text = "String Collection Form";
            this.StringForm.UseVisualStyleBackColor = true;
            this.StringForm.Click += new System.EventHandler(this.StringForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1119, 539);
            this.Controls.Add(this.StringForm);
            this.Controls.Add(this.LinqForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GenerateObject);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ShowTime);
            this.Controls.Add(this.PrintAll);
            this.Controls.Add(this.deleteObject);
            this.Controls.Add(this.SeeObject);
            this.Controls.Add(this.CreateException);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberOfObjects);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfChildren);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CloseProject);
            this.Controls.Add(this.CreateObject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа№2 Жигалов Бобков";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.Button CloseProject;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumberOfChildren;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Weight;
        private System.Windows.Forms.Label NumberOfObjects;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CreateException;
        private System.Windows.Forms.Button SeeObject;
        private System.Windows.Forms.Button deleteObject;
        private System.Windows.Forms.Button PrintAll;
        private System.Windows.Forms.Button ShowTime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button GenerateObject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LinqForm;
        private System.Windows.Forms.Button StringForm;
    }
}

