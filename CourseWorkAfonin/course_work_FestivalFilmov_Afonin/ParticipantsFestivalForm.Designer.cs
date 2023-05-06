namespace course_work_FestivalFilmov_Afonin
{
    partial class ParticipantsFestivalForm
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
            this.ButtonCloseParticipantsTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteParticipants = new System.Windows.Forms.Button();
            this.ButtonDeleteParticipants = new System.Windows.Forms.Button();
            this.ButtonCreateParticipants = new System.Windows.Forms.Button();
            this.TextBoxCountParticipants = new System.Windows.Forms.TextBox();
            this.labelCountParticipants = new System.Windows.Forms.Label();
            this.dataGridViewParticipantsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCloseParticipantsTable
            // 
            this.ButtonCloseParticipantsTable.Location = new System.Drawing.Point(839, 423);
            this.ButtonCloseParticipantsTable.Name = "ButtonCloseParticipantsTable";
            this.ButtonCloseParticipantsTable.Size = new System.Drawing.Size(123, 48);
            this.ButtonCloseParticipantsTable.TabIndex = 13;
            this.ButtonCloseParticipantsTable.Text = "Закрыть форму";
            this.ButtonCloseParticipantsTable.UseVisualStyleBackColor = true;
            this.ButtonCloseParticipantsTable.Click += new System.EventHandler(this.ButtonCloseFilmTable_Click);
            // 
            // ButtonAllDeleteParticipants
            // 
            this.ButtonAllDeleteParticipants.Location = new System.Drawing.Point(828, 185);
            this.ButtonAllDeleteParticipants.Name = "ButtonAllDeleteParticipants";
            this.ButtonAllDeleteParticipants.Size = new System.Drawing.Size(123, 48);
            this.ButtonAllDeleteParticipants.TabIndex = 12;
            this.ButtonAllDeleteParticipants.Text = "Удалить всех участников";
            this.ButtonAllDeleteParticipants.UseVisualStyleBackColor = true;
            this.ButtonAllDeleteParticipants.Click += new System.EventHandler(this.ButtonAllDeleteParticipants_Click);
            // 
            // ButtonDeleteParticipants
            // 
            this.ButtonDeleteParticipants.Location = new System.Drawing.Point(828, 102);
            this.ButtonDeleteParticipants.Name = "ButtonDeleteParticipants";
            this.ButtonDeleteParticipants.Size = new System.Drawing.Size(123, 48);
            this.ButtonDeleteParticipants.TabIndex = 11;
            this.ButtonDeleteParticipants.Text = "Удалить участника";
            this.ButtonDeleteParticipants.UseVisualStyleBackColor = true;
            this.ButtonDeleteParticipants.Click += new System.EventHandler(this.ButtonDeleteParticipants_Click);
            // 
            // ButtonCreateParticipants
            // 
            this.ButtonCreateParticipants.Location = new System.Drawing.Point(828, 21);
            this.ButtonCreateParticipants.Name = "ButtonCreateParticipants";
            this.ButtonCreateParticipants.Size = new System.Drawing.Size(123, 48);
            this.ButtonCreateParticipants.TabIndex = 10;
            this.ButtonCreateParticipants.Text = "Добавить участника";
            this.ButtonCreateParticipants.UseVisualStyleBackColor = true;
            this.ButtonCreateParticipants.Click += new System.EventHandler(this.ButtonCreateParticipants_Click);
            // 
            // TextBoxCountParticipants
            // 
            this.TextBoxCountParticipants.Location = new System.Drawing.Point(212, 361);
            this.TextBoxCountParticipants.Name = "TextBoxCountParticipants";
            this.TextBoxCountParticipants.Size = new System.Drawing.Size(113, 22);
            this.TextBoxCountParticipants.TabIndex = 9;
            // 
            // labelCountParticipants
            // 
            this.labelCountParticipants.AutoSize = true;
            this.labelCountParticipants.Location = new System.Drawing.Point(23, 364);
            this.labelCountParticipants.Name = "labelCountParticipants";
            this.labelCountParticipants.Size = new System.Drawing.Size(165, 16);
            this.labelCountParticipants.TabIndex = 8;
            this.labelCountParticipants.Text = "Количество участников";
            // 
            // dataGridViewParticipantsTable
            // 
            this.dataGridViewParticipantsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipantsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewParticipantsTable.Location = new System.Drawing.Point(10, 6);
            this.dataGridViewParticipantsTable.Name = "dataGridViewParticipantsTable";
            this.dataGridViewParticipantsTable.ReadOnly = true;
            this.dataGridViewParticipantsTable.RowHeadersWidth = 51;
            this.dataGridViewParticipantsTable.RowTemplate.Height = 24;
            this.dataGridViewParticipantsTable.Size = new System.Drawing.Size(737, 325);
            this.dataGridViewParticipantsTable.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя участника";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия участника";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Город участника";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Возраст участника";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // ParticipantsFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 474);
            this.Controls.Add(this.ButtonCloseParticipantsTable);
            this.Controls.Add(this.ButtonAllDeleteParticipants);
            this.Controls.Add(this.ButtonDeleteParticipants);
            this.Controls.Add(this.ButtonCreateParticipants);
            this.Controls.Add(this.TextBoxCountParticipants);
            this.Controls.Add(this.labelCountParticipants);
            this.Controls.Add(this.dataGridViewParticipantsTable);
            this.Name = "ParticipantsFestivalForm";
            this.Text = "ParticipantsFestivalForm";
            this.Load += new System.EventHandler(this.ParticipantsFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseParticipantsTable;
        private System.Windows.Forms.Button ButtonAllDeleteParticipants;
        private System.Windows.Forms.Button ButtonDeleteParticipants;
        private System.Windows.Forms.Button ButtonCreateParticipants;
        private System.Windows.Forms.TextBox TextBoxCountParticipants;
        private System.Windows.Forms.Label labelCountParticipants;
        private System.Windows.Forms.DataGridView dataGridViewParticipantsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}