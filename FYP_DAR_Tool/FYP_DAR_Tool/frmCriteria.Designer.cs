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
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblMainCriWeight = new System.Windows.Forms.Label();
            this.txtMainCriWeight = new System.Windows.Forms.TextBox();
            this.grpMainCriteria = new System.Windows.Forms.GroupBox();
            this.txtMainCriName = new System.Windows.Forms.TextBox();
            this.lblMainCriName = new System.Windows.Forms.Label();
            this.grpSubCriteria = new System.Windows.Forms.GroupBox();
            this.txtSubCriName = new System.Windows.Forms.TextBox();
            this.lblSubCriName = new System.Windows.Forms.Label();
            this.lblSubCriWeight = new System.Windows.Forms.Label();
            this.lblRltdMainCriName = new System.Windows.Forms.Label();
            this.txtSubCriWeight = new System.Windows.Forms.TextBox();
            this.btnSubmitMainCriteria = new System.Windows.Forms.Button();
            this.btnBackToDecisionFrm = new System.Windows.Forms.Button();
            this.lblCurrDecision = new System.Windows.Forms.Label();
            this.cmbMainCriteria = new System.Windows.Forms.ComboBox();
            this.grpMainCriteria.SuspendLayout();
            this.grpSubCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(13, 13);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(325, 394);
            this.lstDisplay.TabIndex = 0;
            // 
            // lblMainCriWeight
            // 
            this.lblMainCriWeight.AutoSize = true;
            this.lblMainCriWeight.Location = new System.Drawing.Point(65, 50);
            this.lblMainCriWeight.Name = "lblMainCriWeight";
            this.lblMainCriWeight.Size = new System.Drawing.Size(90, 13);
            this.lblMainCriWeight.TabIndex = 1;
            this.lblMainCriWeight.Text = "Criteria Weighting";
            // 
            // txtMainCriWeight
            // 
            this.txtMainCriWeight.Location = new System.Drawing.Point(161, 47);
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
            this.txtMainCriName.Location = new System.Drawing.Point(161, 77);
            this.txtMainCriName.Name = "txtMainCriName";
            this.txtMainCriName.Size = new System.Drawing.Size(182, 20);
            this.txtMainCriName.TabIndex = 4;
            // 
            // lblMainCriName
            // 
            this.lblMainCriName.AutoSize = true;
            this.lblMainCriName.Location = new System.Drawing.Point(65, 80);
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
            // txtSubCriName
            // 
            this.txtSubCriName.Location = new System.Drawing.Point(161, 94);
            this.txtSubCriName.Name = "txtSubCriName";
            this.txtSubCriName.Size = new System.Drawing.Size(182, 20);
            this.txtSubCriName.TabIndex = 10;
            // 
            // lblSubCriName
            // 
            this.lblSubCriName.AutoSize = true;
            this.lblSubCriName.Location = new System.Drawing.Point(65, 97);
            this.lblSubCriName.Name = "lblSubCriName";
            this.lblSubCriName.Size = new System.Drawing.Size(92, 13);
            this.lblSubCriName.TabIndex = 9;
            this.lblSubCriName.Text = "Sub Criteria Name";
            // 
            // lblSubCriWeight
            // 
            this.lblSubCriWeight.AutoSize = true;
            this.lblSubCriWeight.Location = new System.Drawing.Point(65, 71);
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
            this.txtSubCriWeight.Location = new System.Drawing.Point(161, 68);
            this.txtSubCriWeight.Name = "txtSubCriWeight";
            this.txtSubCriWeight.Size = new System.Drawing.Size(182, 20);
            this.txtSubCriWeight.TabIndex = 6;
            // 
            // btnSubmitMainCriteria
            // 
            this.btnSubmitMainCriteria.Location = new System.Drawing.Point(401, 383);
            this.btnSubmitMainCriteria.Name = "btnSubmitMainCriteria";
            this.btnSubmitMainCriteria.Size = new System.Drawing.Size(93, 23);
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
            // cmbMainCriteria
            // 
            this.cmbMainCriteria.FormattingEnabled = true;
            this.cmbMainCriteria.Location = new System.Drawing.Point(161, 41);
            this.cmbMainCriteria.Name = "cmbMainCriteria";
            this.cmbMainCriteria.Size = new System.Drawing.Size(182, 21);
            this.cmbMainCriteria.TabIndex = 11;
            // 
            // frmCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 445);
            this.Controls.Add(this.lblCurrDecision);
            this.Controls.Add(this.btnBackToDecisionFrm);
            this.Controls.Add(this.btnSubmitMainCriteria);
            this.Controls.Add(this.grpSubCriteria);
            this.Controls.Add(this.grpMainCriteria);
            this.Controls.Add(this.lstDisplay);
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

        private System.Windows.Forms.ListBox lstDisplay;
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
    }
}

