namespace FYP_DAR_Tool
{
    partial class frmCriteria
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
            this.lblMainCriWeight = new System.Windows.Forms.Label();
            this.txtMainCriWeight = new System.Windows.Forms.TextBox();
            this.grpMainCriteria = new System.Windows.Forms.GroupBox();
            this.txtMainCriName = new System.Windows.Forms.TextBox();
            this.lblMainCriName = new System.Windows.Forms.Label();
            this.grpSubCriteria = new System.Windows.Forms.GroupBox();
            this.cmbMainCriteria = new System.Windows.Forms.ComboBox();
            this.txtSubCriName = new System.Windows.Forms.TextBox();
            this.lblSubCriName = new System.Windows.Forms.Label();
            this.lblSubCriWeight = new System.Windows.Forms.Label();
            this.lblRltdMainCriName = new System.Windows.Forms.Label();
            this.txtSubCriWeight = new System.Windows.Forms.TextBox();
            this.btnSubmitMainCriteria = new System.Windows.Forms.Button();
            this.btnBackToDecisionFrm = new System.Windows.Forms.Button();
            this.lblCurrDecision = new System.Windows.Forms.Label();
            this.btnSubmitSubCriteria = new System.Windows.Forms.Button();
            this.btnToSolutionForm = new System.Windows.Forms.Button();
            this.lstMainCriDisplay = new System.Windows.Forms.ListView();
            this.lstSubCriDisplay = new System.Windows.Forms.ListView();
            this.lblCurrSelection = new System.Windows.Forms.Label();
            this.btnUpdateMainCriteria = new System.Windows.Forms.Button();
            this.btnUpdateSubCriteria = new System.Windows.Forms.Button();
            this.btnDeleteMainCriteria = new System.Windows.Forms.Button();
            this.btnDeleteSubCriteria = new System.Windows.Forms.Button();
            this.grpMainCriteria.SuspendLayout();
            this.grpSubCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainCriWeight
            // 
            this.lblMainCriWeight.AutoSize = true;
            this.lblMainCriWeight.Location = new System.Drawing.Point(65, 74);
            this.lblMainCriWeight.Name = "lblMainCriWeight";
            this.lblMainCriWeight.Size = new System.Drawing.Size(90, 13);
            this.lblMainCriWeight.TabIndex = 1;
            this.lblMainCriWeight.Text = "Criteria Weighting";
            // 
            // txtMainCriWeight
            // 
            this.txtMainCriWeight.Location = new System.Drawing.Point(161, 71);
            this.txtMainCriWeight.Name = "txtMainCriWeight";
            this.txtMainCriWeight.Size = new System.Drawing.Size(182, 20);
            this.txtMainCriWeight.TabIndex = 2;
            // 
            // grpMainCriteria
            // 
            this.grpMainCriteria.Controls.Add(this.txtMainCriName);
            this.grpMainCriteria.Controls.Add(this.lblMainCriName);
            this.grpMainCriteria.Controls.Add(this.txtMainCriWeight);
            this.grpMainCriteria.Controls.Add(this.lblMainCriWeight);
            this.grpMainCriteria.Location = new System.Drawing.Point(401, 80);
            this.grpMainCriteria.Name = "grpMainCriteria";
            this.grpMainCriteria.Size = new System.Drawing.Size(427, 129);
            this.grpMainCriteria.TabIndex = 3;
            this.grpMainCriteria.TabStop = false;
            this.grpMainCriteria.Text = "Main Criteria";
            // 
            // txtMainCriName
            // 
            this.txtMainCriName.Location = new System.Drawing.Point(161, 44);
            this.txtMainCriName.Name = "txtMainCriName";
            this.txtMainCriName.Size = new System.Drawing.Size(182, 20);
            this.txtMainCriName.TabIndex = 4;
            // 
            // lblMainCriName
            // 
            this.lblMainCriName.AutoSize = true;
            this.lblMainCriName.Location = new System.Drawing.Point(65, 47);
            this.lblMainCriName.Name = "lblMainCriName";
            this.lblMainCriName.Size = new System.Drawing.Size(70, 13);
            this.lblMainCriName.TabIndex = 3;
            this.lblMainCriName.Text = "Criteria Name";
            // 
            // grpSubCriteria
            // 
            this.grpSubCriteria.Controls.Add(this.cmbMainCriteria);
            this.grpSubCriteria.Controls.Add(this.txtSubCriName);
            this.grpSubCriteria.Controls.Add(this.lblSubCriName);
            this.grpSubCriteria.Controls.Add(this.lblSubCriWeight);
            this.grpSubCriteria.Controls.Add(this.lblRltdMainCriName);
            this.grpSubCriteria.Controls.Add(this.txtSubCriWeight);
            this.grpSubCriteria.Location = new System.Drawing.Point(401, 215);
            this.grpSubCriteria.Name = "grpSubCriteria";
            this.grpSubCriteria.Size = new System.Drawing.Size(427, 146);
            this.grpSubCriteria.TabIndex = 4;
            this.grpSubCriteria.TabStop = false;
            this.grpSubCriteria.Text = "Sub Criteria";
            // 
            // cmbMainCriteria
            // 
            this.cmbMainCriteria.FormattingEnabled = true;
            this.cmbMainCriteria.Location = new System.Drawing.Point(161, 41);
            this.cmbMainCriteria.Name = "cmbMainCriteria";
            this.cmbMainCriteria.Size = new System.Drawing.Size(182, 21);
            this.cmbMainCriteria.TabIndex = 11;
            // 
            // txtSubCriName
            // 
            this.txtSubCriName.Location = new System.Drawing.Point(161, 69);
            this.txtSubCriName.Name = "txtSubCriName";
            this.txtSubCriName.Size = new System.Drawing.Size(182, 20);
            this.txtSubCriName.TabIndex = 10;
            // 
            // lblSubCriName
            // 
            this.lblSubCriName.AutoSize = true;
            this.lblSubCriName.Location = new System.Drawing.Point(65, 72);
            this.lblSubCriName.Name = "lblSubCriName";
            this.lblSubCriName.Size = new System.Drawing.Size(92, 13);
            this.lblSubCriName.TabIndex = 9;
            this.lblSubCriName.Text = "Sub Criteria Name";
            // 
            // lblSubCriWeight
            // 
            this.lblSubCriWeight.AutoSize = true;
            this.lblSubCriWeight.Location = new System.Drawing.Point(65, 101);
            this.lblSubCriWeight.Name = "lblSubCriWeight";
            this.lblSubCriWeight.Size = new System.Drawing.Size(90, 13);
            this.lblSubCriWeight.TabIndex = 5;
            this.lblSubCriWeight.Text = "Criteria Weighting";
            // 
            // lblRltdMainCriName
            // 
            this.lblRltdMainCriName.AutoSize = true;
            this.lblRltdMainCriName.Location = new System.Drawing.Point(65, 44);
            this.lblRltdMainCriName.Name = "lblRltdMainCriName";
            this.lblRltdMainCriName.Size = new System.Drawing.Size(96, 13);
            this.lblRltdMainCriName.TabIndex = 7;
            this.lblRltdMainCriName.Text = "Main Criteria Name";
            // 
            // txtSubCriWeight
            // 
            this.txtSubCriWeight.Location = new System.Drawing.Point(161, 98);
            this.txtSubCriWeight.Name = "txtSubCriWeight";
            this.txtSubCriWeight.Size = new System.Drawing.Size(182, 20);
            this.txtSubCriWeight.TabIndex = 6;
            // 
            // btnSubmitMainCriteria
            // 
            this.btnSubmitMainCriteria.Location = new System.Drawing.Point(401, 367);
            this.btnSubmitMainCriteria.Name = "btnSubmitMainCriteria";
            this.btnSubmitMainCriteria.Size = new System.Drawing.Size(100, 34);
            this.btnSubmitMainCriteria.TabIndex = 5;
            this.btnSubmitMainCriteria.Text = "Submit Main Criteria";
            this.btnSubmitMainCriteria.UseVisualStyleBackColor = true;
            this.btnSubmitMainCriteria.Click += new System.EventHandler(this.btnSubmitMainCriteria_Click);
            // 
            // btnBackToDecisionFrm
            // 
            this.btnBackToDecisionFrm.Location = new System.Drawing.Point(727, 393);
            this.btnBackToDecisionFrm.Name = "btnBackToDecisionFrm";
            this.btnBackToDecisionFrm.Size = new System.Drawing.Size(111, 40);
            this.btnBackToDecisionFrm.TabIndex = 6;
            this.btnBackToDecisionFrm.Text = "Return to Decision Selection";
            this.btnBackToDecisionFrm.UseVisualStyleBackColor = true;
            this.btnBackToDecisionFrm.Click += new System.EventHandler(this.btnBackToDecisionFrm_Click);
            // 
            // lblCurrDecision
            // 
            this.lblCurrDecision.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCurrDecision.Location = new System.Drawing.Point(401, 28);
            this.lblCurrDecision.Name = "lblCurrDecision";
            this.lblCurrDecision.Size = new System.Drawing.Size(100, 23);
            this.lblCurrDecision.TabIndex = 7;
            // 
            // btnSubmitSubCriteria
            // 
            this.btnSubmitSubCriteria.Location = new System.Drawing.Point(507, 367);
            this.btnSubmitSubCriteria.Name = "btnSubmitSubCriteria";
            this.btnSubmitSubCriteria.Size = new System.Drawing.Size(100, 34);
            this.btnSubmitSubCriteria.TabIndex = 8;
            this.btnSubmitSubCriteria.Text = "Submit Sub Criteria";
            this.btnSubmitSubCriteria.UseVisualStyleBackColor = true;
            this.btnSubmitSubCriteria.Click += new System.EventHandler(this.btnSubmitSubCriteria_Click);
            // 
            // btnToSolutionForm
            // 
            this.btnToSolutionForm.Location = new System.Drawing.Point(632, 393);
            this.btnToSolutionForm.Name = "btnToSolutionForm";
            this.btnToSolutionForm.Size = new System.Drawing.Size(88, 40);
            this.btnToSolutionForm.TabIndex = 10;
            this.btnToSolutionForm.Text = "Go To Solution Entry";
            this.btnToSolutionForm.UseVisualStyleBackColor = true;
            this.btnToSolutionForm.Click += new System.EventHandler(this.btnToSolutionForm_Click);
            // 
            // lstMainCriDisplay
            // 
            this.lstMainCriDisplay.FullRowSelect = true;
            this.lstMainCriDisplay.Location = new System.Drawing.Point(13, 13);
            this.lstMainCriDisplay.Name = "lstMainCriDisplay";
            this.lstMainCriDisplay.Size = new System.Drawing.Size(325, 230);
            this.lstMainCriDisplay.TabIndex = 11;
            this.lstMainCriDisplay.UseCompatibleStateImageBehavior = false;
            this.lstMainCriDisplay.View = System.Windows.Forms.View.Details;
            // 
            // lstSubCriDisplay
            // 
            this.lstSubCriDisplay.FullRowSelect = true;
            this.lstSubCriDisplay.Location = new System.Drawing.Point(13, 249);
            this.lstSubCriDisplay.Name = "lstSubCriDisplay";
            this.lstSubCriDisplay.Size = new System.Drawing.Size(325, 230);
            this.lstSubCriDisplay.TabIndex = 12;
            this.lstSubCriDisplay.UseCompatibleStateImageBehavior = false;
            this.lstSubCriDisplay.View = System.Windows.Forms.View.Details;
            // 
            // lblCurrSelection
            // 
            this.lblCurrSelection.Location = new System.Drawing.Point(534, 28);
            this.lblCurrSelection.Name = "lblCurrSelection";
            this.lblCurrSelection.Size = new System.Drawing.Size(100, 23);
            this.lblCurrSelection.TabIndex = 13;
            // 
            // btnUpdateMainCriteria
            // 
            this.btnUpdateMainCriteria.Location = new System.Drawing.Point(401, 407);
            this.btnUpdateMainCriteria.Name = "btnUpdateMainCriteria";
            this.btnUpdateMainCriteria.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateMainCriteria.TabIndex = 14;
            this.btnUpdateMainCriteria.Text = "Update Main Criteria";
            this.btnUpdateMainCriteria.UseVisualStyleBackColor = true;
            this.btnUpdateMainCriteria.Click += new System.EventHandler(this.btnUpdateMainCriteria_Click);
            // 
            // btnUpdateSubCriteria
            // 
            this.btnUpdateSubCriteria.Location = new System.Drawing.Point(507, 407);
            this.btnUpdateSubCriteria.Name = "btnUpdateSubCriteria";
            this.btnUpdateSubCriteria.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateSubCriteria.TabIndex = 15;
            this.btnUpdateSubCriteria.Text = "Update Sub Criteria";
            this.btnUpdateSubCriteria.UseVisualStyleBackColor = true;
            this.btnUpdateSubCriteria.Click += new System.EventHandler(this.btnUpdateSubCriteria_Click);
            // 
            // btnDeleteMainCriteria
            // 
            this.btnDeleteMainCriteria.Location = new System.Drawing.Point(401, 447);
            this.btnDeleteMainCriteria.Name = "btnDeleteMainCriteria";
            this.btnDeleteMainCriteria.Size = new System.Drawing.Size(100, 34);
            this.btnDeleteMainCriteria.TabIndex = 16;
            this.btnDeleteMainCriteria.Text = "Delete Main Criteria";
            this.btnDeleteMainCriteria.UseVisualStyleBackColor = true;
            this.btnDeleteMainCriteria.Click += new System.EventHandler(this.btnDeleteMainCriteria_Click);
            // 
            // btnDeleteSubCriteria
            // 
            this.btnDeleteSubCriteria.Location = new System.Drawing.Point(507, 447);
            this.btnDeleteSubCriteria.Name = "btnDeleteSubCriteria";
            this.btnDeleteSubCriteria.Size = new System.Drawing.Size(100, 34);
            this.btnDeleteSubCriteria.TabIndex = 17;
            this.btnDeleteSubCriteria.Text = "Delete Sub Criteria";
            this.btnDeleteSubCriteria.UseVisualStyleBackColor = true;
            this.btnDeleteSubCriteria.Click += new System.EventHandler(this.btnDeleteSubCriteria_Click);
            // 
            // frmCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 493);
            this.Controls.Add(this.btnDeleteSubCriteria);
            this.Controls.Add(this.btnDeleteMainCriteria);
            this.Controls.Add(this.btnUpdateSubCriteria);
            this.Controls.Add(this.btnUpdateMainCriteria);
            this.Controls.Add(this.lblCurrSelection);
            this.Controls.Add(this.lstSubCriDisplay);
            this.Controls.Add(this.lstMainCriDisplay);
            this.Controls.Add(this.btnToSolutionForm);
            this.Controls.Add(this.btnSubmitSubCriteria);
            this.Controls.Add(this.lblCurrDecision);
            this.Controls.Add(this.btnBackToDecisionFrm);
            this.Controls.Add(this.btnSubmitMainCriteria);
            this.Controls.Add(this.grpSubCriteria);
            this.Controls.Add(this.grpMainCriteria);
            this.Name = "frmCriteria";
            this.Text = "Criteria Entry";
            this.Load += new System.EventHandler(this.frmCriteria_Load);
            this.grpMainCriteria.ResumeLayout(false);
            this.grpMainCriteria.PerformLayout();
            this.grpSubCriteria.ResumeLayout(false);
            this.grpSubCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMainCriWeight;
        private System.Windows.Forms.TextBox txtMainCriWeight;
        private System.Windows.Forms.GroupBox grpMainCriteria;
        private System.Windows.Forms.GroupBox grpSubCriteria;
        private System.Windows.Forms.TextBox txtMainCriName;
        private System.Windows.Forms.Label lblMainCriName;
        private System.Windows.Forms.TextBox txtSubCriName;
        private System.Windows.Forms.Label lblSubCriName;
        private System.Windows.Forms.Label lblSubCriWeight;
        private System.Windows.Forms.Label lblRltdMainCriName;
        private System.Windows.Forms.TextBox txtSubCriWeight;
        private System.Windows.Forms.Button btnSubmitMainCriteria;
        private System.Windows.Forms.Button btnBackToDecisionFrm;
        private System.Windows.Forms.Label lblCurrDecision;
        private System.Windows.Forms.ComboBox cmbMainCriteria;
        private System.Windows.Forms.Button btnSubmitSubCriteria;
        private System.Windows.Forms.Button btnToSolutionForm;
        private System.Windows.Forms.ListView lstMainCriDisplay;
        private System.Windows.Forms.ListView lstSubCriDisplay;
        private System.Windows.Forms.Label lblCurrSelection;
        private System.Windows.Forms.Button btnUpdateMainCriteria;
        private System.Windows.Forms.Button btnUpdateSubCriteria;
        private System.Windows.Forms.Button btnDeleteMainCriteria;
        private System.Windows.Forms.Button btnDeleteSubCriteria;
    }
}

