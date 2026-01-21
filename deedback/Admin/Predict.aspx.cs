using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Admin
{
    public partial class Predict : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Constr"]))
                {
                    string query = @"
    SELECT 
        CourseSem,
        SUM(CAST(marks AS FLOAT)) AS TotalMarks,
        AVG(CAST(marks AS FLOAT)) AS AvgMarks
    FROM 
        CR_Mark
    WHERE 
        TRY_CAST(marks AS FLOAT) IS NOT NULL
    GROUP BY 
        CourseSem";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Add Recommendation Column
                    dt.Columns.Add("Recommendation", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        float avg = Convert.ToSingle(row["AvgMarks"]);
                        row["Recommendation"] = GetRecommendation(avg);
                    }

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }

            }
        }

        private string GetRecommendation(float avgMarks)
        {
            if (avgMarks >= 80)
                return "Higher Education";
            else if (avgMarks >= 60)
                return "Specialized Courses";
            else
                return "Entry-Level Jobs";
        }
    }
}