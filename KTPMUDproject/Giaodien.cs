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
    public partial class Giaodien : Form
    {
        MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=hong1997;");
        string staff_id;
        public Giaodien(string id)
        {
            InitializeComponent();
            //*
            staff_id = id;
            tabControl.SelectTab(tabPageProfile);
            //tao mot lien ket den co so du lieu
            //string connectdata = "datasource=localhost;port=3306;username=root;password=hong1997;";
            //MySqlConnection myconnection = new MySqlConnection(connectdata);
            //tao doi tuong adapter de gui cac lenh truy van den CSDL
            MySqlDataAdapter mydataadapter = new MySqlDataAdapter();
            //Chon lenh select trong doi tuong adapter
            mydataadapter.SelectCommand = new MySqlCommand("select * from ktpmud.nhan_vien where Ma_nhan_vien ='" + staff_id + "' ;", myconnection);
            //Cap nhat du lieu nhan vien vao giao dien
            //Cap nhat du lieu nhan vien vao giao dien
            myconnection.Open();
            MySqlDataReader myreader;
            myreader = mydataadapter.SelectCommand.ExecuteReader();
            myreader.Read();
            if (myreader["Chuc_vu"].ToString() == "1")
            {
                buttonOrder.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button10.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
            }
            else if (myreader["Chuc_vu"].ToString() == "2")
            {
                buttonStaff.Visible = false;
                buttonReport.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button10.Visible = false;
              
                
            }
            else
            {
                buttonStaff.Visible = false;
                buttonReport.Visible = false;
                buttonOrder.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
              
            }
            label1.Text = "Chao, " + myreader.GetString("Ten_nhan_vien");
            textBoxSo_dien_thoai.Text = myreader.GetString("So_dien_thoai");
            textBoxMa_nhan_vien.Text = myreader.GetString("Ma_nhan_vien");
            textBoxGioi_tinh.Text = myreader.GetString("Gioi_tinh");
            string chucvu = "";
            if (myreader["Chuc_vu"].ToString() == "1")
            {
                chucvu = "Quan ly";
            }
            else if (myreader["Chuc_vu"].ToString() == "2")
            {
                chucvu = "Tiep tan";
            }
            else
            {
                chucvu = "Nhan vien kho";
            }
            textBoxChuc_vu.Text = chucvu;
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
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            button4.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPagePhim);
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageStaff);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageReport);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageOrder);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectTab(tabPageProfile);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void buttonChangeProfile_Click(object sender, EventArgs e)
        {
            textBoxMa_nhan_vien.Enabled = true;
            textBoxGioi_tinh.Enabled = true;
            textBoxQue_quan.Enabled = true;
            textBoxTen_nhan_vien.Enabled = true;
            textBoxTuoi.Enabled = true;
            textBoxSo_dien_thoai.Enabled = true;
            button4.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxMa_nhan_vien.Enabled = false;
            textBoxGioi_tinh.Enabled = false;
            textBoxChuc_vu.Enabled = false;
            textBoxQue_quan.Enabled = false;
            textBoxTen_nhan_vien.Enabled = false;
            textBoxTuoi.Enabled = false;
            textBoxSo_gio_lam.Enabled = false;
            textBoxSo_dien_thoai.Enabled = false;
            button4.Visible = false;
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            MySqlCommand cm = new MySqlCommand("select * from ktpmud.phim order by Ma_phim", myconnection);
            try
            {
                MySqlDataReader myreader = cm.ExecuteReader();
                while (myreader.Read())
                {
                    ListViewItem item = new ListViewItem(myreader["Ma_phim"].ToString());
                    item.SubItems.Add(myreader["Ten_phim"].ToString());
                    item.SubItems.Add(myreader["Gia_phim"].ToString());
                    item.SubItems.Add(myreader["Ma_nhan_vien"].ToString());

                    listView1.Items.Add(item);
                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void Giaodien_Load(object sender, EventArgs e)
        {
            
            try
            {
                myconnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void buttonRefresh2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            MySqlCommand cm = new MySqlCommand("select * from ktpmud.nhan_vien order by Ma_nhan_vien", myconnection);
            try
            {
                MySqlDataReader myreader = cm.ExecuteReader();
                while (myreader.Read())
                {
                    ListViewItem item = new ListViewItem(myreader["Ma_nhan_vien"].ToString());
                    item.SubItems.Add(myreader["Ten_nhan_vien"].ToString());
                    item.SubItems.Add(myreader["So_dien_thoai"].ToString());
                    string chucvu= "quan ly";
                    if (myreader["Chuc_vu"].ToString() == "1")
                    {
                        chucvu = "Quan ly";
                    }
                    else if (myreader["Chuc_vu"].ToString() == "2")
                    {
                        chucvu = "Tiep tan";
                    }
                    else
                    {
                        chucvu = "Nhan vien kho";
                    }
                    item.SubItems.Add(chucvu);
                    item.SubItems.Add(myreader["So_gio_lam"].ToString());

                    listView2.Items.Add(item);
                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void buttonRefresh3_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            MySqlCommand cm = new MySqlCommand("select * from ktpmud.dat_phong", myconnection);
            try
            {
                MySqlDataReader myreader = cm.ExecuteReader();
                while (myreader.Read())
                {
                    ListViewItem item = new ListViewItem(myreader["Ma_khach_hang"].ToString());
                    item.SubItems.Add(myreader["Ma_phong"].ToString());
                    item.SubItems.Add(myreader["Thoi_gian_dat_phong"].ToString());
                    item.SubItems.Add(myreader["So_nguoi"].ToString());
                    item.SubItems.Add(myreader["Thoi_gian_su_dung"].ToString());
                    item.SubItems.Add(myreader["Hinh_thuc_dat"].ToString());
                    item.SubItems.Add(myreader["Giam_gia"].ToString());

                    listView3.Items.Add(item);
                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = myconnection;
            if (comboBoxPhim.Text == "Ma_phim")
            {
                cm.CommandText = "select * from ktpmud.phim where Ma_phim = '" + textBoxSearchPhim.Text + "' ;";

            }
            else if (comboBoxPhim.Text == "Ten_phim")
            {
                cm.CommandText = "select * from ktpmud.phim where Ten_phim = '" + textBoxSearchPhim.Text + "' ;";

            }
            else if (comboBoxPhim.Text == "Ma_nhan_vien")
            {
                cm.CommandText = "select * from ktpmud.phim where Ma_nhan_vien = '" + textBoxSearchPhim.Text + "' ;";

            }
            else
            {
                MessageBox.Show("Không có lựa chọn này");
                cm.CommandText = "select * from ktpmud.phim";
            }
            try
            {
                MySqlDataReader myreader = cm.ExecuteReader();
                while (myreader.Read())
                {
                    ListViewItem item = new ListViewItem(myreader["Ma_phim"].ToString());
                    item.SubItems.Add(myreader["Ten_phim"].ToString());
                    item.SubItems.Add(myreader["Gia_phim"].ToString());
                    item.SubItems.Add(myreader["Ma_nhan_vien"].ToString());

                    listView1.Items.Add(item);
                }
                myreader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void buttonSearchStaff_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = myconnection;
            if (comboBoxStaff.Text == "Ma_nhan_vien")
            {         
                cm.CommandText = "select * from ktpmud.nhan_vien where Ma_nhan_vien = '" + textBoxSearchStaff.Text + "' ;";               
               
            }
            else if (comboBoxStaff.Text == "Ten_nhan_vien")
            {
                cm.CommandText = "select * from ktpmud.nhan_vien where Ten_nhan_vien = '" + textBoxSearchStaff.Text + "' ;";
            }
            else
            {
                MessageBox.Show("Không có lựa chọn này");
                cm.CommandText = "select * from ktpmud.nhan_vien";
            }

            try
            {
                MySqlDataReader myreader = cm.ExecuteReader();
                while (myreader.Read())
                {
                    ListViewItem item = new ListViewItem(myreader["Ma_nhan_vien"].ToString());
                    item.SubItems.Add(myreader["Ten_nhan_vien"].ToString());
                    item.SubItems.Add(myreader["So_dien_thoai"].ToString());
                    string chucvu = "quan ly";
                    if (myreader["Chuc_vu"].ToString() == "1")
                    {
                        chucvu = "Quan ly";
                    }
                    else if (myreader["Chuc_vu"].ToString() == "2")
                    {
                        chucvu = "Tiep tan";
                    }
                    else
                    {
                        chucvu = "Nhan vien kho";
                    }
                    item.SubItems.Add(chucvu);
                    item.SubItems.Add(myreader["So_gio_lam"].ToString());

                    listView2.Items.Add(item);
                }
                myreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = myconnection;
            
            if (comboBox1.Text == "Ma_khach_hang")
            {
                cm.CommandText = "select * from ktpmud.dat_phong where Ma_khach_hang = '" + textBox1.Text + "' ;";

            }
            else if (comboBox1.Text == "Ma_phong")
            {
                cm.CommandText = "select * from ktpmud.dat_phong where Ma_phong = '" + textBox1.Text + "' ;";
            }
            else
            {
                MessageBox.Show("Không có lựa chọn này");
                cm.CommandText = "select * from ktpmud.dat_phong";
                
            }
            
                try
                {
                    MySqlDataReader myreader = cm.ExecuteReader();
                    while (myreader.Read())
                    {
                        ListViewItem item = new ListViewItem(myreader["Ma_khach_hang"].ToString());
                        item.SubItems.Add(myreader["Ma_phong"].ToString());
                        item.SubItems.Add(myreader["Thoi_gian_dat_phong"].ToString());
                        item.SubItems.Add(myreader["So_nguoi"].ToString());
                        item.SubItems.Add(myreader["Thoi_gian_su_dung"].ToString());
                        item.SubItems.Add(myreader["Hinh_thuc_dat"].ToString());
                        item.SubItems.Add(myreader["Giam_gia"].ToString());

                        listView3.Items.Add(item);
                    }
                    myreader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxChuc_vu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
