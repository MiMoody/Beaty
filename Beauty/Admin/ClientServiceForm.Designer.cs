
namespace Beauty
{
    partial class ClientServiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnServices = new System.Windows.Forms.Button();
            this.BottomPannel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabTitle = new System.Windows.Forms.Label();
            this.LabDuration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TableClients = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePic = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStart = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLast = new System.Windows.Forms.MaskedTextBox();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableClients)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.TxtLast);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.TxtStart);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.DatePic);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.TableClients);
            this.MainPanel.Controls.Add(this.LabDuration);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.LabTitle);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.BtnServices);
            this.MainPanel.Controls.Add(this.BottomPannel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(553, 532);
            this.MainPanel.TabIndex = 1;
            // 
            // BtnServices
            // 
            this.BtnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServices.Location = new System.Drawing.Point(147, 444);
            this.BtnServices.Name = "BtnServices";
            this.BtnServices.Size = new System.Drawing.Size(236, 37);
            this.BtnServices.TabIndex = 2;
            this.BtnServices.Text = "Добавить запись";
            this.BtnServices.UseVisualStyleBackColor = true;
            this.BtnServices.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // BottomPannel
            // 
            this.BottomPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.BottomPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPannel.Location = new System.Drawing.Point(0, 487);
            this.BottomPannel.Name = "BottomPannel";
            this.BottomPannel.Size = new System.Drawing.Size(553, 45);
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
            this.TopPanel.Size = new System.Drawing.Size(553, 45);
            this.TopPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 11);
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
            this.BtnExit.Location = new System.Drawing.Point(502, 7);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(39, 33);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::Beauty.Properties.Resources.logo;
            this.PicLogo.Location = new System.Drawing.Point(10, 4);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(43, 39);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 7;
            this.PicLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование:";
            // 
            // LabTitle
            // 
            this.LabTitle.AutoSize = true;
            this.LabTitle.Location = new System.Drawing.Point(175, 64);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(146, 23);
            this.LabTitle.TabIndex = 4;
            this.LabTitle.Text = "Наименование:";
            // 
            // LabDuration
            // 
            this.LabDuration.AutoSize = true;
            this.LabDuration.Location = new System.Drawing.Point(175, 101);
            this.LabDuration.Name = "LabDuration";
            this.LabDuration.Size = new System.Drawing.Size(134, 23);
            this.LabDuration.TabIndex = 6;
            this.LabDuration.Text = "Длительность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Длительность:";
            // 
            // TableClients
            // 
            this.TableClients.AllowUserToAddRows = false;
            this.TableClients.AllowUserToDeleteRows = false;
            this.TableClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableClients.Location = new System.Drawing.Point(16, 172);
            this.TableClients.Name = "TableClients";
            this.TableClients.ReadOnly = true;
            this.TableClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableClients.Size = new System.Drawing.Size(525, 177);
            this.TableClients.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Список клиентов:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatePic
            // 
            this.DatePic.Location = new System.Drawing.Point(16, 391);
            this.DatePic.Name = "DatePic";
            this.DatePic.Size = new System.Drawing.Size(200, 30);
            this.DatePic.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата записи:";
            // 
            // TxtStart
            // 
            this.TxtStart.Location = new System.Drawing.Point(245, 391);
            this.TxtStart.Mask = "00:00";
            this.TxtStart.Name = "TxtStart";
            this.TxtStart.Size = new System.Drawing.Size(138, 30);
            this.TxtStart.TabIndex = 15;
            this.TxtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtStart.ValidatingType = typeof(System.DateTime);
            this.TxtStart.Leave += new System.EventHandler(this.TxtStart_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Время начала";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Время оконч.";
            // 
            // TxtLast
            // 
            this.TxtLast.Location = new System.Drawing.Point(403, 394);
            this.TxtLast.Mask = "90:00";
            this.TxtLast.Name = "TxtLast";
            this.TxtLast.ReadOnly = true;
            this.TxtLast.Size = new System.Drawing.Size(138, 30);
            this.TxtLast.TabIndex = 17;
            this.TxtLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLast.ValidatingType = typeof(System.DateTime);
            // 
            // ClientServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 532);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientServiceForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись";
            this.Load += new System.EventHandler(this.ClientServiceForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnServices;
        private System.Windows.Forms.Panel BottomPannel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label LabTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TableClients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DatePic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TxtLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtStart;
    }
}