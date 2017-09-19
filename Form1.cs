using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortalWinForm
{
    public partial class Display : Form
    {
         List<StudentClass> studentsList = new List<StudentClass>();
        public Display(ref List<StudentClass> newList)
        {
            studentsList = newList;
        }

        public Display()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            studentsList.Add(new StudentClass() { firstName = textBox1.Text, lastName = 
                textBox2.Text, phoneNumber = textBox3.Text});
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = studentsList;
            

            
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
           // DataRelationCollection rows = dataGridView1.Get
            form2.ShowDialog();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
