using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_3
{
    public partial class Create : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Submit();
            }
        }
        public void Submit()
        {
            string firstname = txtName.Text;
            string lastname = txtSurname.Text;
            string gender = txtGender.Text;
            DateTime dob = DateTime.Parse(txtDob.Text);
            string address = txtAddress.Text;
            string subjects = txtSubjects.Text;

            string connstring;
            SqlConnection conn;

            connstring = @"Server=localhost;Database=EmployerDBESmith;Trusted_Connection=True;";
            conn = new SqlConnection(connstring);

            string queryString = "INSERT INTO students " +
                "(name, surname, gender, dob, address, subjects) " +
                "VALUES " +
                "(@name, @surname, @gender, @dob, @address, @subjects)";

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("@name", firstname);
            command.Parameters.AddWithValue("@surname", lastname);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@subjects", subjects);

            conn.Open();

            command.ExecuteNonQuery();
            //to be refactored with a checkboxlist and saved in a table called subjects, linked by foreign keys, but wasn't sure I would make it in time
            //and instructions didn't specify

            //var recordId = Convert.ToInt32(id.ToString());

            //Response.Write(recordId + " inserted id");
            conn.Close();

            //for (int i = 0; i < checkboxlist1.Items.Count; i++)
            //{
            //    if (checkboxlist1.Items[i].Selected == true)
            //    {
            //        Response.Write(checkboxlist1.Items[i].Value);

            //        queryString = "INSERT INTO subjects (subjectid, studentid) VALUES (@subjectid, @studentid)";

            //        SqlCommand subjectcommand = new SqlCommand(queryString, conn);
            //        command.Parameters.AddWithValue("@subject", firstname);
            //        conn.Open();

            //        command.ExecuteNonQuery();

            //        //Response.Write(recordId + " inserted id");
            //        conn.Close();
            //    }
            //}
            Response.Redirect("~/");
        }        
    }
}