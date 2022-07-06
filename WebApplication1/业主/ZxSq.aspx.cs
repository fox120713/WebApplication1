using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.IO;
namespace WebApplication1.业主
{
    public partial class ZxSq : System.Web.UI.Page
    {
        UserInfo_BLL ubll = new UserInfo_BLL();
        RepnnBLL rbll = new RepnnBLL();
        WuyeZHMXBLL wbll = new WuyeZHMXBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string phone = login.userphone;

                DataTable dt = ubll.selnum(phone);
                this.TextBox1.Text = dt.Rows[0][0].ToString();
                DateTime a = DateTime.Now;
                this.TextBox2.Text =Convert.ToString(a);
                this.TextBox4.Text = "2000";

                
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)//判断是否有文件
                {
                    string filename = FileUpload1.FileName;
                    string kzm = Path.GetExtension(FileUpload1.FileName);//提取文件扩展名
                    if (kzm == ".jpg" || kzm == ".png" || kzm == ".jpeg")
                    {
                        
                        
                        if (this.RadioButton1.Checked)
                        {
                            DataTable tb = ubll.seluserid(login.userphone);
                            int userid = int.Parse(tb.Rows[0][0].ToString());
                            string mph = this.TextBox1.Text;
                            string img = this.FileUpload1.FileName;
                            if (rbll.Repnntj(userid, mph,img) > 0)
                            {
                                
                                wbll.insYaJin(mph);
                                FileUpload1.SaveAs(Server.MapPath("~/wximg/" + filename));
                                Response.Write("<script>alert('申请成功！！！');window.location.href='ZxCk.aspx';</script>");


                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('请勾选协议!')</script>");
                        }
                       


                    }
                    else
                    {
                        Response.Write("<script>alert('您上传的文件不是图片请重新上传！！！')</script>");

                    }
                }
                else
                {
                    Response.Write("<script>alert('请上传文件！！！')</script>");



                }
               



            }
            catch (Exception)
            {
                
                
            }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ZxCk.aspx");
        }
    }
}