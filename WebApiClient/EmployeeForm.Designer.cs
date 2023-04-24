namespace EmployeeDetailsApp
{
    partial class EmployeeForm
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
            label1 = new Label();
            employeeGrid = new DataGridView();
            labelId = new Label();
            labelName = new Label();
            labelGender = new Label();
            labelEmail = new Label();
            labelStatus = new Label();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            genderTextBox = new TextBox();
            mailTextBox = new TextBox();
            statusTextBox = new TextBox();
            Insert = new Button();
            Update = new Button();
            Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(495, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 54);
            label1.TabIndex = 0;
            label1.Text = "Employee Details";
            // 
            // employeeGrid
            // 
            employeeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            employeeGrid.BackgroundColor = SystemColors.ActiveCaption;
            employeeGrid.BorderStyle = BorderStyle.Fixed3D;
            employeeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeGrid.GridColor = SystemColors.ActiveCaption;
            employeeGrid.Location = new Point(226, 74);
            employeeGrid.Name = "employeeGrid";
            employeeGrid.RowTemplate.Height = 25;
            employeeGrid.Size = new Size(885, 227);
            employeeGrid.TabIndex = 2;
            employeeGrid.RowHeaderMouseClick += EmployeeGrid_RowHeaderMouseClick;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(178, 325);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 15);
            labelId.TabIndex = 3;
            labelId.Text = "ID";
            labelId.Visible = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(178, 371);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 4;
            labelName.Text = "Name";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(178, 415);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(45, 15);
            labelGender.TabIndex = 5;
            labelGender.Text = "Gender";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(178, 458);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(43, 15);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Mail Id";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(178, 501);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(293, 317);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(399, 23);
            idTextBox.TabIndex = 8;
            idTextBox.Visible = false;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(293, 363);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(399, 23);
            nameTextBox.TabIndex = 9;
            // 
            // genderTextBox
            // 
            genderTextBox.Location = new Point(293, 407);
            genderTextBox.Name = "genderTextBox";
            genderTextBox.Size = new Size(399, 23);
            genderTextBox.TabIndex = 10;
            // 
            // mailTextBox
            // 
            mailTextBox.Location = new Point(293, 450);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(399, 23);
            mailTextBox.TabIndex = 11;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(293, 493);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(399, 23);
            statusTextBox.TabIndex = 12;
            // 
            // Insert
            // 
            Insert.Location = new Point(786, 450);
            Insert.Name = "Insert";
            Insert.Size = new Size(105, 48);
            Insert.TabIndex = 13;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += EmployeeInsertOrUpdate;
            // 
            // Update
            // 
            Update.Location = new Point(943, 450);
            Update.Name = "Update";
            Update.Size = new Size(91, 48);
            Update.TabIndex = 14;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += EmployeeInsertOrUpdate;
            // 
            // Delete
            // 
            Delete.Location = new Point(1080, 450);
            Delete.Name = "Delete";
            Delete.Size = new Size(91, 48);
            Delete.TabIndex = 15;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += DeleteEmployee;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 527);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Insert);
            Controls.Add(statusTextBox);
            Controls.Add(mailTextBox);
            Controls.Add(genderTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(labelStatus);
            Controls.Add(labelEmail);
            Controls.Add(labelGender);
            Controls.Add(labelName);
            Controls.Add(labelId);
            Controls.Add(employeeGrid);
            Controls.Add(label1);
            Name = "EmployeeForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)employeeGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelId;
        private Label labelName;
        private Label labelGender;
        private Label labelEmail;
        private Label labelStatus;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox genderTextBox;
        private TextBox mailTextBox;
        private TextBox statusTextBox;
        private Button Insert;
        private Button Update;
        private Button Delete;
        private DataGridView employee;
        private DataGridView employeeGrid;
    }
}