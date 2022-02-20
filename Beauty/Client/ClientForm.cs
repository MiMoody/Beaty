using Beauty.Properties;
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
    public partial class ClientForm : Form
    {
        BeautyEntities db = new BeautyEntities();
        bool AdminMode = false;
        int TotalPages;
        int CurrentRowCount;
        bool CmbChange = false;
        public List<Service> list = new List<Service>();
        DataGridViewImageColumn ImgColumn = new DataGridViewImageColumn { Name = "img"};
        BindingSource bsource = new BindingSource();
        public ClientForm(bool admin)
        {
            InitializeComponent();
            AdminMode = admin;
            Refs.clientForm = this;
        }

        public string PrintPages()
        {
            return CurrentRowCount.ToString() + " из " + TotalPages.ToString() + " записей";
        }

        public List<Service> ConfigureList(List <Service> list)
        {
            List<Service> new_list = new List<Service>();
            foreach (Service item in list)
            {
                Service el = new Service { 
                ID = item.ID,
                Title = item.Title,
                Cost = item.Cost,
                DurationInSeconds = item.DurationInSeconds / 60,
                Discount = item.Discount * 100,
                Description = item.Description,
                MainImagePath = item.MainImagePath,
                };
                new_list.Add(el);
            }
            return new_list;
        }

        public void ColorizeTable()
        {
            foreach(DataGridViewRow item in TableService.Rows)
            {
                if(Convert.ToInt32(item.Cells["Discount"].Value) > 0)
                    item.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        public List<Service> WriteDiscountCell(List<Service> list)
        {
            List<Service> new_list = new List<Service>();
            foreach(Service item in list)
            {
                double Dicsount = Convert.ToDouble(item.Discount) / 100.0;
               if (Dicsount > 0)
                {
                    var OldPrice = Convert.ToDouble(item.Cost);
                    item.NewPrice = OldPrice - (OldPrice * Dicsount);
                }
                new_list.Add(item);
            }
            return new_list;
        }

        public List<string> AddImgPath()
        {
            List<string> arr = new List<string>();
            foreach (var item in db.Service.ToList())
            {
                string path = Path.Combine(Application.StartupPath, item.MainImagePath.Trim());
                arr.Add(path);
            }
            return arr;
        }

        public List <Bitmap> AddImgToList(List<string> ArrPath)
        {
            List<Bitmap> list = new List<Bitmap>();
            int i = 0;
            foreach (DataGridViewRow item in TableService.Rows)
            {
                Image img;
                using (FileStream file = new FileStream(ArrPath[i], FileMode.Open))
                {
                    img = Image.FromStream(file);
                }
                Size size = new Size(40, 40);
                list.Add(new Bitmap(img, size));
                i++;
            }
            return list;
        }

        public void AddImg(List<Bitmap> list)
        {
            try
            {
                int i = 0;
                foreach (DataGridViewRow item in TableService.Rows)
                {
                    ImgColumn.Image = list[i];
                    item.Cells["img"].Value = ImgColumn.Image;
                    i++;
                }
            }
            catch { }
            // await Task.Run(() =>
            //TableService.Invoke((MethodInvoker)(() =>
            //{
            //}))
            //);
        }

        public void DisplayCells()
        {
            TableService.Columns["ID"].Visible = false;
            TableService.Columns["MainImagePath"].Visible = false;
            TableService.Columns["ClientService"].Visible = false;
            TableService.Columns["ServicePhoto"].Visible = false;
            TableService.Columns["Description"].Visible = false;
            TableService.Columns["Title"].HeaderText = "Наименование";
            TableService.Columns["Cost"].HeaderText = "Цена";
            TableService.Columns["NewPrice"].HeaderText = "Новая цена";
            TableService.Columns["DurationInSeconds"].HeaderText = "Длительность мин.";
            TableService.Columns["Discount"].HeaderText = "Скидка, %";
            TableService.Columns["img"].HeaderText = "Картинка";
            TableService.Columns["Title"].DisplayIndex = 0;
            TableService.Columns["Cost"].DisplayIndex = 1;
            TableService.Columns["NewPrice"].DisplayIndex = 2;
            TableService.Columns["DurationInSeconds"].DisplayIndex = 3;
            TableService.Columns["Discount"].DisplayIndex = 4;
            TableService.Columns["img"].DisplayIndex = 5;
        }

        public List<Service> SortList(List<Service> list)
        {
            List<Service> new_list = new List<Service>();
            if (CmbSort.SelectedIndex == 1)
            {
                new_list = list.OrderBy(p => p.Cost).ToList();
            }
            else if (CmbSort.SelectedIndex == 2)
            {
                new_list = list.OrderByDescending(p => p.Cost).ToList();
            }
            else return list;

            return new_list;
        }

        public List<Service> FilterList(List<Service> list)
        {
            List<Service> new_list = new List<Service>();

            if (CmbFilter.SelectedIndex == 1)
                new_list = list.Where(p => p.Discount >= 0 && p.Discount < 0.05).ToList();
            else if (CmbFilter.SelectedIndex == 2)
                new_list = list.Where(p => p.Discount >= 0.05 && p.Discount < 0.15).ToList();
            else if (CmbFilter.SelectedIndex == 3)
                new_list = list.Where(p => p.Discount >= 0.15 && p.Discount < 0.3).ToList();
            else if (CmbFilter.SelectedIndex == 4)
                new_list = list.Where(p => p.Discount >= 0.3 && p.Discount < 0.7).ToList();
            else if (CmbFilter.SelectedIndex == 5)
                new_list = list.Where(p => p.Discount >= 0.7 && p.Discount < 1).ToList();
            else return list;

            return new_list;

        }

        public List<Service> SearchList(List<Service> list, string SearchStr)
        {
            List<Service> new_list = new List<Service>();

            foreach (Service item in list)
            {
                bool check = false;
                if(!string.IsNullOrEmpty(item.Title))
                    if (item.Title.Contains(SearchStr))
                        check = true;
                if (!string.IsNullOrEmpty(item.Description))
                    if (item.Description.Contains(SearchStr))
                        check = true;
                if(check) new_list.Add(item);
            }
            return new_list;
        }
       
       public void UpdateTable()
        {
            if(CmbSort.SelectedIndex == -1 && CmbFilter.SelectedIndex == -1)
            {
                CmbChange = true;
                CmbSort.SelectedIndex = 0;
                CmbFilter.SelectedIndex = 0;
            }
            CmbChange = false;
            list = db.Service.ToList();
            TotalPages = list.Count();
            list = SearchList(list, TxtSearch.Text);
            list = FilterList(list);
            list = SortList(list);
            list = ConfigureList(list);
            list = ConfigureData(list);
            list = WriteDiscountCell(list);
            bsource.DataSource = list;
            TableService.DataSource = bsource;
            var ListImg = AddImgToList(AddImgPath());
            CurrentRowCount = TableService.RowCount;
            LabPage.Text = PrintPages();
            DisplayCells();
            ColorizeTable();
            AddImg(ListImg);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            if (AdminMode)
                ButtonPanel.Visible = true;
            else ButtonPanel.Visible = false;
            TableService.Columns.Add(ImgColumn);
            try
            {
               UpdateTable();
            }
            catch { }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new Mainform().Show();
        }

        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!CmbChange)
                UpdateTable();
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CmbChange)
                UpdateTable();
        }

        public List <Service> ConfigureData(List<Service> list)
        {
            List<Service> new_list = new List<Service>();
            foreach(var item in list)
            {
                Service el = new Service
                {
                    ID = item.ID,
                    Title = item.Title,
                    Cost = Math.Round(item.Cost, 1),
                    DurationInSeconds = item.DurationInSeconds,
                    Discount = item.Discount,
                    Description = item.Description,
                    MainImagePath = item.MainImagePath,
                };
                new_list.Add(el);
            }
            return new_list;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddServiceForm().ShowDialog();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            new EditServiceForm(Convert.ToInt32(TableService.SelectedRows[0].Cells["ID"].Value)).Show();
        }

        private void DtnDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить услугу?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int IdService = Convert.ToInt32(TableService.SelectedRows[0].Cells["ID"].Value);
                if (!db.ClientService.Any(p => p.ServiceID == IdService))
                {
                    var service = db.Service.Where(p => p.ID == IdService).FirstOrDefault();
                    FileInfo f = new FileInfo(Path.Combine(Application.StartupPath, service.MainImagePath));
                    if (f.Exists) f.Delete();
                    foreach (ServicePhoto item in db.ServicePhoto.Where(p => p.ServiceID == IdService).ToList())
                    {
                        FileInfo file = new FileInfo(Path.Combine(Application.StartupPath, item.PhotoPath));
                        if (file.Exists) file.Delete();
                        db.ServicePhoto.Remove(item);
                    }
                    db.Service.Remove(service);
                    db.SaveChanges();
                    UpdateTable();
                    MessageBox.Show("Услуга успешно удалена!");

                }
                else MessageBox.Show("Невозможно выполнить удаление!\nНа эту услугу записаны клиенты!!!");
            }
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            new ClientServiceForm(Convert.ToInt32(TableService.SelectedRows[0].Cells["ID"].Value)).ShowDialog();
        }

        private void BtnNearest_Click(object sender, EventArgs e)
        {
            new ShowWritesForm().ShowDialog();
        }
    }
}
