using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.BusinessLayer;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.HeThong
{
    public partial class FrmKetNoi : Form
    {
        BLL_HeThong bll;
        SqlConnectionStringBuilder stringBuilder;
        public FrmKetNoi()
        {
            InitializeComponent();
        }

        private void FrmKetNoi_Load(object sender, EventArgs e)
        {
            bll = new BLL_HeThong();
            HienThiChuoiKetNoi(ClsMain.pathConnectionFile);

        }

        private void HienThiChuoiKetNoi(string pathConnectFile)
        {
            stringBuilder = bll.ReadConnectionString(pathConnectFile);
            txtBoxServer.Text = stringBuilder.DataSource;
            txtBoxDBname.Text = stringBuilder.InitialCatalog;
            txtBoxUID.Text = stringBuilder.UserID;
            txtBoxPWD.Text = stringBuilder.Password;
            cbAuth.SelectedIndex = stringBuilder.IntegratedSecurity ? 0 : 1;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string err = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            bll = new BLL_HeThong(ClsMain.pathConnectionFile);
            if(bll.CheckConnect(ref err))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Failed!" + err);
            }
        }
    }
}
