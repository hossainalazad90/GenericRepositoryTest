using GenericRepositoryTest.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Models.AuditableEntities
{
    [IgnoreEntity]
    public abstract class AuditableEntity<T>:Entity<T>,IAuditableEntity
    {
        public AuditableEntity()
        {
            CreateDateTime = DateTime.Now;
            EditDateTime = DateTime.Now;            
        }
        [IgnoreUpdate]
        public DateTime CreateDateTime { get; set; }

        public DateTime EditDateTime { get; set; }
        [IgnoreUpdate]
        public int CreatorId { get; set; }

        public int EditorId { get; set; }

        public string LoginIP { get; set; }

        public string LoginLocation { get; set; }
    }
}
