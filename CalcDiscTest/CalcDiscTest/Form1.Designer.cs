namespace CalcDiscTest
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
            this.tb_X1 = new System.Windows.Forms.TextBox();
            this.tb_Y1 = new System.Windows.Forms.TextBox();
            this.tb_Y2 = new System.Windows.Forms.TextBox();
            this.tb_X2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_X1
            // 
            this.tb_X1.Location = new System.Drawing.Point(98, 59);
            this.tb_X1.Name = "tb_X1";
            this.tb_X1.Size = new System.Drawing.Size(100, 20);
            this.tb_X1.TabIndex = 0;
            // 
            // tb_Y1
            // 
            this.tb_Y1.Location = new System.Drawing.Point(98, 94);
            this.tb_Y1.Name = "tb_Y1";
            this.tb_Y1.Size = new System.Drawing.Size(100, 20);
            this.tb_Y1.TabIndex = 1;
            // 
            // tb_Y2
            // 
            this.tb_Y2.Location = new System.Drawing.Point(238, 94);
            this.tb_Y2.Name = "tb_Y2";
            this.tb_Y2.Size = new System.Drawing.Size(100, 20);
            this.tb_Y2.TabIndex = 3;
            // 
            // tb_X2
            // 
            this.tb_X2.Location = new System.Drawing.Point(238, 59);
            this.tb_X2.Name = "tb_X2";
            this.tb_X2.Size = new System.Drawing.Size(100, 20);
            this.tb_X2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Y2);
            this.Controls.Add(this.tb_X2);
            this.Controls.Add(this.tb_Y1);
            this.Controls.Add(this.tb_X1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_X1;
        private System.Windows.Forms.TextBox tb_Y1;
        private System.Windows.Forms.TextBox tb_Y2;
        private System.Windows.Forms.TextBox tb_X2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

