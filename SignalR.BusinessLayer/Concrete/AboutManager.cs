using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _abutDal;

        public AboutManager(IAboutDal abutDal)
        {
            _abutDal = abutDal;
        }

        public void TAdd(About entity)
        {
            _abutDal.Add(entity);
        }

        public void TDelete(About entity)
        {
            _abutDal.Delete(entity);
        }

        public About TGetByID(int id)
        {
            return _abutDal.GetByID(id);
        }

        public List<About> TGetListAll()
        {
           return _abutDal.GetListAll();
        }

        

        public void TUpdate(About entity)
        {
            _abutDal.Update(entity);
        }
    }
}
