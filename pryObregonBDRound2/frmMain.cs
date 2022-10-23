using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryObregonBDRound2
{
    public partial class frmMain : Form
    {
        //declaracion de variables y objetos globales
        //utilizaremos las variables publicas para usarlas en todo el proyecto
        public OleDbConnection conexionBase;
        public OleDbConnection queQuieroDeLaBase;
        public OleDbConnection lectorDeConsultas;
        public string varRutaBaseDeDatos = "DEPORTE.accdb";

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                lblFechaActual.Text = DateTime.Now.ToString();
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRutaBaseDeDatos);
                conexionBase.Open();
                lblEstado.Text = "Conectado:" + conexionBase.ConnectionString;
                ssp.BackColor = Color.GreenYellow;
            }
            catch (Exception mensajito)
            {
                lblEstado.Text = mensajito.Message;
                ssp.BackColor = Color.Red;


                // throw;
            }


        }

        private void itemDeportista_Click(object sender, EventArgs e)
        {
            frmRegistroDeportista frmRD = new frmRegistroDeportista();
            frmRD.ShowDialog();
        }

        private void itemEntrenador_Click(object sender, EventArgs e)
        {
            frmRegistroEntrenador frmRE = new frmRegistroEntrenador();
            frmRE.ShowDialog();
        }

        private void itemDeportista1_Click(object sender, EventArgs e)
        {
            frmConsultaRegistroDeportista frmCRD = new frmConsultaRegistroDeportista();
            frmCRD.ShowDialog();
        }

        private void itemEntrenador1_Click(object sender, EventArgs e)
        {
            frmConsultaRegistroEntrenador frmCRE = new frmConsultaRegistroEntrenador();
            frmCRE.ShowDialog();
        }
    }
}
