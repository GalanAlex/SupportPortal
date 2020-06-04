using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.ChatHub;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace SupportPortal.Controllers
{
    public class ChatController : Controller
    {
        IHubContext<ChatHub> hubContext;
        public ChatController(IHubContext<ChatHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(string product)
        {
            await hubContext.Clients.All.SendAsync("Notify", $"Добавлено: {product} - {DateTime.Now.ToShortTimeString()}");
            return RedirectToAction("Index");
        }
    }
}
