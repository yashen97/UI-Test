namespace Modern_UI
{
    partial class Customer
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ser_res_pannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Cus_Reg_Pan = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Ser_res_pannel.SuspendLayout();
            this.Cus_Reg_Pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Ser_res_pannel
            // 
            this.Ser_res_pannel.Controls.Add(this.label1);
            this.Ser_res_pannel.Location = new System.Drawing.Point(90, 91);
            this.Ser_res_pannel.Name = "Ser_res_pannel";
            this.Ser_res_pannel.Size = new System.Drawing.Size(601, 267);
            this.Ser_res_pannel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "ADD a Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cus_Reg_Pan
            // 
            this.Cus_Reg_Pan.Controls.Add(this.button3);
            this.Cus_Reg_Pan.Controls.Add(this.label2);
            this.Cus_Reg_Pan.Controls.Add(this.textBox2);
            this.Cus_Reg_Pan.Location = new System.Drawing.Point(52, 70);
            this.Cus_Reg_Pan.Name = "Cus_Reg_Pan";
            this.Cus_Reg_Pan.Size = new System.Drawing.Size(680, 314);
            this.Cus_Reg_Pan.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter customer info here";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cus_Reg_Pan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ser_res_pannel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Customer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.Ser_res_pannel.ResumeLayout(false);
            this.Ser_res_pannel.PerformLayout();
            this.Cus_Reg_Pan.ResumeLayout(false);
            this.Cus_Reg_Pan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Ser_res_pannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Cus_Reg_Pan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}