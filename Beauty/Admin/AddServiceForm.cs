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
    public partial class AddServiceForm : Form
    {
        BeautyEntities db = new BeautyEntities();
        string NamePhoto = null;
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddImage()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    PicBox.Image = new Bitmap(file.FileName);
                    NamePhoto = file.SafeFileName;
                    
                }
            }
        }

        public string getFileExtension(string fileName) // Получение типа фотографии
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            AddImage();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string Title = TxtName.Text;
            decimal Cost;
            decimal Duration = TxtDuration.Value;
            string Desc = TxtDesc.Text;
            decimal Discount = TxtDiscount.Value;
            if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(TxtCost.Text) && !string.IsNullOrEmpty(NamePhoto))
            {
                if (decimal.TryParse(TxtCost.Text, out Cost) && Cost>0){
                    if (!db.Service.Any(p => p.Title == Title))
                    {
                        string path = "";
                        if (PicBox.Image != null)
                        {
                            Random rand = new Random();
                            NamePhoto = rand.Next(100000).ToString() + NamePhoto;
                            path = Path.Combine(Application.StartupPath, "Услуги салона красоты", NamePhoto);
                            PicBox.Image.Save(path);
                        }
                        Service service = new Service
                        {
                            Title = Title,
                            Cost = Cost,
                            DurationInSeconds = Convert.ToInt32(Duration)*60,
                            Description = Desc,
                            Discount = Convert.ToDouble(Discount)/100,
                            MainImagePath = $"Услуги салона красоты\\{NamePhoto}"
                        };
                        db.Service.Add(service);
                        db.SaveChanges();
                        MessageBox.Show("Услуга успешно создана!");
                        this.Close();
                        Refs.clientForm.UpdateTable();
                    }
                    else MessageBox.Show("Услуга с таким наименованием уже существует!");
                }
                else MessageBox.Show("Введите корректное значение стоимости! \n В формате 123,34 или 123");
                    

            }
            else MessageBox.Show("Заполните все поля!");
        }
    }
}
