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
                    lstDecisionDisplay.Items.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        cmbDecision.Items.Add(DR[0]);
                        lstDecisionDisplay.Items.Add(DR[0]);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                if (lstDecisionDisplay.SelectedIndex == -1 || txtDecisionName.Text == "")
                {
                    MessageBox.Show("Please select one of the decision names from the list by clicking on it and please enter the name you wish to change the selected decision to.");
                }
                else if (lstDecisionDisplay.SelectedIndex != -1 && txtDecisionName.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Decision SET DecisionName = @DecisionName WHERE DecisionName = '" + lstDecisionDisplay.SelectedItem.ToString() + "'"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@DecisionName", txtDecisionName.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            txtDecisionName.Text = "";
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                if (lstDecisionDisplay.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the name of the decision you wish to delete by clicking on it..");
                }
                else if (lstDecisionDisplay.SelectedIndex != -1)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Decision WHERE DecisionName = @DecisionName"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@DecisionName", lstDecisionDisplay.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            RefreshData();
        }
    }
}
