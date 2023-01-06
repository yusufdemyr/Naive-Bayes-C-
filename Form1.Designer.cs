
namespace ödev2
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
            this.trainingDataGridView = new System.Windows.Forms.DataGridView();
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            this.trainButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.classifiedDataGridView = new System.Windows.Forms.DataGridView();
            this.loadTrainingDataButton = new System.Windows.Forms.Button();
            this.loadTestDataButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trainingDataGridView
            // 
            this.trainingDataGridView.AllowUserToAddRows = false;
            this.trainingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingDataGridView.Location = new System.Drawing.Point(71, 39);
            this.trainingDataGridView.Name = "trainingDataGridView";
            this.trainingDataGridView.Size = new System.Drawing.Size(313, 187);
            this.trainingDataGridView.TabIndex = 0;
            // 
            // testDataGridView
            // 
            this.testDataGridView.AllowUserToAddRows = false;
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Location = new System.Drawing.Point(410, 39);
            this.testDataGridView.Name = "testDataGridView";
            this.testDataGridView.Size = new System.Drawing.Size(353, 187);
            this.testDataGridView.TabIndex = 1;
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(236, 250);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(75, 23);
            this.trainButton.TabIndex = 2;
            this.trainButton.Text = "trainButton";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(594, 249);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "testButton";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // classifiedDataGridView
            // 
            this.classifiedDataGridView.AllowUserToAddRows = false;
            this.classifiedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classifiedDataGridView.Location = new System.Drawing.Point(71, 289);
            this.classifiedDataGridView.Name = "classifiedDataGridView";
            this.classifiedDataGridView.Size = new System.Drawing.Size(692, 150);
            this.classifiedDataGridView.TabIndex = 4;
            // 
            // loadTrainingDataButton
            // 
            this.loadTrainingDataButton.Location = new System.Drawing.Point(71, 250);
            this.loadTrainingDataButton.Name = "loadTrainingDataButton";
            this.loadTrainingDataButton.Size = new System.Drawing.Size(153, 23);
            this.loadTrainingDataButton.TabIndex = 5;
            this.loadTrainingDataButton.Text = "loadTrainingDataButton";
            this.loadTrainingDataButton.UseVisualStyleBackColor = true;
            this.loadTrainingDataButton.Click += new System.EventHandler(this.loadTrainingDataButton_Click);
            // 
            // loadTestDataButton
            // 
            this.loadTestDataButton.Location = new System.Drawing.Point(460, 249);
            this.loadTestDataButton.Name = "loadTestDataButton";
            this.loadTestDataButton.Size = new System.Drawing.Size(128, 23);
            this.loadTestDataButton.TabIndex = 6;
            this.loadTestDataButton.Text = "loadTestDataButton";
            this.loadTestDataButton.UseVisualStyleBackColor = true;
            this.loadTestDataButton.Click += new System.EventHandler(this.loadTestDataButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(223, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "0\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(617, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(617, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(425, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(58, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "TP (Gerçek Pozitif) adedi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(58, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "TN (Gerçek Negatif) adedi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(445, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "TP rate (Gerçek Pozitif oranı):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(445, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "TN rate (Gerçek Negatif oranı):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(265, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Accuracy (Doğruluk):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(58, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "FP (Yanlış Pozitif) adedi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(57, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "FN (Yanlış Negatif) adedi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(223, 512);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "0\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(222, 539);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "0\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(445, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "FP rate (Yanlış Pozitif) oranı):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(445, 542);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "FN rate (Yanlış Negatif oranı):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(617, 515);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 18);
            this.label17.TabIndex = 23;
            this.label17.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(618, 539);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 18);
            this.label18.TabIndex = 24;
            this.label18.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadTestDataButton);
            this.Controls.Add(this.loadTrainingDataButton);
            this.Controls.Add(this.classifiedDataGridView);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.testDataGridView);
            this.Controls.Add(this.trainingDataGridView);
            this.Name = "Form1";
            this.Text = "NaiveBayes";
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifiedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView trainingDataGridView;
        private System.Windows.Forms.DataGridView testDataGridView;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.DataGridView classifiedDataGridView;
        private System.Windows.Forms.Button loadTrainingDataButton;
        private System.Windows.Forms.Button loadTestDataButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

