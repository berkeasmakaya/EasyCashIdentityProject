using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CustomerAccountProcessManager : ICustomerAccountProcessService
	{
		private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

		public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
		{
			_customerAccountProcessDal = customerAccountProcessDal;
		}

		public void TDelete(CustomerAccountProcess t)
		{
			_customerAccountProcessDal.Delete(t);
		}

		public List<CustomerAccountProcess> TGetAll()
		{
			return _customerAccountProcessDal.GetAll();
		}

		public CustomerAccountProcess TGetById(int id)
		{
			return _customerAccountProcessDal.GetById(id);
		}

		public void TInsert(CustomerAccountProcess t)
		{
			_customerAccountProcessDal.Insert(t);
		}

		public void TUpdate(CustomerAccountProcess t)
		{
			_customerAccountProcessDal.Update(t);
		}
	}
}
