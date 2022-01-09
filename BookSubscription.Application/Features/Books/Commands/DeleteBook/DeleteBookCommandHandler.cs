using AutoMapper;
using BookSubscription.Application.Interfaces.Persistence;
using BookSubscription.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Books.Commands.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IAsyncRepository<Book> _bookRepository;
        private readonly IMapper _mapper;

 
        public DeleteBookCommandHandler(IAsyncRepository<Book> bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var bookToDelete = await _bookRepository.GetByIdAsync(request.BookId);

            if (bookToDelete is null)
            {
                throw new Exception("Book Not Found");
            }

            await _bookRepository.DeleteAsync(bookToDelete);

            return Unit.Value;
            
        }
    }
}
