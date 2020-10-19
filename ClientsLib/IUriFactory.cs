using System;
using System.Collections.Generic;

namespace ClientsLib
{
    public interface IUriFactory
    {
        IUriFactory AddParameters(params KeyValuePair<string, string>[] parameters);
        IUriFactory AddSegments(params string[] segments);

        Uri Create();
    }
}
