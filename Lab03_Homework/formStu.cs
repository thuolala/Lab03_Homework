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
    public partial class formStu : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        public formStu()
        {
            InitializeComponent();
        }

        //Load Data  
        private void LoadData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM SVien WHERE QueQuan = @Que", conn);
                cmd.Parameters.Add(new SqlParameter("@Que", comboBoxQue.SelectedItem.ToString()));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewStu.DataSource = dt;
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

        //Load by QueQuan
        private void formStu_Load(object sender, EventArgs e)
        {
            comboBoxQue.SelectedItem = null;
            comboBoxQue.SelectedText = "--Select--";

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT QueQuan FROM SVien", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxQue.Items.Add(dt.Rows[i]["QueQuan"].ToString());
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("No Data!");
            }
            adapter.Dispose();
        }

        //Load all
        private void btnAll_Click(object sender, EventArgs e)
        {
            comboBoxQue.Text = "";
            comboBoxQue.SelectedItem = null;
            comboBoxQue.SelectedText = "--Select--";

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM SVien", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewStu.DataSource = dt;
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

        private void comboBoxQue_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
