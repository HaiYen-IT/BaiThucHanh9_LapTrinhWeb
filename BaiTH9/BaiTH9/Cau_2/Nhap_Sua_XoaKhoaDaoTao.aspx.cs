using BaiTH9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTH9.Cau_2
{
    public partial class Nhap_Sua_XoaKhoaDaoTao : System.Web.UI.Page
    {
        private string strCon = "Data Source=SKY-20200706ULN;Initial Catalog=QuanlyhocDB;Integrated Security=True";
        private QuanLyHoc_DBDataContext myContext;
        private static bool isAdd;
        protected void SetControl(bool status)
        {
            txtMaKhoa.Enabled = status;
            txtTenKhoa.Enabled = status;
            txtDienThoai.Enabled = status;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                myContext = new QuanLyHoc_DBDataContext(strCon);
                var myQuery = from i in myContext.KhoaDaoTaos
                              select i;
                GridView1.DataSource = myQuery;
                GridView1.DataBind();
            }
            

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "btnSua")
            {
                isAdd = false;
                SetControl(true);
                txtMaKhoa.Text = GridView1.Rows[row].Cells[0].Text;
                txtTenKhoa.Text = GridView1.Rows[row].Cells[1].Text;
                txtDienThoai.Text = GridView1.Rows[row].Cells[2].Text;
                txtMaKhoa.Enabled = false;
            }
            else
            {
                string sMaKhoa = GridView1.Rows[row].Cells[0].Text;
                var myQuery = from i in myContext.KhoaDaoTaos
                              where i.MaKhoa == sMaKhoa
                              select i;
                myContext.KhoaDaoTaos.DeleteAllOnSubmit(myQuery);
                myContext.SubmitChanges();

            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            SetControl(true);
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtDienThoai.Text = "";
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                KhoaDaoTao myKhoaDaoTaos = new KhoaDaoTao();
                myKhoaDaoTaos.MaKhoa = txtMaKhoa.Text;
                myKhoaDaoTaos.TenKhoa = txtTenKhoa.Text;
                myKhoaDaoTaos.Phone = txtDienThoai.Text;
                myContext.KhoaDaoTaos.InsertOnSubmit(myKhoaDaoTaos);
                myContext.SubmitChanges();
            }
            else
            {
                var myData = from i in myContext.KhoaDaoTaos
                             where i.MaKhoa == txtMaKhoa.Text
                             select i;
                KhoaDaoTao myKhoaDaoTaos = myData.First();
                myKhoaDaoTaos.MaKhoa = txtMaKhoa.Text;
                myKhoaDaoTaos.TenKhoa = txtTenKhoa.Text;
                myKhoaDaoTaos.Phone = txtDienThoai.Text;
                myContext.SubmitChanges();
            }
            SetControl(false);
        }
    }
}