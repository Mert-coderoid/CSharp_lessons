using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApi.Application.UserOperations.Commands.CreateUser;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class UserController : ControllerBase
    {
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        readonly IConfiguration _configuration;
        
        public UserController(IBookStoreDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = (IBookStoreDbContext?)context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserModel newUser)
        {
            CreateUserCommand command = new CreateUserCommand(_context, _mapper);
            command.Model = newUser;

            // validator

            command.Handle();
            return Ok();
        }
    }
}