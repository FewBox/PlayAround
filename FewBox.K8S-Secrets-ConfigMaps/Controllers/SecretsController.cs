using Microsoft.AspNetCore.Mvc;

namespace FewBox.K8S_Secrets_ConfigMaps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretsController : ControllerBase
    {
        private AppConfig AppConfig { get; set; }

        public SecretsController(AppConfig appConfig)
        {
            this.AppConfig = appConfig;
        }

        [HttpGet]
        public ActionResult<AppConfig> Get()
        {
            return this.AppConfig;
        }
    }
}
