using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using ModeloDeDominio;



namespace Presentacion
{
    public partial class FrmPresentacion : Form
    {
        private List<Articulos> listaArticulos;
        private readonly object cboMarca;

        public FrmPresentacion()
        {
            InitializeComponent();
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {

            Cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Precio");
          
            

        }


        private void Cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {

                listaArticulos = negocio.listar();
                dgvPresent.DataSource = listaArticulos;
                dgvPresent.Columns["ImagenUrl"].Visible = false;
                dgvPresent.Columns["IdMarca"].Visible = false;
                dgvPresent.Columns["IdCategoria"].Visible = false;
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void dgvPresent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbxPresent_Click(object sender, EventArgs e)
        {

        }

        private void dgvPresent_SelectionChanged(object sender, EventArgs e)
        {

            Articulos seleccionado = (Articulos)dgvPresent.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPresent.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxPresent.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo alta = new FrmAgregarArticulo();
            alta.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvPresent.CurrentRow.DataBoundItem;

            FrmAgregarArticulo modificar = new FrmAgregarArticulo(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos seleccionado;
            try
            {
                

                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvPresent.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.Codigo);
                    Cargar();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }


        private void btnfiltro1_Click(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txtFiltro1.Text;

            if (filtro != "")
            {
                
                listaFiltrada = listaArticulos.FindAll(itemListaArt => itemListaArt.Nombre.ToUpper().Contains(txtFiltro1.Text.ToUpper())); ;
            }
            else
            {
                listaFiltrada = listaArticulos;
            }


            dgvPresent.DataSource = null;
            dgvPresent.DataSource = listaFiltrada;
        }

        private void txtFiltro1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFiltro1_TextChanged(object sender, EventArgs e)
        {

            List<Articulos> listaFiltrada;
            string filtro = txtFiltro1.Text;


            if (filtro.Length >= 3)
            {

                listaFiltrada = listaArticulos.FindAll(itemListaArt => itemListaArt.Nombre.ToUpper().Contains(txtFiltro1.Text.ToUpper())); ;
            }
            else
            {
                listaFiltrada = listaArticulos;
            }


            dgvPresent.DataSource = null;
            dgvPresent.DataSource = listaFiltrada;
        }

        private void cboCategoriaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            
          
            
            if( opcion == "Nombre")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con..");
                cboCriterio.Items.Add("Termina con..");
                cboCriterio.Items.Add("Contiene..");
                
            }

            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Menor a $10.000");
                cboCriterio.Items.Add("Entre $10.000 y $40.000");
                cboCriterio.Items.Add("Mas de $40.000");
            }

            



        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool validarFiltro()
        {
          


            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el CAMPO para poder filtrar");
                return true;
            }

            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el CRITERIO para poder filtrar");
                return true;
            }

            if (cboCampo.SelectedItem.ToString() == "Precio")
            {

                if (string.IsNullOrEmpty(txtFiltroBusq.Text))
                {
                    MessageBox.Show("Por favor carge el filtro de busqueda con un numerico");
                    return true;
                }


                if (!(soloValNumericos(txtFiltroBusq.Text)))
                {


                    MessageBox.Show("Ingrese solo numeros para filtrar");
                    return true;
                }
            }

            return false;
        }
       
        private bool soloValNumericos(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }






        private void btnOKbusq_Click(object sender, EventArgs e)
        {

            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {

                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroBusq.Text;
                
               
                dgvPresent.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void txtFiltroBusq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
