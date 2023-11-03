namespace lab01
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelNumber = new ToolStripStatusLabel();
            result = new TextBox();
            StSurname = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            StSurname2 = new TextBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            TSurname = new TextBox();
            groupBox3 = new GroupBox();
            button3 = new Button();
            BusNumber = new TextBox();
            groupBox4 = new GroupBox();
            button4 = new Button();
            GradeTB = new TextBox();
            groupBox5 = new GroupBox();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 4, 0, 4);
            menuStrip1.Size = new Size(1150, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            loadToolStripMenuItem.Size = new Size(259, 34);
            loadToolStripMenuItem.Text = "Загрузить";
            loadToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabelNumber });
            statusStrip1.Location = new Point(0, 688);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(1150, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.ControlLight;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(117, 25);
            toolStripStatusLabel1.Text = "Число строк:";
            // 
            // toolStripStatusLabelNumber
            // 
            toolStripStatusLabelNumber.BackColor = SystemColors.ControlLight;
            toolStripStatusLabelNumber.Name = "toolStripStatusLabelNumber";
            toolStripStatusLabelNumber.Size = new Size(74, 25);
            toolStripStatusLabelNumber.Text = "number";
            // 
            // result
            // 
            result.Anchor = AnchorStyles.None;
            result.BackColor = SystemColors.ControlLight;
            result.Location = new Point(527, 54);
            result.Margin = new Padding(4, 5, 4, 5);
            result.Multiline = true;
            result.Name = "result";
            result.ScrollBars = ScrollBars.Vertical;
            result.Size = new Size(567, 586);
            result.TabIndex = 3;
            // 
            // StSurname
            // 
            StSurname.Cursor = Cursors.IBeam;
            StSurname.Location = new Point(20, 45);
            StSurname.Margin = new Padding(4);
            StSurname.Name = "StSurname";
            StSurname.PlaceholderText = " Фамилия студента";
            StSurname.Size = new Size(276, 31);
            StSurname.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(StSurname);
            groupBox1.Location = new Point(15, 54);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(494, 111);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task 1 (Поиск преподавателей студента)";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(332, 45);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 6;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StSurname2
            // 
            StSurname2.Cursor = Cursors.IBeam;
            StSurname2.Location = new Point(20, 45);
            StSurname2.Margin = new Padding(4);
            StSurname2.Name = "StSurname2";
            StSurname2.PlaceholderText = " Фамилия студента";
            StSurname2.Size = new Size(276, 31);
            StSurname2.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(StSurname2);
            groupBox2.Location = new Point(15, 172);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(494, 111);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task 2 (Поиск автобуса, на котором ездит студент)";
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(332, 45);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(126, 34);
            button2.TabIndex = 7;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TSurname
            // 
            TSurname.Cursor = Cursors.IBeam;
            TSurname.Location = new Point(20, 58);
            TSurname.Margin = new Padding(4);
            TSurname.Name = "TSurname";
            TSurname.PlaceholderText = " Фамилия преподавателя";
            TSurname.Size = new Size(276, 31);
            TSurname.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(TSurname);
            groupBox3.Location = new Point(15, 291);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(494, 111);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Task 3 (Список студентов, обучающиеся у преподавателя)";
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(332, 58);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(126, 34);
            button3.TabIndex = 8;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BusNumber
            // 
            BusNumber.Cursor = Cursors.IBeam;
            BusNumber.Location = new Point(20, 45);
            BusNumber.Margin = new Padding(4);
            BusNumber.Name = "BusNumber";
            BusNumber.PlaceholderText = " Номер автобуса";
            BusNumber.Size = new Size(276, 31);
            BusNumber.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightGray;
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(BusNumber);
            groupBox4.Location = new Point(15, 410);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(494, 111);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Task 4 (Поиск студента по автобусу)";
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(332, 45);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(126, 34);
            button4.TabIndex = 10;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // GradeTB
            // 
            GradeTB.Cursor = Cursors.IBeam;
            GradeTB.Location = new Point(20, 45);
            GradeTB.Margin = new Padding(4);
            GradeTB.Name = "GradeTB";
            GradeTB.PlaceholderText = " Степень обучения";
            GradeTB.Size = new Size(276, 31);
            GradeTB.TabIndex = 5;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.LightGray;
            groupBox5.Controls.Add(button5);
            groupBox5.Controls.Add(GradeTB);
            groupBox5.Location = new Point(15, 529);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(494, 111);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Task 5 (Поиск студента по степени обучения)";
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(332, 45);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(126, 34);
            button5.TabIndex = 12;
            button5.Text = "Поиск";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1150, 720);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(result);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "LAB01";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelNumber;
        private TextBox result;
        private TextBox StSurname;
        private GroupBox groupBox1;
        private TextBox StSurname2;
        private GroupBox groupBox2;
        private TextBox TSurname;
        private GroupBox groupBox3;
        private TextBox BusNumber;
        private GroupBox groupBox4;
        private TextBox GradeTB;
        private GroupBox groupBox5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}