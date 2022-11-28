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
    public partial class Form1 : Form
    {
        public static Form1 fthis;
        public List<TASK> tasks = new List<TASK>();
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            try
            {
                tasks = Json.loadAsync("DATA.json");
                for (int i = 0; i < tasks.Count; i++)
                {
                    comboBox1.Items.Add(tasks[i].Name);
                }
            }
            catch {}

            if(tasks.Count <= 0)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
            Closed += Save_Data; fthis = this;
        }

        private void Save_Data(object sender, EventArgs e)
        {
            try
            {
                Json.saveAsync(tasks, "DATA.json");
            }
            catch {}
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if(tasks.Count > 0)
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Name == comboBox1.Text)
                    textBox1.Text = tasks[i].Description;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
