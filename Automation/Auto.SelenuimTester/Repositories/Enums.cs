using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.SelenuimTester.Repositories
{
    public enum ItemType
    {
        ID = 0,
        Name = 1,
        Class = 2,
        Select = 3
    }

    public enum Actions
    {
        Click = 0,
        SendKey = 1,
        SelectByText = 2,
        SelectByValue = 3,
        SelectByIndex = 4
    }
}
