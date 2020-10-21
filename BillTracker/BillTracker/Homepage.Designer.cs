namespace BillTracker
{
    partial class Homepage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.AddBillsButton = new System.Windows.Forms.MenuItem();
            this.ViewBillsButton = new System.Windows.Forms.MenuItem();
            this.ManageBudgetsButton = new System.Windows.Forms.MenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.TitleLabel.Location = new System.Drawing.Point(47, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(293, 54);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Bill Manager";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.AddBillsButton,
            this.ViewBillsButton,
            this.ManageBudgetsButton});
            // 
            // AddBillsButton
            // 
            this.AddBillsButton.Index = 0;
            this.AddBillsButton.Text = "Add Bills";
            this.AddBillsButton.Click += new System.EventHandler(this.AddBillsButton_Click);
            // 
            // ViewBillsButton
            // 
            this.ViewBillsButton.Index = 1;
            this.ViewBillsButton.Text = "View Bills";
            this.ViewBillsButton.Click += new System.EventHandler(this.ViewBillsButton_Click);
            // 
            // ManageBudgetsButton
            // 
            this.ManageBudgetsButton.Index = 2;
            this.ManageBudgetsButton.Text = "Manage Budgets";
            this.ManageBudgetsButton.Click += new System.EventHandler(this.ManageBudgetsButton_Click);
            // 
            // chart1
            // 
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 66);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Spent";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Budget";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(353, 209);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Budgets";
            title2.Text = "Budgets";
            this.chart1.Titles.Add(title2);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(377, 287);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Menu = this.mainMenu1;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeBudgetManagement()
        {
            this.BudgetButton = new System.Windows.Forms.Button();
            this.FoodBudgetButton = new System.Windows.Forms.Button();
            this.ChangeBudgetText = new System.Windows.Forms.NumericUpDown();
            this.ChangeFoodBudgetText = new System.Windows.Forms.NumericUpDown();
            this.FoodBudgetLabel = new System.Windows.Forms.Label();
            this.CurrentBudget = new System.Windows.Forms.Label();
            this.RemainingFoodLabel = new System.Windows.Forms.Label();
            this.RemainingBudgetLabel = new System.Windows.Forms.Label();
            this.BudgetIdentifier = new System.Windows.Forms.Label();
            this.BudgetRemainingIdentifier = new System.Windows.Forms.Label();
            this.FoodRemainingIdentifier = new System.Windows.Forms.Label();
            this.FinalLeftOverBudget = new System.Windows.Forms.Label();
            this.FoodIdentifier = new System.Windows.Forms.Label();
            this.DividerX = new System.Windows.Forms.Label();
            this.DividerXBottom = new System.Windows.Forms.Label();
            this.DividerY = new System.Windows.Forms.Label();
            this.SubTitleBudgetLabel = new System.Windows.Forms.Label();
            this.SubTitleFoodLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.ChangeBudgetText)).BeginInit();
            // 
            // BudgetButton
            // 
            this.BudgetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetButton.Location = new System.Drawing.Point(7, 200);
            this.BudgetButton.Name = "BudgetButton";
            this.BudgetButton.Size = new System.Drawing.Size(100, 25);
            this.BudgetButton.TabIndex = 3;
            this.BudgetButton.Text = "Change Budget";
            this.BudgetButton.UseVisualStyleBackColor = true;
            this.BudgetButton.Click += new System.EventHandler(this.BudgetButton_Click);
            // 
            // FoodBudgetButton
            // 
            this.FoodBudgetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodBudgetButton.Location = new System.Drawing.Point(205, 200);
            this.FoodBudgetButton.Name = "FoodBudgetButton";
            this.FoodBudgetButton.Size = new System.Drawing.Size(100, 25);
            this.FoodBudgetButton.TabIndex = 3;
            this.FoodBudgetButton.Text = "Set Food";
            this.FoodBudgetButton.UseVisualStyleBackColor = true;
            this.FoodBudgetButton.Click += new System.EventHandler(this.FoodBudgetButton_Click);
            // 
            // ChangeBudgetText
            // 
            this.ChangeBudgetText.DecimalPlaces = 2;
            this.ChangeBudgetText.Location = new System.Drawing.Point(115, 202);
            this.ChangeBudgetText.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ChangeBudgetText.Name = "ChangeBudgetText";
            this.ChangeBudgetText.Size = new System.Drawing.Size(60, 20);
            this.ChangeBudgetText.TabIndex = 8;
            // 
            // ChangeFoodBudgetText
            // 
            this.ChangeFoodBudgetText.DecimalPlaces = 2;
            this.ChangeFoodBudgetText.Location = new System.Drawing.Point(315, 202);
            this.ChangeFoodBudgetText.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ChangeFoodBudgetText.Name = "ChangeFoodBudgetText";
            this.ChangeFoodBudgetText.Size = new System.Drawing.Size(60, 20);
            this.ChangeFoodBudgetText.TabIndex = 8;
            // 
            // SubTitleBudgetLabel
            // 
            this.SubTitleBudgetLabel.AutoSize = true;
            this.SubTitleBudgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTitleBudgetLabel.Location = new System.Drawing.Point(20, 70);
            this.SubTitleBudgetLabel.Name = "SubTitleBudgetLabel";
            this.SubTitleBudgetLabel.Size = new System.Drawing.Size(160, 17);
            this.SubTitleBudgetLabel.TabIndex = 5;
            this.SubTitleBudgetLabel.Text = "Monthly Budget";
            this.SubTitleBudgetLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // SubTitleFoodLabel
            // 
            this.SubTitleFoodLabel.AutoSize = true;
            this.SubTitleFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTitleFoodLabel.Location = new System.Drawing.Point(230, 70);
            this.SubTitleFoodLabel.Name = "SubTitleFoodLabel";
            this.SubTitleFoodLabel.Size = new System.Drawing.Size(160, 17);
            this.SubTitleFoodLabel.TabIndex = 5;
            this.SubTitleFoodLabel.Text = "Food Budget";
            this.SubTitleFoodLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // FoodBudgetLabel
            // 
            this.FoodBudgetLabel.AutoSize = true;
            this.FoodBudgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodBudgetLabel.Location = new System.Drawing.Point(210, 134);
            this.FoodBudgetLabel.Name = "FoodBudgetLabel";
            this.FoodBudgetLabel.Size = new System.Drawing.Size(160, 17);
            this.FoodBudgetLabel.TabIndex = 5;
            this.FoodBudgetLabel.Text = "Current Budget:";
            this.FoodBudgetLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // CurrentBudget
            // 
            this.CurrentBudget.AutoSize = true;
            this.CurrentBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBudget.Location = new System.Drawing.Point(10, 134);
            this.CurrentBudget.Name = "CurrentBudget";
            this.CurrentBudget.Size = new System.Drawing.Size(156, 17);
            this.CurrentBudget.TabIndex = 6;
            this.CurrentBudget.Text = "Current Budget:";
            this.CurrentBudget.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // RemainingBudgetLabel
            // 
            this.RemainingBudgetLabel.AutoSize = true;
            this.RemainingBudgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingBudgetLabel.Location = new System.Drawing.Point(10, 164);
            this.RemainingBudgetLabel.Name = "RemainingBudgetLabel";
            this.RemainingBudgetLabel.Size = new System.Drawing.Size(156, 17);
            this.RemainingBudgetLabel.TabIndex = 6;
            this.RemainingBudgetLabel.Text = "Remaining Budget:";
            this.RemainingBudgetLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // RemainingFoodLabel
            // 
            this.RemainingFoodLabel.AutoSize = true;
            this.RemainingFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingFoodLabel.Location = new System.Drawing.Point(210, 164);
            this.RemainingFoodLabel.Name = "RemainingFoodLabel";
            this.RemainingFoodLabel.Size = new System.Drawing.Size(156, 17);
            this.RemainingFoodLabel.TabIndex = 6;
            this.RemainingFoodLabel.Text = "Remaining Food:";
            this.RemainingFoodLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // BudgetIdentifier
            // 
            this.BudgetIdentifier.AutoSize = true;
            this.BudgetIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetIdentifier.Location = new System.Drawing.Point(120, 134);
            this.BudgetIdentifier.Name = "BudgetIdentifier";
            this.BudgetIdentifier.Size = new System.Drawing.Size(16, 17);
            this.BudgetIdentifier.TabIndex = 7;
            this.BudgetIdentifier.Text = "£";
            this.BudgetIdentifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // FoodIdentifier
            // 
            this.FoodIdentifier.AutoSize = true;
            this.FoodIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodIdentifier.Location = new System.Drawing.Point(310, 134);
            this.FoodIdentifier.Name = "FoodIdentifier";
            this.FoodIdentifier.Size = new System.Drawing.Size(16, 17);
            this.FoodIdentifier.TabIndex = 7;
            this.FoodIdentifier.Text = "£";
            this.FoodIdentifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // BudgetRemainingIdentifier
            // 
            this.BudgetRemainingIdentifier.AutoSize = true;
            this.BudgetRemainingIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetRemainingIdentifier.Location = new System.Drawing.Point(120, 164);
            this.BudgetRemainingIdentifier.Name = "BudgetRemainingIdentifier";
            this.BudgetRemainingIdentifier.Size = new System.Drawing.Size(16, 17);
            this.BudgetRemainingIdentifier.TabIndex = 9;
            this.BudgetRemainingIdentifier.Text = "£";
            this.BudgetRemainingIdentifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // FoodRemainingIdentifier
            // 
            this.FoodRemainingIdentifier.AutoSize = true;
            this.FoodRemainingIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodRemainingIdentifier.Location = new System.Drawing.Point(310, 164);
            this.FoodRemainingIdentifier.Name = "FoodRemainingIdentifier";
            this.FoodRemainingIdentifier.Size = new System.Drawing.Size(16, 17);
            this.FoodRemainingIdentifier.TabIndex = 9;
            this.FoodRemainingIdentifier.Text = "£";
            this.FoodRemainingIdentifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // FinalLeftOverBudget
            // 
            this.FinalLeftOverBudget.AutoSize = true;
            this.FinalLeftOverBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalLeftOverBudget.Location = new System.Drawing.Point(205, 255);
            this.FinalLeftOverBudget.Name = "FinalLeftOverBudget";
            this.FinalLeftOverBudget.Size = new System.Drawing.Size(16, 17);
            this.FinalLeftOverBudget.TabIndex = 9;
            this.FinalLeftOverBudget.Text = "Total Remaining";
            this.FinalLeftOverBudget.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // DividerXTop
            // 
            this.DividerX.BackColor = System.Drawing.Color.LightGray;
            this.DividerX.Location = new System.Drawing.Point(-2, 100);
            this.DividerX.Name = "DividerX";
            this.DividerX.Size = new System.Drawing.Size(400, 13);
            this.DividerX.TabIndex = 7;
            // 
            // DividerXBottom
            // 
            this.DividerXBottom.BackColor = System.Drawing.Color.LightGray;
            this.DividerXBottom.Location = new System.Drawing.Point(-2, 230);
            this.DividerXBottom.Name = "DividerXBottom";
            this.DividerXBottom.Size = new System.Drawing.Size(400, 13);
            this.DividerXBottom.TabIndex = 7;
            // 
            // DividerY
            // 
            this.DividerY.BackColor = System.Drawing.Color.LightGray;
            this.DividerY.Location = new System.Drawing.Point(185, 74);
            this.DividerY.Name = "DividerY";
            this.DividerY.Size = new System.Drawing.Size(13, 220);
            this.DividerY.TabIndex = 8;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(40, 255);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 25);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            //
            // Title
            //
            this.TitleLabel.Location = new System.Drawing.Point(5, 9);
            this.TitleLabel.Text = "Budget Manager";
            // 
            // Homepage
            // 
            this.ClientSize = new System.Drawing.Size(385, 287);

            this.Controls.Add(this.ChangeBudgetText);
            this.Controls.Add(this.ChangeFoodBudgetText);
            this.Controls.Add(this.BudgetButton);
            this.Controls.Add(this.FoodBudgetButton);
            this.Controls.Add(this.SubTitleBudgetLabel);
            this.Controls.Add(this.SubTitleFoodLabel);
            this.Controls.Add(this.BudgetRemainingIdentifier);
            this.Controls.Add(this.FoodRemainingIdentifier);
            this.Controls.Add(this.FinalLeftOverBudget);
            this.Controls.Add(this.BudgetIdentifier);
            this.Controls.Add(this.FoodIdentifier);
            this.Controls.Add(this.RemainingBudgetLabel);
            this.Controls.Add(this.CurrentBudget);
            this.Controls.Add(this.CurrentBudget);
            this.Controls.Add(this.FoodBudgetLabel);
            this.Controls.Add(this.DividerY);
            this.Controls.Add(this.DividerX);
            this.Controls.Add(this.DividerXBottom);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RemainingFoodLabel);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeBudgetText)).EndInit();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown ChangeBudgetText;
        private System.Windows.Forms.NumericUpDown ChangeFoodBudgetText;

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubTitleBudgetLabel;
        private System.Windows.Forms.Label SubTitleFoodLabel;
        private System.Windows.Forms.Label FoodBudgetLabel;
        private System.Windows.Forms.Label CurrentBudget;
        private System.Windows.Forms.Label RemainingBudgetLabel;
        private System.Windows.Forms.Label BudgetIdentifier;
        private System.Windows.Forms.Label RemainingFoodLabel;
        private System.Windows.Forms.Label BudgetRemainingIdentifier;
        private System.Windows.Forms.Label FoodRemainingIdentifier;
        private System.Windows.Forms.Label FoodIdentifier;
        private System.Windows.Forms.Label FinalLeftOverBudget;
        private System.Windows.Forms.Button BudgetButton;
        private System.Windows.Forms.Button FoodBudgetButton;
        private System.Windows.Forms.Button BackButton;

        private System.Windows.Forms.Label DividerX;
        private System.Windows.Forms.Label DividerXBottom;
        private System.Windows.Forms.Label DividerY;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem AddBillsButton;
        private System.Windows.Forms.MenuItem ViewBillsButton;
        private System.Windows.Forms.MenuItem ManageBudgetsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}