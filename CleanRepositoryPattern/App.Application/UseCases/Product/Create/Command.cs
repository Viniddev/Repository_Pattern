using App.Domain.Abstractions;
using MediatR;

namespace App.Application.UseCases.Product.Create;
public sealed record Command(string Title, decimal Price) : IRequest<Result<Response>>;
