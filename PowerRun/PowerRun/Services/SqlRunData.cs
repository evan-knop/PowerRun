using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PowerRun.Models;

namespace PowerRun.Services
{
    public class SqlRunData : IRunData
    {
        private ApplicationDbContext _context;

        public SqlRunData(ApplicationDbContext context)
        {
            _context = context;
        }

        public Run Add(Run run)
        {
            _context.Runs.Add(run);
            _context.SaveChanges();
            return run;
        }

        public Run Get(int id)
        {
            return _context.Runs.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Run> GetAll(string username)
        {
            return _context.Runs
                .Where(x => x.Username == username);
        }
    }
}
