using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Admin
{
    public partial class graph : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindChart();
            imghacker();
            RenderAvgMarksChart();
        }

        private void RenderAvgMarksChart()
        {
            DataTable chartData = GetAvgMarksPerSemester();
            StringBuilder strScript = new StringBuilder();

            strScript.Append(@"<script type='text/javascript' src='https://www.gstatic.com/charts/loader.js'></script>
<script type='text/javascript'>
google.charts.load('current', { packages: ['corechart'] });
google.charts.setOnLoadCallback(drawChart);
function drawChart() {
    var data = google.visualization.arrayToDataTable([
        ['Semester', 'Average Marks'],");

            foreach (DataRow row in chartData.Rows)
            {
                string semester = row["CourseSem"].ToString();
                string avgMarks = Convert.ToDecimal(row["AvgMarks"]).ToString("0.00");
                strScript.Append("['Semester " + semester + "', " + avgMarks + "],");
            }
            strScript.Length--; // Remove trailing comma

            strScript.Append(@"]);
    var options = {
        title: 'Average Marks Per Semester',
        backgroundColor: 'transparent',
        hAxis: { title: 'Semester' },
        vAxis: { title: 'Average Marks', minValue: 0 },
        legend: 'none'
    };
    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div2'));
    chart.draw(data, options);
}
</script>");

            Literal1.Text = strScript.ToString();
        }

        private DataTable GetAvgMarksPerSemester()
        {
            DataSet dsData = new DataSet();
            try
            {
                string connStr = ConfigurationManager.AppSettings["ConStr"];
                using (SqlConnection sqlCon = new SqlConnection(connStr))
                {
                    string queryString = @"
                    SELECT CourseSem, AVG(CAST(MARKS AS FLOAT)) AS AvgMarks 
FROM CR_Mark
WHERE ISNUMERIC(MARKS) = 1
GROUP BY CourseSem
ORDER BY CourseSem";

                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlCon);
                    sqlCon.Open();
                    adapter.Fill(dsData);
                    sqlCon.Close();
                }
            }
            catch
            {
                throw;
            }
            return dsData.Tables[0];
        }


        private void BindChart()
        {
            DataTable dsChartData = new DataTable();
            StringBuilder strScript = new StringBuilder();

            try
            {
                dsChartData = GetChartData();

                strScript.Append(@"<script type='text/javascript'>  
                    google.load('visualization', '1', {packages: ['corechart']});</script>  
  
                    <script type='text/javascript'>  
                    function drawVisualization() {         
                    var data = google.visualization.arrayToDataTable([  
                    ['ipAddress', 'Count'],");

                foreach (DataRow row in dsChartData.Rows)
                {
                    strScript.Append("['" + row["CourseName"] + "'," + row["Counter"] + "],");
                }
                strScript.Remove(strScript.Length - 1, 1);
                strScript.Append("]);");

                strScript.Append("var options = { backgroundColor: 'transparent',title : 'Visual Chart for Email', seriesType: 'bars', series: {3: {type: 'area'}} };");
                strScript.Append(" var chart = new google.visualization.PieChart(document.getElementById('chart_div'));  chart.draw(data, options); } google.setOnLoadCallback(drawVisualization);");
                strScript.Append(" </script>");

                ltScripts.Text = strScript.ToString();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                dsChartData.Dispose();
            }
        }



        private void imghacker()
        {
            DataTable dsChartData = GetChartData1();
            StringBuilder strScript = new StringBuilder();

            strScript.Append(@"<script type='text/javascript' src='https://www.gstatic.com/charts/loader.js'></script>
<script type='text/javascript'>
google.charts.load('current', { packages: ['corechart'] });
google.charts.setOnLoadCallback(drawVisualization);
function drawVisualization() {
    var data = google.visualization.arrayToDataTable([
        ['CourseName - Sem', 'Count'],");

            foreach (DataRow row in dsChartData.Rows)
            {
                string label = HttpUtility.JavaScriptStringEncode($"{row["CourseName"]} - Sem {row["CourseSem"]}");
                strScript.Append("['" + label + "', " + row["Counter"] + "],");
            }
            strScript.Length--; // Remove trailing comma

            strScript.Append(@"]);
    var options = {
        title: 'Course-Semester Count Distribution',
        backgroundColor: 'transparent',
        legend: { position: 'bottom' },
        hAxis: { title: 'Course-Semester' },
        vAxis: { title: 'Count' },
        bar: { groupWidth: '70%' }
    };
    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div1'));
    chart.draw(data, options);
}
</script>");

            Literal1.Text = strScript.ToString();
        }



        private DataTable GetChartData()
        {
            DataSet dsData = new DataSet();
            try
            {
                SqlConnection sqlCon = new SqlConnection(ConfigurationManager.AppSettings["ConStr"]);
                //SqlDataAdapter sqlCmd = new SqlDataAdapter("GetData", sqlCon);
                //sqlCmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                //string queryString = "Select distinct ipAddress, Count(ipAddress) as Counter from request group by ipAddress";
                string queryString = "Select distinct Count(CourseName) as Counter,CourseName from CR_Mark group by CourseName";
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlCon);
                sqlCon.Open();

                adapter.Fill(dsData);

                sqlCon.Close();
            }
            catch
            {
                throw;
            }
            return dsData.Tables[0];
        }

        private DataTable GetChartData1()
        {
            DataSet dsData = new DataSet();
            try
            {
                string connStr = ConfigurationManager.AppSettings["ConStr"]; // Ensure key exists in Web.config
                using (SqlConnection sqlCon = new SqlConnection(connStr))
                {
                    string queryString = @"
                    SELECT COUNT(CourseSem) AS Counter, CourseName, CourseSem
                    FROM CR_Mark
                    GROUP BY CourseSem, CourseName
                    ORDER BY CourseSem, CourseName";

                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, sqlCon);
                    sqlCon.Open();
                    adapter.Fill(dsData);
                    sqlCon.Close();
                }
            }
            catch
            {
                throw;
            }
            return dsData.Tables[0];
        }
    }
}