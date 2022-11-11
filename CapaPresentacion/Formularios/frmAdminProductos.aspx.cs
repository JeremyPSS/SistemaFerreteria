//using CapaEntidades.Inventario;
//using CapaLogica.Inventario;
using CapaEntidades.Inventory;
using CapaLogica.Inventory;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaFarmaciaWeb.Formularios
{
    public partial class frmAdminMedicamentos : System.Web.UI.Page
    {
        
        //GLOBAL VARIABLES
        ProductoLN omln = new ProductoLN();
        CategoriaLN opln = new CategoriaLN();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                ListarProductos();
                ListProductosCombo();
                
                ListCategoria();
                
                //btnPrueba.Enabled = false;
                btnGuardarEditar.Visible = false;
            }
            
        }
        
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Save();
        }
        
        public void Save()
        {
            try
            {
                if (Validar() == true)
                {
                    ProductoCE obj = CreateObject();
                    omln.CreateProducto(obj);
                    ListarProductos();
                    ListProductosCombo();
                    ClearInformation();
                    Response.Write("<script>alert('Se ha insertado correctatmente')</script>");
                }
                else
                {
                Response.Write("<script>alert('Ingrese correctamente los datos')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al registrar el medicamento,')</script>");
                lblerror.Text = "ERROR!!!!!!" + ex.Message;
            }
        }

        public void SaveCategoria()
        {
            try
            {
                if (txtCodigoCategoria.Text.Trim().Length != 0 && txtNombreCategoria.Text.Trim().Length !=0 && txtDescripcionCategoria.Text.Trim().Length!=0)
                {
                    CategoriaCE obj = CreateObjectCategoria();
                    opln.CreateCategoria(obj);
                    
                    ListCategoria();
                    ClearInformation();
                    Response.Write("<script>alert('Se ha insertado correctatmente')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Ingrese correctamente los datos')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al registrar el medicamento,')</script>");
                lblerror.Text = "ERROR!!!!!!" + ex.Message;
            }
        }

        public ProductoCE CreateObject()
        {
            int id = int.Parse(txtIdProducto.Text);
            string nom = txtNombre.Text;
            double precio = double.Parse(txtPrecio.Text , CultureInfo.InvariantCulture); //CultureInfo help us to detect the decimal point
            int cant = int.Parse(txtCantidad.Text);
            int idcategoria = int.Parse( ddlCategoria.SelectedValue.ToString());


            ProductoCE obj = new ProductoCE(id,nom,precio,cant,idcategoria);
            return obj;
        }

        public CategoriaCE CreateObjectCategoria()
        {
            int id = int.Parse(txtCodigoCategoria.Text);
            string nom = txtNombreCategoria.Text;
            string des = txtDescripcionCategoria.Text;


            CategoriaCE obj = new CategoriaCE(id, nom, des);
            return obj;
        }

        public void ClearInformation()
        {
            txtCodigoCategoria.Text = "";
            txtCantidad.Text = "";
            txtDescripcionCategoria.Text = "";
            txtIdProducto.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtNombreCategoria.Text = "";
        }
        
        public void SetData(ProductoCE ob)
        {
            txtIdProducto.Text = ob.Id_Producto.ToString();
            txtNombre.Text = ob.Nombre;
            txtCantidad.Text =  ob.Stock.ToString();
            txtPrecio.Text = ob.Precio.ToString();         
            try
            {
                //calFechaVencimiento.SelectedDate = ob.FechaVencimiento;
                ddlCategoria.SelectedIndex = ob.Id_Categoria-1;
            }
            catch(Exception ex)
            {

            } 
            
            
        }
        
        public void ListCategoria()
        {
            try
            {
                ddlCategoria.DataSource = opln.ViewCategoria();
                ddlCategoria.DataValueField = "id_Categoria";
                ddlCategoria.DataTextField = "nombre";
                ddlCategoria.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al listar promociones')</script>");
            }
        }
        
        public void ListProductosCombo()
        {
            try
            {
                ddlEditar.DataSource = omln.ViewProducto();
                ddlEditar.DataValueField = "id_Producto";
                ddlEditar.DataTextField = "nombre";
                ddlEditar.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al listar medicamentos')</script>");
            }
        }
        
        public void ListarProductos()
        {
            GridView1.DataSource = omln.ViewProducto();
            GridView1.DataBind();
        }
        
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearInformation();
            if (btnRegistrar.Visible == false) btnRegistrar.Visible = true;
            if (btnGuardarEditar.Visible == true) btnGuardarEditar.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Edit();
        }
        
        public void Edit()
        {
            int id;
            try
            {
                id = int.Parse(ddlEditar.SelectedValue.ToString());
                ProductoCE ob = omln.GetProducto(id);
                ClearInformation();
                SetData(ob);
                btnGuardarEditar.Visible = true;
                btnRegistrar.Visible = false;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al editar')</script>");
            }

        }
        
        protected void Button3_Click(object sender, EventArgs e)
        {
            Delete();
        }

        protected void Button4_Click(object sender, EventArgs e) 
        {
            SaveCategoria();
        }


        public void Delete()
        {
           
            int id;
            try
            {
                id = int.Parse(ddlEditar.SelectedValue.ToString());
                //ProductoCE ob = omln.GetMedicamento(id);
                omln.DeleteProducto(id);
                ListarProductos();
                ListProductosCombo();
                Response.Write("<script>alert('Se ha eliminado exitosamente')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al eliminar')</script>");
            }
        }
        
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Validar() == true)
                {
                    
                    ProductoCE ob = CreateObject();
                    omln.UpdateProducto(ob,ob.Id_Producto);
                    btnRegistrar.Visible = true;
                    btnGuardarEditar.Visible = false;
                    ClearInformation();
                    ListarProductos();
                    ListProductosCombo();
                    Response.Write("<script>alert('Se ha editado correctatmente')</script>");
                    
                }
                else
                {
                    Response.Write("<script>alert('Ingrese correctamente los datos')</script>");
                }
                
            }catch(Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un errores')</script>");
            }
            
        }
        public bool Validar()
        {
            bool valor = true;
            if ( txtCantidad.Text.Trim().Length == 0 
                ||  txtNombre.Text.Trim().Length == 0 || txtPrecio.Text.Trim().Length == 0 )
            {
                valor = false;
            }
            return valor;
        }


        

    }
}