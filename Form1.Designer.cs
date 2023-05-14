namespace CSAssignmentEmp
{
    partial class Form1
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
            this.empLbl = new System.Windows.Forms.Label();
            this.depLbl = new System.Windows.Forms.Label();
            this.worksLbl = new System.Windows.Forms.Label();
            this.projectLbl = new System.Windows.Forms.Label();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.departmentListBox = new System.Windows.Forms.ListBox();
            this.worksListBox = new System.Windows.Forms.ListBox();
            this.projectListBox = new System.Windows.Forms.ListBox();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.EmpTblGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteEmpBtn = new System.Windows.Forms.Button();
            this.updateEmpBtn = new System.Windows.Forms.Button();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.depTbleGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteDeptBtn = new System.Windows.Forms.Button();
            this.updateDeptBtn = new System.Windows.Forms.Button();
            this.addDeptBtn = new System.Windows.Forms.Button();
            this.deptNameTxtBox = new System.Windows.Forms.TextBox();
            this.deptNoTxtBox = new System.Windows.Forms.TextBox();
            this.deptNameLbl = new System.Windows.Forms.Label();
            this.deptNoLbl = new System.Windows.Forms.Label();
            this.worksGroupBox = new System.Windows.Forms.GroupBox();
            this.displayWorksBtn = new System.Windows.Forms.Button();
            this.worksListView = new System.Windows.Forms.ListView();
            this.projectDataGrid = new System.Windows.Forms.DataGridView();
            this.projectNoLbl = new System.Windows.Forms.Label();
            this.projectNameLbl = new System.Windows.Forms.Label();
            this.projectNoTxtBox = new System.Windows.Forms.TextBox();
            this.projectNameTxtBox = new System.Windows.Forms.TextBox();
            this.projectsGroupBox = new System.Windows.Forms.GroupBox();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.updateProjectBtn = new System.Windows.Forms.Button();
            this.deleteProjectBtn = new System.Windows.Forms.Button();
            this.updateDBFromGridBtn = new System.Windows.Forms.Button();
            this.showDBInGridBtn = new System.Windows.Forms.Button();
            this.EmpTblGroupBox.SuspendLayout();
            this.depTbleGroupBox.SuspendLayout();
            this.worksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGrid)).BeginInit();
            this.projectsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // empLbl
            // 
            this.empLbl.AutoSize = true;
            this.empLbl.Location = new System.Drawing.Point(89, 26);
            this.empLbl.Name = "empLbl";
            this.empLbl.Size = new System.Drawing.Size(69, 16);
            this.empLbl.TabIndex = 0;
            this.empLbl.Text = "Employee";
            // 
            // depLbl
            // 
            this.depLbl.AutoSize = true;
            this.depLbl.Location = new System.Drawing.Point(350, 26);
            this.depLbl.Name = "depLbl";
            this.depLbl.Size = new System.Drawing.Size(84, 16);
            this.depLbl.TabIndex = 1;
            this.depLbl.Text = "Departments";
            // 
            // worksLbl
            // 
            this.worksLbl.AutoSize = true;
            this.worksLbl.Location = new System.Drawing.Point(636, 26);
            this.worksLbl.Name = "worksLbl";
            this.worksLbl.Size = new System.Drawing.Size(70, 16);
            this.worksLbl.TabIndex = 2;
            this.worksLbl.Text = "Works_On";
            // 
            // projectLbl
            // 
            this.projectLbl.AutoSize = true;
            this.projectLbl.Location = new System.Drawing.Point(906, 26);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(56, 16);
            this.projectLbl.TabIndex = 3;
            this.projectLbl.Text = "Projects";
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 16;
            this.employeeListBox.Location = new System.Drawing.Point(33, 45);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(212, 100);
            this.employeeListBox.TabIndex = 4;
            // 
            // departmentListBox
            // 
            this.departmentListBox.FormattingEnabled = true;
            this.departmentListBox.ItemHeight = 16;
            this.departmentListBox.Location = new System.Drawing.Point(302, 45);
            this.departmentListBox.Name = "departmentListBox";
            this.departmentListBox.Size = new System.Drawing.Size(212, 100);
            this.departmentListBox.TabIndex = 5;
            // 
            // worksListBox
            // 
            this.worksListBox.FormattingEnabled = true;
            this.worksListBox.ItemHeight = 16;
            this.worksListBox.Location = new System.Drawing.Point(576, 45);
            this.worksListBox.Name = "worksListBox";
            this.worksListBox.Size = new System.Drawing.Size(212, 100);
            this.worksListBox.TabIndex = 6;
            // 
            // projectListBox
            // 
            this.projectListBox.FormattingEnabled = true;
            this.projectListBox.ItemHeight = 16;
            this.projectListBox.Location = new System.Drawing.Point(851, 45);
            this.projectListBox.Name = "projectListBox";
            this.projectListBox.Size = new System.Drawing.Size(212, 100);
            this.projectListBox.TabIndex = 7;
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Location = new System.Drawing.Point(33, 161);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(1030, 32);
            this.loadDataBtn.TabIndex = 8;
            this.loadDataBtn.Text = "Load data in all tables (Reader)";
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // EmpTblGroupBox
            // 
            this.EmpTblGroupBox.Controls.Add(this.deleteEmpBtn);
            this.EmpTblGroupBox.Controls.Add(this.updateEmpBtn);
            this.EmpTblGroupBox.Controls.Add(this.addEmpBtn);
            this.EmpTblGroupBox.Controls.Add(this.lastNameTxtBox);
            this.EmpTblGroupBox.Controls.Add(this.firstNameTxtBox);
            this.EmpTblGroupBox.Controls.Add(this.lastNamelbl);
            this.EmpTblGroupBox.Controls.Add(this.firstNameLbl);
            this.EmpTblGroupBox.Location = new System.Drawing.Point(33, 220);
            this.EmpTblGroupBox.Name = "EmpTblGroupBox";
            this.EmpTblGroupBox.Size = new System.Drawing.Size(293, 169);
            this.EmpTblGroupBox.TabIndex = 9;
            this.EmpTblGroupBox.TabStop = false;
            this.EmpTblGroupBox.Text = "Employee Table";
            // 
            // deleteEmpBtn
            // 
            this.deleteEmpBtn.Location = new System.Drawing.Point(203, 123);
            this.deleteEmpBtn.Name = "deleteEmpBtn";
            this.deleteEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteEmpBtn.TabIndex = 10;
            this.deleteEmpBtn.Text = "Delete";
            this.deleteEmpBtn.UseVisualStyleBackColor = true;
            this.deleteEmpBtn.Click += new System.EventHandler(this.deleteEmpBtn_Click);
            // 
            // updateEmpBtn
            // 
            this.updateEmpBtn.Location = new System.Drawing.Point(106, 123);
            this.updateEmpBtn.Name = "updateEmpBtn";
            this.updateEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.updateEmpBtn.TabIndex = 10;
            this.updateEmpBtn.Text = "Update";
            this.updateEmpBtn.UseVisualStyleBackColor = true;
            this.updateEmpBtn.Click += new System.EventHandler(this.updateEmpBtn_Click);
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Location = new System.Drawing.Point(18, 123);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.addEmpBtn.TabIndex = 10;
            this.addEmpBtn.Text = "Add";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(93, 83);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(119, 22);
            this.lastNameTxtBox.TabIndex = 10;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(93, 41);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(119, 22);
            this.firstNameTxtBox.TabIndex = 10;
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Location = new System.Drawing.Point(15, 86);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(72, 16);
            this.lastNamelbl.TabIndex = 10;
            this.lastNamelbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(15, 44);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(72, 16);
            this.firstNameLbl.TabIndex = 10;
            this.firstNameLbl.Text = "First Name";
            // 
            // depTbleGroupBox
            // 
            this.depTbleGroupBox.Controls.Add(this.deleteDeptBtn);
            this.depTbleGroupBox.Controls.Add(this.updateDeptBtn);
            this.depTbleGroupBox.Controls.Add(this.addDeptBtn);
            this.depTbleGroupBox.Controls.Add(this.deptNameTxtBox);
            this.depTbleGroupBox.Controls.Add(this.deptNoTxtBox);
            this.depTbleGroupBox.Controls.Add(this.deptNameLbl);
            this.depTbleGroupBox.Controls.Add(this.deptNoLbl);
            this.depTbleGroupBox.Location = new System.Drawing.Point(353, 220);
            this.depTbleGroupBox.Name = "depTbleGroupBox";
            this.depTbleGroupBox.Size = new System.Drawing.Size(293, 169);
            this.depTbleGroupBox.TabIndex = 10;
            this.depTbleGroupBox.TabStop = false;
            this.depTbleGroupBox.Text = "Department Table";
            // 
            // deleteDeptBtn
            // 
            this.deleteDeptBtn.Location = new System.Drawing.Point(201, 109);
            this.deleteDeptBtn.Name = "deleteDeptBtn";
            this.deleteDeptBtn.Size = new System.Drawing.Size(75, 54);
            this.deleteDeptBtn.TabIndex = 6;
            this.deleteDeptBtn.Text = "Delete (Stored)";
            this.deleteDeptBtn.UseVisualStyleBackColor = true;
            this.deleteDeptBtn.Click += new System.EventHandler(this.deleteDeptBtn_Click);
            // 
            // updateDeptBtn
            // 
            this.updateDeptBtn.Location = new System.Drawing.Point(110, 109);
            this.updateDeptBtn.Name = "updateDeptBtn";
            this.updateDeptBtn.Size = new System.Drawing.Size(75, 54);
            this.updateDeptBtn.TabIndex = 5;
            this.updateDeptBtn.Text = "Update (Stored)";
            this.updateDeptBtn.UseVisualStyleBackColor = true;
            this.updateDeptBtn.Click += new System.EventHandler(this.updateDeptBtn_Click);
            // 
            // addDeptBtn
            // 
            this.addDeptBtn.Location = new System.Drawing.Point(19, 108);
            this.addDeptBtn.Name = "addDeptBtn";
            this.addDeptBtn.Size = new System.Drawing.Size(75, 55);
            this.addDeptBtn.TabIndex = 4;
            this.addDeptBtn.Text = "Add (Stored)";
            this.addDeptBtn.UseVisualStyleBackColor = true;
            this.addDeptBtn.Click += new System.EventHandler(this.addDeptBtn_Click);
            // 
            // deptNameTxtBox
            // 
            this.deptNameTxtBox.Location = new System.Drawing.Point(110, 68);
            this.deptNameTxtBox.Name = "deptNameTxtBox";
            this.deptNameTxtBox.Size = new System.Drawing.Size(111, 22);
            this.deptNameTxtBox.TabIndex = 3;
            // 
            // deptNoTxtBox
            // 
            this.deptNoTxtBox.Location = new System.Drawing.Point(110, 32);
            this.deptNoTxtBox.Name = "deptNoTxtBox";
            this.deptNoTxtBox.Size = new System.Drawing.Size(111, 22);
            this.deptNoTxtBox.TabIndex = 2;
            // 
            // deptNameLbl
            // 
            this.deptNameLbl.AutoSize = true;
            this.deptNameLbl.Location = new System.Drawing.Point(28, 71);
            this.deptNameLbl.Name = "deptNameLbl";
            this.deptNameLbl.Size = new System.Drawing.Size(76, 16);
            this.deptNameLbl.TabIndex = 1;
            this.deptNameLbl.Text = "Dept Name";
            // 
            // deptNoLbl
            // 
            this.deptNoLbl.AutoSize = true;
            this.deptNoLbl.Location = new System.Drawing.Point(47, 35);
            this.deptNoLbl.Name = "deptNoLbl";
            this.deptNoLbl.Size = new System.Drawing.Size(57, 16);
            this.deptNoLbl.TabIndex = 0;
            this.deptNoLbl.Text = "Dept No";
            // 
            // worksGroupBox
            // 
            this.worksGroupBox.Controls.Add(this.displayWorksBtn);
            this.worksGroupBox.Controls.Add(this.worksListView);
            this.worksGroupBox.Location = new System.Drawing.Point(669, 220);
            this.worksGroupBox.Name = "worksGroupBox";
            this.worksGroupBox.Size = new System.Drawing.Size(491, 216);
            this.worksGroupBox.TabIndex = 11;
            this.worksGroupBox.TabStop = false;
            this.worksGroupBox.Text = "Works On Table";
            // 
            // displayWorksBtn
            // 
            this.displayWorksBtn.Location = new System.Drawing.Point(203, 175);
            this.displayWorksBtn.Name = "displayWorksBtn";
            this.displayWorksBtn.Size = new System.Drawing.Size(75, 35);
            this.displayWorksBtn.TabIndex = 1;
            this.displayWorksBtn.Text = "Display";
            this.displayWorksBtn.UseVisualStyleBackColor = true;
            this.displayWorksBtn.Click += new System.EventHandler(this.displayWorksBtn_Click);
            // 
            // worksListView
            // 
            this.worksListView.HideSelection = false;
            this.worksListView.Location = new System.Drawing.Point(6, 21);
            this.worksListView.Name = "worksListView";
            this.worksListView.Size = new System.Drawing.Size(479, 148);
            this.worksListView.TabIndex = 0;
            this.worksListView.UseCompatibleStateImageBehavior = false;
            // 
            // projectDataGrid
            // 
            this.projectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGrid.Location = new System.Drawing.Point(18, 36);
            this.projectDataGrid.Name = "projectDataGrid";
            this.projectDataGrid.RowHeadersWidth = 51;
            this.projectDataGrid.RowTemplate.Height = 24;
            this.projectDataGrid.Size = new System.Drawing.Size(613, 172);
            this.projectDataGrid.TabIndex = 12;
            // 
            // projectNoLbl
            // 
            this.projectNoLbl.AutoSize = true;
            this.projectNoLbl.Location = new System.Drawing.Point(800, 71);
            this.projectNoLbl.Name = "projectNoLbl";
            this.projectNoLbl.Size = new System.Drawing.Size(70, 16);
            this.projectNoLbl.TabIndex = 13;
            this.projectNoLbl.Text = "Project No";
            // 
            // projectNameLbl
            // 
            this.projectNameLbl.AutoSize = true;
            this.projectNameLbl.Location = new System.Drawing.Point(781, 106);
            this.projectNameLbl.Name = "projectNameLbl";
            this.projectNameLbl.Size = new System.Drawing.Size(89, 16);
            this.projectNameLbl.TabIndex = 14;
            this.projectNameLbl.Text = "Project Name";
            // 
            // projectNoTxtBox
            // 
            this.projectNoTxtBox.Location = new System.Drawing.Point(886, 65);
            this.projectNoTxtBox.Name = "projectNoTxtBox";
            this.projectNoTxtBox.Size = new System.Drawing.Size(115, 22);
            this.projectNoTxtBox.TabIndex = 15;
            // 
            // projectNameTxtBox
            // 
            this.projectNameTxtBox.Location = new System.Drawing.Point(886, 103);
            this.projectNameTxtBox.Name = "projectNameTxtBox";
            this.projectNameTxtBox.Size = new System.Drawing.Size(115, 22);
            this.projectNameTxtBox.TabIndex = 16;
            // 
            // projectsGroupBox
            // 
            this.projectsGroupBox.Controls.Add(this.showDBInGridBtn);
            this.projectsGroupBox.Controls.Add(this.updateDBFromGridBtn);
            this.projectsGroupBox.Controls.Add(this.deleteProjectBtn);
            this.projectsGroupBox.Controls.Add(this.updateProjectBtn);
            this.projectsGroupBox.Controls.Add(this.addProjectBtn);
            this.projectsGroupBox.Controls.Add(this.projectDataGrid);
            this.projectsGroupBox.Controls.Add(this.projectNameTxtBox);
            this.projectsGroupBox.Controls.Add(this.projectNameLbl);
            this.projectsGroupBox.Controls.Add(this.projectNoTxtBox);
            this.projectsGroupBox.Controls.Add(this.projectNoLbl);
            this.projectsGroupBox.Location = new System.Drawing.Point(33, 442);
            this.projectsGroupBox.Name = "projectsGroupBox";
            this.projectsGroupBox.Size = new System.Drawing.Size(1121, 245);
            this.projectsGroupBox.TabIndex = 17;
            this.projectsGroupBox.TabStop = false;
            this.projectsGroupBox.Text = "Projects Table data grid using Adapter";
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(799, 153);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(75, 43);
            this.addProjectBtn.TabIndex = 17;
            this.addProjectBtn.Text = "Add (Stored)";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // updateProjectBtn
            // 
            this.updateProjectBtn.Location = new System.Drawing.Point(899, 153);
            this.updateProjectBtn.Name = "updateProjectBtn";
            this.updateProjectBtn.Size = new System.Drawing.Size(75, 43);
            this.updateProjectBtn.TabIndex = 18;
            this.updateProjectBtn.Text = "Update (Stored)";
            this.updateProjectBtn.UseVisualStyleBackColor = true;
            this.updateProjectBtn.Click += new System.EventHandler(this.updateProjectBtn_Click);
            // 
            // deleteProjectBtn
            // 
            this.deleteProjectBtn.Location = new System.Drawing.Point(995, 153);
            this.deleteProjectBtn.Name = "deleteProjectBtn";
            this.deleteProjectBtn.Size = new System.Drawing.Size(75, 43);
            this.deleteProjectBtn.TabIndex = 19;
            this.deleteProjectBtn.Text = "Delete (Stored)";
            this.deleteProjectBtn.UseVisualStyleBackColor = true;
            this.deleteProjectBtn.Click += new System.EventHandler(this.deleteProjectBtn_Click);
            // 
            // updateDBFromGridBtn
            // 
            this.updateDBFromGridBtn.Location = new System.Drawing.Point(642, 130);
            this.updateDBFromGridBtn.Name = "updateDBFromGridBtn";
            this.updateDBFromGridBtn.Size = new System.Drawing.Size(113, 78);
            this.updateDBFromGridBtn.TabIndex = 20;
            this.updateDBFromGridBtn.Text = "Update DB table based on current grid data";
            this.updateDBFromGridBtn.UseVisualStyleBackColor = true;
            this.updateDBFromGridBtn.Click += new System.EventHandler(this.updateDBFromGridBtn_Click);
            // 
            // showDBInGridBtn
            // 
            this.showDBInGridBtn.Location = new System.Drawing.Point(642, 40);
            this.showDBInGridBtn.Name = "showDBInGridBtn";
            this.showDBInGridBtn.Size = new System.Drawing.Size(113, 78);
            this.showDBInGridBtn.TabIndex = 21;
            this.showDBInGridBtn.Text = "Show DB table in the grid";
            this.showDBInGridBtn.UseVisualStyleBackColor = true;
            this.showDBInGridBtn.Click += new System.EventHandler(this.showDBInGridBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 715);
            this.Controls.Add(this.projectsGroupBox);
            this.Controls.Add(this.worksGroupBox);
            this.Controls.Add(this.depTbleGroupBox);
            this.Controls.Add(this.EmpTblGroupBox);
            this.Controls.Add(this.loadDataBtn);
            this.Controls.Add(this.projectListBox);
            this.Controls.Add(this.worksListBox);
            this.Controls.Add(this.departmentListBox);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.projectLbl);
            this.Controls.Add(this.worksLbl);
            this.Controls.Add(this.depLbl);
            this.Controls.Add(this.empLbl);
            this.Name = "Form1";
            this.Text = "Employees System App";
            this.EmpTblGroupBox.ResumeLayout(false);
            this.EmpTblGroupBox.PerformLayout();
            this.depTbleGroupBox.ResumeLayout(false);
            this.depTbleGroupBox.PerformLayout();
            this.worksGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGrid)).EndInit();
            this.projectsGroupBox.ResumeLayout(false);
            this.projectsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empLbl;
        private System.Windows.Forms.Label depLbl;
        private System.Windows.Forms.Label worksLbl;
        private System.Windows.Forms.Label projectLbl;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.ListBox departmentListBox;
        private System.Windows.Forms.ListBox worksListBox;
        private System.Windows.Forms.ListBox projectListBox;
        private System.Windows.Forms.Button loadDataBtn;
        private System.Windows.Forms.GroupBox EmpTblGroupBox;
        private System.Windows.Forms.Button deleteEmpBtn;
        private System.Windows.Forms.Button updateEmpBtn;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label lastNamelbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.GroupBox depTbleGroupBox;
        private System.Windows.Forms.Button deleteDeptBtn;
        private System.Windows.Forms.Button updateDeptBtn;
        private System.Windows.Forms.Button addDeptBtn;
        private System.Windows.Forms.TextBox deptNameTxtBox;
        private System.Windows.Forms.TextBox deptNoTxtBox;
        private System.Windows.Forms.Label deptNameLbl;
        private System.Windows.Forms.Label deptNoLbl;
        private System.Windows.Forms.GroupBox worksGroupBox;
        private System.Windows.Forms.Button displayWorksBtn;
        private System.Windows.Forms.ListView worksListView;
        private System.Windows.Forms.DataGridView projectDataGrid;
        private System.Windows.Forms.Label projectNoLbl;
        private System.Windows.Forms.Label projectNameLbl;
        private System.Windows.Forms.TextBox projectNoTxtBox;
        private System.Windows.Forms.TextBox projectNameTxtBox;
        private System.Windows.Forms.GroupBox projectsGroupBox;
        private System.Windows.Forms.Button deleteProjectBtn;
        private System.Windows.Forms.Button updateProjectBtn;
        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.Button showDBInGridBtn;
        private System.Windows.Forms.Button updateDBFromGridBtn;
    }
}

