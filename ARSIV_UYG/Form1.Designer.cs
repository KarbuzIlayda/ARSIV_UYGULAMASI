using System.Windows.Forms;

namespace ARSIV_UYG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_aramaSonuc = new System.Windows.Forms.DataGridView();
            this.btn_ara = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_aramaKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_klasorsec = new System.Windows.Forms.Button();
            this.txt_secilenklasor = new System.Windows.Forms.TextBox();
            this.fbd_klasorsec = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_dosyasec = new System.Windows.Forms.Button();
            this.ofd_dosyasec = new System.Windows.Forms.OpenFileDialog();
            this.lbx_veritabanlari = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_seckaldir = new System.Windows.Forms.Button();
            this.btn_listemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_seciliveritabani = new System.Windows.Forms.TextBox();
            this.link_veritabanigit = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aramaSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_aramaSonuc
            // 
            this.dgv_aramaSonuc.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aramaSonuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_aramaSonuc.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_aramaSonuc.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_aramaSonuc.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_aramaSonuc.Location = new System.Drawing.Point(583, 12);
            this.dgv_aramaSonuc.MinimumSize = new System.Drawing.Size(243, 180);
            this.dgv_aramaSonuc.MultiSelect = false;
            this.dgv_aramaSonuc.Name = "dgv_aramaSonuc";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aramaSonuc.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_aramaSonuc.RowHeadersWidth = 10;
            this.dgv_aramaSonuc.RowTemplate.Height = 24;
            this.dgv_aramaSonuc.Size = new System.Drawing.Size(972, 772);
            this.dgv_aramaSonuc.TabIndex = 7;
            this.dgv_aramaSonuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_aramaSonuc_CellClick);
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(184)))), ((int)(((byte)(56)))));
            this.btn_ara.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.ImageKey = "(none)";
            this.btn_ara.ImageList = this.ımageList1;
            this.btn_ara.Location = new System.Drawing.Point(30, 633);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(530, 35);
            this.btn_ara.TabIndex = 6;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "remove.png");
            this.ımageList1.Images.SetKeyName(2, "searchicon.png");
            // 
            // txt_aramaKey
            // 
            this.txt_aramaKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aramaKey.Location = new System.Drawing.Point(30, 593);
            this.txt_aramaKey.Name = "txt_aramaKey";
            this.txt_aramaKey.Size = new System.Drawing.Size(530, 34);
            this.txt_aramaKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arama Niteliğini Giriniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Veri Tabanı için:";
            // 
            // btn_klasorsec
            // 
            this.btn_klasorsec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(184)))), ((int)(((byte)(56)))));
            this.btn_klasorsec.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_klasorsec.Location = new System.Drawing.Point(257, 22);
            this.btn_klasorsec.Name = "btn_klasorsec";
            this.btn_klasorsec.Size = new System.Drawing.Size(128, 44);
            this.btn_klasorsec.TabIndex = 9;
            this.btn_klasorsec.Text = "KLASÖR SEÇ";
            this.btn_klasorsec.UseVisualStyleBackColor = false;
            this.btn_klasorsec.Click += new System.EventHandler(this.btn_klasorsec_Click);
            // 
            // txt_secilenklasor
            // 
            this.txt_secilenklasor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txt_secilenklasor.Enabled = false;
            this.txt_secilenklasor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_secilenklasor.Location = new System.Drawing.Point(30, 72);
            this.txt_secilenklasor.Name = "txt_secilenklasor";
            this.txt_secilenklasor.Size = new System.Drawing.Size(530, 30);
            this.txt_secilenklasor.TabIndex = 10;
            // 
            // fbd_klasorsec
            // 
            this.fbd_klasorsec.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btn_dosyasec
            // 
            this.btn_dosyasec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(184)))), ((int)(((byte)(56)))));
            this.btn_dosyasec.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dosyasec.Location = new System.Drawing.Point(391, 22);
            this.btn_dosyasec.Name = "btn_dosyasec";
            this.btn_dosyasec.Size = new System.Drawing.Size(128, 44);
            this.btn_dosyasec.TabIndex = 9;
            this.btn_dosyasec.Text = "DOSYA SEÇ";
            this.btn_dosyasec.UseVisualStyleBackColor = false;
            this.btn_dosyasec.Click += new System.EventHandler(this.btn_dosyasec_Click);
            // 
            // ofd_dosyasec
            // 
            this.ofd_dosyasec.FileName = "ofd_dosyasec";
            // 
            // lbx_veritabanlari
            // 
            this.lbx_veritabanlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.lbx_veritabanlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbx_veritabanlari.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbx_veritabanlari.FormattingEnabled = true;
            this.lbx_veritabanlari.ItemHeight = 24;
            this.lbx_veritabanlari.Location = new System.Drawing.Point(30, 171);
            this.lbx_veritabanlari.Name = "lbx_veritabanlari";
            this.lbx_veritabanlari.Size = new System.Drawing.Size(530, 292);
            this.lbx_veritabanlari.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seçili Veritabanları";
            // 
            // btn_seckaldir
            // 
            this.btn_seckaldir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(184)))), ((int)(((byte)(56)))));
            this.btn_seckaldir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_seckaldir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seckaldir.ImageKey = "delete.png";
            this.btn_seckaldir.ImageList = this.ımageList1;
            this.btn_seckaldir.Location = new System.Drawing.Point(30, 482);
            this.btn_seckaldir.Name = "btn_seckaldir";
            this.btn_seckaldir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_seckaldir.Size = new System.Drawing.Size(242, 43);
            this.btn_seckaldir.TabIndex = 9;
            this.btn_seckaldir.Text = "SEÇİLENİ KALDIR";
            this.btn_seckaldir.UseVisualStyleBackColor = false;
            this.btn_seckaldir.Click += new System.EventHandler(this.btn_seckaldir_Click);
            // 
            // btn_listemizle
            // 
            this.btn_listemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(184)))), ((int)(((byte)(56)))));
            this.btn_listemizle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_listemizle.ImageKey = "remove.png";
            this.btn_listemizle.ImageList = this.ımageList1;
            this.btn_listemizle.Location = new System.Drawing.Point(324, 482);
            this.btn_listemizle.Name = "btn_listemizle";
            this.btn_listemizle.Size = new System.Drawing.Size(236, 43);
            this.btn_listemizle.TabIndex = 9;
            this.btn_listemizle.Text = "LİSTEYİ TEMİZLE";
            this.btn_listemizle.UseVisualStyleBackColor = false;
            this.btn_listemizle.Click += new System.EventHandler(this.btn_listemizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ImageKey = "searchicon.png";
            this.label4.ImageList = this.ımageList1;
            this.label4.Location = new System.Drawing.Point(530, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "  ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 682);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gidilmek üzere seçilen veri tabanı";
            // 
            // txt_seciliveritabani
            // 
            this.txt_seciliveritabani.Enabled = false;
            this.txt_seciliveritabani.Location = new System.Drawing.Point(35, 713);
            this.txt_seciliveritabani.Name = "txt_seciliveritabani";
            this.txt_seciliveritabani.Size = new System.Drawing.Size(525, 22);
            this.txt_seciliveritabani.TabIndex = 14;
            // 
            // link_veritabanigit
            // 
            this.link_veritabanigit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.link_veritabanigit.AutoSize = true;
            this.link_veritabanigit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(184)))), ((int)(((byte)(56)))));
            this.link_veritabanigit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.link_veritabanigit.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(254)))), ((int)(((byte)(163)))));
            this.link_veritabanigit.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_veritabanigit.LinkColor = System.Drawing.SystemColors.ControlText;
            this.link_veritabanigit.Location = new System.Drawing.Point(270, 738);
            this.link_veritabanigit.Name = "link_veritabanigit";
            this.link_veritabanigit.Size = new System.Drawing.Size(45, 26);
            this.link_veritabanigit.TabIndex = 15;
            this.link_veritabanigit.TabStop = true;
            this.link_veritabanigit.Text = "GİT";
            this.link_veritabanigit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_veritabanigit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_veritabanigit_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(254)))), ((int)(((byte)(163)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1573, 793);
            this.Controls.Add(this.link_veritabanigit);
            this.Controls.Add(this.txt_seciliveritabani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbx_veritabanlari);
            this.Controls.Add(this.txt_secilenklasor);
            this.Controls.Add(this.btn_dosyasec);
            this.Controls.Add(this.btn_listemizle);
            this.Controls.Add(this.btn_seckaldir);
            this.Controls.Add(this.btn_klasorsec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_aramaSonuc);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.txt_aramaKey);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aramaSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_aramaSonuc;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_aramaKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_klasorsec;
        private System.Windows.Forms.TextBox txt_secilenklasor;
        private System.Windows.Forms.FolderBrowserDialog fbd_klasorsec;
        private System.Windows.Forms.Button btn_dosyasec;
        private System.Windows.Forms.OpenFileDialog ofd_dosyasec;
        private System.Windows.Forms.ListBox lbx_veritabanlari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_seckaldir;
        private System.Windows.Forms.Button btn_listemizle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label4;
        private Label label5;
        private TextBox txt_seciliveritabani;
        private LinkLabel link_veritabanigit;
    }
}

