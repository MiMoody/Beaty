
namespace Beauty
{
    partial class EditServiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.TxtDiscount = new System.Windows.Forms.NumericUpDown();
            this.TxtDuration = new System.Windows.Forms.NumericUpDown();
            this.TxtDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BottomPannel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDelPic = new System.Windows.Forms.Button();
            this.BtnAddPic = new System.Windows.Forms.Button();
            this.TablePicture = new System.Windows.Forms.DataGridView();
            this.AddPic = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDuration)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.BtnDelPic);
            this.MainPanel.Controls.Add(this.BtnAddPic);
            this.MainPanel.Controls.Add(this.TablePicture);
            this.MainPanel.Controls.Add(this.AddPic);
            this.MainPanel.Controls.Add(this.PicBox);
            this.MainPanel.Controls.Add(this.TxtDiscount);
            this.MainPanel.Controls.Add(this.TxtDuration);
            this.MainPanel.Controls.Add(this.TxtDesc);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.TxtCost);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.TxtName);
            this.MainPanel.Controls.Add(this.BtnEdit);
            this.MainPanel.Controls.Add(this.BottomPannel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1040, 549);
            this.MainPanel.TabIndex = 2;
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(275, 270);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(223, 175);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 16;
            this.PicBox.TabStop = false;
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Location = new System.Drawing.Point(282, 110);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(216, 30);
            this.TxtDiscount.TabIndex = 15;
            // 
            // TxtDuration
            // 
            this.TxtDuration.Location = new System.Drawing.Point(20, 198);
            this.TxtDuration.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.TxtDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtDuration.Name = "TxtDuration";
            this.TxtDuration.Size = new System.Drawing.Size(216, 30);
            this.TxtDuration.TabIndex = 14;
            this.TxtDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtDesc
            // 
            this.TxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDesc.Location = new System.Drawing.Point(16, 270);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(220, 175);
            this.TxtDesc.TabIndex = 13;
            this.TxtDesc.Text = "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(278, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Скидка, %";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Длительность, мин";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Описание";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(273, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость, руб";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(273, 198);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(225, 30);
            this.TxtCost.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 109);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(225, 30);
            this.TxtName.TabIndex = 3;
            // 
            // BtnEdit
            // 
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(12, 451);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(486, 36);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Изменить";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BottomPannel
            // 
            this.BottomPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BottomPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPannel.Location = new System.Drawing.Point(0, 504);
            this.BottomPannel.Name = "BottomPannel";
            this.BottomPannel.Size = new System.Drawing.Size(1040, 45);
            this.BottomPannel.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.TopPanel.Controls.Add(this.PicLogo);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.BtnExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1040, 45);
            this.TopPanel.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::Beauty.Properties.Resources.logo;
            this.PicLogo.Location = new System.Drawing.Point(12, 3);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(43, 39);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 9;
            this.PicLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Бархатные бровки";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.Location = new System.Drawing.Point(990, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(39, 33);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(530, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(499, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Изображения к услуге";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDelPic
            // 
            this.BtnDelPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelPic.Location = new System.Drawing.Point(530, 413);
            this.BtnDelPic.Name = "BtnDelPic";
            this.BtnDelPic.Size = new System.Drawing.Size(228, 36);
            this.BtnDelPic.TabIndex = 27;
            this.BtnDelPic.Text = "Удалить фото";
            this.BtnDelPic.UseVisualStyleBackColor = true;
            this.BtnDelPic.Click += new System.EventHandler(this.BtnDelPic_Click);
            // 
            // BtnAddPic
            // 
            this.BtnAddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPic.Location = new System.Drawing.Point(801, 413);
            this.BtnAddPic.Name = "BtnAddPic";
            this.BtnAddPic.Size = new System.Drawing.Size(228, 36);
            this.BtnAddPic.TabIndex = 26;
            this.BtnAddPic.Text = "Добавить фото";
            this.BtnAddPic.UseVisualStyleBackColor = true;
            this.BtnAddPic.Click += new System.EventHandler(this.BtnAddPic_Click);
            // 
            // TablePicture
            // 
            this.TablePicture.AllowUserToAddRows = false;
            this.TablePicture.AllowUserToDeleteRows = false;
            this.TablePicture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablePicture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablePicture.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablePicture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablePicture.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablePicture.Location = new System.Drawing.Point(530, 109);
            this.TablePicture.Name = "TablePicture";
            this.TablePicture.ReadOnly = true;
            this.TablePicture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablePicture.Size = new System.Drawing.Size(499, 293);
            this.TablePicture.TabIndex = 25;
            // 
            // AddPic
            // 
            this.AddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPic.Location = new System.Drawing.Point(620, 459);
            this.AddPic.Name = "AddPic";
            this.AddPic.Size = new System.Drawing.Size(338, 36);
            this.AddPic.TabIndex = 24;
            this.AddPic.Text = "Выбрать главное изображение";
            this.AddPic.UseVisualStyleBackColor = true;
            this.AddPic.Click += new System.EventHandler(this.AddPic_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(278, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Изображение";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 549);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditServiceForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение услуги";
            this.Load += new System.EventHandler(this.EditServiceForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDuration)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.NumericUpDown TxtDiscount;
        private System.Windows.Forms.NumericUpDown TxtDuration;
        private System.Windows.Forms.RichTextBox TxtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Panel BottomPannel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnDelPic;
        private System.Windows.Forms.Button BtnAddPic;
        private System.Windows.Forms.DataGridView TablePicture;
        private System.Windows.Forms.Button AddPic;
        private System.Windows.Forms.Label label7;
    }
}