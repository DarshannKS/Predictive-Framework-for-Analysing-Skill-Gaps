using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Faculty
{
    public partial class teacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Loadcounts();
            }
        }
        private void Loadcounts()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            string sql = "Select Count(id) from CR_Training";


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                Label1.Text = Convert.ToString(count);
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {

            }
        }
    }
}