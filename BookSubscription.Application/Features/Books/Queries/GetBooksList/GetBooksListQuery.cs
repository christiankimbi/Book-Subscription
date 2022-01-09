using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Features.Books.Queries.GetBooksList
{
    public class GetBooksListQuery : IRequest<List<BookListVm>>
    {

    }
}
