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
        Random rand = new Random();
        string NamePhoto = null;
        List<TemporaryData> PictureList = new List<TemporaryData>();
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddTimeImg()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    Size size = new Size(100, 100);
                    Image img = new Bitmap(file.FileName);
                    img = new Bitmap(img, size);

                    TemporaryData temporaryData = new TemporaryData
                    {
                        NamePicture = rand.Next(10000)+file.SafeFileName,
                        Picture = img
                    };
                    foreach (var item in PictureList)
                    {
                        if (item.NamePicture == temporaryData.NamePicture)
                        {
                            MessageBox.Show("Картинка с таким именем уже существует!");
                            return;
                        }
                    }
                    PictureList.Add(temporaryData);
                }
            }
        }

        public string getFileExtension(string fileName) // Получение типа фотографии
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            if (TablePicture.SelectedRows.Count > 0)
            {
                var item = GetDataTemporary();
                PicBox.Image = item.Picture;
                
                NamePhoto = item.NamePicture;
            }
            else MessageBox.Show("Фотография не выбрана!");
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
                        foreach (TemporaryData item in PictureList)
                        {
                            ServicePhoto servicePhoto = new ServicePhoto { 
                            ServiceID = service.ID,
                            PhotoPath = "Услуги салона красоты\\" + item.NamePicture
                            };
                            string path = Path.Combine(Application.StartupPath, servicePhoto.PhotoPath);
                            item.Picture.Save(path);
                            db.ServicePhoto.Add(servicePhoto);
                        }
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

        private void BtnAddPic_Click(object sender, EventArgs e)
        {
            AddTimeImg();
            UpdateTable();

        }

        public void UpdateTable()
        {
            TablePicture.DataSource = PictureList.ToList();
            TablePicture.Columns["NamePicture"].Visible = false;
            TablePicture.Columns["Picture"].HeaderText = "Картинка";
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {
        }

        public TemporaryData GetDataTemporary()
        {
            var StrName = TablePicture.SelectedRows[0].Cells["NamePicture"].Value.ToString();
            var item = PictureList.Find(p => p.NamePicture == StrName);
            return item;
        }

        private void BtnDelPic_Click(object sender, EventArgs e)
        {
            if(TablePicture.SelectedRows.Count > 0)
            {
                PictureList.Remove(GetDataTemporary());
                UpdateTable();
            }
            else MessageBox.Show("Фотография не выбрана!");



        }
    }
}
