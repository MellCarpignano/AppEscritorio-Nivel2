using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDeDominio;
using Negocio;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class FrmEliminarArticulo : Form
    {

        private Articulos deleteArt = null;
        public FrmEliminarArticulo()
        {
            InitializeComponent();
            Text = "Eliminar Articulo";
        }

        private void btnAceptarElim_Click(object sender, EventArgs e)
        {

        }


        private void FrmEliminarArticulo_Load(object sender, EventArgs e)
        {
   
            
        }

        private void BtnCancelarElim_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
