using EntityFrameworkEducation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkEducation
{
    public partial class Form2 : Form
    {
        IEducationService _educationService;
        public Form2(IEducationService educationService)
        {
            InitializeComponent();
            _educationService = educationService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _educationService.GetAll();
            dataGridView1.DataSource = result;
        }
    }
}
