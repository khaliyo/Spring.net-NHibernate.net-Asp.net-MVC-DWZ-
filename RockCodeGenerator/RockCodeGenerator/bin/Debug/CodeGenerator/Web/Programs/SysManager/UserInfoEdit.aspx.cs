﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BLL.SysManager;
using Domain.Entities.SysManager;
using RockFramework.View.WebForm;

namespace Web.Programs.SysManager
{
    public partial class UserInfoEdit : DWZBasePager<UserInfo>
    {

        public BusinessObjectManagerFactory BllObjectFactory { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
             if(!IsPostBack)
             {
                 this.DefaultObject = BllObjectFactory.UserInfoManager.Get(Request["UserID"]);
             }
        }
    }
}

