using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_POO_DB
{
    public partial class FrmlLogInCitizen : Form
    {
        private Employee employee { get; set; }
        public FrmlLogInCitizen(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new Proyecto_POO_DBContext();

            int DUI = Convert.ToInt32(txtDUI.Text);
            
            List<Citizen> CitizenList = db.Citizens
                .OrderBy(c => c.Dui).ToList();
            
            //lista que devuelve a todos los ciudadanos con el dui ingresada (1 max)
            List<Citizen> result =
                CitizenList.Where(c => c.Dui == DUI).ToList();

            if (result.Count > 0)
            {
                //Iniciar sesion
                FrmAppointment window = new FrmAppointment(result[0], employee);
                window.ShowDialog();
                this.Hide();
            }
            else 
                MessageBox.Show("Ciudadano inexistente", "Inicio de sesion de ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //redirige al formulario para crear citas
            FrmCreateAppointment window = new FrmCreateAppointment(employee);
            window.ShowDialog();
            this.Hide();
        }
    }
}