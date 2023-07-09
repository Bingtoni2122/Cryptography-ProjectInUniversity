using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class DataInfor : Form
    {
        public static Boolean running = false;
        public DataInfor()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fList.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fList.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            fList.Enabled = false;
        }
        public static int i = 0;
        public static string fieldName = "";
        public static string fieldFrom = "";
        public static string fieldTo = "";
        public static string fieldDiv = "";
        public static string fieldList = "";
        public static string  fieldType = "";
        private void button3_Click(object sender, EventArgs e)
        {
            DataInfor.fieldName = fName.Text;
            DataInfor.fieldFrom = fFrom.Text;
            DataInfor.fieldTo = fTo.Text;
            DataInfor.fieldDiv = fDiv.Text;
            DataInfor.fieldList = fList.Text;
            DataInfor.fieldType = fType.SelectedItem as string;

            ++i;
            running = true;
            fList.Enabled = true;
            fFrom.Enabled = true;
            fTo.Enabled = true;
            fDiv.Enabled = true;

            fList.Text = "";
            fFrom.Text = "";
            fTo.Text = "";
            fDiv.Text = "";
            fName.Text = "";
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            fFrom.Enabled = false;
            fTo.Enabled = false;
            fDiv.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            running = false;
            this.Close();
        }

        private void DataInfor_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
