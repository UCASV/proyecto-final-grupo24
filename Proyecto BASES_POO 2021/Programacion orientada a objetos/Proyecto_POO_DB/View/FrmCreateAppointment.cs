using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Proyecto_POO_DB
{
    public partial class FrmCreateAppointment : Form
    {
        private Employee employee { get; set; }
        public FrmCreateAppointment(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void FrmCreateAppointment_Load(object sender, EventArgs e)
        {
            var db = new Proyecto_POO_DBContext();
            //se llena el combobox con los puestos
            //y se toma la referencia a su id
            List<Position> positions = db.Positions.ToList();

            cmbPosition.DataSource = positions;
            cmbPosition.DisplayMember = "Position1";
            cmbPosition.ValueMember = "Id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //se verifica que los campos contengan texto para proceder con el registro del ciudadano
            if (txtName.Text == "" || txtLastname.Text == "" || txtAdress.Text == ""
                || txtEmail.Text == "" || txtInstitution.Text == ""
                || txtDUI.Text == "" || txtAge.Text == "" || txtPhone.Text == "")
                MessageBox.Show("Algun campo esta vacio", "Registro de ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var db = new Proyecto_POO_DBContext();
                
                //se le asigna una variable a los datos que han sido ingresados
                int DUI = Convert.ToInt32(txtDUI.Text);
                string name = txtName.Text;
                string lastname = txtLastname.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string adress = txtAdress.Text;
                int phone = Convert.ToInt32(txtPhone.Text);
                string email = txtEmail.Text;
                string institution = txtInstitution.Text;
                Position position = (Position) cmbPosition.SelectedItem;
                
                //se revisa en la base de datos que no haya otro usuario con el mismo DUI
                List<Citizen> CitizenList = db.Citizens
                    .OrderBy(c => c.Dui).ToList();
                bool checking = CitizenList
                    .Where(c => c.Dui == DUI).ToList().Count > 0;
                
                //si no existen repetidos, se carga el usuario a la base de datos
                if (!checking)
                {
                    //se obtiene el id del puesto y el empleado para mandarlo como llave foranea
                    Position pdb = db.Set<Position>().SingleOrDefault(p => p.Id == position.Id);
                    Employee edb = db.Set<Employee>().SingleOrDefault(em => em.Id == employee.Id);
                    
                    //se annaden las variables a una clase 'citizen' para ser guardada en la base de datos
                    Citizen citizen = new Citizen()
                    {
                        Dui = DUI,
                        NameCitizen = name,
                        LastnameCitizen = lastname,
                        Age = age,
                        AddressCitizen = adress,
                        Phone = phone,
                        EmailCitizen = email,
                        InstitutionalIdentifier = institution,
                        IdPosition = pdb.Id,
                        IdEmployee = edb.Id
                    };
                    db.Add(citizen);
                    db.SaveChanges();
                    
                    MessageBox.Show("Ciudadano registrado exitosamente!", "Registro de ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //si el ciudadano fue registrado y tiene alguna enfermedad, se annade a la base de datos
                    if (txtDisease.Text != "")
                    {
                        Citizen cdb = db.Set<Citizen>().SingleOrDefault(c => c.Dui == citizen.Dui);
                        Disease disease = new Disease()
                        {
                            DuiCitizen = cdb.Dui,
                            Disease1 = txtDisease.Text
                        };
                        db.Add(disease);
                        db.SaveChanges();
                        
                        MessageBox.Show("Ciudadano tiene alguna enfermedad!", "Registro de ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };
                    
                    //se revisa si el ciudadano pertenece a un grupo de prioridad 
                    if (age > 60 || pdb.Id != 4 || txtDisease.Text != "")
                        MessageBox.Show("Pertenece a un grupo de prioridad!", "Registro de ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //se hace uso de la clase Random para generar la fecha y hora de la cita
                    Random r = new Random();

                    //se crea una fecha maxima para las citas (dentro de 2 meses ~)
                    DateTime datemax = new DateTime(2021, 8, 31);
                    //se genera un numero aleatorio entre la fecha actual y la maxima
                    int range = (datemax - DateTime.Today).Days;
                    //a la fecha actual se le suma el numero aleatorio anterior para crear una fecha
                    DateTime date = DateTime.Now.AddDays(r.Next(range)).AddHours(r.Next(7, 17)).AddMinutes(r.Next(0, 60)).AddSeconds(r.Next(0, 60));

                    //el valor de 'range' cambia para dar un numero aleatorio de cabinas
                    range = r.Next(5);
                    
                    Cabin cadb = db.Set<Cabin>().SingleOrDefault(ca => ca.CabinNumber == range);
                    Citizen cidb = db.Set<Citizen>().SingleOrDefault(c => c.Dui == citizen.Dui);

                    Appointment appointment = new Appointment()
                    {
                        DuiCitizen = cidb.Dui,
                        IdEmployee = edb.Id,
                        CabinNumber = cadb.CabinNumber,
                        DateHour = date
                    };
                    db.Add(appointment);
                    db.SaveChanges();
                    
                    MessageBox.Show("Cita agendada exitosamente!", "Registro de cita", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmAppointment window = new FrmAppointment(citizen, employee);
                    window.ShowDialog();
                    this.Hide();
                }
                else 
                    MessageBox.Show("Ciudadano ya existe en la base de datos!", "Registro de ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}