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
    public partial class Form4 : Form
    {
        Form1 f = Form1.fthis;

        public static Form4 fthis;
        public List<TASK> temp_tasks = new List<TASK>();
        public Form4()
        {
            InitializeComponent();
            button1.Enabled = false;
            checkBox1.CheckedChanged += ch_Event;
            checkBox2.CheckedChanged += ch_Event;
            textBox1.TextChanged += tx_Event;
            fthis = this;
        }

        private void tx_Event(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked || textBox1.TextLength <= 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void ch_Event(object sender, EventArgs e)
        {
           if(!checkBox1.Checked && !checkBox2.Checked || textBox1.TextLength <= 0)
                button1.Enabled = false;
           else
                button1.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp_tasks.Clear();
            if(textBox1.Text.Split().Length != 1)
            {
                MessageBox.Show("Incorrect input! Pls Enter only 1 word");
                return;
            }
            bool isname = false, isdesc = false;

            if(checkBox1.Checked)
                isname = true;
            if(checkBox2.Checked)
                isdesc = true;

            

            if(checkBox1.Checked)
            {
                for (int i = 0; i < f.tasks.Count; i++)
                {
                    for (int j = 0; j < f.tasks[i].Name.Split().Length; j++)
                    {
                        if (textBox1.Text.Split()[0].ToLower() == f.tasks[i].Name.Split()[j].ToLower())
                        {
                            temp_tasks.Add(f.tasks[i]);
                            break;
                        }
                    }
                }
            }

            if(checkBox2.Checked)
            {
                for (int i = 0; i < f.tasks.Count; i++)
                {
                    for (int j = 0; j < f.tasks[i].Description.Split().Length; j++)
                    {
                        if (textBox1.Text.Split()[0].ToLower() == f.tasks[i].Description.Split()[j].ToLower())
                        {
                            bool istrue = false;
                            for (int x = 0; x < temp_tasks.Count; x++)
                            {
                                if (f.tasks[i].Name == temp_tasks[x].Name)
                                {
                                    istrue = true;
                                    break;
                                }
                            }
                            if (!istrue)
                            { temp_tasks.Add(f.tasks[i]); break; }
                        }
                    }
                }
            }
            if(temp_tasks.Count <= 0)
            {
                MessageBox.Show("Nothing were found :(");
                return;
            }
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
