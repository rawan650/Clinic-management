using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class patients : Form
    {
        public patients()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patients_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       
            private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Please enter the patient name.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Add(
                maskedTextBox1.Text,
                maskedTextBox2.Text,
                maskedTextBox3.Text,
                maskedTextBox4.Text
            );

            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();

            maskedTextBox1.Focus();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Appointments().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Billing().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a row to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;
            row.Cells[0].Value = maskedTextBox1.Text;
            row.Cells[1].Value = maskedTextBox2.Text;
            row.Cells[2].Value = maskedTextBox3.Text;
            row.Cells[3].Value = maskedTextBox4.Text;
        }

       
            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            maskedTextBox1.Text = Convert.ToString(row.Cells[0].Value);
            maskedTextBox2.Text = Convert.ToString(row.Cells[1].Value);
            maskedTextBox3.Text = Convert.ToString(row.Cells[2].Value);
            maskedTextBox4.Text = Convert.ToString(row.Cells[3].Value);
        }
    }
    }
