﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.servise
{
    public partial class servise2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void returnbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}