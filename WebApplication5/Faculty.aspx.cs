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
    public partial class WebForm3 : System.Web.UI.Page
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adp;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label6.Text = " ";
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox5.Enabled = false;
            TextBox7.Enabled = false;
            DropDownList1.Enabled = false;
            DropDownList2.Enabled = false;
            RadioButton1.Enabled = false;
            RadioButton2.Enabled = false;
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\Visual Studio 2015\\Projects\\WebApplication5\\WebApplication5\\bin\\Giit.accdb");
            }
            catch(Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            GridView2.Visible = true;
            GridView1.Visible = false;
            Show_Table();
        }
        private void Show_Table()
        {
            try
            {
                conn.Open();

                String sqlsearch = "Select * from MST_Faculty ";
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
        protected void faculty_id()
        {
            conn.Open();
            int count;
            String sql = "select count(*) from MST_Faculty";
            cmd = new OleDbCommand(sql, conn);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            TextBox1.Text = ("F00" + count);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox5.Enabled = true;
            TextBox7.Enabled = true;
            TextBox8.Enabled = true;
            DropDownList1.Enabled = true;
            DropDownList2.Enabled = true;
            StateDropDown.Enabled = true;
            CityDropDown.Enabled = true;
            RadioButton1.Enabled = true;
            RadioButton2.Enabled = true;
            faculty_id();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String s;
            try
            {
                conn.Open();
                if (RadioButton1.Enabled == true)
                    s = RadioButton1.Text;
                else
                    s = RadioButton2.Text;
                String savesql = "Insert into MST_Faculty values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + s.Trim() + "','" + TextBox5.Text.Trim() + "','" + DropDownList1.Text.Trim() + "','" + DropDownList2.Text.Trim() +"','"+TextBox7.Text.Trim()+"','"+StateDropDown.Text.Trim()+"','"+CityDropDown.Text.Trim()+"','"+TextBox8.Text.Trim()+"')";
                cmd = new OleDbCommand(savesql, conn);
                cmd.ExecuteNonQuery();
                Label6.Text = "Record Inserted";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
        }

       
        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView2.Visible = false;
            GridView1.Visible = true;
            try
            {
                conn.Open();

                String searchsql = "select * from MST_Faculty where FID='" + TextBox1.Text.Trim() + "'";
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
                Label6.Text = ex.ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Button5.Visible = true;
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox5.Enabled = true;
            TextBox7.Enabled = true;
            TextBox8.Enabled = true;
            DropDownList1.Enabled = true;
            DropDownList2.Enabled = true;
            StateDropDown.Enabled = true;
            CityDropDown.Enabled = true;
            RadioButton1.Enabled = true;
            RadioButton2.Enabled = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String updatesql1 = "Update MST_Faculty set FName='" + TextBox2.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql1, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String updatesql2 = "Update MST_Faculty set FAge='" + TextBox3.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql2, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String s;
                if (RadioButton1.Enabled == true)
                    s = RadioButton1.Text;
                else
                    s = RadioButton2.Text;
                String updatesql3 = "Update MST_Faculty set Fgender ='" + s.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql3, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String updatesql4 = "Update MST_Faculty set F_Joining_Year ='" + TextBox5.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql4, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String updatesql5 = "Update MST_Faculty set F_Designation ='" + DropDownList1.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql5, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String updatesql6 = "Update MST_Faculty set F_department ='" + DropDownList2.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql6, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String updatesql7 = "Update MST_Faculty set F_Address ='" + TextBox7.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql7, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String updatesql8 = "Update MST_Faculty set F_State ='" + StateDropDown.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql8, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String updatesql9 = "Update MST_Faculty set F_City ='" + CityDropDown.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql9, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            try
            {
                String updatesql10 = "Update MST_Faculty set F_Pincode ='" + TextBox8.Text.Trim() + "' where FID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql10, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            Response.Redirect("Faculty");
        }
    }
}