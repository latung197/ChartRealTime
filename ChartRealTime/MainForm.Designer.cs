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
            rjDropdownMenu1 = new Resources.CustomControl.RJDropdownMenu(components);
            qwqwToolStripMenuItem = new ToolStripMenuItem();
            qwqToolStripMenuItem = new ToolStripMenuItem();
            qwToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            rjDropdownMenu2 = new Resources.CustomControl.RJDropdownMenu(components);
            rjDropdownMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.DisplayScale = 1F;
            chart1.Location = new Point(47, 104);
            chart1.Name = "chart1";
            chart1.Size = new Size(490, 376);
            chart1.TabIndex = 0;
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
            // rjDropdownMenu2
            // 
            rjDropdownMenu2.IsMainMenu = false;
            rjDropdownMenu2.MenuItemHeight = 25;
            rjDropdownMenu2.MenuItemTextColor = Color.Empty;
            rjDropdownMenu2.Name = "rjDropdownMenu2";
            rjDropdownMenu2.PrimaryColor = Color.Empty;
            rjDropdownMenu2.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 589);
            Controls.Add(chart1);
            Name = "MainForm";
            Text = "q";
            Load += MainForm_Load;
            rjDropdownMenu1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot chart1;
        private Resources.CustomControl.RJDropdownMenu rjDropdownMenu1;
        private ToolStripMenuItem qwqwToolStripMenuItem;
        private ToolStripMenuItem qwqToolStripMenuItem;
        private ToolStripMenuItem qwToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private Resources.CustomControl.RJDropdownMenu rjDropdownMenu2;
    }
}
