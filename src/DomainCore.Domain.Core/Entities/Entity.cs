using System;
using DomainCore.Domain.Core.Interfaces.Entities;

namespace DomainCore.Domain.Core.Entities
{
    public class Entity : IEntity
    {
        public Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}