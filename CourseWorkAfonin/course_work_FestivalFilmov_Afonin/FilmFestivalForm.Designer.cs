namespace course_work_FestivalFilmov_Afonin
{
    partial class FilmFestivalForm
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
            this.dataGridViewFilmTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCountFilm = new System.Windows.Forms.Label();
            this.TextBoxCountFilm = new System.Windows.Forms.TextBox();
            this.ButtonCreateFilm = new System.Windows.Forms.Button();
            this.ButtonDeleteFilm = new System.Windows.Forms.Button();
            this.ButtonAllDeleteFilm = new System.Windows.Forms.Button();
            this.ButtonCloseFilmTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFilmTable
            // 
            this.dataGridViewFilmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewFilmTable.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewFilmTable.Name = "dataGridViewFilmTable";
            this.dataGridViewFilmTable.ReadOnly = true;
            this.dataGridViewFilmTable.RowHeadersWidth = 51;
            this.dataGridViewFilmTable.RowTemplate.Height = 24;
            this.dataGridViewFilmTable.Size = new System.Drawing.Size(737, 325);
            this.dataGridViewFilmTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название фильма";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номинация фильма";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена билета на фестиваль";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Рейтинг фильма";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // labelCountFilm
            // 
            this.labelCountFilm.AutoSize = true;
            this.labelCountFilm.Location = new System.Drawing.Point(12, 385);
            this.labelCountFilm.Name = "labelCountFilm";
            this.labelCountFilm.Size = new System.Drawing.Size(147, 16);
            this.labelCountFilm.TabIndex = 1;
            this.labelCountFilm.Text = "Количество фильмов";
            // 
            // TextBoxCountFilm
            // 
            this.TextBoxCountFilm.Location = new System.Drawing.Point(187, 385);
            this.TextBoxCountFilm.Name = "TextBoxCountFilm";
            this.TextBoxCountFilm.Size = new System.Drawing.Size(113, 22);
            this.TextBoxCountFilm.TabIndex = 2;
            // 
            // ButtonCreateFilm
            // 
            this.ButtonCreateFilm.Location = new System.Drawing.Point(780, 41);
            this.ButtonCreateFilm.Name = "ButtonCreateFilm";
            this.ButtonCreateFilm.Size = new System.Drawing.Size(123, 48);
            this.ButtonCreateFilm.TabIndex = 3;
            this.ButtonCreateFilm.Text = "Добавить фильм";
            this.ButtonCreateFilm.UseVisualStyleBackColor = true;
            this.ButtonCreateFilm.Click += new System.EventHandler(this.ButtonCreateFilm_Click);
            // 
            // ButtonDeleteFilm
            // 
            this.ButtonDeleteFilm.Location = new System.Drawing.Point(780, 122);
            this.ButtonDeleteFilm.Name = "ButtonDeleteFilm";
            this.ButtonDeleteFilm.Size = new System.Drawing.Size(123, 48);
            this.ButtonDeleteFilm.TabIndex = 4;
            this.ButtonDeleteFilm.Text = "Удалить фильм";
            this.ButtonDeleteFilm.UseVisualStyleBackColor = true;
            this.ButtonDeleteFilm.Click += new System.EventHandler(this.ButtonDeleteFilm_Click);
            // 
            // ButtonAllDeleteFilm
            // 
            this.ButtonAllDeleteFilm.Location = new System.Drawing.Point(780, 205);
            this.ButtonAllDeleteFilm.Name = "ButtonAllDeleteFilm";
            this.ButtonAllDeleteFilm.Size = new System.Drawing.Size(123, 48);
            this.ButtonAllDeleteFilm.TabIndex = 5;
            this.ButtonAllDeleteFilm.Text = "Удалить все фильмы";
            this.ButtonAllDeleteFilm.UseVisualStyleBackColor = true;
            this.ButtonAllDeleteFilm.Click += new System.EventHandler(this.ButtonAllDeleteFilm_Click);
            // 
            // ButtonCloseFilmTable
            // 
            this.ButtonCloseFilmTable.Location = new System.Drawing.Point(790, 447);
            this.ButtonCloseFilmTable.Name = "ButtonCloseFilmTable";
            this.ButtonCloseFilmTable.Size = new System.Drawing.Size(123, 48);
            this.ButtonCloseFilmTable.TabIndex = 6;
            this.ButtonCloseFilmTable.Text = "Закрыть форму";
            this.ButtonCloseFilmTable.UseVisualStyleBackColor = true;
            this.ButtonCloseFilmTable.Click += new System.EventHandler(this.ButtonCloseFilmTable_Click);
            // 
            // FilmFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 497);
            this.Controls.Add(this.ButtonCloseFilmTable);
            this.Controls.Add(this.ButtonAllDeleteFilm);
            this.Controls.Add(this.ButtonDeleteFilm);
            this.Controls.Add(this.ButtonCreateFilm);
            this.Controls.Add(this.TextBoxCountFilm);
            this.Controls.Add(this.labelCountFilm);
            this.Controls.Add(this.dataGridViewFilmTable);
            this.Name = "FilmFestivalForm";
            this.Text = "FilmFestivalForm";
            this.Load += new System.EventHandler(this.FilmFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilmTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label labelCountFilm;
        private System.Windows.Forms.TextBox TextBoxCountFilm;
        private System.Windows.Forms.Button ButtonCreateFilm;
        private System.Windows.Forms.Button ButtonDeleteFilm;
        private System.Windows.Forms.Button ButtonAllDeleteFilm;
        private System.Windows.Forms.Button ButtonCloseFilmTable;
    }
}