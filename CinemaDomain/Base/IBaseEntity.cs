using System;
using FluentValidation;
using CinemaDomain;
using System.Collections.Generic;
using System.Text;

namespace CinemaDomain.Base
{
    public interface IBaseService<TypeEntity> where TypeEntity : IBaseEntity
    {
        TypeOutputModel Create<TypeOutputModel,
                                TypeInputModel,
                                TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>;

        TypeOutputModel ReadbyId<TypeOutputModel>(int id)
            where TypeOutputModel : class;

        IEnumerable<TypeOutputModel> ReadAll<TypeOutputModel>()
            where TypeOutputModel : class;

        TypeOutputModel Update<TypeOutputModel,
                                TypeInputModel,
                                TypeValidator>(TypeEntity entity)
            where TypeInputModel : class
            where TypeOutputModel : class
            where TypeValidator : AbstractValidator<TypeEntity>;

        void Delete(int id);
    }


}
