using BaiTH9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTH9.Cau_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string conStr = "Data Source=SKY-20200706ULN;Initial Catalog=CSDL_Bai2_TH89;Integrated Security=True";
        private CSDL_TH9DataContext myDataContext;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                myDataContext = new CSDL_TH9DataContext(conStr);
                string taiKhoan = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                var myQuery1 = from i in myDataContext.Users
                               where i.UserName == taiKhoan
                               select i;
                var myQuery2 = from j in myDataContext.Users
                               where j.PassWord == matKhau
                               select j;
                if (myQuery1.Count() > 0 && myQuery2.Count() > 0)
                {
                    Application["TaiKhoan"] = txtTaiKhoan.Text;
                    Response.Redirect("GetTaiKhoan.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Bạn nhập sai tài khoản')</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Lỗi kết nối')</script>");
            }
            
        }
    }
}