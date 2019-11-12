using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoListSln.Domain.Contract;
using ToDoListSln.Domain.Interfaces;

namespace ToDoListSln.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/toDoList")]
    public class ToDoListController : Controller
    {

        private readonly IToDoListAppQuery _toDoListAppQuery;
        private readonly IToDoListAppService _toDoListAppService;

        public ToDoListController(IToDoListAppQuery toDoListAppQuery, IToDoListAppService toDoListAppService)
        {
            _toDoListAppQuery = toDoListAppQuery;
            _toDoListAppService = toDoListAppService;
        }

        [HttpGet]
        public IEnumerable<ToDoListDto> Get()
        {
            return _toDoListAppQuery.Get();
        }

        [HttpPost]
        public ActionResult Post([FromBody]ToDoListDto toDoList)
        {
            _toDoListAppService.Add(toDoList);
            return Ok(StatusCodes.Status200OK);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _toDoListAppService.Delete(new Guid(id));
            return Ok(StatusCodes.Status200OK);
        }

        [HttpPatch("{id}")]
        public ActionResult Patch(string id)
        {
            _toDoListAppService.Update(new Guid(id));
            return Ok(StatusCodes.Status200OK);
        }
    }
}
