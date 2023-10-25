using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GemBox.Spreadsheet;
using InevntoryManagement.GlobalFuntion;

namespace InevntoryManagement.Models
{

    public enum fileextensions
    {
        none,
        xlsx,
        csv,
        pdf
    }

    public class ExportData
    {

        private  string savefilename = "";
        private  string extension = "";

        public ExportData(string filename, fileextensions? fileextension)
        {


            if (fileextension == fileextensions.xlsx)
            {
                extension = fileextensions.xlsx.ToString();
            }
            else if (fileextension == fileextensions.csv)
            {
                extension = fileextensions.csv.ToString();
            }
            else if (fileextension == fileextensions.pdf)
            {
                extension = fileextensions.pdf.ToString();
            }

            // get store file extension like .xlsx .pdf
            savefilename = filename + "." + extension;


            

        }
 

        public void exportData<T>(List<T> tdata)
        {

       
  
            //export data 


            if (extension != null && extension.ToLower() == "xlsx")
            {
                saveExcel<T>(tdata);
                Global_Functions.SetMessage(@"User\" + Environment.UserName + @"\Downloads\" + savefilename, "success");

            }
            else if (extension != null && extension.ToLower() == "csv")
            {
                saveCSV<T>(tdata);
                Global_Functions.SetMessage(@"User\" + Environment.UserName + @"\Downloads\" + savefilename, "success");

            }
            else if (extension != null && extension.ToLower() == "pdf")
            {
                CreatePDF<T>(tdata);
                Global_Functions.SetMessage(@"User\" + Environment.UserName + @"\Downloads\" + savefilename, "success");

            }
        }



         void saveExcel<T>(List<T> EData)
        {
            StringBuilder str = new StringBuilder();

            //var tmptype = EData.FirstOrDefault();
            //savefilename parameter is passed from action method
           // string filename = savefilename + ".xlsx";
            string strpath = GetDefault_Download_FilePath() + savefilename; 
           


            PropertyInfo[] lst = typeof(T).GetProperties();
            List<PropertyInfo> lst1 = lst.ToList();

            DataTable dt = ListtoDatatableConverter.ToDataTable<T>(EData);

            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add(savefilename.Split(".")[0]);

                var wbb = new XLWorkbook();


                for (int i = 0; i < lst.Count(); i++)
                {
                    ws.Cell(1, i + 1).Value = lst[i].Name;
                    ws.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGreen;
                    ws.Cell(1, i + 1).Style.Font.SetBold(true);
                    
                    //border
                    ws.Cell(1, i + 1).Style.Border.TopBorder = XLBorderStyleValues.Medium;
                    ws.Cell(1, i + 1).Style.Border.LeftBorder = XLBorderStyleValues.Medium;
                    ws.Cell(1, i + 1).Style.Border.RightBorder = XLBorderStyleValues.Medium;
                    ws.Cell(1, i + 1).Style.Border.BottomBorder = XLBorderStyleValues.Medium;


                }

                ws.Rows("1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Rows("1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                



                var slno = 2;
                for (int sl = 0; sl < dt.Rows.Count; sl++)
                {

                    for (int i = 0; i < lst.Count(); i++)
                    {
                        DataRow dr = dt.Rows[sl];


                        ws.Cell(slno, i + 1).Value = dr[i].ToString();

                        ////vertical Center
                        //ws.Cell(slno, i+1).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                        //border
                        ws.Cell(slno, i + 1).Style.Border.TopBorder = XLBorderStyleValues.Medium;
                        ws.Cell(slno, i + 1).Style.Border.LeftBorder = XLBorderStyleValues.Medium;
                        ws.Cell(slno, i + 1).Style.Border.RightBorder = XLBorderStyleValues.Medium;
                        ws.Cell(slno, i + 1).Style.Border.BottomBorder = XLBorderStyleValues.Medium;
                    }


        

                    slno++;

                }

                //all column is autofited
                ws.Columns(1, lst.Count()).AdjustToContents(1,slno);
                ws.Rows("1:" + slno).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                
                //set row height
                ws.Rows("1").Height = 25;
                ws.Rows("2:" + slno).Height = 20;

                using (MemoryStream fs = new MemoryStream())
                {

                    wb.SaveAs(fs);
                    var content = fs.ToArray();

                    
                    System.IO.File.WriteAllBytes(strpath, content);

                }

            }
        }




         void saveCSV<T>(List<T> EData)
        {
            StringBuilder str = new StringBuilder();

            //var tmptype = EData.FirstOrDefault();
            //string filename = savefilename + ".csv";
            string strpath = GetDefault_Download_FilePath() + savefilename;
           

            PropertyInfo[] lst = typeof(T).GetProperties();
            List<PropertyInfo> lst1 = lst.ToList();

            DataTable dt = ListtoDatatableConverter.ToDataTable<T>(EData);

            string colname = "";


            for (int i = 0; i < lst.Count(); i++)
            {
                colname = colname + lst[i].Name + ",";
            }



            str.AppendLine(colname);





            for (int sl = 0; sl < dt.Rows.Count; sl++)
            {

                DataRow d = dt.Rows[sl];
                string strdata = "";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    strdata = strdata + d[i].ToString() + ",";
                }


                str.AppendLine(strdata);
            }


            System.IO.File.WriteAllBytes(strpath, Encoding.UTF8.GetBytes(str.ToString()));

        }






         void CreatePDF<T>(List<T> EData)
        {
            StringBuilder str = new StringBuilder();

            //var tmptype = EData.FirstOrDefault();
            string filename = savefilename.Split(".")[0] + ".xlsx";
            string strpath = GetDefault_Download_FilePath() + filename;
            


            PropertyInfo[] lst = typeof(T).GetProperties();
            List<PropertyInfo> lst1 = lst.ToList();

            DataTable dt = ListtoDatatableConverter.ToDataTable<T>(EData);

            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add(savefilename.Split(".")[0]);

                var wbb = new XLWorkbook();


                for (int i = 0; i < lst.Count(); i++)
                {
                    ws.Cell(1, i + 1).Value = lst[i].Name;


                    ws.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGreen;
                    ws.Cell(1, i + 1).Style.Font.SetBold(true);

                    //border
                    ws.Cell(1, i + 1).Style.Border.TopBorder = XLBorderStyleValues.Medium;
                    ws.Cell(1, i + 1).Style.Border.LeftBorder = XLBorderStyleValues.Medium;
                    ws.Cell(1, i + 1).Style.Border.RightBorder = XLBorderStyleValues.Medium;
                    ws.Cell(1, i + 1).Style.Border.BottomBorder = XLBorderStyleValues.Medium;
                }


                ws.Rows("1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Rows("1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                var slno = 2;
                for (int sl = 0; sl < dt.Rows.Count; sl++)
                {

                    for (int i = 0; i < lst.Count(); i++)
                    {
                        DataRow dr = dt.Rows[sl];


                        ws.Cell(slno, i + 1).Value = dr[i].ToString();

                        //border
                        ws.Cell(slno, i + 1).Style.Border.TopBorder = XLBorderStyleValues.Medium;
                        ws.Cell(slno, i + 1).Style.Border.LeftBorder = XLBorderStyleValues.Medium;
                        ws.Cell(slno, i + 1).Style.Border.RightBorder = XLBorderStyleValues.Medium;
                        ws.Cell(slno, i + 1).Style.Border.BottomBorder = XLBorderStyleValues.Medium;
                    }
                    slno++;

                }

                //all column is autofited
                ws.Columns(1, lst.Count()).AdjustToContents(1, slno);
                ws.Rows("1:" + slno).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                //set row height
                ws.Rows("1").Height = 25;
                ws.Rows("2:" + slno).Height = 20;

                using (MemoryStream fs = new MemoryStream())
                {

                    wb.SaveAs(fs);
                    var content = fs.ToArray();


                    System.IO.File.WriteAllBytes(strpath, content);

                }

                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                var GemBoxworkbook = GemBox.Spreadsheet.ExcelFile.Load(strpath) ;
                
                var GemBoxworksheet = GemBoxworkbook.Worksheets[0];
                var GemBoxprintoption = GemBoxworksheet.PrintOptions;
                GemBoxprintoption.LeftMargin = 0.7;
                GemBoxprintoption.RightMargin = 0.7;
                GemBoxprintoption.TopMargin = 0.75;
                GemBoxprintoption.BottomMargin = 1.0;
                GemBoxprintoption.HeaderMargin = 0.3;
                GemBoxprintoption.BottomMargin = 0.3;
                GemBoxprintoption.PaperType = PaperType.Letter;
                //GemBoxprintoption.AutomaticPageBreakScalingFactor = 90;

                var GemBoxSaveOption = new PdfSaveOptions();
                GemBoxSaveOption.SelectionType = SelectionType.EntireFile;


                //for save pdf file into download folder
                string pdfpath = GetDefault_Download_FilePath() + savefilename.Split(".")[0] +".pdf";


                GemBoxworkbook.Save(pdfpath , GemBoxSaveOption);

                File.Delete(strpath);
                


            }
        }



        public static  void ConvertoExcelToPDF(string filename,string filepath)
        {
            StringBuilder str = new StringBuilder();

            //var tmptype = EData.FirstOrDefault();


            // it is store file with fullpath end file extension example E:\Test.xlsx or E:\Test.xls
            // / must be set
            string strpath = filepath+   filename;
         
        



            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                var GemBoxworkbook = GemBox.Spreadsheet.ExcelFile.Load(strpath);

                var GemBoxworksheet = GemBoxworkbook.Worksheets[0];
            var GemBoxprintoption = GemBoxworksheet.PrintOptions;
            GemBoxprintoption.LeftMargin = 0.7;
            GemBoxprintoption.RightMargin = 0.7;
            GemBoxprintoption.TopMargin = 0.75;
            GemBoxprintoption.BottomMargin = 0.75;
            GemBoxprintoption.HeaderMargin = 0.3;
            GemBoxprintoption.BottomMargin = 0.3;
            GemBoxprintoption.PaperType = PaperType.Letter;
            //GemBoxprintoption.AutomaticPageBreakScalingFactor = 80;


            var GemBoxSaveOption = new PdfSaveOptions();
                GemBoxSaveOption.SelectionType = SelectionType.EntireFile;


                //for save pdf file into download folder
                string pdfpath = GetDefault_Download_FilePath() + filename.Split(".")[0] + ".pdf";


                GemBoxworkbook.Save(pdfpath, GemBoxSaveOption);

                



        }



        [Obsolete]
        public string GetDefault_Download_FilePath(string filepath)
        {
            string fullfilepath = filepath;

            if (fullfilepath == null || fullfilepath == "")
            {
                fullfilepath = @"C:\Users\" + Environment.UserName + @"\Downloads\";
            }
            else
            {
                fullfilepath = filepath;
            }

            return fullfilepath;
        }

        public static  string GetDefault_Download_FilePath()
        {
            
              string  fullfilepath = @"C:\Users\" + Environment.UserName + @"\Downloads\";
            

            return fullfilepath;
        }



    }
}
