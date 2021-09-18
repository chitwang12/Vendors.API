using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendors.API.Models;
using Vendors.API.Repository;

namespace Vendors.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        IVendorRespository<Vendor> _context;
        public VendorController(IVendorRespository<Vendor> vendor)
        {
            _context = vendor;
        }

        //Get :API/<VendorController>
        [HttpGet]
        public IEnumerable<Vendor> Get()
        {
            return _context.GetAll();
        }

        //Get API/<VendorController>
        [HttpGet("Get/{Id:int}")]
        public IActionResult Get([FromRoute]int Id)
        {
            return Accepted(_context.GetVendor(Id));
        }

        //POST API/VendorController
        [HttpPost]
        public IActionResult Post([FromBody] VendorStock vs)
        {
            _context.PostStock(vs);
            return Ok("Success");
        }
    }
}
