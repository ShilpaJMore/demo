using CsvHelper;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;    

namespace DBHandling
{
    public partial class Form1 : Form
    {

        private static string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private static string oldconnectionstring;
        private static string connectionString;

        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ImportTable()
        {

        }

        //public static DataTable ReadFromCsv(string fileName)
        //{
        //    DataTable table = null;
        //    bool a;
        //    bool b;
        //    bool c;
        //    if (a = fileName != null &&
        //    !fileName.Equals(string.Empty) && 
        //    File.Exists(fileName))
        //    {
        //        try
        //        {
        //            // If required, you can collect some useful info from the file
        //            FileInfo info = new FileInfo(fileName);
        //            string tableName = info.Name;

        //            // Prepare for the data to be processed into a DataTable
        //            // We don't know how many records there are in the .csv, so we
        //            // use a List<string> to store the records in it temporarily.
        //            // We also prepare a DataTable;
        //            List<string> rows = new List<string>();

        //            // Then we read in the raw data
        //            StreamReader reader = new StreamReader(fileName);
        //            string record = reader.ReadLine();
        //            while (record != null)
        //            {
        //                rows.Add(record);
        //                record = reader.ReadLine();

        //                Console.WriteLine(reader.ReadLine());
                           
        //            }

        //            // And we split it into chuncks.
        //            // Note that we keep track of the number of columns
        //            // in case the file has been tampered with, or has been made
        //            // in a weird kind of way (believe me: this does happen)

        //            // Here we will store the converted rows
        //            List<string[]> rowObjects = new List<string[]>();

        //            int maxColsCount = 0;
        //            foreach (string s in rows)
        //            {
        //                string[] convertedRow = s.Split(new char[] { ',' });
        //                if (convertedRow.Length > maxColsCount)
        //                    maxColsCount = convertedRow.Length;
        //                rowObjects.Add(convertedRow);
        //            }

        //            // Then we build the table
        //            table = new DataTable(tableName);
        //            for (int i = 0; i < maxColsCount; i++)
        //            {
        //                // Change this if you want other datatypes
        //                // make sure you also convert the string[] to
        //                // the corect datataype
        //                table.Columns.Add(new DataColumn());
        //            }

        //            foreach (string[] rowArray in rowObjects)
        //            {
        //                table.Rows.Add(rowArray);
        //            }
        //            table.AcceptChanges();
        //        }
        //        catch(Exception ex)
        //        {
        //            throw new Exception("Error in ReadFromCsv: IO error.");
        //        }
        //    }
        //    else
        //    {
        //        throw new FileNotFoundException("Error in ReadFromCsv: the file path could not be found.");
        //    }
        //    return table;
        //}

        //public static bool createTable(string tableName, DataTable columns)
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        //    {
                
        //        //Open connection to DB
        //        conn.Open();
        //        int result;
        //        //Query to be fired
        //        string sql = "CREATE TABLE " + tableName + "(";
        //        DataRow dtRow = columns.Rows[0];
        //        object[] s = dtRow.ItemArray;
        //        int i = s.Count(), j =0;

        //        for (; i>0; i--)
        //        {
        //            if(dtRow[j] == "")
        //            {
        //                break;
        //            }
        //            sql += "[" + dtRow[j] + "] " + "nvarchar(50)" + ",";
        //            j++;
        //        }

        //        sql = sql.TrimEnd(new char[] { ',' }) + ")";

        //        using (SQLiteCommand command = new SQLiteCommand(sql, conn))
        //        {
        //            //Executing the query                    
        //            command.CommandText = sql;
        //            result = command.ExecuteNonQuery();
        //        }
        //        //Close connection to DB
        //        conn.Close();
        //    }
        //    //Return result as string
        //    return true;
        //}

        //public static bool insertTable(string tableName, DataTable columns)
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        //    {
        //        //Open connection to DB
        //        conn.Open();
        //        int result;
        //        //Query to be fired
        //        string sql = "insert into " + tableName + "(";

        //        foreach (DataColumn column in columns.Columns)
        //        {
        //            sql += "[" + column.ColumnName + "] " + "nvarchar(50)" + ",";
        //        }

        //        sql = sql.TrimEnd(new char[] { ',' }) + ")";

        //        using (SQLiteCommand command = new SQLiteCommand(sql, conn))
        //        {
        //            //Executing the query                    
        //            command.CommandText = sql;
        //            result = command.ExecuteNonQuery();
        //        }
        //        //Close connection to DB
        //        conn.Close();
        //    }
        //    //Return result as string
        //    return true;
        //}

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            oldconnectionstring = Path.Combine(executableLocation, txbxDBName.Text);
            connectionString = "Data Source =" + oldconnectionstring.ToString();           
        }

        private void btnImportTable_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

             OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "(*.xls)|*.xlsx" ;
            //openFileDialog1.FilterIndex = 1;



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                Excel.Application xlApp = new Excel.Application();
                //Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\ContactDetailsofGICEmployee.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); 
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;
            }
        }

    }
}
