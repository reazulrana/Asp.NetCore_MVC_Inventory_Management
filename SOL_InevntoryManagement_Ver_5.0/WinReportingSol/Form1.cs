using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinReportingSol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstc.Items.Clear();
            //10 set no
            int basepage = 10;
            int totalPage = 55;
            int pageIndex = Convert.ToInt32(textBox1.Text)-1;
            int numberremove = 0;
            int lessthanbasenumber = 0;
            int sn = 0;
            int sl = 0;
            if (totalPage < basepage)
            {
                sn = totalPage;
                numberremove = 1;
                sl = 1;

            }
            else { 
            
            //lessthanbasenumber = TotalPage <= basepage?TotalPage:0;
            sn = pageIndex <= totalPage ? (((pageIndex / basepage)*basepage))+ basepage : (((pageIndex / basepage) * basepage))+ (totalPage - ((pageIndex / basepage) * basepage));
                numberremove = sn == totalPage ? basepage - Math.Abs(((((pageIndex / basepage) * basepage)) + basepage) - totalPage) : basepage;

                sl = ((sn - numberremove))+1;
            }

            

            for (int i= sl; i <= sn; i++)
            {
                lstc.Items.Add(i);
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
