using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_POO_DB
{
    public partial class FrmVaccine : Form
    {
        private Citizen citizen { get; set; }
        private Employee employee { get; set; }
        private Cabin cabin { get; set; }

        public FrmVaccine(Citizen citizen, Employee employee, Cabin cabin)
        {
            InitializeComponent();
            this.employee = employee;
            this.citizen = citizen;
            this.cabin = cabin;
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            var db = new Proyecto_POO_DBContext();

            //se traen las citas hechas de la base de datos
            List<Appointment> AppointmentList = db.Appointments
                .OrderBy(a => a.Id).ToList();
            
            //se encuentra la cita que contenga el mismo dui
            List<Appointment> result =
                AppointmentList.Where(a => a.DuiCitizen == citizen.Dui).ToList();
            
            //se hace uso de la clase Random para generar una hora que se tarda el ciudadano en llegar a la cita
            Random r = new Random();
            //se toma la hora de la cita como variable inicial
            DateTime dateQueue = (DateTime) result[0].DateHour;
            //a la hora original se le agregan un valor aleatorio entre 0 y 30 minutos
            dateQueue = dateQueue.AddMinutes(r.Next(0, 30));

            lblDateQueue.Text = Convert.ToString(dateQueue);
        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            if (lblDateQueue.Text != "")
            {
                //se hace uso de la clase Random para generar una hora que se tarda el ciudadano en llegar a la cita
                Random r = new Random();
                //se toma la hora de la que se llego a la fila como variable inicial
                DateTime dateVaccine = Convert.ToDateTime(lblDateQueue.Text);
                //a la hora original se le agregan un valor aleatorio entre 0 y 90 minutos
                dateVaccine = dateVaccine.AddMinutes(r.Next(0, 90));

                lblDateVaccine.Text = Convert.ToString(dateVaccine);
                
                MessageBox.Show("La vacuna ha sido inyectada!", "Proceso de vacunacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Primero se debe de ingresar la hora a la que llego a la fila", "Proceso de vacunacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (lblDateVaccine.Text != "")
            {
                var db = new Proyecto_POO_DBContext();
                
                //se consiguen las referencias para las llaves foreanes
                Citizen cidb = db.Set<Citizen>().SingleOrDefault(ci => ci.Dui == citizen.Dui);
                Employee emdb = db.Set<Employee>().SingleOrDefault(em => em.Id == employee.Id);
                Cabin cadb = db.Set<Cabin>().SingleOrDefault(ca => ca.CabinNumber == cabin.CabinNumber);

                
                Random r = new Random();
                
                
                //se toma la fecha de vacuna y se le annaden dias extra entre 4 y 6 semanans (42 y 56 dias)
                DateTime dateSecondVaccine = Convert.ToDateTime(lblDateVaccine.Text).AddDays(r.Next(42,56)).AddHours(r.Next(7, 17)).AddMinutes(r.Next(0, 60)).AddSeconds(r.Next(0, 60));

                int range = r.Next(5);
                Cabin cabdb = db.Set<Cabin>().SingleOrDefault(cab => cab.CabinNumber == range);
                
                VaccinationProcess vaccine = new VaccinationProcess()
                {
                    RowDateTime = Convert.ToDateTime(lblDateQueue.Text),
                    VaccinationDateTime = Convert.ToDateTime(lblDateVaccine.Text),
                    SeconddoseDateTime = dateSecondVaccine,
                    SeconddoseCabin = cabdb.CabinNumber,
                    CabinNumber = cadb.CabinNumber,
                    IdEmployee = emdb.Id,
                    DuiCitizen = cidb.Dui
                };
                db.Add(vaccine);
                db.SaveChanges();
                MessageBox.Show("Segunda cita agendada exitosamente!", "Proceso de vacunacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (txtEffect.Text != "" && cmbMinuteEffect.Text != "")
                {
                    VaccinationProcess vadb = db.Set<VaccinationProcess>()
                        .SingleOrDefault(va => va.DuiCitizen == citizen.Dui);
                    SecondaryEffect secEff = new SecondaryEffect()
                    {
                        IdProcess = vadb.Id,
                        SecondaryEffect1 = txtEffect.Text,
                        EffectMinutes = Convert.ToInt32(cmbMinuteEffect.Text)
                    };
                    db.Add(secEff);
                    db.SaveChanges();
                        
                    MessageBox.Show("Ciudadano presento efectos secudarios!", "Proceso de vacunacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmSeccondAppointment window = new FrmSeccondAppointment(citizen);
                    window.ShowDialog();
                    this.Hide();
                };
            }
            else
                MessageBox.Show("Debe de vacunarse primero", "Proceso de vacunacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}