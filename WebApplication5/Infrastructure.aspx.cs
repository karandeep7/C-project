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
    public partial class WebForm6 : System.Web.UI.Page
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
                Label6.Text = ex.ToString();
            }
            Label6.Text = " ";
            DropDownList2.Enabled = false;
            GridView2.Visible = true;
            GridView1.Visible = false;
            Show_Table();
        }

        private void Show_Table()
        {
            try
            {
                conn.Open();

                String sqlsearch = "Select * from MST_Infrastructure ";
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
                Label6.Text = ex.ToString();
            }
        }

        private void Infra_Code()
        {
            conn.Open();
            int count;
            String str = "Select count(*) from Mst_Infrastructure";
            cmd = new OleDbCommand(str, conn);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            TextBox1.Text = ("I00" + count);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Infra_Code();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String sql = "INSERT INTO MST_Infrastructure VALUES('" + TextBox1.Text.Trim() + "','" + DropDownList1.Text.Trim() + "','" + DropDownList2.Text.Trim() + "','" + DropDownList3.Text.Trim() + "','" + DropDownList4.Text.Trim() + "','" + DropDownList5.Text.Trim() + "','"+DropDownList6.Text.Trim()+"','"+DropDownList7.Text.Trim()+"','"+DropDownList8.Text.Trim()+"','"+DropDownList9.Text.Trim()+"','"+TextBox2.Text.Trim()+"')";
                cmd = new OleDbCommand(sql, conn);

                cmd.ExecuteNonQuery();

                Label6.Text = "Record Inserted";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            Response.Redirect("Infrastructure");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView2.Visible = false;
            GridView1.Visible = true;
            try
            {
                conn.Open();

                String sqlsearch = "Select * from MST_Infrastructure where InfraID='" + TextBox1.Text.Trim() + "'";
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
                Label6.Text = ex.ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String sqlupdate1 = "update MST_Infrastructure set Category = '" + DropDownList1.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate1, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate2 = "update MST_Infrastructure set Short_Name = '" + DropDownList2.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate2, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate3 = "update MST_Infrastructure set Facility = '" + DropDownList3.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate3, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate4 = "update MST_Infrastructure set Sitting_Arrangement = '" + DropDownList4.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate4, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate5 = "update MST_Infrastructure set TV = '" + DropDownList5.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate5, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate6 = "update MST_Infrastructure set Floor = '" + DropDownList6.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate6, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate7 = "update MST_Infrastructure set AC_Type = '" + DropDownList7.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate7, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate8 = "update MST_Infrastructure set Board_Type = '" + DropDownList8.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate8, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate9 = "update MST_Infrastructure set CCTV = '" + DropDownList9.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate9, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String sqlupdate10 = "update MST_Infrastructure set Accomodation = '" + TextBox2.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate10, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Updated";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            Response.Redirect("Infrastructure");
        }
    }
}