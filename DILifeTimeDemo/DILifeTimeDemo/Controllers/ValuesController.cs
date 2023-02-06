using DILifeTimeDemo.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DILifeTimeDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly ITrasitiveOperation _trasitiveOperation;

        public ValuesController
            (
            ISingletonOperation singletonOperation,
            IScopedOperation scopedOperation,
            ITrasitiveOperation trasitiveOperation
            )
             
        {
            _singletonOperation = singletonOperation;
            _scopedOperation = scopedOperation;
            _trasitiveOperation = trasitiveOperation;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                new
                {
                    singleton = _singletonOperation.Operationid,
                    scoped = _scopedOperation.Operationid,
                    transient = _trasitiveOperation.Operationid
                });
        }
    }
}
