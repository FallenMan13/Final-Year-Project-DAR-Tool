using System;
using System.Collections.Generic;
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
    public partial class frmSolution : Form
    {
        public frmSolution()
        {
            InitializeComponent();
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

                using (SqlCommand cmd = new SqlCommand("SELECT SolutionName, SolutionOutcomeVal FROM Solution WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    lstSolutionDisplay.Items.Clear();
                    lstSolutionDisplay.Columns.Add("Solution Name:", -2, HorizontalAlignment.Left);
                    lstSolutionDisplay.Columns.Add("Solution Outcome Value:", -2, HorizontalAlignment.Left);

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        ListViewItem item = new ListViewItem(new[] { DR[0].ToString(), DR[1].ToString() });
                        lstSolutionDisplay.Items.Add(item);
                    }
                    lstSolutionDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lstSolutionDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    DR.Close();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT SolutionName FROM Solution WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmbSolutionName.Items.Clear();

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        cmbSolutionName.Items.Add(DR[0]);
                    }
                    DR.Close();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT MainCriteriaName FROM MainCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmbSolutionCriteria.Items.Clear();

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        cmbSolutionCriteria.Items.Add(DR[0]);
                    }
                    DR.Close();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT SubCriteriaName FROM SubCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmbCriteriaValue.Items.Clear();

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        cmbCriteriaValue.Items.Add(DR[0]);
                    }
                    DR.Close();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT SolutionName, SolutionCriteriaName, SolutionCriteriaValue FROM SolutionCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    lstSolutionCriteriaDisplay.Items.Clear();
                    lstSolutionCriteriaDisplay.Columns.Add("Solution Name", -2, HorizontalAlignment.Left);
                    lstSolutionCriteriaDisplay.Columns.Add("Criteria Name", -2, HorizontalAlignment.Left);
                    lstSolutionCriteriaDisplay.Columns.Add("Criteria Value", -2, HorizontalAlignment.Left);

                    //lstSolutionCriteriaDisplay.Items.Add("Solution Name:" + "Criteria Name:" + "Criteria Value:");

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        ListViewItem item = new ListViewItem(new[] { DR[0].ToString(), DR[1].ToString(), DR[2].ToString() });
                        lstSolutionCriteriaDisplay.Items.Add(item);
                    }
                    lstSolutionCriteriaDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lstSolutionCriteriaDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    DR.Close();
                }
            }
        }

        private void frmSolution_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSubmitSolutionName_Click(object sender, EventArgs e)
        {
            if (txtSolutionName.Text == "")
            {
                MessageBox.Show("Please enter the name of the solution you wish to add");
            }
            else if (txtSolutionName.Text != "")
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Solution (DecisionName, SolutionName, SolutionOutcomeVal) VALUES (@Decision, @SolutionName, @OutcomeVal)"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@Decision", lblCurrDecision.Text);
                        cmd.Parameters.AddWithValue("@SolutionName", txtSolutionName.Text);
                        cmd.Parameters.AddWithValue("@OutcomeVal", 0);

                        cmd.ExecuteNonQuery();
                    }
                    txtSolutionName.Text = "";
                    conn.Close();
                }
            }
            RefreshData();
        }

        private void btnSubmitSolutionCriteria_Click(object sender, EventArgs e)
        {
            if (cmbSolutionName.Text == "" || cmbSolutionCriteria.Text == "" || cmbCriteriaValue.Text == "")
            {
                MessageBox.Show("Please enter the name of the solution the criteria is attributed to, the name of the criteria to attribute a value to and the value to attribute to a criteria");
            }
            else if (cmbSolutionName.Text != "" && cmbSolutionCriteria.Text != "" && cmbCriteriaValue.Text != "")
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO SolutionCriteria (DecisionName, SolutionName, SolutionCriteriaName, SolutionCriteriaValue) VALUES (@Decision, @SolutionName, @SolutionCriteriaName, @SolutionCriteriaValue)"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@Decision", lblCurrDecision.Text);
                        cmd.Parameters.AddWithValue("@SolutionName", cmbSolutionName.Text);
                        cmd.Parameters.AddWithValue("@SolutionCriteriaName", cmbSolutionCriteria.Text);
                        cmd.Parameters.AddWithValue("@SolutionCriteriaValue", cmbCriteriaValue.Text);

                        cmd.ExecuteNonQuery();
                    }
                    cmbSolutionName.Text = "";
                    cmbSolutionCriteria.Text = "";
                    cmbCriteriaValue.Text = "";
                    conn.Close();
                }
            }
            RefreshData();
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

        private void btnReturnToCriteriaForm_Click(object sender, EventArgs e)
        {
            var criteria = new frmCriteria();
            this.Hide();
            criteria.Show();
        }

        private void btnUpdateSolutionName_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                if (lstSolutionDisplay.SelectedIndices[0] == -1 || txtSolutionName.Text == "")
                {
                    MessageBox.Show("Please select the solution you wish to edit, and make sure that the solution name field is filled.");
                }
                else if (lstSolutionDisplay.SelectedIndices[0] != -1 && txtSolutionName.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Solution SET SolutionName = @SolutionName WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "' AND SolutionName = '" + lstSolutionDisplay.SelectedItems[0].SubItems[0].Text.ToString() + "'"))
                    {
                        cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@SolutionName", txtSolutionName.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            txtSolutionName.Text = "";
            RefreshData();
        }

        private void btnDeleteSolutionName_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                if (lstSolutionDisplay.SelectedIndices[0] == -1)
                {
                    MessageBox.Show("Please select the solution name you wish to delete.");
                }
                else if (lstSolutionDisplay.SelectedIndices[0] != -1)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Solution WHERE DecisionName = '" + lblCurrDecision.Text + "' AND SolutionName = '" + lstSolutionDisplay.SelectedItems[0].SubItems[0].Text.ToString() + "'"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            RefreshData();
        }

        private void btnUpdateSolutionCriteria_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                if (lstSolutionCriteriaDisplay.SelectedIndices[0] == -1 || cmbSolutionName.Text == "" || cmbSolutionCriteria.Text == "" || cmbCriteriaValue.Text == "")
                {
                    MessageBox.Show("Please select the solution criteria you wish to edit, and make sure that the solution name, solution criteria and criteria value fields are filled.");
                }
                else if (lstSolutionCriteriaDisplay.SelectedIndices[0] != -1 && cmbSolutionName.Text != "" && cmbSolutionCriteria.Text != "" && cmbCriteriaValue.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE SolutionCriteria SET SolutionName = @SolutionName, SolutionCriteriaName = @SolutionCriName, SolutionCriteriaValue = @SolutionCriValue WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "' AND SolutionName = '" + lstSolutionCriteriaDisplay.SelectedItems[0].SubItems[0].Text.ToString() + "' AND SolutionCriteriaName = '" + lstSolutionCriteriaDisplay.SelectedItems[0].SubItems[1].Text.ToString() + "' AND SolutionCriteriaValue = '" + lstSolutionCriteriaDisplay.SelectedItems[0].SubItems[2].Text.ToString() + "'"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.Parameters.AddWithValue("@SolutionName", cmbSolutionName.Text);
                        cmd.Parameters.AddWithValue("@SolutionCriName", cmbSolutionCriteria.Text);
                        cmd.Parameters.AddWithValue("@SolutionCriValue", cmbCriteriaValue.Text);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close(); 
                }
                cmbSolutionName.Text = "";
                cmbSolutionCriteria.Text = "";
                cmbCriteriaValue.Text = "";
                RefreshData();
            }
        }

        private void btnDeleteSolutionCriteria_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                if (lstSolutionCriteriaDisplay.SelectedIndices[0] == -1)
                {
                    MessageBox.Show("Please select the solution name you wish to delete.");
                }
                else if (lstSolutionCriteriaDisplay.SelectedIndices[0] != -1)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM SolutionCriteria WHERE DecisionName = '" + lblCurrDecision.Text + "' AND SolutionName = '" + lstSolutionCriteriaDisplay.SelectedItems[0].SubItems[0].Text.ToString() + "' AND SolutionCriteriaName = '" + lstSolutionCriteriaDisplay.SelectedItems[0].SubItems[1].Text.ToString() + "' AND SolutionCriteriaValue = '" + lstSolutionCriteriaDisplay.SelectedItems[0].SubItems[2].Text.ToString() + "'"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            RefreshData();
        }

        private void btnCalcBestSolution_Click(object sender, EventArgs e)
        {
            List<String[]> SolutionData = new List<String[]>();
            List<String[]> MainCriData = new List<String[]>();
            List<String[]> SubCriData = new List<String[]>();

            var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT SolutionName, SolutionCriteriaName, SolutionCriteriaValue FROM SolutionCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                {
                    String[] SolData = new String[3];
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        SolData = new String[] { DR[0].ToString(), DR[1].ToString(), DR[2].ToString() };
                        SolutionData.Add(SolData);
                    }
                    DR.Close();
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MainCriteriaName, MainCriteriaWeighting FROM MainCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                {
                    String[] MCriData = new String[2];
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        MCriData = new String[] { DR[0].ToString(), DR[1].ToString() };
                        MainCriData.Add(MCriData);
                    }
                    DR.Close();
                }
                conn.Close();
            }
        }
    }
}
