using PowerRun.Models;
using System.Collections.Generic;

namespace PowerRun.Services
{
    public interface IRunData
    {
        IEnumerable<Run> GetAll(string username);
        Run Add(Run run);
    }
}
