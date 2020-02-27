using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RudnevMenuProject
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
