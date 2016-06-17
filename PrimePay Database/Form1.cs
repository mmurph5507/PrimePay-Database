/*
 * PrimePay Database
 * 
 * Primary Contributor(s): Matt Murphy
 * 
 * Last Update: 6/17/2016
 * 
 * 
 * 
 *      -~-   PROJECT DESCRIPTION   -~-
 * 
 * A databse intended to store employee information. The Form1.cs file manages all code for the
 * PrimePay Database, including establishing connections with the database and handling form control
 * methods.
 * 
 * The program utilizes the tables 'tbl_info' and 'tbl_pay' to display data; both databases are found
 * under the Employees.mdf database file. This program uses .NET properties to create strings and
 * facilitate connections with the database. These strings and their settings
 * ('EmployeesConnectionString', 'InfoSQL', 'PaySQL') can be found under 'Properties' -> 'Settings'.
 * 
 * The table 'tbl_info' is used for storing employee info: Their name, position, department and office
 * location, and yearly salary. The table 'tbl_pay' is used for accounting for individual salary
 * payments to employees, and is related as a child table to 'tbl_info' via the foreign key 'I_Id'.
 * 
 * When the project is running, the user can page back nd forth between individual records in the
 * 'tbl_info' database using the '< <' and '> >', and they may skip to the first or last records in the
 * database with the '| | <' and '> | |' buttons respectively. There are also options to add new
 * records, and update or delete already existing records. When the 'Add New' button is clicked, all
 * other buttons other than 'Save' and 'Cancel' are disabled, and the text boxes are cleared. The user
 * enters in the desired information into the text boxes, and must click save to commit the new record
 * to the 'tbl_info' database. By clicking 'Cancel', they will clear the text boxes and reset the form
 * to its original state.
 * 
 * 
 * 
 *      -~-   KNOWN ISSUES   -~-
 * 
 *   -   The program throws a 'concurrency violation' when the user attempts to delete a record
 *          immediately after adding it. To delete it, the entire program must be restarted to allow
 *          the new data to be accepted into the table. There is a known cause for this: Visual Studio
 *          by default does not immediately retrieve the identity value for the row immediately after
 *          adding it, and the table's autoincrement function must be altered to solve the issue.
 *          However, an adequate solution has not been reached as of yet.
 * 
 * 
 * 
 *      -~-   PLANNED IMPLEMENTATIONS   -~-
 *      
 *   -   The project does not currently completely utilize the 'tbl_pay' table. The table exists, and
 *          it is constrained to the 'tbl_info' table which is utilized by the project. The planned
 *          function to be implemented is to allow the user to view all of the payments made to a
 *          specific employee; when the user scrolls to another employee, the GUI will display all of
 *          the relevant payments made to that employee.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimePay_Database
{
    public partial class frmPrimePay : Form
    {
        /*          -~-   GLOBAL VARIABLES   -~-          */

        /* DataAdapter used for databases. */
        System.Data.SqlClient.SqlDataAdapter da_1;

        /* String used to establish connections with a SQL database in Employees.mdf. */
        private string connection;

        /* Strings used to hold SQL queries that will fetch a table from the Employees.mdf database. */
        private string sqlInfo;
        private string sqlPay;

        /* DataSet objects that will be used to display records from the database. */
        DataSet dSet;
        DataRow dRow;

        /* Variables used to facilitate some program functions. The variable 'maxRows' tracks the size of a
         * table, and inc is used as a marker to track the user's current position within the database. */
        int maxRows;
        int inc = 0;



        /*          -~-   MAIN METHODS   -~-          */

        public frmPrimePay()
        {
            InitializeComponent();
        }

        private void frmPrimePay_Load(object sender, EventArgs e)
        {
            /* Use a try-catch block to facilitate interactions with the Employees.mdf database. */
            try
            {
                /* Initialize variables. */

                /* Create connections with the properties strings. The string 'connection' creates a connection, while
                 * sqlInfo and sqlPay each store SQL queries for retrieving data from individual tables in
                 * Employees.mdf. The string 'sqlInfo' retrieves data from tbl_info, and sqlPay retrieves data from
                 * tbl_pay. */
                connection = Properties.Settings.Default.EmployeesConnectionString;
                sqlInfo = Properties.Settings.Default.InfoSQL;
                sqlPay = Properties.Settings.Default.PaySQL;

                /* Create the DataSet by calling BuildDataSet() and assigning it to the variable 'dSet'. */
                dSet = BuildDataSet();

                /* Initialize 'maxRows' to the total number of rows in the DataSet. */
                maxRows = dSet.Tables[0].Rows.Count;

                /* Initial call to RecordDisplay() to display the first item in the record on the form. */
                RecordDisplay();
            }
            /* Throw an error message if any of the above code causes an exception. */
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /*          -~-   FORM CONTROLS   -~-          */

        /* Move forward in the database when the next button ('> >') is clicked. */
        private void btnNext_Click(object sender, EventArgs e)
        {
            /* An if-statement to check if the user has reached the end of the database, which is determined by
             * checking if 'inc' is less than the length of the table. */
            if (inc < maxRows - 1)
            {
                /* Increment 'inc' by one to move to the next item, then call RecordDisplay() to display the next set
                 * of records in the database. */
                inc++;
                RecordDisplay();
            }
            /* Notify the user if they have reached the end of the list. */
            else
            {
                MessageBox.Show("End of Record");
            }
        }

        /* Move backwards in the databasewhen the previous button ('< <') is clicked. */
        private void btnPrev_Click(object sender, EventArgs e)
        {
            /* An if-statement to check if the user has reached the beginning of the database, which is determined
             * by checking if 'inc' is less than 0. */
            if (inc > 0)
            {
                /* Deincrement 'inc' by one to move back, then call RecordDisplay() to display the new set of
                 * records in the database. */
                inc--;
                RecordDisplay();
            }
            /* Notify the user if they have reached the beginning of the list. */
            else
            {
                MessageBox.Show("Beginning of Record");
            }
        }

        /* Jump to the last record in the database. */
        private void btnLast_Click(object sender, EventArgs e)
        {
            /* An if-statement checks if the user isn't already at the end of the database. If the user already is,
             * the program takes no action. This is done by checking if 'inc' is not equal to 'maxRows'. */
            if (inc != maxRows)
            {
                inc = maxRows - 1;
                RecordDisplay();
            }
        }

        /* Jump to the first record in the database. */
        private void btnFirst_Click(object sender, EventArgs e)
        {
            /* An if-statement checks if the user isn't already at the beginning of the database. If the user
             * already is, the program takes no action. This is done by checking if 'inc' is not equal to 0. */
            if (inc != 0)
            {
                inc = 0;
                RecordDisplay();
            }
        }

        /* Allows the user to add new records to the database through the GUI. */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* Clear out text from all of the text boxes to allow the user to enter in new information. */
            txtFirst.Clear();
            txtLast.Clear();
            txtTitle.Clear();
            txtDept.Clear();
            txtLocale.Clear();
            txtSalary.Clear();

            /* Switch all of the relevant buttons. */
            ButtonSwitch(false);
        }

        /* Saves data the user entered into the text boxes to the database. The control 'btnSave' can normally
         * only be accessed by clicking on 'btnAdd'. */
        private void btnSave_Click(object sender, EventArgs e)
        {
            /* Use an if-statement to check the contents of the 'txtSalary' input. Since the database will only
             * accept integers for that column, it will cause errors in the code if the user inputs anything but an
             * integer. So, the data will only save if the user inputs an integer, and will warn the user if they
             * put in anything like a string. Since the other columns accept strings, they do not need this sort of
             * check. */
            
            /* Float variable required for the TryParse() to work. */
            float num;

            if (float.TryParse(txtSalary.Text, out num))
            {
                /* Use a try-catch block to retrieve the data and update the database. */
                try
                {
                    /* Create a new row that will store user input and append it to the end of the database. */
                    DataRow row = dSet.Tables[0].NewRow();

                    /* Retreive the text from all of the text boxes. */
                    row[1] = txtFirst.Text;
                    row[2] = txtLast.Text;
                    row[3] = txtTitle.Text;
                    row[4] = txtDept.Text;
                    row[5] = txtLocale.Text;
                    row[6] = txtSalary.Text;

                    /* Add the new row to the DataSet and call UpdateDatabase() to add it to the actual database. */
                    dSet.Tables[0].Rows.Add(row);
                    UpdateDatabase();

                    /* Increment 'maxRows' and reset 'inc' to the position of the new record. */
                    maxRows = maxRows + 1;
                    inc = maxRows - 1;

                    /* Confirm to the user that the database was successfully updated. */
                    MessageBox.Show("New Record Added");
                    RecordDisplay();
                }
                /* Throw an error message if any of the above code causes an exception. */
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                ButtonSwitch(true);
            }
            /* If the TryParse() returns false (i.e. non-numeric values were found in the input for txtSalary),
             * clear txtSalary and warn the user they must input a numeric value. */
            else
            {
                txtSalary.Clear();
                MessageBox.Show("You must input a number for the salary.");
            }
        }

        /* Cancels an action to add a new record, resetting the form to its previous state. The control
         * 'btnCancel' can normally only be accessed by clicking on 'btnAdd'. */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            RecordDisplay();
            ButtonSwitch(true);
        }

        /* Updates a single record in the database. */
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            /* Use an if-statement to check the contents of the 'txtSalary' input. Since the database will only
             * accept integers for that column, it will cause errors in the code if the user inputs anything but an
             * integer. So, the data will only save if the user inputs an integer, and will warn the user if they
             * put in anything like a string. Since the other columns accept strings, they do not need this sort of
             * check. */

            /* Float variable required for the TryParse() to work. */
            float num;

            if (float.TryParse(txtSalary.Text, out num))
            {
                /* Use a try-catch block to retrieve the data and update the database. */
                try
                {
                    /* Create a new row at the current position in the database that will store the updated information. */
                    DataRow row = dSet.Tables[0].Rows[inc];

                    /* Retreive the text from all of the text boxes. */
                    row[1] = txtFirst.Text;
                    row[2] = txtLast.Text;
                    row[3] = txtTitle.Text;
                    row[4] = txtDept.Text;
                    row[5] = txtLocale.Text;
                    row[6] = txtSalary.Text;

                    /* Update the database with the new information and inform the user the operation has completed. */
                    UpdateDatabase();
                    MessageBox.Show("Record Updated");
                }
                /* Throw an error message if any of the above code causes an exception. */
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /* If the TryParse() returns false (i.e. non-numeric values were found in the input for txtSalary),
             * warn the user they must input a numeric value. */
            else
            {
                MessageBox.Show("You must input a number for the salary.");
            }
        }

        /* Deletes a record from the database. */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* Use a try-catch block to remove the item from the database safely. */
            try
            {
                /* Delete the row, then update the database. */
                dSet.Tables[0].Rows[inc].Delete();
                UpdateDatabase();

                /* Reset 'maxRows' and 'inc' to the new database length. */
                maxRows = dSet.Tables[0].Rows.Count;
                inc--;

                /* Reset the form display and notify the user the item was removed. */
                RecordDisplay();
                MessageBox.Show("Record Deleted");
            }
            /* Throw an error message if any of the above code causes an exception. */
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /*          -~-   DATABASE CONNECTION   -~-          */

        /* Method used to create a DataSet that will be used to display and alter a database table and its
         * contents. */
        private System.Data.DataSet BuildDataSet()
        {
            /* Create and open a connection to the SQL database. */
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connection);
            con.Open();

            /* Initialize the DataAdapter and point it to the correct database. */
            da_1 = new System.Data.SqlClient.SqlDataAdapter(sqlInfo, con);
            
            /* Creates a DataSet called dat_set. This will be returned by PrimeDataSet as the DataSet that will be
             * used by the rest of the application. */
            System.Data.DataSet dat_set = new System.Data.DataSet();

            /* Use the DataAdapter da_1 to fill the DataSet dat_set. The dat_set is called "Info Table". Now that
             * BuildDataSet() has finished its job, the connection to the database in closed and dat_set is
             * returned for future use. */
            da_1.Fill(dat_set, "Info Table");

            con.Close();
            return dat_set;
        }

        /* Update the Employees.mdf database. */
        public void UpdateDatabase()
        {
            /* Create a SqlCommandBuilder to facilitate interations with the database and update. */
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(da_1);
            cb.DataAdapter.Update(dSet.Tables[0]);
        }



        /*          -~-   FUNCTIONAL METHODS   -~-          */

        /* Display a given row from the database to the GUI form. */
        private void RecordDisplay()
        {
            /* Retrieve all of the data from a specific row in the database. The row selected is the one specified
             * by 'inc'. */
            dRow = dSet.Tables[0].Rows[inc];

            /* Display all of the data to the text boxes on the form. In order: First name, last name, title,
             * department, office location, and the employee's yearly salary. */
            txtFirst.Text = dRow.ItemArray.GetValue(1).ToString();
            txtLast.Text = dRow.ItemArray.GetValue(2).ToString();
            txtTitle.Text = dRow.ItemArray.GetValue(3).ToString();
            txtDept.Text = dRow.ItemArray.GetValue(4).ToString();
            txtLocale.Text = dRow.ItemArray.GetValue(5).ToString();
            txtSalary.Text = dRow.ItemArray.GetValue(6).ToString();
        }

        /* Enable or disable the appropriate buttons when entering in a new record. */
        private void ButtonSwitch(bool x)
        {
            /* Switch all of the navigational buttons. */
            btnNext.Enabled = x;
            btnPrev.Enabled = x;
            btnFirst.Enabled = x;
            btnLast.Enabled = x;

            /* Switch all of the Add New buttons. The 'Save' and 'Cancel' buttons should be normally disabled, and
             * enabled while every other button (including 'Add New') is disabled. */
            btnAdd.Enabled = x;
            btnSave.Enabled = !x;
            btnCancel.Enabled = !x;

            /* Switch all of the update buttons. */
            btnUpdate.Enabled = x;
            btnDelete.Enabled = x;
        }
    }
}
