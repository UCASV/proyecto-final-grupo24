using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_POO_DB
{
    public partial class FrmSeccondAppointment : Form
    {
        private Citizen citizen { get; set; }
        
        public FrmSeccondAppointment(Citizen citizen)
        {
            InitializeComponent();
            this.citizen = citizen;
        }

        private void FrmSeccondAppointment_Load(object sender, EventArgs e)
        {
            var db = new Proyecto_POO_DBContext();

            //se traen los procesos de vacunacion de la base de datos
            List<VaccinationProcess> VaccineList = db.VaccinationProcesses
                .OrderBy(va => va.Id).ToList();
            
            //se encuentra la cita que contenga el mismo dui
            List<VaccinationProcess> result =
                VaccineList.Where(va => va.DuiCitizen == citizen.Dui).ToList();
            
            //se asocia la el numero de cabina con la cita
            Cabin cdb = db.Set<Cabin>().SingleOrDefault(c => c.CabinNumber == result[0].SeconddoseCabin);

            //se muestran los datos para la cita
            lblDUI2.Text = Convert.ToString(result[0].DuiCitizen);
            lblDate2.Text = Convert.ToString(result[0].SeconddoseDateTime);
            lblCabin2.Text = Convert.ToString(cdb.AdressCabin);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le esperamos para su segunda vacuna!", "Segunda cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}