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
    public partial class InfraFacility : System.Web.UI.Page
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
            TextBox2.Enabled = false;
            GridView1.Visible = false;
            GridView2.Visible = true;
            Label1.Text = " ";
            Show_Table();
        }
        private void Show_Table()
        {
            try
            {
                conn.Open();

                String sqlsearch = "Select * from T02_mst_infrafacility ";
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
                Label1.Text = ex.ToString();
            }
        }
        protected void InfraFacility_Code()
        {
            conn.Open();
            int count;
            String sqlcode = "select count(*) from T02_mst_infrafacility";
            cmd = new OleDbCommand(sqlcode, conn);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            TextBox1.Text = ("IF00" + count);
            conn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            InfraFacility_Code();
            TextBox2.Enabled = true;
            Button5.Enabled = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String savesql = "Insert into T02_mst_infrafacility values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "')";
                cmd = new OleDbCommand(savesql, conn);
                cmd.ExecuteNonQuery();
                Label1.Text = "Record Inserted..!";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            Response.Redirect("InfraFacility");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            GridView2.Visible = false;
            try
            {
                conn.Open();

                String searchsql = "select * from T02_mst_infrafacility where InfraID = '" + TextBox1.Text.Trim() + "'";
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
            Button8.Visible = true;
            TextBox2.Enabled = true;
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
                String updatesql = "update T02_mst_infrafacility set InfraFacility ='" + TextBox2.Text.Trim() + "' where InfraID = '" + TextBox1.Text.Trim() + "'";
                cmd = new OleDbCommand(updatesql, conn);
                cmd.ExecuteNonQuery();
                Label1.Text = "Record Updated..!";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            Response.Redirect("InfraFacility");
        }
    }
}