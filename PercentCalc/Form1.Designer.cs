namespace PercentCalc
{
    partial class 퍼센트계산기
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
            this.기본값설정 = new System.Windows.Forms.GroupBox();
            this.TotalWidthLabel = new System.Windows.Forms.Label();
            this.totalWidth = new System.Windows.Forms.TextBox();
            this.TotalHeightLabel = new System.Windows.Forms.Label();
            this.totalHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.top = new System.Windows.Forms.TextBox();
            this.left = new System.Windows.Forms.TextBox();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C4 = new System.Windows.Forms.Button();
            this.widthCal = new System.Windows.Forms.TextBox();
            this.heightCal = new System.Windows.Forms.TextBox();
            this.topCal = new System.Windows.Forms.TextBox();
            this.leftCal = new System.Windows.Forms.TextBox();
            this.widthPercent = new System.Windows.Forms.TextBox();
            this.heightpercent = new System.Windows.Forms.TextBox();
            this.topPercent = new System.Windows.Forms.TextBox();
            this.leftPercent = new System.Windows.Forms.TextBox();
            this.기본값설정.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 기본값설정
            // 
            this.기본값설정.Controls.Add(this.totalHeight);
            this.기본값설정.Controls.Add(this.TotalHeightLabel);
            this.기본값설정.Controls.Add(this.totalWidth);
            this.기본값설정.Controls.Add(this.TotalWidthLabel);
            this.기본값설정.Location = new System.Drawing.Point(5, 12);
            this.기본값설정.Name = "기본값설정";
            this.기본값설정.Size = new System.Drawing.Size(402, 78);
            this.기본값설정.TabIndex = 0;
            this.기본값설정.TabStop = false;
            this.기본값설정.Text = "기본값설정";
            // 
            // TotalWidthLabel
            // 
            this.TotalWidthLabel.AutoSize = true;
            this.TotalWidthLabel.Location = new System.Drawing.Point(19, 23);
            this.TotalWidthLabel.Name = "TotalWidthLabel";
            this.TotalWidthLabel.Size = new System.Drawing.Size(62, 12);
            this.TotalWidthLabel.TabIndex = 0;
            this.TotalWidthLabel.Text = "WIDTH   : ";
            // 
            // totalWidth
            // 
            this.totalWidth.Location = new System.Drawing.Point(90, 20);
            this.totalWidth.Name = "totalWidth";
            this.totalWidth.Size = new System.Drawing.Size(155, 21);
            this.totalWidth.TabIndex = 1;
            this.totalWidth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TotalHeightLabel
            // 
            this.TotalHeightLabel.AutoSize = true;
            this.TotalHeightLabel.Location = new System.Drawing.Point(20, 50);
            this.TotalHeightLabel.Name = "TotalHeightLabel";
            this.TotalHeightLabel.Size = new System.Drawing.Size(61, 12);
            this.TotalHeightLabel.TabIndex = 2;
            this.TotalHeightLabel.Text = "HEIGHT : ";
            // 
            // totalHeight
            // 
            this.totalHeight.Location = new System.Drawing.Point(90, 47);
            this.totalHeight.Name = "totalHeight";
            this.totalHeight.Size = new System.Drawing.Size(155, 21);
            this.totalHeight.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leftPercent);
            this.groupBox1.Controls.Add(this.topPercent);
            this.groupBox1.Controls.Add(this.heightpercent);
            this.groupBox1.Controls.Add(this.widthPercent);
            this.groupBox1.Controls.Add(this.leftCal);
            this.groupBox1.Controls.Add(this.topCal);
            this.groupBox1.Controls.Add(this.heightCal);
            this.groupBox1.Controls.Add(this.widthCal);
            this.groupBox1.Controls.Add(this.C4);
            this.groupBox1.Controls.Add(this.C3);
            this.groupBox1.Controls.Add(this.C2);
            this.groupBox1.Controls.Add(this.C1);
            this.groupBox1.Controls.Add(this.left);
            this.groupBox1.Controls.Add(this.top);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.width);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "width  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "height : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "top     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "left     : ";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(71, 33);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 21);
            this.width.TabIndex = 4;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(71, 60);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(99, 21);
            this.height.TabIndex = 5;
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(71, 87);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(100, 21);
            this.top.TabIndex = 6;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(71, 114);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(99, 21);
            this.left.TabIndex = 7;
            this.left.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(177, 32);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(25, 21);
            this.C1.TabIndex = 8;
            this.C1.Text = "C";
            this.C1.UseVisualStyleBackColor = true;
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(176, 59);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(25, 21);
            this.C2.TabIndex = 9;
            this.C2.Text = "C";
            this.C2.UseVisualStyleBackColor = true;
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(176, 87);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(25, 21);
            this.C3.TabIndex = 10;
            this.C3.Text = "C";
            this.C3.UseVisualStyleBackColor = true;
            // 
            // C4
            // 
            this.C4.Location = new System.Drawing.Point(176, 113);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(25, 21);
            this.C4.TabIndex = 11;
            this.C4.Text = "C";
            this.C4.UseVisualStyleBackColor = true;
            // 
            // widthCal
            // 
            this.widthCal.Location = new System.Drawing.Point(207, 32);
            this.widthCal.Name = "widthCal";
            this.widthCal.Size = new System.Drawing.Size(89, 21);
            this.widthCal.TabIndex = 12;
            // 
            // heightCal
            // 
            this.heightCal.Location = new System.Drawing.Point(207, 59);
            this.heightCal.Name = "heightCal";
            this.heightCal.Size = new System.Drawing.Size(89, 21);
            this.heightCal.TabIndex = 13;
            // 
            // topCal
            // 
            this.topCal.Location = new System.Drawing.Point(207, 86);
            this.topCal.Name = "topCal";
            this.topCal.Size = new System.Drawing.Size(89, 21);
            this.topCal.TabIndex = 14;
            // 
            // leftCal
            // 
            this.leftCal.Location = new System.Drawing.Point(207, 113);
            this.leftCal.Name = "leftCal";
            this.leftCal.Size = new System.Drawing.Size(89, 21);
            this.leftCal.TabIndex = 15;
            // 
            // widthPercent
            // 
            this.widthPercent.Location = new System.Drawing.Point(302, 32);
            this.widthPercent.Name = "widthPercent";
            this.widthPercent.Size = new System.Drawing.Size(89, 21);
            this.widthPercent.TabIndex = 16;
            // 
            // heightpercent
            // 
            this.heightpercent.Location = new System.Drawing.Point(302, 58);
            this.heightpercent.Name = "heightpercent";
            this.heightpercent.Size = new System.Drawing.Size(89, 21);
            this.heightpercent.TabIndex = 17;
            // 
            // topPercent
            // 
            this.topPercent.Location = new System.Drawing.Point(302, 88);
            this.topPercent.Name = "topPercent";
            this.topPercent.Size = new System.Drawing.Size(89, 21);
            this.topPercent.TabIndex = 18;
            // 
            // leftPercent
            // 
            this.leftPercent.Location = new System.Drawing.Point(302, 114);
            this.leftPercent.Name = "leftPercent";
            this.leftPercent.Size = new System.Drawing.Size(89, 21);
            this.leftPercent.TabIndex = 19;
            // 
            // 퍼센트계산기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.기본값설정);
            this.Name = "퍼센트계산기";
            this.Text = "퍼센트계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.기본값설정.ResumeLayout(false);
            this.기본값설정.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 기본값설정;
        private System.Windows.Forms.TextBox totalHeight;
        private System.Windows.Forms.Label TotalHeightLabel;
        private System.Windows.Forms.TextBox totalWidth;
        private System.Windows.Forms.Label TotalWidthLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox top;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Button C4;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.TextBox leftPercent;
        private System.Windows.Forms.TextBox topPercent;
        private System.Windows.Forms.TextBox heightpercent;
        private System.Windows.Forms.TextBox widthPercent;
        private System.Windows.Forms.TextBox leftCal;
        private System.Windows.Forms.TextBox topCal;
        private System.Windows.Forms.TextBox heightCal;
        private System.Windows.Forms.TextBox widthCal;
    }
}

