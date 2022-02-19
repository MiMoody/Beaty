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
            UpdateTable();
        }


        public void UpdateTable()
        {
            var list = from cls in db.ClientService
                       join cl in db.Client on cls.ClientID equals cl.ID
                       join ser in db.Service on cls.ServiceID equals ser.ID
                       where cls.StartTime > DateTime.Now && cls.StartTime <= DbFunctions.AddDays(DateTime.Now, 1)
                       orderby cls.StartTime
                       select new
                       {
                          id = cls.ID, 
                          servname = ser.Title,
                          firstname =  cl.FirstName,
                          lastname = cl.LastName,
                          middlename = cl.Patronymic,
                          date = cls.StartTime,
                          stay = (DbFunctions.DiffHours(DateTime.Now,cls.StartTime) - 1).ToString() + " ч. " + (DbFunctions.DiffMinutes(DateTime.Now,cls.StartTime) / DbFunctions.DiffHours(DateTime.Now,cls.StartTime) > 60 ? DbFunctions.DiffMinutes(DateTime.Now,cls.StartTime) / DbFunctions.DiffHours(DateTime.Now,cls.StartTime) - 60 : DbFunctions.DiffMinutes(DateTime.Now,cls.StartTime) / DbFunctions.DiffHours(DateTime.Now,cls.StartTime)).ToString() + " мин.",
                          email = cl.Email,
                          phone = cl.Phone,
                       };
            TableRecords.DataSource = list.ToList();
            TableRecords.Columns["id"].Visible = false;
            TableRecords.Columns["servname"].HeaderText = "Наименование";
            TableRecords.Columns["firstname"].HeaderText = "Наименование";
            TableRecords.Columns["lastname"].HeaderText = "Фамилия";
            TableRecords.Columns["middlename"].HeaderText = "Отчество";
            TableRecords.Columns["date"].HeaderText = "Дата";
            TableRecords.Columns["stay"].HeaderText = "Осталось";
            TableRecords.Columns["email"].HeaderText = "Email";
            TableRecords.Columns["phone"].HeaderText = "Телефон";


            foreach (var item in list)
            {
                if (item.date.Subtract(DateTime.Now) <= new TimeSpan(1, 0, 0))
                {
                    foreach(DataGridViewRow row in TableRecords.Rows)
                    {
                        if (item.id == Convert.ToInt32(row.Cells["id"].Value))
                            row.DefaultCellStyle.BackColor = Color.FromArgb(250, 128, 114);
                    }
                }    
            }
                        
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
