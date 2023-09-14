namespace AirTicketRequests_Coursework
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.table = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortFlightNumber = new System.Windows.Forms.Button();
            this.sortDate = new System.Windows.Forms.Button();
            this.textBoxFlightNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(793, 416);
            this.table.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Номер рейса";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата вылета";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Место назначения";
            this.Column3.Name = "Column3";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 434);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(217, 51);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddFlightTicket);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 491);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(217, 51);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteFlightTicket);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортировка по номеру рейса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сортировка по дате вылета:";
            // 
            // sortFlightNumber
            // 
            this.sortFlightNumber.Location = new System.Drawing.Point(255, 476);
            this.sortFlightNumber.Name = "sortFlightNumber";
            this.sortFlightNumber.Size = new System.Drawing.Size(225, 66);
            this.sortFlightNumber.TabIndex = 5;
            this.sortFlightNumber.Text = "Сортировка";
            this.sortFlightNumber.UseVisualStyleBackColor = true;
            this.sortFlightNumber.Click += new System.EventHandler(this.SortFlightNumber);
            // 
            // sortDate
            // 
            this.sortDate.Location = new System.Drawing.Point(511, 476);
            this.sortDate.Name = "sortDate";
            this.sortDate.Size = new System.Drawing.Size(225, 66);
            this.sortDate.TabIndex = 6;
            this.sortDate.Text = "Сортировка";
            this.sortDate.UseVisualStyleBackColor = true;
            this.sortDate.Click += new System.EventHandler(this.SortDate);
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Location = new System.Drawing.Point(255, 450);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(225, 20);
            this.textBoxFlightNumber.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(511, 450);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.Location = new System.Drawing.Point(742, 476);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(61, 66);
            this.clearFiltersButton.TabIndex = 9;
            this.clearFiltersButton.Text = "Очистка";
            this.clearFiltersButton.UseVisualStyleBackColor = true;
            this.clearFiltersButton.Click += new System.EventHandler(this.ClearTable);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 550);
            this.Controls.Add(this.clearFiltersButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxFlightNumber);
            this.Controls.Add(this.sortDate);
            this.Controls.Add(this.sortFlightNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.table);
            this.MaximumSize = new System.Drawing.Size(831, 589);
            this.MinimumSize = new System.Drawing.Size(831, 589);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sortFlightNumber;
        private System.Windows.Forms.Button sortDate;
        private System.Windows.Forms.TextBox textBoxFlightNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button clearFiltersButton;
    }
}

