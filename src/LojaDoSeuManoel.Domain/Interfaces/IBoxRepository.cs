﻿using LojaDoSeuManoel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Domain.Interfaces
{
    public interface IBoxRepository
    {
        Task<IEnumerable<Box>> GetAllAsync();
        Task<Box?> GetByIdAsync(Guid id);
        Task AddAsync(Box box);
        Task UpdateAsync(Box box);
        Task DeleteAsync(Guid id);
    }
}
