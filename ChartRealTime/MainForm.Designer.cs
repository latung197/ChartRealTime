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
            rjDropdownMenu1 = new Resources.CustomControl.RJDropdownMenu(components);
            qwqwToolStripMenuItem = new ToolStripMenuItem();
            qwqToolStripMenuItem = new ToolStripMenuItem();
            qwToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            rjDropdownMenu2 = new Resources.CustomControl.RJDropdownMenu(components);
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            formsPlot1 = new ScottPlot.FormsPlot();
            rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1018, 627);
            splitContainer1.SplitterDistance = 80;
            splitContainer1.TabIndex = 2;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(934, 627);
            splitContainer2.SplitterDistance = 502;
            splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(formsPlot1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(502, 627);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(4, 3);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(494, 307);
            formsPlot1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 627);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "q";
            Load += MainForm_Load;
            rjDropdownMenu1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Resources.CustomControl.RJDropdownMenu rjDropdownMenu1;
        private ToolStripMenuItem qwqwToolStripMenuItem;
        private ToolStripMenuItem qwqToolStripMenuItem;
        private ToolStripMenuItem qwToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private Resources.CustomControl.RJDropdownMenu rjDropdownMenu2;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.FormsPlot formsPlot1;
    }
}
