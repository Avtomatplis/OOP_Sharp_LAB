namespace course_work_FestivalFilmov_Afonin
{
    partial class FilmForm
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
            this.labelNameFilm = new System.Windows.Forms.Label();
            this.TextBoxNameFilm = new System.Windows.Forms.TextBox();
            this.labelRatingFilm = new System.Windows.Forms.Label();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.labelNominationFilm = new System.Windows.Forms.Label();
            this.ComboBoxNominationFilm = new System.Windows.Forms.ComboBox();
            this.NumericUpDownTicketPrice = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxRatingFilm = new System.Windows.Forms.ComboBox();
            this.labelPrimerNameFilm = new System.Windows.Forms.Label();
            this.labelHintNominationFilm = new System.Windows.Forms.Label();
            this.labelHintRatingFilm = new System.Windows.Forms.Label();
            this.ButtonCreateFilm = new System.Windows.Forms.Button();
            this.ButtonCloseFilmForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameFilm
            // 
            this.labelNameFilm.AutoSize = true;
            this.labelNameFilm.Location = new System.Drawing.Point(39, 32);
            this.labelNameFilm.Name = "labelNameFilm";
            this.labelNameFilm.Size = new System.Drawing.Size(127, 16);
            this.labelNameFilm.TabIndex = 0;
            this.labelNameFilm.Text = "Название фильма";
            // 
            // TextBoxNameFilm
            // 
            this.TextBoxNameFilm.Location = new System.Drawing.Point(299, 26);
            this.TextBoxNameFilm.Name = "TextBoxNameFilm";
            this.TextBoxNameFilm.Size = new System.Drawing.Size(145, 22);
            this.TextBoxNameFilm.TabIndex = 1;
            // 
            // labelRatingFilm
            // 
            this.labelRatingFilm.AutoSize = true;
            this.labelRatingFilm.Location = new System.Drawing.Point(39, 164);
            this.labelRatingFilm.Name = "labelRatingFilm";
            this.labelRatingFilm.Size = new System.Drawing.Size(110, 16);
            this.labelRatingFilm.TabIndex = 2;
            this.labelRatingFilm.Text = "Оценка фильма";
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Location = new System.Drawing.Point(39, 119);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(246, 16);
            this.labelTicketPrice.TabIndex = 3;
            this.labelTicketPrice.Text = "Цена билета на фестиваль фильмов";
            // 
            // labelNominationFilm
            // 
            this.labelNominationFilm.AutoSize = true;
            this.labelNominationFilm.Location = new System.Drawing.Point(39, 74);
            this.labelNominationFilm.Name = "labelNominationFilm";
            this.labelNominationFilm.Size = new System.Drawing.Size(135, 16);
            this.labelNominationFilm.TabIndex = 4;
            this.labelNominationFilm.Text = "Номинация фильма";
            // 
            // ComboBoxNominationFilm
            // 
            this.ComboBoxNominationFilm.FormattingEnabled = true;
            this.ComboBoxNominationFilm.Items.AddRange(new object[] {
            "Самый романтичный",
            "Самый смешной"});
            this.ComboBoxNominationFilm.Location = new System.Drawing.Point(299, 71);
            this.ComboBoxNominationFilm.Name = "ComboBoxNominationFilm";
            this.ComboBoxNominationFilm.Size = new System.Drawing.Size(145, 24);
            this.ComboBoxNominationFilm.TabIndex = 5;
            // 
            // NumericUpDownTicketPrice
            // 
            this.NumericUpDownTicketPrice.Location = new System.Drawing.Point(299, 117);
            this.NumericUpDownTicketPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownTicketPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownTicketPrice.Name = "NumericUpDownTicketPrice";
            this.NumericUpDownTicketPrice.Size = new System.Drawing.Size(145, 22);
            this.NumericUpDownTicketPrice.TabIndex = 6;
            this.NumericUpDownTicketPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ComboBoxRatingFilm
            // 
            this.ComboBoxRatingFilm.FormattingEnabled = true;
            this.ComboBoxRatingFilm.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBoxRatingFilm.Location = new System.Drawing.Point(299, 164);
            this.ComboBoxRatingFilm.Name = "ComboBoxRatingFilm";
            this.ComboBoxRatingFilm.Size = new System.Drawing.Size(145, 24);
            this.ComboBoxRatingFilm.TabIndex = 7;
            // 
            // labelPrimerNameFilm
            // 
            this.labelPrimerNameFilm.AutoSize = true;
            this.labelPrimerNameFilm.Location = new System.Drawing.Point(473, 29);
            this.labelPrimerNameFilm.Name = "labelPrimerNameFilm";
            this.labelPrimerNameFilm.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerNameFilm.TabIndex = 8;
            // 
            // labelHintNominationFilm
            // 
            this.labelHintNominationFilm.AutoSize = true;
            this.labelHintNominationFilm.Location = new System.Drawing.Point(473, 74);
            this.labelHintNominationFilm.Name = "labelHintNominationFilm";
            this.labelHintNominationFilm.Size = new System.Drawing.Size(0, 16);
            this.labelHintNominationFilm.TabIndex = 9;
            // 
            // labelHintRatingFilm
            // 
            this.labelHintRatingFilm.AutoSize = true;
            this.labelHintRatingFilm.Location = new System.Drawing.Point(473, 167);
            this.labelHintRatingFilm.Name = "labelHintRatingFilm";
            this.labelHintRatingFilm.Size = new System.Drawing.Size(0, 16);
            this.labelHintRatingFilm.TabIndex = 10;
            // 
            // ButtonCreateFilm
            // 
            this.ButtonCreateFilm.Location = new System.Drawing.Point(12, 394);
            this.ButtonCreateFilm.Name = "ButtonCreateFilm";
            this.ButtonCreateFilm.Size = new System.Drawing.Size(137, 44);
            this.ButtonCreateFilm.TabIndex = 11;
            this.ButtonCreateFilm.Text = "Добавить фильм";
            this.ButtonCreateFilm.UseVisualStyleBackColor = true;
            this.ButtonCreateFilm.Click += new System.EventHandler(this.ButtonCreateFilm_Click);
            // 
            // ButtonCloseFilmForm
            // 
            this.ButtonCloseFilmForm.Location = new System.Drawing.Point(678, 394);
            this.ButtonCloseFilmForm.Name = "ButtonCloseFilmForm";
            this.ButtonCloseFilmForm.Size = new System.Drawing.Size(121, 44);
            this.ButtonCloseFilmForm.TabIndex = 12;
            this.ButtonCloseFilmForm.Text = "Закрыть форму";
            this.ButtonCloseFilmForm.UseVisualStyleBackColor = true;
            this.ButtonCloseFilmForm.Click += new System.EventHandler(this.ButtonCloseFilmForm_Click);
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCloseFilmForm);
            this.Controls.Add(this.ButtonCreateFilm);
            this.Controls.Add(this.labelHintRatingFilm);
            this.Controls.Add(this.labelHintNominationFilm);
            this.Controls.Add(this.labelPrimerNameFilm);
            this.Controls.Add(this.ComboBoxRatingFilm);
            this.Controls.Add(this.NumericUpDownTicketPrice);
            this.Controls.Add(this.ComboBoxNominationFilm);
            this.Controls.Add(this.labelNominationFilm);
            this.Controls.Add(this.labelTicketPrice);
            this.Controls.Add(this.labelRatingFilm);
            this.Controls.Add(this.TextBoxNameFilm);
            this.Controls.Add(this.labelNameFilm);
            this.Name = "FilmForm";
            this.Text = "FilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameFilm;
        private System.Windows.Forms.TextBox TextBoxNameFilm;
        private System.Windows.Forms.Label labelRatingFilm;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.Label labelNominationFilm;
        private System.Windows.Forms.ComboBox ComboBoxNominationFilm;
        private System.Windows.Forms.NumericUpDown NumericUpDownTicketPrice;
        private System.Windows.Forms.ComboBox ComboBoxRatingFilm;
        private System.Windows.Forms.Label labelPrimerNameFilm;
        private System.Windows.Forms.Label labelHintNominationFilm;
        private System.Windows.Forms.Label labelHintRatingFilm;
        private System.Windows.Forms.Button ButtonCreateFilm;
        private System.Windows.Forms.Button ButtonCloseFilmForm;
    }
}