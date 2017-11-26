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
    public partial class Attendance : System.Web.UI.Page
    {
        OleDbConnection conn;
        OleDbCommand cmd;
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
            String CurrDate = Convert.ToString(DateTime.Now.Day) + "-" + Convert.ToString(DateTime.Now.Month) + "-" + Convert.ToString(DateTime.Now.Year);
            Label1.Text = CurrDate;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow item in GridView1.Rows)
            {
                if ((item.Cells[0].FindControl("cbSelect") as CheckBox).Checked)
                {
                    int j = Convert.ToInt16(item.Cells[5].Text);
                    j++;
                    item.Cells[5].Text = Convert.ToString(j);
                    //int k = Convert.ToInt16(item.Cells[5].Text);
                    //Label Classes_Attended = (Label)item.FindControl("Classes_Attended");
                    //DataInsert(item.Cells[5].Text);

                    cmd = new OleDbCommand("Update T16_mst_result set Classes_Attended = '" + item.Cells[5].Text + "' WHERE Student_ID = '"+item.Cells[1].Text+"'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                int k = Convert.ToInt16(item.Cells[6].Text);
                k++;
                item.Cells[6].Text = Convert.ToString(k);
                cmd = new OleDbCommand("Update T16_mst_result set Total_Classes = '" + item.Cells[6].Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Response.Redirect("Attendance");
        }
    }
}