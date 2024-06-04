namespace ChartRealTime
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            chart1 = new ScottPlot.WinForms.FormsPlot();
            rjButton1 = new Resources.CustomControl.RJButton();
            rjToggleButton1 = new Resources.CustomControl.RJToggleButton();
            rjToggleButton2 = new Resources.CustomControl.RJToggleButton();
            rjComboBox1 = new Resources.CustomControl.RJComboBox();
            rjDropdownMenu1 = new Resources.CustomControl.RJDropdownMenu(components);
            qwqwToolStripMenuItem = new ToolStripMenuItem();
            qwqToolStripMenuItem = new ToolStripMenuItem();
            qwToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            rjDropdownMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.DisplayScale = 1F;
            chart1.Location = new Point(176, 104);
            chart1.Name = "chart1";
            chart1.Size = new Size(453, 294);
            chart1.TabIndex = 0;
            chart1.Load += chart1_Load;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(584, 138);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(161, 37);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "rjButton1";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjToggleButton1
            // 
            rjToggleButton1.AutoSize = true;
            rjToggleButton1.Location = new Point(584, 89);
            rjToggleButton1.MinimumSize = new Size(45, 22);
            rjToggleButton1.Name = "rjToggleButton1";
            rjToggleButton1.OffBackColor = Color.Gray;
            rjToggleButton1.OffToggleColor = Color.Gainsboro;
            rjToggleButton1.OnBackColor = Color.MediumSlateBlue;
            rjToggleButton1.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton1.Size = new Size(45, 22);
            rjToggleButton1.TabIndex = 2;
            rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // rjToggleButton2
            // 
            rjToggleButton2.AutoSize = true;
            rjToggleButton2.Location = new Point(574, 227);
            rjToggleButton2.MinimumSize = new Size(45, 22);
            rjToggleButton2.Name = "rjToggleButton2";
            rjToggleButton2.OffBackColor = Color.Gray;
            rjToggleButton2.OffToggleColor = Color.Gainsboro;
            rjToggleButton2.OnBackColor = Color.MediumSlateBlue;
            rjToggleButton2.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton2.Size = new Size(45, 22);
            rjToggleButton2.TabIndex = 3;
            rjToggleButton2.UseVisualStyleBackColor = true;
            // 
            // rjComboBox1
            // 
            rjComboBox1.BackColor = Color.WhiteSmoke;
            rjComboBox1.BorderColor = Color.MediumSlateBlue;
            rjComboBox1.BorderSize = 1;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rjComboBox1.ForeColor = Color.DimGray;
            rjComboBox1.IconColor = Color.MediumSlateBlue;
            rjComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            rjComboBox1.ListTextColor = Color.DimGray;
            rjComboBox1.Location = new Point(543, 269);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.Padding = new Padding(1);
            rjComboBox1.Size = new Size(200, 30);
            rjComboBox1.TabIndex = 4;
            rjComboBox1.Texts = "";
            // 
            // rjDropdownMenu1
            // 
            rjDropdownMenu1.IsMainMenu = false;
            rjDropdownMenu1.Items.AddRange(new ToolStripItem[] { qwqwToolStripMenuItem, qwqToolStripMenuItem, qwToolStripMenuItem, eToolStripMenuItem });
            rjDropdownMenu1.MenuItemHeight = 25;
            rjDropdownMenu1.MenuItemTextColor = Color.Empty;
            rjDropdownMenu1.Name = "rjDropdownMenu1";
            rjDropdownMenu1.PrimaryColor = Color.Empty;
            rjDropdownMenu1.Size = new Size(107, 92);
            // 
            // qwqwToolStripMenuItem
            // 
            qwqwToolStripMenuItem.Name = "qwqwToolStripMenuItem";
            qwqwToolStripMenuItem.Size = new Size(106, 22);
            qwqwToolStripMenuItem.Text = "qwqw";
            // 
            // qwqToolStripMenuItem
            // 
            qwqToolStripMenuItem.Name = "qwqToolStripMenuItem";
            qwqToolStripMenuItem.Size = new Size(106, 22);
            qwqToolStripMenuItem.Text = "qwq";
            // 
            // qwToolStripMenuItem
            // 
            qwToolStripMenuItem.Name = "qwToolStripMenuItem";
            qwToolStripMenuItem.Size = new Size(106, 22);
            qwToolStripMenuItem.Text = "qw";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(106, 22);
            eToolStripMenuItem.Text = "e";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 589);
            Controls.Add(rjComboBox1);
            Controls.Add(rjToggleButton2);
            Controls.Add(rjToggleButton1);
            Controls.Add(rjButton1);
            Controls.Add(chart1);
            Name = "MainForm";
            Text = "q";
            rjDropdownMenu1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot chart1;
        private Resources.CustomControl.RJButton rjButton1;
        private Resources.CustomControl.RJToggleButton rjToggleButton1;
        private Resources.CustomControl.RJToggleButton rjToggleButton2;
        private Resources.CustomControl.RJComboBox rjComboBox1;
        private Resources.CustomControl.RJDropdownMenu rjDropdownMenu1;
        private ToolStripMenuItem qwqwToolStripMenuItem;
        private ToolStripMenuItem qwqToolStripMenuItem;
        private ToolStripMenuItem qwToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
    }
}
