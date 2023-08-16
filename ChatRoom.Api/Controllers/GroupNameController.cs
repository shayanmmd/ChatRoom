using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoom.Application.Feautures.GroupName.Requests.Commands;
using ChatRoom.Application.Feautures.GroupName.Requests.Queries;
using ChatRoom.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChatRoom.Api.Controllers
{
    [ApiController]
    public class GroupNameController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GroupNameController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/GroupName/Get")]
        public async Task<ActionResult<GroupNameDto>> GetAsync([FromHeader] Guid guid)
        {
            try
            {
                var response = await _mediator.Send(new GetOneGroupNameRequest() { Guid = guid });
                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("/GroupName/GetAll")]
        public async Task<ActionResult<List<GroupNameDto>>> GetAllAsync()
        {
            try
            {
                var response = await _mediator.Send(new GetListGroupNameRequest());
                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        [Route("/GroupName/Add")]
        public async Task<ActionResult<BaseResponse>> AddAsync([FromBody] GroupNameDto groupNameDto)
        {
            try
            {
                var response = await _mediator.Send(new AddGroupNameRequestCommands() { NewgroupName = groupNameDto });
                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        [Route("/GroupName/Update")]
        public async Task<ActionResult<BaseResponse>> UpdateAsync([FromBody] GroupNameDto groupNameDto)
        {
            try
            {
                var response = await _mediator.Send(new UpdateGroupNameRequestCommands() { OldGroupName = groupNameDto });
                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete]
        [Route("/GroupName/Update")]
        public async Task<ActionResult<BaseResponse>> DeleteAsync([FromBody] GroupNameDto groupNameDto)
        {
            try
            {
                var response = await _mediator.Send(new DeleteGroupNameRequestCommands() { OldGroupName = groupNameDto });
                return Ok(response);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }




    }
}
