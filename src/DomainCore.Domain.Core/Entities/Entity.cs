using System;
using DomainCore.Domain.Core.Interfaces.Entities;

namespace DomainCore.Domain.Core.Entities
{
    public abstract class Entity : IEntity
    {
        protected Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}