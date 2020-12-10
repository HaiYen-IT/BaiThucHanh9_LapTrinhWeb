<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="BaiTH9.Cau_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 168px;
        }
        #btnDangNhap{
            margin-left: 170px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="2">ĐĂNG NHẬP&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Tài khoản:</td>
                    <td>
                        <asp:TextBox ID="txtTaiKhoan" runat="server" Width="326px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Mật khẩu:</td>
                    <td>
                        <asp:TextBox ID="txtMatKhau" runat="server" Width="326px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" Width="84px" OnClick="btnDangNhap_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
