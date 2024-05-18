namespace ToDoListProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTaskCollection = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.сьогодніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завтраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.виберітьДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTaskProp = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRemoveTime = new System.Windows.Forms.Button();
            this.panelTimeSet = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panelDate = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveDate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonCloseTaskProp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.термінToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сьогодніToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завтраToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.виберітьДатуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTasks = new System.Windows.Forms.Panel();
            this.textBoxNameList = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelTaskProp.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelTimeSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelTaskCollection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 461);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додати список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTaskCollection
            // 
            this.panelTaskCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelTaskCollection.Location = new System.Drawing.Point(0, 82);
            this.panelTaskCollection.Name = "panelTaskCollection";
            this.panelTaskCollection.Size = new System.Drawing.Size(304, 337);
            this.panelTaskCollection.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.panelTaskProp);
            this.panel2.Controls.Add(this.panelTasks);
            this.panel2.Controls.Add(this.textBoxNameList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 461);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 436);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(172, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 25);
            this.toolStripTextBox1.Text = "Додайте завдання";
            this.toolStripTextBox1.Enter += new System.EventHandler(this.toolStripTextBox1_Enter);
            this.toolStripTextBox1.Leave += new System.EventHandler(this.toolStripTextBox1_Leave);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.AboveRight;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сьогодніToolStripMenuItem,
            this.завтраToolStripMenuItem,
            this.toolStripSeparator1,
            this.виберітьДатуToolStripMenuItem});
            this.toolStripDropDownButton1.Enabled = false;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // сьогодніToolStripMenuItem
            // 
            this.сьогодніToolStripMenuItem.Name = "сьогодніToolStripMenuItem";
            this.сьогодніToolStripMenuItem.ShowShortcutKeys = false;
            this.сьогодніToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.сьогодніToolStripMenuItem.Text = "Сьогодні";
            this.сьогодніToolStripMenuItem.Click += new System.EventHandler(this.сьогодніToolStripMenuItem_Click);
            // 
            // завтраToolStripMenuItem
            // 
            this.завтраToolStripMenuItem.Name = "завтраToolStripMenuItem";
            this.завтраToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.завтраToolStripMenuItem.Text = "Завтра";
            this.завтраToolStripMenuItem.Click += new System.EventHandler(this.завтраToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // виберітьДатуToolStripMenuItem
            // 
            this.виберітьДатуToolStripMenuItem.Name = "виберітьДатуToolStripMenuItem";
            this.виберітьДатуToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.виберітьДатуToolStripMenuItem.Text = "Виберіть дату";
            this.виберітьДатуToolStripMenuItem.Click += new System.EventHandler(this.виберітьДатуToolStripMenuItem_Click);
            // 
            // panelTaskProp
            // 
            this.panelTaskProp.Controls.Add(this.panelTime);
            this.panelTaskProp.Controls.Add(this.panelTimeSet);
            this.panelTaskProp.Controls.Add(this.panelDate);
            this.panelTaskProp.Controls.Add(this.button5);
            this.panelTaskProp.Controls.Add(this.textBoxTaskName);
            this.panelTaskProp.Controls.Add(this.button4);
            this.panelTaskProp.Controls.Add(this.groupBox1);
            this.panelTaskProp.Controls.Add(this.textBox1);
            this.panelTaskProp.Controls.Add(this.checkBox1);
            this.panelTaskProp.Controls.Add(this.buttonCloseTaskProp);
            this.panelTaskProp.Controls.Add(this.menuStrip1);
            this.panelTaskProp.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTaskProp.Location = new System.Drawing.Point(172, 0);
            this.panelTaskProp.Name = "panelTaskProp";
            this.panelTaskProp.Size = new System.Drawing.Size(308, 461);
            this.panelTaskProp.TabIndex = 4;
            this.panelTaskProp.Visible = false;
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.labelTime);
            this.panelTime.Controls.Add(this.label3);
            this.panelTime.Controls.Add(this.buttonRemoveTime);
            this.panelTime.Location = new System.Drawing.Point(36, 229);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(255, 35);
            this.panelTime.TabIndex = 11;
            this.panelTime.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(64, 5);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 21);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Час:";
            // 
            // buttonRemoveTime
            // 
            this.buttonRemoveTime.Location = new System.Drawing.Point(206, 2);
            this.buttonRemoveTime.Name = "buttonRemoveTime";
            this.buttonRemoveTime.Size = new System.Drawing.Size(42, 30);
            this.buttonRemoveTime.TabIndex = 0;
            this.buttonRemoveTime.Text = "button6";
            this.buttonRemoveTime.UseVisualStyleBackColor = true;
            this.buttonRemoveTime.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelTimeSet
            // 
            this.panelTimeSet.Controls.Add(this.button7);
            this.panelTimeSet.Controls.Add(this.button6);
            this.panelTimeSet.Controls.Add(this.numericUpDown2);
            this.panelTimeSet.Controls.Add(this.numericUpDown1);
            this.panelTimeSet.Location = new System.Drawing.Point(36, 270);
            this.panelTimeSet.Name = "panelTimeSet";
            this.panelTimeSet.Size = new System.Drawing.Size(208, 97);
            this.panelTimeSet.TabIndex = 8;
            this.panelTimeSet.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(113, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 31);
            this.button7.TabIndex = 3;
            this.button7.Text = "Зберегти";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 31);
            this.button6.TabIndex = 2;
            this.button6.Text = "Скасувати";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(113, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.labelDate);
            this.panelDate.Controls.Add(this.label1);
            this.panelDate.Controls.Add(this.buttonRemoveDate);
            this.panelDate.Location = new System.Drawing.Point(36, 191);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(255, 35);
            this.panelDate.TabIndex = 10;
            this.panelDate.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(64, 5);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 21);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Термін:";
            // 
            // buttonRemoveDate
            // 
            this.buttonRemoveDate.Location = new System.Drawing.Point(206, 2);
            this.buttonRemoveDate.Name = "buttonRemoveDate";
            this.buttonRemoveDate.Size = new System.Drawing.Size(42, 30);
            this.buttonRemoveDate.TabIndex = 0;
            this.buttonRemoveDate.Text = "button6";
            this.buttonRemoveDate.UseVisualStyleBackColor = true;
            this.buttonRemoveDate.Click += new System.EventHandler(this.buttonRemoveDate_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 26);
            this.button5.TabIndex = 9;
            this.button5.Text = "Додати час";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(43, 46);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(206, 23);
            this.textBoxTaskName.TabIndex = 8;
            this.textBoxTaskName.Click += new System.EventHandler(this.textBoxTaskName_Click);
            this.textBoxTaskName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Видалити";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(24, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 103);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пріорітет";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 19);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "Високий";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtonPriority_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 19);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "Середній";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtonPriority_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 19);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "Низький";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonPriority_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(24, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 104);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Додати нотатку";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // buttonCloseTaskProp
            // 
            this.buttonCloseTaskProp.Location = new System.Drawing.Point(213, 12);
            this.buttonCloseTaskProp.Name = "buttonCloseTaskProp";
            this.buttonCloseTaskProp.Size = new System.Drawing.Size(78, 23);
            this.buttonCloseTaskProp.TabIndex = 0;
            this.buttonCloseTaskProp.Text = "Закрити";
            this.buttonCloseTaskProp.UseVisualStyleBackColor = true;
            this.buttonCloseTaskProp.Click += new System.EventHandler(this.buttonCloseTaskProp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.термінToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(43, 205);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(106, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // термінToolStripMenuItem
            // 
            this.термінToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сьогодніToolStripMenuItem1,
            this.завтраToolStripMenuItem1,
            this.toolStripSeparator2,
            this.виберітьДатуToolStripMenuItem1});
            this.термінToolStripMenuItem.Name = "термінToolStripMenuItem";
            this.термінToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.термінToolStripMenuItem.Text = "Додати термін";
            // 
            // сьогодніToolStripMenuItem1
            // 
            this.сьогодніToolStripMenuItem1.Name = "сьогодніToolStripMenuItem1";
            this.сьогодніToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.сьогодніToolStripMenuItem1.Text = "Сьогодні";
            this.сьогодніToolStripMenuItem1.Click += new System.EventHandler(this.сьогодніToolStripMenuItem_Click);
            // 
            // завтраToolStripMenuItem1
            // 
            this.завтраToolStripMenuItem1.Name = "завтраToolStripMenuItem1";
            this.завтраToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.завтраToolStripMenuItem1.Text = "Завтра";
            this.завтраToolStripMenuItem1.Click += new System.EventHandler(this.завтраToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // виберітьДатуToolStripMenuItem1
            // 
            this.виберітьДатуToolStripMenuItem1.Name = "виберітьДатуToolStripMenuItem1";
            this.виберітьДатуToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.виберітьДатуToolStripMenuItem1.Text = "Виберіть дату";
            this.виберітьДатуToolStripMenuItem1.Click += new System.EventHandler(this.виберітьДатуToolStripMenuItem_Click);
            // 
            // panelTasks
            // 
            this.panelTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTasks.AutoScroll = true;
            this.panelTasks.AutoSize = true;
            this.panelTasks.BackColor = System.Drawing.Color.Gray;
            this.panelTasks.Location = new System.Drawing.Point(37, 67);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelTasks.Size = new System.Drawing.Size(412, 316);
            this.panelTasks.TabIndex = 3;
            // 
            // textBoxNameList
            // 
            this.textBoxNameList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameList.Location = new System.Drawing.Point(37, 22);
            this.textBoxNameList.MinimumSize = new System.Drawing.Size(200, 0);
            this.textBoxNameList.Name = "textBoxNameList";
            this.textBoxNameList.Size = new System.Drawing.Size(300, 23);
            this.textBoxNameList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(365, 500);
            this.Name = "Form1";
            this.Text = "ListToDo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelTaskProp.ResumeLayout(false);
            this.panelTaskProp.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelTimeSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private TextBox textBoxNameList;
        private Button button1;
        private Panel panelTaskCollection;
        private Panel panelTasks;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem сьогодніToolStripMenuItem;
        private ToolStripMenuItem завтраToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem виберітьДатуToolStripMenuItem;
        private Panel panelTaskProp;
        private Button buttonCloseTaskProp;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem термінToolStripMenuItem;
        private ToolStripMenuItem сьогодніToolStripMenuItem1;
        private ToolStripMenuItem завтраToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem виберітьДатуToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
        private TextBox textBoxTaskName;
        private Button button5;
        private Panel panelDate;
        private Label labelDate;
        private Label label1;
        private Button buttonRemoveDate;
        private Panel panelTimeSet;
        private Button button7;
        private Button button6;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Panel panelTime;
        private Label labelTime;
        private Label label3;
        private Button buttonRemoveTime;
    }
}