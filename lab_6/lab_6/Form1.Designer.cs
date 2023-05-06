namespace lab_6
{
    partial class Form1
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
            this.ButtonCloseForm = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPlatformID = new System.Windows.Forms.Label();
            this.ButtonCreateTrain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonGetInfoTrain = new System.Windows.Forms.Button();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.numericPlatform = new System.Windows.Forms.NumericUpDown();
            this.numericFindID = new System.Windows.Forms.NumericUpDown();
            this.ButtonClearJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFindID)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(612, 384);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(176, 54);
            this.ButtonCloseForm.TabIndex = 0;
            this.ButtonCloseForm.Text = "Закрыть программу";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(11, 37);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 16);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "id";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(167, 68);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(135, 22);
            this.textBoxCity.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(11, 74);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(134, 16);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "город отправления";
            // 
            // labelPlatformID
            // 
            this.labelPlatformID.AutoSize = true;
            this.labelPlatformID.Location = new System.Drawing.Point(11, 113);
            this.labelPlatformID.Name = "labelPlatformID";
            this.labelPlatformID.Size = new System.Drawing.Size(100, 16);
            this.labelPlatformID.TabIndex = 5;
            this.labelPlatformID.Text = "№ платформы";
            // 
            // ButtonCreateTrain
            // 
            this.ButtonCreateTrain.Location = new System.Drawing.Point(14, 177);
            this.ButtonCreateTrain.Name = "ButtonCreateTrain";
            this.ButtonCreateTrain.Size = new System.Drawing.Size(275, 48);
            this.ButtonCreateTrain.TabIndex = 7;
            this.ButtonCreateTrain.Text = "Добавить в базу";
            this.ButtonCreateTrain.UseVisualStyleBackColor = true;
            this.ButtonCreateTrain.Click += new System.EventHandler(this.ButtonCreateTrain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "id";
            // 
            // ButtonGetInfoTrain
            // 
            this.ButtonGetInfoTrain.Location = new System.Drawing.Point(616, 74);
            this.ButtonGetInfoTrain.Name = "ButtonGetInfoTrain";
            this.ButtonGetInfoTrain.Size = new System.Drawing.Size(158, 55);
            this.ButtonGetInfoTrain.TabIndex = 10;
            this.ButtonGetInfoTrain.Text = "Вывести информацию";
            this.ButtonGetInfoTrain.UseVisualStyleBackColor = true;
            this.ButtonGetInfoTrain.Click += new System.EventHandler(this.ButtonGetInfoTrain_Click);
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(167, 28);
            this.numericID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(132, 22);
            this.numericID.TabIndex = 11;
            this.numericID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericPlatform
            // 
            this.numericPlatform.Location = new System.Drawing.Point(167, 111);
            this.numericPlatform.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPlatform.Name = "numericPlatform";
            this.numericPlatform.Size = new System.Drawing.Size(132, 22);
            this.numericPlatform.TabIndex = 12;
            this.numericPlatform.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericFindID
            // 
            this.numericFindID.Location = new System.Drawing.Point(642, 31);
            this.numericFindID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFindID.Name = "numericFindID";
            this.numericFindID.Size = new System.Drawing.Size(132, 22);
            this.numericFindID.TabIndex = 13;
            this.numericFindID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonClearJson
            // 
            this.ButtonClearJson.Location = new System.Drawing.Point(616, 170);
            this.ButtonClearJson.Name = "ButtonClearJson";
            this.ButtonClearJson.Size = new System.Drawing.Size(158, 87);
            this.ButtonClearJson.TabIndex = 14;
            this.ButtonClearJson.Text = "Очистить полностью расписание";
            this.ButtonClearJson.UseVisualStyleBackColor = true;
            this.ButtonClearJson.Click += new System.EventHandler(this.ButtonClearJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonClearJson);
            this.Controls.Add(this.numericFindID);
            this.Controls.Add(this.numericPlatform);
            this.Controls.Add(this.numericID);
            this.Controls.Add(this.ButtonGetInfoTrain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCreateTrain);
            this.Controls.Add(this.labelPlatformID);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.ButtonCloseForm);
            this.Name = "Form1";
            this.Text = "Lab6_Zhigalov_Bobkov";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFindID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseForm;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPlatformID;
        private System.Windows.Forms.Button ButtonCreateTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonGetInfoTrain;
        private System.Windows.Forms.NumericUpDown numericID;
        private System.Windows.Forms.NumericUpDown numericPlatform;
        private System.Windows.Forms.NumericUpDown numericFindID;
        private System.Windows.Forms.Button ButtonClearJson;
    }
}

