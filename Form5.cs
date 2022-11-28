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
    public partial class Form5 : Form
    {
        Form4 form= Form4.fthis;
        List<TASK> tasks = new List<TASK>();
        public Form5()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < form.temp_tasks.Count; i++)
            {
                comboBox1.Items.Add(form.temp_tasks[i].Name);
            }
            tasks = form.temp_tasks;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Name == comboBox1.Text)
                    textBox1.Text = tasks[i].Description;
            }
        }
    }
}
