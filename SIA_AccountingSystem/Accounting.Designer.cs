
namespace SIA_AccountingSystem
{
    partial class Accounting
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.overdue_btn = new System.Windows.Forms.Button();
            this.feetypes_btn = new System.Windows.Forms.Button();
            this.invoice_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ac_feetypes1 = new SIA_AccountingSystem.ac_feetypes();
            this.ac_overdue1 = new SIA_AccountingSystem.ac_overdue();
            this.ac_invoice1 = new SIA_AccountingSystem.ac_invoice();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 448);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.invoice_btn);
            this.panel1.Controls.Add(this.feetypes_btn);
            this.panel1.Controls.Add(this.overdue_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(407, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 80);
            this.panel1.TabIndex = 0;
            // 
            // overdue_btn
            // 
            this.overdue_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.overdue_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(116)))));
            this.overdue_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.overdue_btn.ForeColor = System.Drawing.Color.White;
            this.overdue_btn.Location = new System.Drawing.Point(143, 25);
            this.overdue_btn.Name = "overdue_btn";
            this.overdue_btn.Size = new System.Drawing.Size(120, 30);
            this.overdue_btn.TabIndex = 2;
            this.overdue_btn.Text = "Overdue";
            this.overdue_btn.UseVisualStyleBackColor = false;
            this.overdue_btn.Click += new System.EventHandler(this.overdue_btn_Click);
            // 
            // feetypes_btn
            // 
            this.feetypes_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.feetypes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(116)))));
            this.feetypes_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.feetypes_btn.ForeColor = System.Drawing.Color.White;
            this.feetypes_btn.Location = new System.Drawing.Point(269, 25);
            this.feetypes_btn.Name = "feetypes_btn";
            this.feetypes_btn.Size = new System.Drawing.Size(120, 30);
            this.feetypes_btn.TabIndex = 3;
            this.feetypes_btn.Text = "Fee Types";
            this.feetypes_btn.UseVisualStyleBackColor = false;
            this.feetypes_btn.Click += new System.EventHandler(this.feetypes_btn_Click);
            // 
            // invoice_btn
            // 
            this.invoice_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.invoice_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(116)))));
            this.invoice_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.invoice_btn.ForeColor = System.Drawing.Color.White;
            this.invoice_btn.Location = new System.Drawing.Point(17, 25);
            this.invoice_btn.Name = "invoice_btn";
            this.invoice_btn.Size = new System.Drawing.Size(120, 30);
            this.invoice_btn.TabIndex = 4;
            this.invoice_btn.Text = "Invoices";
            this.invoice_btn.UseVisualStyleBackColor = false;
            this.invoice_btn.Click += new System.EventHandler(this.invoice_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ac_invoice1);
            this.panel2.Controls.Add(this.ac_overdue1);
            this.panel2.Controls.Add(this.ac_feetypes1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 368);
            this.panel2.TabIndex = 1;
            // 
            // ac_feetypes1
            // 
            this.ac_feetypes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ac_feetypes1.Location = new System.Drawing.Point(0, 0);
            this.ac_feetypes1.Name = "ac_feetypes1";
            this.ac_feetypes1.Size = new System.Drawing.Size(814, 368);
            this.ac_feetypes1.TabIndex = 0;
            // 
            // ac_overdue1
            // 
            this.ac_overdue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ac_overdue1.Location = new System.Drawing.Point(0, 0);
            this.ac_overdue1.Name = "ac_overdue1";
            this.ac_overdue1.Size = new System.Drawing.Size(814, 368);
            this.ac_overdue1.TabIndex = 1;
            // 
            // ac_invoice1
            // 
            this.ac_invoice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ac_invoice1.Location = new System.Drawing.Point(0, 0);
            this.ac_invoice1.Name = "ac_invoice1";
            this.ac_invoice1.Size = new System.Drawing.Size(814, 368);
            this.ac_invoice1.TabIndex = 2;
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Accounting";
            this.Size = new System.Drawing.Size(814, 448);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button invoice_btn;
        private System.Windows.Forms.Button feetypes_btn;
        private System.Windows.Forms.Button overdue_btn;
        private System.Windows.Forms.Panel panel2;
        private ac_invoice ac_invoice1;
        private ac_overdue ac_overdue1;
        private ac_feetypes ac_feetypes1;
    }
}
