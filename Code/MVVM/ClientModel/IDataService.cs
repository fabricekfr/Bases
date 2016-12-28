using System.Collections.Generic;

namespace ClientModel
{
    public interface IDataService
    {
        IEnumerable<IMyObject> GetData(object argument);
    }
}
