using EvaluationManagerV2.Models;
using EvaluationManagerV2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerV2
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }

        private void ShowStudents()
        {
            List<Student> students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;

            dgvStudents.Columns["Id"].DisplayIndex = 0;
            dgvStudents.Columns["FirstName"].DisplayIndex = 1;
            dgvStudents.Columns["LastName"].DisplayIndex = 2;
            dgvStudents.Columns["Grade"].DisplayIndex = 3;
        }
    }
}
