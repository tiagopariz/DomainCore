using System;

namespace DomainCore.Domain.Core.Interfaces.Entities
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}