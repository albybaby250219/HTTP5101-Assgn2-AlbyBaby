﻿using System.Web;
using System.Web.Mvc;

namespace HTTP5101_Assgn2_AlbyBaby
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
