using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_structure_Project
{
    public partial class Flight_Form : Form
    {
        public Flight_Form()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goes back to Admin Dashboard");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string flightName = txt_flightName.Text;
            string source = cmb_Source.Text;
            string destination = cmb_Dest.Text;
            DateTime date = dateTime_takeOff.Value;
            int seatNo; int.TryParse(txt_seatNo.Text, out seatNo);

            FlightsAddition newFlight = new FlightsAddition(flightName,source,destination,date,seatNo);
            if(newFlight != null)
            {
                //AdminDashboard dashboard = new Dashboard
                //dashboard.Load the grid view function on dashboard form
                //dashboard.Show()
                MessageBox.Show("On click, It add to the grid view on Admin Dashboard");
            }
            else
            {
                MessageBox.Show("Attributes cannot be null");
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On click, removes from data grid view on admin dashboard");
        }

        /* Function in the admin dashboard
         * 
         * private void AddShowEmpDetails(bool newEmp)
        {

            int selectedRowCount = gridEmpTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Employee selectedEmployee = null;
            if (!newEmp && selectedRowCount > 0)
            {
                string empId = (string)gridEmpTable.SelectedRows[0].Cells[0].Value;
                selectedEmployee = EmployeeDB.GetEmployee(long.Parse(empId));
            }
            Form employeeRegistration = new EmployeeRegistrationForm(selectedEmployee);
            employeeRegistration.ShowDialog();
            RefreshEmployeelDataGridView();
        }*/
    }
}
