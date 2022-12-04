using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dou_store.webui.Data;

namespace dou_store.webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString()=="list")
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}