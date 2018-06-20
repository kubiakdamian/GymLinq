namespace GymApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.addButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.wristBox = new System.Windows.Forms.TextBox();
            this.ankleBox = new System.Windows.Forms.TextBox();
            this.neckBox = new System.Windows.Forms.TextBox();
            this.waistBox = new System.Windows.Forms.TextBox();
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
            this.bmiData = new System.Windows.Forms.Label();
            this.fatData = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(89, 265);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(341, 86);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(391, 184);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(150, 86);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 3;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(150, 112);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 4;
            // 
            // wristBox
            // 
            this.wristBox.Location = new System.Drawing.Point(150, 138);
            this.wristBox.Name = "wristBox";
            this.wristBox.Size = new System.Drawing.Size(100, 20);
            this.wristBox.TabIndex = 5;
            // 
            // ankleBox
            // 
            this.ankleBox.Location = new System.Drawing.Point(150, 164);
            this.ankleBox.Name = "ankleBox";
            this.ankleBox.Size = new System.Drawing.Size(100, 20);
            this.ankleBox.TabIndex = 6;
            // 
            // neckBox
            // 
            this.neckBox.Location = new System.Drawing.Point(150, 190);
            this.neckBox.Name = "neckBox";
            this.neckBox.Size = new System.Drawing.Size(100, 20);
            this.neckBox.TabIndex = 7;
            // 
            // waistBox
            // 
            this.waistBox.Location = new System.Drawing.Point(149, 217);
            this.waistBox.Name = "waistBox";
            this.waistBox.Size = new System.Drawing.Size(100, 20);
            this.waistBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(295, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "MyGym";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "waga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "wzrost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "nadgarstek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "kostka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "kark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "pas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(449, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "BMI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(449, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(449, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "label10";
            // 
            // bmiData
            // 
            this.bmiData.AutoSize = true;
            this.bmiData.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmiData.Location = new System.Drawing.Point(552, 284);
            this.bmiData.Name = "bmiData";
            this.bmiData.Size = new System.Drawing.Size(90, 26);
            this.bmiData.TabIndex = 19;
            this.bmiData.Text = "BMI data";
            // 
            // fatData
            // 
            this.fatData.AutoSize = true;
            this.fatData.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fatData.Location = new System.Drawing.Point(552, 317);
            this.fatData.Name = "fatData";
            this.fatData.Size = new System.Drawing.Size(78, 26);
            this.fatData.TabIndex = 20;
            this.fatData.Text = "Fat data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(552, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 26);
            this.label11.TabIndex = 21;
            this.label11.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 400);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fatData);
            this.Controls.Add(this.bmiData);
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
            this.Controls.Add(this.waistBox);
            this.Controls.Add(this.neckBox);
            this.Controls.Add(this.ankleBox);
            this.Controls.Add(this.wristBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox wristBox;
        private System.Windows.Forms.TextBox ankleBox;
        private System.Windows.Forms.TextBox neckBox;
        private System.Windows.Forms.TextBox waistBox;
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
        private System.Windows.Forms.Label bmiData;
        private System.Windows.Forms.Label fatData;
        private System.Windows.Forms.Label label11;
    }
}

