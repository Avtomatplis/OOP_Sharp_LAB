namespace lab_4
{
    partial class LINQWindow
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
            this.Close = new System.Windows.Forms.Button();
            this.PrintCollection = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfChildren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortCollection = new System.Windows.Forms.Button();
            this.InsertToFile = new System.Windows.Forms.Button();
            this.LINQ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(925, 585);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(125, 44);
            this.Close.TabIndex = 0;
            this.Close.Text = "Закрыть форму";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PrintCollection
            // 
            this.PrintCollection.Location = new System.Drawing.Point(12, 585);
            this.PrintCollection.Name = "PrintCollection";
            this.PrintCollection.Size = new System.Drawing.Size(125, 44);
            this.PrintCollection.TabIndex = 1;
            this.PrintCollection.Text = "Вывести содержимое ";
            this.PrintCollection.UseVisualStyleBackColor = true;
            this.PrintCollection.Click += new System.EventHandler(this.PrintCollection_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridName,
            this.LastName,
            this.Age,
            this.City,
            this.Height,
            this.Weight,
            this.NumberOfChildren});
            this.dataGridView1.Location = new System.Drawing.Point(11, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 206);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GridName
            // 
            this.GridName.HeaderText = "Имя";
            this.GridName.MinimumWidth = 6;
            this.GridName.Name = "GridName";
            this.GridName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // Height
            // 
            this.Height.HeaderText = "Рост";
            this.Height.MinimumWidth = 6;
            this.Height.Name = "Height";
            this.Height.Width = 125;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Вес";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.Width = 125;
            // 
            // NumberOfChildren
            // 
            this.NumberOfChildren.HeaderText = "Кол-во детей";
            this.NumberOfChildren.MinimumWidth = 6;
            this.NumberOfChildren.Name = "NumberOfChildren";
            this.NumberOfChildren.Width = 125;
            // 
            // SortCollection
            // 
            this.SortCollection.Location = new System.Drawing.Point(173, 585);
            this.SortCollection.Name = "SortCollection";
            this.SortCollection.Size = new System.Drawing.Size(125, 44);
            this.SortCollection.TabIndex = 3;
            this.SortCollection.Text = "Отсортировать коллекцию";
            this.SortCollection.UseVisualStyleBackColor = true;
            this.SortCollection.Click += new System.EventHandler(this.SortCollection_Click);
            // 
            // InsertToFile
            // 
            this.InsertToFile.Location = new System.Drawing.Point(318, 585);
            this.InsertToFile.Name = "InsertToFile";
            this.InsertToFile.Size = new System.Drawing.Size(125, 44);
            this.InsertToFile.TabIndex = 4;
            this.InsertToFile.Text = "Добавить в файл";
            this.InsertToFile.UseVisualStyleBackColor = true;
            this.InsertToFile.Click += new System.EventHandler(this.InsertToFile_Click);
            // 
            // LINQ
            // 
            this.LINQ.Location = new System.Drawing.Point(461, 585);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(125, 44);
            this.LINQ.TabIndex = 5;
            this.LINQ.Text = "Выполнить LINQ запросы";
            this.LINQ.UseVisualStyleBackColor = true;
            this.LINQ.Click += new System.EventHandler(this.LINQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "--";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "_humans.GetList().Where(human=>human.Age>2).Reverse().First();";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Linq запросы";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 305);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(480, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "_humans.GetList().Skip(2).Take(3).All(human=>human.NumberOfChildren==0);";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "--";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 333);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(639, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "_humans.GetList().SkipWhile(human => human.Height < 167).TakeWhile(human => human" +
    ".Age > 0).Count();";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "--";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 361);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(539, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "_humans.GetList().OrderBy(human=>human.Name).Take(1).Sum(human=>human.Age);";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "--";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(141, 389);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(581, 22);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "_humans.GetList().Where(human=>human.Age > 0).TakeWhile(human=>human.Age<100).Any" +
    "();";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "--";
            // 
            // LINQWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 641);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.InsertToFile);
            this.Controls.Add(this.SortCollection);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PrintCollection);
            this.Controls.Add(this.Close);
            this.Name = "LINQWindow";
            this.Text = "Linq Window";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button PrintCollection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn newName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nName;
        private System.Windows.Forms.Button SortCollection;
        private System.Windows.Forms.Button InsertToFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfChildren;
        private System.Windows.Forms.Button LINQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
    }
}