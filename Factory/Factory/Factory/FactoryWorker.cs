using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using MOIE = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Factory
{
    public partial class FactoryWorker : Form
    {
        Bd Bd = new Bd();
        public int index;
        string First_name;
        string Last_name;
        string Father_name;
        string JobTitle;
        double Salary;
        string Foto;
        int AgeF ;
        int FullSalary;
        DateTime Now= DateTime.Now;
        DateTime DataB = new DateTime();
        public FactoryWorker()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColums()
        {
            WorkerTable.Columns.Add("ArrivalTime", "Время прихода");
            WorkerTable.Columns.Add("CareTime", "Время ухода");
            WorkerTable.Columns.Add("HoursPerShift", "Часов за смену");
        }
        private void ReadSingleRow(DataGridView WorkerTable, IDataRecord record)
        {
            var difference = (record.GetDateTime(1) - record.GetDateTime(0)).Duration();
            WorkerTable.Rows.Add(record.GetDateTime(0) , record.GetDateTime(1),difference.Hours);
        }
        //выводит данные в таблицу,
        private void RefDataGrid(DataGridView WorkerTable)
        {
            WorkerTable.Rows.Clear();
            string query = $"select ArrivalTime,CareTime from WatchHistory where Id_fw='{index}'";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(WorkerTable, read);
            }
            read.Close();
        }
        private void FactoryWorker_Load(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            int Hours = 0;
            int count=0;
            string query = $"select First_name,Last_name,Father_name,Foto_fw,Date_of_Birth,JobTitle,Salary from FactoryWorker where Id_fw='{index}'";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                First_name = read.GetString(0);
                Last_name = read.GetString(1);
                Father_name = read.GetString(2);
               // Foto=read.GetString(3);
                DataB = read.GetDateTime(4);
                JobTitle= read.GetString(5);
                Salary = read.GetDouble(6);
            }
            read.Close();
           // pictureBox1.Image = Image.FromFile(Foto);
            FIO.Text = Last_name + First_name +  Father_name;
            Dol.Text=JobTitle;
            AgeF=Now.Year - DataB.Year;
            if (DataB > Now.AddYears(-AgeF)) AgeF--;
            Age.Text = AgeF + " года";
            CreateColums();
            RefDataGrid(WorkerTable);
            while (WorkerTable.Rows.Count > count)
            {
                TimeSpan DifferenceDays;
                DateTime DateCare = Convert.ToDateTime(WorkerTable.Rows[count].Cells[1].Value);
                DifferenceDays = Now-DateCare;
                if (DifferenceDays.Days <= 30)
                {
                    Hours+= Convert.ToInt32(WorkerTable.Rows[count].Cells[2].Value);
                }
                count++;
            }
            ZP.Text = Convert.ToString(Hours*Salary);
            FullSalary = Hours*(Convert.ToInt32(Salary));

        }

        private void Doc_Click(object sender, EventArgs e)
        {
             MOIE.Application exApp = new MOIE.Application();
             exApp.Workbooks.Add();
            MOIE.Worksheet wsh = (MOIE.Worksheet)exApp.ActiveSheet;
            wsh.Cells[1, 3] = "ФИО";
            wsh.Cells[2, 3] = "Возраст";
            wsh.Cells[3, 3] = "Должность";
            wsh.Cells[4, 3] = "Зарплата";
            wsh.Cells[1, 4] = Last_name + First_name + Father_name; 
            wsh.Cells[2, 4] = AgeF;
            wsh.Cells[3, 4] = JobTitle;
            wsh.Cells[4, 4] = FullSalary;
            wsh.Cells[6, 1] = "Время прихода";
            wsh.Cells[6, 2] = "Время ухода";
            wsh.Cells[6, 3] = "Часов за смену";
            int rowExcel = 7;
            int indexExel = 5;
            wsh.Columns.AutoFit();
            MOIE.Range Defolt = exApp.get_Range("C1", "D4");
            Defolt.Borders.LineStyle = MOIE.XlLineStyle.xlContinuous;
            Defolt.Borders.Weight = MOIE.XlBorderWeight.xlThin;
            for (int i = 0; i < WorkerTable.Rows.Count; i++)
            {
                wsh.Cells[rowExcel, "1"] = WorkerTable.Rows[i].Cells["ArrivalTime"].Value;
                wsh.Cells[rowExcel, "2"] = WorkerTable.Rows[i].Cells["CareTime"].Value;
                wsh.Cells[rowExcel, "3"] = WorkerTable.Rows[i].Cells["HoursPerShift"].Value;
                ++rowExcel;
                indexExel++;
            }
            MOIE.Range tRange = exApp.get_Range("A6", "C" + indexExel.ToString());
            tRange.Borders.LineStyle = MOIE.XlLineStyle.xlContinuous;
            tRange.Borders.Weight = MOIE.XlBorderWeight.xlThin;
            MOIE.Range range = wsh.Range["A1:B1", System.Type.Missing];
            range.EntireColumn.ColumnWidth = 18;
            wsh.SaveAs("MyFile.xls");
                exApp.Visible = true;
            
        }

    }
}
