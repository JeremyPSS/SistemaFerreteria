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
        //PromocionLN opln = new PromocionLN();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                ListarProductos();
                /*
                ListPromociones();
                ListMedicamentosCombo();
                */
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
                    //ListMedicamentosCombo();
                    //ClearInformation();
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
            //int idcategoria = int.Parse( ddlCategoria.SelectedValue.ToString());


            ProductoCE obj = new ProductoCE(id,nom,precio,cant,1);
            return obj;
        }
        /*
        public void ClearInformation()
        {
            txtAlmacenamiento.Text = "";
            txtCantidad.Text = "";
            txtEnpaque.Text = "";
            txtEspecificacion.Text = "";
            txtIdMedicamento.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtPresentacion.Text = "";
            txtViaAdministracion.Text = "";
        }

        public void SetData(MedicamentoCE ob)
        {
            txtAlmacenamiento.Text = ob.Almacenamiento;
            txtCantidad.Text = ob.Cantidad.ToString();
            txtEnpaque.Text = ob.Enpaque;
            txtEspecificacion.Text = ob.Especificacion;
            txtIdMedicamento.Text = ob.IdMedicamento.ToString();
            txtNombre.Text = ob.Nombre;
            txtPrecio.Text = ob.Precio.ToString();
            txtPresentacion.Text = ob.Presentacion;
            txtViaAdministracion.Text = ob.ViaAdministracion;
            try
            {
                calFechaVencimiento.SelectedDate = ob.FechaVencimiento;
                ddlPromocion.SelectedIndex = ob.IdPromocion-1;
            }
            catch(Exception ex)
            {

            } 
            
            
        }
        public void ListPromociones()
        {
            try
            {
                ddlPromocion.DataSource = opln.ViewPromociones();
                ddlPromocion.DataValueField = "idPromocion";
                ddlPromocion.DataTextField = "tipo";
                ddlPromocion.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al listar promociones')</script>");
            }
        }

        public void ListMedicamentosCombo()
        {
            try
            {
                ddlEditar.DataSource = omln.ViewMedicamento();
                ddlEditar.DataValueField = "idMedicamento";
                ddlEditar.DataTextField = "nombre";
                ddlEditar.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al listar medicamentos')</script>");
            }
        }
        */
        public void ListarProductos()
        {
            GridView1.DataSource = omln.ViewProducto();
            GridView1.DataBind();
        }
        
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //ClearInformation();
            //if (btnRegistrar.Visible == false) btnRegistrar.Visible = true;
            //if (btnGuardarEditar.Visible == true) btnGuardarEditar.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Edit();
        }
        /*
        public void Edit()
        {
            int id;
            try
            {
                id = int.Parse(ddlEditar.SelectedValue.ToString());
                MedicamentoCE ob = omln.GetMedicamento(id);
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
        */
        protected void Button3_Click(object sender, EventArgs e)
        {
            //Delete();
        }
        /*
        public void Delete()
        {
           
            int id;
            try
            {
                id = int.Parse(ddlEditar.SelectedValue.ToString());
                MedicamentoCE ob = omln.GetMedicamento(id);
                omln.DeleteMedicamento(ob);
                ListarMedicamentos();
                ListMedicamentosCombo();
                Response.Write("<script>alert('Se ha eliminado exitosamente')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un error al eliminar')</script>");
            }
        }
        */
        protected void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                if (Validar() == true)
                {
                    MedicamentoCE ob = CreateObject();
                    omln.UpdateMedicamento(ob);
                    btnRegistrar.Visible = true;
                    btnGuardarEditar.Visible = false;
                    ClearInformation();
                    ListarMedicamentos();
                    ListMedicamentosCombo();
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
            */
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