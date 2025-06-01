using App.Domain.Abstractions.Interfaces;
using App.Domain.Repositories;
using App.Domain.Abstractions;
using App.Domain.Entities;
using MediatR;

namespace App.Application.UseCases.Product.Create;

public class Handler(IProductRepository _productRepository, IUnitOfWork _unitOfWork) : IRequestHandler<Command, Result<Response>>
{
    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        var product = new Products
        {
            Id = Guid.NewGuid(),
            Name = request.Title,
            Price = request.Price
        };

        await _productRepository.CreateAsync(product, cancellationToken);
        await _unitOfWork.CommitAsync(); //commita as alteracoes no banco

        return Result.Success(new Response("Produto criado com sucesso"));
    }
}
