using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty
{
    public partial class ShowWritesForm : Form
    {
        BeautyEntities db = new BeautyEntities();
        public ShowWritesForm()
        {
            InitializeComponent();
        }

        private void ShowWritesForm_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Timer.Start();
            TableRecords.Columns.Add("id", "ID");
            TableRecords.Columns.Add("servname", "Наименование");
            TableRecords.Columns.Add("firstname", "Имя");
            TableRecords.Columns.Add("lastname", "Фамилия");
            TableRecords.Columns.Add("middlename", "Отчество");
            TableRecords.Columns.Add("date", "Дата");
            TableRecords.Columns.Add("stay", "Осталось");
            TableRecords.Columns.Add("email", "Email");
            TableRecords.Columns.Add("phone", "Телефон");
            TableRecords.Columns["id"].Visible = false;
            UpdateTable();
        }

        public void WriteTable(IQueryable<dynamic> list)
        {
            foreach (var item in list)
            {
                var date = item.date;
                TimeSpan TimeRemaining = date - DateTime.Now;
                var stay = TimeRemaining.Hours + " ч. " + TimeRemaining.Minutes + " мин.";
                TableRecords.Rows.Add(item.id, item.servname, item.firstname, item.lastname, item.middlename, item.date, stay, item.email, item.phone);
            }
        }

        public void ColorizeTable(IQueryable<dynamic> list)
        {
            foreach (var item in list)
            {
                TimeSpan time = item.date - DateTime.Now;
                if (time.Hours < 1)
                {
                    foreach (DataGridViewRow row in TableRecords.Rows)
                    {
                        if (item.id == Convert.ToInt32(row.Cells["id"].Value))
                            row.DefaultCellStyle.BackColor = Color.FromArgb(250, 128, 114);
                    }
                }
            }
        }

        public void UpdateTable()
        {
            TableRecords.Rows.Clear();
            var list = from cls in db.ClientService
                       join cl in db.Client on cls.ClientID equals cl.ID
                       join ser in db.Service on cls.ServiceID equals ser.ID
                       where cls.StartTime >= DateTime.Now && cls.StartTime <= DbFunctions.AddDays(DateTime.Now, 1)
                       orderby cls.StartTime
                       select new
                       {
                          id = cls.ID, 
                          servname = ser.Title,
                          firstname =  cl.FirstName,
                          lastname = cl.LastName,
                          middlename = cl.Patronymic,
                          date = cls.StartTime,
                          stay = "",
                          email = cl.Email,
                          phone = cl.Phone,
                       };
           
            WriteTable(list);
            ColorizeTable(list);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Timer.Stop();
            Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
