using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Log4netDemo.Common;
using Log4netDemo.TestLib;

namespace Log4netDemo.Site
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Test1
            //try
            //{
            //    int i = 0;
            //    int k = 1 / i;
            //}
            //catch (Exception ex)
            //{
            //    LogHelper.Error("", ex);
            //}

            Calculator calc = new Calculator();
            calc.Devide(1, 0);
        }
    }
}