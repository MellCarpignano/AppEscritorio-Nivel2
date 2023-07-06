using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class ArticulosNegocio
    {

        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server= .\\SQLEXPRESS; database= CATALOGO_DB; integrated security= true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.id,codigo, nombre, A.descripcion, C.Descripcion AS CATEGORIA, M.Descripcion AS MARCA,m.id as IDMARCA, C.ID AS IDCATEGORIA, imagenurl, idmarca, IdCategoria, precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca = M.Id AND IdCategoria= C.ID";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if(!(lector ["ImagenUrl"] is DBNull))
                         aux.ImagenUrl = (string)lector["ImagenUrl"];
                    
                    aux.Precio = (decimal)lector["Precio"];
                    
                    aux.IdMarca = (int)lector["IdMarca"];
                    aux.IdCategoria = (int)lector["IdCategoria"];
                    
                
                    aux.Categoria = new Categorias();
                    aux.Categoria.id = (int)lector["idCategoria"];
                    aux.Categoria.descripcion = (string)lector["Categoria"];

                
                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];


                   
                   
                   



                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void Agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into articulos(codigo, nombre, descripcion, precio, Idmarca, Idcategoria, ImagenUrl) values (@Codigo, @Nombre, @Descripcion, @Precio, @Marca, @Categoria, @ImagenUrl)");
                datos.SetearParametro("@Marca", nuevo.Marca.Id);
                datos.SetearParametro("@Categoria", nuevo.Categoria.id);
                datos.SetearParametro("@Codigo", nuevo.Codigo);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@Precio", nuevo.Precio);
                datos.SetearParametro("@ImagenUrl", nuevo.ImagenUrl);

                datos.EjectuarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public void Modificar(Articulos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update articulos set Codigo= @cod, Nombre= @nombre, Descripcion= @desc, ImagenUrl = @img, precio= @precio where Id = @Id; ");
                datos.SetearParametro("@cod", modificar.Codigo);
                datos.SetearParametro("@nombre", modificar.Nombre);
                datos.SetearParametro("@desc", modificar.Descripcion);
                datos.SetearParametro("@img", modificar.ImagenUrl);
                datos.SetearParametro("@precio",modificar.Precio);
                datos.SetearParametro("@id",modificar.Id);

                datos.EjectuarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.CerrarConexion();
            }
        }


        public void eliminarArticulo( string codigo)
        {
           
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from ARTICULOS where Codigo = @cod");
                datos.SetearParametro("@cod", codigo);
                datos.EjectuarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }






        public List<Articulos> filtrar(string campo, string criterio, string filtro)
        {

            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
              
                string consulta = "select A.id,codigo, nombre, A.descripcion, C.Descripcion AS CATEGORIA, M.Descripcion AS MARCA,m.id as IDMARCA, C.ID AS IDCATEGORIA, imagenurl, idmarca, IdCategoria, precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca = M.Id AND IdCategoria= C.ID and ";
                 

                if(campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Empieza con ..":
                            consulta += "Nombre from like '" + filtro + "%' ";
                            break;
                        case "Termina con..":
                                consulta += "Nombre like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "Nombre like '%" + filtro + "%' ";
                            break;
                    }
                

                }
                
                else if( campo== "Precio")
                {
                    switch (criterio)
                    {
                        case " Menor a $ 10.000":
                            consulta += "precio > " + filtro;
                           break;
                         case "Entre $10.000 y $40.000":
                            consulta += "precio  > " + filtro;
                            break;
                        case "Mas de $40.000":
                            consulta += "precio >" + filtro;
                            break;

                        default:
                            break;
                    }
                }


                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();



                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];


                    aux.Categoria = new Categorias();
                    aux.Categoria.id = (int)datos.Lector["idCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["Categoria"];


                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];








                    lista.Add(aux);
                }


                return lista;
            }
            


            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
