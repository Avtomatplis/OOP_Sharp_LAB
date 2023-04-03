namespace lab_4
{
    partial class StringForm
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
            this.Close = new System.Windows.Forms.Button();
            this.PrintStringCollection = new System.Windows.Forms.Button();
            this.CreateCollection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LengthCollection = new System.Windows.Forms.NumericUpDown();
            this.LengthArray = new System.Windows.Forms.NumericUpDown();
            this.LengthTo = new System.Windows.Forms.NumericUpDown();
            this.LengthFrom = new System.Windows.Forms.NumericUpDown();
            this.LenghtToLabel = new System.Windows.Forms.Label();
            this.LenghtFromLabel = new System.Windows.Forms.Label();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.ExecuteOperationString = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LengthStringForSearch = new System.Windows.Forms.Label();
            this.LengthN = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LengthCollectionN = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LengthCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthCollectionN)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(665, 412);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(123, 41);
            this.Close.TabIndex = 0;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PrintStringCollection
            // 
            this.PrintStringCollection.Location = new System.Drawing.Point(12, 397);
            this.PrintStringCollection.Name = "PrintStringCollection";
            this.PrintStringCollection.Size = new System.Drawing.Size(138, 56);
            this.PrintStringCollection.TabIndex = 1;
            this.PrintStringCollection.Text = "Показать коллекцию строк";
            this.PrintStringCollection.UseVisualStyleBackColor = true;
            this.PrintStringCollection.Click += new System.EventHandler(this.PrintStringCollection_Click);
            // 
            // CreateCollection
            // 
            this.CreateCollection.Location = new System.Drawing.Point(178, 397);
            this.CreateCollection.Name = "CreateCollection";
            this.CreateCollection.Size = new System.Drawing.Size(138, 56);
            this.CreateCollection.TabIndex = 2;
            this.CreateCollection.Text = "Создать коллекцию строк";
            this.CreateCollection.UseVisualStyleBackColor = true;
            this.CreateCollection.Click += new System.EventHandler(this.CreateCollection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Длина коллекции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Длина массива";
            // 
            // LengthCollection
            // 
            this.LengthCollection.Location = new System.Drawing.Point(664, 53);
            this.LengthCollection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthCollection.Name = "LengthCollection";
            this.LengthCollection.Size = new System.Drawing.Size(120, 22);
            this.LengthCollection.TabIndex = 5;
            this.LengthCollection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LengthArray
            // 
            this.LengthArray.Location = new System.Drawing.Point(665, 93);
            this.LengthArray.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthArray.Name = "LengthArray";
            this.LengthArray.Size = new System.Drawing.Size(120, 22);
            this.LengthArray.TabIndex = 6;
            this.LengthArray.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthArray.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // LengthTo
            // 
            this.LengthTo.Location = new System.Drawing.Point(665, 167);
            this.LengthTo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LengthTo.Name = "LengthTo";
            this.LengthTo.Size = new System.Drawing.Size(120, 22);
            this.LengthTo.TabIndex = 10;
            this.LengthTo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LengthTo.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // LengthFrom
            // 
            this.LengthFrom.Location = new System.Drawing.Point(664, 127);
            this.LengthFrom.Name = "LengthFrom";
            this.LengthFrom.Size = new System.Drawing.Size(120, 22);
            this.LengthFrom.TabIndex = 9;
            // 
            // LenghtToLabel
            // 
            this.LenghtToLabel.AutoSize = true;
            this.LenghtToLabel.Location = new System.Drawing.Point(537, 167);
            this.LenghtToLabel.Name = "LenghtToLabel";
            this.LenghtToLabel.Size = new System.Drawing.Size(115, 16);
            this.LenghtToLabel.TabIndex = 8;
            this.LenghtToLabel.Text = "Длина строки до";
            // 
            // LenghtFromLabel
            // 
            this.LenghtFromLabel.AutoSize = true;
            this.LenghtFromLabel.Location = new System.Drawing.Point(537, 129);
            this.LenghtFromLabel.Name = "LenghtFromLabel";
            this.LenghtFromLabel.Size = new System.Drawing.Size(114, 16);
            this.LenghtFromLabel.TabIndex = 7;
            this.LenghtFromLabel.Text = "Длина строки от";
            // 
            // ConsoleText
            // 
            this.ConsoleText.Location = new System.Drawing.Point(12, 24);
            this.ConsoleText.Multiline = true;
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.Size = new System.Drawing.Size(351, 367);
            this.ConsoleText.TabIndex = 11;
            // 
            // ExecuteOperationString
            // 
            this.ExecuteOperationString.Location = new System.Drawing.Point(435, 397);
            this.ExecuteOperationString.Name = "ExecuteOperationString";
            this.ExecuteOperationString.Size = new System.Drawing.Size(138, 56);
            this.ExecuteOperationString.TabIndex = 12;
            this.ExecuteOperationString.Text = "Провести операции над строками";
            this.ExecuteOperationString.UseVisualStyleBackColor = true;
            this.ExecuteOperationString.Click += new System.EventHandler(this.ExecuteOperationString_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(656, 226);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // LengthStringForSearch
            // 
            this.LengthStringForSearch.AutoSize = true;
            this.LengthStringForSearch.Location = new System.Drawing.Point(472, 228);
            this.LengthStringForSearch.Name = "LengthStringForSearch";
            this.LengthStringForSearch.Size = new System.Drawing.Size(171, 16);
            this.LengthStringForSearch.TabIndex = 13;
            this.LengthStringForSearch.Text = "Длина строки для поиска";
            // 
            // LengthN
            // 
            this.LengthN.Location = new System.Drawing.Point(656, 301);
            this.LengthN.Name = "LengthN";
            this.LengthN.Size = new System.Drawing.Size(120, 22);
            this.LengthN.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Количество строк длины n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "n=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "n=";
            // 
            // LengthCollectionN
            // 
            this.LengthCollectionN.Location = new System.Drawing.Point(640, 368);
            this.LengthCollectionN.Name = "LengthCollectionN";
            this.LengthCollectionN.Size = new System.Drawing.Size(120, 22);
            this.LengthCollectionN.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Количество коллекций длины n";
            // 
            // StringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LengthCollectionN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LengthN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LengthStringForSearch);
            this.Controls.Add(this.ExecuteOperationString);
            this.Controls.Add(this.ConsoleText);
            this.Controls.Add(this.LengthTo);
            this.Controls.Add(this.LengthFrom);
            this.Controls.Add(this.LenghtToLabel);
            this.Controls.Add(this.LenghtFromLabel);
            this.Controls.Add(this.LengthArray);
            this.Controls.Add(this.LengthCollection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateCollection);
            this.Controls.Add(this.PrintStringCollection);
            this.Controls.Add(this.Close);
            this.Name = "StringForm";
            this.Text = "StringForm";
            this.Load += new System.EventHandler(this.StringForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LengthCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthCollectionN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button PrintStringCollection;
        private System.Windows.Forms.Button CreateCollection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LengthCollection;
        private System.Windows.Forms.NumericUpDown LengthArray;
        private System.Windows.Forms.NumericUpDown LengthTo;
        private System.Windows.Forms.NumericUpDown LengthFrom;
        private System.Windows.Forms.Label LenghtToLabel;
        private System.Windows.Forms.Label LenghtFromLabel;
        private System.Windows.Forms.TextBox ConsoleText;
        private System.Windows.Forms.Button ExecuteOperationString;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label LengthStringForSearch;
        private System.Windows.Forms.NumericUpDown LengthN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LengthCollectionN;
        private System.Windows.Forms.Label label6;
    }
}