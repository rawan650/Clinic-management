using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new string[] { "2026-11-04", "10:00", "Ahmed Hassan", "Checkup", "Done" });
            dataGridView1.Rows.Add(new string[] { "2026-11-04", "11:30", "Mona Said", "Root Canal", "Scheduled" });
            dataGridView1.Rows.Add(new string[] { "2026-11-04", "13:00", "Omar Khaled", "Cleaning", "Scheduled" });
            dataGridView1.Rows.Add(new string[] { "2026-11-04", "15:30", "Sara Adel", "Whitening", "Scheduled" });
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }
    }
}