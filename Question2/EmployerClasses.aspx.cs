using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question2
{
    public partial class EmployerClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connstring;
                SqlConnection conn;

                connstring = @"Server=localhost;Database=EmployerDBJESmith;Trusted_Connection=True;";
                conn = new SqlConnection(connstring);
                conn.Open();

                string queryString = "select * from EmployerClasses";
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "employer_classes");

                employer_classes.DataSource = ds;
                employer_classes.DataTextField = "EmployerClassName";
                employer_classes.DataValueField = "id";
                employer_classes.DataBind();

                conn.Close();
            }
        }

        public void employerclassChange(object sender, EventArgs e)
        {
            string employerclass = employer_classes.Items[employer_classes.SelectedIndex].Value.ToString();

            string connstring;
            SqlConnection conn;

            connstring = @"Server=localhost;Database=EmployerDBJESmith;Trusted_Connection=True;";
            conn = new SqlConnection(connstring);
            conn.Open();

            string queryString = "select * from EmployerSubClasses where ClassRef = @1";


            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@1", employerclass);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "employer_sub");

            employer_sub.DataSource = ds;
            employer_sub.DataTextField = "EmployerSubClassShortDescription";
            employer_sub.DataValueField = "id";
            employer_sub.DataBind();

            conn.Close();
        }
    }
}