namespace Ticketing
{
    partial class TicketsForm
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.chkDiscount1 = new System.Windows.Forms.CheckBox();
            this.radBalcony = new System.Windows.Forms.RadioButton();
            this.radGeneral = new System.Windows.Forms.RadioButton();
            this.radBox = new System.Windows.Forms.RadioButton();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.chkDiscount2 = new System.Windows.Forms.CheckBox();
            this.grpSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(64, 59);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(148, 59);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(325, 59);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(80, 16);
            this.lblAmountDue.TabIndex = 2;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(436, 65);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 16);
            this.lblAmount.TabIndex = 3;
            // 
            // chkDiscount1
            // 
            this.chkDiscount1.AutoSize = true;
            this.chkDiscount1.Location = new System.Drawing.Point(148, 117);
            this.chkDiscount1.Margin = new System.Windows.Forms.Padding(4);
            this.chkDiscount1.Name = "chkDiscount1";
            this.chkDiscount1.Size = new System.Drawing.Size(123, 20);
            this.chkDiscount1.TabIndex = 5;
            this.chkDiscount1.Text = "Senior / Student";
            this.chkDiscount1.UseVisualStyleBackColor = true;
            this.chkDiscount1.CheckedChanged += new System.EventHandler(this.chkDiscount1_CheckedChanged);
            // 
            // radBalcony
            // 
            this.radBalcony.AutoSize = true;
            this.radBalcony.Location = new System.Drawing.Point(35, 21);
            this.radBalcony.Margin = new System.Windows.Forms.Padding(4);
            this.radBalcony.Name = "radBalcony";
            this.radBalcony.Size = new System.Drawing.Size(77, 20);
            this.radBalcony.TabIndex = 6;
            this.radBalcony.Text = "Balcony";
            this.radBalcony.UseVisualStyleBackColor = true;
            // 
            // radGeneral
            // 
            this.radGeneral.AutoSize = true;
            this.radGeneral.Checked = true;
            this.radGeneral.Location = new System.Drawing.Point(35, 49);
            this.radGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.radGeneral.Name = "radGeneral";
            this.radGeneral.Size = new System.Drawing.Size(76, 20);
            this.radGeneral.TabIndex = 7;
            this.radGeneral.TabStop = true;
            this.radGeneral.Text = "General";
            this.radGeneral.UseVisualStyleBackColor = true;
            // 
            // radBox
            // 
            this.radBox.AutoSize = true;
            this.radBox.Location = new System.Drawing.Point(35, 78);
            this.radBox.Margin = new System.Windows.Forms.Padding(4);
            this.radBox.Name = "radBox";
            this.radBox.Size = new System.Drawing.Size(89, 20);
            this.radBox.TabIndex = 8;
            this.radBox.Text = "Box Seats";
            this.radBox.UseVisualStyleBackColor = true;
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.radBox);
            this.grpSection.Controls.Add(this.radGeneral);
            this.grpSection.Controls.Add(this.radBalcony);
            this.grpSection.Location = new System.Drawing.Point(69, 174);
            this.grpSection.Margin = new System.Windows.Forms.Padding(4);
            this.grpSection.Name = "grpSection";
            this.grpSection.Padding = new System.Windows.Forms.Padding(4);
            this.grpSection.Size = new System.Drawing.Size(185, 137);
            this.grpSection.TabIndex = 9;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "Section";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(392, 330);
            this.cmdCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(144, 43);
            this.cmdCalculate.TabIndex = 10;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // chkDiscount2
            // 
            this.chkDiscount2.AutoSize = true;
            this.chkDiscount2.Location = new System.Drawing.Point(289, 117);
            this.chkDiscount2.Name = "chkDiscount2";
            this.chkDiscount2.Size = new System.Drawing.Size(59, 20);
            this.chkDiscount2.TabIndex = 11;
            this.chkDiscount2.Text = "Child";
            this.chkDiscount2.UseVisualStyleBackColor = true;
            this.chkDiscount2.CheckedChanged += new System.EventHandler(this.chkDiscount2_CheckedChanged);
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 548);
            this.Controls.Add(this.chkDiscount2);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.grpSection);
            this.Controls.Add(this.chkDiscount1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketsForm";
            this.Text = "Theater Ticket Purchase";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.CheckBox chkDiscount1;
        private System.Windows.Forms.RadioButton radBalcony;
        private System.Windows.Forms.RadioButton radGeneral;
        private System.Windows.Forms.RadioButton radBox;
        private System.Windows.Forms.GroupBox grpSection;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.CheckBox chkDiscount2;
    }
}

