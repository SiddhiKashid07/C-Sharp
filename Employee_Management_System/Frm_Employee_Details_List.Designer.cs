
namespace Employee_Management_System
{
    partial class frm_Employee_Details_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employee_Details_List));
            this.lbl_Employee_Details_List = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Employee_Details = new System.Windows.Forms.Button();
            this.dgv_Employee_Details_List = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disginationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_System_DBDataSet1 = new Employee_Management_System.Employee_Management_System_DBDataSet1();
            this.employee_DetailsTableAdapter = new Employee_Management_System.Employee_Management_System_DBDataSet1TableAdapters.Employee_DetailsTableAdapter();
            this.lbl_UName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Details_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details_List
            // 
            this.lbl_Employee_Details_List.AutoSize = true;
            this.lbl_Employee_Details_List.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_Employee_Details_List.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details_List.Location = new System.Drawing.Point(105, 34);
            this.lbl_Employee_Details_List.Name = "lbl_Employee_Details_List";
            this.lbl_Employee_Details_List.Size = new System.Drawing.Size(558, 79);
            this.lbl_Employee_Details_List.TabIndex = 2;
            this.lbl_Employee_Details_List.Text = "Employee Details List";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Logout.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Logout.Location = new System.Drawing.Point(720, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(62, 30);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Employee_Details
            // 
            this.btn_Employee_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Employee_Details.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_Details.Location = new System.Drawing.Point(290, 406);
            this.btn_Employee_Details.Name = "btn_Employee_Details";
            this.btn_Employee_Details.Size = new System.Drawing.Size(180, 33);
            this.btn_Employee_Details.TabIndex = 13;
            this.btn_Employee_Details.Text = "Employee Details";
            this.btn_Employee_Details.UseVisualStyleBackColor = false;
            this.btn_Employee_Details.Click += new System.EventHandler(this.btn_Employee_Details_Click);
            // 
            // dgv_Employee_Details_List
            // 
            this.dgv_Employee_Details_List.AllowUserToAddRows = false;
            this.dgv_Employee_Details_List.AllowUserToDeleteRows = false;
            this.dgv_Employee_Details_List.AutoGenerateColumns = false;
            this.dgv_Employee_Details_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_Details_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_Details_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.disginationDataGridViewTextBoxColumn});
            this.dgv_Employee_Details_List.DataSource = this.employeeDetailsBindingSource;
            this.dgv_Employee_Details_List.Location = new System.Drawing.Point(45, 157);
            this.dgv_Employee_Details_List.Name = "dgv_Employee_Details_List";
            this.dgv_Employee_Details_List.ReadOnly = true;
            this.dgv_Employee_Details_List.Size = new System.Drawing.Size(680, 219);
            this.dgv_Employee_Details_List.TabIndex = 14;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disginationDataGridViewTextBoxColumn
            // 
            this.disginationDataGridViewTextBoxColumn.DataPropertyName = "Disgination";
            this.disginationDataGridViewTextBoxColumn.HeaderText = "Disgination";
            this.disginationDataGridViewTextBoxColumn.Name = "disginationDataGridViewTextBoxColumn";
            this.disginationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_Management_System_DBDataSet1;
            // 
            // employee_Management_System_DBDataSet1
            // 
            this.employee_Management_System_DBDataSet1.DataSetName = "Employee_Management_System_DBDataSet1";
            this.employee_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_UName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_UName.Location = new System.Drawing.Point(0, 0);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(112, 16);
            this.lbl_UName.TabIndex = 15;
            this.lbl_UName.Text = "LoggedInUser";
            // 
            // frm_Employee_Details_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.dgv_Employee_Details_List);
            this.Controls.Add(this.btn_Employee_Details);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Employee_Details_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee_Details_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details List";
            this.Load += new System.EventHandler(this.frm_Employee_Details_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Details_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details_List;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Employee_Details;
        private System.Windows.Forms.DataGridView dgv_Employee_Details_List;
        private Employee_Management_System_DBDataSet1 employee_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Management_System_DBDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disginationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_UName;
    }
}