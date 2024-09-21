using Evently.Common.Application.Messaging;
using System;

namespace Evently.Modules.Ticketing.Application.Carts.AddItemToCart;

public sealed record AddItemToCartCommand(
    Guid CustomerId, 
    Guid TicketTypeId, 
    decimal Quantity) 
    : ICommand;
