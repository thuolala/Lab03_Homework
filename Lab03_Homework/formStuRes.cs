using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03_Homework
{
    public partial class formStuRes : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        public formStuRes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //--LOAD BY EACH--
        //SV
        private void LoadDataSV()
        {
            try
            {
                String sql = "SELECT sd.MSSV, s.HoTen, KetQua FROM SVien s, SVDT sd WHERE sd.MSSV = @MSSV AND sd.MSSV = s.MSSV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@MSSV", comboBoxSV.SelectedItem.ToString()));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewSR.DataSource = dt;
                }
                else
                {
                    dataGridViewSR.DataSource = "";
                    MessageBox.Show("No Data!");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }
        //DT 
        private void LoadDataDT()
        {
            try
            {
                String sql = "SELECT DISTINCT sd.MSDT, d.TenDT, KetQua FROM DeTai d,  SVDT sd WHERE TenDT = @TenDT AND sd.MSDT = d.MSDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@TenDT", comboBoxDT.SelectedItem.ToString()));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewSR.DataSource = dt;
                }
                else
                {
                    dataGridViewSR.DataSource = "";
                    MessageBox.Show("No Data!");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        //CN
        private void LoadDataCN()
        {
            try
            {
                String sql = "SELECT d.ChuNhiem, KetQua FROM DeTai d,  SVDT sd WHERE d.ChuNhiem = @CN AND d.MSDT = sd.MSDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@CN", comboBoxCN.SelectedItem.ToString()));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewSR.DataSource = dt;
                }
                else
                {
                    dataGridViewSR.DataSource = "";
                    MessageBox.Show("No Data!");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        //Load form 
        private void formStuRes_Load(object sender, EventArgs e)
        {
            comboBoxSV.SelectedItem = null;
            comboBoxSV.SelectedText = "--Select--";
            comboBoxDT.SelectedItem = null;
            comboBoxDT.SelectedText = "--Select--";
            comboBoxCN.SelectedItem = null;
            comboBoxCN.SelectedText = "--Select--";

            //Theo SV 
            SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT MSSV FROM SVien", conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);

            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    comboBoxSV.Items.Add(dt1.Rows[i]["MSSV"].ToString());
                }
                // LoadData();
            }
            else
            {
                MessageBox.Show("No Data!");
            }
            adapter1.Dispose();

            //Theo DT 
            SqlCommand cmd2 = new SqlCommand("SELECT DISTINCT TenDT FROM DeTai", conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);

            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    comboBoxDT.Items.Add(dt2.Rows[i]["TenDT"].ToString());
                }
                // LoadData();
            }
            else
            {
                MessageBox.Show("No Data!");
            }
            adapter2.Dispose();

            //Theo CN
            SqlCommand cmd3 = new SqlCommand("SELECT DISTINCT ChuNhiem FROM DeTai", conn);
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);

            DataTable dt3 = new DataTable();
            adapter3.Fill(dt3);
            if (dt3.Rows.Count > 0)
            {
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    comboBoxCN.Items.Add(dt3.Rows[i]["ChuNhiem"].ToString());
                }
                // LoadData();
            }
            else
            {
                MessageBox.Show("No Data!");
            }
            adapter3.Dispose();
        }

        //Load all
        private void btnAll_Click(object sender, EventArgs e)
        {
            comboBoxSV.SelectedItem = null;
            //comboBoxSV.SelectedText = "--Select--";
            comboBoxDT.SelectedItem = null;
            //comboBoxDT.SelectedText = "--Select--";
            comboBoxCN.SelectedItem = null;
            //comboBoxCN.SelectedText = "--Select--";

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM SVDT", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewSR.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data!");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        //Print
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        //Load by SV
        private void comboBoxSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataSV();
        }

        //Load by DT 
        private void comboBoxDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataDT();
        }

        //Load by CN 
        private void comboBoxCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataCN();
        }
    }
}
