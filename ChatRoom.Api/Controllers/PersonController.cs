using ChatRoom.Application.DTOs.PersonDto;
using ChatRoom.Application.Feautures.Person.Requests.Commands;
using ChatRoom.Application.Feautures.Person.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        [Route("/Person/GetAll")]
        public async Task<ActionResult<List<PersonDto>>> GetAllPersonAsync()
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
        [Route("/Person/Get")]
        public async Task<ActionResult<PersonDto>> GetPersonAsync([FromHeader] Guid guid)
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
        [Route("/Person/Add")]
        public async Task<ActionResult<PersonDto>> AddPersonAsync([FromBody] PersonDto personDto)
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
        [Route("/Person/Update")]
        public async Task<ActionResult<PersonDto>> UpdatePersonAsync([FromBody] PersonDto personDto)
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
        [Route("/Person/Delete")]
        public async Task<ActionResult<PersonDto>> DeletePersonAsync([FromBody] PersonDto personDto)
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
