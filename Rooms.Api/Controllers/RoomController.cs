using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rooms.Aplication.Contracts.Services;
using Rooms.Business.Models;

namespace Rooms.Api.Controllers
{
        [Route("room")]
        [ApiController]
        public class RoomControler : ControllerBase
        {

            private readonly IRoomService _roomService;

            public RoomControler(IRoomService roomService)
            {
                this._roomService = roomService;
            }

        //Get 
        /// <summary>
        /// Get Room By ID
        /// </summary>
        /// <remarks>Export the room whith one ID</remarks>
        /// <param name="id"></param>
        /// <response code="200">Returned when successful</response>
        /// <response code="404">Room not found</response>
        /// <response code="500">Unexpected Error</response>
        [HttpGet("{id}")]
        [EnableCors("Policy1")]
        [ProducesResponseType(typeof(RoomCompleto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> getRoomById(int id)
            {
            IActionResult result;
            try
            {
                 var room = await _roomService.GetById(id);
                if (room == null)
                    result = StatusCode(StatusCodes.Status404NotFound);
                else
                    return Ok(room);
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }

        /// <summary>
        /// Export all Rooms
        /// </summary>
        /// <remarks>Export all rooms</remarks>
        /// <response code="200">Returned when successful</response>
        /// <response code="500">Unexpected Error</response>
        [HttpGet]
        [EnableCors("Policy1")]
        [ProducesResponseType(typeof(List<RoomCompleto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> getAll()
            {
            IActionResult result;
            try
            {
                var rooms = await _roomService.GetAll();
                return Ok(rooms);
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }

        //Put
        /// <summary>
        /// Add Room
        /// </summary>
        /// <remarks>Add one room</remarks>
        /// <response code="200">Returned when successful</response>
        /// <response code="404">Room not found</response>
        /// <response code="500">Unexpected Error</response>
        [HttpPost]
        [EnableCors("Policy1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult addRoom(RoomCompleto room)
            {
            IActionResult result;
            try
            {
                _roomService.AddRoom(room);
                return Ok(room);
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }
        //Delete
        /// <summary>
        /// Delete Room
        /// </summary>
        /// <remarks>Delete one room</remarks>
        /// <param name="id"></param>
        /// <response code="200">Returned when successful</response>
        /// <response code="500">Unexpected Error</response>
        [HttpDelete("{id}")]
        [EnableCors("Policy1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> deleteRoom(int id)
            {
            IActionResult result;
            try
            {
                var room = await _roomService.GetById(id);
                if (room == null)
                    result = StatusCode(StatusCodes.Status404NotFound);
                else
                {
                    await _roomService.DeleteRoom(id);
                    return Ok();
                }
                
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }
        //Update
        /// <summary>
        /// Update Room
        /// </summary>
        /// <remarks>Update one room</remarks>
        /// <response code="200">Returned when successful</response>
        /// <response code="500">Unexpected Error</response>
        [HttpPut]
        [EnableCors("Policy1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult updateRoom(RoomCompleto room)
            {

            IActionResult result;
            try
            {
                _roomService.UpdateRoom(room);
                return Ok();
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
            }
        //Get 
        /// <summary>
        /// Get Room By UserID
        /// </summary>
        /// <remarks>Export the rooms whith same UserID</remarks>
        /// <param name="id"></param>
        /// <response code="200">Returned when successful</response>
        /// <response code="500">Unexpected Error</response>
        [HttpGet("user/{id}")]
        [EnableCors("Policy1")]
        public async Task<IActionResult> getRoomsByUser(int id)
        {
            IActionResult result;
            try
            {
                var rooms = await _roomService.GetByUser(id);
                return Ok(rooms);
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }
        //Get 
        /// <summary>
        /// Get Room By Locality
        /// </summary>
        /// <remarks>Export the rooms whith same Locality</remarks>
        /// <param name="locality"></param>
        /// <response code="200">Returned when successful</response>
        /// <response code="500">Unexpected Error</response>
        [HttpGet("locality/{locality}")]
        [EnableCors("Policy1")]
        public async Task<IActionResult> getRoomsByLocality(string locality)
        {
            IActionResult result;
            try
            {
                var rooms = await _roomService.GetByLocality(locality);
                return Ok(rooms);
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }

    }

    
}
