namespace ToDoListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Button buttonMarkCompleted;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.buttonMarkCompleted = new System.Windows.Forms.Button();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(9, 10);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(208, 20);
            this.textBoxTask.TabIndex = 0;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(220, 9);
            this.buttonAddTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(70, 19);
            this.buttonAddTask.TabIndex = 1;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(9, 57);
            this.listBoxTasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(283, 160);
            this.listBoxTasks.TabIndex = 2;
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.Location = new System.Drawing.Point(9, 221);
            this.buttonRemoveTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(90, 19);
            this.buttonRemoveTask.TabIndex = 3;
            this.buttonRemoveTask.Text = "Remove Task";
            this.buttonRemoveTask.UseVisualStyleBackColor = true;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // buttonMarkCompleted
            // 
            this.buttonMarkCompleted.Location = new System.Drawing.Point(201, 221);
            this.buttonMarkCompleted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMarkCompleted.Name = "buttonMarkCompleted";
            this.buttonMarkCompleted.Size = new System.Drawing.Size(90, 19);
            this.buttonMarkCompleted.TabIndex = 4;
            this.buttonMarkCompleted.Text = "Mark Completed";
            this.buttonMarkCompleted.UseVisualStyleBackColor = true;
            this.buttonMarkCompleted.Click += new System.EventHandler(this.buttonMarkCompleted_Click);
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(9, 32);
            this.dateTimePickerDueDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerDueDate.TabIndex = 5;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxPriority.Location = new System.Drawing.Point(164, 32);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(128, 21);
            this.comboBoxPriority.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(9, 245);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(208, 20);
            this.textBoxSearch.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(220, 244);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(70, 19);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 272);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.buttonMarkCompleted);
            this.Controls.Add(this.buttonRemoveTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.textBoxTask);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "To-Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
