﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.LinkModels
{
    public class LinkCollectionWrapper<T> : LinkResourceBase
    {
        public List<T> Value { get; set; } = new List<T>();

        public LinkCollectionWrapper()
        { }

        public LinkCollectionWrapper(List<T> value)
        {
            Value = value;
        }
    }
}
