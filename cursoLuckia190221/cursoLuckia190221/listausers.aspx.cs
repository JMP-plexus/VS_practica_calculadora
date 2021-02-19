using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cursoLuckia190221
{
    public partial class listausers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PLX300000002207\\SQLEXPRESS;Database=AdventureWorksLT2017;Integrated Security=SSPI;Trusted_Connection=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT userID, usuario,Nombre,Apellidos,Email,Direccion,contrasenya FROM USUARIOS";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TableRow r = new TableRow();
                    TableCell c0 = new TableCell();
                    c0.Controls.Add(new LiteralControl(reader.GetInt32(0).ToString()));
                    r.Cells.Add(c0);
                    for (int i = 1; i < 7; i++)
                    {
                        TableCell c = new TableCell();
                        c.Controls.Add(new LiteralControl(reader.GetString(i)));
                        r.Cells.Add(c);
                    }
                    Table1.Rows.Add(r);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            con.Close();
        }
    }
}