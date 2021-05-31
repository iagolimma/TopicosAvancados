using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleBiblioteca
{
    public partial class Livros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Desc_Livro = txtDescricao.Text;
            string Autor_livro = txtAutor.Text;
            LIVROS livros = new LIVROS() { Desc_Livro = Desc_Livro, Autor_livro = Autor_livro };
            BibliotecaDBEntities2 contextLivros = new BibliotecaDBEntities2();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextLivros.LIVROS.Add(livros);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                LIVROS Livros = contextLivros.LIVROS.First(c => c.id == id);
                Livros.Desc_Livro = Livros.descricao;
                Livros.Autor_livro = Livros.Autor_livro;
                lblmsg.Text = "Registro Alterado";
            }
            contextLivros.SaveChanges();
        }
        private void Clear()
        {
            txtDescricao.Text = "";
            txtAutor.Text = "";
            txtDescricao.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;
            LIVROS livros = new LIVROS();


            if (!String.IsNullOrEmpty(valor))
            {
                BibliotecaDBEntities2 contextLivros = new BibliotecaDBEntities2();
                idItem = Convert.ToInt32(valor);
                livros = contextLivros.LIVROS.First(c => c.id == idItem);

                txtDescricao.Text = livros.descricao;
                txtAutor.Text = livros.Autor_livro;
            }
        }
    }
}


