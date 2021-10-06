using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Entities.Dto;

namespace DataAccess.Abstract
{
	public interface IRentalDal : IEntityRepository<Rental>
	{
		List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null);
	}
}
