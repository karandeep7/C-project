using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace WebApplication5
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adp;
        DataSet ds;
        public static string strCurrntMonthYear = "";
        int Year = 0;
        int inMonth = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\Visual Studio 2015\\Projects\\WebApplication5\\WebApplication5\\bin\\Giit.accdb");
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            Label1.Text = " ";
            if(!IsPostBack)
            {
                bindAttendance();
            }
        }

        protected void bindAttendance()
        {
            Year = DateTime.Now.Year;
            inMonth = DateTime.Now.Month;
            int Days = DateTime.DaysInMonth(Year, inMonth);

            //Declare DataTable
            DataTable Dt = new DataTable("dtDays");

            //Declare Data Column
            DataColumn auto = new DataColumn("AutoID", typeof(System.Int32));
            Dt.Columns.Add(auto);

            DataColumn DaysName = new DataColumn("DaysName", typeof(string));
            Dt.Columns.Add(DaysName);

            DataColumn Date = new DataColumn("Date", typeof(string));
            Dt.Columns.Add(Date);

            //Declare Data Row
            DataRow dr = null;
            DateTime days;
            DateTime strDate;

            for (int i = 1; i <= Days; i++)
            {
                //Create row in DataTable
                dr = Dt.NewRow();
                days = new DateTime(Year, inMonth, i);  // find days name
                strDate = new DateTime(Year, inMonth, i); // find date w.r.t days

                dr["AutoID"] = i;
                dr["DaysName"] = days.DayOfWeek;
                dr["Date"] = strDate.Date.ToShortDateString();
                Dt.Rows.Add(dr);    //Add row in DataTable
            }

            //Assign Current Date, Month and Year

            strCurrntMonthYear = DateTime.Now.ToString("dd") + " " + DateTime.Now.ToString("MMMM") + " " + Year;

            //Assing DataTable to GridView
            gvCalander.DataSource = Dt;
            gvCalander.DataBind();

        }
        protected void gvCalander_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            string currDate = DateTime.Now.ToShortDateString();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string rowDate = e.Row.Cells[2].Text; //Date
                string rowDay = e.Row.Cells[1].Text;  //Day

                CheckBox chk = (CheckBox)e.Row.FindControl("chkMark");
                TextBox txtRemark = (TextBox)e.Row.FindControl("txtRemarks");

                string strRemarks = "";
                bool boolAttStatus = false;
                bindPrevAtt(out boolAttStatus, out strRemarks, rowDate);
                txtRemark.Text = strRemarks;
                chk.Checked = boolAttStatus;

                if ((Convert.ToDateTime(rowDate) < Convert.ToDateTime(currDate)) || chk.Checked == true)
                {
                    // CheckBox chk = (CheckBox)e.Row.FindControl("chkMark");
                    // TextBox txtRemark = (TextBox)e.Row.FindControl("txtRemarks");
                    chk.Enabled = false;
                    txtRemark.Enabled = false;
                }
                if (rowDay.Equals("Sunday") || rowDay.Equals("Saturday"))        //if there is Sunday make it red colour
                {
                    e.Row.Cells[1].ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        protected void btnAddAttendence_Click(object sender, EventArgs e)
        {
            string strRemarks = "";
            string tsCurrHour = DateTime.Now.Hour.ToString();
            string tsCurrMin = DateTime.Now.Minute.ToString();

            foreach (GridViewRow gvr in gvCalander.Rows)
            {
                string strDay = gvr.Cells[1].Text; //Day
                string strDate = gvr.Cells[2].Text; //Date
                TextBox txtRemarks = (TextBox)gvr.FindControl("txtRemarks");
                CheckBox chkMark = (CheckBox)gvr.FindControl("chkMark");
                if (chkMark.Checked == true)
                {
                    if (Convert.ToInt32(tsCurrHour) > 10 || Convert.ToInt32(tsCurrMin) > 30)
                    {
                        strRemarks = "Sorry you are late";
                    }
                    else
                    {
                        strRemarks = txtRemarks.Text.Trim();
                    }
                    //strRemarks = txtRemarks.Text.Trim();
                    //Save Data
                    DateTime dt = Convert.ToDateTime(strDate);
                    string strDateTime = dt.Month + "/" + dt.Day + "/" + dt.Year;
                    SaveData(1, strRemarks, strDateTime);
                }
            }

            //bind Attendance
            bindAttendance();
        }
        protected void SaveData(int attStatus, string strRemarks, string strDate)
        {
            //here I am assuming logged in employee Id as 1
            string strQry = "INSERT INTO AttendanceMaster (empId, attMonth, attYear, attStatus, remarks, attdate, loggedInDate ) VALUES (1," + DateTime.Now.Month + "," + DateTime.Now.Year + "," + attStatus + ", '" + strRemarks + "', '" + strDate + "',getDate())";
            OleDbCommand cmd = new OleDbCommand(strQry, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        protected void bindPrevAtt(out bool attStatus, out string strRemarks, string strAttDate)
        {
            attStatus = false;
            strRemarks = "Remarks";
            string strQry = "SELECT attStatus, remarks FROM MST_Attendance WHERE Student_Id = 1 AND Att_Date = '" + strAttDate + "'";
            OleDbCommand cmd = new OleDbCommand(strQry, conn);
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                strRemarks = dt.Rows[0]["remarks"].ToString();
                attStatus = Convert.ToBoolean(dt.Rows[0]["Att_Status"]);
            }
            gvCalander.DataSource = dt;
            gvCalander.DataBind();
            dt.Dispose();
            da.Dispose();
            cmd.Dispose();
            conn.Close();
        }

    }
}
