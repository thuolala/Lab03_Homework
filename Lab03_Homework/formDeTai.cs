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

namespace Lab03_Homework
{
    public partial class formDeTai : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        public formDeTai()
        {
            InitializeComponent();
        }

        private void dataGridViewDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
        //Load Data Both  
        private void LoadData()
        {
            try
            {
                String sql = "";
                //Case 1: KP < 10000000
                if (comboBoxKP.SelectedIndex == 0){
                    sql = "SELECT * FROM DeTai WHERE ChuNhiem = @CN AND (KinhPhi <= 10000000)";
                }
                //Case 2: 10000000 <= KP < 100000000
                else if(comboBoxKP.SelectedIndex == 1)
                {
                    sql = "SELECT * FROM DeTai WHERE ChuNhiem = @CN AND (KinhPhi > 10000000 AND KinhPhi <= 100000000)";
                }
                //Case 3: KP > 100000000
                else if(comboBoxKP.SelectedIndex == 2)
                {
                    sql = "SELECT * FROM DeTai WHERE ChuNhiem = @CN AND KinhPhi > 100000000";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@CN", comboBoxCN.SelectedItem.ToString()));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewDT.DataSource = dt;
                }
                else
                {
                    dataGridViewDT.DataSource = "";
                    MessageBox.Show("No Data!");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }
        */

        //Load CN 
        private void LoadDataCN()
        {
            try
            {
                String sql = "SELECT * FROM DeTai WHERE ChuNhiem = @CN";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@CN", comboBoxCN.SelectedItem.ToString()));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewDT.DataSource = dt;
                }
                else
                {
                    dataGridViewDT.DataSource = "";
                    MessageBox.Show("No Data!");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        //Load KP 
        private void LoadDataKP()
        {
            try
            {
                String sql = "";
                //Case 1: KP < 10000000
                if (comboBoxKP.SelectedIndex == 0)
                {
                    sql = "SELECT * FROM DeTai WHERE (KinhPhi <= 10000000)";
                }
                //Case 2: 10000000 <= KP < 100000000
                else if (comboBoxKP.SelectedIndex == 1)
                {
                    sql = "SELECT * FROM DeTai WHERE (KinhPhi > 10000000 AND KinhPhi <= 100000000)";
                }
                //Case 3: KP > 100000000
                else if (comboBoxKP.SelectedIndex == 2)
                {
                    sql = "SELECT * FROM DeTai WHERE KinhPhi > 100000000";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewDT.DataSource = dt;
                }
                else
                {
                    dataGridViewDT.DataSource = "";
                    MessageBox.Show("No Data!");
                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        //Load beginning 
        private void formDeTai_Load(object sender, EventArgs e)
        {
            comboBoxCN.SelectedItem = null;
            comboBoxCN.SelectedText = "--Select--";
            comboBoxKP.SelectedItem = null;
            comboBoxKP.SelectedText = "--Select--";

            //Theo CN
            SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT ChuNhiem FROM DeTai", conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);

            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    comboBoxCN.Items.Add(dt1.Rows[i]["ChuNhiem"].ToString());
                }
               // LoadData();
            }
            else
            {
                MessageBox.Show("No Data!");
            }
            adapter1.Dispose();

            //Theo KP
            comboBoxKP.Items.Add("<= 10.000.000 đồng");
            comboBoxKP.Items.Add("<= 100.000.000 đồng");
            comboBoxKP.Items.Add("> 100.000.000 đồng");
        }
        
        //Load all 
        private void btnAll_Click(object sender, EventArgs e)
        {
            comboBoxCN.Text = "";
            comboBoxCN.SelectedItem = null;
            comboBoxCN.SelectedText = "--Select--";
            comboBoxKP.Text = "";
            comboBoxKP.SelectedItem = null;
            comboBoxKP.SelectedText = "--Select--";

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DeTai", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewDT.DataSource = dt;
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

        //Chu nhiem 
        private void comboBoxCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKP.SelectedItem = null;
            //comboBoxKP.SelectedText = "--Select--";
            LoadDataCN();
        }

        //Kinh phi 
        private void comboBoxKP_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCN.SelectedItem = null;
            //comboBoxCN.SelectedText = "--Select--";
            LoadDataKP();
        }
    }
}
