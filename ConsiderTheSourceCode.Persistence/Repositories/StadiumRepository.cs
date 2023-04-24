using ConsiderTheSourceCode.Application.Interfaces.Repositories;
using ConsiderTheSourceCode.Domain.Entities;
using ConsiderTheSourceCode.Persistence.Contexts;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsiderTheSourceCode.Persistence.Repositories
{
    public class StadiumRepository : IStadiumRepository
    {
        private readonly IGenericRepository<Stadium> _repository;

        public StadiumRepository(IGenericRepository<Stadium> repository) 
        {
            _repository = repository;
        } 
    }
}
