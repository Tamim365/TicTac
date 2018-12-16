namespace TicTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NGButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NGButton
            // 
            this.NGButton.BackColor = System.Drawing.Color.SpringGreen;
            this.NGButton.Location = new System.Drawing.Point(21, 15);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(80, 38);
            this.NGButton.TabIndex = 1;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = false;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // RButton
            // 
            this.RButton.BackColor = System.Drawing.Color.SpringGreen;
            this.RButton.Location = new System.Drawing.Point(21, 75);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(80, 38);
            this.RButton.TabIndex = 1;
            this.RButton.Text = "Reset";
            this.RButton.UseVisualStyleBackColor = false;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // EButton
            // 
            this.EButton.BackColor = System.Drawing.Color.IndianRed;
            this.EButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton.Location = new System.Drawing.Point(21, 168);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(80, 30);
            this.EButton.TabIndex = 1;
            this.EButton.Text = "Exit";
            this.EButton.UseVisualStyleBackColor = false;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(3, 7);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(85, 30);
            this.XWin.TabIndex = 2;
            this.XWin.Text = "label1";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(116, 7);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(85, 30);
            this.OWin.TabIndex = 2;
            this.OWin.Text = "label1";
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(221, 7);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(85, 30);
            this.Draws.TabIndex = 2;
            this.Draws.Text = "label1";
            // 
            // A00
            // 
            this.A00.BackColor = System.Drawing.Color.SkyBlue;
            this.A00.Location = new System.Drawing.Point(232, 108);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(80, 69);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = false;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.BackColor = System.Drawing.Color.SkyBlue;
            this.A10.Location = new System.Drawing.Point(232, 183);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(80, 69);
            this.A10.TabIndex = 0;
            this.A10.UseVisualStyleBackColor = false;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.BackColor = System.Drawing.Color.SkyBlue;
            this.A01.Location = new System.Drawing.Point(318, 108);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(80, 69);
            this.A01.TabIndex = 0;
            this.A01.UseVisualStyleBackColor = false;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.BackColor = System.Drawing.Color.SkyBlue;
            this.A11.Location = new System.Drawing.Point(318, 183);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(80, 69);
            this.A11.TabIndex = 0;
            this.A11.UseVisualStyleBackColor = false;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.BackColor = System.Drawing.Color.SkyBlue;
            this.A02.Location = new System.Drawing.Point(404, 108);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(80, 69);
            this.A02.TabIndex = 0;
            this.A02.UseVisualStyleBackColor = false;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.BackColor = System.Drawing.Color.SkyBlue;
            this.A12.Location = new System.Drawing.Point(404, 183);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(80, 69);
            this.A12.TabIndex = 0;
            this.A12.UseVisualStyleBackColor = false;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.BackColor = System.Drawing.Color.SkyBlue;
            this.A20.Location = new System.Drawing.Point(232, 258);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(80, 69);
            this.A20.TabIndex = 0;
            this.A20.UseVisualStyleBackColor = false;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.BackColor = System.Drawing.Color.SkyBlue;
            this.A21.Location = new System.Drawing.Point(318, 258);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(80, 69);
            this.A21.TabIndex = 0;
            this.A21.UseVisualStyleBackColor = false;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.BackColor = System.Drawing.Color.SkyBlue;
            this.A22.Location = new System.Drawing.Point(404, 258);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(80, 69);
            this.A22.TabIndex = 0;
            this.A22.UseVisualStyleBackColor = false;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.EButton);
            this.panel1.Controls.Add(this.RButton);
            this.panel1.Controls.Add(this.NGButton);
            this.panel1.Location = new System.Drawing.Point(500, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 219);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.XWin);
            this.panel2.Controls.Add(this.OWin);
            this.panel2.Controls.Add(this.Draws);
            this.panel2.Location = new System.Drawing.Point(266, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 37);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score Board";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 307);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(591, 337);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 34);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(518, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Developed By";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(526, 350);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 16);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "T@MiM";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 377);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Name = "Form1";
            this.Text = "Tic Tac Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

