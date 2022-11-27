using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Interfaces
{
    public interface IEntityConfiguration
    {
        void Visit(ModelBuilder modelBuilder);
    }
}
