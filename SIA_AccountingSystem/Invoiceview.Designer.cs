
namespace SIA_AccountingSystem
{
    partial class Invoiceview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.load_btn = new System.Windows.Forms.Button();
            this.due_selection = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pay_overall = new System.Windows.Forms.Button();
            this.pay_units = new System.Windows.Forms.Button();
            this.pay_miscellanous = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.m_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date_misc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 436);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_code,
            this.subject_name,
            this.units,
            this.price,
            this.issue_date,
            this.id,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(758, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_unit);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.load_btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.due_selection, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 50);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // load_btn
            // 
            this.load_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.load_btn.BackColor = System.Drawing.Color.Lime;
            this.load_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.load_btn.ForeColor = System.Drawing.Color.White;
            this.load_btn.Location = new System.Drawing.Point(20, 10);
            this.load_btn.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(120, 30);
            this.load_btn.TabIndex = 5;
            this.load_btn.Text = "Load Data";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // due_selection
            // 
            this.due_selection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.due_selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.due_selection.FormattingEnabled = true;
            this.due_selection.Items.AddRange(new object[] {
            "Unpaid",
            "Overdue",
            "Paid"});
            this.due_selection.Location = new System.Drawing.Point(504, 14);
            this.due_selection.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.due_selection.Name = "due_selection";
            this.due_selection.Size = new System.Drawing.Size(274, 21);
            this.due_selection.TabIndex = 2;
            this.due_selection.SelectedIndexChanged += new System.EventHandler(this.combo_onchange);
            this.due_selection.DropDownClosed += new System.EventHandler(this.load_invoice_drop);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.pay_overall, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pay_units, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pay_miscellanous, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 386);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(798, 50);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // pay_overall
            // 
            this.pay_overall.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pay_overall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pay_overall.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.pay_overall.ForeColor = System.Drawing.Color.White;
            this.pay_overall.Location = new System.Drawing.Point(552, 10);
            this.pay_overall.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pay_overall.Name = "pay_overall";
            this.pay_overall.Size = new System.Drawing.Size(172, 30);
            this.pay_overall.TabIndex = 8;
            this.pay_overall.Text = "Pay Full";
            this.pay_overall.UseVisualStyleBackColor = false;
            this.pay_overall.Click += new System.EventHandler(this.pay_overall_Click);
            // 
            // pay_units
            // 
            this.pay_units.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pay_units.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pay_units.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.pay_units.ForeColor = System.Drawing.Color.White;
            this.pay_units.Location = new System.Drawing.Point(321, 10);
            this.pay_units.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pay_units.Name = "pay_units";
            this.pay_units.Size = new System.Drawing.Size(172, 30);
            this.pay_units.TabIndex = 7;
            this.pay_units.Text = "Pay All Units";
            this.pay_units.UseVisualStyleBackColor = false;
            this.pay_units.Click += new System.EventHandler(this.pay_units_Click);
            // 
            // pay_miscellanous
            // 
            this.pay_miscellanous.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pay_miscellanous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pay_miscellanous.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.pay_miscellanous.ForeColor = System.Drawing.Color.White;
            this.pay_miscellanous.Location = new System.Drawing.Point(91, 10);
            this.pay_miscellanous.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pay_miscellanous.Name = "pay_miscellanous";
            this.pay_miscellanous.Size = new System.Drawing.Size(172, 30);
            this.pay_miscellanous.TabIndex = 6;
            this.pay_miscellanous.Text = "Pay All Miscellanous";
            this.pay_miscellanous.UseVisualStyleBackColor = false;
            this.pay_miscellanous.Click += new System.EventHandler(this.pay_miscellanous_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_name,
            this.m_fee,
            this.issue_date_misc});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(20, 221);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(758, 162);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_misc);
            // 
            // m_name
            // 
            this.m_name.HeaderText = "Miscellaneous Type";
            this.m_name.Name = "m_name";
            this.m_name.ReadOnly = true;
            this.m_name.Width = 300;
            // 
            // m_fee
            // 
            this.m_fee.HeaderText = "Fee";
            this.m_fee.Name = "m_fee";
            this.m_fee.ReadOnly = true;
            this.m_fee.Width = 300;
            // 
            // issue_date_misc
            // 
            this.issue_date_misc.HeaderText = "Issue Date";
            this.issue_date_misc.Name = "issue_date_misc";
            this.issue_date_misc.ReadOnly = true;
            // 
            // subject_code
            // 
            this.subject_code.HeaderText = "Subject Code";
            this.subject_code.Name = "subject_code";
            this.subject_code.ReadOnly = true;
            this.subject_code.Width = 250;
            // 
            // subject_name
            // 
            this.subject_name.HeaderText = "Subject Name";
            this.subject_name.Name = "subject_name";
            this.subject_name.ReadOnly = true;
            this.subject_name.Width = 250;
            // 
            // units
            // 
            this.units.HeaderText = "Units";
            this.units.Name = "units";
            this.units.ReadOnly = true;
            this.units.Width = 250;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 250;
            // 
            // issue_date
            // 
            this.issue_date.HeaderText = "Issue Date";
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Invoiceview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Invoiceview";
            this.Size = new System.Drawing.Size(798, 436);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox due_selection;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button pay_overall;
        private System.Windows.Forms.Button pay_units;
        private System.Windows.Forms.Button pay_miscellanous;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date_misc;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
