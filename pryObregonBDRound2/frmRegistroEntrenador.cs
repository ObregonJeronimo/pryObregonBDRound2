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
    public partial class frmRegistroEntrenador : Form
    {

        public OleDbConnection conexionBD; //declaracion de conexion de BD
        public OleDbCommand comandoBD;//representa una instruccion 


        //declaracion de la ruta donde esta alojada la BD
        public string RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        public frmRegistroEntrenador()
        {
            InitializeComponent();
        }


        private void frmRegistroEntrenador_Load(object sender, EventArgs e)
        {

        }


        private void btnRegistroDeportistas_Click(object sender, EventArgs e)
        {
            try
            {
                conexionBD = new OleDbConnection(RutaBD);
                conexionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD; //conexion al origen de datos
                comandoBD.CommandType = CommandType.Text; //comando para insertar datos
                comandoBD.CommandText = "INSERT INTO" + " ENTRENADORES ([NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                        " VALUES ('" + txtApellidoEntrenador.Text + "','" + txtApellidoEntrenador.Text + "','" + txtDireccionEntrenador.Text + "','" + txtProvincia.Text + "','" + lstDeporte.SelectedItem + "')";

                comandoBD.ExecuteNonQuery();//numero de filas afectadas
                MessageBox.Show("Tus datos fueron ingresados con exito");
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
