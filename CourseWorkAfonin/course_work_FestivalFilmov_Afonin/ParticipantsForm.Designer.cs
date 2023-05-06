namespace course_work_FestivalFilmov_Afonin
{
    partial class ParticipantsForm
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
            this.ButtonCloseParticipantsForm = new System.Windows.Forms.Button();
            this.ButtonCreateParticipants = new System.Windows.Forms.Button();
            this.labelPrimerCityParticipants = new System.Windows.Forms.Label();
            this.labelPrimerLastNameParticipants = new System.Windows.Forms.Label();
            this.labelPrimerNameParticipants = new System.Windows.Forms.Label();
            this.NumericUpDownAgeParticipants = new System.Windows.Forms.NumericUpDown();
            this.labelLastNameParticipants = new System.Windows.Forms.Label();
            this.labelCityParticipants = new System.Windows.Forms.Label();
            this.labelAgeParticipants = new System.Windows.Forms.Label();
            this.TextBoxNameParticipants = new System.Windows.Forms.TextBox();
            this.labelNameParticipants = new System.Windows.Forms.Label();
            this.TextBoxLastNameParticipants = new System.Windows.Forms.TextBox();
            this.TextBoxCityParticipants = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownAgeParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCloseParticipantsForm
            // 
            this.ButtonCloseParticipantsForm.Location = new System.Drawing.Point(673, 387);
            this.ButtonCloseParticipantsForm.Name = "ButtonCloseParticipantsForm";
            this.ButtonCloseParticipantsForm.Size = new System.Drawing.Size(121, 44);
            this.ButtonCloseParticipantsForm.TabIndex = 25;
            this.ButtonCloseParticipantsForm.Text = "Закрыть форму";
            this.ButtonCloseParticipantsForm.UseVisualStyleBackColor = true;
            this.ButtonCloseParticipantsForm.Click += new System.EventHandler(this.ButtonCloseParticipantsForm_Click);
            // 
            // ButtonCreateParticipants
            // 
            this.ButtonCreateParticipants.Location = new System.Drawing.Point(7, 387);
            this.ButtonCreateParticipants.Name = "ButtonCreateParticipants";
            this.ButtonCreateParticipants.Size = new System.Drawing.Size(137, 44);
            this.ButtonCreateParticipants.TabIndex = 24;
            this.ButtonCreateParticipants.Text = "Добавить участника";
            this.ButtonCreateParticipants.UseVisualStyleBackColor = true;
            this.ButtonCreateParticipants.Click += new System.EventHandler(this.ButtonCreateParticipants_Click);
            // 
            // labelPrimerCityParticipants
            // 
            this.labelPrimerCityParticipants.AutoSize = true;
            this.labelPrimerCityParticipants.Location = new System.Drawing.Point(468, 112);
            this.labelPrimerCityParticipants.Name = "labelPrimerCityParticipants";
            this.labelPrimerCityParticipants.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerCityParticipants.TabIndex = 23;
            // 
            // labelPrimerLastNameParticipants
            // 
            this.labelPrimerLastNameParticipants.AutoSize = true;
            this.labelPrimerLastNameParticipants.Location = new System.Drawing.Point(468, 67);
            this.labelPrimerLastNameParticipants.Name = "labelPrimerLastNameParticipants";
            this.labelPrimerLastNameParticipants.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerLastNameParticipants.TabIndex = 22;
            // 
            // labelPrimerNameParticipants
            // 
            this.labelPrimerNameParticipants.AutoSize = true;
            this.labelPrimerNameParticipants.Location = new System.Drawing.Point(468, 22);
            this.labelPrimerNameParticipants.Name = "labelPrimerNameParticipants";
            this.labelPrimerNameParticipants.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerNameParticipants.TabIndex = 21;
            // 
            // NumericUpDownAgeParticipants
            // 
            this.NumericUpDownAgeParticipants.Location = new System.Drawing.Point(294, 151);
            this.NumericUpDownAgeParticipants.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.NumericUpDownAgeParticipants.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NumericUpDownAgeParticipants.Name = "NumericUpDownAgeParticipants";
            this.NumericUpDownAgeParticipants.Size = new System.Drawing.Size(145, 22);
            this.NumericUpDownAgeParticipants.TabIndex = 19;
            this.NumericUpDownAgeParticipants.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // labelLastNameParticipants
            // 
            this.labelLastNameParticipants.AutoSize = true;
            this.labelLastNameParticipants.Location = new System.Drawing.Point(34, 67);
            this.labelLastNameParticipants.Name = "labelLastNameParticipants";
            this.labelLastNameParticipants.Size = new System.Drawing.Size(138, 16);
            this.labelLastNameParticipants.TabIndex = 17;
            this.labelLastNameParticipants.Text = "Фамилия участника";
            // 
            // labelCityParticipants
            // 
            this.labelCityParticipants.AutoSize = true;
            this.labelCityParticipants.Location = new System.Drawing.Point(34, 112);
            this.labelCityParticipants.Name = "labelCityParticipants";
            this.labelCityParticipants.Size = new System.Drawing.Size(118, 16);
            this.labelCityParticipants.TabIndex = 16;
            this.labelCityParticipants.Text = "Город участника";
            // 
            // labelAgeParticipants
            // 
            this.labelAgeParticipants.AutoSize = true;
            this.labelAgeParticipants.Location = new System.Drawing.Point(34, 157);
            this.labelAgeParticipants.Name = "labelAgeParticipants";
            this.labelAgeParticipants.Size = new System.Drawing.Size(213, 16);
            this.labelAgeParticipants.TabIndex = 15;
            this.labelAgeParticipants.Text = "Возраст участника (от 18 до 65)";
            // 
            // TextBoxNameParticipants
            // 
            this.TextBoxNameParticipants.Location = new System.Drawing.Point(294, 19);
            this.TextBoxNameParticipants.Name = "TextBoxNameParticipants";
            this.TextBoxNameParticipants.Size = new System.Drawing.Size(145, 22);
            this.TextBoxNameParticipants.TabIndex = 14;
            // 
            // labelNameParticipants
            // 
            this.labelNameParticipants.AutoSize = true;
            this.labelNameParticipants.Location = new System.Drawing.Point(34, 25);
            this.labelNameParticipants.Name = "labelNameParticipants";
            this.labelNameParticipants.Size = new System.Drawing.Size(105, 16);
            this.labelNameParticipants.TabIndex = 13;
            this.labelNameParticipants.Text = "Имя участника";
            // 
            // TextBoxLastNameParticipants
            // 
            this.TextBoxLastNameParticipants.Location = new System.Drawing.Point(294, 64);
            this.TextBoxLastNameParticipants.Name = "TextBoxLastNameParticipants";
            this.TextBoxLastNameParticipants.Size = new System.Drawing.Size(145, 22);
            this.TextBoxLastNameParticipants.TabIndex = 26;
            // 
            // TextBoxCityParticipants
            // 
            this.TextBoxCityParticipants.Location = new System.Drawing.Point(294, 109);
            this.TextBoxCityParticipants.Name = "TextBoxCityParticipants";
            this.TextBoxCityParticipants.Size = new System.Drawing.Size(145, 22);
            this.TextBoxCityParticipants.TabIndex = 27;
            // 
            // ParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 446);
            this.Controls.Add(this.TextBoxCityParticipants);
            this.Controls.Add(this.TextBoxLastNameParticipants);
            this.Controls.Add(this.ButtonCloseParticipantsForm);
            this.Controls.Add(this.ButtonCreateParticipants);
            this.Controls.Add(this.labelPrimerCityParticipants);
            this.Controls.Add(this.labelPrimerLastNameParticipants);
            this.Controls.Add(this.labelPrimerNameParticipants);
            this.Controls.Add(this.NumericUpDownAgeParticipants);
            this.Controls.Add(this.labelLastNameParticipants);
            this.Controls.Add(this.labelCityParticipants);
            this.Controls.Add(this.labelAgeParticipants);
            this.Controls.Add(this.TextBoxNameParticipants);
            this.Controls.Add(this.labelNameParticipants);
            this.Name = "ParticipantsForm";
            this.Text = "ParticipantsForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownAgeParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseParticipantsForm;
        private System.Windows.Forms.Button ButtonCreateParticipants;
        private System.Windows.Forms.Label labelPrimerCityParticipants;
        private System.Windows.Forms.Label labelPrimerLastNameParticipants;
        private System.Windows.Forms.Label labelPrimerNameParticipants;
        private System.Windows.Forms.NumericUpDown NumericUpDownAgeParticipants;
        private System.Windows.Forms.Label labelLastNameParticipants;
        private System.Windows.Forms.Label labelCityParticipants;
        private System.Windows.Forms.Label labelAgeParticipants;
        private System.Windows.Forms.TextBox TextBoxNameParticipants;
        private System.Windows.Forms.Label labelNameParticipants;
        private System.Windows.Forms.TextBox TextBoxLastNameParticipants;
        private System.Windows.Forms.TextBox TextBoxCityParticipants;
    }
}