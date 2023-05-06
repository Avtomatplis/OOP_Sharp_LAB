namespace lab_5
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
            this.CloseForm = new System.Windows.Forms.Button();
            this.CreateObject = new System.Windows.Forms.Button();
            this.StationName = new System.Windows.Forms.TextBox();
            this.NameStation = new System.Windows.Forms.Label();
            this.ValueEmployees = new System.Windows.Forms.NumericUpDown();
            this.Employees = new System.Windows.Forms.Label();
            this.ValueTrain = new System.Windows.Forms.Label();
            this.ValueTrains = new System.Windows.Forms.NumericUpDown();
            this.DirectorName = new System.Windows.Forms.Label();
            this.NameDirector = new System.Windows.Forms.TextBox();
            this.TrainsBox = new System.Windows.Forms.ComboBox();
            this.labelTrainStations = new System.Windows.Forms.Label();
            this.ChangeObject = new System.Windows.Forms.Button();
            this.SeeObject = new System.Windows.Forms.Button();
            this.NumberOfObjects = new System.Windows.Forms.Label();
            this.CloneObject = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValueEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTrains)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(658, 404);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(138, 44);
            this.CloseForm.TabIndex = 0;
            this.CloseForm.Text = "Закрыть";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // CreateObject
            // 
            this.CreateObject.Location = new System.Drawing.Point(341, 394);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(138, 44);
            this.CreateObject.TabIndex = 1;
            this.CreateObject.Text = "Создать обьект";
            this.CreateObject.UseVisualStyleBackColor = true;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // StationName
            // 
            this.StationName.Location = new System.Drawing.Point(637, 45);
            this.StationName.Name = "StationName";
            this.StationName.Size = new System.Drawing.Size(140, 22);
            this.StationName.TabIndex = 2;
            // 
            // NameStation
            // 
            this.NameStation.AutoSize = true;
            this.NameStation.Location = new System.Drawing.Point(487, 48);
            this.NameStation.Name = "NameStation";
            this.NameStation.Size = new System.Drawing.Size(130, 16);
            this.NameStation.TabIndex = 3;
            this.NameStation.Text = "Название станции";
            // 
            // ValueEmployees
            // 
            this.ValueEmployees.Location = new System.Drawing.Point(637, 89);
            this.ValueEmployees.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ValueEmployees.Name = "ValueEmployees";
            this.ValueEmployees.Size = new System.Drawing.Size(140, 22);
            this.ValueEmployees.TabIndex = 4;
            this.ValueEmployees.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Location = new System.Drawing.Point(444, 91);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(173, 16);
            this.Employees.TabIndex = 5;
            this.Employees.Text = "Количество сотрудников";
            // 
            // ValueTrain
            // 
            this.ValueTrain.AutoSize = true;
            this.ValueTrain.Location = new System.Drawing.Point(473, 140);
            this.ValueTrain.Name = "ValueTrain";
            this.ValueTrain.Size = new System.Drawing.Size(144, 16);
            this.ValueTrain.TabIndex = 9;
            this.ValueTrain.Text = "Количество поездов";
            // 
            // ValueTrains
            // 
            this.ValueTrains.Location = new System.Drawing.Point(637, 138);
            this.ValueTrains.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ValueTrains.Name = "ValueTrains";
            this.ValueTrains.Size = new System.Drawing.Size(140, 22);
            this.ValueTrains.TabIndex = 8;
            this.ValueTrains.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DirectorName
            // 
            this.DirectorName.AutoSize = true;
            this.DirectorName.Location = new System.Drawing.Point(454, 194);
            this.DirectorName.Name = "DirectorName";
            this.DirectorName.Size = new System.Drawing.Size(163, 16);
            this.DirectorName.TabIndex = 7;
            this.DirectorName.Text = "Имя директора станции";
            // 
            // NameDirector
            // 
            this.NameDirector.Location = new System.Drawing.Point(637, 191);
            this.NameDirector.Name = "NameDirector";
            this.NameDirector.Size = new System.Drawing.Size(140, 22);
            this.NameDirector.TabIndex = 6;
            // 
            // TrainsBox
            // 
            this.TrainsBox.FormattingEnabled = true;
            this.TrainsBox.Location = new System.Drawing.Point(341, 268);
            this.TrainsBox.Name = "TrainsBox";
            this.TrainsBox.Size = new System.Drawing.Size(146, 24);
            this.TrainsBox.TabIndex = 10;
            // 
            // labelTrainStations
            // 
            this.labelTrainStations.AutoSize = true;
            this.labelTrainStations.Location = new System.Drawing.Point(13, 30);
            this.labelTrainStations.Name = "labelTrainStations";
            this.labelTrainStations.Size = new System.Drawing.Size(0, 16);
            this.labelTrainStations.TabIndex = 11;
            // 
            // ChangeObject
            // 
            this.ChangeObject.Location = new System.Drawing.Point(161, 394);
            this.ChangeObject.Name = "ChangeObject";
            this.ChangeObject.Size = new System.Drawing.Size(138, 44);
            this.ChangeObject.TabIndex = 12;
            this.ChangeObject.Text = "Изменить обьект";
            this.ChangeObject.UseVisualStyleBackColor = true;
            this.ChangeObject.Click += new System.EventHandler(this.ChangeObject_Click);
            // 
            // SeeObject
            // 
            this.SeeObject.Location = new System.Drawing.Point(502, 394);
            this.SeeObject.Name = "SeeObject";
            this.SeeObject.Size = new System.Drawing.Size(138, 44);
            this.SeeObject.TabIndex = 13;
            this.SeeObject.Text = "Показать обьект";
            this.SeeObject.UseVisualStyleBackColor = true;
            this.SeeObject.Click += new System.EventHandler(this.SeeObject_Click_1);
            // 
            // NumberOfObjects
            // 
            this.NumberOfObjects.AutoSize = true;
            this.NumberOfObjects.Location = new System.Drawing.Point(564, 271);
            this.NumberOfObjects.Name = "NumberOfObjects";
            this.NumberOfObjects.Size = new System.Drawing.Size(144, 16);
            this.NumberOfObjects.TabIndex = 14;
            this.NumberOfObjects.Text = "Добавлено обьектов";
            // 
            // CloneObject
            // 
            this.CloneObject.Location = new System.Drawing.Point(12, 394);
            this.CloneObject.Name = "CloneObject";
            this.CloneObject.Size = new System.Drawing.Size(138, 44);
            this.CloneObject.TabIndex = 15;
            this.CloneObject.Text = "Дублировать обьект";
            this.CloneObject.UseVisualStyleBackColor = true;
            this.CloneObject.Click += new System.EventHandler(this.CloneObject_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(502, 344);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(138, 44);
            this.ClearAll.TabIndex = 16;
            this.ClearAll.Text = "Удалить все";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.CloneObject);
            this.Controls.Add(this.NumberOfObjects);
            this.Controls.Add(this.SeeObject);
            this.Controls.Add(this.ChangeObject);
            this.Controls.Add(this.labelTrainStations);
            this.Controls.Add(this.TrainsBox);
            this.Controls.Add(this.ValueTrain);
            this.Controls.Add(this.ValueTrains);
            this.Controls.Add(this.DirectorName);
            this.Controls.Add(this.NameDirector);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.ValueEmployees);
            this.Controls.Add(this.NameStation);
            this.Controls.Add(this.StationName);
            this.Controls.Add(this.CreateObject);
            this.Controls.Add(this.CloseForm);
            this.Name = "Form1";
            this.Text = "Lab5_Zhigalov_Bobkov";
            ((System.ComponentModel.ISupportInitialize)(this.ValueEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTrains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.TextBox StationName;
        private System.Windows.Forms.Label NameStation;
        private System.Windows.Forms.NumericUpDown ValueEmployees;
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.Label ValueTrain;
        private System.Windows.Forms.NumericUpDown ValueTrains;
        private System.Windows.Forms.Label DirectorName;
        private System.Windows.Forms.TextBox NameDirector;
        private System.Windows.Forms.ComboBox TrainsBox;
        private System.Windows.Forms.Label labelTrainStations;
        private System.Windows.Forms.Button ChangeObject;
        private System.Windows.Forms.Button SeeObject;
        private System.Windows.Forms.Label NumberOfObjects;
        private System.Windows.Forms.Button CloneObject;
        private System.Windows.Forms.Button ClearAll;
    }
}

