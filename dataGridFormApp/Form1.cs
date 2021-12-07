using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id;
            if (int.TryParse(txt_id.Text, out id ))
            {
                int satir = dataGridView1.Rows.Add();

                dataGridView1.Rows[satir].Cells[0].Value = txt_id.Text;
                dataGridView1.Rows[satir].Cells[1].Value = txt_name.Text;
                dataGridView1.Rows[satir].Cells[2].Value = txt_surname.Text;
            }
            else
            {
                MessageBox.Show("Lütfen id yerine sayısal veri giriniz");
            }


            
            txtclear();
        }

        private void txtclear()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_surname.Clear();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
