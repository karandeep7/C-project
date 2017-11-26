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
    public partial class WebForm1 : System.Web.UI.Page
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adp;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\Visual Studio 2015\\Projects\\WebApplication5\\WebApplication5\\bin\\Giit.accdb");
            }
            catch(Exception ex) {
                Label7.Text = ex.ToString();
            }
            TextBox6.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox7.Enabled = false;
            DropDownList3.Enabled = false;
            DropDownList4.Enabled = false;
            Button2.Enabled = false;
            Button5.Visible = false;
            GridView1.Visible = true;
            Show_Table();
            Label7.Text = " ";
        }

        private void Show_Table()
        {
            try
            {
                conn.Open();

                String sqlsearch = "Select * from MST_Course ";
                cmd = new OleDbCommand(sqlsearch, conn);
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
                Label7.Text = ex.ToString();
            }
        }
        private void course_code()
        {
            conn.Open();
            int count;
            String str = "Select count(*) from Mst_Course";
            cmd = new OleDbCommand(str, conn);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            TextBox1.Text = ("C00" + count);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox6.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            TextBox7.Enabled = true;
            DropDownList3.Enabled = true;
            DropDownList4.Enabled = true;
            Button2.Enabled = true;

            course_code();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            try {
                conn.Open();
                String sql = "INSERT INTO MST_Course VALUES('" + TextBox1.Text.Trim() + "','" + TextBox6.Text.Trim() + "','" + TextBox3.Text.Trim() + "','"+TextBox7.Text.Trim()+"','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "','"+DropDownList4.Text.Trim()+"','"+DropDownList5.Text.Trim()+"','" + DropDownList3.Text.Trim() + "')";
                cmd = new OleDbCommand(sql, conn);
                
                cmd.ExecuteNonQuery();

                Label7.Text = "Record Inserted";
                conn.Close();
               
            }
            catch(Exception ex)
            {
                Label7.Text = ex.ToString();
                Response.Write(DropDownList3.Text);
            }
            Response.Redirect("Course");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView1.Visible = false;
            try
            {
                conn.Open();

                String sqlsearch = "Select * from MST_Course where Course_ID = '"+TextBox1.Text.Trim()+"' ";
                cmd = new OleDbCommand(sqlsearch, conn);
                adp = new OleDbDataAdapter();
                adp.SelectCommand = cmd;
                ds = new DataSet();
                adp.Fill(ds);
                GridView2.DataSource = ds;
                GridView2.DataBind();
                conn.Close();
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = true;
            TextBox6.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            TextBox7.Enabled = true;
            DropDownList3.Enabled = true;
            DropDownList4.Enabled = true;

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
             try
            {
                conn.Open();
                String sqlupdate1 = "update MST_Course set Course_Name = '" + TextBox6.Text.Trim() + "' where Course_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate1, conn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
            try
            {
                String sqlupdate2 = "update MST_Course set Course_Active = '" + DropDownList3.Text.Trim() + "' where Course_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate2, conn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
            try
            {
                String sqlupdate3 = "update MST_Course set Short_Name = '" + TextBox3.Text.Trim() + "' where Course_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(sqlupdate3, conn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
            try
            {
                String sqlupdate4 = "update MST_Course set Course_Fee = '" + TextBox7.Text.Trim() + "' where Course_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(sqlupdate4, conn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
            try
            {
                String sqlupdate5 = "update MST_Course set Start_Year = '" + TextBox4.Text.Trim() + "' where Course_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(sqlupdate5, conn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
            try
            {
                String sqlupdate6 = "update MST_Course set End_Year = '" + TextBox5.Text.Trim() + "' where Course_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(sqlupdate6, conn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
            try
            {
                String sqlupdate8 = "update MST_Course set Session = '" + DropDownList5.Text.Trim() + "' where Course_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(sqlupdate8, conn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
            try
            {
                String sqlupdate7 = "update MST_Course set course_Type = '" + DropDownList4.Text.Trim() + "' where Course_ID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(sqlupdate7, conn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Record Updated";
                conn.Close();
                Label7.Text = "Record Updated..!";
            }
            catch (Exception ex)
            {
                Label7.Text = ex.ToString();
            }
            Response.Redirect("Course");
        }
    }
}