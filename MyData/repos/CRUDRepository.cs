using System.Collections;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using MyData.domain;

namespace MyData.repos
{
    public interface CRUDRepository<E> : Repository<E>
    {
        void SetValidator(Validator<E> validator);
        void Save(E e);
        ArrayList GetAll();
    }
}