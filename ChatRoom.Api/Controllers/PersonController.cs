using ChatRoom.Application.DTOs.PersonDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ChatRoom.Application.Feautures.Person.Requests.Queries;
using ChatRoom.Application.Feautures.Person.Requests.Commands;

namespace ChatRoom.Api.Controllers
{
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IMediator _mediator;
        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("Person/GetAll")]
        public async Task<ActionResult<List<PersonDto>>> GetAllAsync()
        {

            try
            {
                var response = await _mediator.Send(new GetPersonListRequest());
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("Person/Get")]
        public async Task<ActionResult<PersonDto>> GetAsync([FromHeader] Guid guid)
        {

            try
            {
                var response = await _mediator.Send(new GetOnePersonRequest() { Guid = guid });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("Person/Add")]
        public async Task<ActionResult<PersonDto>> AddAsync([FromBody] PersonDto personDto)
        {

            try
            {
                var response = await _mediator.Send(new AddPersonRequestCommands() { newPerson = personDto });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpPut]
        [Route("Person/Update")]
        public async Task<ActionResult<PersonDto>> UpdateAsync([FromBody] PersonDto personDto)
        {

            try
            {
                var response = await _mediator.Send(new UpdatePersonRequestCommands() { OldPerson = personDto });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpDelete]
        [Route("Person/Delete")]
        public async Task<ActionResult<PersonDto>> DeleteAsync([FromBody] PersonDto personDto)
        {

            try
            {
                var response = await _mediator.Send(new DeletePersonRequestCommands() { oldPerson = personDto });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
