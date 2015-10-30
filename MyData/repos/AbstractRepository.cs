using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using MyData.domain;

namespace MyData.repos
{
    public abstract class AbstractRepository<E> : CRUDRepository<E>
    {
        protected int LastId;
        private ArrayList entities = new ArrayList();
        private Validator<E> validator;
        

        protected AbstractRepository()
        {
            LastId = 0;
        }

        public void SetValidator(Validator<E> validator)
        {
            this.validator = validator;
        }

        public abstract void SetEntityId(E e);

        public void Save(E e)
        {
            validator.Validate(e);

            LastId++;
            SetEntityId(e);

            entities.Add(e);
        }

        public ArrayList GetAll()
        {
            return entities;
        }

    }
}