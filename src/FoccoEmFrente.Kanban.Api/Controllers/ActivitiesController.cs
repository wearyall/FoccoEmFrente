using FoccoEmFrente.Kanban.Api.Controllers.Attributes;
using FoccoEmFrente.Kanban.Application.Entities;
using FoccoEmFrente.Kanban.Application.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoccoEmFrente.Kanban.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [ValidateModelState]
    [Authorize]

    public class ActivitiesController : ControllerBase
    {
        private readonly IActivityRepository _activityRepository;


        public ActivitiesController(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var atividades = await _activityRepository.GetAllAsync();

            return Ok(atividades);
        }

        [HttpPost]
        public IActionResult Inserir(Activity activity)
        {
            var newActivity = _activityRepository.Add(activity);

            return Ok(newActivity);
        }

    }
}
