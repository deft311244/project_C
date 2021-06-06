using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_final_plantshop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void go_to_link(object sender, MouseEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://shortrecap.co/home-space/12-%E0%B8%95%E0%B9%89%E0%B8%99%E0%B9%84%E0%B8%A1%E0%B9%89%E0%B8%9B%E0%B8%A5%E0%B8%B9%E0%B8%81%E0%B9%83%E0%B8%99%E0%B8%9A%E0%B9%89%E0%B8%B2%E0%B8%99-%E0%B8%8A%E0%B9%88%E0%B8%A7%E0%B8%A2%E0%B8%9F/");
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
