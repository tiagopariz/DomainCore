using System;
using DomainCore.Domain.Core.Entities;
using DomainCore.Domain.Interfaces.Entities;

namespace DomainCore.Domain.Entities
{
    public class Person : Entity, IPerson
    {
        public Person(Guid id) : base(id) { }
    }
}