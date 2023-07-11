﻿using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repostiory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Repository
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
    }
}
