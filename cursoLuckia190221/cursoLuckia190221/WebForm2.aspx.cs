using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cursoLuckia190221
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = TextBox1.Text;
            string nombre = TextBox2.Text;
            string apellidos = TextBox3.Text;
            string email = TextBox4.Text;
            string direccion = TextBox5.Text;
            string contrasenya = TextBox6.Text;


            SqlConnection con = new SqlConnection("Data Source=PLX300000002207\\SQLEXPRESS;Database=AdventureWorksLT2017;Integrated Security=SSPI;Trusted_Connection=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO dbo.Usuarios (usuario,Nombre,Apellidos,Email,Direccion,contrasenya) VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";

            cmd.Parameters.AddWithValue("@param1", usuario);
            cmd.Parameters.AddWithValue("@param2", nombre);
            cmd.Parameters.AddWithValue("@param3", apellidos);
            cmd.Parameters.AddWithValue("@param4", email);
            cmd.Parameters.AddWithValue("@param5", direccion);
            cmd.Parameters.AddWithValue("@param6", contrasenya);

            cmd.ExecuteNonQuery();
            con.Close();

            TextBox1.Text="";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";


        }
    }
}