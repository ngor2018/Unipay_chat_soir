﻿using System.Web;
using System.Web.Mvc;

namespace Unipay_chat_soir
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
