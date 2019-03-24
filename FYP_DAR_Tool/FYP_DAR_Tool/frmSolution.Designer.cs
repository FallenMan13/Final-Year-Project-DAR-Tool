namespace FYP_DAR_Tool
{
    partial class frmSolution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrDecision = new System.Windows.Forms.Label();
            this.grpSolutionCriteria = new System.Windows.Forms.GroupBox();
            this.cmbCriteriaValue = new System.Windows.Forms.ComboBox();
            this.lblCriteriaValue = new System.Windows.Forms.Label();
            this.cmbSolutionCriteria = new System.Windows.Forms.ComboBox();
            this.lblSolutionCriteria = new System.Windows.Forms.Label();
            this.cmbSolutionName = new System.Windows.Forms.ComboBox();
            this.lblSolutionNameSelection = new System.Windows.Forms.Label();
            this.grpSolutions = new System.Windows.Forms.GroupBox();
            this.txtSolutionName = new System.Windows.Forms.TextBox();
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.btnSubmitSolutionName = new System.Windows.Forms.Button();
            this.btnSubmitSolutionCriteria = new System.Windows.Forms.Button();
            this.btnBackToDecisionFrm = new System.Windows.Forms.Button();
            this.btnReturnToCriteriaForm = new System.Windows.Forms.Button();
            this.lstSolutionCriteriaDisplay = new System.Windows.Forms.ListView();
            this.lstSolutionDisplay = new System.Windows.Forms.ListView();
            this.btnUpdateSolutionName = new System.Windows.Forms.Button();
            this.btnDeleteSolutionName = new System.Windows.Forms.Button();
            this.btnUpdateSolutionCriteria = new System.Windows.Forms.Button();
            this.btnDeleteSolutionCriteria = new System.Windows.Forms.Button();
            this.btnCalcBestSolution = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grpSolutionCriteria.SuspendLayout();
            this.grpSolutions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrDecision
            // 
            this.lblCurrDecision.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCurrDecision.Location = new System.Drawing.Point(290, 13);
            this.lblCurrDecision.Name = "lblCurrDecision";
            this.lblCurrDecision.Size = new System.Drawing.Size(100, 23);
            this.lblCurrDecision.TabIndex = 2;
            // 
            // grpSolutionCriteria
            // 
            this.grpSolutionCriteria.Controls.Add(this.cmbCriteriaValue);
            this.grpSolutionCriteria.Controls.Add(this.lblCriteriaValue);
            this.grpSolutionCriteria.Controls.Add(this.cmbSolutionCriteria);
            this.grpSolutionCriteria.Controls.Add(this.lblSolutionCriteria);
            this.grpSolutionCriteria.Controls.Add(this.cmbSolutionName);
            this.grpSolutionCriteria.Controls.Add(this.lblSolutionNameSelection);
            this.grpSolutionCriteria.Location = new System.Drawing.Point(293, 186);
            this.grpSolutionCriteria.Name = "grpSolutionCriteria";
            this.grpSolutionCriteria.Size = new System.Drawing.Size(285, 146);
            this.grpSolutionCriteria.TabIndex = 4;
            this.grpSolutionCriteria.TabStop = false;
            this.grpSolutionCriteria.Text = "Solution Criteria";
            // 
            // cmbCriteriaValue
            // 
            this.cmbCriteriaValue.FormattingEnabled = true;
            this.cmbCriteriaValue.Location = new System.Drawing.Point(108, 104);
            this.cmbCriteriaValue.Name = "cmbCriteriaValue";
            this.cmbCriteriaValue.Size = new System.Drawing.Size(150, 21);
            this.cmbCriteriaValue.TabIndex = 5;
            // 
            // lblCriteriaValue
            // 
            this.lblCriteriaValue.AutoSize = true;
            this.lblCriteriaValue.Location = new System.Drawing.Point(33, 107);
            this.lblCriteriaValue.Name = "lblCriteriaValue";
            this.lblCriteriaValue.Size = new System.Drawing.Size(69, 13);
            this.lblCriteriaValue.TabIndex = 4;
            this.lblCriteriaValue.Text = "Criteria Value";
            // 
            // cmbSolutionCriteria
            // 
            this.cmbSolutionCriteria.FormattingEnabled = true;
            this.cmbSolutionCriteria.Location = new System.Drawing.Point(108, 72);
            this.cmbSolutionCriteria.Name = "cmbSolutionCriteria";
            this.cmbSolutionCriteria.Size = new System.Drawing.Size(150, 21);
            this.cmbSolutionCriteria.TabIndex = 3;
            // 
            // lblSolutionCriteria
            // 
            this.lblSolutionCriteria.AutoSize = true;
            this.lblSolutionCriteria.Location = new System.Drawing.Point(25, 75);
            this.lblSolutionCriteria.Name = "lblSolutionCriteria";
            this.lblSolutionCriteria.Size = new System.Drawing.Size(80, 13);
            this.lblSolutionCriteria.TabIndex = 2;
            this.lblSolutionCriteria.Text = "Solution Criteria";
            // 
            // cmbSolutionName
            // 
            this.cmbSolutionName.FormattingEnabled = true;
            this.cmbSolutionName.Location = new System.Drawing.Point(108, 40);
            this.cmbSolutionName.Name = "cmbSolutionName";
            this.cmbSolutionName.Size = new System.Drawing.Size(150, 21);
            this.cmbSolutionName.TabIndex = 1;
            // 
            // lblSolutionNameSelection
            // 
            this.lblSolutionNameSelection.AutoSize = true;
            this.lblSolutionNameSelection.Location = new System.Drawing.Point(29, 43);
            this.lblSolutionNameSelection.Name = "lblSolutionNameSelection";
            this.lblSolutionNameSelection.Size = new System.Drawing.Size(76, 13);
            this.lblSolutionNameSelection.TabIndex = 0;
            this.lblSolutionNameSelection.Text = "Solution Name";
            // 
            // grpSolutions
            // 
            this.grpSolutions.Controls.Add(this.txtSolutionName);
            this.grpSolutions.Controls.Add(this.lblSolutionName);
            this.grpSolutions.Location = new System.Drawing.Point(293, 39);
            this.grpSolutions.Name = "grpSolutions";
            this.grpSolutions.Size = new System.Drawing.Size(285, 134);
            this.grpSolutions.TabIndex = 3;
            this.grpSolutions.TabStop = false;
            this.grpSolutions.Text = "Solutions";
            // 
            // txtSolutionName
            // 
            this.txtSolutionName.Location = new System.Drawing.Point(108, 51);
            this.txtSolutionName.Name = "txtSolutionName";
            this.txtSolutionName.Size = new System.Drawing.Size(150, 20);
            this.txtSolutionName.TabIndex = 1;
            // 
            // lblSolutionName
            // 
            this.lblSolutionName.AutoSize = true;
            this.lblSolutionName.Location = new System.Drawing.Point(26, 54);
            this.lblSolutionName.Name = "lblSolutionName";
            this.lblSolutionName.Size = new System.Drawing.Size(76, 13);
            this.lblSolutionName.TabIndex = 0;
            this.lblSolutionName.Text = "Solution Name";
            // 
            // btnSubmitSolutionName
            // 
            this.btnSubmitSolutionName.Location = new System.Drawing.Point(293, 339);
            this.btnSubmitSolutionName.Name = "btnSubmitSolutionName";
            this.btnSubmitSolutionName.Size = new System.Drawing.Size(86, 36);
            this.btnSubmitSolutionName.TabIndex = 5;
            this.btnSubmitSolutionName.Text = "Submit Solution Name";
            this.btnSubmitSolutionName.UseVisualStyleBackColor = true;
            this.btnSubmitSolutionName.Click += new System.EventHandler(this.btnSubmitSolutionName_Click);
            // 
            // btnSubmitSolutionCriteria
            // 
            this.btnSubmitSolutionCriteria.Location = new System.Drawing.Point(385, 339);
            this.btnSubmitSolutionCriteria.Name = "btnSubmitSolutionCriteria";
            this.btnSubmitSolutionCriteria.Size = new System.Drawing.Size(89, 36);
            this.btnSubmitSolutionCriteria.TabIndex = 6;
            this.btnSubmitSolutionCriteria.Text = "Submit Solution Criteria";
            this.btnSubmitSolutionCriteria.UseVisualStyleBackColor = true;
            this.btnSubmitSolutionCriteria.Click += new System.EventHandler(this.btnSubmitSolutionCriteria_Click);
            // 
            // btnBackToDecisionFrm
            // 
            this.btnBackToDecisionFrm.Location = new System.Drawing.Point(611, 345);
            this.btnBackToDecisionFrm.Name = "btnBackToDecisionFrm";
            this.btnBackToDecisionFrm.Size = new System.Drawing.Size(111, 40);
            this.btnBackToDecisionFrm.TabIndex = 7;
            this.btnBackToDecisionFrm.Text = "Return to Decision Selection";
            this.btnBackToDecisionFrm.UseVisualStyleBackColor = true;
            this.btnBackToDecisionFrm.Click += new System.EventHandler(this.btnBackToDecisionFrm_Click);
            // 
            // btnReturnToCriteriaForm
            // 
            this.btnReturnToCriteriaForm.Location = new System.Drawing.Point(494, 345);
            this.btnReturnToCriteriaForm.Name = "btnReturnToCriteriaForm";
            this.btnReturnToCriteriaForm.Size = new System.Drawing.Size(111, 40);
            this.btnReturnToCriteriaForm.TabIndex = 8;
            this.btnReturnToCriteriaForm.Text = "Return to Criteria Entry";
            this.btnReturnToCriteriaForm.UseVisualStyleBackColor = true;
            this.btnReturnToCriteriaForm.Click += new System.EventHandler(this.btnReturnToCriteriaForm_Click);
            // 
            // lstSolutionCriteriaDisplay
            // 
            this.lstSolutionCriteriaDisplay.FullRowSelect = true;
            this.lstSolutionCriteriaDisplay.Location = new System.Drawing.Point(13, 245);
            this.lstSolutionCriteriaDisplay.Name = "lstSolutionCriteriaDisplay";
            this.lstSolutionCriteriaDisplay.Size = new System.Drawing.Size(261, 214);
            this.lstSolutionCriteriaDisplay.TabIndex = 9;
            this.lstSolutionCriteriaDisplay.UseCompatibleStateImageBehavior = false;
            this.lstSolutionCriteriaDisplay.View = System.Windows.Forms.View.Details;
            // 
            // lstSolutionDisplay
            // 
            this.lstSolutionDisplay.FullRowSelect = true;
            this.lstSolutionDisplay.Location = new System.Drawing.Point(13, 12);
            this.lstSolutionDisplay.Name = "lstSolutionDisplay";
            this.lstSolutionDisplay.Size = new System.Drawing.Size(261, 227);
            this.lstSolutionDisplay.TabIndex = 10;
            this.lstSolutionDisplay.UseCompatibleStateImageBehavior = false;
            this.lstSolutionDisplay.View = System.Windows.Forms.View.Details;
            // 
            // btnUpdateSolutionName
            // 
            this.btnUpdateSolutionName.Location = new System.Drawing.Point(293, 381);
            this.btnUpdateSolutionName.Name = "btnUpdateSolutionName";
            this.btnUpdateSolutionName.Size = new System.Drawing.Size(86, 36);
            this.btnUpdateSolutionName.TabIndex = 11;
            this.btnUpdateSolutionName.Text = "Update Solution Name";
            this.btnUpdateSolutionName.UseVisualStyleBackColor = true;
            this.btnUpdateSolutionName.Click += new System.EventHandler(this.btnUpdateSolutionName_Click);
            // 
            // btnDeleteSolutionName
            // 
            this.btnDeleteSolutionName.Location = new System.Drawing.Point(293, 423);
            this.btnDeleteSolutionName.Name = "btnDeleteSolutionName";
            this.btnDeleteSolutionName.Size = new System.Drawing.Size(86, 36);
            this.btnDeleteSolutionName.TabIndex = 12;
            this.btnDeleteSolutionName.Text = "Delete Solution Name";
            this.btnDeleteSolutionName.UseVisualStyleBackColor = true;
            this.btnDeleteSolutionName.Click += new System.EventHandler(this.btnDeleteSolutionName_Click);
            // 
            // btnUpdateSolutionCriteria
            // 
            this.btnUpdateSolutionCriteria.Location = new System.Drawing.Point(385, 381);
            this.btnUpdateSolutionCriteria.Name = "btnUpdateSolutionCriteria";
            this.btnUpdateSolutionCriteria.Size = new System.Drawing.Size(89, 36);
            this.btnUpdateSolutionCriteria.TabIndex = 13;
            this.btnUpdateSolutionCriteria.Text = "Update Solution Criteria";
            this.btnUpdateSolutionCriteria.UseVisualStyleBackColor = true;
            this.btnUpdateSolutionCriteria.Click += new System.EventHandler(this.btnUpdateSolutionCriteria_Click);
            // 
            // btnDeleteSolutionCriteria
            // 
            this.btnDeleteSolutionCriteria.Location = new System.Drawing.Point(385, 423);
            this.btnDeleteSolutionCriteria.Name = "btnDeleteSolutionCriteria";
            this.btnDeleteSolutionCriteria.Size = new System.Drawing.Size(89, 36);
            this.btnDeleteSolutionCriteria.TabIndex = 14;
            this.btnDeleteSolutionCriteria.Text = "Delete Solution Criteria";
            this.btnDeleteSolutionCriteria.UseVisualStyleBackColor = true;
            this.btnDeleteSolutionCriteria.Click += new System.EventHandler(this.btnDeleteSolutionCriteria_Click);
            // 
            // btnCalcBestSolution
            // 
            this.btnCalcBestSolution.Location = new System.Drawing.Point(494, 391);
            this.btnCalcBestSolution.Name = "btnCalcBestSolution";
            this.btnCalcBestSolution.Size = new System.Drawing.Size(111, 36);
            this.btnCalcBestSolution.TabIndex = 15;
            this.btnCalcBestSolution.Text = "Calculate Best Solution";
            this.btnCalcBestSolution.UseVisualStyleBackColor = true;
            this.btnCalcBestSolution.Click += new System.EventHandler(this.btnCalcBestSolution_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(584, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(138, 293);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 471);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCalcBestSolution);
            this.Controls.Add(this.btnDeleteSolutionCriteria);
            this.Controls.Add(this.btnUpdateSolutionCriteria);
            this.Controls.Add(this.btnDeleteSolutionName);
            this.Controls.Add(this.btnUpdateSolutionName);
            this.Controls.Add(this.lstSolutionDisplay);
            this.Controls.Add(this.lstSolutionCriteriaDisplay);
            this.Controls.Add(this.btnReturnToCriteriaForm);
            this.Controls.Add(this.btnBackToDecisionFrm);
            this.Controls.Add(this.btnSubmitSolutionCriteria);
            this.Controls.Add(this.btnSubmitSolutionName);
            this.Controls.Add(this.grpSolutionCriteria);
            this.Controls.Add(this.grpSolutions);
            this.Controls.Add(this.lblCurrDecision);
            this.Name = "frmSolution";
            this.Text = "Solution Entry";
            this.Load += new System.EventHandler(this.frmSolution_Load);
            this.grpSolutionCriteria.ResumeLayout(false);
            this.grpSolutionCriteria.PerformLayout();
            this.grpSolutions.ResumeLayout(false);
            this.grpSolutions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCurrDecision;
        private System.Windows.Forms.GroupBox grpSolutionCriteria;
        private System.Windows.Forms.ComboBox cmbSolutionCriteria;
        private System.Windows.Forms.Label lblSolutionCriteria;
        private System.Windows.Forms.ComboBox cmbSolutionName;
        private System.Windows.Forms.Label lblSolutionNameSelection;
        private System.Windows.Forms.GroupBox grpSolutions;
        private System.Windows.Forms.TextBox txtSolutionName;
        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.Label lblCriteriaValue;
        private System.Windows.Forms.Button btnSubmitSolutionName;
        private System.Windows.Forms.Button btnSubmitSolutionCriteria;
        private System.Windows.Forms.Button btnBackToDecisionFrm;
        private System.Windows.Forms.Button btnReturnToCriteriaForm;
        private System.Windows.Forms.ListView lstSolutionCriteriaDisplay;
        private System.Windows.Forms.ListView lstSolutionDisplay;
        private System.Windows.Forms.ComboBox cmbCriteriaValue;
        private System.Windows.Forms.Button btnUpdateSolutionName;
        private System.Windows.Forms.Button btnDeleteSolutionName;
        private System.Windows.Forms.Button btnUpdateSolutionCriteria;
        private System.Windows.Forms.Button btnDeleteSolutionCriteria;
        private System.Windows.Forms.Button btnCalcBestSolution;
        private System.Windows.Forms.ListView listView1;
    }
}