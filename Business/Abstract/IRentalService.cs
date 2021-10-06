﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
		IDataResult<List<Rental>> GetAll();
		IDataResult<Rental> GetById(int id);
		IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);

		IResult Add(Rental rental);
		IResult Update(Rental rental);
		IResult Delete(Rental rental);
	}
}
