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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBox_matkhau.PasswordChar = '*'; // che dau mat khau
            textBox_matkhau.MaxLength = 20;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //tao mot lien ket den co so du lieu
                string connectdata = "datasource=localhost;port=3306;username=root;password=hong1997;";
                MySqlConnection myconnection = new MySqlConnection(connectdata);
                //tao doi tuong adapter de gui cac lenh truy van den CSDL
                MySqlDataAdapter mydataadapter = new MySqlDataAdapter();
                //Chon lenh select trong doi tuong adapter
                mydataadapter.SelectCommand = new MySqlCommand("select * from ktpmud.nhan_vien where Tai_khoan ='" + textBox_taikhoan.Text + "'and Mat_khau ='" + textBox_matkhau.Text + "' ;", myconnection);
                //Reader de doc cac gia tri tra ve
                MySqlDataReader myreader;
                //mo ket noi giong nhu 3-way-handshake
                myconnection.Open();
                myreader = mydataadapter.SelectCommand.ExecuteReader();
                if (myreader.Read())
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                   // mo giao dien chinh ra dong thoi truyen vao id nhan vien do'
                    Giaodien giaodien = new Giaodien(myreader.GetString("Ma_nhan_vien"));
                    giaodien.ShowDialog();
                    //myconnection.Close();
                    myreader.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");                   
                }
                myconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }

}
