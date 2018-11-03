using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace FYP_DAR_Tool
{
    public partial class frmDecision : Form
    {
        public frmDecision()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT DecisionName FROM Decision"))
                {
                    cmbDecision.Items.Clear();
                    listBox1.Items.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        cmbDecision.Items.Add(DR[0]);
                        listBox1.Items.Add(DR[0]);
                    }
                    DR.Close();
                }
                conn.Close();
            }
        }

        private void btnNewDecision_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Decision (DecisionName, IsCurrentDecision) VALUES (@Decision, @TF)"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@Decision", txtDecisionName.Text);
                    cmd.Parameters.AddWithValue("@TF", 0);

                    cmd.ExecuteNonQuery();
                }
                txtDecisionName.Text = "";
                conn.Close();
            }

            RefreshData();
        }

        private void frmDecision_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnLoadDecision_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Decision SET IsCurrentDecision = 1 WHERE DecisionName = @Decision"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@Decision", cmbDecision.Text);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            var criteria = new frmCriteria();
            this.Hide();
            criteria.Show();
        }
    }
}
