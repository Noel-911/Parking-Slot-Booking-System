﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Server.Transfer("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("AdminRegistration.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Reports.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("Usermgmt.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Parkingmgmt.aspx");
        }
    }
}