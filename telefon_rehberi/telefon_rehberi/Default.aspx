<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </br></br>

            <center>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Green" Text="Telefon Rehberi"></asp:Label>
                </center>
            </br></br>

            <table class="table table-hover table-responsive">

                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Ad"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblContact" runat="server" Text="Telefon No. "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtContact" runat="server" MaxLength="10"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLocation" runat="server" Text="Konum"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLocation" runat="server" MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Ekle" CssClass="btn btn-default btn-success" />
                    </td>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Enabled="False" OnClick="btnUpdate_Click" Text="Düzenle" class="btn btn-danger btn-default"/>
                    </td>
                </tr>

            </table>
        </div>
        <asp:GridView ID="gridBook" runat="server" class="table table-hover table-responsive">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Default.aspx?id={0}&amp;action=1" HeaderText="Sil" Text="Sil">
                    <ControlStyle ForeColor="Red" />
                </asp:HyperLinkField>
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Default.aspx?id={0}&amp;action=2" HeaderText="Düzenle" Text="Düzenle">
                    <ControlStyle ForeColor="Green" />
                </asp:HyperLinkField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
