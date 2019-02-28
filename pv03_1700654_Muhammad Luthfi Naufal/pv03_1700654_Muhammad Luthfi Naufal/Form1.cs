using pv03_1700654_Muhammad_Luthfi_Naufal.Model;
using pv03_1700654_Muhammad_Luthfi_Naufal.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pv03_1700654_Muhammad_Luthfi_Naufal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodoRepository todo = new TodoRepository();

            tbNim.Enabled = false;

            string nim = tbNim.Text;

            btnAdd.Enabled = true;
            submitNim.Enabled = false;

            dataGridView2.DataSource = todo.getByNim(nim);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            tbUNamaK.Text = row.Cells["Nama"].Value.ToString();
            tbUkategori.Text = row.Cells["Kategori"].Value.ToString();
            tbDid.Text = row.Cells["id"].Value.ToString();
            tbUid.Text = row.Cells["id"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.NimMhs = tbNim.Text;
            temp.Nama = tbNama.Text;
            temp.Kategori = tbKategori.Text;

            TodoRepository todo = new TodoRepository();

            todo.addTodo(temp);

            string nim = tbNim.Text;

            dataGridView2.DataSource = todo.getByNim(nim);
        }
    }
}
