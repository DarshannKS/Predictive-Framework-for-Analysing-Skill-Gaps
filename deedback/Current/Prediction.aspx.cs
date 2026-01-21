using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Current
{
    public partial class Prediction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                GetReport();
                //string stdUSN = "UO1CO22SO160";

                string stdUSN = Session["usn"].ToString(); // Replace with actual input (e.g., from textbox or session)

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Constr"]))
                {
                    string query = @"
                    SELECT 
                        StdUSN,
                        SUM(CAST(marks AS FLOAT)) AS TotalMarks,
                        AVG(CAST(marks AS FLOAT)) AS AvgMarks
                    FROM 
                        CR_Mark
                    WHERE 
                        TRY_CAST(marks AS FLOAT) IS NOT NULL AND
                        StdUSN = @StdUSN
                    GROUP BY 
                        StdUSN";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StdUSN", stdUSN);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        private void GetReport()
        {
            // Get StdUSN from the input field
            string stdUSN = Session["usn"].ToString();

            if (!string.IsNullOrEmpty(stdUSN))
            {
                // Call method to execute the query and display the result
                string result = GetStudentReport(stdUSN);

                // Display the result on the page
                lblResults.Text = result;
            }
            else
            {
                lblResults.Text = "Please enter a valid Student USN.";
            }
        }

        // Method to fetch the student report based on the StdUSN
        private string GetStudentReport(string stdUSN)
        {
            // SQL query to retrieve the report data
            string query = @"
                SELECT
                    StdUSN,
                    COUNT(DISTINCT CourseSem) AS TotalSemesters,
                    COUNT(Subject) AS TotalSubjects,
                    SUM(CAST(marks AS FLOAT)) AS TotalMarks,
                    ROUND(AVG(CAST(marks AS FLOAT)), 2) AS AvgMarks,
                    CASE
                        WHEN AVG(CAST(marks AS FLOAT)) >= 60 THEN 'Research or Higher Studies Path'
                        WHEN AVG(CAST(marks AS FLOAT)) >= 50 THEN 'Industry Internships or Advanced Certifications'
                        WHEN AVG(CAST(marks AS FLOAT)) >= 40 THEN 'Domain-Specific Certifications or Live Projects'
                        ELSE 'Suggested: Foundation Courses or Skill-building Internships'
                    END AS Suggested_Path
                FROM CR_Mark
                WHERE StdUSN = @StdUSN AND ISNUMERIC(marks) = 1
                GROUP BY StdUSN";
           // SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Constr"])
            // Create a connection and command to execute the query
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Constr"]))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StdUSN", stdUSN);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                // If data is found, process the results
                if (reader.HasRows)
                {
                    reader.Read();
                    string result = $@"
                        <strong>Student USN:</strong> {reader["StdUSN"]}<br>
                        <strong>Total Semesters:</strong> {reader["TotalSemesters"]}<br>
                        <strong>Total Subjects:</strong> {reader["TotalSubjects"]}<br>
                        <strong>Total Marks:</strong> {reader["TotalMarks"]}<br>
                        <strong>Average Marks:</strong> {reader["AvgMarks"]}<br>
                        <strong>Suggested Path:</strong> {reader["Suggested_Path"]}<br>
                    ";

                    return result;
                }
                else
                {
                    return "No data found for the given Student USN.";
                }
            }
        }

        private string GetRecommendation(float avgMarks)
        {
            if (avgMarks >= 8)
                return "Higher Education";
            else if (avgMarks >= 6)
                return "Specialized Courses";
            else
                return "Entry-Level Jobs";
        }
    }
}