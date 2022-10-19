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
        //declarando var y obj globales

        OleDbConnection conexionBase;
        OleDbCommand queQuieroDeLaBase;
        OleDbDataReader lectorDeConsultas;

        string varRutaDeBaseDeDatos =
            "D:\\Escritorio\\pryObregonBDRound2\\pryObregonBDRound2\\DEPORTE.accdb";
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                lblFechaActual.Text = DateTime.Now.ToString();

                conexionBase = new OleDbConnection(
                    "Provider=Microsoft." +
                    "ACE.OLEDB.12.0;Data Source =" +
                    varRutaDeBaseDeDatos);

                conexionBase.Open();

                lblEstado.Text = "Conectado: " + conexionBase.ConnectionString;
                lblEstado.ForeColor = Color.Green;

            }
            catch (Exception mensajeError)
            {
                lblEstado.Text = mensajeError.Message;

                ssp.BackColor = Color.Red;
                //cambia color a rojo si no se conecta
            }

        }


    }
}
