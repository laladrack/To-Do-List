using System.Data;
using System.Data.Common;

namespace To_Do_List
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");
            todoList.Columns.Add("Tag");
            todoList.Columns.Add("Priority");
            todoList.Columns.Add("Status");

            //datagridview to datasource
            toDoListView.DataSource = todoList;
        }

        private void toDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextbox.Text = "";
            tagsTextbox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // fill text fields with data
            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
            tagsTextbox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[2].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextbox.Text;
            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextbox.Text, tagsTextbox.Text);
            }
            // clear fields
            titleTextBox.Text = "";
            descriptionTextbox.Text = "";
            tagsTextbox.Text = "";
            isEditing = false;
        }
    }
}
