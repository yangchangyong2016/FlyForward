using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyForward.Core.API.Controllers
{
	/// <summary>
	/// 控制器抽象
	/// </summary>
	[Route("api/[controller]/[action]")]
	[ApiController]
	public abstract class AbstractController : ControllerBase
	{

	}
}
