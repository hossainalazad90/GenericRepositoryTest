using GenericRepositoryTest.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Models.AuditableEntities
{
    [IgnoreEntity]
    public class BaseEntity:IBaseEntity
    {
    }
}
