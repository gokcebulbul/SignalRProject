using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.Layout_Components
{
    public class _LayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
