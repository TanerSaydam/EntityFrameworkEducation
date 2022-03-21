using EntityFrameworkEducation.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EntityFrameworkEducation
{
    public partial class Form1 : Form
    {
        //SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-3BJ5GK9;Database=BookStore;Integrated Security=true");
        //BookManager bookManager = new BookManager();
        IBookService _bookService;
        IEducationService _educationService;
        public Form1(IBookService bookService, IEducationService educationService)
        {
            InitializeComponent();
            _bookService = bookService;
            _educationService = educationService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ContextDb contextDb = new ContextDb();
            //var result = contextDb.Books.ToList();

            var result = _bookService.GetBooks();

            //SqlDataAdapter adapter = new SqlDataAdapter("Select * From Books",sqlConnection);  
            //DataTable dataTable = new DataTable();
            //dataTable.Clear();
            //adapter.Fill(dataTable);
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_educationService);
            form2.Show();
        }
    }
}