﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
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
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            Button5.Visible = false;
            GridView2.Visible = true;
            GridView1.Visible = false;
            Show_Table();
        }

        private void Show_Table()
        {
            try
            {
                conn.Open();

                String sqlsearch = "Select * from MST_Session ";
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
        protected void Session_code()
        {
            int count;
                conn.Open();
                String sql = "Select count(*) from MST_Session";

                cmd = new OleDbCommand(sql, conn);
                count = Convert.ToInt16(cmd.ExecuteScalar())+1;
                TextBox1.Text = ("S00" + count);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            Session_code();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String savesql = "Insert into MST_Session values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "')";

                cmd = new OleDbCommand(savesql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Label6.Text = "Record Inserted!";
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

                String searchsql = "select * from MST_Session where SID='" + TextBox1.Text.Trim() + "'";
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
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            Button5.Visible = true;
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
                String updatesql1 = "Update MST_Session set Session_Name='" + TextBox2.Text.Trim() + "' where SID='" + TextBox1.Text.Trim() + "'";
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
                String updatesql2 = "Update MST_Session set Short_Name='" + TextBox3.Text.Trim() + "' where SID='" + TextBox1.Text.Trim() + "'";
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
                String updatesql3 = "Update MST_Session set Start_Year='" + TextBox4.Text.Trim() + "' where SID='" + TextBox1.Text.Trim() + "'";
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
                String updatesql4 = "Update MST_Session set End_Year='" + TextBox5.Text.Trim() + "' where SID='" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql4, conn);
                cmd.ExecuteNonQuery();

                Label6.Text = "Record Updated";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
            Response.Redirect("Session");
        }
    }
}