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

    public partial class WebForm13 : System.Web.UI.Page
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adp;
        DataSet ds;
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
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //conn.Open();
            foreach (GridViewRow item in GridView1.Rows)
            {
                if ((item.Cells[0].FindControl("cbSelect") as CheckBox).Checked)
                {
                    int n;
                    String sem = DropDownList2.Text;
                    n = Convert.ToInt16(sem) + 1;
                    String id = item.Cells[1].Text;
                    try
                    {
                        conn.Open();
                        String sqlpassed = "Update T16_mst_result set Current_sem = '" + n + "' where Student_ID = '" + id + "'";
                        cmd = new OleDbCommand(sqlpassed, conn);
                        cmd.ExecuteNonQuery();
                        Label1.Text = "Result Published.";
                        conn.Close();
                    }
                    catch(Exception ex)
                    {
                        Label1.Text = ex.ToString();
                    }
                }
            }
            
            foreach(GridViewRow item in GridView1.Rows)
            {
                try
                {
                    conn.Open();
                    String sqlreset = "Update T16_mst_result set Classes_attended = '0' AND Total_Classes = '0'";
                    cmd = new OleDbCommand(sqlreset, conn);
                    cmd.ExecuteNonQuery();
                    Label1.Text = "Attendance Reset";
                    conn.Close();
                }
                catch(Exception ex)
                {
                    Label1.Text = ex.ToString();
                }
            }
            Response.Redirect("Results");
            /* */
        }

    }
}