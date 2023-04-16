namespace CSPaint
{
    partial class CSPaint
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            black = new ToolStripButton();
            white = new ToolStripButton();
            green = new ToolStripButton();
            red = new ToolStripButton();
            orange = new ToolStripButton();
            yellow = new ToolStripButton();
            blue = new ToolStripButton();
            purple = new ToolStripButton();
            pink = new ToolStripButton();
            clear = new ToolStripButton();
            file = new ToolStripMenuItem();
            open = new ToolStripMenuItem();
            openFile = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            canvas = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(115, 52);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 24);
            saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 24);
            openToolStripMenuItem.Text = "Open";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, openToolStripMenuItem1 });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(115, 52);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(114, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(114, 24);
            openToolStripMenuItem1.Text = "Open";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { black, white, green, red, orange, yellow, blue, purple, pink, clear });
            toolStrip1.Location = new Point(0, 36);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(61, 414);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // black
            // 
            black.AutoSize = false;
            black.BackColor = Color.Black;
            black.DisplayStyle = ToolStripItemDisplayStyle.Text;
            black.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            black.ForeColor = SystemColors.ButtonHighlight;
            black.ImageTransparentColor = Color.Magenta;
            black.Name = "black";
            black.Size = new Size(50, 35);
            black.Text = "Black";
            black.Click += black_Click;
            // 
            // white
            // 
            white.AutoSize = false;
            white.BackColor = Color.White;
            white.DisplayStyle = ToolStripItemDisplayStyle.Text;
            white.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            white.ImageTransparentColor = Color.Magenta;
            white.Margin = new Padding(5, 1, 5, 5);
            white.Name = "white";
            white.Size = new Size(50, 35);
            white.Text = "White";
            white.Click += white_Click;
            // 
            // green
            // 
            green.AutoSize = false;
            green.BackColor = Color.GreenYellow;
            green.DisplayStyle = ToolStripItemDisplayStyle.Text;
            green.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            green.ImageTransparentColor = Color.Magenta;
            green.Name = "green";
            green.Size = new Size(50, 35);
            green.Text = "Green";
            green.Click += green_Click;
            // 
            // red
            // 
            red.AutoSize = false;
            red.BackColor = Color.DarkRed;
            red.DisplayStyle = ToolStripItemDisplayStyle.Text;
            red.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            red.ForeColor = SystemColors.ButtonHighlight;
            red.ImageTransparentColor = Color.Magenta;
            red.Name = "red";
            red.Size = new Size(50, 35);
            red.Text = "Red";
            red.Click += red_Click;
            // 
            // orange
            // 
            orange.AutoSize = false;
            orange.BackColor = Color.Tomato;
            orange.DisplayStyle = ToolStripItemDisplayStyle.Text;
            orange.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            orange.ForeColor = SystemColors.ControlText;
            orange.ImageTransparentColor = Color.Magenta;
            orange.Name = "orange";
            orange.Size = new Size(50, 35);
            orange.Text = "Orange";
            orange.Click += orange_Click;
            // 
            // yellow
            // 
            yellow.AutoSize = false;
            yellow.BackColor = Color.Yellow;
            yellow.DisplayStyle = ToolStripItemDisplayStyle.Text;
            yellow.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            yellow.ImageTransparentColor = Color.Magenta;
            yellow.Name = "yellow";
            yellow.Size = new Size(50, 35);
            yellow.Text = "Yellow";
            yellow.Click += yellow_Click;
            // 
            // blue
            // 
            blue.AutoSize = false;
            blue.BackColor = Color.DeepSkyBlue;
            blue.DisplayStyle = ToolStripItemDisplayStyle.Text;
            blue.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            blue.ImageTransparentColor = Color.Magenta;
            blue.Name = "blue";
            blue.Size = new Size(50, 35);
            blue.Text = "Blue";
            blue.Click += blue_Click;
            // 
            // purple
            // 
            purple.AutoSize = false;
            purple.BackColor = Color.MediumOrchid;
            purple.DisplayStyle = ToolStripItemDisplayStyle.Text;
            purple.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            purple.ImageTransparentColor = Color.Magenta;
            purple.Name = "purple";
            purple.Size = new Size(50, 35);
            purple.Text = "Purple";
            purple.Click += purple_Click;
            // 
            // pink
            // 
            pink.AutoSize = false;
            pink.BackColor = Color.HotPink;
            pink.DisplayStyle = ToolStripItemDisplayStyle.Text;
            pink.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            pink.ImageTransparentColor = Color.Magenta;
            pink.Name = "pink";
            pink.Size = new Size(50, 35);
            pink.Text = "Pink";
            pink.Click += pink_Click;
            // 
            // clear
            // 
            clear.AutoSize = false;
            clear.BackColor = Color.Transparent;
            clear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            clear.Font = new Font("Bryndan Write", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            clear.ImageTransparentColor = Color.Magenta;
            clear.Margin = new Padding(0, 11, 0, 0);
            clear.Name = "clear";
            clear.Size = new Size(50, 35);
            clear.Text = "CLEAR";
            clear.Click += clear_Click;
            // 
            // file
            // 
            file.DisplayStyle = ToolStripItemDisplayStyle.Text;
            file.DropDownItems.AddRange(new ToolStripItem[] { open, openFile });
            file.Font = new Font("Bryndan Write", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            file.ForeColor = SystemColors.ActiveCaptionText;
            file.Name = "file";
            file.Size = new Size(68, 32);
            file.Text = "File";
            // 
            // open
            // 
            open.BackColor = Color.WhiteSmoke;
            open.Name = "open";
            open.Size = new Size(224, 32);
            open.Text = "Save";
            open.Click += onSave_Click;
            // 
            // openFile
            // 
            openFile.BackColor = Color.WhiteSmoke;
            openFile.Name = "openFile";
            openFile.Size = new Size(224, 32);
            openFile.Text = "Open";
            openFile.Click += open_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { file });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 36);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // canvas
            // 
            canvas.BackColor = Color.White;
            canvas.Location = new Point(64, 31);
            canvas.Name = "canvas";
            canvas.Size = new Size(715, 407);
            canvas.TabIndex = 5;
            canvas.TabStop = false;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            // 
            // CSPaint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(canvas);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CSPaint";
            Text = "CS Paint";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStrip toolStrip1;
        private ToolStripButton black;
        private ToolStripButton white;
        private ToolStripButton green;
        private ToolStripButton red;
        private ToolStripButton orange;
        private ToolStripButton yellow;
        private ToolStripButton blue;
        private ToolStripButton purple;
        private ToolStripButton clear;
        private ToolStripMenuItem file;
        private ToolStripMenuItem open;
        private ToolStripMenuItem openFile;
        private MenuStrip menuStrip1;
        private PictureBox canvas;
        private ToolStripButton pink;
        private SaveFileDialog saveFileDialog1;
    }
}