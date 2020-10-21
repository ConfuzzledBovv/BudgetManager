namespace BillTracker
{
    partial class ViewBillsForm
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
            this.components = new System.ComponentModel.Container();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.BillTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddBillsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.monthlyBillsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.billTrackerDataSet2 = new BillTracker.BillTrackerDataSet2();
            this.monthlyBillsTableAdapter2 = new BillTracker.BillTrackerDataSet2TableAdapters.MonthlyBillsTableAdapter();
            this.billTrackerDataSet4 = new BillTracker.BillTrackerDataSet4();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billTrackerDataSet5 = new BillTracker.BillTrackerDataSet5();
            this.monthlyBillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyBillsTableAdapter = new BillTracker.BillTrackerDataSet5TableAdapters.MonthlyBillsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyBillsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyBillsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(80, 30);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(131, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // BillTextBox
            // 
            this.BillTextBox.Location = new System.Drawing.Point(80, 60);
            this.BillTextBox.Name = "BillTextBox";
            this.BillTextBox.Size = new System.Drawing.Size(131, 20);
            this.BillTextBox.TabIndex = 2;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(80, 90);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(131, 20);
            this.PriceTextBox.TabIndex = 3;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(80, 120);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(131, 20);
            this.DateTextBox.TabIndex = 4;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(80, 149);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(58, 23);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(37, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Due Date";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(150, 149);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(58, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddBillsButton
            // 
            this.AddBillsButton.BackColor = System.Drawing.Color.White;
            this.AddBillsButton.Location = new System.Drawing.Point(10, 149);
            this.AddBillsButton.Name = "AddBillsButton";
            this.AddBillsButton.Size = new System.Drawing.Size(58, 23);
            this.AddBillsButton.TabIndex = 5;
            this.AddBillsButton.Text = "Add bill";
            this.AddBillsButton.UseVisualStyleBackColor = false;
            this.AddBillsButton.Click += new System.EventHandler(this.AddBillsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(40, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Edit and view data";
            // 
            // monthlyBillsBindingSource2
            // 
            this.monthlyBillsBindingSource2.DataMember = "MonthlyBills";
            this.monthlyBillsBindingSource2.DataSource = this.billTrackerDataSet2;
            // 
            // billTrackerDataSet2
            // 
            this.billTrackerDataSet2.DataSetName = "BillTrackerDataSet2";
            this.billTrackerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyBillsTableAdapter2
            // 
            this.monthlyBillsTableAdapter2.ClearBeforeFill = true;
            // 
            // billTrackerDataSet4
            // 
            this.billTrackerDataSet4.DataSetName = "BillTrackerDataSet4";
            this.billTrackerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.recurringDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.monthlyBillsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(217, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 160);
            this.dataGridView1.TabIndex = 13;
            // 
            // billTrackerDataSet5
            // 
            this.billTrackerDataSet5.DataSetName = "BillTrackerDataSet5";
            this.billTrackerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyBillsBindingSource
            // 
            this.monthlyBillsBindingSource.DataMember = "MonthlyBills";
            this.monthlyBillsBindingSource.DataSource = this.billTrackerDataSet5;
            // 
            // monthlyBillsTableAdapter
            // 
            this.monthlyBillsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.DataPropertyName = "Bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "Bill";
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // recurringDataGridViewTextBoxColumn
            // 
            this.recurringDataGridViewTextBoxColumn.DataPropertyName = "Recurring";
            this.recurringDataGridViewTextBoxColumn.HeaderText = "Recurring";
            this.recurringDataGridViewTextBoxColumn.Name = "recurringDataGridViewTextBoxColumn";
            // 
            // ViewBillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(761, 184);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddBillsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.BillTextBox);
            this.Controls.Add(this.idTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewBillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBillsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewBillsForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewBillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyBillsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyBillsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox BillTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddBillsButton;
        private System.Windows.Forms.Label label5;
        private BillTrackerDataSet2 billTrackerDataSet2;
        private System.Windows.Forms.BindingSource monthlyBillsBindingSource2;
        private BillTrackerDataSet2TableAdapters.MonthlyBillsTableAdapter monthlyBillsTableAdapter2;
        private BillTrackerDataSet4 billTrackerDataSet4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BillTrackerDataSet5 billTrackerDataSet5;
        private System.Windows.Forms.BindingSource monthlyBillsBindingSource;
        private BillTrackerDataSet5TableAdapters.MonthlyBillsTableAdapter monthlyBillsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recurringDataGridViewTextBoxColumn;
    }
}