

using LojaDoSeuManoel.Domain.Entities;
using LojaDoSeuManoel.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaDoSeuManoel.Infrastructure.Data.Repositories
{
    public class BoxRepository: IBoxRepository
    {
        private readonly AppDbContext _dbContext;

        public BoxRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Box>> GetAllAsync()
        {
            return await _dbContext.Boxes.ToListAsync();
        }

        public async Task<Box?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Boxes.FindAsync(id);
        }

        public async Task AddAsync(Box box)
        {
            _dbContext.Boxes.Add(box);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Box box)
        {
            _dbContext.Boxes.Update(box);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var box = await _dbContext.Boxes.FindAsync(id);
            if (box != null) {
                _dbContext.Boxes.Remove(box);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
   
    
    }
