using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects;
using AutomicObjectDesignerBack.Repository;
using AutomicObjectDesignerBack.Repository.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    // https://localhost:7017/api/WindowsGeneral
    [ApiController]
    [Route("api/[controller]")]
    public class WindowsGeneralController : ControllerBase
    {
        private readonly IWindowsGeneralRepository _windowsGeneralRepository;
        private readonly ILogger<WindowsGeneralController> _logger;

        public WindowsGeneralController(AppDatabaseContext context, ILogger<WindowsGeneralController> logger,
            IWindowsGeneralRepository repository)
        {
            _windowsGeneralRepository = repository;
            _logger = logger;
        }

        //GET https://localhost:7017/api/WindowsGeneral
        [HttpGet]
        public async Task<ActionResult<List<WindowsGeneral>>> GetWindowsGeneral()
        {
            _logger.LogInformation("GetWindowsGeneral called...");
            var windowsGeneral = _windowsGeneralRepository.GetAll();

            return Ok(windowsGeneral);
        }

        // Function returns required Data ready for modification after step 1 was filled.
        //Get https://localhost:7017/api/WindowsGeneral/GetWindowsGeneralStep2/{id}
        [HttpGet("GetWindowsGeneralStep2/{id:int}", Name = "GetWindowsGeneralStep2")]
        public async Task<ActionResult<WindowsGeneral>> GetSapJobBwChainStep2(int id)
        {
            _logger.LogInformation($"GetSapSobBwChain called with parameter id = {id}");

            var windowsGeneral = _windowsGeneralRepository.FindByCondition((h => h.Id == id)).FirstOrDefault();

            WindowsGeneralStep2Dto win = new WindowsGeneralStep2Dto()
            {
                Id = id,
                ObjectName = windowsGeneral.ObjectName
            };

            return Ok(win);
        }

        //GET https://localhost:7017/api/WindowsGeneral/{id}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<WindowsGeneral>> GetWindowsGeneral(int id)
        {
            _logger.LogInformation($"GetWindowsGeneral called with parameter id = {id}");
            var windowsGeneral = _windowsGeneralRepository.FindByCondition((x => x.Id == id));

            if (windowsGeneral == null)
            {
                return NotFound();
            }

            return Ok(windowsGeneral);
        }

        //DELETE https://localhost:7017/api/WindowsGeneral/{id}
        [HttpDelete("{id}", Name = "DeleteWindowsGeneral")]
        public async Task<ActionResult<List<WindowsGeneral>>> DeleteWindowsGeneral(int id)
        {
            var winObject = new WindowsGeneral() { Id = id };


            if (winObject == null)
            {
                return NotFound();
            }

            _windowsGeneralRepository.Delete(winObject);
            await _windowsGeneralRepository.Save();

            return NoContent();

        }

        //POST https://localhost:7017/api/WindowsGeneral/step1
        [HttpPost("step1", Name = "CreateWindowsGeneral_Step1")]
        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneral([FromBody] WindowsGeneralStep1Dto WindowsGeneralStep1Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsGeneral = new WindowsGeneral
            {
                WinLogin = WindowsGeneralStep1Dto.WinLogin,
                WinServer = WindowsGeneralStep1Dto.WinServer,
                RoutineJob = WindowsGeneralStep1Dto.RoutineJob,
                ProcessName = WindowsGeneralStep1Dto.ProcessName,
                NameSuffix = WindowsGeneralStep1Dto.NameSuffix,
                ObjectName = $"<>.<>#<{WindowsGeneralStep1Dto.RoutineJob}>" +
                             $"#<{WindowsGeneralStep1Dto.ProcessName}>#WIN_<{WindowsGeneralStep1Dto.NameSuffix}>.JOBS"

            };

            _windowsGeneralRepository.Create(windowsGeneral);
            await _windowsGeneralRepository.Save();

            return CreatedAtRoute("CreateWindowsGeneral_Step1", new { id = windowsGeneral.Id }, windowsGeneral);
        }

        //POST https://localhost:7017/api/WindowsGeneral/step2
        [HttpPost("step2", Name = "CreateWindowsGeneral_Step2")]

        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneralStep2([FromBody] WindowsGeneralStep2Dto WindowsGeneralStep2Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsObject = _windowsGeneralRepository.FindByCondition(x => x.Id == WindowsGeneralStep2Dto.Id).FirstOrDefault();

            if (windowsObject == null)
            {
                return NotFound();
            }

            windowsObject.ObjectName = WindowsGeneralStep2Dto.ObjectName;


            //throw new NotImplementedException();
            _windowsGeneralRepository.Update(windowsObject);
            await _windowsGeneralRepository.Save();

            return CreatedAtRoute("CreateWindowsGeneral_Step2", new { id = windowsObject.Id }, windowsObject);
        }

        //POST https://localhost:7017/api/WindowsGeneral/step3
        [HttpPost("step3", Name = "CreateWindowsGeneral_Step3")]

        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneralStep3([FromBody] WindowsGeneralStep3Dto WindowsGeneralStep3Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsObject = _windowsGeneralRepository.FindByCondition(x => x.Id == WindowsGeneralStep3Dto.Id).FirstOrDefault();

            if (windowsObject == null)
            {
                return NotFound();
            }

            windowsObject.Process = WindowsGeneralStep3Dto.Process;

            _windowsGeneralRepository.Update(windowsObject);
            await _windowsGeneralRepository.Save();

            return CreatedAtRoute("CreateWindowsGeneral_Step3", new { id = windowsObject.Id }, windowsObject);
        }

        //POST https://localhost:7017/api/WindowsGeneral/step4
        [HttpPost("step4", Name = "CreateWindowsGeneral_Step4")]

        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneralStep4([FromBody] WindowsGeneralStep4Dto WindowsGeneralStep4Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsObject = _windowsGeneralRepository.FindByCondition(x => x.Id == WindowsGeneralStep4Dto.Id).FirstOrDefault();
            if (windowsObject == null)
            {
                return NotFound();
            }

            windowsObject.Documentation = WindowsGeneralStep4Dto.Documentation;


            _windowsGeneralRepository.Update(windowsObject);
            await _windowsGeneralRepository.Save();

            return CreatedAtRoute("CreateWindowsGeneral_Step4", new { id = windowsObject.Id }, windowsObject);
        }

        //POST https://localhost:7017/api/WindowsGeneral/step5
        [HttpPost("step5", Name = "CreateWindowsGeneral_Step5")]

        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneralStep5([FromBody] WindowsGeneralStep5Dto WindowsGeneralStep5Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var windowsObject = _windowsGeneralRepository.FindByCondition(x => x.Id == WindowsGeneralStep5Dto.Id).FirstOrDefault();

            if (windowsObject == null)
            {
                return NotFound();
            }

            windowsObject.Archive1 = WindowsGeneralStep5Dto.Archive1;
            windowsObject.Archive2 = WindowsGeneralStep5Dto.Archive2;
            windowsObject.Folder = WindowsGeneralStep5Dto.Folder;
            windowsObject.InternalAccount = WindowsGeneralStep5Dto.InternalAccount;
            windowsObject.Title = WindowsGeneralStep5Dto.Title;



            _windowsGeneralRepository.Update(windowsObject);
            await _windowsGeneralRepository.Save();

            return CreatedAtRoute("CreateWindowsGeneral_Step5", new { id = windowsObject.Id }, windowsObject);
        }

        // Function returns required Data ready for modification after step 1 was filled.
        //Get https://localhost:7017/api/WindowsGeneral/GetWindowsGeneralStep2/{id}
        [HttpGet("GetWindowsGeneralStep2/{id:int}", Name = "GetWindowsGeneralStep2")]
        public async Task<ActionResult<WindowsGeneral>> GetWindowsGeneralStep2(int id)
        {
            _logger.LogInformation($"GetWindowsGeneral called with parameter id = {id}");

            var windowsGeneral = _windowsGeneralRepository.FindByCondition((h => h.Id == id));
            WindowsGeneralStep2Dto windows = new WindowsGeneralStep2Dto

            {
                Id = id,
                ObjectName = windowsGeneral.FirstOrDefault().ObjectName,

            };

            return Ok(windows);
        }

        // Function returns required Data ready for modification after all steps were finished.
        //Get https://localhost:7017/api/WindowsGeneral/GetWindowsGeneralStep5/{id}
        [HttpGet("GetWindowsGeneralStep6/{id:int}", Name = "GetWindowsGeneralStep6")]
        public async Task<ActionResult<WindowsGeneral>> GetWindowsGeneralStep6(int id)
        {
            _logger.LogInformation($"GetWindowsGeneral called with parameter id = {id}");

            var windowsGeneral = _windowsGeneralRepository.FindByCondition((h => h.Id == id));

            WindowsGeneral windows = new WindowsGeneral
            {
                Id = id,
                WinServer = windowsGeneral.FirstOrDefault().WinServer,
                WinLogin = windowsGeneral.FirstOrDefault().WinLogin,
                ObjectName = windowsGeneral.FirstOrDefault().ObjectName,
                OwnerId = windowsGeneral.FirstOrDefault().OwnerId,
                Active = windowsGeneral.FirstOrDefault().Active,
                NameSuffix = windowsGeneral.FirstOrDefault().NameSuffix,
                MaxParallelTasks = windowsGeneral.FirstOrDefault().MaxParallelTasks,
                Process = windowsGeneral.FirstOrDefault().Process,
                PreProcess = windowsGeneral.FirstOrDefault().PreProcess,
                PostProcess = windowsGeneral.FirstOrDefault().PostProcess,
                RoutineJob = windowsGeneral.FirstOrDefault().RoutineJob,
                ProcessName = windowsGeneral.FirstOrDefault().ProcessName,
                Documentation = windowsGeneral.FirstOrDefault().Documentation,
                Title = windowsGeneral.FirstOrDefault().Title,
                Archive1 = windowsGeneral.FirstOrDefault().Archive1,
                Archive2 = windowsGeneral.FirstOrDefault().Archive2,
                InternalAccount = windowsGeneral.FirstOrDefault().InternalAccount,
                Folder = windowsGeneral.FirstOrDefault().Folder,
                Queue = windowsGeneral.FirstOrDefault().Queue,
                Agent = windowsGeneral.FirstOrDefault().Agent,
                Login = windowsGeneral.FirstOrDefault().Login

            };

            return Ok(windows);
        }

        // Function returns required Data ready for modification after all steps were finished.
        //Get https://localhost:7017/api/WindowsGeneral/DownloadCsvFile/{id}
        [HttpGet("DownloadWindowsGeneralCsvFile/{id:int}", Name = "DownloadWindowsGeneralCsvFile")]
        public IActionResult DownloadCsvFile(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            };

            var windowsGeneral = _windowsGeneralRepository.FindByCondition((h => h.Id == id)).FirstOrDefault();
            if (windowsGeneral == null)
            {
                return NotFound();
            };


            string[] columnNames = new string[]
            {
                "Id", "WinServer", "WinLogin", "ObjectName", "OwnerId", "Active", "NameSuffix", "MaxParallelTasks",
                "Process", "PreProcess", "PostProcess", "RoutineJob", "ProcessName", "Documentation", "Title",
                "Archive1", "Archive2", "InternalAccount",
                "Folder", "Queue", "Agent", "Login"
            };
            var wins = _windowsGeneralRepository.FindByCondition((h => h.Id == id));
            string csv = String.Empty;

            foreach (string columnName in columnNames)
            {
                csv += columnName + ',';
            }

            csv += "\r\n";

            foreach (var win in wins)
            {
                csv += '"' + win.Id.ToString().Replace(",", ";") + "\",";
                csv += '"' + win.WinServer.Replace(",", ";") + "\",";
                csv += '"' + win.WinLogin.Replace(",", ";") + "\",";
                csv += '"' + win.ObjectName.Replace(",", ";") + "\",";
                csv += '"' + win.OwnerId.ToString().Replace(",", ";") + "\",";
                csv += '"' + win.Active.ToString().Replace(",", ";") + "\",";
                csv += '"' + win.NameSuffix.Replace(",", ";") + "\",";
                csv += '"' + win.MaxParallelTasks.ToString().Replace(",", ";") + "\",";
                csv += '"' + win.Process.Replace(",", ";") + "\",";
                csv += '"' + win.PreProcess.Replace(",", ";") + "\",";
                csv += '"' + win.PostProcess.Replace(",", ";") + "\",";
                csv += '"' + win.RoutineJob.ToString().Replace(",", ";") + "\",";
                csv += '"' + win.ProcessName.Replace(",", ";") + "\",";
                csv += '"' + win.Documentation.Replace(",", ";") + "\",";
                csv += '"' + win.Title.Replace(",", ";") + "\",";
                csv += '"' + win.Archive1.Replace(",", ";") + "\",";
                csv += '"' + win.Archive2.Replace(",", ";") + "\",";
                csv += '"' + win.InternalAccount.Replace(",", ";") + "\",";
                csv += '"' + win.Folder.Replace(",", ";") + "\",";
                csv += '"' + win.Queue?.Replace(",", ";") + "\",";
                csv += '"' + win.Agent?.Replace(",", ";") + "\",";
                csv += '"' + win.Login?.Replace(",", ";") + "\",";

                csv += "\r\n";

            }

            byte[] bytes = Encoding.ASCII.GetBytes(csv);
            return File(bytes, "text/csv", "win.csv");

        }

        // Function returns required Data ready for modification after all steps were finished.
        //Get https://localhost:7017/api/WindowsGeneral/DownloadJsonFile/{id}
        [HttpGet("DownloadWindowsGeneralJsonFile/{id:int}", Name = "DownloadWindowsGeneralJsonFile")]
        public IActionResult DownloadJsonFile(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            };

            var windowsGeneral = _windowsGeneralRepository.FindByCondition((h => h.Id == id)).FirstOrDefault();
            if (windowsGeneral == null)
            {
                return NotFound();
            };

            WindowsGeneral winJson = new WindowsGeneral
            {
                Id = id,
                WinServer = windowsGeneral.WinServer,
                WinLogin = windowsGeneral.WinLogin,
                ObjectName = windowsGeneral.ObjectName,
                OwnerId = windowsGeneral.OwnerId,
                Active = windowsGeneral.Active,
                NameSuffix = windowsGeneral.NameSuffix,
                MaxParallelTasks = windowsGeneral.MaxParallelTasks,
                Process = windowsGeneral.Process,
                PreProcess = windowsGeneral.PreProcess,
                PostProcess = windowsGeneral.PostProcess,
                RoutineJob = windowsGeneral.RoutineJob,
                ProcessName = windowsGeneral.ProcessName,
                Documentation = windowsGeneral.Documentation,
                Title = windowsGeneral.Title,
                Archive1 = windowsGeneral.Archive1,
                Archive2 = windowsGeneral.Archive2,
                InternalAccount = windowsGeneral.InternalAccount,
                Folder = windowsGeneral.Folder,
                Queue = windowsGeneral.Queue,
                Agent = windowsGeneral.Agent,
                Login = windowsGeneral.Login
            };

            string fileName = "win.json";
            string jsonString = JsonSerializer.Serialize(windowsGeneral, new JsonSerializerOptions { WriteIndented = true });

            byte[] bytes = Encoding.ASCII.GetBytes(jsonString);
            return File(bytes, "application/json", "win.json");

        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult<List<WindowsGeneralDto>>> UpdateWindowsGeneral([FromBody] WindowsGeneral updateWindowsGeneral)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    //TODO:
        //    var windowsGeneral = await _context.WindowsGeneral.FindAsync(updateWindowsGeneral);

        //    if (windowsGeneral == null)
        //    {
        //        return NotFound();
        //    }


        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


    }

}
