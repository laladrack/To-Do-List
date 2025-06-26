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
            todoList.Columns.Add("Priority");
            todoList.Columns.Add("Status");

            //datagridview to datasource
            toDoListView.DataSource = todoList;
        }

        private void toDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
