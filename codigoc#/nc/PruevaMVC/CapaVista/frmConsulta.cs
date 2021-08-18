using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;


namespace CapaVista
{
    public partial class frmConsulta : Form
    {
        clsControlador cn = new clsControlador();

        string tabla = "bodegas";
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dtgConsulta.DataSource = dt;

        }
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
