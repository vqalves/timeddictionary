using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimedDictionary.DateTimeProvider
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}