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
            //Refresh data displayed in the list views after successful execution of a database operation
            try
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void frmSolution_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSubmitSolutionName_Click(object sender, EventArgs e)
        {
            //Handle attempts to insert new solution into database
            try
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnSubmitSolutionCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to insert new solution criteria into database
            try
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnBackToDecisionFrm_Click(object sender, EventArgs e)
        {
            //Handle attempt to return to Decision form
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    //SQL code to set the "IsCurrentDecision" field of the currently used decision back to 0
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnReturnToCriteriaForm_Click(object sender, EventArgs e)
        {
            var criteria = new frmCriteria();
            this.Hide();
            criteria.Show();
        }

        private void btnUpdateSolutionName_Click(object sender, EventArgs e)
        {
            //Handle attempts to update the name of a created solution in the database
            try
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnDeleteSolutionName_Click(object sender, EventArgs e)
        {
            //Handle attempts to delete an existing solution from the database
            try
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnUpdateSolutionCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to update existing solution criteria in the database 
            try
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
                }
                cmbSolutionName.Text = "";
                cmbSolutionCriteria.Text = "";
                cmbCriteriaValue.Text = "";
                RefreshData();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnDeleteSolutionCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to delete existing solution criteria from the database
            try
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnCalcBestSolution_Click(object sender, EventArgs e)
        {
            //Function for comparison algorithm
            try
            {
                //Create lists for required data
                List<String[]> SolData = new List<String[]>();
                List<String[]> SolCriData = new List<String[]>();
                List<String[]> MainCriData = new List<String[]>();
                List<String[]> SubCriData = new List<String[]>();

                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                //Populate the lists with data
                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT SolutionName, SolutionOutcomeVal FROM Solution WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                    {
                        String[] SData = new String[2];
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        SqlDataReader DR = cmd.ExecuteReader();

                        while (DR.Read())
                        {
                            SData = new String[] { DR[0].ToString(), DR[1].ToString() };
                            SolData.Add(SData);
                        }
                        DR.Close();
                    }
                    conn.Close();
                }

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT SolutionName, SolutionCriteriaName, SolutionCriteriaValue FROM SolutionCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                    {
                        String[] SCriData = new String[3];
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        SqlDataReader DR = cmd.ExecuteReader();

                        while (DR.Read())
                        {
                            SCriData = new String[] { DR[0].ToString(), DR[1].ToString(), DR[2].ToString() };
                            SolCriData.Add(SCriData);
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

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT MainCriteriaName, SubCriteriaName, SubCriteriaWeighting FROM SubCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                    {
                        String[] SCriData = new string[3];
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        SqlDataReader DR = cmd.ExecuteReader();

                        while (DR.Read())
                        {
                            SCriData = new String[] { DR[0].ToString(), DR[1].ToString(), DR[2].ToString() };
                            SubCriData.Add(SCriData);
                        }
                        DR.Close();
                    }
                    conn.Close();
                }

                //Multiply the weightings of Main and Sub criteria where the MainCriteriaName in each list matches
                foreach (String[] MCri in MainCriData)
                {
                    foreach (String[] SCri in SubCriData)
                    {
                        if (SCri[0] == MCri[0])
                        {
                            int iOne = 0;
                            int iTwo = 0;
                            Int32.TryParse(SCri[2], out iOne);
                            Int32.TryParse(MCri[1], out iTwo);
                            int res = iOne * iTwo;
                            SCri[2] = res.ToString();
                        }
                    }
                }

                /*
                 Comparison Algorithm pseudo-code:
                 While still using the same Solution Name:
                 Compare Main Criteria and Sub Criteria Names from SubCriData list against values in SolCriData list
                 If match: add current weighting value to int variable
                 Once no longer using the same Solution Name:
                 Replace SolutionOutcomeVal of related Solution with final comparison value
                 */

                foreach (String[] SolName in SolData)
                {
                    int FinalVal = 0;
                    foreach (String[] SCriData in SolCriData)
                    {
                        foreach (String[] SCri in SubCriData)
                        {
                            if (SCriData[0] == SolName[0])
                            {
                                if (SCriData[1] == SCri[0] && SCriData[2] == SCri[1])
                                {
                                    int iOne = 0;
                                    Int32.TryParse(SCri[2], out iOne);
                                    FinalVal += iOne;
                                }
                            }
                        }
                    }
                    SolName[1] = FinalVal.ToString();

                    //Update the "SolutionOutcomeVal" field of a solution with the final calculated outcome value
                    using (SqlConnection conn = new SqlConnection(connection.ToString()))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE Solution SET SolutionOutcomeVal = @SolOutVal WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "' AND SolutionName = '" + SolName[0].ToString() + "'"))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@SolOutVal", SolName[1]);

                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                //Refresh the display to show the new outcome values
                RefreshData();
                
                //Determine which solution is the best for the decision based on the highest outcome value
                int BestVal = 0;
                foreach (String[] SolName in SolData)
                {
                    int iOne = 0;
                    Int32.TryParse(SolName[1], out iOne);
                    if (iOne > BestVal)
                    {
                        BestVal = iOne;
                    }
                }

                foreach (String[] SolName in SolData)
                {
                    int iOne = 0;
                    Int32.TryParse(SolName[1], out iOne);
                    if (BestVal == iOne)
                    {
                        MessageBox.Show("The best solution for this decision is: " + SolName[0]);
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
