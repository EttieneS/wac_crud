using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Question_3
{
    public partial class Edit : System.Web.UI.Page
    {
        public DataRow _currentRow;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string id = Request.QueryString["id"];

                if ((id == null) || (id == ""))
                {
                    Response.Redirect(string.Format("~/Default.aspx"));
                }

                string connstring;
                SqlConnection conn;

                connstring = @"Server=localhost;Database=EmployerDBESmith;Trusted_Connection=True;";
                conn = new SqlConnection(connstring);
                conn.Open();

                string queryString = "SELECT * FROM students WHERE id = (@id)";

                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);

                DataSet ds = new DataSet();
                DataTable table = new DataTable();
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(table);

                _currentRow = table.Rows[0];
                Page.DataBind();

                conn.Close();
            }
        }

        public void Update(Object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string gender = txtGender.Text;
            string dob = txtDob.Text;
            string address = txtAddress.Text;
            string subjects = txtSubjects.Text;

            string connstring;
            SqlConnection conn;

            connstring = @"Server=localhost;Database=EmployerDBESmith;Trusted_Connection=True;";
            conn = new SqlConnection(connstring);
            conn.Open();
            Response.Write("Connection made update");

            string queryString = "UPDATE students set " +
                "name = @name, surname = @surname, gender = @gender, dob = @dob, address = @address, subjects = @subjects " +
                "WHERE id = @id";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = new SqlCommand(queryString, conn);
            adapter.UpdateCommand.Parameters.AddWithValue("@name", name);
            adapter.UpdateCommand.Parameters.AddWithValue("@surname", surname);
            adapter.UpdateCommand.Parameters.AddWithValue("@gender", gender);
            adapter.UpdateCommand.Parameters.AddWithValue("@dob", dob);
            adapter.UpdateCommand.Parameters.AddWithValue("@address", address);
            adapter.UpdateCommand.Parameters.AddWithValue("@subjects", subjects);
            adapter.UpdateCommand.Parameters.AddWithValue("@id", id);
            adapter.UpdateCommand.ExecuteNonQuery();

            conn.Close();

            Response.Redirect(string.Format("~/Default.aspx"));
        }
    }
}