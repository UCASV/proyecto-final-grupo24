using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_POO_DB
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }
        
        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            var db = new Proyecto_POO_DBContext();
            //se llena el combobox con las direcciones de las cabinas
            //y se toma la referencia a su id
            List<Cabin> cabins = db.Cabins.ToList();

            cmbCabin.DataSource = cabins;
            cmbCabin.DisplayMember = "AdressCabin";
            cmbCabin.ValueMember = "CabinNumber";

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new Proyecto_POO_DBContext();
            
            List<Employee> EmployeeList = db.Employees
                .OrderBy(e => e.Id).ToList();
            
            //se almacenan los datos en variables para poder verificar en la base de datos si existen o no
            string user = txtUser.Text.Trim();
            string password = txtPassword.Text;
            Cabin cabin = (Cabin) cmbCabin.SelectedItem;

            //lista que devuelve a todos los empleados existentes con el usuario y contrasenna ingresada (1 max)
            List<Employee> result =
                EmployeeList.Where(e => e.Username == user
                                        && e.PasswordUser == password).ToList();
            
            //de cumplir la condicion el empleado inicia sesion
            if (result.Count >0)
            {
                MessageBox.Show("Bienvenido!", "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //se obtiene el id del empleado y la cabina para mandarlos como llave foranea
                Employee edb = db.Set<Employee>().SingleOrDefault(e => e.Id == result[0].Id);
                Cabin cdb = db.Set<Cabin>().SingleOrDefault(c => c.CabinNumber == cabin.CabinNumber);
                //se agregan los datos a una clase 'registry' para annadira a la base de datos
                Registry registry = new Registry()
                {
                    IdEmployee = edb.Id,
                    CabinNumber = cdb.CabinNumber,
                    DateHour = DateTime.Now
                };
                db.Add(registry);
                db.SaveChanges();
                MessageBox.Show("Credenciales guardadas en registro", "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //se abre la nueva ventana ya que se inicio sesion y se cierra esta
                //se manda el 'edb.id' al siguiente formulario porque se utiliza al llenar los datos del ciudadano
                FrmPrincipal window = new FrmPrincipal(result[0]);
                window.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usuario inexistente", "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}