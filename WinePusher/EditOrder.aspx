<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditOrder.aspx.cs" Inherits="WinePusher.EditOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
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
                                <td colspan="3">
                                    <asp:Label ID="lblEditOrder" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Ret ordre"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 20px">&nbsp;</td>
                                <td style="width: 150px">
                                    &nbsp;</td>
                                <td style="width: 20px">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblOrderDate" runat="server" Text="Ordredato"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text=":&amp;nbsp;"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lbloOrderDate" runat="server" Text="OrderDate*"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblMemberName" runat="server" Text="Medlem"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblMemberNameSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lbloMemberName" runat="server" Text="MemberName*"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblWineName" runat="server" Text="Vinnavn"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWineNameSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label></td>
                                <td>
                                    <asp:Label ID="lbloWineName" runat="server" Text="WineName*"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblWineType" runat="server" Text="Vintype"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblWineTypeSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label></td>
                                <td>
                                    <asp:Label ID="lbloWineType" runat="server" Text="WineType*"></asp:Label>
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
                                    <asp:Label ID="lbloWinePrice" runat="server" Text="WinePrice*"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblBottles" runat="server" Text="Antal flasker"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblBottlesSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="ddBottles" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddBottles_SelectedIndexChanged">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblOrderAmount" runat="server" Text="Ordrebeløb"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblOrderAmountSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lbloOrderAmount" runat="server" Text="OrderAmount*"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblDeliveredMark" runat="server" Text="Er flaskerne leveret?"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblDeliveredMarkSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddDeliveredMark" runat="server">
                                        <asp:ListItem Value="Y">Ja</asp:ListItem>
                                        <asp:ListItem Value="N">Nej</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblPaidMark" runat="server" Text="Er ordren betalt?"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblPaidMarkSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddPaidMark" runat="server">
                                        <asp:ListItem Value="Y">Ja</asp:ListItem>
                                        <asp:ListItem Value="N">Nej</asp:ListItem>
                                    </asp:DropDownList>
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
                        <asp:Button ID="btnSaveRound" runat="server" Text="Gem ordre" OnClick="btnSaveOrder_Click" />
                        &nbsp;                
                        <asp:Button ID="btnDelete" runat="server"  CausesValidation="false" Text="Slet ordre" OnClick="btnDeleteOrder_Click" />
                        &nbsp;                
                        <asp:Button ID="btnBack" runat="server"  CausesValidation="false" Text="Tilbage" OnClick="btnBack_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
