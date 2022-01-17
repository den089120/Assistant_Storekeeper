using Assistant_Storekeeper.DbContexts;
using Assistant_Storekeeper.Models;
using Assistant_Storekeeper.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assistant_Storekeeper.Repository
{
    public class MoveProductRepository : IMoveProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public MoveProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<MoveProductDto> CreateUpdateMoveProduct(MoveProductDto moveProductDto)
        {
            MoveProduct moveProduct = _mapper.Map<MoveProductDto, MoveProduct>(moveProductDto);
            if(moveProduct.Id > 0)
            {
                _db.MoveProducts.Update(moveProduct);
            }
            else
            {
                _db.MoveProducts.Add(moveProduct);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<MoveProduct, MoveProductDto>(moveProduct);
        }

        public async Task<bool> DeleteProduct(int moveProductId)
        {
            try
            {
                MoveProduct moveProduct = await _db.MoveProducts.FirstOrDefaultAsync(el => el.Id == moveProductId);
                if(moveProduct == null)
                {
                    return false;
                }
                else
                {
                    _db.MoveProducts.Remove(moveProduct);
                    await _db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<MoveProductDto> GetMoveProductById(int moveProductId)
        {
            MoveProduct moveProduct = await _db.MoveProducts.Where(el => el.Id == moveProductId).FirstOrDefaultAsync();
            return _mapper.Map<MoveProductDto>(moveProduct);
        }

        public async Task<IList<MoveProductDto>> GetMoveProducts()
        {
            List<MoveProduct> moveProduct = await _db.MoveProducts.ToListAsync();
            return _mapper.Map<List<MoveProductDto>>(moveProduct);
        }
    }
}
