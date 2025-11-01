using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationSystem.Application.Interfaces;

namespace NotificationSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService notificationService;

        public NotificationController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromQuery] string recipient, [FromQuery] string message)
        {
            await notificationService.PublishAsync(recipient, message);

            return Ok(new
            {
                Message = "Notification sent."
            }
            );
        }
    }
}
