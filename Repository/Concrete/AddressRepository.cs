using CoreMVC.Model;
using CoreMVC.Utilities.Results;
using RunGroopWebApp.Repository.Abstract;
using IResult = CoreMVC.Utilities.Results.IResult;

namespace RunGroopWebApp.Repository.Concrete
{
	public class AddressRepository : IAddressRepository
	{
        public IResult Add(IModel model)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IModel model)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(IModel model)
        {
            throw new NotImplementedException();
        }

        public IResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<IModel>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
