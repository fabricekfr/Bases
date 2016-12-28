using System;
using System.Collections.Generic;
using ClientModel;
using Domain;

namespace DataAccess
{
    public class DesignDataService : IDataService
    {
        public IEnumerable<IMyObject> GetData(object argument)
        {
            return new IMyObject[50];
        }

        public IEnumerable<IMyObject> GetData()
        {
            var data = new List<IMyObject>();
            var start = new DateTime(2014, 1, 1);
            for (var i = 0; i < 30; i++)
            {
                var myObject = new MyObject
                {
                    Date = start.AddDays(i),
                };
                data.Add(myObject);
            }

            return data;
        }
    }
}