<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControleBiblioteca.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript"> function MostrarPopupMensagem() { $("#modalMsg").modal('show'); }
        function EsconderPopupDados() { $("#modalDados").modal('hide'); } </script>
    <!-- /.modal -->
    <div class="modal fade" id="modalMsg">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>

                    <h4 class="modal-title" id="h1" runat="server">Modal title</h4>
                </div>
                <div class="modal-body">
                    <p>
                        <label id="lblMsgPopup" runat="server">
                        </label>
                    </p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Ok</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <form runat="server">
        <asp:GridView ID="GVLivros" runat="server" CellPadding="4" CssClass="table" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="GVLivros_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="Regiao" HeaderText="Descricao" />   
                <asp:BoundField DataField="Autor_livro" HeaderText="Autor" />              
                <asp:TemplateField HeaderText="Ações">
                    <ItemTemplate>
                      <asp:LinkButton ID="btnExcluir" runat="server" >Excluir</asp:LinkButton>
                      <asp:LinkButton ID="btnAlterar" runat="server">Alterar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</asp:Content>