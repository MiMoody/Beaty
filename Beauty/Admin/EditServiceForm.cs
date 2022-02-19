using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty
{
    public partial class EditServiceForm : Form
    {
        BeautyEntities db = new BeautyEntities();
        int IdService;
        string NamePhoto = null;
        Service service = new Service();

        bool CheckPic = false;

        public EditServiceForm(int IdService)
        {
            InitializeComponent();
            this.IdService = IdService;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditServiceForm_Load(object sender, EventArgs e)
        {
            service = db.Service.Where(p => p.ID == IdService).FirstOrDefault();
            TxtCost.Text = service.Cost.ToString();
            TxtDesc.Text = service.Description == null? "": service.Description ;
            TxtDiscount.Value = Convert.ToDecimal(service.Discount) * 100;
            TxtDuration.Value = service.DurationInSeconds / 60;
            TxtName.Text = service.Title;
            if (!string.IsNullOrEmpty(service.MainImagePath))
                PicBox.Image = new Bitmap(Path.Combine(Application.StartupPath, service.MainImagePath.Trim()));
        }
        public void AddImg()
        {
            using (OpenFileDialog f = new OpenFileDialog())
            {
                f.Filter = "Jpg|*.jpg|Png|*.png";
                if(f.ShowDialog() == DialogResult.OK)
                {
                    PicBox.Image = new Bitmap(f.FileName);
                    CheckPic = true;
                    NamePhoto = f.SafeFileName;
                }
            }

        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            AddImg();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string Title = TxtName.Text;
            decimal Cost;
            decimal Duration = TxtDuration.Value;
            string Desc = TxtDesc.Text;
            decimal Discount = TxtDiscount.Value;
            if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(TxtCost.Text))
            {
                if (decimal.TryParse(TxtCost.Text, out Cost) && Cost > 0)
                {
                    if (!db.Service.Any(p => p.Title == Title))
                    {
                        string path = "";
                        if (PicBox.Image != null && CheckPic)
                        {
                            Random rand = new Random();
                            NamePhoto = rand.Next(100000).ToString() + NamePhoto;
                            path = Path.Combine(Application.StartupPath, "Услуги салона красоты",  NamePhoto);
                            PicBox.Image.Save(path);
                        }
                        service.Title = Title;
                        service.Cost = Cost;
                        service.DurationInSeconds = Convert.ToInt32(Duration) * 60;
                        service.Description = Desc;
                        service.Discount = Convert.ToDouble(Discount) / 100;
                        if (CheckPic && !string.IsNullOrEmpty(NamePhoto))
                            service.MainImagePath = $"Услуги салона красоты\\{NamePhoto}";
                        db.SaveChanges();
                        MessageBox.Show("Информация об услуге успешно обновлена!");
                        Refs.clientForm.Close();
                        new ClientForm(true).Show();
                        this.Close();
                    }
                    else MessageBox.Show("Услуга с таким наименованием уже существует!");
                }
                else MessageBox.Show("Введите корректное значение стоимости! \n В формате 123,34 или 123");


            }
            else MessageBox.Show("Заполните все поля!");
        }
    }
}
