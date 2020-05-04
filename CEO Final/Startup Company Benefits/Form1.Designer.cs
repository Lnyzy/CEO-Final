namespace Startup_Company_Benefits
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.CalculateYearlySalaryButton = new System.Windows.Forms.Button();
            this.CalculateRaiseButton = new System.Windows.Forms.Button();
            this.CalculatePTOButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.YearsWorkedTextBox = new System.Windows.Forms.TextBox();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RandomHourGenerator = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateBonus = new System.Windows.Forms.Button();
            this.CalculateAll = new System.Windows.Forms.Button();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.SaveEmployee = new System.Windows.Forms.Button();
            this.LoadEmployee = new System.Windows.Forms.Button();
            this.ClearEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.GridControlTab = new System.Windows.Forms.TabControl();
            this.EmployeeGridTab = new System.Windows.Forms.TabPage();
            this.InventoryGridTab = new System.Windows.Forms.TabPage();
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ClearItemButton = new System.Windows.Forms.Button();
            this.ItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.ItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.LoadItemButton = new System.Windows.Forms.Button();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yearly_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.GridControlTab.SuspendLayout();
            this.EmployeeGridTab.SuspendLayout();
            this.InventoryGridTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateYearlySalaryButton
            // 
            this.CalculateYearlySalaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateYearlySalaryButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateYearlySalaryButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculateYearlySalaryButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculateYearlySalaryButton.Image")));
            this.CalculateYearlySalaryButton.Location = new System.Drawing.Point(427, 22);
            this.CalculateYearlySalaryButton.Name = "CalculateYearlySalaryButton";
            this.CalculateYearlySalaryButton.Size = new System.Drawing.Size(167, 48);
            this.CalculateYearlySalaryButton.TabIndex = 0;
            this.CalculateYearlySalaryButton.Text = "Calculate Yearly Salary";
            this.CalculateYearlySalaryButton.UseVisualStyleBackColor = true;
            this.CalculateYearlySalaryButton.Click += new System.EventHandler(this.CalculateYearlySalary_Click);
            // 
            // CalculateRaiseButton
            // 
            this.CalculateRaiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateRaiseButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateRaiseButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculateRaiseButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculateRaiseButton.Image")));
            this.CalculateRaiseButton.Location = new System.Drawing.Point(427, 80);
            this.CalculateRaiseButton.Name = "CalculateRaiseButton";
            this.CalculateRaiseButton.Size = new System.Drawing.Size(167, 48);
            this.CalculateRaiseButton.TabIndex = 1;
            this.CalculateRaiseButton.Text = "Calculate Raise";
            this.CalculateRaiseButton.UseVisualStyleBackColor = true;
            this.CalculateRaiseButton.Click += new System.EventHandler(this.CalculateRaise_Click);
            // 
            // CalculatePTOButton
            // 
            this.CalculatePTOButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculatePTOButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatePTOButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculatePTOButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatePTOButton.Image")));
            this.CalculatePTOButton.Location = new System.Drawing.Point(427, 140);
            this.CalculatePTOButton.Name = "CalculatePTOButton";
            this.CalculatePTOButton.Size = new System.Drawing.Size(167, 48);
            this.CalculatePTOButton.TabIndex = 2;
            this.CalculatePTOButton.Text = "Calculate PTO";
            this.CalculatePTOButton.UseVisualStyleBackColor = true;
            this.CalculatePTOButton.Click += new System.EventHandler(this.CalculatePTO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hourly Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yearly Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Years Worked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Results";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(209, 96);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(170, 20);
            this.HoursTextBox.TabIndex = 8;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(209, 156);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(170, 20);
            this.SalaryTextBox.TabIndex = 9;
            // 
            // YearsWorkedTextBox
            // 
            this.YearsWorkedTextBox.Location = new System.Drawing.Point(209, 230);
            this.YearsWorkedTextBox.Name = "YearsWorkedTextBox";
            this.YearsWorkedTextBox.Size = new System.Drawing.Size(170, 20);
            this.YearsWorkedTextBox.TabIndex = 10;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ResultsTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.ResultsTextBox.Location = new System.Drawing.Point(209, 333);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.Size = new System.Drawing.Size(170, 73);
            this.ResultsTextBox.TabIndex = 11;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Image = global::Startup_Company_Benefits.Properties.Resources.Purple_Buttons;
            this.ExitButton.Location = new System.Drawing.Point(427, 350);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 56);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RandomHourGenerator
            // 
            this.RandomHourGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomHourGenerator.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomHourGenerator.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RandomHourGenerator.Image = ((System.Drawing.Image)(resources.GetObject("RandomHourGenerator.Image")));
            this.RandomHourGenerator.Location = new System.Drawing.Point(615, 22);
            this.RandomHourGenerator.Name = "RandomHourGenerator";
            this.RandomHourGenerator.Size = new System.Drawing.Size(167, 48);
            this.RandomHourGenerator.TabIndex = 14;
            this.RandomHourGenerator.Text = "Random Hours";
            this.RandomHourGenerator.UseVisualStyleBackColor = true;
            this.RandomHourGenerator.Click += new System.EventHandler(this.RandomHourGenerator_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(209, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(170, 20);
            this.NameTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Employee Name";
            // 
            // CalculateBonus
            // 
            this.CalculateBonus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateBonus.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBonus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculateBonus.Image = ((System.Drawing.Image)(resources.GetObject("CalculateBonus.Image")));
            this.CalculateBonus.Location = new System.Drawing.Point(427, 202);
            this.CalculateBonus.Name = "CalculateBonus";
            this.CalculateBonus.Size = new System.Drawing.Size(167, 48);
            this.CalculateBonus.TabIndex = 17;
            this.CalculateBonus.Text = "Calculate Bonus";
            this.CalculateBonus.UseVisualStyleBackColor = true;
            this.CalculateBonus.Click += new System.EventHandler(this.CalculateBonus_Click);
            // 
            // CalculateAll
            // 
            this.CalculateAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateAll.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateAll.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculateAll.Image = ((System.Drawing.Image)(resources.GetObject("CalculateAll.Image")));
            this.CalculateAll.Location = new System.Drawing.Point(427, 267);
            this.CalculateAll.Name = "CalculateAll";
            this.CalculateAll.Size = new System.Drawing.Size(167, 48);
            this.CalculateAll.TabIndex = 18;
            this.CalculateAll.Text = "Calculate All";
            this.CalculateAll.UseVisualStyleBackColor = true;
            this.CalculateAll.Click += new System.EventHandler(this.CalculateAll_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AllowUserToAddRows = false;
            this.EmployeeGrid.AllowUserToDeleteRows = false;
            this.EmployeeGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_Name,
            this.Yearly_Salary,
            this.Raise,
            this.PTO,
            this.Bonus});
            this.EmployeeGrid.Location = new System.Drawing.Point(13, 170);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            this.EmployeeGrid.Size = new System.Drawing.Size(544, 202);
            this.EmployeeGrid.TabIndex = 19;
            // 
            // SaveEmployee
            // 
            this.SaveEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveEmployee.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveEmployee.Image = ((System.Drawing.Image)(resources.GetObject("SaveEmployee.Image")));
            this.SaveEmployee.Location = new System.Drawing.Point(198, 30);
            this.SaveEmployee.Name = "SaveEmployee";
            this.SaveEmployee.Size = new System.Drawing.Size(167, 48);
            this.SaveEmployee.TabIndex = 20;
            this.SaveEmployee.Text = "Save Employee";
            this.SaveEmployee.UseVisualStyleBackColor = true;
            this.SaveEmployee.Click += new System.EventHandler(this.SaveEmployee_Click);
            // 
            // LoadEmployee
            // 
            this.LoadEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadEmployee.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadEmployee.Image = ((System.Drawing.Image)(resources.GetObject("LoadEmployee.Image")));
            this.LoadEmployee.Location = new System.Drawing.Point(390, 30);
            this.LoadEmployee.Name = "LoadEmployee";
            this.LoadEmployee.Size = new System.Drawing.Size(167, 48);
            this.LoadEmployee.TabIndex = 21;
            this.LoadEmployee.Text = "Load Employee";
            this.LoadEmployee.UseVisualStyleBackColor = true;
            this.LoadEmployee.Click += new System.EventHandler(this.LoadEmployee_Click);
            // 
            // ClearEmployee
            // 
            this.ClearEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearEmployee.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearEmployee.Image = ((System.Drawing.Image)(resources.GetObject("ClearEmployee.Image")));
            this.ClearEmployee.Location = new System.Drawing.Point(198, 106);
            this.ClearEmployee.Name = "ClearEmployee";
            this.ClearEmployee.Size = new System.Drawing.Size(167, 48);
            this.ClearEmployee.TabIndex = 22;
            this.ClearEmployee.Text = "Clear Employee";
            this.ClearEmployee.UseVisualStyleBackColor = true;
            this.ClearEmployee.Click += new System.EventHandler(this.ClearEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployee.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("AddEmployee.Image")));
            this.AddEmployee.Location = new System.Drawing.Point(13, 30);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(167, 48);
            this.AddEmployee.TabIndex = 23;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // GridControlTab
            // 
            this.GridControlTab.Controls.Add(this.EmployeeGridTab);
            this.GridControlTab.Controls.Add(this.InventoryGridTab);
            this.GridControlTab.Location = new System.Drawing.Point(615, 76);
            this.GridControlTab.Name = "GridControlTab";
            this.GridControlTab.SelectedIndex = 0;
            this.GridControlTab.Size = new System.Drawing.Size(669, 426);
            this.GridControlTab.TabIndex = 24;
            // 
            // EmployeeGridTab
            // 
            this.EmployeeGridTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EmployeeGridTab.Controls.Add(this.EmployeeGrid);
            this.EmployeeGridTab.Controls.Add(this.SaveEmployee);
            this.EmployeeGridTab.Controls.Add(this.LoadEmployee);
            this.EmployeeGridTab.Controls.Add(this.AddEmployee);
            this.EmployeeGridTab.Controls.Add(this.ClearEmployee);
            this.EmployeeGridTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeeGridTab.Name = "EmployeeGridTab";
            this.EmployeeGridTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeGridTab.Size = new System.Drawing.Size(661, 400);
            this.EmployeeGridTab.TabIndex = 0;
            this.EmployeeGridTab.Text = "Employees";
            // 
            // InventoryGridTab
            // 
            this.InventoryGridTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.InventoryGridTab.Controls.Add(this.ItemGrid);
            this.InventoryGridTab.Controls.Add(this.AddItemButton);
            this.InventoryGridTab.Controls.Add(this.ClearItemButton);
            this.InventoryGridTab.Controls.Add(this.ItemPriceTextBox);
            this.InventoryGridTab.Controls.Add(this.ItemQuantityTextBox);
            this.InventoryGridTab.Controls.Add(this.ItemNameTextBox);
            this.InventoryGridTab.Controls.Add(this.label8);
            this.InventoryGridTab.Controls.Add(this.label7);
            this.InventoryGridTab.Controls.Add(this.label6);
            this.InventoryGridTab.Controls.Add(this.SaveItemButton);
            this.InventoryGridTab.Controls.Add(this.LoadItemButton);
            this.InventoryGridTab.Location = new System.Drawing.Point(4, 22);
            this.InventoryGridTab.Name = "InventoryGridTab";
            this.InventoryGridTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryGridTab.Size = new System.Drawing.Size(661, 400);
            this.InventoryGridTab.TabIndex = 1;
            this.InventoryGridTab.Text = "Inventory";
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.AllowUserToDeleteRows = false;
            this.ItemGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemQuantity,
            this.ItemPrice});
            this.ItemGrid.Location = new System.Drawing.Point(11, 236);
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.ReadOnly = true;
            this.ItemGrid.Size = new System.Drawing.Size(345, 150);
            this.ItemGrid.TabIndex = 35;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "Item Quantity";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddItemButton.Image = ((System.Drawing.Image)(resources.GetObject("AddItemButton.Image")));
            this.AddItemButton.Location = new System.Drawing.Point(416, 42);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(167, 48);
            this.AddItemButton.TabIndex = 34;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ClearItemButton
            // 
            this.ClearItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearItemButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearItemButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearItemButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearItemButton.Image")));
            this.ClearItemButton.Location = new System.Drawing.Point(416, 236);
            this.ClearItemButton.Name = "ClearItemButton";
            this.ClearItemButton.Size = new System.Drawing.Size(167, 48);
            this.ClearItemButton.TabIndex = 33;
            this.ClearItemButton.Text = "Clear Item";
            this.ClearItemButton.UseVisualStyleBackColor = true;
            this.ClearItemButton.Click += new System.EventHandler(this.ClearItemButton_Click);
            // 
            // ItemPriceTextBox
            // 
            this.ItemPriceTextBox.Location = new System.Drawing.Point(193, 185);
            this.ItemPriceTextBox.Name = "ItemPriceTextBox";
            this.ItemPriceTextBox.Size = new System.Drawing.Size(170, 20);
            this.ItemPriceTextBox.TabIndex = 32;
            // 
            // ItemQuantityTextBox
            // 
            this.ItemQuantityTextBox.Location = new System.Drawing.Point(193, 120);
            this.ItemQuantityTextBox.Name = "ItemQuantityTextBox";
            this.ItemQuantityTextBox.Size = new System.Drawing.Size(170, 20);
            this.ItemQuantityTextBox.TabIndex = 31;
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(193, 58);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.ItemNameTextBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "Item Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Item Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "Item Name";
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveItemButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveItemButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveItemButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveItemButton.Image")));
            this.SaveItemButton.Location = new System.Drawing.Point(416, 104);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(167, 48);
            this.SaveItemButton.TabIndex = 26;
            this.SaveItemButton.Text = "Save Item";
            this.SaveItemButton.UseVisualStyleBackColor = true;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // LoadItemButton
            // 
            this.LoadItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadItemButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadItemButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadItemButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadItemButton.Image")));
            this.LoadItemButton.Location = new System.Drawing.Point(416, 169);
            this.LoadItemButton.Name = "LoadItemButton";
            this.LoadItemButton.Size = new System.Drawing.Size(167, 48);
            this.LoadItemButton.TabIndex = 25;
            this.LoadItemButton.Text = "Load Item";
            this.LoadItemButton.UseVisualStyleBackColor = true;
            this.LoadItemButton.Click += new System.EventHandler(this.LoadItemButton_Click);
            // 
            // Employee_Name
            // 
            this.Employee_Name.HeaderText = "Employee Name";
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            // 
            // Yearly_Salary
            // 
            this.Yearly_Salary.HeaderText = "Yearly Salary";
            this.Yearly_Salary.Name = "Yearly_Salary";
            this.Yearly_Salary.ReadOnly = true;
            // 
            // Raise
            // 
            this.Raise.HeaderText = "Raise";
            this.Raise.Name = "Raise";
            this.Raise.ReadOnly = true;
            // 
            // PTO
            // 
            this.PTO.HeaderText = "PTO";
            this.PTO.Name = "PTO";
            this.PTO.ReadOnly = true;
            // 
            // Bonus
            // 
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            this.Bonus.ReadOnly = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1294, 508);
            this.Controls.Add(this.GridControlTab);
            this.Controls.Add(this.CalculateAll);
            this.Controls.Add(this.CalculateBonus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RandomHourGenerator);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.YearsWorkedTextBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculatePTOButton);
            this.Controls.Add(this.CalculateRaiseButton);
            this.Controls.Add(this.CalculateYearlySalaryButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.GridControlTab.ResumeLayout(false);
            this.EmployeeGridTab.ResumeLayout(false);
            this.InventoryGridTab.ResumeLayout(false);
            this.InventoryGridTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateYearlySalaryButton;
        private System.Windows.Forms.Button CalculateRaiseButton;
        private System.Windows.Forms.Button CalculatePTOButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox YearsWorkedTextBox;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RandomHourGenerator;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateBonus;
        private System.Windows.Forms.Button CalculateAll;
        private System.Windows.Forms.Button SaveEmployee;
        private System.Windows.Forms.Button LoadEmployee;
        private System.Windows.Forms.Button ClearEmployee;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.TabControl GridControlTab;
        private System.Windows.Forms.TabPage EmployeeGridTab;
        private System.Windows.Forms.TabPage InventoryGridTab;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.Button LoadItemButton;
        private System.Windows.Forms.TextBox ItemPriceTextBox;
        private System.Windows.Forms.TextBox ItemQuantityTextBox;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        public System.Windows.Forms.DataGridView EmployeeGrid;
        public System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yearly_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raise;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
    }
}

