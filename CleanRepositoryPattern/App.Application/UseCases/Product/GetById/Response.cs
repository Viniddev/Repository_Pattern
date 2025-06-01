using App.Domain.Abstractions;
using MediatR;

namespace App.Application.UseCases.Product.GetById;

public sealed record Response(Guid Id, string Title): IRequest<Result<Response>>;
