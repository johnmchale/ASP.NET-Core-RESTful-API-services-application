using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class ShapedEntity
    {
        public ShapedEntity()
        {
            Entity = new Entity();
        }

        public Guid Id { get; set; }
        public Entity Entity { get; set; }
    }
}
