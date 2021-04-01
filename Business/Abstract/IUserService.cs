﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);

        IResult Update(User user);

        IResult Delete(User user);

        IDataResult<List<User>> GetAll();

        IDataResult<List<User>> GetById(int userId);



    }
}
