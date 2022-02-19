using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty
{
    public partial class ClientServiceForm : Form
    {
        int ServiceId;
        BeautyEntities db = new BeautyEntities();
        Service service = new Service();
        DateTime date;
        public ClientServiceForm(int SerId)
        {
            InitializeComponent();
            ServiceId = SerId;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadClients()
        {
            TableClients.DataSource = db.Client.ToList();
            TableClients.Columns["ID"].Visible = false;
            TableClients.Columns["Birthday"].Visible = false;
            TableClients.Columns["RegistrationDate"].Visible = false;
            TableClients.Columns["Email"].Visible = false;
            TableClients.Columns["Phone"].Visible = false;
            TableClients.Columns["GenderCode"].Visible = false;
            TableClients.Columns["PhotoPath"].Visible = false;
            TableClients.Columns["Gender"].Visible = false;
            TableClients.Columns["ClientService"].Visible = false;
            TableClients.Columns["Tag"].Visible = false;
            TableClients.Columns["FirstName"].HeaderText = "Имя";
            TableClients.Columns["LastName"].HeaderText = "Фамилия";
            TableClients.Columns["Patronymic"].HeaderText = "Отчество";

        }

        private void ClientServiceForm_Load(object sender, EventArgs e)
        {
            service = db.Service.Where(p => p.ID == ServiceId).FirstOrDefault();
            LoadClients();
            LabTitle.Text = service.Title;
            LabDuration.Text = (service.DurationInSeconds / 60).ToString() + " мин.";
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            if (!ValidateTime())
            {
                MessageBox.Show("Введите корректное время начала!");
                return;
            }
            if (!string.IsNullOrEmpty(TxtStart.Text))
            {
                int ClientId = Convert.ToInt32(TableClients.SelectedRows[0].Cells["ID"].Value);
                ClientService ClSer = new ClientService
                {
                    ClientID = ClientId,
                    ServiceID = service.ID,
                    StartTime = date
                };
                db.ClientService.Add(ClSer);
                db.SaveChanges();
                MessageBox.Show("Вы успешно добавили запись!");
                this.Close();
            }
            else MessageBox.Show("Введите время начала!");
          

        }
            public bool ValidateTime()
        {
            Regex regex = new Regex(@"^(([0,1][0-9])|(2[0-1])):[0-5][0-9]$");
            if (regex.IsMatch(TxtStart.Text))
                return true;
            return false;
        }

        private void TxtStart_Leave(object sender, EventArgs e)
        {
            if (!ValidateTime()) MessageBox.Show("Введите корректное время начала!");
            else
            {
                var ArrStr = TxtStart.Text.Split(':');
                date = new DateTime(DatePic.Value.Year, DatePic.Value.Month, DatePic.Value.Day, Convert.ToInt32(ArrStr[0]), Convert.ToInt32(ArrStr[1]), 0);
               var d = date.AddMinutes(service.DurationInSeconds / 60);
                TxtLast.Text = d.ToShortTimeString();
            }
        }
    }
}
