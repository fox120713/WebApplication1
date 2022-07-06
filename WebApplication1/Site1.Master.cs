using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using BLL;
using MODEL;
namespace WebApplication1
{
    public partial class site : System.Web.UI.MasterPage
    {

        YgBLL bll = new YgBLL();
        StfInfo_BLL s_bll = new StfInfo_BLL();
        UserInfo_BLL u_bll = new UserInfo_BLL();
        StfInfo_BLL bll2 = new StfInfo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["posname"] = login.ygposname;

            if (!IsPostBack)
            {
                this.Label1.Text = "";
                if (int.Parse(s_bll.sel(login.ygphone).Rows[0][0].ToString()) > 0 )
                {
                    this.Label1.Text = login.ygname;
                    if (int.Parse(s_bll.selpic(login.ygphone).Rows[0][0].ToString()) == 0)
                    {
                        this.Image4.ImageUrl = "~/img/R-C.jfif";
                        this.Image1.ImageUrl = "~/img/R-C.jfif";
                    }
                    else
                    {
                        this.Image4.ImageUrl = "~/头像" + s_bll.selpic1(login.ygphone).Rows[0][0].ToString();
                        this.Image1.ImageUrl = "~/头像" + s_bll.selpic1(login.ygphone).Rows[0][0].ToString();
                    }
                }
                else
                {
                    this.Label1.Text = login.user;
                    if (int.Parse(u_bll.selpic(login.userphone).Rows[0][0].ToString()) == 0)
                    {
                        this.Image4.ImageUrl = "~/img/R-C.jfif";
                        this.Image1.ImageUrl = "~/img/R-C.jfif";
                    }
                    else
                    {
                        this.Image4.ImageUrl = "~/头像" + u_bll.selpic1(login.userphone).Rows[0][0].ToString();
                        this.Image1.ImageUrl = "~/头像" + u_bll.selpic1(login.userphone).Rows[0][0].ToString();
                    }
                }

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            YgKqMODEL a = new YgKqMODEL();
            string name = login.ygname;
            a.YgId1 = Convert.ToInt32(bll2.cx(login.ygphone).Rows[0][0].ToString());
            a.YgName1 = bll2.cx(login.ygphone).Rows[0][1].ToString();
            a.PosName1 = Convert.ToInt32(bll2.cx(login.ygphone).Rows[0][2].ToString());
            a.DaKaSj1 = DateTime.Now;
            int d = a.DaKaSj1.Day;
            int m = a.DaKaSj1.Month;
            int y = a.DaKaSj1.Year;
            int q = Convert.ToInt32(bll.xz(login.ygphone, y, m, d).Rows[0][0].ToString());
            int xs = Convert.ToInt32(a.DaKaSj1.Hour);
            if (xs >= 7 && xs <= 12)
            {
                if (q < 1)
                {
                    int shi = Convert.ToInt32(a.DaKaSj1.Hour);
                    int fen = Convert.ToInt32(a.DaKaSj1.Minute);

                    if (shi >= 8 && shi <= 12)
                    {

                        if (fen > 1)
                        {
                            a.BeiZhu1 = "迟到";
                            DateTime b = a.DaKaSj1.AddHours(-8);
                            DateTime c = a.DaKaSj1.AddMinutes(0);
                            int zhi1 = Convert.ToInt32(b.Hour) * 60;
                            int zhi2 = Convert.ToInt32(c.Minute);
                            a.Ctime1 = zhi1 + zhi2;
                        }

                    }
                    else
                    {
                        a.BeiZhu1 = "正常";
                    }
                    bll.tj(a);
                    Response.Write("<script>alert('打卡成功！')</script>");
                }
                else if (q == 1 && xs <= 12)
                {
                    Response.Write("<script>alert('已打卡！')</script>");
                }
            }
            else if (xs >= 12 && xs < 24)
            {
                if (q < 2)
                {
                    int shi = Convert.ToInt32(a.DaKaSj1.Hour);//当前打卡小时
                    int fen = Convert.ToInt32(a.DaKaSj1.Minute);//当前打卡分钟
                    if (shi >= 12 && shi <= 18)
                    {
                        if (fen > 1)
                        {
                            a.BeiZhu1 = "早退";

                            int ztf = 0;
                            if (shi < 18)
                            {
                                int x = 18 - shi;
                                if (x > 0)
                                {
                                    ztf = ztf + x * 60;
                                }

                                ztf -= fen;
                            }

                            //DateTime l = a.DaKaSj1.AddHours(-18);
                            //DateTime f = a.DaKaSj1.AddMinutes(0);
                            //int zhi3 = Convert.ToInt32(l.Hour);
                            //int zhi4 = Convert.ToInt32(f.Minute);
                            a.Ctime1 = ztf;
                        }
                    }
                    else
                    {
                        a.BeiZhu1 = "正常";
                    }
                    bll.tj(a);
                    Response.Write("<script>alert('打卡成功！')</script>");
                }
                else if (q == 2)
                {
                    Response.Write("<script>alert('已打卡！')</script>");
                }
            }


        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("kqcx.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("kqcx.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("information.aspx");
        }
    }
}