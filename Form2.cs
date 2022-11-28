using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form2 : Form
    {
        Form1 form = Form1.fthis;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength == 0  || textBox2.TextLength == 0) 
            {
                MessageBox.Show("Incorrect input! Try Again");
            }
            else
            {
                int f = 0;
                for (int i = 0; i < form.tasks.Count; i++)
                {
                    if(textBox1.Text == form.tasks[i].Name)
                    {
                        MessageBox.Show("This task name already exists");
                        f = 1;
                        break;
                    }
                }
                if(f != 1)
                {
                    form.tasks.Add(new TASK(textBox1.Text, textBox2.Text));
                    form.comboBox1.Items.Add(textBox1.Text);
                    Close();
                }
               
            }
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
