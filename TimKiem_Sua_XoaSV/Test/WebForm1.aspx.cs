using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnTinh_Click(object sender, EventArgs e)
        {
            /*if(txtMaSP.Text.Trim() == "")
            {
                Response.Write("<Script>alert'Đề nghị nhập mã sản phẩm'</Script>");
                txtMaSP.Focus();
                return;
            }*/
            /*double SoLuong = 0, DonGia = 0;
            bool kiemtra = Double.TryParse(txtSoLuong.Text, out SoLuong);
            if(kiemtra == false)
            {
                Response.Write("<Script>alert('Lỗi nhập số lượng!')</script>");
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            bool kiemtraDG = Double.TryParse(txtDonGia.Text, out DonGia);
            if (kiemtraDG == false)
            {
                Response.Write("<Script>alert('Lỗi nhập đơn giá!')</Script>");
                txtDonGia.Text = "";
                txtDonGia.Focus();
                return;
            }*/
            //double SoLuong = Convert.ToDouble(txtSoLuong.Text);
            //double DonGia = Convert.ToDouble(txtDonGia.Text);
            double SoLuong = 0, DonGia = 0;
            try
            {
                SoLuong = Convert.ToDouble(txtSoLuong.Text);
                DonGia = Convert.ToDouble(txtDonGia.Text);
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Lỗi nhập số lượng/đơn giá')</script>");
            }
            double ThanhTien = SoLuong * DonGia;
            txtThanhTien.Text = ThanhTien.ToString();
        }
    }
}