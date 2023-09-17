using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tələbə_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        StudentDal _studentDal=new StudentDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgwProducts.DataSource = _studentDal.GetAll();
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _studentDal.Add(new Student
            {
                Ad=tbxName.Text,
                Soyad=tbxsurname.Text,
                Qrup=tbxgroup.Text,
            });
            LoadStudents() ;
            MessageBox.Show("Əlavə edildi!");
        }
        
            
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _studentDal.Update(new Student
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Ad = tbxNameUpdate.Text,
                Soyad = tbxsurnameUpdate.Text,
                Qrup=tbxgroupUpdate.Text,

            });
            LoadStudents() ;
            MessageBox.Show("Məlumatlar yeniləndi!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxsurnameUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxgroupUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _studentDal.Delete(new Student
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadStudents();
            MessageBox.Show("Məlumatlar silindi!");
        }
    }
}
