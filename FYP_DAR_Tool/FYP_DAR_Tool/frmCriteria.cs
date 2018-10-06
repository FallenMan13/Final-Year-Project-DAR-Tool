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

namespace FYP_DAR_Tool
{
    public partial class frmCriteria : Form
    {
        //Code written by Ross Craig B00705624
        //Variables
        private ArrayList mainCriteria = new ArrayList();
        private ArrayList subCriteria = new ArrayList();
        
        public frmCriteria()
        {
            InitializeComponent();
        }

        //Function to refresh the list box and display the newly entered criteria
        private void Refresh_ListBox()
        {
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Main Criteria");

            foreach(Object o in mainCriteria)
            {
                lstDisplay.Items.Add(o);
            }

            lstDisplay.Items.Add("");
            lstDisplay.Items.Add("Sub Criteria");

            foreach(Object j in subCriteria)
            {
                lstDisplay.Items.Add(j);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtMainCriWeight.Text != "" && txtMainCriName.Text != "")
            {
                int tempMainCriWeight = Convert.ToInt32(txtMainCriWeight.Text);
                String tempMainCriName = txtMainCriName.Text;

                MainCriteria M1 = new MainCriteria(tempMainCriWeight, tempMainCriName);

                mainCriteria.Add(M1.Weighting);
                mainCriteria.Add(M1.Criteria);

                txtMainCriWeight.Text = "";
                txtMainCriName.Text = "";
            }
            
            if(txtSubCriWeight.Text != "" && txtRltdMainCriName.Text != "" && txtSubCriName.Text != "")
            {
                int tempSubCriWeight = Convert.ToInt32(txtSubCriWeight.Text);
                String tempRltdMainCriName = txtRltdMainCriName.Text;
                String tempSubCriName = txtSubCriName.Text;

                SubCriteria S1 = new SubCriteria(tempSubCriWeight, tempRltdMainCriName, tempSubCriName);

                subCriteria.Add(S1.Weighting);
                subCriteria.Add(S1.MainCriteria);
                subCriteria.Add(S1.Criteria);

                txtSubCriWeight.Text = "";
                txtRltdMainCriName.Text = "";
                txtSubCriName.Text = "";
            }

            Refresh_ListBox();
        }
    }
}
