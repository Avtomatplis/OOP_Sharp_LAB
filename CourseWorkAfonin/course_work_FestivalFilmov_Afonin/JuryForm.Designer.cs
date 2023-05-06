namespace course_work_FestivalFilmov_Afonin
{
    partial class JuryForm
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
            this.ButtonCloseJuryForm = new System.Windows.Forms.Button();
            this.ButtonCreateJury = new System.Windows.Forms.Button();
            this.labelHintPostJury = new System.Windows.Forms.Label();
            this.labelPrimerLastNameJury = new System.Windows.Forms.Label();
            this.labelPrimerNameJury = new System.Windows.Forms.Label();
            this.ComboBoxPostJury = new System.Windows.Forms.ComboBox();
            this.labelLastNameJury = new System.Windows.Forms.Label();
            this.labelPostJury = new System.Windows.Forms.Label();
            this.TextBoxNameJury = new System.Windows.Forms.TextBox();
            this.labelNameJury = new System.Windows.Forms.Label();
            this.TextBoxLastNameJury = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCloseJuryForm
            // 
            this.ButtonCloseJuryForm.Location = new System.Drawing.Point(673, 387);
            this.ButtonCloseJuryForm.Name = "ButtonCloseJuryForm";
            this.ButtonCloseJuryForm.Size = new System.Drawing.Size(121, 44);
            this.ButtonCloseJuryForm.TabIndex = 25;
            this.ButtonCloseJuryForm.Text = "Закрыть форму";
            this.ButtonCloseJuryForm.UseVisualStyleBackColor = true;
            this.ButtonCloseJuryForm.Click += new System.EventHandler(this.ButtonCloseJuryForm_Click);
            // 
            // ButtonCreateJury
            // 
            this.ButtonCreateJury.Location = new System.Drawing.Point(7, 387);
            this.ButtonCreateJury.Name = "ButtonCreateJury";
            this.ButtonCreateJury.Size = new System.Drawing.Size(137, 44);
            this.ButtonCreateJury.TabIndex = 24;
            this.ButtonCreateJury.Text = "Добавить члена жюри";
            this.ButtonCreateJury.UseVisualStyleBackColor = true;
            this.ButtonCreateJury.Click += new System.EventHandler(this.ButtonCreateJury_Click);
            // 
            // labelHintPostJury
            // 
            this.labelHintPostJury.AutoSize = true;
            this.labelHintPostJury.Location = new System.Drawing.Point(397, 111);
            this.labelHintPostJury.Name = "labelHintPostJury";
            this.labelHintPostJury.Size = new System.Drawing.Size(0, 16);
            this.labelHintPostJury.TabIndex = 23;
            // 
            // labelPrimerLastNameJury
            // 
            this.labelPrimerLastNameJury.AutoSize = true;
            this.labelPrimerLastNameJury.Location = new System.Drawing.Point(397, 62);
            this.labelPrimerLastNameJury.Name = "labelPrimerLastNameJury";
            this.labelPrimerLastNameJury.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerLastNameJury.TabIndex = 22;
            // 
            // labelPrimerNameJury
            // 
            this.labelPrimerNameJury.AutoSize = true;
            this.labelPrimerNameJury.Location = new System.Drawing.Point(397, 17);
            this.labelPrimerNameJury.Name = "labelPrimerNameJury";
            this.labelPrimerNameJury.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerNameJury.TabIndex = 21;
            // 
            // ComboBoxPostJury
            // 
            this.ComboBoxPostJury.FormattingEnabled = true;
            this.ComboBoxPostJury.Items.AddRange(new object[] {
            "Актёр",
            "Продюсер",
            "Режисёр"});
            this.ComboBoxPostJury.Location = new System.Drawing.Point(226, 108);
            this.ComboBoxPostJury.Name = "ComboBoxPostJury";
            this.ComboBoxPostJury.Size = new System.Drawing.Size(145, 24);
            this.ComboBoxPostJury.TabIndex = 20;
            // 
            // labelLastNameJury
            // 
            this.labelLastNameJury.AutoSize = true;
            this.labelLastNameJury.Location = new System.Drawing.Point(34, 67);
            this.labelLastNameJury.Name = "labelLastNameJury";
            this.labelLastNameJury.Size = new System.Drawing.Size(147, 16);
            this.labelLastNameJury.TabIndex = 17;
            this.labelLastNameJury.Text = "Фамилия члена жюри";
            // 
            // labelPostJury
            // 
            this.labelPostJury.AutoSize = true;
            this.labelPostJury.Location = new System.Drawing.Point(34, 113);
            this.labelPostJury.Name = "labelPostJury";
            this.labelPostJury.Size = new System.Drawing.Size(159, 16);
            this.labelPostJury.TabIndex = 15;
            this.labelPostJury.Text = "Должность члена жюри";
            // 
            // TextBoxNameJury
            // 
            this.TextBoxNameJury.Location = new System.Drawing.Point(226, 14);
            this.TextBoxNameJury.Name = "TextBoxNameJury";
            this.TextBoxNameJury.Size = new System.Drawing.Size(145, 22);
            this.TextBoxNameJury.TabIndex = 14;
            // 
            // labelNameJury
            // 
            this.labelNameJury.AutoSize = true;
            this.labelNameJury.Location = new System.Drawing.Point(34, 25);
            this.labelNameJury.Name = "labelNameJury";
            this.labelNameJury.Size = new System.Drawing.Size(114, 16);
            this.labelNameJury.TabIndex = 13;
            this.labelNameJury.Text = "Имя члена жюри";
            // 
            // TextBoxLastNameJury
            // 
            this.TextBoxLastNameJury.Location = new System.Drawing.Point(226, 59);
            this.TextBoxLastNameJury.Name = "TextBoxLastNameJury";
            this.TextBoxLastNameJury.Size = new System.Drawing.Size(145, 22);
            this.TextBoxLastNameJury.TabIndex = 26;
            // 
            // JuryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxLastNameJury);
            this.Controls.Add(this.ButtonCloseJuryForm);
            this.Controls.Add(this.ButtonCreateJury);
            this.Controls.Add(this.labelHintPostJury);
            this.Controls.Add(this.labelPrimerLastNameJury);
            this.Controls.Add(this.labelPrimerNameJury);
            this.Controls.Add(this.ComboBoxPostJury);
            this.Controls.Add(this.labelLastNameJury);
            this.Controls.Add(this.labelPostJury);
            this.Controls.Add(this.TextBoxNameJury);
            this.Controls.Add(this.labelNameJury);
            this.Name = "JuryForm";
            this.Text = "JuryForm";
            this.Load += new System.EventHandler(this.JuryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseJuryForm;
        private System.Windows.Forms.Button ButtonCreateJury;
        private System.Windows.Forms.Label labelHintPostJury;
        private System.Windows.Forms.Label labelPrimerLastNameJury;
        private System.Windows.Forms.Label labelPrimerNameJury;
        private System.Windows.Forms.ComboBox ComboBoxPostJury;
        private System.Windows.Forms.Label labelLastNameJury;
        private System.Windows.Forms.Label labelPostJury;
        private System.Windows.Forms.TextBox TextBoxNameJury;
        private System.Windows.Forms.Label labelNameJury;
        private System.Windows.Forms.TextBox TextBoxLastNameJury;
    }
}