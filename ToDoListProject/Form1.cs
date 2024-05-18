using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ToDoListProject
{
    public partial class Form1 : Form
    {
        private string filename = "TasksCollection.json";
        public List<TaskConteinerData> taskConteinerData = new List<TaskConteinerData>();
        public List<ModifiedButton> ModifiedButtons = new List<ModifiedButton>();

        public void SortTasksByPriority()
        {
            foreach (var taskConteiner in taskConteinerData)
            {
                taskConteiner.tasks.Sort((task1, task2) => task2.Priority.CompareTo(task1.Priority));
            }
        }

        public TaskConteinerData FindTaskConteinerData(string name)
        {
            for (int i = 0; i < taskConteinerData.Count; i++)
            {
                if (taskConteinerData[i].Name == name)
                {
                    return taskConteinerData[i];
                }
            }
            throw new Exception();
        }
        public ModifiedButton FindModifiedButton(string name)
        {
            for (int i = 0; i < ModifiedButtons.Count; i++)
            {
                if (ModifiedButtons[i].Text == name)
                {
                    return ModifiedButtons[i];
                }
            }
            throw new Exception();
        }
        public Form1()
        {
            InitializeComponent();
            LoadTaskCollectionsFromJson(filename);
            TaskCollection_Click(ModifiedButtons[0], EventArgs.Empty);
        }
        public void AdjustLayout(Panel container)
        {
            int totalHeight = 0;
            foreach (Control control in container.Controls)
            {
                totalHeight += control.Height;
            }

            if (totalHeight > container.Height)
            {
                container.AutoScroll = true;
            }
            else
            {
                container.AutoScroll = false;
            }
        }

        private void UpdateTasks(TaskConteinerData taskConteiner)
        {
            panelTasks.Controls.Clear();
            ModifiedButton button = ModifiedButtons.Find(b => b.Text == taskConteiner.Name);
            if (button != null)
            {
                foreach (TaskData item in taskConteiner.tasks)
                {
                    TaskControl newTask = new TaskControl() { Text = item.Name };
                    newTask.checkBox.Checked = item.IsCompleted;
                    newTask.ShowTask(panelTasks);
                    newTask.Click += TaskControl_Click;
                }
                AdjustLayout(panelTasks);
            }
        }

        private void AddTaskConteiner(string buttonText, Image buttonImage, int count, List<TaskData> tasks)
        {
            ShowTaskConteiner(buttonText, buttonImage, count, tasks);
            taskConteinerData.Add(new TaskConteinerData() { Name = buttonText, tasks = tasks});
        }
        private void ShowTaskConteiner(string buttonText, Image buttonImage, int count, List<TaskData> tasks)
        {
            ModifiedButton newButton = new ModifiedButton() { Text = buttonText, Image = buttonImage, CountTasks = count };
            newButton.Dock = DockStyle.Top;
            panelTaskCollection.Controls.Add(newButton);
            newButton.BringToFront();
            AdjustLayout(panelTaskCollection);
            newButton.Show();

            newButton.Click += TaskCollection_Click;
            newButton.MouseDown += TaskCollection_MouseDown;
            ModifiedButtons.Add(newButton);
        }
        private void TaskCollection_Click(object sender, EventArgs e)
        {

            panelTasks.Controls.Clear();
            
            if (sender is ModifiedButton clickedTaskCollection)
            {
                textBoxNameList.Text = clickedTaskCollection.Text;
                int i = 0;
                for (; i < taskConteinerData.Count; i++)
                {
                    if (taskConteinerData[i].Name == textBoxNameList.Text)
                        break;
                }

                foreach (TaskData item in taskConteinerData[i].tasks)
                {
                    TaskControl newTask = new TaskControl() { Text = item.Name };
                    newTask.checkBox.Checked = item.IsCompleted;
                    newTask.ShowTask(panelTasks);
                    newTask.Click += TaskControl_Click;
                }

            }
        }
        private void TaskCollection_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                ToolStripMenuItem renameMenuItem = new ToolStripMenuItem("Перейменувати");
                ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Видалити");
                contextMenu.Items.AddRange(new ToolStripItem[] { renameMenuItem, deleteMenuItem });
                renameMenuItem.Click += RenameMenuItem_Click;
                deleteMenuItem.Click += DeleteMenuItem_Click;
                ModifiedButton button = sender as ModifiedButton;
                contextMenu.Show(button, e.Location);
            }
        }

        private void RenameMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Owner is ContextMenuStrip contextMenu && contextMenu.SourceControl is ModifiedButton button)
                {
                    button.textBox.Enabled = true;
                    button.textBox.ReadOnly = false; 
                    button.textBox.Focus();

                    button.textBox.Tag = button.Text;
                    button.textBox.KeyDown += TextBox_KeyDown;
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as System.Windows.Forms.TextBox).Parent is ModifiedButton)
                {
                    ModifiedButton button = (sender as System.Windows.Forms.TextBox).Parent as ModifiedButton;
                    button.textBox.Enabled = false;
                    button.textBox.ReadOnly = true;
                    button.textBox.KeyDown -= TextBox_KeyDown;
                    if (!string.IsNullOrWhiteSpace(button.textBox.Text))
                    {
                        button.Text = button.textBox.Text;
                    }
                    else
                    {
                        button.Text = button.textBox.Tag.ToString();
                    }
                    TaskConteinerData temp = FindTaskConteinerData(button.textBox.Tag.ToString());
                    temp.Name = button.textBox.Text;
                    textBoxNameList.Text = temp.Name;
                }
                else 
                {
                    if (!string.IsNullOrWhiteSpace(textBoxTaskName.Text))
                    {
                        TaskConteinerData temp = FindTaskConteinerData(textBoxTaskName.Text);
                        temp.Name = textBoxTaskName.Text;
                        UpdateTasks(temp);
                    }
                    else
                    {
                        textBoxTaskName.Text = textBoxTaskName.Tag.ToString();
                    }
                }
            }
        }

        private void textBoxTaskName_Click(object sender, EventArgs e)
        {
            textBoxTaskName.Focus();
            textBoxTaskName.Tag = textBoxTaskName.Text;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Owner is ContextMenuStrip contextMenu && contextMenu.SourceControl is ModifiedButton button)
                {
                    RemoveButton(button);
                }
            }
        }

        private void RemoveButton(ModifiedButton button)
        {
            panelTaskCollection.Controls.Remove(button);

            ModifiedButtons.Remove(button);

            foreach (var conteiner in taskConteinerData)
            {
                if (conteiner.Name == button.Text)
                {
                    taskConteinerData.Remove(conteiner);
                    break;
                }
            }
        }
        private int unnamedContainerCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string containerName = "Список без назви";
            if (unnamedContainerCount > 0)
            {
                containerName += $" ({unnamedContainerCount})";
            }
            AddTaskConteiner(containerName, null, 0, new List<TaskData>());
            unnamedContainerCount++;
        }

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {
            toolStripTextBox1.ForeColor = SystemColors.ControlText;
            toolStripDropDownButton1.Enabled = true;
            if (toolStripTextBox1.Text == "Додайте завдання")
                toolStripTextBox1.Text = string.Empty;
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
            {
                toolStripTextBox1.Text = "Додайте завдання";
                toolStripTextBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && toolStripTextBox1.Text != string.Empty)
            {
                TaskControl newTask = new TaskControl() { Text = toolStripTextBox1.Text };
                newTask.Dock = DockStyle.Top;
                panelTasks.Controls.Add(newTask);
                TaskConteinerData taskConteinerData = FindTaskConteinerData(textBoxNameList.Text);
                ModifiedButton button = FindModifiedButton(textBoxNameList.Text);
                taskConteinerData.tasks.Add(new TaskData() { Name = toolStripTextBox1.Text });
                button.CountTasks++;
                
                newTask.BringToFront();
                AdjustLayout(panelTasks);
                newTask.Show();
                toolStripTextBox1.Text = string.Empty;
                newTask.Click += TaskControl_Click;
                toolStripDropDownButton1.Enabled = false;
            }
        }
        private void SaveTaskCollectionsToJson(string filename)
        {
            string json = JsonConvert.SerializeObject(taskConteinerData);
            File.WriteAllText(filename, json);
        }

        private void LoadTaskCollectionsFromJson(string filename)
        {
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                taskConteinerData = JsonConvert.DeserializeObject<List<TaskConteinerData>>(json);
                RefreshTaskCollectionButtons();
            }
        }

        private void RefreshTaskCollectionButtons()
        {
            panelTaskCollection.Controls.Clear();
            foreach (var taskConteiner in taskConteinerData)
            {
                ShowTaskConteiner(taskConteiner.Name, null, taskConteiner.tasks.Count, taskConteiner.tasks);
                foreach(var task in taskConteiner.tasks)
                {
                    TaskControl newTask = new TaskControl() { Text = task.Name };
                    newTask.Dock = DockStyle.Top;
                    panelTasks.Controls.Add(newTask);
                    newTask.BringToFront();
                    AdjustLayout(panelTasks);
                    newTask.Show();
                }
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            SaveTaskCollectionsToJson(filename);
        }


        private void сьогодніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskData taskData = FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == checkBox1.Text);
            taskData.Date = DateTime.Today;
            labelDate.Text = taskData.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            panelDate.Visible = true;
        }

        private void завтраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskData taskData = FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == checkBox1.Text);
            taskData.Date = DateTime.Today.AddDays(1);
            labelDate.Text = taskData.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            panelDate.Visible = true;
        }

        private void виберітьДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var monthCalendar = new MonthCalendar();
            monthCalendar.DateSelected += MonthCalendar_DateSelected;

            Point location = toolStripDropDownButton1.Bounds.Location;
            location.Offset(toolStripDropDownButton1.Width, Height-235);
            monthCalendar.Location = location;
            Controls.Add(monthCalendar);
            monthCalendar.BringToFront();
            
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            TaskData taskData = FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == checkBox1.Text);
            if (sender is MonthCalendar monthCalendar)
            {
                taskData.Date = monthCalendar.SelectionStart;
                Controls.Remove(monthCalendar);
            }
            labelDate.Text = taskData.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            panelDate.Visible = true;
        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            
            //checkBox1.Text = task.Text;
            //timer1.Start();
            //checkBox1.Checked = task.checkBox.Checked;
            //task.checkBox.CheckedChanged += (s, ev) =>
            //{
            //    checkBox1.Checked = task.checkBox.Checked;
            //};
            //checkBox1.CheckedChanged += (s, ev) =>
            //{
            //    task.checkBox.Checked = checkBox1.Checked;
            //};
            //timer1.Stop();
        }
        private void TaskControl_Click(object sender, EventArgs e)
        {
            panelTaskProp.Visible = true;
            if (sender is TaskControl task)
            {
                checkBox1.Text = task.Text;
                textBoxTaskName.Text = task.Text;
                checkBox1.Checked = task.checkBox.Checked;    
                TaskData taskData = FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == task.Text);
                textBox1.Text = taskData.MultiText;
                if (textBox1.Text == string.Empty)
                    textBox1.Text = "Додати нотатку";
                switch (taskData.Priority)
                {
                    case 0:
                        radioButton1.Checked = true;
                        break;
                    case 1:
                        radioButton2.Checked = true;
                        break;
                    case 2:
                        radioButton3.Checked = true;
                        break;
                }
                if (taskData.Date == DateTime.MinValue)
                    panelDate.Visible = false;
                else
                {
                    panelDate.Visible = true;
                    labelDate.Text = taskData.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                if (taskData.Time == TimeOnly.MinValue)
                    panelTime.Visible = false;
                else
                {
                    panelTime.Visible = true;
                    labelTime.Text = taskData.Time.ToString("hh:mm");
                }
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (Width <= 700)
                panel1.Hide();
            else
                panel1.Show();

        }

        private void buttonCloseTaskProp_Click(object sender, EventArgs e)
        {
            panelTaskProp.Visible = false;
            TaskData task =  FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == checkBox1.Text);
            if(textBox1.Text != "Додати нотатку")
                task.MultiText = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TaskControl task = panelTasks.Controls.OfType<TaskControl>()
        .    FirstOrDefault(tc => tc.Text == checkBox1.Text);

            panelTasks.Controls.Remove(task);
            TaskConteinerData taskConteiner = taskConteinerData.FirstOrDefault(tc => tc.Name == textBoxNameList.Text);

            if (taskConteiner != null)
            {
                taskConteiner.tasks.RemoveAll(td => td.Name == task.Text);
            }
            panelTaskProp.Visible = false;
            ModifiedButton mButton = FindModifiedButton(textBoxNameList.Text);
            mButton.CountTasks--;
            mButton.Invalidate();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.ForeColor = SystemColors.ControlText;
            if (textBox1.Text == "Додати нотатку")
                textBox1.Text = string.Empty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Додати нотатку";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void radioButtonPriority_CheckedChanged(object sender, EventArgs e)
        {
            TaskData task = FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == checkBox1.Text);
            foreach (var control in groupBox1.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                {
                    task.Priority = int.Parse(radioButton.Tag.ToString());
                }
            }
            SortTasksByPriority();
            UpdateTasks(FindTaskConteinerData(textBoxNameList.Text));
        }


        private void buttonRemoveDate_Click(object sender, EventArgs e)
        {
            TaskData task = FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == checkBox1.Text);
            task.Date = DateTime.MinValue;
            panelDate.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panelTimeSet.Visible = true;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelTimeSet.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelTimeSet.Visible = false;
            TaskData task = FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == checkBox1.Text);
            task.Time = new TimeOnly((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            panelDate.Visible = false;
            labelTime.Text = task.Time.ToString("hh:mm");
            panelTime.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TaskData task = FindTaskConteinerData(textBoxNameList.Text).tasks.Find(m => m.Name == checkBox1.Text);
            task.Time = TimeOnly.MinValue;
            panelTime.Visible = false;
        }

    }

}