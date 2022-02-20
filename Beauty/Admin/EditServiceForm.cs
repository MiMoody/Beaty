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
        Random rand = new Random();
        int IdService;
        string NamePhoto = null;
        Service service = new Service();
        List<TemporaryData> PictureList = new List<TemporaryData>();
        List<ServicePhoto> OldData;

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
            TxtDesc.Text = service.Description == null ? "" : service.Description;
            TxtDiscount.Value = Convert.ToDecimal(service.Discount) * 100;
            TxtDuration.Value = service.DurationInSeconds / 60;
            TxtName.Text = service.Title;
            if (!string.IsNullOrEmpty(service.MainImagePath))
            {
                var path = Path.Combine(Application.StartupPath, service.MainImagePath.Trim());
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    PicBox.Image = Image.FromStream(stream);
                    stream.Dispose();
                }
            }
            LoadDataInList();
            UpdateTable();
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

                    service.Title = Title;
                    service.Cost = Cost;
                    service.DurationInSeconds = Convert.ToInt32(Duration) * 60;
                    service.Description = Desc;
                    service.Discount = Convert.ToDouble(Discount) / 100;
                    if (CheckPic && !string.IsNullOrEmpty(NamePhoto))
                    {
                        service.MainImagePath = $"Услуги салона красоты\\{NamePhoto}";
                    }
                    foreach (var item in OldData)
                    {
                        string path = Path.Combine(Application.StartupPath, item.PhotoPath);
                        FileInfo fileInfo = new FileInfo(path);
                        if (PictureList.Count > 0)
                        {
                            if (fileInfo.Exists) fileInfo.Delete();
                            db.ServicePhoto.Remove(item);
                        }
                        else
                        {
                            if (service.MainImagePath == item.PhotoPath) continue;
                            if (fileInfo.Exists) fileInfo.Delete();
                            db.ServicePhoto.Remove(item);
                        }
                    }

                    foreach (TemporaryData item in PictureList)
                    {
                        ServicePhoto servicePhoto = new ServicePhoto
                        {
                            ServiceID = service.ID,
                            PhotoPath = "Услуги салона красоты\\" + item.NamePicture
                        };
                        string path = Path.Combine(Application.StartupPath, servicePhoto.PhotoPath);
                        FileInfo fi = new FileInfo(path);
                        if (!fi.Exists)
                            item.Picture.Save(path);
                        db.ServicePhoto.Add(servicePhoto);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Информация об услуге успешно обновлена!");
                    Refs.clientForm.Close();
                    new ClientForm(true).Show();
                    this.Close();
                }
                else MessageBox.Show("Введите корректное значение стоимости! \n В формате 123,34 или 123");


            }
            else MessageBox.Show("Заполните все поля!");
        }

        public TemporaryData GetDataTemporary()
        {
            var StrName = TablePicture.SelectedRows[0].Cells["NamePicture"].Value.ToString();
            var item = PictureList.Find(p => p.NamePicture == StrName);
            return item;
        }

        public void AddTimeImg()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    Size size = new Size(100, 100);
                    Image img;
                    using (FileStream stream = new FileStream(file.FileName, FileMode.Open))
                    {
                        img = Image.FromStream(stream);
                        stream.Dispose();
                    }
                    img = new Bitmap(img, size);
                    TemporaryData temporaryData = new TemporaryData
                    {
                        NamePicture = rand.Next(10000) + file.SafeFileName,
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

        private void BtnDelPic_Click(object sender, EventArgs e)
        {
            if (TablePicture.SelectedRows.Count > 0)
            {
                PictureList.Remove(GetDataTemporary());
                UpdateTable();
            }
            else MessageBox.Show("Фотография не выбрана!");
        }

        public void UpdateTable()
        {
            TablePicture.DataSource = PictureList.ToList();
            TablePicture.Columns["NamePicture"].Visible = false;
            TablePicture.Columns["Picture"].HeaderText = "Картинка";
        }

        private void BtnAddPic_Click(object sender, EventArgs e)
        {
            AddTimeImg();
            UpdateTable();

        }

        private void AddPic_Click(object sender, EventArgs e)
        {
            if (TablePicture.SelectedRows.Count > 0)
            {
                var item = GetDataTemporary();
                PicBox.Image = item.Picture;
                NamePhoto = item.NamePicture;
                CheckPic = true;
            }
            else MessageBox.Show("Фотография не выбрана!");
        }

        public void LoadDataInList()
        {
            OldData = db.ServicePhoto.Where(p => p.ServiceID == IdService).ToList();
            foreach (var item in OldData)
            {
                string str = item.PhotoPath;
                if (str.Contains("Услуги салона красоты"))
                {
                    var index = str.IndexOf("\\") + 1;
                    str = str.Substring(index);
                }
                string path = Path.Combine(Application.StartupPath, item.PhotoPath);
                Image image;
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    image = Image.FromStream(stream);
                    stream.Dispose();
                }
                image = new Bitmap(image, new Size(100, 100));
                PictureList.Add(
                    new TemporaryData
                    {
                        NamePicture = str,
                        Picture = image
                    });
            }
        }
    }
}
