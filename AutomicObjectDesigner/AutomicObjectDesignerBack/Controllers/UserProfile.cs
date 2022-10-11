using AutomicObjectDesignerBack.Controllers.ObjectContollers;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.List;
using AutomicObjectDesignerBack.Models.Objects;
using AutomicObjectDesignerBack.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomicObjectDesignerBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // [Authorize(Roles = "User,Admin")]
    public class UserProfileController : ControllerBase
    {
        private readonly ILogger<UserProfileController> _logger;
        private readonly IWindowsGeneralRepository _windowsGeneralRepository;
        private readonly IUnixGeneralRepository _unixGeneralRepository;
        private readonly ISapSimpleRepository _sapSimpleRepository;
        private readonly ISapJobBwChainRepository _sapJobBwChainRepository;

        public UserProfileController(AppDatabaseContext context, ILogger<UserProfileController> logger,
            IWindowsGeneralRepository windowsRepository, IUnixGeneralRepository unixGeneralRepository,
            ISapSimpleRepository sapSimpleRepository, ISapJobBwChainRepository sapJobBwChainRepository)
        {
            _windowsGeneralRepository = windowsRepository;
            _unixGeneralRepository = unixGeneralRepository;
            _sapSimpleRepository = sapSimpleRepository;
            _sapJobBwChainRepository = sapJobBwChainRepository;
            _logger = logger;
        }
        // GET  https://localhost:7017/api/UserProfile
        [HttpGet]
        public async Task<ActionResult<List<ListObjects>>> GetFiles()
        {
            _logger.LogInformation("UserProfile called...");

            var windowsGeneral = _windowsGeneralRepository.GetAll();
            var unixGeneral = _unixGeneralRepository.GetAll();
            var sapSimple = _sapSimpleRepository.GetAll();
            var sapJobBwChain = _sapJobBwChainRepository.GetAll();

            var x = new ListObjects();
            // x.SapJobBwChains = sapJobBwChain;
            // x.Add(unixGeneral);
            // x.Add(sapSimple);
            // x.Add(sapJobBwChain);

            return Ok(x);
        }
    }
}