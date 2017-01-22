using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Log4netDemo.Common;

namespace Log4netDemo.TestLib
{
    public class Calculator
    {
        public void Devide(int i, int k)
        {
            try
            {
                int m = i / k;
            }
            catch (Exception ex)
            {
                LogHelper.Error("", ex);
            }
        }
    }
}
