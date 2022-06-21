using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rooms.Aplication.Contracts.Services;
using Rooms.Business.Models;

namespace Rooms.Api.Controllers
{
        [Route("user")]
        [ApiController]
        public class UserControler : ControllerBase
        {

            private readonly IUserService _userService;

            public UserControler(IUserService userService)
            {
                this._userService = userService;
            }

        //Get 
        /// <summary>
        /// Get User By ID
        /// </summary>
        /// <remarks>Export the user whith one ID</remarks>
        /// <param name="id"></param>
        /// <response code="200">Returned when successful</response>
        /// <response code="404">User not found</response>
        /// <response code="500">Unexpected Error</response>
        [HttpGet("{id}")]
        [EnableCors("Policy1")]
        [ProducesResponseType(typeof(UserCompleto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> getUserById(int id)
            {
            IActionResult result;
            try
            {
                var user = await _userService.GetById(id);
                if(user == null)
                    result = StatusCode(StatusCodes.Status404NotFound);
                else
                     result = Ok(user);
            }
            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }

        /// <summary>
        /// Get User By ID
        /// </summary>
        /// <remarks>Export the user whith one ID</remarks>
        /// <param name="email"></param>
        /// <response code="200">Returned when successful</response>
        /// <response code="404">User not found</response>
        /// <response code="500">Unexpected Error</response>
        [HttpGet("/email/{email}")]
        [EnableCors("Policy1")]
        [ProducesResponseType(typeof(UserCompleto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> getUserByEmail(string email)
        {
            IActionResult result;
            try
            {
                var user = await _userService.GetByEmail(email);
                if(user != null)
                    return Ok(user);
                else 
                    return StatusCode(StatusCodes.Status500InternalServerError);
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }
        /// <summary>
        /// Export Users
        /// </summary>
        /// <remarks>Export all users</remarks>
        /// <response code="200">Returned when successful</response>
        /// <response code="500">Unexpected Error</response>
        [HttpGet]
        [EnableCors("Policy1")]
        [ProducesResponseType(typeof(List<UserCompleto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public async Task<IActionResult> getAll()
            {
                
            IActionResult result;
            try
            {
                var users = await _userService.GetAll();
                result = Ok(users);
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }

        //Put
        /// <summary>
        /// Add User
        /// </summary>
        /// <remarks>Add one user</remarks>
        /// <response code="200">Returned when successful</response>
        /// <response code="500">Unexpected Error</response>
        [HttpPost]
        [EnableCors("Policy1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public IActionResult addUser(UserCompleto user)
            {               
            IActionResult result;
            try
            {
                _userService.AddUser(user);
                result = Ok();
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }

        //Delete
        /// <summary>
        /// Delete User
        /// </summary>
        /// <remarks>Delete one user</remarks>
        /// <param name="id"></param>
        /// <response code="200">Returned when successful</response>
        /// <response code="404">User not found</response>
        /// <response code="500">Unexpected Error</response>
        [HttpDelete("{id}")]
        [EnableCors("Policy1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public async Task<IActionResult> deleteUser(int id)
            {
             IActionResult result;
             try
             {
                var user = await _userService.GetById(id);
                if (user == null)
                    result = StatusCode(StatusCodes.Status404NotFound);
                else { 
                   await _userService.DeleteUser(id);
                    result = Ok();
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
        /// Update User
        /// </summary>
        /// <remarks>Update one user</remarks>
        /// <response code="200">Returned when successful</response>
        /// <response code="500">Unexpected Error</response>
        [HttpPut]
        [EnableCors("Policy1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public IActionResult updateUser(UserCompleto user)
            {
            IActionResult result;
            try
            {
                _userService.UpdateUser(user);
                result = Ok();
            }

            catch (Exception e)
            {
                result = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return result;
        }

      /*  [HttpGet("/login")]
        [EnableCors("Policy1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult login(string email, string pass)
        {
            IActionResult result;
            try
            {
              //var user = _userService.GetByEmail(email);
                var user = this.getUserByEmail(email);

                if (user != null)
                   return Ok(user);
            }

            catch (Exception e)
            {
               return   StatusCode(StatusCodes.Status500InternalServerError);
            }
            return StatusCode(StatusCodes.Status500InternalServerError); 
        }*/
    }

}
 
