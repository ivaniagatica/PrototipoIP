using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace logisticainventario


    {
        class clsConexion
        {
            public OdbcConnection conexion()
            {
                //creacion de la conexion via ODBC
                OdbcConnection conn = new OdbcConnection("Dsn=inventario");
                try
                {
                    conn.Open();
                }
                catch (OdbcException)
                {
                    Console.WriteLine("No Conectó");
                }
                return conn;
            }

            //metodo para cerrar la conexion
            public void desconexion(OdbcConnection conn)
            {
                try
                {
                    conn.Close();
                }
                catch (OdbcException)
                {
                    Console.WriteLine("No Conectó");
                }
            }
        }
    }


