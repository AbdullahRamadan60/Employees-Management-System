using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // ADO.Net --> To deal with DBs
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace CSAssignmentEmp
{
    public partial class Form1 : Form
    {
        SqlDataAdapter myadapter;
        DataSet dataSet;

        //PUT HERE YOUR DATA CONNECTION STRING 
        string connectionString = "Data Source=DESKTOP-P087U98;Initial Catalog=D3Company;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            //clearing old list of items (if exist)
            employeeListBox.Items.Clear();
            departmentListBox.Items.Clear();
            worksListBox.Items.Clear();
            projectListBox.Items.Clear();

            // establish connection
            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            // first command to show employee table
            string empSqlCommand = "select * from D3Company.HumanResources.Employee";
            SqlCommand selectEmpComm = new SqlCommand(empSqlCommand, myconnection);
            
            // Data reader to GET the rowS of the employee table
            SqlDataReader reader = selectEmpComm.ExecuteReader();
            while(reader.Read())
            {
                employeeListBox.Items.Add(reader["EmpNo"].ToString() + " | " + reader["EmpFName"].ToString() + " | " + reader["EmpLName"].ToString());
            }
            reader.Close();   // close the reader after each command.

            // second command to show departments table
            string depSqlCommand = "select * from D3Company.Company.Department";
            SqlCommand selectDepComm = new SqlCommand(depSqlCommand,myconnection);
            
            reader = selectDepComm.ExecuteReader();
            while(reader.Read())
            {
                departmentListBox.Items.Add(reader["DeptNo"].ToString() + " | " + reader["DeptName"].ToString());
            }
            reader.Close();


            string worksSqlCommand = "select * from D3Company.dbo.Works_on";
            SqlCommand selectWorksComm = new SqlCommand(worksSqlCommand,myconnection);

            reader = selectWorksComm.ExecuteReader();
            while(reader.Read())
            {
                worksListBox.Items.Add(reader["EmpNo"].ToString() + " | " + reader["ProjectNo"].ToString() + " | " + reader["job"].ToString());
            }
            reader.Close();


            string projectSqlCommand = "select * from D3Company.Company.Project";
            SqlCommand selectProjectComm = new SqlCommand(projectSqlCommand, myconnection);

            reader = selectProjectComm.ExecuteReader();
            while (reader.Read())
            {
                projectListBox.Items.Add(reader["ProjectNo"].ToString() + " | " + reader["ProjectName"].ToString());
            }
            reader.Close();

        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomEmpID = random.Next(1,Int32.MaxValue);

            string firstName = this.firstNameTxtBox.Text;
            string lastName = this.lastNameTxtBox.Text;

            // establish connection
            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand addEmpcommand = new SqlCommand("insert into D3Company.HumanResources.Employee (EmpNo, EmpFName, EmpLName) values(@empNo,@fname,@lname)", myconnection);

            addEmpcommand.Parameters.AddWithValue("@empNo", randomEmpID);  //Give the new created employee a random number
            addEmpcommand.Parameters.AddWithValue("@fname", firstName);
            addEmpcommand.Parameters.AddWithValue("@lname", lastName);
            addEmpcommand.ExecuteNonQuery();
        }

        private void updateEmpBtn_Click(object sender, EventArgs e)
        {
            if (this.employeeListBox.SelectedItem == null)   //Check if there's no employee is checked
            {
                MessageBox.Show("Please select the employee first");
                return;
            }

            string selectedItemString = this.employeeListBox.SelectedItem.ToString();

            string idString = Regex.Match(selectedItemString, @"\d+").Value;

            string newFirstName = firstNameTxtBox.Text;
            string newLastName = lastNameTxtBox.Text;

            // establish connection
            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand updateEmpCommand = new SqlCommand("update D3Company.HumanResources.Employee set EmpFName = @newFName , EmpLName = @newLName where EmpNo = @empNo", myconnection);
            updateEmpCommand.Parameters.AddWithValue("@newFName", newFirstName);
            updateEmpCommand.Parameters.AddWithValue("@newLName", newLastName);
            updateEmpCommand.Parameters.AddWithValue("@empNo", idString);
            updateEmpCommand.ExecuteNonQuery();
        }


        private void deleteEmpBtn_Click(object sender, EventArgs e)
        {
            if (this.employeeListBox.SelectedItem == null)   //Check if there's no employee is checked
            {
                MessageBox.Show("Please select the employee first");
                return;
            }

            string selectedItemString = this.employeeListBox.SelectedItem.ToString();

            string idString = Regex.Match(selectedItemString, @"\d+").Value;  // To get the id of the selected employee

            // establish connection
            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand deleteEmpCommand = new SqlCommand("delete from D3Company.HumanResources.Employee where EmpNo = @empNo", myconnection);
            deleteEmpCommand.Parameters.AddWithValue("@empNo", idString);
            deleteEmpCommand.ExecuteNonQuery();
        }

        private void addDeptBtn_Click(object sender, EventArgs e)
        {
            string deptNo = deptNoTxtBox.Text; 
            string deptName = deptNameTxtBox.Text;

            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand addDeptCommand = new SqlCommand("addDept", myconnection);  //The stored procedure name is (addDept)
            addDeptCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter deptNoParam = new SqlParameter("@deptNo", deptNo);
            deptNoParam.Direction = ParameterDirection.Input;
            deptNoParam.DbType = DbType.String;

            addDeptCommand.Parameters.Add(deptNoParam); 

            SqlParameter deptNameParam = new SqlParameter("@deptName", deptName);
            deptNameParam.Direction = ParameterDirection.Input;
            deptNameParam.DbType = DbType.String;

            addDeptCommand.Parameters.Add(deptNameParam);

            addDeptCommand.ExecuteNonQuery(); 
        }

        private void updateDeptBtn_Click(object sender, EventArgs e)
        {
            if (this.departmentListBox.SelectedItem == null)   //Check if there's no employee is checked
            {
                MessageBox.Show("Please select the department first");
                return;
            }

            string newDeptNo = deptNoTxtBox.Text;
            string deptName = deptNameTxtBox.Text;

            string selectedItemString = this.departmentListBox.SelectedItem.ToString();
            string oldDeptNo = "d" + Regex.Match(selectedItemString, @"\d+").Value;

            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand updateDeptCommand = new SqlCommand("updateDept", myconnection);  //The stored procedure name is (addDept)
            updateDeptCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter deptNoParam = new SqlParameter("@newDeptNo", newDeptNo);
            deptNoParam.Direction = ParameterDirection.Input;
            deptNoParam.DbType = DbType.String;

            updateDeptCommand.Parameters.Add(deptNoParam);

            SqlParameter deptNameParam = new SqlParameter("@deptName", deptName);
            deptNameParam.Direction = ParameterDirection.Input;
            deptNameParam.DbType = DbType.String;

            updateDeptCommand.Parameters.Add(deptNameParam);

            SqlParameter oldDeptNoParam = new SqlParameter("@oldDeptNo", oldDeptNo);
            oldDeptNoParam.Direction = ParameterDirection.Input;
            oldDeptNoParam.DbType = DbType.String;

            updateDeptCommand.Parameters.Add(oldDeptNoParam);

            updateDeptCommand.ExecuteNonQuery();
        }

        private void deleteDeptBtn_Click(object sender, EventArgs e)
        {
            if (this.departmentListBox.SelectedItem == null)   //Check if there's no employee is checked
            {
                MessageBox.Show("Please select the department first");
                return;
            }


            string selectedItemString = this.departmentListBox.SelectedItem.ToString();
            string deptNo = "d" + Regex.Match(selectedItemString, @"\d+").Value;

            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand deleteDeptCommand = new SqlCommand("deleteDept", myconnection);  //The stored procedure name is (addDept)
            deleteDeptCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter deptNoParam = new SqlParameter("@deptNo", deptNo);
            deptNoParam.Direction = ParameterDirection.Input;
            deptNoParam.DbType = DbType.String;

            deleteDeptCommand.Parameters.Add(deptNoParam);

            deleteDeptCommand.ExecuteNonQuery();

        }

        private void displayWorksBtn_Click(object sender, EventArgs e)
        {
            worksListView.Clear();
            worksListView.View = View.Details;
            worksListView.GridLines = true;
            worksListView.FullRowSelect = true;
            worksListView.Columns.Add("EmpNo");
            worksListView.Columns.Add("ProjectNo");
            worksListView.Columns.Add("Job");
            worksListView.Columns.Add("Enter_Date");

            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            string worksSqlCommand = "select * from D3Company.dbo.Works_on";
            SqlCommand selectWorksComm = new SqlCommand(worksSqlCommand, myconnection);

            SqlDataReader reader = selectWorksComm.ExecuteReader();


            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems[0].Text = reader[0].ToString();   //First column of list item is filled with reader first column data
                listViewItem.SubItems.Add(reader[1].ToString());       // seoncd column -> second column
                listViewItem.SubItems.Add(reader[2].ToString());
                listViewItem.SubItems.Add(reader[3].ToString());
                
                worksListView.Items.Add(listViewItem);

            }

        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            string projectNo = projectNoTxtBox.Text;
            string projectName = projectNameTxtBox.Text;

            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand addProjectCommand = new SqlCommand("addProject", myconnection);  //The stored procedure name is (addDept)
            addProjectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter projectNoParam = new SqlParameter("@projectNo", projectNo);
            projectNoParam.Direction = ParameterDirection.Input;
            projectNoParam.DbType = DbType.String;

            addProjectCommand.Parameters.Add(projectNoParam);

            SqlParameter projectNameParam = new SqlParameter("@projectName", projectName);
            projectNameParam.Direction = ParameterDirection.Input;
            projectNameParam.DbType = DbType.String;

            addProjectCommand.Parameters.Add(projectNameParam);

            addProjectCommand.ExecuteNonQuery();

        }

        private void updateProjectBtn_Click(object sender, EventArgs e)
        {
            if (this.projectListBox.SelectedItem == null)   //Check if there's no employee is checked
            {
                MessageBox.Show("Please select the project first");
                return;
            }

            string newProjectNo = projectNoTxtBox.Text;
            string projectName = projectNameTxtBox.Text;

            string selectedItemString = this.projectListBox.SelectedItem.ToString();
            string oldProjectNo = "p" + Regex.Match(selectedItemString, @"\d+").Value;

            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand updateProjectCommand = new SqlCommand("updateProject", myconnection);  //The stored procedure name is (addDept)
            updateProjectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter projectNoParam = new SqlParameter("@newProjectNo", newProjectNo);
            projectNoParam.Direction = ParameterDirection.Input;
            projectNoParam.DbType = DbType.String;

            updateProjectCommand.Parameters.Add(projectNoParam);

            SqlParameter projectNameParam = new SqlParameter("@projectName", projectName);
            projectNameParam.Direction = ParameterDirection.Input;
            projectNameParam.DbType = DbType.String;

            updateProjectCommand.Parameters.Add(projectNameParam);

            SqlParameter oldProjectNoParam = new SqlParameter("@oldProjectNo", oldProjectNo);
            oldProjectNoParam.Direction = ParameterDirection.Input;
            oldProjectNoParam.DbType = DbType.String;

            updateProjectCommand.Parameters.Add(oldProjectNoParam);

            updateProjectCommand.ExecuteNonQuery();
        }

        private void deleteProjectBtn_Click(object sender, EventArgs e)
        {
            if (this.projectListBox.SelectedItem == null)   //Check if there's no employee is checked
            {
                MessageBox.Show("Please select the project first");
                return;
            }


            string selectedItemString = this.projectListBox.SelectedItem.ToString();
            string projectNo = "p" + Regex.Match(selectedItemString, @"\d+").Value;

            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand deleteProjectCommand = new SqlCommand("deleteProject", myconnection);  //The stored procedure name is (addDept)
            deleteProjectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter deptNoParam = new SqlParameter("@projectNo", projectNo);
            deptNoParam.Direction = ParameterDirection.Input;
            deptNoParam.DbType = DbType.String;

            deleteProjectCommand.Parameters.Add(deptNoParam);

            deleteProjectCommand.ExecuteNonQuery();
        }

        private void showDBInGridBtn_Click(object sender, EventArgs e)
        {          
            SqlConnection myconnection = new SqlConnection(connectionString);
            myconnection.Open();

            SqlCommand showProjectsCommand = new SqlCommand("select * from D3Company.Company.Project", myconnection);

            myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = showProjectsCommand;

            dataSet = new DataSet();

            myadapter.Fill(dataSet);

            if (dataSet.Tables.Count == 0)
            {
                MessageBox.Show("no data");
            }

            projectDataGrid.DataSource = dataSet; //bind datasource with the datagrid control
            projectDataGrid.DataMember = dataSet.Tables[0].ToString();

            
        }

        private void updateDBFromGridBtn_Click(object sender, EventArgs e)
        {
            myadapter.TableMappings.Add("D3Company.Company.Project", "Table");

            SqlCommandBuilder builder = new SqlCommandBuilder(myadapter);

            myadapter.Update(dataSet, "D3Company.Company.Project");

            projectDataGrid.DataSource = dataSet.Tables["D3Company.Company.Project"];
            dataSet.AcceptChanges();
        }
    }
}

