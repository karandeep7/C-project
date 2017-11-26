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
    public partial class WebForm8 : System.Web.UI.Page
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
                Label2.Text = ex.ToString();
            }
            TextBox19.Enabled = false;  
            DropDownList4.Enabled = false;
            Roll_Code();
            Label2.Text = " ";
            DropDownList6.Enabled = false;
        }
        public void Roll_Code()
        {
            try
            {
                conn.Open();
                int c;
                String str = "select count(*) from MST_Student where Course = '" + DropDownList3.Text.Trim() + "'";
                cmd = new OleDbCommand(str, conn);
                c = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
                TextBox19.Text = (TextBox13.Text.Trim() + "00" + c);
                conn.Close();
               
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
        }
        public void Student_Code()
        {
            conn.Open();
            int count;
            String str = "Select count(*) from MST_Student";
            cmd = new OleDbCommand(str, conn);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            TextBox1.Text = ("ST00" + count);
            conn.Close();
        }
       

        protected void Button4_Click(object sender, EventArgs e)
        {
            Student_Code();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String sql = "INSERT INTO MST_Student VALUES('"+TextBox1.Text.Trim()+ "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "','" + TextBox6.Text.Trim() + "','" + TextBox7.Text.Trim() + "','" + TextBox8.Text.Trim() + "','" + TextBox9.Text.Trim() + "','" + TextBox10.Text.Trim() + "','" + TextBox11.Text.Trim() + "','" + DropDownList4.Text.Trim() + "','" + TextBox13.Text.Trim() + "','" + TextBox14.Text.Trim() + "','" + TextBox15.Text.Trim() + "','" + TextBox16.Text.Trim() + "','" + TextBox17.Text.Trim() + "','" + TextBox18.Text.Trim() + "','" + DropDownList1.Text.Trim() + "','" + DropDownList2.Text.Trim() + "','" + TextBox19.Text.Trim() + "','"+DropDownList5.Text.Trim()+"')";
                cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Inserted";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try {
                String sql = "INSERT INTO T16_mst_result(Student_ID,Name,Course,Session_Name,Semester_Year,Current_sem,Classes_Attended,Total_Classes) VALUES('"+TextBox1.Text.Trim()+"','"+TextBox2.Text.Trim()+"','"+DropDownList4.Text.Trim()+"','"+DropDownList5.Text.Trim()+"','"+DropDownList6.Text.Trim()+"','1','0','0')";
                cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                //Label2.Text = "Record Inserted";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
}

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                String sqlsearch = "Select * from MST_Student where Student_ID='" + TextBox1.Text.Trim() + "'";
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
                Label2.Text = ex.ToString();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
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
                String sqlupdate1 = "update MST_Student set Student_Name = '" + TextBox2.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate1, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate2 = "update MST_Student set Father_Name = '" + TextBox3.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate2, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate3 = "update MST_Student set Mother_Name = '" + TextBox4.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate3, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate4 = "update MST_Student set Student_Mob = '" + TextBox5.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate4, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate5 = "update MST_Student set Student_Email = '" + TextBox6.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate5, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate6 = "update MST_Student set Father_Mob = '" + TextBox7.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate6, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate7 = "update MST_Student set Father_Email = '" + TextBox8.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate7, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate8 = "update MST_Student set Age = '" + TextBox9.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate8, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate9 = "update MST_Student set Blood_Grp = '" + TextBox10.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate9, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate10 = "update MST_Student set Religion = '" + TextBox11.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate10, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate11 = "update MST_Student set Course = '" + DropDownList4.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate11, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate23 = "update T16_mst_result set Course = '" + DropDownList4.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate23, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate13 = "update MST_Student set Start_Year = '" + TextBox13.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate13, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate14 = "update MST_Student set End_Year = '" + TextBox14.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate14, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate15 = "update MST_Student set Qualifications = '" + TextBox15.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate15, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate16 = "update MST_Student set Class_10% = '" + TextBox16.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate16, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate17 = "update MST_Student set Class_12% = '" + TextBox17.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate17, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate18 = "update MST_Student set Address = '" + TextBox18.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate18, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate19 = "update MST_Student set State = '" + DropDownList1.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate19, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate20 = "update MST_Student set City = '" + DropDownList2.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate20, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate21 = "update MST_Student set Roll_No = '" + TextBox19.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate21, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            String ssn = DropDownList5.Text.Trim();
            try
            {
                String sqlupdate22 = "update MST_Student set Sssn = '"+DropDownList5.Text.Trim()+"' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate22, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate24 = "update T16_mst_result set Session_Name = '" + DropDownList5.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate24, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }
            try
            {
                String sqlupdate25 = "update T16_mst_result set Semester_Year = '" + DropDownList6.Text.Trim() + "' where Student_ID = '" + TextBox1.Text.Trim() + "' ";
                cmd = new OleDbCommand(sqlupdate25, conn);
                cmd.ExecuteNonQuery();
                Label2.Text = "Record Updated";
                conn.Close();
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
            }

            Response.Redirect("Student");
        }
    }
}