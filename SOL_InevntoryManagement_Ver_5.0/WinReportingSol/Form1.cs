using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinReportingSol;
using WinReportingSol.Ef;

namespace WinReportingSol
{
    public partial class Form1 : Form
    {


        InventoryManagmentEntities ef;
        public Form1()
        {
            InitializeComponent();
             ef = new Ef.InventoryManagmentEntities();

            //var properties = typeof(exportdata).GetProperties();
            //List<PropertyInfo> names = properties.ToList();
            //foreach (var p in names) 
            //{ 
            //MessageBox.Show(p.Name);
            //}
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

        private void button2_Click(object sender, EventArgs e)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };

            //int num = 2;
            //int[] arr1= { };

            //for(int i=1;i<(num+1); i++)
            //{
            //    arr1.Append(arr[i]);

            //}



            int year = dateTimePicker1.Value.Year;

            if(year % 4 == 0)
            {
                MessageBox.Show(year.ToString() + " This is Leap Year");
            }
            else
            {
                MessageBox.Show(year.ToString() + " This is not Leap Year");

            }



        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            



        }


    

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {

            //IQueryable<Ef.Product> _model = ef.Products;

            //List<Ef.Product> _tmodel = _model.Where(x => x.Description.ToLower().StartsWith("Tas")).ToList();

            List<Ef.Product> _model = ef.Products.ToList();

            List<Ef.Product> _tmodel = _model.Where(x => x.Description.ToLower().StartsWith("Tas")).ToList();

            dgvGrid.DataSource = _tmodel;




        }
    }



  
}
