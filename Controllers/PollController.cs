using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
namespace SportsStore.Controllers
{
    public class PollController : Controller
    {
        private IPollingRepository repository;
        public PollController(IPollingRepository repo)
        {
            repository = repo;
        }
        //public ViewResult List() => View(repository.Selection);
        [HttpPost]
        public IActionResult Poll(Polling polling)
        {
            return View(polling);
        }
    }
}