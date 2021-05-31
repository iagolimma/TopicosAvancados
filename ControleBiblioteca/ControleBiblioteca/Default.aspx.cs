using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleBiblioteca
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            BibliotecaDBEntities2 context = new BibliotecaDBEntities2();
            List<LIVROS> lstLivros = context.LIVROS.ToList<LIVROS>();

            GVLivros.DataSource = lstLivros;
            GVLivros.DataBind();
        }

        protected void GVLivros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            BibliotecaDBEntities2 contextLivros = new BibliotecaDBEntities2();
            LIVROS livros = new LIVROS();

            livros = contextLivros.LIVROS.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("Livros.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextLivros.LIVROS.Remove(livros);
                contextLivros.SaveChanges();
                string msg = "Livro excluido com sucesso!";
                string titulo = "Informacao";
                CarregarLista();
                DisplayAlert(titulo, msg, this);
            }
        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            lblMsgPopup.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(),
                "MostrarPopupMensagem();", true);
        }
    }
}