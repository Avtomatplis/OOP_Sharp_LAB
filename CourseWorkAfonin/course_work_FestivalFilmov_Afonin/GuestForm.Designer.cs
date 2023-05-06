namespace course_work_FestivalFilmov_Afonin
{
    partial class GuestForm
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
            this.TextBoxEmailGuest = new System.Windows.Forms.TextBox();
            this.TextBoxLastNameGuest = new System.Windows.Forms.TextBox();
            this.ButtonCloseGuestForm = new System.Windows.Forms.Button();
            this.ButtonCreateGuest = new System.Windows.Forms.Button();
            this.labelPrimerEmailGuest = new System.Windows.Forms.Label();
            this.labelPrimerLastNameGuest = new System.Windows.Forms.Label();
            this.labelPrimerNameGuest = new System.Windows.Forms.Label();
            this.NumericUpDownSeatNumberGuest = new System.Windows.Forms.NumericUpDown();
            this.labelLastNameGuest = new System.Windows.Forms.Label();
            this.labelSeatNumber = new System.Windows.Forms.Label();
            this.labelEmailGuest = new System.Windows.Forms.Label();
            this.TextBoxNameGuest = new System.Windows.Forms.TextBox();
            this.labelNameGuest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSeatNumberGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxEmailGuest
            // 
            this.TextBoxEmailGuest.Location = new System.Drawing.Point(294, 151);
            this.TextBoxEmailGuest.Name = "TextBoxEmailGuest";
            this.TextBoxEmailGuest.Size = new System.Drawing.Size(145, 22);
            this.TextBoxEmailGuest.TabIndex = 40;
            // 
            // TextBoxLastNameGuest
            // 
            this.TextBoxLastNameGuest.Location = new System.Drawing.Point(294, 64);
            this.TextBoxLastNameGuest.Name = "TextBoxLastNameGuest";
            this.TextBoxLastNameGuest.Size = new System.Drawing.Size(145, 22);
            this.TextBoxLastNameGuest.TabIndex = 39;
            // 
            // ButtonCloseGuestForm
            // 
            this.ButtonCloseGuestForm.Location = new System.Drawing.Point(673, 387);
            this.ButtonCloseGuestForm.Name = "ButtonCloseGuestForm";
            this.ButtonCloseGuestForm.Size = new System.Drawing.Size(121, 44);
            this.ButtonCloseGuestForm.TabIndex = 38;
            this.ButtonCloseGuestForm.Text = "Закрыть форму";
            this.ButtonCloseGuestForm.UseVisualStyleBackColor = true;
            this.ButtonCloseGuestForm.Click += new System.EventHandler(this.ButtonCloseGuestForm_Click);
            // 
            // ButtonCreateGuest
            // 
            this.ButtonCreateGuest.Location = new System.Drawing.Point(7, 387);
            this.ButtonCreateGuest.Name = "ButtonCreateGuest";
            this.ButtonCreateGuest.Size = new System.Drawing.Size(137, 44);
            this.ButtonCreateGuest.TabIndex = 37;
            this.ButtonCreateGuest.Text = "Добавить гостя";
            this.ButtonCreateGuest.UseVisualStyleBackColor = true;
            this.ButtonCreateGuest.Click += new System.EventHandler(this.ButtonCreateGuest_Click);
            // 
            // labelPrimerEmailGuest
            // 
            this.labelPrimerEmailGuest.AutoSize = true;
            this.labelPrimerEmailGuest.Location = new System.Drawing.Point(468, 154);
            this.labelPrimerEmailGuest.Name = "labelPrimerEmailGuest";
            this.labelPrimerEmailGuest.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerEmailGuest.TabIndex = 36;
            // 
            // labelPrimerLastNameGuest
            // 
            this.labelPrimerLastNameGuest.AutoSize = true;
            this.labelPrimerLastNameGuest.Location = new System.Drawing.Point(468, 67);
            this.labelPrimerLastNameGuest.Name = "labelPrimerLastNameGuest";
            this.labelPrimerLastNameGuest.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerLastNameGuest.TabIndex = 35;
            // 
            // labelPrimerNameGuest
            // 
            this.labelPrimerNameGuest.AutoSize = true;
            this.labelPrimerNameGuest.Location = new System.Drawing.Point(468, 22);
            this.labelPrimerNameGuest.Name = "labelPrimerNameGuest";
            this.labelPrimerNameGuest.Size = new System.Drawing.Size(0, 16);
            this.labelPrimerNameGuest.TabIndex = 34;
            // 
            // NumericUpDownSeatNumberGuest
            // 
            this.NumericUpDownSeatNumberGuest.Location = new System.Drawing.Point(294, 106);
            this.NumericUpDownSeatNumberGuest.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownSeatNumberGuest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownSeatNumberGuest.Name = "NumericUpDownSeatNumberGuest";
            this.NumericUpDownSeatNumberGuest.Size = new System.Drawing.Size(145, 22);
            this.NumericUpDownSeatNumberGuest.TabIndex = 33;
            this.NumericUpDownSeatNumberGuest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelLastNameGuest
            // 
            this.labelLastNameGuest.AutoSize = true;
            this.labelLastNameGuest.Location = new System.Drawing.Point(34, 67);
            this.labelLastNameGuest.Name = "labelLastNameGuest";
            this.labelLastNameGuest.Size = new System.Drawing.Size(104, 16);
            this.labelLastNameGuest.TabIndex = 32;
            this.labelLastNameGuest.Text = "Фамилия гостя";
            // 
            // labelSeatNumber
            // 
            this.labelSeatNumber.AutoSize = true;
            this.labelSeatNumber.Location = new System.Drawing.Point(34, 112);
            this.labelSeatNumber.Name = "labelSeatNumber";
            this.labelSeatNumber.Size = new System.Drawing.Size(130, 16);
            this.labelSeatNumber.TabIndex = 31;
            this.labelSeatNumber.Text = "Номер места гостя";
            // 
            // labelEmailGuest
            // 
            this.labelEmailGuest.AutoSize = true;
            this.labelEmailGuest.Location = new System.Drawing.Point(34, 157);
            this.labelEmailGuest.Name = "labelEmailGuest";
            this.labelEmailGuest.Size = new System.Drawing.Size(174, 16);
            this.labelEmailGuest.TabIndex = 30;
            this.labelEmailGuest.Text = "Электронная почта гостя";
            // 
            // TextBoxNameGuest
            // 
            this.TextBoxNameGuest.Location = new System.Drawing.Point(294, 19);
            this.TextBoxNameGuest.Name = "TextBoxNameGuest";
            this.TextBoxNameGuest.Size = new System.Drawing.Size(145, 22);
            this.TextBoxNameGuest.TabIndex = 29;
            // 
            // labelNameGuest
            // 
            this.labelNameGuest.AutoSize = true;
            this.labelNameGuest.Location = new System.Drawing.Point(34, 25);
            this.labelNameGuest.Name = "labelNameGuest";
            this.labelNameGuest.Size = new System.Drawing.Size(71, 16);
            this.labelNameGuest.TabIndex = 28;
            this.labelNameGuest.Text = "Имя гостя";
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxEmailGuest);
            this.Controls.Add(this.TextBoxLastNameGuest);
            this.Controls.Add(this.ButtonCloseGuestForm);
            this.Controls.Add(this.ButtonCreateGuest);
            this.Controls.Add(this.labelPrimerEmailGuest);
            this.Controls.Add(this.labelPrimerLastNameGuest);
            this.Controls.Add(this.labelPrimerNameGuest);
            this.Controls.Add(this.NumericUpDownSeatNumberGuest);
            this.Controls.Add(this.labelLastNameGuest);
            this.Controls.Add(this.labelSeatNumber);
            this.Controls.Add(this.labelEmailGuest);
            this.Controls.Add(this.TextBoxNameGuest);
            this.Controls.Add(this.labelNameGuest);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSeatNumberGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEmailGuest;
        private System.Windows.Forms.TextBox TextBoxLastNameGuest;
        private System.Windows.Forms.Button ButtonCloseGuestForm;
        private System.Windows.Forms.Button ButtonCreateGuest;
        private System.Windows.Forms.Label labelPrimerEmailGuest;
        private System.Windows.Forms.Label labelPrimerLastNameGuest;
        private System.Windows.Forms.Label labelPrimerNameGuest;
        private System.Windows.Forms.NumericUpDown NumericUpDownSeatNumberGuest;
        private System.Windows.Forms.Label labelLastNameGuest;
        private System.Windows.Forms.Label labelSeatNumber;
        private System.Windows.Forms.Label labelEmailGuest;
        private System.Windows.Forms.TextBox TextBoxNameGuest;
        private System.Windows.Forms.Label labelNameGuest;
    }
}