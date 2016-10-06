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
            this.WIDTH = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.기본값설정.SuspendLayout();
            this.SuspendLayout();
            // 
            // 기본값설정
            // 
            this.기본값설정.Controls.Add(this.textBox2);
            this.기본값설정.Controls.Add(this.label1);
            this.기본값설정.Controls.Add(this.textBox1);
            this.기본값설정.Controls.Add(this.WIDTH);
            this.기본값설정.Location = new System.Drawing.Point(5, 2);
            this.기본값설정.Name = "기본값설정";
            this.기본값설정.Size = new System.Drawing.Size(620, 85);
            this.기본값설정.TabIndex = 0;
            this.기본값설정.TabStop = false;
            this.기본값설정.Text = "기본값설정";
            // 
            // WIDTH
            // 
            this.WIDTH.AutoSize = true;
            this.WIDTH.Location = new System.Drawing.Point(19, 23);
            this.WIDTH.Name = "WIDTH";
            this.WIDTH.Size = new System.Drawing.Size(62, 12);
            this.WIDTH.TabIndex = 0;
            this.WIDTH.Text = "WIDTH   : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "HEIGHT : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 21);
            this.textBox2.TabIndex = 3;
            // 
            // 퍼센트계산기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 551);
            this.Controls.Add(this.기본값설정);
            this.Name = "퍼센트계산기";
            this.Text = "퍼센트계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.기본값설정.ResumeLayout(false);
            this.기본값설정.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 기본값설정;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label WIDTH;
    }
}

