﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);

        List<Color> GetById(int colorId);
        List<Color> GetAll();
    }
}
