using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using DevOne.Security.Cryptography.BCrypt;


namespace VoltageDropCalculator
{
    public partial class BatchConverter : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(HandleRef handle, out int processId);

        public BatchConverter()
        {
            InitializeComponent();
        }
        private void btn_UploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog xdialog = new OpenFileDialog();
            xdialog.CheckFileExists = true;
            xdialog.AddExtension = true;
            xdialog.Filter = "Excel File |*.xls;*.xlsx;*.xlsm";

            if (xdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txt_fileUploaded.Text = xdialog.FileName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            txt_data.Clear();

            string xexcelFile = txt_fileUploaded.Text;

            Microsoft.Office.Interop.Excel.Application xexcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xworkBook = xexcelApp.Workbooks.Open(xexcelFile);
            Microsoft.Office.Interop.Excel._Worksheet xworkSheet = xworkBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xsheetRange = xworkSheet.UsedRange;

            int rowCount = xsheetRange.Rows.Count;
            int columnCount = xsheetRange.Columns.Count;

            string xnumberOfEntries = (rowCount - 1).ToString();
            string xdateTime = DateTime.Now.ToString("MMddyyyy");
            string xorgShortCode = txt_orgshortCode.Text;

            string xformat = "000000000000.00";

            txt_data.AppendText("H|" + xorgShortCode +"|"+ xdateTime + "|" + "1" + Environment.NewLine);

            long xtotalFormat = 0;
            
            for (int i = 2; i <= rowCount; i++) {

                if (xsheetRange.Cells[i, 1] != null && xsheetRange.Cells[i, 1].Value != null) {

                    string xamount = xsheetRange.Cells[i, 2].Value.ToString(xformat);
                    string xwalangDot = xamount.Replace(".", "");
                    long xparsedEach = Int64.Parse(xwalangDot);
                    xtotalFormat += xparsedEach;
                    string xforMattedString = "000000000000";

                    txt_data.AppendText("D|" + xsheetRange.Cells[i, 1].Value2.ToString() + "|" + xparsedEach.ToString(xforMattedString) + "|" + (i - 1).ToString() + "|" + xsheetRange.Cells[i, 3].Value2.ToString());
                }

                txt_data.AppendText(Environment.NewLine);
            }

            string xtotalFormat2 = "000000000000000";

            string xwalangDotTotal = xtotalFormat.ToString();
            xwalangDotTotal = xwalangDotTotal.Replace(".", "");
            long xparsedTotal = Int64.Parse(xwalangDotTotal);
            string xoriginalTotal = xparsedTotal.ToString(xtotalFormat2);

            string encryptedTotal = ecnryptHash(xoriginalTotal);


            txt_data.AppendText("S|" + xnumberOfEntries  + "|" + xoriginalTotal + "|" + encryptedTotal);


            GC.Collect();
            GC.WaitForPendingFinalizers();
            
            Marshal.ReleaseComObject(xsheetRange);
            Marshal.ReleaseComObject(xworkSheet);
            
            xworkBook.Close();
            Marshal.ReleaseComObject(xworkBook);

            xexcelApp.Quit();
            Marshal.ReleaseComObject(xexcelApp);
            

            Marshal.FinalReleaseComObject(xexcelApp);
            Marshal.FinalReleaseComObject(xworkBook);

            
            Process[] p = Process.GetProcessesByName("EXCEL");
            p[0].Kill();

            int batchNumber = 1;

            bool checker = false;
            while (checker == false) {

                for (int q = 99; q >= 1; q--) {

                    string xfileExists = @"C:\Users\pc\" + xdateTime + "_" + q + ".txt";
                    if (File.Exists(xfileExists))
                    {
                        //MessageBox.Show("File exist!");
                    }
                    else {
                        batchNumber = q;
                        checker = true;
                    }
                    
                }
            }

            TextWriter xtextWriter = new StreamWriter("C:\\Users\\pc\\" + xdateTime + "_" + batchNumber + ".txt");
            xtextWriter.Write(txt_data.Text);
            xtextWriter.Close();

            MessageBox.Show("Successful Generation of Enrollment File!" +
                "" + Environment.NewLine + Environment.NewLine +
                "File Name: " + xdateTime + "_" + batchNumber +".txt" + Environment.NewLine +
                "Number of Entries: " + xnumberOfEntries + Environment.NewLine +
                "" + Environment.NewLine +
                "File Location: " + "C:\\Users\\pc\\" + xdateTime +  "_" + batchNumber + ".txt" +
                "" , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private string bcryptSalt() {
            return BCryptHelper.GenerateSalt(12);
        }
        private string ecnryptHash(string xoriginalString) {

            return BCryptHelper.HashPassword(xoriginalString, bcryptSalt());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double xtest = double.Parse(txt_fileUploaded.Text);
            double rounded = Math.Round(xtest,2 ,MidpointRounding.AwayFromZero);

            MessageBox.Show(rounded.ToString());

        }
    }

}
