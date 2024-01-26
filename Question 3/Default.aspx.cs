using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;
using System.Diagnostics;
using System.Xml.Linq;
using System.Net;

namespace Question_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connstring;
                SqlConnection conn;

                connstring = @"Server=localhost;Database=EmployerDBESmith;Trusted_Connection=True;";
                conn = new SqlConnection(connstring);
                conn.Open();

                string queryString = "select * from students";
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "students");
                Repeater1.DataSource = ds;
                Repeater1.DataBind();

                conn.Close();
            }
        }

        public void Edit(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string id = btn.CommandArgument;

            Response.Redirect(string.Format("~/Edit.aspx?id={0}", id));
        }

        public void Delete(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string id = btn.CommandArgument;

            string connstring;
            SqlConnection conn;

            connstring = @"Server=localhost;Database=EmployerDBESmith;Trusted_Connection=True;";
            conn = new SqlConnection(connstring);

            string queryString = "DELETE FROM  students WHERE id = @id";

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("@id", id);

            conn.Open();

            command.ExecuteNonQuery();
            conn.Close();

            Response.Redirect(Request.RawUrl);
        }
    }
}