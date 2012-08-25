﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;

namespace DynamicDataLinq.DynamicData.FieldTemplates
{
    public partial class MyCustomFieldTemplate : System.Web.DynamicData.FieldTemplateUserControl
    {
        public override Control DataControl
        {
            get
            {
                return Literal1;
            }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            var value = this.FieldValue.ToString();

            if (value.Contains("z"))
            {
                this.Literal1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}