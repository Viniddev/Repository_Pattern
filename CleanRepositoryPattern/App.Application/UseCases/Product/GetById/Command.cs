using App.Domain.Abstractions;
using MediatR;

namespace App.Application.UseCases.Product.GetById;

public sealed record Command(Guid Id): IRequest<Result<Response>>;
