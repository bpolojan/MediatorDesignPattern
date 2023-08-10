using MediatR.Demo.Commands;
using MediatR.Demo.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        private IMediator _mediator;
        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> GetContacts()
        {
            GetContactsQuery contactsQuery = new GetContactsQuery();
            var result = await _mediator.Send(contactsQuery);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactById([FromRoute] int id)
        {
            GetContactByIdQuery getContactByIdQuery = new GetContactByIdQuery(id);
            var result = await this._mediator.Send(getContactByIdQuery);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost()]        
        public async Task<IActionResult> CreateContact([FromBody] CreateContactCommand createCommand)
        {
            var result = await _mediator.Send(createCommand);
            return CreatedAtAction("GetContactById", new { result.Id }, result);
        }       
    }
}