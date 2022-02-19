
namespace Beauty
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LabSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LabFilter = new System.Windows.Forms.Label();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.labSort = new System.Windows.Forms.Label();
            this.CmbSort = new System.Windows.Forms.ComboBox();
            this.LabPage = new System.Windows.Forms.Label();
            this.LabHeader = new System.Windows.Forms.Label();
            this.TableService = new System.Windows.Forms.DataGridView();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BottomPannel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.BtnNearest = new System.Windows.Forms.Button();
            this.DtnDel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableService)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Controls.Add(this.LabSearch);
            this.MainPanel.Controls.Add(this.TxtSearch);
            this.MainPanel.Controls.Add(this.LabFilter);
            this.MainPanel.Controls.Add(this.CmbFilter);
            this.MainPanel.Controls.Add(this.labSort);
            this.MainPanel.Controls.Add(this.CmbSort);
            this.MainPanel.Controls.Add(this.LabPage);
            this.MainPanel.Controls.Add(this.LabHeader);
            this.MainPanel.Controls.Add(this.PicLogo);
            this.MainPanel.Controls.Add(this.TableService);
            this.MainPanel.Controls.Add(this.BtnExit);
            this.MainPanel.Controls.Add(this.BottomPannel);
            this.MainPanel.Controls.Add(this.ButtonPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1196, 478);
            this.MainPanel.TabIndex = 1;
            // 
            // LabSearch
            // 
            this.LabSearch.AutoSize = true;
            this.LabSearch.Location = new System.Drawing.Point(13, 55);
            this.LabSearch.Name = "LabSearch";
            this.LabSearch.Size = new System.Drawing.Size(62, 23);
            this.LabSearch.TabIndex = 17;
            this.LabSearch.Text = "Поиск";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(81, 52);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(226, 30);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LabFilter
            // 
            this.LabFilter.AutoSize = true;
            this.LabFilter.Location = new System.Drawing.Point(332, 54);
            this.LabFilter.Name = "LabFilter";
            this.LabFilter.Size = new System.Drawing.Size(71, 23);
            this.LabFilter.TabIndex = 15;
            this.LabFilter.Text = "Скидка";
            // 
            // CmbFilter
            // 
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "Без фильтрации",
            "От 0 до 5%",
            "От 5 до 15%",
            "От 15 до 30%",
            "От 30 до 70%",
            "От 70 до 100%"});
            this.CmbFilter.Location = new System.Drawing.Point(409, 51);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(252, 31);
            this.CmbFilter.TabIndex = 14;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // labSort
            // 
            this.labSort.AutoSize = true;
            this.labSort.Location = new System.Drawing.Point(690, 55);
            this.labSort.Name = "labSort";
            this.labSort.Size = new System.Drawing.Size(235, 23);
            this.labSort.TabIndex = 13;
            this.labSort.Text = "Сортировка по стоимости";
            // 
            // CmbSort
            // 
            this.CmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSort.FormattingEnabled = true;
            this.CmbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "По возрастанию",
            "По убыванию"});
            this.CmbSort.Location = new System.Drawing.Point(931, 51);
            this.CmbSort.Name = "CmbSort";
            this.CmbSort.Size = new System.Drawing.Size(252, 31);
            this.CmbSort.TabIndex = 12;
            this.CmbSort.SelectedIndexChanged += new System.EventHandler(this.CmbSort_SelectedIndexChanged);
            // 
            // LabPage
            // 
            this.LabPage.AutoSize = true;
            this.LabPage.Location = new System.Drawing.Point(956, 396);
            this.LabPage.Name = "LabPage";
            this.LabPage.Size = new System.Drawing.Size(133, 23);
            this.LabPage.TabIndex = 11;
            this.LabPage.Text = "10 из 100 стр.";
            // 
            // LabHeader
            // 
            this.LabHeader.AutoSize = true;
            this.LabHeader.Location = new System.Drawing.Point(63, 14);
            this.LabHeader.Name = "LabHeader";
            this.LabHeader.Size = new System.Drawing.Size(171, 23);
            this.LabHeader.TabIndex = 7;
            this.LabHeader.Text = "Бархатные бровки";
            // 
            // TableService
            // 
            this.TableService.AllowUserToAddRows = false;
            this.TableService.AllowUserToDeleteRows = false;
            this.TableService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableService.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableService.DefaultCellStyle = dataGridViewCellStyle1;
            this.TableService.Location = new System.Drawing.Point(17, 88);
            this.TableService.Name = "TableService";
            this.TableService.ReadOnly = true;
            this.TableService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableService.Size = new System.Drawing.Size(1167, 287);
            this.TableService.TabIndex = 10;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.Location = new System.Drawing.Point(1145, 9);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(39, 33);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BottomPannel
            // 
            this.BottomPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BottomPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPannel.Location = new System.Drawing.Point(0, 433);
            this.BottomPannel.Name = "BottomPannel";
            this.BottomPannel.Size = new System.Drawing.Size(1196, 45);
            this.BottomPannel.TabIndex = 1;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.BtnWrite);
            this.ButtonPanel.Controls.Add(this.BtnNearest);
            this.ButtonPanel.Controls.Add(this.DtnDel);
            this.ButtonPanel.Controls.Add(this.BtnAdd);
            this.ButtonPanel.Controls.Add(this.BtnChange);
            this.ButtonPanel.Location = new System.Drawing.Point(3, 381);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(868, 49);
            this.ButtonPanel.TabIndex = 9;
            // 
            // BtnWrite
            // 
            this.BtnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWrite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnWrite.Location = new System.Drawing.Point(698, 10);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(165, 33);
            this.BtnWrite.TabIndex = 10;
            this.BtnWrite.Text = "Записать";
            this.BtnWrite.UseVisualStyleBackColor = false;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // BtnNearest
            // 
            this.BtnNearest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnNearest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNearest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNearest.Location = new System.Drawing.Point(527, 10);
            this.BtnNearest.Name = "BtnNearest";
            this.BtnNearest.Size = new System.Drawing.Size(165, 33);
            this.BtnNearest.TabIndex = 9;
            this.BtnNearest.Text = "Ближ. записи";
            this.BtnNearest.UseVisualStyleBackColor = false;
            this.BtnNearest.Click += new System.EventHandler(this.BtnNearest_Click);
            // 
            // DtnDel
            // 
            this.DtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.DtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DtnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtnDel.Location = new System.Drawing.Point(185, 10);
            this.DtnDel.Name = "DtnDel";
            this.DtnDel.Size = new System.Drawing.Size(165, 33);
            this.DtnDel.TabIndex = 7;
            this.DtnDel.Text = "Удалить";
            this.DtnDel.UseVisualStyleBackColor = false;
            this.DtnDel.Click += new System.EventHandler(this.DtnDel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdd.Location = new System.Drawing.Point(14, 10);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(165, 33);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnChange.Location = new System.Drawing.Point(356, 10);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(165, 33);
            this.BtnChange.TabIndex = 8;
            this.BtnChange.Text = "Изменить";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::Beauty.Properties.Resources.logo;
            this.PicLogo.Location = new System.Drawing.Point(14, 6);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(43, 39);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 6;
            this.PicLogo.TabStop = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 478);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список услуг";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableService)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BottomPannel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button DtnDel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.Button BtnNearest;
        private System.Windows.Forms.DataGridView TableService;
        private System.Windows.Forms.Label LabHeader;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LabPage;
        private System.Windows.Forms.Label labSort;
        private System.Windows.Forms.ComboBox CmbSort;
        private System.Windows.Forms.Label LabFilter;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label LabSearch;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}