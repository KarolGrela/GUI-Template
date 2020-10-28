namespace GUI_Template
{
    partial class MainForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTopRight = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelUnderTop = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelCentre = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(2)))), ((int)(((byte)(29)))));
            this.panelLeft.Controls.Add(this.panelButton);
            this.panelLeft.Controls.Add(this.button7);
            this.panelLeft.Controls.Add(this.button6);
            this.panelLeft.Controls.Add(this.button5);
            this.panelLeft.Controls.Add(this.button4);
            this.panelLeft.Controls.Add(this.button3);
            this.panelLeft.Controls.Add(this.button2);
            this.panelLeft.Controls.Add(this.button1);
            this.panelLeft.Controls.Add(this.labelTopRight);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(237, 617);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.White;
            this.panelButton.Location = new System.Drawing.Point(0, 110);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(15, 70);
            this.panelButton.TabIndex = 2;
            this.panelButton.Visible = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 530);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(237, 70);
            this.button7.TabIndex = 9;
            this.button7.Text = "Button 7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 460);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(237, 70);
            this.button6.TabIndex = 8;
            this.button6.Text = "Button 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 70);
            this.button5.TabIndex = 7;
            this.button5.Text = "Button 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 70);
            this.button4.TabIndex = 6;
            this.button4.Text = "Button 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Button 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "Button 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Button 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTopRight
            // 
            this.labelTopRight.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTopRight.Location = new System.Drawing.Point(0, 0);
            this.labelTopRight.Name = "labelTopRight";
            this.labelTopRight.Size = new System.Drawing.Size(237, 107);
            this.labelTopRight.TabIndex = 2;
            this.labelTopRight.Text = "GUI Template";
            this.labelTopRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTopRight.Click += new System.EventHandler(this.labelTopRight_Click);
            this.labelTopRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTopRight_MouseMove);
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTop.Location = new System.Drawing.Point(3, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(777, 35);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Main Menu";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(2)))), ((int)(((byte)(29)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(237, 577);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(959, 40);
            this.panelBottom.TabIndex = 2;
            // 
            // panelUnderTop
            // 
            this.panelUnderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(7)))), ((int)(((byte)(40)))));
            this.panelUnderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUnderTop.Location = new System.Drawing.Point(237, 35);
            this.panelUnderTop.Name = "panelUnderTop";
            this.panelUnderTop.Size = new System.Drawing.Size(959, 5);
            this.panelUnderTop.TabIndex = 5;
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconSize = 16;
            this.iconButtonExit.Location = new System.Drawing.Point(924, 0);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(35, 35);
            this.iconButtonExit.TabIndex = 0;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            this.iconButtonExit.MouseEnter += new System.EventHandler(this.iconButtonExit_MouseEnter);
            this.iconButtonExit.MouseLeave += new System.EventHandler(this.iconButtonExit_MouseLeave);
            // 
            // iconButtonMinimize
            // 
            this.iconButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMinimize.IconColor = System.Drawing.Color.White;
            this.iconButtonMinimize.IconSize = 16;
            this.iconButtonMinimize.Location = new System.Drawing.Point(887, 0);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Rotation = 0D;
            this.iconButtonMinimize.Size = new System.Drawing.Size(35, 35);
            this.iconButtonMinimize.TabIndex = 1;
            this.iconButtonMinimize.UseVisualStyleBackColor = true;
            this.iconButtonMinimize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
            this.iconButtonMinimize.MouseEnter += new System.EventHandler(this.iconButtonMinimize_MouseEnter);
            this.iconButtonMinimize.MouseLeave += new System.EventHandler(this.iconButtonMinimize_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(2)))), ((int)(((byte)(29)))));
            this.panelTop.Controls.Add(this.iconButtonMinimize);
            this.panelTop.Controls.Add(this.iconButtonExit);
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(237, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(959, 35);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(2)))), ((int)(((byte)(29)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1041, 40);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(155, 537);
            this.panelRight.TabIndex = 6;
            // 
            // panelCentre
            // 
            this.panelCentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.panelCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentre.Location = new System.Drawing.Point(237, 40);
            this.panelCentre.Name = "panelCentre";
            this.panelCentre.Size = new System.Drawing.Size(804, 537);
            this.panelCentre.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 617);
            this.Controls.Add(this.panelCentre);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelUnderTop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelTopRight;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelUnderTop;
        private System.Windows.Forms.Label labelTop;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelCentre;
    }
}