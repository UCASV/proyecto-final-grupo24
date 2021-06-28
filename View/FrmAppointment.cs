using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Proyecto_POO_DB
{
    public partial class FrmAppointment : Form
    {
        private Citizen citizen { get; set; }
        private Employee employee { get; set; }
        public FrmAppointment(Citizen citizen, Employee employee)
        {
            InitializeComponent();
            this.citizen = citizen;
            this.employee = employee;
        }

        private void FrmAppointment_Load(object sender, EventArgs e)
        {
            var db = new Proyecto_POO_DBContext();

            //se traen las citas hechas de la base de datos
            List<Appointment> AppointmentList = db.Appointments
                .OrderBy(a => a.Id).ToList();
            
            //se encuentra la cita que contenga el mismo dui
            List<Appointment> result =
                AppointmentList.Where(a => a.DuiCitizen == citizen.Dui).ToList();
            
            //se asocia la el numero de cabina con la cita
            Cabin cdb = db.Set<Cabin>().SingleOrDefault(c => c.CabinNumber == result[0].CabinNumber);

            //se muestran los datos para la cita
            lblDUI2.Text = Convert.ToString(result[0].DuiCitizen);
            lblDate2.Text = Convert.ToString(result[0].DateHour);
            lblCabin2.Text = Convert.ToString(cdb.AdressCabin);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////
            //PDF
            ///////////////////////////////////////////////////
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var db = new Proyecto_POO_DBContext();
            
            //se traen las citas hechas de la base de datos
            List<Appointment> AppointmentList = db.Appointments
                .OrderBy(a => a.Id).ToList();
            //se encuentra la cita que contenga el mismo dui
            List<Appointment> result =
                AppointmentList.Where(a => a.DuiCitizen == citizen.Dui).ToList();
            //se asocia la el numero de cabina con la cita
            Cabin cadb = db.Set<Cabin>().SingleOrDefault(ca => ca.CabinNumber == result[0].CabinNumber);

            //se crea una lista de los registros
            List<Registry> RegistryList = db.Registries
                .OrderBy(re => re.CabinNumber).ToList();
            //dentro de la lista de registros, se que el empleado actual este en la cabina adecuada
            //para verificar que el ciudadano se ha presentado a la cabina correspondiente
            List<Registry> RegistryResult = RegistryList
                .Where(re => re.IdEmployee == employee.Id &&
                             re.CabinNumber == cadb.CabinNumber).ToList();

            if (RegistryResult.Count > 0)
            {
                FrmVaccine window = new FrmVaccine(citizen, employee, cadb);
                window.ShowDialog();
                this.Hide();
            }
            else 
                MessageBox.Show("Debe de ir a la cabina adecuada", "Proceso de vacunacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}