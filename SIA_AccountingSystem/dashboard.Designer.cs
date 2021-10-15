
namespace SIA_AccountingSystem
{
    partial class dashboard
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
            this.accounting1 = new SIA_AccountingSystem.Accounting();
            this.maindash1 = new SIA_AccountingSystem.Maindash();
            this.SuspendLayout();
            // 
            // accounting1
            // 
            this.accounting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accounting1.Location = new System.Drawing.Point(0, 0);
            this.accounting1.Name = "accounting1";
            this.accounting1.Size = new System.Drawing.Size(765, 437);
            this.accounting1.TabIndex = 0;
            // 
            // maindash1
            // 
            this.maindash1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maindash1.Location = new System.Drawing.Point(0, 0);
            this.maindash1.Name = "maindash1";
            this.maindash1.Size = new System.Drawing.Size(765, 437);
            this.maindash1.TabIndex = 1;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maindash1);
            this.Controls.Add(this.accounting1);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(765, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private Accounting accounting1;
        private Maindash maindash1;
    }
}
