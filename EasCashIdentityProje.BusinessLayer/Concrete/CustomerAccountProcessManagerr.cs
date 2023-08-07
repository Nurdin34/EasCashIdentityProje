using EasCashIdentityProje.DataAccessLayer.Abstract;
using EasCashIdentityProje.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasCashIdentityProje.BusinessLayer.Concrete
{
    public class CustomerAccountManagerr : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountManagerr(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }
        public void TDelete(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _customerAccountProcessDal.GetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _customerAccountProcessDal.GetList();
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
