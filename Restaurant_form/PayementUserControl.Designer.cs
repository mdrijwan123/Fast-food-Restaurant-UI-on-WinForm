namespace Restaurant_form
{
    partial class PayementUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Debit = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cashusercontrol1 = new Restaurant_form.Cashusercontrol();
            this.debitcardCustomControl1 = new Restaurant_form.DebitcardCustomControl();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Debit
            // 
            this.Debit.FlatAppearance.BorderSize = 0;
            this.Debit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Debit.Location = new System.Drawing.Point(13, 129);
            this.Debit.Name = "Debit";
            this.Debit.Size = new System.Drawing.Size(88, 34);
            this.Debit.TabIndex = 0;
            this.Debit.Text = "Debit Card";
            this.Debit.UseVisualStyleBackColor = true;
            this.Debit.Click += new System.EventHandler(this.Debit_Click);
            // 
            // credit
            // 
            this.credit.FlatAppearance.BorderSize = 0;
            this.credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credit.Location = new System.Drawing.Point(13, 167);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(88, 34);
            this.credit.TabIndex = 1;
            this.credit.Text = "Credit card";
            this.credit.UseVisualStyleBackColor = true;
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // cash
            // 
            this.cash.FlatAppearance.BorderSize = 0;
            this.cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cash.Location = new System.Drawing.Point(13, 206);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(88, 34);
            this.cash.TabIndex = 2;
            this.cash.Text = "Cash On Delivery";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Payement Option";
            // 
            // cashusercontrol1
            // 
            this.cashusercontrol1.Location = new System.Drawing.Point(117, 55);
            this.cashusercontrol1.Name = "cashusercontrol1";
            this.cashusercontrol1.Size = new System.Drawing.Size(500, 232);
            this.cashusercontrol1.TabIndex = 5;
            // 
            // debitcardCustomControl1
            // 
            this.debitcardCustomControl1.Location = new System.Drawing.Point(117, 55);
            this.debitcardCustomControl1.Name = "debitcardCustomControl1";
            this.debitcardCustomControl1.Size = new System.Drawing.Size(500, 232);
            this.debitcardCustomControl1.TabIndex = 4;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sidepanel.Location = new System.Drawing.Point(13, 129);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(10, 35);
            this.sidepanel.TabIndex = 6;
            // 
            // PayementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.cashusercontrol1);
            this.Controls.Add(this.debitcardCustomControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.Debit);
            this.Name = "PayementUserControl";
            this.Size = new System.Drawing.Size(620, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Debit;
        private System.Windows.Forms.Button credit;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Label label1;
        private DebitcardCustomControl debitcardCustomControl1;
        private Cashusercontrol cashusercontrol1;
        private System.Windows.Forms.Panel sidepanel;
    }
}
