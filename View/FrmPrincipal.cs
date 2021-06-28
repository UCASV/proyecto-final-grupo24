using System;
using System.Windows.Forms;

namespace Proyecto_POO_DB
{
    public partial class FrmPrincipal : Form
    {
        private Employee employee { get; set; }
        //recibe el id del empleado 
        public FrmPrincipal(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //redirige al nuevo formulario para crear citas
            FrmCreateAppointment window = new FrmCreateAppointment(employee);
            window.ShowDialog();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //redirige al nuevo formulario para revisar citas
            FrmlLogInCitizen window = new FrmlLogInCitizen(employee);
            window.ShowDialog();        
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}