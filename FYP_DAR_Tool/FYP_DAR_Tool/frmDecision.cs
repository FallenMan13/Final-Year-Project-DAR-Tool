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
            //Refresh the data displayed in the list box after any database operations have successfully executed
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DecisionName FROM Decision"))
                    {
                        lstDecisionDisplay.Items.Clear();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        SqlDataReader DR = cmd.ExecuteReader();

                        while (DR.Read())
                        {
                            lstDecisionDisplay.Items.Add(DR[0]);
                        }
                        DR.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnNewDecision_Click(object sender, EventArgs e)
        {
            //Insert a new decision into the "Decision" table and then calls the "RefreshData" function to display the newly added decision
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                if (txtDecisionName.Text == "")
                {
                    MessageBox.Show("Please enter the name of the decision you wish to create");
                }
                else if (txtDecisionName.Text != "")
                {
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
                }
                RefreshData();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void frmDecision_Load(object sender, EventArgs e)
        {
            //Ensure that the data displayed in the list box is always up to date upon first load of the form
            RefreshData();
        }

        private void btnLoadDecision_Click(object sender, EventArgs e)
        {
            //Handle attempts at loading a created decision
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    if (lstDecisionDisplay.SelectedIndex == -1)
                    {
                        //Below SQL Command is for a situation where the program closed before setting the "IsCurrentDecision" field of the decision being used to 0
                        //and the user accidentally attempts to load no decision
                        using (SqlCommand cmd = new SqlCommand("UPDATE Decision SET IsCurrentDecision = 0 WHERE IsCurrentDecision = 1"))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Please select the decision you wish to load.");
                    }
                    else if (lstDecisionDisplay.SelectedIndex != -1)
                    {
                        //Ensure that only one decision is set to be the current decision at a time by resetting the "IsCurrentDecision" value of all other decisions
                        //back to 0 if there are any.
                        using (SqlCommand cmd = new SqlCommand("UPDATE Decision SET IsCurrentDecision = 0 WHERE DecisionName <> '" + lstDecisionDisplay.SelectedItems[0].ToString() + "' AND IsCurrentDecision = 1"))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand("UPDATE Decision SET IsCurrentDecision = 1 WHERE DecisionName = '" + lstDecisionDisplay.SelectedItems[0].ToString() + "'"))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                            cmd.ExecuteNonQuery();
                        }
                        var criteria = new frmCriteria();
                        this.Hide();
                        criteria.Show();
                    }
                    conn.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Handle attempts to edit the name of a created decision
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    //If the decision has not been selected from the list box OR the new decision name has not been entered into the text field when pressing the edit button
                    //do not attempt to execute any SQL code, and return a message stating the steps needed for editing to be successful
                    if (lstDecisionDisplay.SelectedIndex == -1 || txtDecisionName.Text == "")
                    {
                        MessageBox.Show("Please select one of the decision names from the list by clicking on it and please enter the name you wish to change the selected decision to.");
                    }
                    //If the necessary steps have been completed, execute the below SQL code to update the name of the selected decision
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Handle attempts to delete a decision from the database 
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    //If no decision was selected from the list box when pressing the delete button, return a message stating as such
                    if (lstDecisionDisplay.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select the name of the decision you wish to delete by clicking on it.");
                    }
                    //If a decision was selected from the list box when pressing the delete button, execute the below SQL code to remove the decision from the database
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
