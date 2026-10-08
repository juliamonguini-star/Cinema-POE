using CinemaDomain;
using FluentValidation;

namespace CinemaDomain.Base
{
    public class BaseService<TypeEntity> : IBaseService<TypeEntity> where TypeEntity : IBaseEntity
    {
        private readonly IBaseRepository<TypeEntity> _baseRepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TypeEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public TypeOutputModel Create<TypeOutputModel, TypeInputModel, TypeValidator>(TypeEntity entity)
            where TypeOutputModel : class
            where TypeInputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>
        {
            var e = _mapper.Map<TypeEntity>(entity);
            Validated(e, Activator.CreateInstance<TypeValidator>());
            _baseRepository.Create(e);
            var outputModel = _mapper.Map<TypeOutputModel>(e);
            return outputModel;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypeOutputModel> ReadAll<TypeOutputModel>() where TypeOutputModel : class
        {
            throw new NotImplementedException();
        }

        public TypeOutputModel ReadbyId<TypeOutputModel>(int id) where TypeOutputModel : class
        {
            throw new NotImplementedException();
        }

        public TypeOutputModel Update<TypeOutputModel, TypeInputModel, TypeValidator>(TypeEntity entity)
            where TypeOutputModel : class
            where TypeInputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>
        {
            throw new NotImplementedException();
        }
    }
}
