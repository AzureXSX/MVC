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
    public partial class Form3 : Form
    {
        Form1 f = Form1.fthis;
        public Form3()
        {
            InitializeComponent();
            button1.Enabled = false;
            FormClosed += FormClosed_Event;  
        }

        private void FormClosed_Event(object sender, FormClosedEventArgs e)
        {
            if(f.tasks.Count <= 0)
            {
                f.button3.Enabled = false;
                f.button4.Enabled = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < f.comboBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(f.comboBox1.Items[i]);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < f.tasks.Count; i++)
            {
                if (f.tasks[i].Name == comboBox1.Text)
                {
                    f.textBox1.Text = "";
                    f.comboBox1.Text = "";
                    f.tasks.RemoveAt(i);
                    f.comboBox1.Items.Clear();
                    for (int j = 0; j < f.tasks.Count; j++)
                    {
                        f.comboBox1.Items.Add(f.tasks[j].Name);
                    }
                    Close();
                }
            }

        }
    }
}
