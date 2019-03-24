namespace FYP_DAR_Tool
{
    partial class frmDecision
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
            this.btnNewDecision = new System.Windows.Forms.Button();
            this.lstDecisionDisplay = new System.Windows.Forms.ListBox();
            this.txtDecisionName = new System.Windows.Forms.TextBox();
            this.lblDecisionName = new System.Windows.Forms.Label();
            this.btnLoadDecision = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewDecision
            // 
            this.btnNewDecision.Location = new System.Drawing.Point(78, 97);
            this.btnNewDecision.Name = "btnNewDecision";
            this.btnNewDecision.Size = new System.Drawing.Size(75, 23);
            this.btnNewDecision.TabIndex = 0;
            this.btnNewDecision.Text = "New";
            this.btnNewDecision.UseVisualStyleBackColor = true;
            this.btnNewDecision.Click += new System.EventHandler(this.btnNewDecision_Click);
            // 
            // lstDecisionDisplay
            // 
            this.lstDecisionDisplay.FormattingEnabled = true;
            this.lstDecisionDisplay.Location = new System.Drawing.Point(66, 167);
            this.lstDecisionDisplay.Name = "lstDecisionDisplay";
            this.lstDecisionDisplay.Size = new System.Drawing.Size(197, 95);
            this.lstDecisionDisplay.TabIndex = 3;
            // 
            // txtDecisionName
            // 
            this.txtDecisionName.Location = new System.Drawing.Point(142, 62);
            this.txtDecisionName.Name = "txtDecisionName";
            this.txtDecisionName.Size = new System.Drawing.Size(121, 20);
            this.txtDecisionName.TabIndex = 4;
            // 
            // lblDecisionName
            // 
            this.lblDecisionName.AutoSize = true;
            this.lblDecisionName.Location = new System.Drawing.Point(63, 65);
            this.lblDecisionName.Name = "lblDecisionName";
            this.lblDecisionName.Size = new System.Drawing.Size(73, 13);
            this.lblDecisionName.TabIndex = 5;
            this.lblDecisionName.Text = "New Decision";
            // 
            // btnLoadDecision
            // 
            this.btnLoadDecision.Location = new System.Drawing.Point(175, 97);
            this.btnLoadDecision.Name = "btnLoadDecision";
            this.btnLoadDecision.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDecision.TabIndex = 6;
            this.btnLoadDecision.Text = "Load";
            this.btnLoadDecision.UseVisualStyleBackColor = true;
            this.btnLoadDecision.Click += new System.EventHandler(this.btnLoadDecision_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(78, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 323);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLoadDecision);
            this.Controls.Add(this.lblDecisionName);
            this.Controls.Add(this.txtDecisionName);
            this.Controls.Add(this.lstDecisionDisplay);
            this.Controls.Add(this.btnNewDecision);
            this.Name = "frmDecision";
            this.Text = "frmDecision";
            this.Load += new System.EventHandler(this.frmDecision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewDecision;
        private System.Windows.Forms.ListBox lstDecisionDisplay;
        private System.Windows.Forms.TextBox txtDecisionName;
        private System.Windows.Forms.Label lblDecisionName;
        private System.Windows.Forms.Button btnLoadDecision;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}