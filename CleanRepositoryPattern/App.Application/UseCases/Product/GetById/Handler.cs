using App.Domain.Repositories;
using App.Domain.Abstractions;
using MediatR;

namespace App.Application.UseCases.Product.GetById;

public sealed class Handler(IProductRepository _productRepository)
    : IRequestHandler<Command, Result<Response>>
{
    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        var result = await _productRepository.GetProductByIdAsync(request.Id, cancellationToken);

        return result is null
            ? Result.Failure<Response>(new Error("404", "Product not found."))
            : Result.Success<Response>(new Response(result.Id, result.Name));
    }
}
