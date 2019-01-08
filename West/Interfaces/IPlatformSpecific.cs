using System;
using System.Threading.Tasks;

namespace West.Interfaces
{
    public interface IPlatformSpecific
    {
        Task DoPlatformSpecificCode(string Hello);
    }
}
