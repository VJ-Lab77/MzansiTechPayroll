using System;
using System.Windows.Forms;

namespace MzansiTechPayroll
{
    public partial class MainForm : Form
    {
        // Declare the calculator object
        private PayrollCalculator calculator;

        public MainForm()
        {
            InitializeComponent();
            calculator = new PayrollCalculator();
        }

        // This method creates all the UI controls programmatically
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblContractorName = new System.Windows.Forms.Label();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblDependents = new System.Windows.Forms.Label();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblGrossPayLabel = new System.Windows.Forms.Label();
            this.lblGrossPayValue = new System.Windows.Forms.Label();
            this.lblUIFLabel = new System.Windows.Forms.Label();
            this.lblUIFValue = new System.Windows.Forms.Label();
            this.lblPAYELabel = new System.Windows.Forms.Label();
            this.lblPAYEValue = new System.Windows.Forms.Label();
            this.lblMembershipLabel = new System.Windows.Forms.Label();
            this.lblMembershipValue = new System.Windows.Forms.Label();
            this.lblTotalDeductionsLabel = new System.Windows.Forms.Label();
            this.lblTotalDeductionsValue = new System.Windows.Forms.Label();
            this.lblNetPayLabel = new System.Windows.Forms.Label();
            this.lblNetPayValue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mzansi Tech Contractors Payroll System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.Lavender;
            this.grpInput.Controls.Add(this.lblContractorName);
            this.grpInput.Controls.Add(this.txtContractorName);
            this.grpInput.Controls.Add(this.lblHoursWorked);
            this.grpInput.Controls.Add(this.txtHoursWorked);
            this.grpInput.Controls.Add(this.lblDependents);
            this.grpInput.Controls.Add(this.txtDependents);
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.Black;
            this.grpInput.Location = new System.Drawing.Point(28, 110);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(280, 220);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Contractor Details";
            // 
            // lblContractorName
            // 
            this.lblContractorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContractorName.Location = new System.Drawing.Point(15, 30);
            this.lblContractorName.Name = "lblContractorName";
            this.lblContractorName.Size = new System.Drawing.Size(120, 25);
            this.lblContractorName.TabIndex = 0;
            this.lblContractorName.Text = "Contractor Name:";
            // 
            // txtContractorName
            // 
            this.txtContractorName.BackColor = System.Drawing.Color.Lavender;
            this.txtContractorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContractorName.Location = new System.Drawing.Point(15, 58);
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(240, 27);
            this.txtContractorName.TabIndex = 1;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoursWorked.Location = new System.Drawing.Point(15, 90);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(120, 25);
            this.lblHoursWorked.TabIndex = 2;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.BackColor = System.Drawing.Color.Lavender;
            this.txtHoursWorked.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoursWorked.Location = new System.Drawing.Point(15, 115);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(240, 27);
            this.txtHoursWorked.TabIndex = 3;
            // 
            // lblDependents
            // 
            this.lblDependents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDependents.Location = new System.Drawing.Point(15, 150);
            this.lblDependents.Name = "lblDependents";
            this.lblDependents.Size = new System.Drawing.Size(180, 25);
            this.lblDependents.TabIndex = 4;
            this.lblDependents.Text = "Dependents (0 - 10):";
            // 
            // txtDependents
            // 
            this.txtDependents.BackColor = System.Drawing.Color.Lavender;
            this.txtDependents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDependents.Location = new System.Drawing.Point(15, 175);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(240, 27);
            this.txtDependents.TabIndex = 5;
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.Lavender;
            this.grpOutput.Controls.Add(this.lblGrossPayLabel);
            this.grpOutput.Controls.Add(this.lblGrossPayValue);
            this.grpOutput.Controls.Add(this.lblUIFLabel);
            this.grpOutput.Controls.Add(this.lblUIFValue);
            this.grpOutput.Controls.Add(this.lblPAYELabel);
            this.grpOutput.Controls.Add(this.lblPAYEValue);
            this.grpOutput.Controls.Add(this.lblMembershipLabel);
            this.grpOutput.Controls.Add(this.lblMembershipValue);
            this.grpOutput.Controls.Add(this.lblTotalDeductionsLabel);
            this.grpOutput.Controls.Add(this.lblTotalDeductionsValue);
            this.grpOutput.Controls.Add(this.lblNetPayLabel);
            this.grpOutput.Controls.Add(this.lblNetPayValue);
            this.grpOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpOutput.ForeColor = System.Drawing.Color.Black;
            this.grpOutput.Location = new System.Drawing.Point(349, 110);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(280, 280);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Payroll Results";
            // 
            // lblGrossPayLabel
            // 
            this.lblGrossPayLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGrossPayLabel.Location = new System.Drawing.Point(15, 30);
            this.lblGrossPayLabel.Name = "lblGrossPayLabel";
            this.lblGrossPayLabel.Size = new System.Drawing.Size(120, 25);
            this.lblGrossPayLabel.TabIndex = 0;
            this.lblGrossPayLabel.Text = "Gross Pay:";
            // 
            // lblGrossPayValue
            // 
            this.lblGrossPayValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGrossPayValue.Location = new System.Drawing.Point(140, 30);
            this.lblGrossPayValue.Name = "lblGrossPayValue";
            this.lblGrossPayValue.Size = new System.Drawing.Size(120, 25);
            this.lblGrossPayValue.TabIndex = 1;
            this.lblGrossPayValue.Text = "R 0.00";
            this.lblGrossPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUIFLabel
            // 
            this.lblUIFLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUIFLabel.Location = new System.Drawing.Point(15, 65);
            this.lblUIFLabel.Name = "lblUIFLabel";
            this.lblUIFLabel.Size = new System.Drawing.Size(120, 25);
            this.lblUIFLabel.TabIndex = 2;
            this.lblUIFLabel.Text = "UIF (1%):";
            // 
            // lblUIFValue
            // 
            this.lblUIFValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUIFValue.Location = new System.Drawing.Point(140, 65);
            this.lblUIFValue.Name = "lblUIFValue";
            this.lblUIFValue.Size = new System.Drawing.Size(120, 25);
            this.lblUIFValue.TabIndex = 3;
            this.lblUIFValue.Text = "R 0.00";
            this.lblUIFValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPAYELabel
            // 
            this.lblPAYELabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPAYELabel.Location = new System.Drawing.Point(15, 100);
            this.lblPAYELabel.Name = "lblPAYELabel";
            this.lblPAYELabel.Size = new System.Drawing.Size(120, 25);
            this.lblPAYELabel.TabIndex = 4;
            this.lblPAYELabel.Text = "PAYE:";
            // 
            // lblPAYEValue
            // 
            this.lblPAYEValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPAYEValue.Location = new System.Drawing.Point(140, 100);
            this.lblPAYEValue.Name = "lblPAYEValue";
            this.lblPAYEValue.Size = new System.Drawing.Size(120, 25);
            this.lblPAYEValue.TabIndex = 5;
            this.lblPAYEValue.Text = "R 0.00";
            this.lblPAYEValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMembershipLabel
            // 
            this.lblMembershipLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMembershipLabel.Location = new System.Drawing.Point(15, 135);
            this.lblMembershipLabel.Name = "lblMembershipLabel";
            this.lblMembershipLabel.Size = new System.Drawing.Size(120, 25);
            this.lblMembershipLabel.TabIndex = 6;
            this.lblMembershipLabel.Text = "Membership Fee (13%):";
            // 
            // lblMembershipValue
            // 
            this.lblMembershipValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMembershipValue.Location = new System.Drawing.Point(140, 135);
            this.lblMembershipValue.Name = "lblMembershipValue";
            this.lblMembershipValue.Size = new System.Drawing.Size(120, 25);
            this.lblMembershipValue.TabIndex = 7;
            this.lblMembershipValue.Text = "R 0.00";
            this.lblMembershipValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeductionsLabel
            // 
            this.lblTotalDeductionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalDeductionsLabel.Location = new System.Drawing.Point(15, 175);
            this.lblTotalDeductionsLabel.Name = "lblTotalDeductionsLabel";
            this.lblTotalDeductionsLabel.Size = new System.Drawing.Size(120, 25);
            this.lblTotalDeductionsLabel.TabIndex = 8;
            this.lblTotalDeductionsLabel.Text = "Total Deductions:";
            // 
            // lblTotalDeductionsValue
            // 
            this.lblTotalDeductionsValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalDeductionsValue.Location = new System.Drawing.Point(140, 175);
            this.lblTotalDeductionsValue.Name = "lblTotalDeductionsValue";
            this.lblTotalDeductionsValue.Size = new System.Drawing.Size(120, 25);
            this.lblTotalDeductionsValue.TabIndex = 9;
            this.lblTotalDeductionsValue.Text = "R 0.00";
            this.lblTotalDeductionsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetPayLabel
            // 
            this.lblNetPayLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNetPayLabel.Location = new System.Drawing.Point(15, 215);
            this.lblNetPayLabel.Name = "lblNetPayLabel";
            this.lblNetPayLabel.Size = new System.Drawing.Size(120, 25);
            this.lblNetPayLabel.TabIndex = 10;
            this.lblNetPayLabel.Text = "Net Pay:";
            // 
            // lblNetPayValue
            // 
            this.lblNetPayValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNetPayValue.ForeColor = System.Drawing.Color.Green;
            this.lblNetPayValue.Location = new System.Drawing.Point(140, 215);
            this.lblNetPayValue.Name = "lblNetPayValue";
            this.lblNetPayValue.Size = new System.Drawing.Size(120, 30);
            this.lblNetPayValue.TabIndex = 11;
            this.lblNetPayValue.Text = "R 0.00";
            this.lblNetPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Lavender;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(12, 344);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 32);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Lavender;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(144, 344);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(241, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mzansi Tech Payroll System";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // ============== CALCULATE BUTTON CLICK EVENT ==============
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate all inputs
                if (!ValidateInputs())
                    return;

                // Step 2: Get values from textboxes
                string contractorName = txtContractorName.Text.Trim();
                decimal hoursWorked = decimal.Parse(txtHoursWorked.Text);
                int dependents = int.Parse(txtDependents.Text);

                // Step 3: Perform calculations using the PayrollCalculator class
                decimal grossPay = calculator.CalculateGrossPay(hoursWorked);
                decimal uif = calculator.CalculateUIF(grossPay);
                decimal membershipFee = calculator.CalculateMembershipFee(grossPay);
                decimal paye = calculator.CalculatePAYE(grossPay, dependents);
                decimal totalDeductions = calculator.CalculateTotalDeductions(uif, paye, membershipFee);
                decimal netPay = calculator.CalculateNetPay(grossPay, totalDeductions);

                // Step 4: Display results in the labels
                lblGrossPayValue.Text = $"R {grossPay:N2}";
                lblUIFValue.Text = $"R {uif:N2}";
                lblPAYEValue.Text = $"R {paye:N2}";
                lblMembershipValue.Text = $"R {membershipFee:N2}";
                lblTotalDeductionsValue.Text = $"R {totalDeductions:N2}";
                lblNetPayValue.Text = $"R {netPay:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============== VALIDATION METHOD ==============
        private bool ValidateInputs()
        {
            // Check 1: Contractor Name cannot be empty
            if (string.IsNullOrWhiteSpace(txtContractorName.Text))
            {
                MessageBox.Show("Please enter the contractor name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContractorName.Focus();
                return false;
            }

            // Check 2: Hours Worked must be a valid number
            if (!decimal.TryParse(txtHoursWorked.Text, out decimal hoursWorked))
            {
                MessageBox.Show("Please enter a valid number for hours worked.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoursWorked.Focus();
                return false;
            }

            // Check 3: Hours Worked cannot be negative
            if (hoursWorked < 0)
            {
                MessageBox.Show("Hours worked cannot be negative.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoursWorked.Focus();
                return false;
            }

            // Check 4: Dependents must be a valid number
            if (!int.TryParse(txtDependents.Text, out int dependents))
            {
                MessageBox.Show("Please enter a valid number for dependents.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return false;
            }

            // Check 5: Dependents cannot be negative
            if (dependents < 0)
            {
                MessageBox.Show("Dependents cannot be negative.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return false;
            }

            // Check 6: Dependents cannot exceed 10
            if (dependents > 10)
            {
                MessageBox.Show("Dependents cannot exceed 10.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return false;
            }

            return true;
        }

        // ============== RESET BUTTON CLICK EVENT ==============
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtContractorName.Clear();
            txtHoursWorked.Clear();
            txtDependents.Clear();

            // Reset all output labels to zero
            lblGrossPayValue.Text = "R 0.00";
            lblUIFValue.Text = "R 0.00";
            lblPAYEValue.Text = "R 0.00";
            lblMembershipValue.Text = "R 0.00";
            lblTotalDeductionsValue.Text = "R 0.00";
            lblNetPayValue.Text = "R 0.00";

            // Set focus back to the first field
            txtContractorName.Focus();
        }

        // ============== EXIT BUTTON CLICK EVENT ==============
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before closing
            DialogResult result = MessageBox.Show("Are you sure you want to exit the Payroll System?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ============== DECLARE ALL CONTROLS ==============
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtContractorName;
        private System.Windows.Forms.Label lblContractorName;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.Label lblDependents;
        private System.Windows.Forms.Label lblGrossPayLabel;
        private System.Windows.Forms.Label lblGrossPayValue;
        private System.Windows.Forms.Label lblUIFLabel;
        private System.Windows.Forms.Label lblUIFValue;
        private System.Windows.Forms.Label lblPAYELabel;
        private System.Windows.Forms.Label lblPAYEValue;
        private System.Windows.Forms.Label lblMembershipLabel;
        private System.Windows.Forms.Label lblMembershipValue;
        private System.Windows.Forms.Label lblTotalDeductionsLabel;
        private System.Windows.Forms.Label lblTotalDeductionsValue;
        private System.Windows.Forms.Label lblNetPayLabel;
        private System.Windows.Forms.Label lblNetPayValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}