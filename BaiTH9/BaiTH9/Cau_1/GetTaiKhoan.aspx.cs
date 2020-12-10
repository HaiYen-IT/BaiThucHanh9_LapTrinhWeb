using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTH9.Cau_1
{
    public partial class GetTaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string taiKhoan = Application["TaiKhoan"].ToString();
            Response.Write("Xin chào bạn: " + taiKhoan);
        }
    }
}