namespace Modern_UI
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZ2 = new Modern_UI.ButtonZ();
            this.buttonZ1 = new Modern_UI.ButtonZ();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.buttonZ2);
            this.mainPanel.Controls.Add(this.buttonZ1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(632, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Developers Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Processing...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(130, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 106);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gihans Grage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "YTSoft";
            // 
            // buttonZ2
            // 
            this.buttonZ2.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.buttonZ2.DisplayText = "_";
            this.buttonZ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ2.ForeColor = System.Drawing.Color.White;
            this.buttonZ2.Location = new System.Drawing.Point(721, 3);
            this.buttonZ2.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.buttonZ2.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(135)))));
            this.buttonZ2.Name = "buttonZ2";
            this.buttonZ2.Size = new System.Drawing.Size(35, 32);
            this.buttonZ2.TabIndex = 1;
            this.buttonZ2.Text = "_";
            this.buttonZ2.TextLocation_X = 6;
            this.buttonZ2.TextLocation_Y = 0;
            this.buttonZ2.UseVisualStyleBackColor = true;
            this.buttonZ2.Click += new System.EventHandler(this.buttonZ2_Click);
            // 
            // buttonZ1
            // 
            this.buttonZ1.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.buttonZ1.DisplayText = "X";
            this.buttonZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ1.ForeColor = System.Drawing.Color.White;
            this.buttonZ1.Location = new System.Drawing.Point(762, 3);
            this.buttonZ1.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.buttonZ1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(135)))));
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.Size = new System.Drawing.Size(35, 32);
            this.buttonZ1.TabIndex = 0;
            this.buttonZ1.Text = "X";
            this.buttonZ1.TextLocation_X = 6;
            this.buttonZ1.TextLocation_Y = 0;
            this.buttonZ1.UseVisualStyleBackColor = true;
            this.buttonZ1.Click += new System.EventHandler(this.buttonZ1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(653, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.LoadingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingForm_Closed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private ButtonZ buttonZ2;
        private ButtonZ buttonZ1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

