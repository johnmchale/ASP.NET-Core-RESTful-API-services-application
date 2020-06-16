﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Entities.Models;


namespace Contracts
{
    public interface IDataShaper<T>
    {
        IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities, string fieldsString);
        ShapedEntity ShapeData(T entity, string fieldsString);
    }
}
