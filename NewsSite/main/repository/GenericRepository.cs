using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSite.main.utils;
using NewsSite.main.domain;

namespace NewsSite.main.repository
{
    public class GenericRepository<E>
    {
        private Object[] Storage = new Object[Constants.RepoSize];
        private int LastID;
        private Validator Validator;

        public GenericRepository()
        {
            LastID = 0;
            Validator = new Validator();
        }

        public void Save(E e)
        {
            //Validator.Validate(e);

            LastID++;
            //e.Id = LastID;

            Storage[LastID-1] = e;
        }

        public E[] GetAll()
        {
            E[] allObjects = new E[LastID];

            for (int i = 0; i < LastID; i++)
            {
                allObjects[i] = (E) Storage[i];
            }

            return allObjects;
        }
    }
}
