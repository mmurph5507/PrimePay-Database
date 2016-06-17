# PrimePay-Database
Primary Contributor(s): Matt Murphy
Last Update: 6/16/2016



     -~-   PROJECT DESCRIPTION   -~-

A databse intended to store employee information. The Form1.cs file manages all code for the
PrimePay Database, including establishing connections with the database and handling form control
methods.

The program utilizes the tables 'tbl_info' and 'tbl_pay' to display data; both databases are found
under the Employees.mdf database file. This program uses .NET properties to create strings and
facilitate connections with the database. These strings and their settings
('EmployeesConnectionString', 'InfoSQL', 'PaySQL') can be found under 'Properties' -> 'Settings'.

The table 'tbl_info' is used for storing employee info: Their name, position, department and office
location, and yearly salary. The table 'tbl_pay' is used for accounting for individual salary
payments to employees, and is related as a child table to 'tbl_info' via the foreign key 'I_Id'.

When the project is running, the user can page back nd forth between individual records in the
'tbl_info' database using the '< <' and '> >', and they may skip to the first or last records in the
database with the '| | <' and '> | |' buttons respectively. There are also options to add new
records, and update or delete already existing records. When the 'Add New' button is clicked, all
other buttons other than 'Save' and 'Cancel' are disabled, and the text boxes are cleared. The user
enters in the desired information into the text boxes, and must click save to commit the new record
to the 'tbl_info' database. By clicking 'Cancel', they will clear the text boxes and reset the form
to its original state.



     -~-   KNOWN ISSUES   -~-

  -   The program throws a 'concurrency violation' when the user attempts to delete a record
         immediately after adding it. To delete it, the entire program must be restarted to allow
         the new data to be accepted into the table. There is a known cause for this: Visual Studio
         by default does not immediately retrieve the identity value for the row immediately after
         adding it, and the table's autoincrement function must be altered to solve the issue.
         However, an adequate solution has not been reached as of yet.



     -~-   PLANNED IMPLEMENTATIONS   -~-

  -   The project does not currently completely utilize the 'tbl_pay' table. The table exists, and
         it is constrained to the 'tbl_info' table which is utilized by the project. The planned
         function to be implemented is to allow the user to view all of the payments made to a
         specific employee; when the user scrolls to another employee, the GUI will display all of
         the relevant payments made to that employee.
