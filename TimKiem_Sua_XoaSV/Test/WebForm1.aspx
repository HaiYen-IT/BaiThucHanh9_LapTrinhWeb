<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 211px;
        }
        .auto-style3 {
            height: 23px;
            width: 211px;
        }
        .auto-style4 {
            width: 92%;
            margin-left: 63px;
        }
        .auto-style5 {
            margin-right: 3px;
        }
    </style>
</head>
<body style="height: 346px">
    <form id="form1" runat="server">
        <table class="auto-style4">
            <tr>
                <td class="auto-style2">Mã sản phẩm</td>
                <td>
                    <asp:TextBox ID="txtMaSP" runat="server" Width="446px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Tên sản phẩm</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtTenSP" runat="server" Width="446px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Số lượng</td>
                <td>
                    <asp:TextBox ID="txtSoLuong" runat="server" Width="446px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Đơn giá</td>
                <td>
                    <asp:TextBox ID="txtDonGia" runat="server" Width="446px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Thành tiền</td>
                <td>
                    <asp:TextBox ID="txtThanhTien" runat="server" CssClass="auto-style5" Width="446px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnTinh" runat="server" OnClick="btnTinh_Click" Text="Tính" Width="105px" />
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" Width="105px" />
                </td>
            </tr>
        </table>
    </form>
    
</body>

</html>
