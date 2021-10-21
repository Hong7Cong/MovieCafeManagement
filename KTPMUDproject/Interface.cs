using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KTPMUDproject
{
    public partial class Interface : Form
    {
        string staff_id;
        public Interface(string id)
        {
            InitializeComponent();                    
            staff_id = id;
            tabControl.SelectTab(tabPageProfile);
            //tao mot lien ket den co so du lieu
            string connectdata = "datasource=localhost;port=3306;username=root;password=hong1997;";
            MySqlConnection myconnection = new MySqlConnection(connectdata);
            //tao doi tuong adapter de gui cac lenh truy van den CSDL
            MySqlDataAdapter mydataadapter = new MySqlDataAdapter();
            //Chon lenh select trong doi tuong adapter
            mydataadapter.SelectCommand = new MySqlCommand("select * from ktpmud.nhan_vien where Ma_nhan_vien ='" + staff_id + "' ;", myconnection);
            //Cap nhat du lieu nhan vien vao giao dien
            myconnection.Open();
            MySqlDataReader myreader;
            myreader = mydataadapter.SelectCommand.ExecuteReader();
            myreader.Read();
            label1.Text = "Chao, " + myreader.GetString("Ten_nhan_vien");
            textBoxSo_dien_thoai.Text = myreader.GetString("So_dien_thoai");
            textBoxMa_nhan_vien.Text = myreader.GetString("Ma_nhan_vien");
            textBoxGioi_tinh.Text = myreader.GetString("Gioi_tinh");
            textBoxChuc_vu.Text = myreader.GetString("Chuc_vu");
            textBoxQue_quan.Text = myreader.GetString("Que_quan");
            textBoxTen_nhan_vien.Text = myreader.GetString("Ten_nhan_vien");
            textBoxTuoi.Text = myreader.GetString("Tuoi");
            textBoxSo_gio_lam.Text = myreader.GetString("So_gio_lam");
            myconnection.Close();
            textBoxMa_nhan_vien.Enabled = false;
            textBoxGioi_tinh.Enabled = false;
            textBoxChuc_vu.Enabled = false;
            textBoxQue_quan.Enabled = false;
            textBoxTen_nhan_vien.Enabled = false;
            textBoxTuoi.Enabled = false;
            textBoxSo_gio_lam.Enabled = false;
            textBoxSo_dien_thoai.Enabled = false;
            // An tab bar
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Bạn thực sự muốn đăng xuất ?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.ShowDialog();
                Application.Exit();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void pageControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageStaff);
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPagePhim);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageReport);
        }

        private void buttonOder_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabelProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(tabPageProfile);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonChangeProfile_Click(object sender, EventArgs e)
        {
            textBoxMa_nhan_vien.Enabled = true;
            textBoxGioi_tinh.Enabled = true;
            textBoxQue_quan.Enabled = true;
            textBoxTen_nhan_vien.Enabled = true;
            textBoxTuoi.Enabled = true;
            textBoxSo_dien_thoai.Enabled = true;
        }
    }
}
