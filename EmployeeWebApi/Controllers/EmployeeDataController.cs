using EmployeeWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace EmployeeWebApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class EmployeeDataController : ControllerBase
    {
        private static readonly string TOKEN = "1234";

        private bool CheckValidtoken(HttpRequest request)
        {
            request.Headers.TryGetValue("token", out var token);
            return token == TOKEN;
        }


        [HttpPost]
        [Route("employeedata2021")]
        public async Task<IActionResult> GetEmployeeData2021()
        {
            if (CheckValidtoken(Request))
            {
                return Ok(await Task.Run(() => new EmployeeData(DataManager.RandomEmployeeData(), 2021)));
            }
            else
            {
                return Unauthorized();
            }

        }
        [HttpPost]
        [Route("employeedata2020")]
        public async Task<IActionResult> GetEmployeeData2020()
        {
            if (CheckValidtoken(Request))
            {
                return Ok(await Task.Run(() => new EmployeeData(DataManager.RandomEmployeeData(), 2020)));
            }
            else
            {
                return Unauthorized();
            }
        }
        [HttpPost]
        [Route("employeedata2019")]
        public async Task<IActionResult> GetEmployeeData2029()
        {
           if (CheckValidtoken(Request))
            {
                return Ok(await Task.Run(() => new EmployeeData(DataManager.RandomEmployeeData(), 2019)));
            }
            else
            {
                return Unauthorized();
            }
        }

    }
}
