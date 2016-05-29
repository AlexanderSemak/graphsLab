namespace PrimForms
{
    partial class Form1
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
            this.pictureBoxAll = new System.Windows.Forms.PictureBox();
            this.buttonMakeEdge = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFindMST = new System.Windows.Forms.Button();
            this.pictureBoxMST = new System.Windows.Forms.PictureBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDFS = new System.Windows.Forms.Button();
            this.buttonBFS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAll
            // 
            this.pictureBoxAll.Location = new System.Drawing.Point(12, 26);
            this.pictureBoxAll.Name = "pictureBoxAll";
            this.pictureBoxAll.Size = new System.Drawing.Size(420, 300);
            this.pictureBoxAll.TabIndex = 0;
            this.pictureBoxAll.TabStop = false;
            this.pictureBoxAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBoxAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAll_MouseDown);
            this.pictureBoxAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAll_MouseMove);
            this.pictureBoxAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAll_MouseUp);
            // 
            // buttonMakeEdge
            // 
            this.buttonMakeEdge.Location = new System.Drawing.Point(12, 375);
            this.buttonMakeEdge.Name = "buttonMakeEdge";
            this.buttonMakeEdge.Size = new System.Drawing.Size(418, 51);
            this.buttonMakeEdge.TabIndex = 1;
            this.buttonMakeEdge.Text = "З\'єднати вершини";
            this.buttonMakeEdge.UseVisualStyleBackColor = true;
            this.buttonMakeEdge.Click += new System.EventHandler(this.buttonMakeEdge_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 345);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(235, 345);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(89, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(480, 432);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(409, 51);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFindMST
            // 
            this.buttonFindMST.Location = new System.Drawing.Point(12, 432);
            this.buttonFindMST.Name = "buttonFindMST";
            this.buttonFindMST.Size = new System.Drawing.Size(418, 51);
            this.buttonFindMST.TabIndex = 5;
            this.buttonFindMST.Text = "Prim";
            this.buttonFindMST.UseVisualStyleBackColor = true;
            this.buttonFindMST.Click += new System.EventHandler(this.buttonFindMST_Click);
            // 
            // pictureBoxMST
            // 
            this.pictureBoxMST.Location = new System.Drawing.Point(469, 26);
            this.pictureBoxMST.Name = "pictureBoxMST";
            this.pictureBoxMST.Size = new System.Drawing.Size(420, 300);
            this.pictureBoxMST.TabIndex = 6;
            this.pictureBoxMST.TabStop = false;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(367, 345);
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownWeight.TabIndex = 7;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вершина 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вершина 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вага";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Граф";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Кістяк";
            // 
            // buttonDFS
            // 
            this.buttonDFS.Location = new System.Drawing.Point(480, 375);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(134, 51);
            this.buttonDFS.TabIndex = 13;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            this.buttonDFS.Click += new System.EventHandler(this.buttonDFS_Click);
            // 
            // buttonBFS
            // 
            this.buttonBFS.Location = new System.Drawing.Point(706, 364);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(134, 51);
            this.buttonBFS.TabIndex = 14;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 495);
            this.Controls.Add(this.buttonBFS);
            this.Controls.Add(this.buttonDFS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.pictureBoxMST);
            this.Controls.Add(this.buttonFindMST);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonMakeEdge);
            this.Controls.Add(this.pictureBoxAll);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Побудова кістяка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAll;
        private System.Windows.Forms.Button buttonMakeEdge;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFindMST;
        private System.Windows.Forms.PictureBox pictureBoxMST;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDFS;
        private System.Windows.Forms.Button buttonBFS;
    }
}

