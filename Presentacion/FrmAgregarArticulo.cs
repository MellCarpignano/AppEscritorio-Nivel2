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

namespace Presentacion
{
    public partial class FrmAgregarArticulo : Form
    {
        private Articulos articulos = null;
        public FrmAgregarArticulo()
        {
            InitializeComponent();
        }
        public FrmAgregarArticulo(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = "Modificar Articulo";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulos newArticulo = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                if (articulos == null)
                    articulos = new Articulos();

                articulos.Codigo = txtCodArt.Text;
                articulos.Nombre = txtNombreArt.Text;
                articulos.Descripcion = txtDescrpArt.Text;
                articulos.Precio = decimal.Parse(txtPrecioArt.Text);
                articulos.ImagenUrl = txtUrlImagen.Text;
                articulos.Marca = (Marcas)cboMarca.SelectedItem;
                articulos.Categoria = (Categorias)cboCategoria.SelectedItem;


                if(articulos.Id != 0)
                {

                    negocio.Modificar(articulos);
                    MessageBox.Show("Modificado Exitosamente");

                }
                else
                {
                    negocio.Agregar(articulos);
                    MessageBox.Show("Agregado Exitosamente");

                }
               
               
              
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            CategoriasNegocio negocioC = new CategoriasNegocio();

            try
            {
                cboMarca.DataSource = negocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = negocioC.listarC();
                cboCategoria.ValueMember = "id";
                cboCategoria.DisplayMember = "descripcion";

                if(articulos != null)
                {
                    txtCodArt.Text = articulos.Codigo;
                    txtNombreArt.Text = articulos.Nombre;
                    txtDescrpArt.Text = articulos.Descripcion;
                    txtUrlImagen.Text = articulos.ImagenUrl;
                    txtPrecioArt.Text = articulos.Precio.ToString();
                    cargarImagen(articulos.ImagenUrl);
                    cboMarca.SelectedValue = articulos.Marca.Id;
                    cboCategoria.SelectedValue = articulos.Categoria.id;
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }



        private void cargarImagen(string imagen)
        {
            try
            {
                pbxUrlImgen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxUrlImgen.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void txtCodArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioArt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
