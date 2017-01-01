<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateOrder.aspx.cs" Inherits="WinePusher.CreateOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .centered-table {
            margin-left: auto;
            margin-right: auto;
        }

        .auto-style7 {
            width: 20px;
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
                                <td class="auto-style7">&nbsp;</td>
                                <td colspan="4">
                                    <asp:Label ID="lblCreateOrder" runat="server" Text="Opret ordre til :" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td colspan="4">
                                    <asp:Label ID="lbloWineName" runat="server" Text="*" Font-Bold="True" Font-Size="Large"></asp:Label>
                                    <asp:Label ID="lblFrom" runat="server" Text="fra" Font-Bold="True" Font-Size="Large"></asp:Label>
                                    <asp:Label ID="lbloStore" runat="server" Text="*" Font-Bold="True" Font-Size="Large"></asp:Label>
                                    <asp:Label ID="lblPrice" runat="server" Text="til kr." Font-Bold="True" Font-Size="Large"></asp:Label>
                                    <asp:Label ID="lbloPrice" runat="server" Text="*" Font-Bold="True" Font-Size="Large"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td style="width: 150px">
                                    <asp:Label ID="lblMember" runat="server" Text="Medlem"></asp:Label>
                                </td>
                                <td style="width: 20px">
                                    <asp:Label ID="lblMemberSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddMembers" runat="server" DataTextField="Name" DataValueField="Id">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvMembers" runat="server" ControlToValidate="ddMembers" ErrorMessage="Vælg medlem"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblNumberOfBottles" runat="server" Text="Antal flasker"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblNumberOfBottlesSpacer" runat="server" Text=": &amp;nbsp;"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddBottles" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvBottles" runat="server" ControlToValidate="ddBottles" ErrorMessage="Vælg antal flasker"></asp:RequiredFieldValidator>
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
                    <asp:Button ID="btnSaveOrder" runat="server" Text="Gem ordre" OnClick="btnSaveOrder_Click" />
                    &nbsp;                
                        <asp:Button ID="btnBack" runat="server" CausesValidation="false" Text="Tilbage" OnClick="btnBack_Click" />
                </td>
            </tr>
            </table>
        </div>
    </form>
</body>
</html>
