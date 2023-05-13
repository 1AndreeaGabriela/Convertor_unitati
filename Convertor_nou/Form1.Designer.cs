namespace Convertor_nou
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            greutateToolStripMenuItem = new ToolStripMenuItem();
            temperaturaToolStripMenuItem = new ToolStripMenuItem();
            lungimeToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pnl1 = new Panel();
            radioBtn6 = new RadioButton();
            radioBtn5 = new RadioButton();
            radioBtn4 = new RadioButton();
            radioBtn3 = new RadioButton();
            radioBtn2 = new RadioButton();
            radioBtn1 = new RadioButton();
            numUpDown = new NumericUpDown();
            lbl1 = new Label();
            btn1 = new Button();
            menuStrip1.SuspendLayout();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SeaGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { greutateToolStripMenuItem, temperaturaToolStripMenuItem, lungimeToolStripMenuItem, refreshToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // greutateToolStripMenuItem
            // 
            greutateToolStripMenuItem.Name = "greutateToolStripMenuItem";
            greutateToolStripMenuItem.Size = new Size(80, 24);
            greutateToolStripMenuItem.Text = "Greutate";
            greutateToolStripMenuItem.Click += greutateToolStripMenuItem_Click;
            // 
            // temperaturaToolStripMenuItem
            // 
            temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            temperaturaToolStripMenuItem.Size = new Size(107, 24);
            temperaturaToolStripMenuItem.Text = "Temperatura";
            temperaturaToolStripMenuItem.Click += temperaturaToolStripMenuItem_Click;
            // 
            // lungimeToolStripMenuItem
            // 
            lungimeToolStripMenuItem.Name = "lungimeToolStripMenuItem";
            lungimeToolStripMenuItem.Size = new Size(80, 24);
            lungimeToolStripMenuItem.Text = "Lungime";
            lungimeToolStripMenuItem.Click += lungimeToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(72, 24);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.DarkSeaGreen;
            pnl1.Controls.Add(radioBtn6);
            pnl1.Controls.Add(radioBtn5);
            pnl1.Controls.Add(radioBtn4);
            pnl1.Controls.Add(radioBtn3);
            pnl1.Controls.Add(radioBtn2);
            pnl1.Controls.Add(radioBtn1);
            pnl1.Controls.Add(numUpDown);
            pnl1.Controls.Add(lbl1);
            pnl1.Controls.Add(btn1);
            pnl1.Location = new Point(0, 31);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(800, 422);
            pnl1.TabIndex = 1;
            // 
            // radioBtn6
            // 
            radioBtn6.AutoSize = true;
            radioBtn6.Location = new Point(275, 189);
            radioBtn6.Name = "radioBtn6";
            radioBtn6.Size = new Size(95, 24);
            radioBtn6.TabIndex = 14;
            radioBtn6.TabStop = true;
            radioBtn6.Text = "radiobtn2";
            radioBtn6.UseVisualStyleBackColor = true;
            // 
            // radioBtn5
            // 
            radioBtn5.AutoSize = true;
            radioBtn5.Location = new Point(275, 159);
            radioBtn5.Name = "radioBtn5";
            radioBtn5.Size = new Size(95, 24);
            radioBtn5.TabIndex = 13;
            radioBtn5.TabStop = true;
            radioBtn5.Text = "radiobtn2";
            radioBtn5.UseVisualStyleBackColor = true;
            // 
            // radioBtn4
            // 
            radioBtn4.AutoSize = true;
            radioBtn4.Location = new Point(275, 129);
            radioBtn4.Name = "radioBtn4";
            radioBtn4.Size = new Size(95, 24);
            radioBtn4.TabIndex = 12;
            radioBtn4.TabStop = true;
            radioBtn4.Text = "radiobtn2";
            radioBtn4.UseVisualStyleBackColor = true;
            // 
            // radioBtn3
            // 
            radioBtn3.AutoSize = true;
            radioBtn3.Location = new Point(70, 189);
            radioBtn3.Name = "radioBtn3";
            radioBtn3.Size = new Size(95, 24);
            radioBtn3.TabIndex = 11;
            radioBtn3.TabStop = true;
            radioBtn3.Text = "radiobtn2";
            radioBtn3.UseVisualStyleBackColor = true;
            radioBtn3.CheckedChanged += radioBtn3_CheckedChanged;
            // 
            // radioBtn2
            // 
            radioBtn2.AutoSize = true;
            radioBtn2.Location = new Point(70, 159);
            radioBtn2.Name = "radioBtn2";
            radioBtn2.Size = new Size(95, 24);
            radioBtn2.TabIndex = 10;
            radioBtn2.TabStop = true;
            radioBtn2.Text = "radiobtn2";
            radioBtn2.UseVisualStyleBackColor = true;
            // 
            // radioBtn1
            // 
            radioBtn1.AutoSize = true;
            radioBtn1.Location = new Point(70, 129);
            radioBtn1.Name = "radioBtn1";
            radioBtn1.Size = new Size(117, 24);
            radioBtn1.TabIndex = 9;
            radioBtn1.TabStop = true;
            radioBtn1.Text = "radioButton1";
            radioBtn1.UseVisualStyleBackColor = true;
            radioBtn1.CheckedChanged += radioBtn1_CheckedChanged;
            // 
            // numUpDown
            // 
            numUpDown.Location = new Point(566, 176);
            numUpDown.Name = "numUpDown";
            numUpDown.Size = new Size(150, 27);
            numUpDown.TabIndex = 8;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(561, 209);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 20);
            lbl1.TabIndex = 7;
            lbl1.Text = "label1";
            // 
            // btn1
            // 
            btn1.Location = new Point(317, 294);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 54);
            btn1.TabIndex = 6;
            btn1.Text = "btn1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem greutateToolStripMenuItem;
        private ToolStripMenuItem temperaturaToolStripMenuItem;
        private ToolStripMenuItem lungimeToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel pnl1;
        private NumericUpDown numUpDown;
        private Label lbl1;
        private Button btn1;
        private RadioButton radioBtn2;
        private RadioButton radioBtn1;
        private RadioButton radioBtn6;
        private RadioButton radioBtn5;
        private RadioButton radioBtn4;
        private RadioButton radioBtn3;
    }
}