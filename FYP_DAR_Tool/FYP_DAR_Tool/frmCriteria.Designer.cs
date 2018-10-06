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
            this.grpSubCriteria = new System.Windows.Forms.GroupBox();
            this.txtMainCriName = new System.Windows.Forms.TextBox();
            this.lblMainCriName = new System.Windows.Forms.Label();
            this.txtRltdMainCriName = new System.Windows.Forms.TextBox();
            this.lblRltdMainCriName = new System.Windows.Forms.Label();
            this.txtSubCriWeight = new System.Windows.Forms.TextBox();
            this.lblSubCriWeight = new System.Windows.Forms.Label();
            this.txtSubCriName = new System.Windows.Forms.TextBox();
            this.lblSubCriName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.grpMainCriteria.Location = new System.Drawing.Point(401, 13);
            this.grpMainCriteria.Name = "grpMainCriteria";
            this.grpMainCriteria.Size = new System.Drawing.Size(427, 129);
            this.grpMainCriteria.TabIndex = 3;
            this.grpMainCriteria.TabStop = false;
            this.grpMainCriteria.Text = "Main Criteria";
            // 
            // grpSubCriteria
            // 
            this.grpSubCriteria.Controls.Add(this.txtSubCriName);
            this.grpSubCriteria.Controls.Add(this.lblSubCriName);
            this.grpSubCriteria.Controls.Add(this.txtRltdMainCriName);
            this.grpSubCriteria.Controls.Add(this.lblSubCriWeight);
            this.grpSubCriteria.Controls.Add(this.lblRltdMainCriName);
            this.grpSubCriteria.Controls.Add(this.txtSubCriWeight);
            this.grpSubCriteria.Location = new System.Drawing.Point(401, 148);
            this.grpSubCriteria.Name = "grpSubCriteria";
            this.grpSubCriteria.Size = new System.Drawing.Size(427, 146);
            this.grpSubCriteria.TabIndex = 4;
            this.grpSubCriteria.TabStop = false;
            this.grpSubCriteria.Text = "Sub Criteria";
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
            // txtRltdMainCriName
            // 
            this.txtRltdMainCriName.Location = new System.Drawing.Point(161, 63);
            this.txtRltdMainCriName.Name = "txtRltdMainCriName";
            this.txtRltdMainCriName.Size = new System.Drawing.Size(182, 20);
            this.txtRltdMainCriName.TabIndex = 8;
            // 
            // lblRltdMainCriName
            // 
            this.lblRltdMainCriName.AutoSize = true;
            this.lblRltdMainCriName.Location = new System.Drawing.Point(65, 66);
            this.lblRltdMainCriName.Name = "lblRltdMainCriName";
            this.lblRltdMainCriName.Size = new System.Drawing.Size(96, 13);
            this.lblRltdMainCriName.TabIndex = 7;
            this.lblRltdMainCriName.Text = "Main Criteria Name";
            // 
            // txtSubCriWeight
            // 
            this.txtSubCriWeight.Location = new System.Drawing.Point(161, 33);
            this.txtSubCriWeight.Name = "txtSubCriWeight";
            this.txtSubCriWeight.Size = new System.Drawing.Size(182, 20);
            this.txtSubCriWeight.TabIndex = 6;
            // 
            // lblSubCriWeight
            // 
            this.lblSubCriWeight.AutoSize = true;
            this.lblSubCriWeight.Location = new System.Drawing.Point(65, 36);
            this.lblSubCriWeight.Name = "lblSubCriWeight";
            this.lblSubCriWeight.Size = new System.Drawing.Size(90, 13);
            this.lblSubCriWeight.TabIndex = 5;
            this.lblSubCriWeight.Text = "Criteria Weighting";
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(401, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Criteria";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 445);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpSubCriteria);
            this.Controls.Add(this.grpMainCriteria);
            this.Controls.Add(this.lstDisplay);
            this.Name = "frmCriteria";
            this.Text = "Criteria Entry";
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
        private System.Windows.Forms.TextBox txtRltdMainCriName;
        private System.Windows.Forms.Label lblSubCriWeight;
        private System.Windows.Forms.Label lblRltdMainCriName;
        private System.Windows.Forms.TextBox txtSubCriWeight;
        private System.Windows.Forms.Button btnSubmit;
    }
}

