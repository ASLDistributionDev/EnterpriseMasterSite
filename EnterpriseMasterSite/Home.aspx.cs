﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EnterpriseMasterSite.Auth;
using EnterpriseMasterSite.Database;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace EnterpriseMasterSite
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DoUniversal();
            if (!IsPostBack)
            {
                DoFreshLoad();
            }
        }

        private void DoFreshLoad()
        {
            
        }

        private void DoUniversal()
        {
            alertL.Text = "";
        }

        protected void managementLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Server.Transfer("/managementportal/login.aspx?token=" + token);
        }

        protected void reportingLB_Click(object sender, EventArgs e)
        {
            string token = Authentication.SetToken(this);
            Response.Redirect("http://10.10.20.4/reporting/reporting/login.aspx?token=" + token);
        }
    }
}