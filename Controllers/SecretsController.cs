using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hello_world_core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecretsController : ControllerBase
    {
        
        [HttpGet]
        public string Get()
        {
            try
            {
                var secret = (new SecretManager()).Get("FirstSecret");
                return secret;
            }catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
