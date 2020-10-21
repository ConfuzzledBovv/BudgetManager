namespace BillTracker
{
    partial class AddBillForm
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bill_Name_Text = new System.Windows.Forms.TextBox();
            this.EnterDataButton = new System.Windows.Forms.Button();
            this.BillNameText = new System.Windows.Forms.Label();
            this.BillPriceText = new System.Windows.Forms.Label();
            this.BillCalendarDate = new System.Windows.Forms.MonthCalendar();
            this.Title = new System.Windows.Forms.Label();
            this.BillPrice = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftOverMonthlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTrackerDataSet3 = new BillTracker.BillTrackerDataSet3();
            this.leftOverMonthlyTableAdapter = new BillTracker.BillTrackerDataSet3TableAdapters.LeftOverMonthlyTableAdapter();
            this.recurringCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftOverMonthlyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // Bill_Name_Text
            // 
            this.Bill_Name_Text.Location = new System.Drawing.Point(68, 73);
            this.Bill_Name_Text.Name = "Bill_Name_Text";
            this.Bill_Name_Text.Size = new System.Drawing.Size(96, 20);
            this.Bill_Name_Text.TabIndex = 0;
            this.Bill_Name_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bill_Name_Text_KeyPress);
            // 
            // EnterDataButton
            // 
            this.EnterDataButton.BackColor = System.Drawing.Color.White;
            this.EnterDataButton.Location = new System.Drawing.Point(40, 157);
            this.EnterDataButton.Name = "EnterDataButton";
            this.EnterDataButton.Size = new System.Drawing.Size(75, 23);
            this.EnterDataButton.TabIndex = 3;
            this.EnterDataButton.Text = "Enter Data";
            this.EnterDataButton.UseVisualStyleBackColor = false;
            this.EnterDataButton.Click += new System.EventHandler(this.Enter_Data_Button);
            // 
            // BillNameText
            // 
            this.BillNameText.AutoSize = true;
            this.BillNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNameText.ForeColor = System.Drawing.SystemColors.Window;
            this.BillNameText.Location = new System.Drawing.Point(0, 69);
            this.BillNameText.Name = "BillNameText";
            this.BillNameText.Size = new System.Drawing.Size(61, 24);
            this.BillNameText.TabIndex = 4;
            this.BillNameText.Text = "Name";
            // 
            // BillPriceText
            // 
            this.BillPriceText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillPriceText.AutoSize = true;
            this.BillPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillPriceText.ForeColor = System.Drawing.SystemColors.Window;
            this.BillPriceText.Location = new System.Drawing.Point(0, 100);
            this.BillPriceText.Name = "BillPriceText";
            this.BillPriceText.Size = new System.Drawing.Size(53, 24);
            this.BillPriceText.TabIndex = 5;
            this.BillPriceText.Text = "Price";
            // 
            // BillCalendarDate
            // 
            this.BillCalendarDate.Location = new System.Drawing.Point(176, 18);
            this.BillCalendarDate.Name = "BillCalendarDate";
            this.BillCalendarDate.TabIndex = 2;
            this.BillCalendarDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.BillCalendarDate_DateSelected);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.Window;
            this.Title.Location = new System.Drawing.Point(0, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(174, 20);
            this.Title.TabIndex = 8;
            this.Title.Text = "Add Bill to Database";
            // 
            // BillPrice
            // 
            this.BillPrice.DecimalPlaces = 2;
            this.BillPrice.Location = new System.Drawing.Point(68, 104);
            this.BillPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BillPrice.Name = "BillPrice";
            this.BillPrice.Size = new System.Drawing.Size(96, 20);
            this.BillPrice.TabIndex = 1;
            this.BillPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BillPrice_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.leftOverMonthlyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(406, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 162);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn1.HeaderText = "Month";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn2.HeaderText = "Year";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remains";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remains";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // leftOverMonthlyBindingSource
            // 
            this.leftOverMonthlyBindingSource.DataMember = "LeftOverMonthly";
            this.leftOverMonthlyBindingSource.DataSource = this.billTrackerDataSet3;
            // 
            // billTrackerDataSet3
            // 
            this.billTrackerDataSet3.DataSetName = "BillTrackerDataSet3";
            this.billTrackerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leftOverMonthlyTableAdapter
            // 
            this.leftOverMonthlyTableAdapter.ClearBeforeFill = true;
            // 
            // recurringCheck
            // 
            this.recurringCheck.AutoSize = true;
            this.recurringCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recurringCheck.Location = new System.Drawing.Point(4, 131);
            this.recurringCheck.Name = "recurringCheck";
            this.recurringCheck.Size = new System.Drawing.Size(72, 17);
            this.recurringCheck.TabIndex = 11;
            this.recurringCheck.Text = "Recurring";
            this.recurringCheck.UseVisualStyleBackColor = true;
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(753, 195);
            this.Controls.Add(this.recurringCheck);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BillPrice);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.BillCalendarDate);
            this.Controls.Add(this.BillPriceText);
            this.Controls.Add(this.BillNameText);
            this.Controls.Add(this.EnterDataButton);
            this.Controls.Add(this.Bill_Name_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBillForm_FormClosing);
            this.Load += new System.EventHandler(this.AddBillForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.BillPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftOverMonthlyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ShowAddFoodForm()
        {
            Bill_Name_Text.Dispose();
            EnterDataButton.Dispose();
            BillNameText.Dispose();
            BillPriceText.Dispose();
            BillCalendarDate.Dispose();
            BillPrice.Dispose();
            dataGridView1.Dispose();
            recurringCheck.Dispose();
            this.components = new System.ComponentModel.Container();
            this.RemoveFoodBillButton = new System.Windows.Forms.Button();
            this.AddFoodBillButton = new System.Windows.Forms.Button();
            this.FoodBillTextBox = new System.Windows.Forms.NumericUpDown();
            this.MonthlyFoodTable = new System.Windows.Forms.DataGridView();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FoodRemainingLabel = new System.Windows.Forms.Label();
            this.FoodSpentLabel = new System.Windows.Forms.Label();
            this.billTrackerDataSet = new BillTracker.BillTrackerDataSet();
            this.monthlyFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyFoodTableAdapter = new BillTracker.BillTrackerDataSetTableAdapters.MonthlyFoodTableAdapter();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.MonthlyFoodTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyFoodBindingSource)).BeginInit();

            //
            // Edit Title
            //
            Title.Text = "Add Food Bills";
            this.Title.Location = new System.Drawing.Point(25, 22);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(5, 125);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(160, 18);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Enter price £";
            // 
            // FoodRemainingLabel
            // 
            this.FoodRemainingLabel.AutoSize = true;
            this.FoodRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodRemainingLabel.ForeColor = System.Drawing.Color.White;
            this.FoodRemainingLabel.Location = new System.Drawing.Point(5, 65);
            this.FoodRemainingLabel.Name = "FoodRemainingLabel";
            this.FoodRemainingLabel.Size = new System.Drawing.Size(160, 18);
            this.FoodRemainingLabel.TabIndex = 8;
            this.FoodRemainingLabel.Text = "Budget remaining £";
            // 
            // FoodSpentLabel
            // 
            this.FoodSpentLabel.AutoSize = true;
            this.FoodSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodSpentLabel.ForeColor = System.Drawing.Color.White;
            this.FoodSpentLabel.Location = new System.Drawing.Point(5, 95);
            this.FoodSpentLabel.Name = "FoodSpentLabel";
            this.FoodSpentLabel.Size = new System.Drawing.Size(160, 18);
            this.FoodSpentLabel.TabIndex = 8;
            this.FoodSpentLabel.Text = "Budget spent £";
            // 
            // RemoveFoodBillButton
            // 
            this.RemoveFoodBillButton.BackColor = System.Drawing.Color.White;
            this.RemoveFoodBillButton.Location = new System.Drawing.Point(3, 165);
            this.RemoveFoodBillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFoodBillButton.Name = "RemoveFoodBillButton";
            this.RemoveFoodBillButton.Size = new System.Drawing.Size(90, 23);
            this.RemoveFoodBillButton.TabIndex = 2;
            this.RemoveFoodBillButton.Text = "Remove Spent";
            this.RemoveFoodBillButton.UseVisualStyleBackColor = false;
            this.RemoveFoodBillButton.Click += new System.EventHandler(this.RemoveFoodBillButton_Click);
            // 
            // AddFoodBillButton
            // 
            this.AddFoodBillButton.BackColor = System.Drawing.Color.White;
            this.AddFoodBillButton.Location = new System.Drawing.Point(95, 165);
            this.AddFoodBillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodBillButton.Name = "AddFoodBillButton";
            this.AddFoodBillButton.Size = new System.Drawing.Size(90, 23);
            this.AddFoodBillButton.TabIndex = 2;
            this.AddFoodBillButton.Text = "Add Spent";
            this.AddFoodBillButton.UseVisualStyleBackColor = false;
            this.AddFoodBillButton.Click += new System.EventHandler(this.AddFoodBillButton_Click);
            // 
            // FoodBillTextBox
            // 
            this.FoodBillTextBox.Location = new System.Drawing.Point(95, 125);
            this.FoodBillTextBox.Name = "FoodBillTextBox";
            this.FoodBillTextBox.Size = new System.Drawing.Size(75, 20);
            this.FoodBillTextBox.TabIndex = 0;
            this.FoodBillTextBox.DecimalPlaces = 2;
            this.FoodBillTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodBillTextBox_KeyPress);
            // 
            // MonthlyFoodTable
            // 
            this.MonthlyFoodTable.AutoGenerateColumns = false;
            this.MonthlyFoodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthlyFoodTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.spentDataGridViewTextBoxColumn,
            this.remainsDataGridViewTextBoxColumn});
            this.MonthlyFoodTable.DataSource = this.monthlyFoodBindingSource;
            this.MonthlyFoodTable.Location = new System.Drawing.Point(190, 10);
            this.MonthlyFoodTable.Name = "MonthlyFoodTable";
            this.MonthlyFoodTable.Size = new System.Drawing.Size(440, 180);
            this.MonthlyFoodTable.TabIndex = 11;
            // 
            // billTrackerDataSet
            // 
            this.billTrackerDataSet.DataSetName = "BillTrackerDataSet";
            this.billTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyFoodBindingSource
            // 
            this.monthlyFoodBindingSource.DataMember = "MonthlyFood";
            this.monthlyFoodBindingSource.DataSource = this.billTrackerDataSet;
            // 
            // monthlyFoodTableAdapter
            // 
            this.monthlyFoodTableAdapter.ClearBeforeFill = true;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // spentDataGridViewTextBoxColumn
            // 
            this.spentDataGridViewTextBoxColumn.DataPropertyName = "Spent";
            this.spentDataGridViewTextBoxColumn.HeaderText = "Spent";
            this.spentDataGridViewTextBoxColumn.Name = "spentDataGridViewTextBoxColumn";
            // 
            // remainsDataGridViewTextBoxColumn
            // 
            this.remainsDataGridViewTextBoxColumn.DataPropertyName = "Remains";
            this.remainsDataGridViewTextBoxColumn.HeaderText = "Remains";
            this.remainsDataGridViewTextBoxColumn.Name = "remainsDataGridViewTextBoxColumn";
            //
            // Form
            //
            this.Controls.Add(this.RemoveFoodBillButton);
            this.Controls.Add(this.AddFoodBillButton);
            this.Controls.Add(this.FoodBillTextBox);
            this.Controls.Add(this.MonthlyFoodTable);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.FoodRemainingLabel);
            this.Controls.Add(this.FoodSpentLabel);
            this.ClientSize = new System.Drawing.Size(640, 200);
            this.Load += new System.EventHandler(this.AddBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyFoodTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyFoodBindingSource)).EndInit();
        }
        private void MenuItems()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.ViewMenuButton = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.AddFoodBillsMenuButton = new System.Windows.Forms.MenuItem();
            this.AddBillsMenuButton = new System.Windows.Forms.MenuItem();
            this.NewMonthMenuButton = new System.Windows.Forms.MenuItem();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ViewMenuButton,
            this.menuItem2,
            this.NewMonthMenuButton});
            // 
            // ViewMenuButton
            // 
            this.ViewMenuButton.Index = 0;
            this.ViewMenuButton.Text = "View Bills";
            this.ViewMenuButton.Click += new System.EventHandler(this.ViewMenuButton_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.AddFoodBillsMenuButton,
            this.AddBillsMenuButton});
            this.menuItem2.Text = "Add";
            //
            // NewMonthMenuButton
            //
            this.NewMonthMenuButton.Index = 2;
            this.NewMonthMenuButton.Text = "New Month";
            this.NewMonthMenuButton.Click += new System.EventHandler(this.NewMonthMenuButton_Click);
            // 
            // AddFoodBillsMenuButton
            // 
            this.AddFoodBillsMenuButton.Index = 0;
            this.AddFoodBillsMenuButton.Text = "Food Bills";
            this.AddFoodBillsMenuButton.Click += new System.EventHandler(this.AddFoodBillsMenuButton_Click);
            // 
            // AddBillsMenuButton
            // 
            this.AddBillsMenuButton.Index = 1;
            this.AddBillsMenuButton.Text = "Bills";
            this.AddBillsMenuButton.Click += new System.EventHandler(this.AddBillsMenuButton_Click);

            this.Menu = this.mainMenu1;
        }

        #endregion
        // Add Bill
        private System.Windows.Forms.TextBox Bill_Name_Text;
        private System.Windows.Forms.Button EnterDataButton;
        private System.Windows.Forms.Label BillNameText;
        private System.Windows.Forms.Label BillPriceText;
        private System.Windows.Forms.MonthCalendar BillCalendarDate;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.NumericUpDown BillPrice;

        // Add Food Bill

        private System.Windows.Forms.Button RemoveFoodBillButton;
        private System.Windows.Forms.Button AddFoodBillButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label FoodRemainingLabel;
        private System.Windows.Forms.Label FoodSpentLabel;
        private System.Windows.Forms.NumericUpDown FoodBillTextBox;
        private System.Windows.Forms.DataGridView MonthlyFoodTable;
        private BillTrackerDataSet billTrackerDataSet;
        private System.Windows.Forms.BindingSource monthlyFoodBindingSource;
        private BillTrackerDataSetTableAdapters.MonthlyFoodTableAdapter monthlyFoodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainsDataGridViewTextBoxColumn;
        private System.Windows.Forms.MainMenu mainMenu1;
        public System.Windows.Forms.MenuItem ViewMenuButton;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem NewMonthMenuButton;
        private System.Windows.Forms.MenuItem AddFoodBillsMenuButton;
        private System.Windows.Forms.MenuItem AddBillsMenuButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BillTrackerDataSet3 billTrackerDataSet3;
        private System.Windows.Forms.BindingSource leftOverMonthlyBindingSource;
        private BillTrackerDataSet3TableAdapters.LeftOverMonthlyTableAdapter leftOverMonthlyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.CheckBox recurringCheck;
    }
}

