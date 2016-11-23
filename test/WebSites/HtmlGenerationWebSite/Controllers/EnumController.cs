// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace HtmlGenerationWebSite.Controllers
{
    public class EnumController : Controller
    {
        public IActionResult Index()
        {
            return View(new AClass { DayOfWeek = DayOfWeek.Friday, Month = Month.FirstOne });
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
