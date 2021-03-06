﻿using System;
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
            //Handle attempt to return to Decision form
            try
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void RefreshData()
        {
            //Refresh the data displayed in the list views after successful execution of a database operation
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

                    using (SqlCommand cmd = new SqlCommand("SELECT MainCriteriaName FROM MainCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
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

                    using (SqlCommand cmd = new SqlCommand("SELECT MainCriteriaWeighting, MainCriteriaName FROM MainCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        lstMainCriDisplay.Items.Clear();
                        lstMainCriDisplay.Columns.Clear();
                        lstMainCriDisplay.Columns.Add("Main Criteria Weighting:", -2, HorizontalAlignment.Left);
                        lstMainCriDisplay.Columns.Add("Main Criteria:", -2, HorizontalAlignment.Left);

                        SqlDataReader DR = cmd.ExecuteReader();

                        while (DR.Read())
                        {
                            ListViewItem item = new ListViewItem(new[] { DR[0].ToString(), DR[1].ToString() });
                            lstMainCriDisplay.Items.Add(item);
                        }
                        lstMainCriDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lstMainCriDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        DR.Close();
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT MainCriteriaName, SubCriteriaWeighting, SubCriteriaName FROM SubCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "'"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        lstSubCriDisplay.Items.Clear();
                        lstSubCriDisplay.Columns.Clear();
                        lstSubCriDisplay.Columns.Add("Main Criteria:", -2, HorizontalAlignment.Left);
                        lstSubCriDisplay.Columns.Add("Sub Criteria Weighting:", -2, HorizontalAlignment.Left);
                        lstSubCriDisplay.Columns.Add("Sub Criteria:", -2, HorizontalAlignment.Left);

                        SqlDataReader DR = cmd.ExecuteReader();

                        while (DR.Read())
                        {
                            ListViewItem item = new ListViewItem(new[] { DR[0].ToString(), DR[1].ToString(), DR[2].ToString() });
                            lstSubCriDisplay.Items.Add(item);
                        }
                        lstSubCriDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lstSubCriDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void frmCriteria_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSubmitMainCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to add new main criteria into database
            try
            {
                int result = -1;
                bool success = Int32.TryParse(txtMainCriWeight.Text, out result);
                if (txtMainCriName.Text == "" || txtMainCriWeight.Text == "")
                {
                    MessageBox.Show("Please enter both the name of the criteria and the weighting");
                }
                else if (!success || result < 0 || result > 10)
                {
                    MessageBox.Show("Please ensure that the weighting assigned to the criteria is an integer (no decimal values) between and including 0 to 10.");
                }
                else if (txtMainCriName.Text != "" && txtMainCriWeight.Text != "" && result >= 0 && result <= 10)
                {
                    var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                    using (SqlConnection conn = new SqlConnection(connection.ToString()))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO MainCriteria (DecisionName, MainCriteriaName, MainCriteriaWeighting) VALUES (@Decision, @CriteriaName, @CriteriaWeighting)"))
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
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnSubmitSubCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to add new sub criteria into database
            try
            {
                int result = -1;
                bool success = Int32.TryParse(txtSubCriWeight.Text, out result);
                if (cmbMainCriteria.Text == "" || txtSubCriName.Text == "" || txtSubCriWeight.Text == "")
                {
                    MessageBox.Show("Please enter the name of the main and sub criteria and the weighting of the sub criteria");
                }
                else if (!success || result < 0 || result > 10)
                {
                    MessageBox.Show("Please ensure that the weighting assigned to the criteria is an integer (no decimal values) between and including 0 to 10.");
                }
                else if (cmbMainCriteria.Text != "" && txtSubCriName.Text != "" && txtSubCriWeight.Text != "" && result >= 0 && result <= 10)
                {
                    var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(connection.ToString()))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO SubCriteria (DecisionName, MainCriteriaName, SubCriteriaName, SubCriteriaWeighting) VALUES (@Decision, @MainCriteriaName, @CriteriaName, @CriteriaWeighting)"))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@Decision", lblCurrDecision.Text);
                            cmd.Parameters.AddWithValue("@MainCriteriaName", cmbMainCriteria.Text);
                            cmd.Parameters.AddWithValue("@CriteriaName", txtSubCriName.Text);
                            cmd.Parameters.AddWithValue("@CriteriaWeighting", txtSubCriWeight.Text);

                            cmd.ExecuteNonQuery();
                        }
                        cmbMainCriteria.Text = "";
                        txtSubCriName.Text = "";
                        txtSubCriWeight.Text = "";
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

        private void btnToSolutionForm_Click(object sender, EventArgs e)
        {
            var solution = new frmSolution();
            this.Hide();
            solution.Show();
        }

        private void btnUpdateMainCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to update the main criteria existing in the database
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                int result = -1;
                bool success = Int32.TryParse(txtMainCriWeight.Text, out result);
                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    if (lstMainCriDisplay.SelectedIndices[0] == -1 || txtMainCriWeight.Text == "" || txtMainCriName.Text == "")
                    {
                        MessageBox.Show("Please select the criteria you wish to edit, and make sure that the criteria name and weighting fields are filled.");
                    }
                    else if (!success || result < 0 || result > 10)
                    {
                        MessageBox.Show("Please ensure that the weighting assigned to the criteria is a number between and including 0 to 10.");
                    }
                    else if (lstMainCriDisplay.SelectedIndices[0] != -1 && txtMainCriWeight.Text != "" && txtMainCriName.Text != "" && result >= 0 && result <= 10)
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE MainCriteria SET MainCriteriaName = @CriteriaName, MainCriteriaWeighting = @CriteriaWeighting WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "' AND MainCriteriaName = '" + lstMainCriDisplay.SelectedItems[0].SubItems[1].Text.ToString() + "'"))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@CriteriaName", txtMainCriName.Text);
                            cmd.Parameters.AddWithValue("@CriteriaWeighting", txtMainCriWeight.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
                txtMainCriWeight.Text = "";
                txtMainCriName.Text = "";
                RefreshData();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnUpdateSubCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to update the sub criteria existing in the database
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                int result = -1;
                bool success = Int32.TryParse(txtSubCriWeight.Text, out result);
                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    if (lstSubCriDisplay.SelectedIndices[0] == -1 || (cmbMainCriteria.Text == "" && txtSubCriWeight.Text == "" || cmbMainCriteria.Text == "" && txtSubCriName.Text == ""))
                    {
                        MessageBox.Show("Please select the criteria you wish to edit, and make sure that the main and sub criteria names and weighting fields are filled.");
                    }
                    else if (lstSubCriDisplay.SelectedIndices[0] != -1 && cmbMainCriteria.Text != "" && txtSubCriWeight.Text != "" && txtSubCriName.Text != "")
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE SubCriteria SET MainCriteriaName = @MainCriteriaName, SubCriteriaName = @SubCriteriaName, SubCriteriaWeighting = @SubCriteriaWeighting WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "' AND MainCriteriaName = '" + lstSubCriDisplay.SelectedItems[0].SubItems[0].Text.ToString() + "' AND SubCriteriaName = '" + lstSubCriDisplay.SelectedItems[0].SubItems[2].Text.ToString() + "'"))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@MainCriteriaName", cmbMainCriteria.Text);
                            cmd.Parameters.AddWithValue("@SubCriteriaName", txtSubCriName.Text);
                            cmd.Parameters.AddWithValue("@SubCriteriaWeighting", txtSubCriWeight.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
                cmbMainCriteria.Text = "";
                txtSubCriName.Text = "";
                txtSubCriWeight.Text = "";
                RefreshData();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnDeleteMainCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to delete existing main criteria from the database
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    if (lstMainCriDisplay.SelectedIndices[0] == -1)
                    {
                        MessageBox.Show("Please select the criteria you wish to delete by clicking on it..");
                    }
                    else if (lstMainCriDisplay.SelectedIndices[0] != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM MainCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "' AND MainCriteriaName = '" + lstMainCriDisplay.SelectedItems[0].SubItems[1].Text.ToString() + "'"))
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

        private void btnDeleteSubCriteria_Click(object sender, EventArgs e)
        {
            //Handle attempts to delete existing sub criteria from the database
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["DecisionsServer"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connection.ToString()))
                {
                    conn.Open();
                    if (lstSubCriDisplay.SelectedIndices[0] == -1)
                    {
                        MessageBox.Show("Please select the criteria you wish to delete by clicking on it..");
                    }
                    else if (lstSubCriDisplay.SelectedIndices[0] != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM SubCriteria WHERE DecisionName = '" + lblCurrDecision.Text.ToString() + "' AND SubCriteriaName = '" + lstSubCriDisplay.SelectedItems[0].SubItems[2].Text.ToString() + "'"))
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
    }
}
