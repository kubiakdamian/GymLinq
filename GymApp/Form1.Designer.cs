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
            this.addButton = new System.Windows.Forms.Button();
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
            this.caloricDemandLabel = new System.Windows.Forms.Label();
            this.bmiRating = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.actualWeight = new System.Windows.Forms.Label();
            this.weightDiff = new System.Windows.Forms.Label();
            this.heightDiff = new System.Windows.Forms.Label();
            this.actualHeight = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.wristDiff = new System.Windows.Forms.Label();
            this.actualWrist = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ankleDiff = new System.Windows.Forms.Label();
            this.actualAnkle = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.neckDiff = new System.Windows.Forms.Label();
            this.actualNeck = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.waistDiff = new System.Windows.Forms.Label();
            this.actualWaist = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(84, 290);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(145, 111);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 3;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(145, 137);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 4;
            // 
            // wristBox
            // 
            this.wristBox.Location = new System.Drawing.Point(145, 163);
            this.wristBox.Name = "wristBox";
            this.wristBox.Size = new System.Drawing.Size(100, 20);
            this.wristBox.TabIndex = 5;
            // 
            // ankleBox
            // 
            this.ankleBox.Location = new System.Drawing.Point(145, 189);
            this.ankleBox.Name = "ankleBox";
            this.ankleBox.Size = new System.Drawing.Size(100, 20);
            this.ankleBox.TabIndex = 6;
            // 
            // neckBox
            // 
            this.neckBox.Location = new System.Drawing.Point(145, 215);
            this.neckBox.Name = "neckBox";
            this.neckBox.Size = new System.Drawing.Size(100, 20);
            this.neckBox.TabIndex = 7;
            // 
            // waistBox
            // 
            this.waistBox.Location = new System.Drawing.Point(144, 242);
            this.waistBox.Name = "waistBox";
            this.waistBox.Size = new System.Drawing.Size(100, 20);
            this.waistBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "MyGym";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "waga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "wzrost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "biceps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "klatka pier.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "kark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "pas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(373, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "BMI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(373, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tkanka tł.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(373, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Zapotrzebowanie kal.";
            // 
            // bmiData
            // 
            this.bmiData.AutoSize = true;
            this.bmiData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmiData.Location = new System.Drawing.Point(531, 290);
            this.bmiData.Name = "bmiData";
            this.bmiData.Size = new System.Drawing.Size(85, 22);
            this.bmiData.TabIndex = 19;
            this.bmiData.Text = "BMI data";
            // 
            // fatData
            // 
            this.fatData.AutoSize = true;
            this.fatData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fatData.Location = new System.Drawing.Point(622, 323);
            this.fatData.Name = "fatData";
            this.fatData.Size = new System.Drawing.Size(78, 22);
            this.fatData.TabIndex = 20;
            this.fatData.Text = "Fat data";
            // 
            // caloricDemandLabel
            // 
            this.caloricDemandLabel.AutoSize = true;
            this.caloricDemandLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.caloricDemandLabel.Location = new System.Drawing.Point(622, 357);
            this.caloricDemandLabel.Name = "caloricDemandLabel";
            this.caloricDemandLabel.Size = new System.Drawing.Size(69, 22);
            this.caloricDemandLabel.TabIndex = 21;
            this.caloricDemandLabel.Text = "Caloric";
            // 
            // bmiRating
            // 
            this.bmiRating.AutoSize = true;
            this.bmiRating.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmiRating.Location = new System.Drawing.Point(622, 290);
            this.bmiRating.Name = "bmiRating";
            this.bmiRating.Size = new System.Drawing.Size(64, 22);
            this.bmiRating.TabIndex = 22;
            this.bmiRating.Text = "Rating";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(487, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Obecne wymiary";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(101, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Dodaj wymiary";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(403, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Waga";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // actualWeight
            // 
            this.actualWeight.AutoSize = true;
            this.actualWeight.Location = new System.Drawing.Point(531, 117);
            this.actualWeight.Name = "actualWeight";
            this.actualWeight.Size = new System.Drawing.Size(41, 13);
            this.actualWeight.TabIndex = 26;
            this.actualWeight.Text = "label15";
            // 
            // weightDiff
            // 
            this.weightDiff.AutoSize = true;
            this.weightDiff.Location = new System.Drawing.Point(663, 117);
            this.weightDiff.Name = "weightDiff";
            this.weightDiff.Size = new System.Drawing.Size(41, 13);
            this.weightDiff.TabIndex = 27;
            this.weightDiff.Text = "label16";
            // 
            // heightDiff
            // 
            this.heightDiff.AutoSize = true;
            this.heightDiff.Location = new System.Drawing.Point(663, 144);
            this.heightDiff.Name = "heightDiff";
            this.heightDiff.Size = new System.Drawing.Size(41, 13);
            this.heightDiff.TabIndex = 30;
            this.heightDiff.Text = "label17";
            // 
            // actualHeight
            // 
            this.actualHeight.AutoSize = true;
            this.actualHeight.Location = new System.Drawing.Point(531, 144);
            this.actualHeight.Name = "actualHeight";
            this.actualHeight.Size = new System.Drawing.Size(41, 13);
            this.actualHeight.TabIndex = 29;
            this.actualHeight.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(403, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Wzrost";
            // 
            // wristDiff
            // 
            this.wristDiff.AutoSize = true;
            this.wristDiff.Location = new System.Drawing.Point(663, 170);
            this.wristDiff.Name = "wristDiff";
            this.wristDiff.Size = new System.Drawing.Size(41, 13);
            this.wristDiff.TabIndex = 33;
            this.wristDiff.Text = "label20";
            // 
            // actualWrist
            // 
            this.actualWrist.AutoSize = true;
            this.actualWrist.Location = new System.Drawing.Point(531, 170);
            this.actualWrist.Name = "actualWrist";
            this.actualWrist.Size = new System.Drawing.Size(41, 13);
            this.actualWrist.TabIndex = 32;
            this.actualWrist.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(403, 170);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Biceps";
            // 
            // ankleDiff
            // 
            this.ankleDiff.AutoSize = true;
            this.ankleDiff.Location = new System.Drawing.Point(663, 196);
            this.ankleDiff.Name = "ankleDiff";
            this.ankleDiff.Size = new System.Drawing.Size(41, 13);
            this.ankleDiff.TabIndex = 36;
            this.ankleDiff.Text = "label23";
            // 
            // actualAnkle
            // 
            this.actualAnkle.AutoSize = true;
            this.actualAnkle.Location = new System.Drawing.Point(531, 196);
            this.actualAnkle.Name = "actualAnkle";
            this.actualAnkle.Size = new System.Drawing.Size(41, 13);
            this.actualAnkle.TabIndex = 35;
            this.actualAnkle.Text = "label24";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(403, 196);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 13);
            this.label25.TabIndex = 34;
            this.label25.Text = "Klatka piersiowa";
            // 
            // neckDiff
            // 
            this.neckDiff.AutoSize = true;
            this.neckDiff.Location = new System.Drawing.Point(664, 222);
            this.neckDiff.Name = "neckDiff";
            this.neckDiff.Size = new System.Drawing.Size(41, 13);
            this.neckDiff.TabIndex = 39;
            this.neckDiff.Text = "label26";
            this.neckDiff.Click += new System.EventHandler(this.label26_Click);
            // 
            // actualNeck
            // 
            this.actualNeck.AutoSize = true;
            this.actualNeck.Location = new System.Drawing.Point(532, 222);
            this.actualNeck.Name = "actualNeck";
            this.actualNeck.Size = new System.Drawing.Size(41, 13);
            this.actualNeck.TabIndex = 38;
            this.actualNeck.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(404, 222);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 13);
            this.label28.TabIndex = 37;
            this.label28.Text = "Kark";
            // 
            // waistDiff
            // 
            this.waistDiff.AutoSize = true;
            this.waistDiff.Location = new System.Drawing.Point(663, 245);
            this.waistDiff.Name = "waistDiff";
            this.waistDiff.Size = new System.Drawing.Size(41, 13);
            this.waistDiff.TabIndex = 42;
            this.waistDiff.Text = "label29";
            // 
            // actualWaist
            // 
            this.actualWaist.AutoSize = true;
            this.actualWaist.Location = new System.Drawing.Point(531, 245);
            this.actualWaist.Name = "actualWaist";
            this.actualWaist.Size = new System.Drawing.Size(41, 13);
            this.actualWaist.TabIndex = 41;
            this.actualWaist.Text = "label30";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(403, 245);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 13);
            this.label31.TabIndex = 40;
            this.label31.Text = "Pas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 400);
            this.Controls.Add(this.waistDiff);
            this.Controls.Add(this.actualWaist);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.neckDiff);
            this.Controls.Add(this.actualNeck);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.ankleDiff);
            this.Controls.Add(this.actualAnkle);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.wristDiff);
            this.Controls.Add(this.actualWrist);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.heightDiff);
            this.Controls.Add(this.actualHeight);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.weightDiff);
            this.Controls.Add(this.actualWeight);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bmiRating);
            this.Controls.Add(this.caloricDemandLabel);
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
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
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
        private System.Windows.Forms.Label caloricDemandLabel;
        private System.Windows.Forms.Label bmiRating;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label actualWeight;
        private System.Windows.Forms.Label weightDiff;
        private System.Windows.Forms.Label heightDiff;
        private System.Windows.Forms.Label actualHeight;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label wristDiff;
        private System.Windows.Forms.Label actualWrist;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label ankleDiff;
        private System.Windows.Forms.Label actualAnkle;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label neckDiff;
        private System.Windows.Forms.Label actualNeck;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label waistDiff;
        private System.Windows.Forms.Label actualWaist;
        private System.Windows.Forms.Label label31;
    }
}

