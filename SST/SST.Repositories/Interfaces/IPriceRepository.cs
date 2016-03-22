﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Repositories.Interfaces
{
    public interface IPriceRepository
    {
        decimal GetPriceByTutorIdANDDisciplineId(int TutorId, int DisciplineId);
    }
}
