﻿using System;

namespace Xer.DomainDriven.Repositories
{
    public interface IAggregateRepository<TAggregate, TAggregateId> where TAggregate : IAggregateRoot<TAggregateId> 
                                                                    where TAggregateId : IEquatable<TAggregateId>
    {
        void Save(TAggregate aggregate);
        TAggregate GetById(TAggregateId aggregateId);
    }
}
