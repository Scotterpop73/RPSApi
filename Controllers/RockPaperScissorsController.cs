using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RPSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RockPaperScissorsController : ControllerBase
{
    [HttpGet]
    [Route("GetRandomOption")]
    public string GetRandomOption(){
        return "";
    }
}
