using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech.Emp.Win
{
    public partial class Form1 : Form
    {
        Emp.Entities.EmplyeeManager EmplyeeManager = new Entities.EmplyeeManager();

        public Form1()
        {
            InitializeComponent();
            EmplyeeManager.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var emp = EmplyeeManager.GetEmployeeById(id);
            if(emp != null)
            {
                textBox2.Text = emp.name + " " + emp.country;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var emp = EmplyeeManager.GetEmployeeById(id);
            if (emp != null)
            {
                EmplyeeManager.RemoveEmployee(id);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmplyeeManager.Save();
        }
    }
}
