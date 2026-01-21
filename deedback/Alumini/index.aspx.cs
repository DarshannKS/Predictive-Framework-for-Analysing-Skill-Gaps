using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Alumini
{
    public partial class index : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            Hidden1.Value = Session["nme"].ToString();

            loaddata();
           
            if (!Page.IsPostBack)
            {
                loaddata();
            }
        }

        private void loaddata()
        {
            string ComId = Session["Username"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            cmd.Connection = con;
            cmd.CommandText = "select * from Chat_Bot";
            con.Open();
            RepeatInformation.DataSource = cmd.ExecuteReader();
            RepeatInformation.DataBind();
            con.Close();
        }

        [System.Web.Services.WebMethod()]
        public static int InActive(string JID, string txtmsg)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            string sql = "";



            con.Open();
            sql = "insert into [Chat_Bot] (Cname,Msg_desc)values('" + JID + "','" + txtmsg + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (cmd.ExecuteNonQuery() > 0)

                return 1;
            return 0;

            con.Close();

        }
    }
}