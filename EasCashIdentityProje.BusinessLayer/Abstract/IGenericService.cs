﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EasCashIdentityProje.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void    TInsert(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        T TGetByID(int id);
        List<T> TGetList();
    }
}
