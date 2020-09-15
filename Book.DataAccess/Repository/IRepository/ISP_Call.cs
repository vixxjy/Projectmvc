﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMVC.DataAccess.Repository.IRepository
{
    //all methods needed in a store procedure call.
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedureName, DynamicParameters param = null);

        void Execute(string procedureName, DynamicParameters param = null);

        T OneRecord<T>(string procedureName, DynamicParameters param = null);

        IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null);

        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedureName, DynamicParameters param = null);
    }
}
