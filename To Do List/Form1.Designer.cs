namespace To_Do_List
{
    partial class ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            toDoListView = new DataGridView();
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(182, 39, 39);
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1336, 75);
            label1.TabIndex = 0;
            label1.Text = "To-Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.White;
            titleTextBox.Location = new Point(12, 120);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Title of your task";
            titleTextBox.Size = new Size(1336, 31);
            titleTextBox.TabIndex = 1;
            titleTextBox.UseWaitCursor = true;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.BackColor = Color.White;
            descriptionTextbox.Location = new Point(12, 188);
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.PlaceholderText = "Make miojo";
            descriptionTextbox.Size = new Size(1336, 31);
            descriptionTextbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // newButton
            // 
            newButton.Location = new Point(12, 236);
            newButton.Name = "newButton";
            newButton.Size = new Size(321, 39);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(352, 236);
            editButton.Name = "editButton";
            editButton.Size = new Size(321, 39);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(690, 236);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(321, 39);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1027, 236);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(321, 39);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = Color.White;
            toDoListView.BorderStyle = BorderStyle.None;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(12, 301);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 62;
            toDoListView.Size = new Size(1336, 613);
            toDoListView.TabIndex = 9;
            toDoListView.CellContentClick += toDoListView_CellContentClick;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Location = new Point(1260, 45);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(49, 25);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "Date";
            dateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1360, 926);
            Controls.Add(dateLabel);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionTextbox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ToDoList";
            Text = "To-Do App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextbox;
        private Label label2;
        private Label label3;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView toDoListView;
        private Label dateLabel;
    }
}
