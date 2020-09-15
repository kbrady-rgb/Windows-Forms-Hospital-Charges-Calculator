namespace HospitalChargesBrady
{
    partial class HospitalChargesForm
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
            this.groupBoxCharges = new System.Windows.Forms.GroupBox();
            this.txtRehab = new System.Windows.Forms.TextBox();
            this.txtLabs = new System.Windows.Forms.TextBox();
            this.txtSurg = new System.Windows.Forms.TextBox();
            this.txtMeds = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblRehab = new System.Windows.Forms.Label();
            this.lblLabs = new System.Windows.Forms.Label();
            this.lblSurg = new System.Windows.Forms.Label();
            this.lblMeds = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOhNo = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.groupBoxCharges.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCharges
            // 
            this.groupBoxCharges.Controls.Add(this.txtRehab);
            this.groupBoxCharges.Controls.Add(this.txtLabs);
            this.groupBoxCharges.Controls.Add(this.txtSurg);
            this.groupBoxCharges.Controls.Add(this.txtMeds);
            this.groupBoxCharges.Controls.Add(this.txtDays);
            this.groupBoxCharges.Controls.Add(this.lblRehab);
            this.groupBoxCharges.Controls.Add(this.lblLabs);
            this.groupBoxCharges.Controls.Add(this.lblSurg);
            this.groupBoxCharges.Controls.Add(this.lblMeds);
            this.groupBoxCharges.Controls.Add(this.lblDays);
            this.groupBoxCharges.ForeColor = System.Drawing.Color.Aqua;
            this.groupBoxCharges.Location = new System.Drawing.Point(25, 86);
            this.groupBoxCharges.Name = "groupBoxCharges";
            this.groupBoxCharges.Size = new System.Drawing.Size(447, 263);
            this.groupBoxCharges.TabIndex = 0;
            this.groupBoxCharges.TabStop = false;
            this.groupBoxCharges.Text = "Hospital Charges";
            // 
            // txtRehab
            // 
            this.txtRehab.BackColor = System.Drawing.Color.Aqua;
            this.txtRehab.Location = new System.Drawing.Point(280, 212);
            this.txtRehab.Name = "txtRehab";
            this.txtRehab.Size = new System.Drawing.Size(100, 22);
            this.txtRehab.TabIndex = 9;
            // 
            // txtLabs
            // 
            this.txtLabs.BackColor = System.Drawing.Color.Aqua;
            this.txtLabs.Location = new System.Drawing.Point(280, 170);
            this.txtLabs.Name = "txtLabs";
            this.txtLabs.Size = new System.Drawing.Size(100, 22);
            this.txtLabs.TabIndex = 8;
            // 
            // txtSurg
            // 
            this.txtSurg.BackColor = System.Drawing.Color.Aqua;
            this.txtSurg.Location = new System.Drawing.Point(280, 128);
            this.txtSurg.Name = "txtSurg";
            this.txtSurg.Size = new System.Drawing.Size(100, 22);
            this.txtSurg.TabIndex = 7;
            // 
            // txtMeds
            // 
            this.txtMeds.BackColor = System.Drawing.Color.Aqua;
            this.txtMeds.Location = new System.Drawing.Point(280, 86);
            this.txtMeds.Name = "txtMeds";
            this.txtMeds.Size = new System.Drawing.Size(100, 22);
            this.txtMeds.TabIndex = 6;
            // 
            // txtDays
            // 
            this.txtDays.BackColor = System.Drawing.Color.Aqua;
            this.txtDays.Location = new System.Drawing.Point(280, 43);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 22);
            this.txtDays.TabIndex = 5;
            // 
            // lblRehab
            // 
            this.lblRehab.AutoSize = true;
            this.lblRehab.ForeColor = System.Drawing.Color.Aqua;
            this.lblRehab.Location = new System.Drawing.Point(27, 212);
            this.lblRehab.Name = "lblRehab";
            this.lblRehab.Size = new System.Drawing.Size(200, 17);
            this.lblRehab.TabIndex = 4;
            this.lblRehab.Text = "Physical rehabilitation charges";
            // 
            // lblLabs
            // 
            this.lblLabs.AutoSize = true;
            this.lblLabs.ForeColor = System.Drawing.Color.Aqua;
            this.lblLabs.Location = new System.Drawing.Point(27, 170);
            this.lblLabs.Name = "lblLabs";
            this.lblLabs.Size = new System.Drawing.Size(63, 17);
            this.lblLabs.TabIndex = 3;
            this.lblLabs.Text = "Lab fees";
            // 
            // lblSurg
            // 
            this.lblSurg.AutoSize = true;
            this.lblSurg.ForeColor = System.Drawing.Color.Aqua;
            this.lblSurg.Location = new System.Drawing.Point(27, 128);
            this.lblSurg.Name = "lblSurg";
            this.lblSurg.Size = new System.Drawing.Size(114, 17);
            this.lblSurg.TabIndex = 2;
            this.lblSurg.Text = "Surgical charges";
            // 
            // lblMeds
            // 
            this.lblMeds.AutoSize = true;
            this.lblMeds.ForeColor = System.Drawing.Color.Aqua;
            this.lblMeds.Location = new System.Drawing.Point(27, 86);
            this.lblMeds.Name = "lblMeds";
            this.lblMeds.Size = new System.Drawing.Size(131, 17);
            this.lblMeds.TabIndex = 1;
            this.lblMeds.Text = "Medication charges";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.ForeColor = System.Drawing.Color.Aqua;
            this.lblDays.Location = new System.Drawing.Point(27, 46);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(147, 17);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days spent in hospital";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackgroundImage = global::HospitalChargesBrady.Properties.Resources.download;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.SeaShell;
            this.btnCalculate.Location = new System.Drawing.Point(55, 422);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 62);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Aqua;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnExit.Location = new System.Drawing.Point(364, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 62);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblOhNo
            // 
            this.lblOhNo.BackColor = System.Drawing.Color.Aqua;
            this.lblOhNo.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblOhNo.Location = new System.Drawing.Point(21, 17);
            this.lblOhNo.Name = "lblOhNo";
            this.lblOhNo.Size = new System.Drawing.Size(451, 49);
            this.lblOhNo.TabIndex = 3;
            this.lblOhNo.Text = "Oh no! You were hospitalized because you ate too many cupcakes! Enter the followi" +
    "ng amounts to calculate your total cost.";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.ForeColor = System.Drawing.Color.Aqua;
            this.lblTotalCharges.Location = new System.Drawing.Point(78, 370);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(99, 17);
            this.lblTotalCharges.TabIndex = 4;
            this.lblTotalCharges.Text = "Total charges:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.ForeColor = System.Drawing.Color.Aqua;
            this.lblOutput.Location = new System.Drawing.Point(199, 370);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 5;
            // 
            // HospitalChargesForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(524, 526);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblOhNo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBoxCharges);
            this.Name = "HospitalChargesForm";
            this.Text = "Form1";
            this.groupBoxCharges.ResumeLayout(false);
            this.groupBoxCharges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCharges;
        private System.Windows.Forms.TextBox txtRehab;
        private System.Windows.Forms.TextBox txtLabs;
        private System.Windows.Forms.TextBox txtSurg;
        private System.Windows.Forms.TextBox txtMeds;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblRehab;
        private System.Windows.Forms.Label lblLabs;
        private System.Windows.Forms.Label lblSurg;
        private System.Windows.Forms.Label lblMeds;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOhNo;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblOutput;
    }
}

