using Microsoft.AspNetCore.SignalR;
using SignalR.DataAccessLayer.Concrete;

namespace SignalRApi.Hubss
{
    public class SignalRHub : Hub
    {
        SignalRContext context = new SignalRContext();

        public async Task SendCategoryCount()
        {
            var value=context.Categories.Count();
            await Clients.All.SendAsync("ReciveCategoryCount", value);

        }
    }
}
