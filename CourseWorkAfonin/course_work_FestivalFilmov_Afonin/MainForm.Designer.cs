namespace course_work_FestivalFilmov_Afonin
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAccountingFilm = new System.Windows.Forms.Button();
            this.ButtonAccountingParticipants = new System.Windows.Forms.Button();
            this.ButtonAccountingJury = new System.Windows.Forms.Button();
            this.ButtonAccountingGuest = new System.Windows.Forms.Button();
            this.ButtonCloseMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курсовой проект студента гр.21ВП2 Жигалова Кирилла ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(195, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "на тему: ❠Фестиваль фильмов\"";
            // 
            // ButtonAccountingFilm
            // 
            this.ButtonAccountingFilm.Location = new System.Drawing.Point(12, 365);
            this.ButtonAccountingFilm.Name = "ButtonAccountingFilm";
            this.ButtonAccountingFilm.Size = new System.Drawing.Size(128, 48);
            this.ButtonAccountingFilm.TabIndex = 2;
            this.ButtonAccountingFilm.Text = "Учёт фильмов";
            this.ButtonAccountingFilm.UseVisualStyleBackColor = true;
            this.ButtonAccountingFilm.Click += new System.EventHandler(this.ButtonAccountingFilm_Click);
            // 
            // ButtonAccountingParticipants
            // 
            this.ButtonAccountingParticipants.Location = new System.Drawing.Point(170, 365);
            this.ButtonAccountingParticipants.Name = "ButtonAccountingParticipants";
            this.ButtonAccountingParticipants.Size = new System.Drawing.Size(128, 48);
            this.ButtonAccountingParticipants.TabIndex = 3;
            this.ButtonAccountingParticipants.Text = "Учёт участников";
            this.ButtonAccountingParticipants.UseVisualStyleBackColor = true;
            this.ButtonAccountingParticipants.Click += new System.EventHandler(this.ButtonAccountingParticipants_Click);
            // 
            // ButtonAccountingJury
            // 
            this.ButtonAccountingJury.Location = new System.Drawing.Point(322, 365);
            this.ButtonAccountingJury.Name = "ButtonAccountingJury";
            this.ButtonAccountingJury.Size = new System.Drawing.Size(128, 48);
            this.ButtonAccountingJury.TabIndex = 4;
            this.ButtonAccountingJury.Text = "Учёт жюри";
            this.ButtonAccountingJury.UseVisualStyleBackColor = true;
            this.ButtonAccountingJury.Click += new System.EventHandler(this.ButtonAccountingJury_Click);
            // 
            // ButtonAccountingGuest
            // 
            this.ButtonAccountingGuest.Location = new System.Drawing.Point(480, 365);
            this.ButtonAccountingGuest.Name = "ButtonAccountingGuest";
            this.ButtonAccountingGuest.Size = new System.Drawing.Size(128, 48);
            this.ButtonAccountingGuest.TabIndex = 5;
            this.ButtonAccountingGuest.Text = "Учёт гостей";
            this.ButtonAccountingGuest.UseVisualStyleBackColor = true;
            this.ButtonAccountingGuest.Click += new System.EventHandler(this.ButtonAccountingGuest_Click);
            // 
            // ButtonCloseMainForm
            // 
            this.ButtonCloseMainForm.Location = new System.Drawing.Point(663, 402);
            this.ButtonCloseMainForm.Name = "ButtonCloseMainForm";
            this.ButtonCloseMainForm.Size = new System.Drawing.Size(128, 48);
            this.ButtonCloseMainForm.TabIndex = 6;
            this.ButtonCloseMainForm.Text = "Закрыть проект";
            this.ButtonCloseMainForm.UseVisualStyleBackColor = true;
            this.ButtonCloseMainForm.Click += new System.EventHandler(this.ButtonCloseMainForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.ButtonCloseMainForm);
            this.Controls.Add(this.ButtonAccountingGuest);
            this.Controls.Add(this.ButtonAccountingJury);
            this.Controls.Add(this.ButtonAccountingParticipants);
            this.Controls.Add(this.ButtonAccountingFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAccountingFilm;
        private System.Windows.Forms.Button ButtonAccountingParticipants;
        private System.Windows.Forms.Button ButtonAccountingJury;
        private System.Windows.Forms.Button ButtonAccountingGuest;
        private System.Windows.Forms.Button ButtonCloseMainForm;
    }
}

