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
    public class CountryRepository : ICountryRepository
    {
        private readonly IGenericRepository<Country> _repository;

        public CountryRepository(IGenericRepository<Country> repository) 
        {
            _repository = repository;
        } 
    }
}
