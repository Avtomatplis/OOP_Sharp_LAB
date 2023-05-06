namespace course_work_FestivalFilmov_Afonin
{
    partial class JuryFestivalForm
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
            this.ButtonCloseJuryTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteJury = new System.Windows.Forms.Button();
            this.ButtonDeleteJury = new System.Windows.Forms.Button();
            this.ButtonCreateJury = new System.Windows.Forms.Button();
            this.TextBoxCountJury = new System.Windows.Forms.TextBox();
            this.labelCountJury = new System.Windows.Forms.Label();
            this.dataGridViewJuryTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCloseJuryTable
            // 
            this.ButtonCloseJuryTable.Location = new System.Drawing.Point(636, 426);
            this.ButtonCloseJuryTable.Name = "ButtonCloseJuryTable";
            this.ButtonCloseJuryTable.Size = new System.Drawing.Size(123, 48);
            this.ButtonCloseJuryTable.TabIndex = 13;
            this.ButtonCloseJuryTable.Text = "Закрыть форму";
            this.ButtonCloseJuryTable.UseVisualStyleBackColor = true;
            this.ButtonCloseJuryTable.Click += new System.EventHandler(this.ButtonCloseJuryTable_Click);
            // 
            // ButtonAllDeleteJury
            // 
            this.ButtonAllDeleteJury.Location = new System.Drawing.Point(636, 191);
            this.ButtonAllDeleteJury.Name = "ButtonAllDeleteJury";
            this.ButtonAllDeleteJury.Size = new System.Drawing.Size(123, 48);
            this.ButtonAllDeleteJury.TabIndex = 12;
            this.ButtonAllDeleteJury.Text = "Удалить всех членов жюри";
            this.ButtonAllDeleteJury.UseVisualStyleBackColor = true;
            this.ButtonAllDeleteJury.Click += new System.EventHandler(this.ButtonAllDeleteJury_Click);
            // 
            // ButtonDeleteJury
            // 
            this.ButtonDeleteJury.Location = new System.Drawing.Point(636, 108);
            this.ButtonDeleteJury.Name = "ButtonDeleteJury";
            this.ButtonDeleteJury.Size = new System.Drawing.Size(123, 48);
            this.ButtonDeleteJury.TabIndex = 11;
            this.ButtonDeleteJury.Text = "Удалить члена жюри";
            this.ButtonDeleteJury.UseVisualStyleBackColor = true;
            this.ButtonDeleteJury.Click += new System.EventHandler(this.ButtonDeleteJury_Click);
            // 
            // ButtonCreateJury
            // 
            this.ButtonCreateJury.Location = new System.Drawing.Point(636, 27);
            this.ButtonCreateJury.Name = "ButtonCreateJury";
            this.ButtonCreateJury.Size = new System.Drawing.Size(123, 48);
            this.ButtonCreateJury.TabIndex = 10;
            this.ButtonCreateJury.Text = "Добавить члена жюри";
            this.ButtonCreateJury.UseVisualStyleBackColor = true;
            this.ButtonCreateJury.Click += new System.EventHandler(this.ButtonCreateJury_Click);
            // 
            // TextBoxCountJury
            // 
            this.TextBoxCountJury.Location = new System.Drawing.Point(200, 377);
            this.TextBoxCountJury.Name = "TextBoxCountJury";
            this.TextBoxCountJury.Size = new System.Drawing.Size(113, 22);
            this.TextBoxCountJury.TabIndex = 9;
            // 
            // labelCountJury
            // 
            this.labelCountJury.AutoSize = true;
            this.labelCountJury.Location = new System.Drawing.Point(11, 380);
            this.labelCountJury.Name = "labelCountJury";
            this.labelCountJury.Size = new System.Drawing.Size(174, 16);
            this.labelCountJury.TabIndex = 8;
            this.labelCountJury.Text = "Количество членов жюри";
            // 
            // dataGridViewJuryTable
            // 
            this.dataGridViewJuryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJuryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewJuryTable.Location = new System.Drawing.Point(11, 7);
            this.dataGridViewJuryTable.Name = "dataGridViewJuryTable";
            this.dataGridViewJuryTable.ReadOnly = true;
            this.dataGridViewJuryTable.RowHeadersWidth = 51;
            this.dataGridViewJuryTable.RowTemplate.Height = 24;
            this.dataGridViewJuryTable.Size = new System.Drawing.Size(572, 325);
            this.dataGridViewJuryTable.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя члена жюри";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия члена жюри";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Должность члена жюри";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // JuryFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 486);
            this.Controls.Add(this.ButtonCloseJuryTable);
            this.Controls.Add(this.ButtonAllDeleteJury);
            this.Controls.Add(this.ButtonDeleteJury);
            this.Controls.Add(this.ButtonCreateJury);
            this.Controls.Add(this.TextBoxCountJury);
            this.Controls.Add(this.labelCountJury);
            this.Controls.Add(this.dataGridViewJuryTable);
            this.Name = "JuryFestivalForm";
            this.Text = "JuryFestivalForm";
            this.Load += new System.EventHandler(this.JuryFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseJuryTable;
        private System.Windows.Forms.Button ButtonAllDeleteJury;
        private System.Windows.Forms.Button ButtonDeleteJury;
        private System.Windows.Forms.Button ButtonCreateJury;
        private System.Windows.Forms.TextBox TextBoxCountJury;
        private System.Windows.Forms.Label labelCountJury;
        private System.Windows.Forms.DataGridView dataGridViewJuryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}