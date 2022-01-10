
using BookSubscription.Application.Features.Books.Commands.CreateBook;
using BookSubscription.Application.Features.Books.Commands.DeleteBook;
using BookSubscription.Application.Features.Books.Commands.UpdateBook;
using BookSubscription.Application.Features.Books.Queries.GetBookDetails;
using BookSubscription.Application.Features.Books.Queries.GetBooksList;
using BookSubscription.Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookSubscription.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILoggedInUserService _loggedInUserService;


        public BookController(IMediator mediator, ILoggedInUserService loggedInUserService)
        {
            _mediator = mediator;
            _loggedInUserService = loggedInUserService;
        }

        [HttpGet(Name = "GetAllBooks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<BookListVm>>> GetAllBooks()
        {
            var dtos = await _mediator.Send(new GetBooksListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetBookById")]
        public async Task<ActionResult<BookDetailVm>> GetBookById(Guid id)
        {
            var getBookDetailQuery = new GetBookDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getBookDetailQuery));
        }

        [HttpPost(Name = "AddBook")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateBookCommand createBookCommand)
        {
            var id = await _mediator.Send(createBookCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateBook")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateBookCommand updateBookCommand)
        {
            await _mediator.Send(updateBookCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteBook")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteBookCommand = new DeleteBookCommand() { BookId = id };
            await _mediator.Send(deleteBookCommand);
            return NoContent();
        }
    }
}
