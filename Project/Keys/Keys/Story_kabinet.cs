using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keys
{
    public partial class Story_kabinet : Form
    {
        Bd Bd = new Bd();
        int index = 0;
        public Story_kabinet()
        {
            InitializeComponent();
        }
        private void CreateColums()
        {
            StoryTable.Columns.Add("Name_kabinet", "Название кабинета");
            StoryTable.Columns.Add("State_kabinet", "Состояние кабинета");
            StoryTable.Columns.Add("Id_teacher", "Учитель");
            StoryTable.Columns.Add("Time", "Время взятия/сдачи");
        }
        //чтения строки
        private void ReadSingleRow(DataGridView StoryTable, IDataRecord record)
        {
            string StateString;
            if (record.GetBoolean(1) == true)
            {
                StateString = "Освободили";
            }
            else
            {
                StateString = "Заняли";
            }
            string TeacherFIO = record.GetString(2) + record.GetString(3) + record.GetString(4);
            StoryTable.Rows.Add(record.GetString(0), StateString, TeacherFIO, record.GetDateTime(5));
            if (record.GetBoolean(1) == true)
            {

                StoryTable.Rows[index].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (record.GetBoolean(1) == false)
            {
                StoryTable.Rows[index].DefaultCellStyle.BackColor = Color.Red;
            }
            index++;

        }
        //выводит данные в таблицу,
        private void RefDataGrid(DataGridView StoryTable)
        {
            StoryTable.Rows.Clear();
            string query = $"select Name_kabinet,State_kabinet,Last_name,First_name,Patronymic,DataTime_kabinet from Story_kabinet inner join Teacher on Story_kabinet.Id_teacher=Teacher.Id_teacher";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            Bd.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(StoryTable, read);
            }
            read.Close();
        }
        private void Story_kabinet_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefDataGrid(StoryTable);
            StoryTable.Sort(StoryTable.Columns[3], ListSortDirection.Ascending);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
