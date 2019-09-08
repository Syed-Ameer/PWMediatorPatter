using BasicServiceMediator.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicServiceMeditor.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMediator mediator;
        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<ActionResult> Index()
        {
            EmployeeListRequest listRequest = new EmployeeListRequest() { };
            
            List<EmployeeResponse> employees = await mediator.Send(listRequest);

            return View(employees);
        }
        public async Task<ActionResult> Details(int id)
        {
            EmployeeDetailRequest detailRequest = new EmployeeDetailRequest() { EmployeeId = id };

            EmployeeResponse employee = await mediator.Send(detailRequest);

            return View(employee);
        }
    }
}