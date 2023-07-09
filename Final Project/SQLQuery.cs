using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class SQLQuery : Form
    {
        public SQLQuery()
        {
            InitializeComponent();
        }
        public static string Request;
        public static bool enter = false;
        public static bool exit = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*SQLQuery.Request = textBox1.Text;
            SQLQuery.enter = true;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            if (Form1.done)
            {
                for (int i = 0; i < Form1.listResult.Count; i++)
                {
                    string[] arr = new string[9999];
                    int count = 0;
                    foreach (string arrdata in Form1.listResult[i].data)
                    {
                        arr[count] = arrdata;
                        count++;
                    }
                    listView1.Items.Add(new ListViewItem(arr));
                }
            }
            SQLQuery.enter = false;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLQuery.exit = true;
        }
    }
}
