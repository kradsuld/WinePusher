<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateRound.aspx.cs" Inherits="WinePusher.CreateRound" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1148px;
        }

        .auto-style5 {
            height: 475px;
        }

        .auto-style6 {
            height: 23px;
        }

        .centered-table {
            margin-left: auto;
            margin-right: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="centered-table" border="1" style="border: thin solid #808080; background-color: #990000; color: #FFFFFF">
                <tr>
                    <td class="HeaderPadding" style="border-width: 0px; text-align: center">
                        <asp:Image ID="imaHeader" runat="server" ImageUrl="~/Images/wp_banner.jpg" />
                    </td>
                </tr>
                <tr>
                    <td style="border-width: 0px;">
                        <table style="width: 100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td colspan="4">
                                    <asp:Label ID="lblCreateRound" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Opret runde"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblWineType" runat="server" Text="Vintype"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWineTypeSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="ddWineTypes" runat="server">
                                        <asp:ListItem>Rødvin</asp:ListItem>
                                        <asp:ListItem>Hvidvin</asp:ListItem>
                                        <asp:ListItem>Sherry</asp:ListItem>
                                        <asp:ListItem>Portvin</asp:ListItem>
                                        <asp:ListItem>Bobler</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblWineName" runat="server" Text="Vinnavn"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWineNameSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="tbWineName" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvWineName" runat="server" ControlToValidate="tbWineName" ErrorMessage="Vinnavn skal udfyldes"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblStore" runat="server" Text="Butik"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblStoreSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="tbStore" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvStore" runat="server" ControlToValidate="tbStore" ErrorMessage="Butik skal udfyldes"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblWinePrice" runat="server" Text="Pris"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWinePriceSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="tbWinePrice" runat="server" ValidationGroup="vgCreateRound"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RegularExpressionValidator ID="rvlWinePrice" runat="server" ControlToValidate="tbWinePrice" ErrorMessage="Skal indeholde tal" ValidationExpression="^\d{0,8}(\,\d{1,4})?$"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="padding: 5px; border-width: 0px; text-align: left; vertical-align: middle;">
                        <hr />
                    </td>
                </tr>

                <tr>
                    <td style="padding: 5px; border-width: 0px; text-align: left; vertical-align: middle;">
                        <asp:Button ID="btnSaveRound" runat="server" Text="Gem runde" OnClick="btnSaveRound_Click" />
                        &nbsp;                
                        <asp:Button ID="btnBack" runat="server"  CausesValidation="false" Text="Tilbage" OnClick="btnBack_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
