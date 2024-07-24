using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        private const string FilePath = "tasks.txt";

        public Form1()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string task = textBoxTask.Text.Trim();
            string dueDate = dateTimePickerDueDate.Value.ToShortDateString();
            string priority = comboBoxPriority.SelectedItem?.ToString() ?? "Low";

            if (!string.IsNullOrEmpty(task))
            {
                listBoxTasks.Items.Add($"{task} - {dueDate} - {priority}");
                textBoxTask.Clear();
                dateTimePickerDueDate.Value = DateTime.Now;
                comboBoxPriority.SelectedIndex = -1;
                SaveTasks();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                listBoxTasks.Items.Remove(listBoxTasks.SelectedItem);
                SaveTasks();
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMarkCompleted_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                int index = listBoxTasks.SelectedIndex;
                string task = listBoxTasks.SelectedItem.ToString();
                if (!task.EndsWith("(Completed)"))
                {
                    listBoxTasks.Items[index] = task + " (Completed)";
                    SaveTasks();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                var searchResults = listBoxTasks.Items.Cast<string>().Where(task => task.ToLower().Contains(searchQuery)).ToList();
                if (searchResults.Any())
                {
                    listBoxTasks.Items.Clear();
                    listBoxTasks.Items.AddRange(searchResults.ToArray());
                }
                else
                {
                    MessageBox.Show("No tasks found matching your search query.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search query.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveTasks()
        {
            File.WriteAllLines(FilePath, listBoxTasks.Items.Cast<string>());
        }

        private void LoadTasks()
        {
            if (File.Exists(FilePath))
            {
                string[] tasks = File.ReadAllLines(FilePath);
                listBoxTasks.Items.AddRange(tasks);
            }
        }
    }
}
