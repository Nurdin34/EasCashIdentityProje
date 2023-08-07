using EasCashIdentityProje.EntityLayer.Concrete;

namespace EasCashIdentityProje.BusinessLayer.Concrete
{
    internal interface ICustomerAccountProcessService
    {
        void TDelete(CustomerAccountProcess t);
        CustomerAccountProcess TGetByID(int id);
        List<CustomerAccountProcess> TGetList();
        void TInsert(CustomerAccountProcess t);
        void TUpdate(CustomerAccountProcess t);
    }
}