namespace CommonsTracker
{
    partial class CloseProcedure
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
            this.clbClosing = new System.Windows.Forms.CheckedListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbClosing
            // 
            this.clbClosing.CheckOnClick = true;
            this.clbClosing.FormattingEnabled = true;
            this.clbClosing.Location = new System.Drawing.Point(25, 12);
            this.clbClosing.Name = "clbClosing";
            this.clbClosing.Size = new System.Drawing.Size(254, 334);
            this.clbClosing.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(285, 303);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(88, 43);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(129, 352);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(110, 20);
            this.txtStaff.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 356);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Staff Sign Off Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // CloseProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 388);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.clbClosing);
            this.Name = "CloseProcedure";
            this.Text = "CloseProcedure";
            this.Load += new System.EventHandler(this.CloseProcedure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbClosing;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label lblName;
    }
}