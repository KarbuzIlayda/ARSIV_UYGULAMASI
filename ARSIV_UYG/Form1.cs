using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Drawing.Text;
using Microsoft.Office.Interop.Access.Dao;
using System.IO;
using System.Linq.Expressions;




namespace ARSIV_UYG
{
    public partial class Form1 : Form
    {
        string[] veritabaniPaths;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_klasorsec_Click(object sender, EventArgs e)
        {
            if (fbd_klasorsec.ShowDialog() == DialogResult.OK)
            { 
                txt_secilenklasor.Text = fbd_klasorsec.SelectedPath;
                string[] veritabanlari = Directory.GetFiles(txt_secilenklasor.Text, "*.accdb");
                if (veritabanlari.Length == 0)
                    MessageBox.Show("Bu klasörde MS Access türünden veri tabanı bulunmamaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    foreach(string vt in veritabanlari)
                    {
                        if (!lbx_veritabanlari.Items.Contains(vt))
                            lbx_veritabanlari.Items.Add($"{vt}");
                        else
                        {
                            MessageBox.Show("İlgili klasör veya veri tabanları zaten seçilmiş.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
            }
            else
                txt_secilenklasor.Text = "";
        }
        private void btn_dosyasec_Click(object sender, EventArgs e)
        {
            if (ofd_dosyasec.ShowDialog() == DialogResult.OK)
            {
                txt_secilenklasor.Text = ofd_dosyasec.FileName;
                if (txt_secilenklasor.Text.Contains(".accdb"))
                    if(!lbx_veritabanlari.Items.Contains(txt_secilenklasor.Text))
                        lbx_veritabanlari.Items.Add(txt_secilenklasor.Text);
                    else
                        MessageBox.Show("Bu veri tabanı zaten seçilmiş.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Seçilen dosya bir veri tabanı değildir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                txt_secilenklasor.Text = "";
        }
        public string[] veritabanlari()
        {
            string[] veritabanlari = new string[lbx_veritabanlari.Items.Count];
            for(int i=0;i<lbx_veritabanlari.Items.Count;i++)
            {
                veritabanlari[i] = lbx_veritabanlari.Items[i].ToString();
            }
            return veritabanlari;

        }
        private string islemGorenSutun(OleDbConnection con, string tabloIsmi)
        {
            OleDbCommand komut = new OleDbCommand($"SELECT TOP 0 * FROM [{tabloIsmi}]", con);
            string[] sutunListe = new string[4] { null, null, $"{tabloIsmi}", null };
            var liste = con.GetSchema("Columns", sutunListe).AsEnumerable().Select(sutun => sutun.Field<string>("Column_Name"));
            string sutunlar = string.Join(", ", liste);
            return sutunlar;
        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            veritabaniPaths = veritabanlari();
            string aramaAnahtari = txt_aramaKey.Text.Trim();
            if (string.IsNullOrEmpty(aramaAnahtari))
            {
                MessageBox.Show("Lütfen bir arama anahtarı giriniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(lbx_veritabanlari.Items.Count == 0)
            {
                MessageBox.Show("İşleme almak için veri tabanı bulunmamaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DataTable sonuclar = new DataTable();
            sonuclar.Columns.Add("Arama Sonucu",typeof(string));
            sonuclar.Columns.Add("Bulunduğu Veritabanı",typeof(string));
            sonuclar.Columns.Add("Bulunduğu Tablo",typeof(string));
            sonuclar.Columns.Add("Sütun",typeof(string));
            
            foreach (string vtPath in veritabaniPaths)
            {
                if (!File.Exists(vtPath))
                {
                    MessageBox.Show("Veritabanı dosyası bulunamadı: " + vtPath,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    continue;
                }
                try
                {
                    using (OleDbConnection baglanti = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {vtPath}"))
                    {
                        baglanti.Open();
                        DataTable tablolar = baglanti.GetSchema("Tables", new string[] { null, null, null, "TABLE" });    //baglantı sağlanan veri tabanının şemasını Tablolar şeması olarak aldım ve bunu şema bilgilerini taşıyan bir datatable haline getirmiş oldum
                        foreach (DataRow sat in tablolar.Rows)
                        {
                            string tabloIsmi = sat["TABLE_NAME"].ToString();
                            string sutunliste = islemGorenSutun(baglanti, tabloIsmi);
                            string[] sutunlar = sutunliste.Split(',');

                            foreach(string sutun in sutunlar)
                            {
                                string query = $"SELECT * FROM [{tabloIsmi}] WHERE [{sutun.Trim()}] LIKE ?";
                                OleDbCommand command = new OleDbCommand(query, baglanti);
                                command.Parameters.AddWithValue("@searchterm","%" + aramaAnahtari + "%");
                                try
                                {
                                    OleDbDataReader okuyucu = command.ExecuteReader();
                                    while (okuyucu.Read())
                                    {
                                        sonuclar.Rows.Add(okuyucu[sutun.Trim()], vtPath, tabloIsmi, sutun);
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Sorgulama esnasında bir sorunla karşılaşıldı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Veritabanını ({vtPath}) ararken bir sorunla karşılaşıldı!","HATA",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            if(sonuclar.Rows.Count==0)
                 MessageBox.Show("Aradığınız anahtar veri tabanlarında bulunmamaktadır.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_aramaSonuc.DataSource = sonuclar;
        }

        private void btn_seckaldir_Click(object sender, EventArgs e)
        {
            lbx_veritabanlari.Items.Remove(lbx_veritabanlari.SelectedItem);
        }

        private void btn_listemizle_Click(object sender, EventArgs e)
        {
            lbx_veritabanlari.Items.Clear();
        }

        private void dgv_aramaSonuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_aramaSonuc.SelectedCells[0].ColumnIndex == 1)
            {
                string deger = dgv_aramaSonuc.SelectedCells[0].Value.ToString();
                txt_seciliveritabani.Text = deger;
            }
            else
            {
                if (txt_seciliveritabani.Text.Length > 0)
                    txt_seciliveritabani.Clear();
                else
                    return;
            }
        }

        private void link_veritabanigit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txt_seciliveritabani.Text.Length > 0) 
            {
                System.Diagnostics.Process.Start(txt_seciliveritabani.Text);
            }
            else
                MessageBox.Show("Lütfen bir veri tabanı sütunu seçtiğinizden emin olunuz.","HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            link_veritabanigit.LinkBehavior = LinkBehavior.NeverUnderline;
        }
    }
}