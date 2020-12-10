<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nhap_Sua_XoaKhoaDaoTao.aspx.cs" Inherits="BaiTH9.Cau_2.Nhap_Sua_XoaKhoaDaoTao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 131px;
        }
        .auto-style3 {
            height: 23px;
            width: 131px;
        }
        #btnThem{
            margin-right: 130px;
            margin-left: 140px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="2">NHẬP - SỬA - XOÁ KHOA ĐÀO TẠO</td>
                </tr>
                <tr>
                    <td class="auto-style2">Mã khoa:</td>
                    <td>
                        <asp:TextBox ID="txtMaKhoa" runat="server" Width="387px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Tên khoa:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtTenKhoa" runat="server" Width="387px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Điện thoại:</td>
                    <td>
                        <asp:TextBox ID="txtDienThoai" runat="server" Width="387px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2">
                        
                        <asp:Button ID="btnThem" runat="server" Text="Thêm mới" Width="87px" OnClick="btnThem_Click" />
                        <asp:Button runat="server" Text="Ghi" Width="87px" ID="btnGhi" OnClick="btnGhi_Click" />
                        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="530px" OnRowCommand="GridView1_RowCommand">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="MaKhoa" HeaderText="Mã khoa" />
                                <asp:BoundField DataField="TenKhoa" HeaderText="Tên khoa">
                                <ItemStyle Width="200px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Phone" HeaderText="Điện thoại" />
                                <asp:ButtonField ButtonType="Button" CommandName="btnSua" HeaderText="Sửa" Text="Sửa" />
                                <asp:ButtonField ButtonType="Button" CommandName="btnXoa" HeaderText="Xóa" Text="Xóa" />
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
