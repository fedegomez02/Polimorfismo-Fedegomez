using Entidades.Models;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_
{
    public partial class Form1 : Form
    {
        AdmPaciente admPaciente = new AdmPaciente();
        AdmMedico AdmMedico = new AdmMedico();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrarMedicos_Click(object sender, EventArgs e)
        {
          

            GridPacientes.DataSource = admPaciente.Listar(); 



        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridPacientes.DataSource = AdmMedico.Listar();

            MedicosClinicosList.Items.Clear();
            List<Medico> medicosClinicos;
            medicosClinicos = AdmMedico.Listar("Clinico");
            foreach (Medico medico in medicosClinicos)
            {
                MedicosClinicosList.Items.Add(medico.Nombre + " " + medico.Apellido);
            }
        }
    }
}
