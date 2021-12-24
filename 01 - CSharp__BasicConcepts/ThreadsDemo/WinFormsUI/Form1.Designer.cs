namespace WinFormsUI
{
    partial class frmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExecuteNormal = new System.Windows.Forms.Button();
            this.btnExecuteAsync = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecuteNormal
            // 
            this.btnExecuteNormal.BackColor = System.Drawing.Color.Indigo;
            this.btnExecuteNormal.FlatAppearance.BorderSize = 0;
            this.btnExecuteNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteNormal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExecuteNormal.ForeColor = System.Drawing.Color.White;
            this.btnExecuteNormal.Location = new System.Drawing.Point(12, 87);
            this.btnExecuteNormal.Name = "btnExecuteNormal";
            this.btnExecuteNormal.Size = new System.Drawing.Size(776, 58);
            this.btnExecuteNormal.TabIndex = 0;
            this.btnExecuteNormal.Text = "Execute Normal";
            this.btnExecuteNormal.UseVisualStyleBackColor = false;
            this.btnExecuteNormal.Click += new System.EventHandler(this.btnExecuteNormal_Click);
            // 
            // btnExecuteAsync
            // 
            this.btnExecuteAsync.BackColor = System.Drawing.Color.Indigo;
            this.btnExecuteAsync.FlatAppearance.BorderSize = 0;
            this.btnExecuteAsync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteAsync.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExecuteAsync.ForeColor = System.Drawing.Color.White;
            this.btnExecuteAsync.Location = new System.Drawing.Point(12, 151);
            this.btnExecuteAsync.Name = "btnExecuteAsync";
            this.btnExecuteAsync.Size = new System.Drawing.Size(776, 58);
            this.btnExecuteAsync.TabIndex = 1;
            this.btnExecuteAsync.Text = "Execute Async";
            this.btnExecuteAsync.UseVisualStyleBackColor = false;
            this.btnExecuteAsync.Click += new System.EventHandler(this.btnExecuteAsync_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Black;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtResult.Location = new System.Drawing.Point(12, 215);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(776, 273);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(575, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Simple Demo using Sync and Async method";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(764, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(37, 40);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExecuteAsync);
            this.Controls.Add(this.btnExecuteNormal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecuteNormal;
        private System.Windows.Forms.Button btnExecuteAsync;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClose;
    }
}
