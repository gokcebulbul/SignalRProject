using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.Layout_Components
{
	public class _LayoutFooterComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
