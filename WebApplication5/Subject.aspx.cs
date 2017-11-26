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
    public partial class WebForm7 : System.Web.UI.Page
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
            Button5.Enabled = false;
            Button8.Visible = false;
        }

        protected void Subject_Code()
        {
            int count;
            conn.Open();
            String sqlcode = "select count(*) from MST_Subject";
            cmd = new OleDbCommand(sqlcode, conn);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            TextBox1.Text = ("SB00" + count);
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Button5.Enabled = true;
            Subject_Code();
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String savesql = "Insert into MST_Subject values('" + TextBox1.Text.Trim() + "','" + DropDownList1.Text.Trim() + "','" + DropDownList2.Text.Trim() + "','" + TextBox2.Text.Trim() + "')";
                cmd = new OleDbCommand(savesql, conn);
                cmd.ExecuteNonQuery();
                Label1.Text = "Record Inserted..!";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String searchsql = "select * from MST_Subject where Subject_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(searchsql, conn);
                adp = new OleDbDataAdapter();
                adp.SelectCommand = cmd;
                ds = new DataSet();
                adp.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            DropDownList1.Enabled = true;
            DropDownList2.Enabled = true;
            Button8.Visible = true;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
            Button7.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String updatesql = "update MST_Subject set Subject_Name = '" + TextBox2.Text.Trim() + "' where Subject_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql, conn);
                cmd.ExecuteNonQuery();
                Label1.Text = "Record Updated..!";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            try
            {
                String updatesql1 = "update MST_Subject set Course_Name = '" + DropDownList1.Text.Trim() + "' where Subject_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql1, conn);
                cmd.ExecuteNonQuery();
                Label1.Text = "Record Updated..!";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            try
            {
                String updatesql2 = "update MST_Subject set Semester = '" + DropDownList2.Text.Trim() + "' where Subject_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql2, conn);
                cmd.ExecuteNonQuery();
                Label1.Text = "Record Updated..!";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            Response.Redirect("Subject");
        }
    }
}