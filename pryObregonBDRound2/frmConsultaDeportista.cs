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
    public partial class frmConsultaDeportista : Form
    {

        //declarando var y obj globales

        OleDbConnection conexionBase;
        OleDbCommand queQuieroDeLaBase;
        OleDbDataReader lectorDeConsultas;

        string varRutaDeBaseDeDatos =
            "D:\\Escritorio\\pryObregonBDRound2\\pryObregonBDRound2\\DEPORTE.accdb";

        public frmConsultaDeportista()
        {
            InitializeComponent();
        }

        private void frmConsultaDeportista_Load(object sender, EventArgs e)
        {
            try
            {

                conexionBase = new OleDbConnection(
                    "Provider=Microsoft." +
                    "ACE.OLEDB.12.0;Data Source =" +
                    varRutaDeBaseDeDatos);

                conexionBase.Open();

                queQuieroDeLaBase = new OleDbCommand();

                queQuieroDeLaBase.Connection = conexionBase;
                queQuieroDeLaBase.CommandType = CommandType.TableDirect;
                queQuieroDeLaBase.CommandText = "DEPORTISTA";

                lectorDeConsultas = queQuieroDeLaBase.ExecuteReader();

                lblDatos.Text = "";

                while (lectorDeConsultas.Read())
                {
                    lblDatos.Text += lectorDeConsultas["Nombre"].ToString() + "\n";
                }

                lectorDeConsultas.Close();
                conexionBase.Close();

                //Reducir la ruta del archivo, que indique a la carpeta del proyecto
                //Vincular la grilla con los datos
            }
            catch (Exception mensajeError)
            {
                lblDatos.Text = mensajeError.Message;
            }
        }
    }
}
