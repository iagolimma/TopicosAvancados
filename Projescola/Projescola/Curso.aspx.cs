using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Projescola
{
    public partial class Curso : System.Web.UI.Page
    {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            protected void Page_Load(object sender, EventArgs e)
            {
                con.ConnectionString = "Data Source=DESKTOP-EGFAGIK\\SQLEXPRESS;Initial Catalog=ProjEscola;Integrated Security=True";
            con.Open();
                if (!Page.IsPostBack)
                {
                    DataShow();
                }
            }

            public void DataShow()
            {
                ds = new DataSet();
                cmd.CommandText = "Select * From Curso";
                cmd.Connection = con;
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                cmd.ExecuteNonQuery();
                GridView1.DataSource = ds;
                GridView1.DataBind();
                con.Close();
            }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert into Curso (Nome,Descricao)values('" + TxtNome.Text.ToString() + "','" + TxtDescricao.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Curso set Nome='" + TxtNome.Text.ToString() + "',Descricao='" + TxtDescricao.Text.ToString() + "' where Nome='" + TxtNome.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "delete from Curso where Nome='" + TxtNome.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }
    }
 }
