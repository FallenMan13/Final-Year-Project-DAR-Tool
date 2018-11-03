using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FYP_DAR_Tool
{
    public partial class frmCriteria : Form
    {
        //Code written by Ross Craig B00705624
        
        
        public frmCriteria()
        {
            InitializeComponent();
        }

        private void btnBackToDecisionFrm_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Decision SET IsCurrentDecision = 0 WHERE DecisionName = @Decision"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@Decision", lblCurrDecision.Text);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            var decision = new frmDecision();
            this.Hide();
            decision.Show();
        }

        private void RefreshData()
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT DecisionName FROM Decision WHERE IsCurrentDecision = 1"))
                {
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        lblCurrDecision.Text = DR[0].ToString();
                    }
                    DR.Close();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT CriteriaName FROM MainCriteria"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmbMainCriteria.Items.Clear();

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        cmbMainCriteria.Items.Add(DR[0]);
                    }
                    DR.Close();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT CriteriaWeighting, CriteriaName FROM MainCriteria"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    lstDisplay.Items.Clear();

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        lstDisplay.Items.Add(DR[0] + "\t" + DR[1]);
                    }
                    DR.Close();
                }

                conn.Close();
            }
        }

        private void frmCriteria_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSubmitMainCriteria_Click(object sender, EventArgs e)
        {
            if (txtMainCriName.Text == "" || txtMainCriWeight.Text == "")
            {
                MessageBox.Show("Please enter both the name of the criteria and the weighting");
            }
            else if (txtMainCriName.Text != "" && txtMainCriWeight.Text != "")
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO MainCriteria (DecisionName, CriteriaName, CriteriaWeighting) VALUES (@Decision, @CriteriaName, @CriteriaWeighting)"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@Decision", lblCurrDecision.Text);
                        cmd.Parameters.AddWithValue("@CriteriaName", txtMainCriName.Text);
                        cmd.Parameters.AddWithValue("@CriteriaWeighting", txtMainCriWeight.Text);

                        cmd.ExecuteNonQuery();
                    }
                    txtMainCriName.Text = "";
                    txtMainCriWeight.Text = "";
                    conn.Close();
                }
            }
            RefreshData();
        }
    }
}
