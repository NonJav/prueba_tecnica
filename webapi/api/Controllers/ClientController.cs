using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Implement;
// using pf.CanonicalModel.Entities;
// using pf.CategoryES.Implement;
// using pf.CanonicalModel.Messages;

namespace api.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController: ControllerBase
    {
        private ClientBL _clientbl;
        public ClientController()
        {
            this._clientbl = new ClientBL();
        }

        [HttpPost, Route("add")]
        public async Task<IActionResult> CreateClient([FromBody]Client model) 
        {
            try
            {
                return Ok(await _clientbl.CreateClient(model));
            }
            catch(Exception ex) 
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ListClient() 
        {
            try
            {
                return Ok(await _clientbl.GetClients());
            }
            catch(Exception ex) 
            {
                return BadRequest(ex);
            }
        }

        [HttpGet, Route("GetClient/{clientId}")]
        public async Task<IActionResult> GetClient(int clientId) 
        {
            try
            {
                return Ok(await _clientbl.GetClient(clientId));
            }
            catch(Exception ex) 
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClient([FromBody]Client model) 
        {
            try
            {
                return Ok(await _clientbl.UpdateClient(model));
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClient([FromBody]Client model) 
        {
            try
            {
                return Ok(await _clientbl.DeleteClient(model));
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}