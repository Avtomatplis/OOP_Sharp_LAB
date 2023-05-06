namespace course_work_FestivalFilmov_Afonin
{
    partial class GuestFestivalForm
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
            this.ButtonCloseGuestTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteGuest = new System.Windows.Forms.Button();
            this.ButtonDeleteGuest = new System.Windows.Forms.Button();
            this.ButtonCreateGuest = new System.Windows.Forms.Button();
            this.TextBoxCountGuest = new System.Windows.Forms.TextBox();
            this.labelCountGuest = new System.Windows.Forms.Label();
            this.dataGridViewGuestTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCloseGuestTable
            // 
            this.ButtonCloseGuestTable.Location = new System.Drawing.Point(792, 423);
            this.ButtonCloseGuestTable.Name = "ButtonCloseGuestTable";
            this.ButtonCloseGuestTable.Size = new System.Drawing.Size(123, 48);
            this.ButtonCloseGuestTable.TabIndex = 13;
            this.ButtonCloseGuestTable.Text = "Закрыть форму";
            this.ButtonCloseGuestTable.UseVisualStyleBackColor = true;
            this.ButtonCloseGuestTable.Click += new System.EventHandler(this.ButtonCloseGuestTable_Click);
            // 
            // ButtonAllDeleteGuest
            // 
            this.ButtonAllDeleteGuest.Location = new System.Drawing.Point(792, 203);
            this.ButtonAllDeleteGuest.Name = "ButtonAllDeleteGuest";
            this.ButtonAllDeleteGuest.Size = new System.Drawing.Size(123, 48);
            this.ButtonAllDeleteGuest.TabIndex = 12;
            this.ButtonAllDeleteGuest.Text = "Удалить всех гостей";
            this.ButtonAllDeleteGuest.UseVisualStyleBackColor = true;
            this.ButtonAllDeleteGuest.Click += new System.EventHandler(this.ButtonAllDeleteGuest_Click);
            // 
            // ButtonDeleteGuest
            // 
            this.ButtonDeleteGuest.Location = new System.Drawing.Point(792, 120);
            this.ButtonDeleteGuest.Name = "ButtonDeleteGuest";
            this.ButtonDeleteGuest.Size = new System.Drawing.Size(123, 48);
            this.ButtonDeleteGuest.TabIndex = 11;
            this.ButtonDeleteGuest.Text = "Удалить гостя";
            this.ButtonDeleteGuest.UseVisualStyleBackColor = true;
            this.ButtonDeleteGuest.Click += new System.EventHandler(this.ButtonDeleteGuest_Click);
            // 
            // ButtonCreateGuest
            // 
            this.ButtonCreateGuest.Location = new System.Drawing.Point(792, 39);
            this.ButtonCreateGuest.Name = "ButtonCreateGuest";
            this.ButtonCreateGuest.Size = new System.Drawing.Size(123, 48);
            this.ButtonCreateGuest.TabIndex = 10;
            this.ButtonCreateGuest.Text = "Добавить гостя";
            this.ButtonCreateGuest.UseVisualStyleBackColor = true;
            this.ButtonCreateGuest.Click += new System.EventHandler(this.ButtonCreateGuest_Click);
            // 
            // TextBoxCountGuest
            // 
            this.TextBoxCountGuest.Location = new System.Drawing.Point(209, 372);
            this.TextBoxCountGuest.Name = "TextBoxCountGuest";
            this.TextBoxCountGuest.Size = new System.Drawing.Size(113, 22);
            this.TextBoxCountGuest.TabIndex = 9;
            // 
            // labelCountGuest
            // 
            this.labelCountGuest.AutoSize = true;
            this.labelCountGuest.Location = new System.Drawing.Point(34, 372);
            this.labelCountGuest.Name = "labelCountGuest";
            this.labelCountGuest.Size = new System.Drawing.Size(132, 16);
            this.labelCountGuest.TabIndex = 8;
            this.labelCountGuest.Text = "Количество гостей";
            // 
            // dataGridViewGuestTable
            // 
            this.dataGridViewGuestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuestTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewGuestTable.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGuestTable.Name = "dataGridViewGuestTable";
            this.dataGridViewGuestTable.ReadOnly = true;
            this.dataGridViewGuestTable.RowHeadersWidth = 51;
            this.dataGridViewGuestTable.RowTemplate.Height = 24;
            this.dataGridViewGuestTable.Size = new System.Drawing.Size(737, 325);
            this.dataGridViewGuestTable.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя гостя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия гостя";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер места гостя";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Электронная почта гостя";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // GuestFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 485);
            this.Controls.Add(this.ButtonCloseGuestTable);
            this.Controls.Add(this.ButtonAllDeleteGuest);
            this.Controls.Add(this.ButtonDeleteGuest);
            this.Controls.Add(this.ButtonCreateGuest);
            this.Controls.Add(this.TextBoxCountGuest);
            this.Controls.Add(this.labelCountGuest);
            this.Controls.Add(this.dataGridViewGuestTable);
            this.Name = "GuestFestivalForm";
            this.Text = "GuestFestivalForm";
            this.Load += new System.EventHandler(this.GuestFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseGuestTable;
        private System.Windows.Forms.Button ButtonAllDeleteGuest;
        private System.Windows.Forms.Button ButtonDeleteGuest;
        private System.Windows.Forms.Button ButtonCreateGuest;
        private System.Windows.Forms.TextBox TextBoxCountGuest;
        private System.Windows.Forms.Label labelCountGuest;
        private System.Windows.Forms.DataGridView dataGridViewGuestTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}