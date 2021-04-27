<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="Projescola.Curso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>       
            table,th,td{
                border: 1px solid black;
                border-collapse: collapse;
            }

            th, td {
                padding: 5px 10px;
            }

            th{
                background-color: black;
                color: white;
            }

            *{
                font-family: Arial, Helvetica, sans-serif;
                color:red;
            }
            /*Odd aplicado em todos elementos impares*/

            table tr:nth-child(odd){
                background-color: blue;
            }

             /*Odd aplicado em todos elementos pares*/
            table tr:nth-child(even){
                background-color: blue;
            }

            * {
                margin:10px auto
            }

        </style>
    </head>
<body>
    <h1><div align="center"> Cadastro de Curso</h1>
     <form id="form1" runat="server">
        <div>
            <div align="center">
            <img src ="img/logo.png.jpg" />
             <asp:GridView ID="GridView1" align="center" runat="server" Width="413px" Height="180px">
             </asp:GridView>

            <table align="center">
                <tr>
                    <td>
                      Nome:
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNome" runat="server" Width="185px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td>
                        Descricao: 
                    </td> 
                    <td>
                        <asp:TextBox ID="TxtDescricao" runat="server" Width="186px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Editar" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Excluir" OnClick="btnDelete_Click" />  
                    </td>
                </tr>
                
            </table>
        </div>
       
    </form>
   <div align="center">
   </div>
</body>
</html>