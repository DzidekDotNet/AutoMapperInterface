using AutoMapper;
using AutoMapperInterface.Application.Items;
using AutoMapperInterface.Domain.Items;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperInterface.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ItemsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetItems()
        {
            return Ok((await _mediator.Send(new GetItemsQuery())).Select(x => _mapper.Map<ItemDto>(x)));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetItem(int id)
        {
            return Ok(_mapper.Map<ItemDto>(await _mediator.Send(new GetItemQuery(id))));
        }
        
        [HttpPost]
        public async Task<ActionResult> AddItem(AddItemDto item)
        {
            return Ok(await _mediator.Send(new AddItemCommand(_mapper.Map<Item>(item))));
        }
    }
}