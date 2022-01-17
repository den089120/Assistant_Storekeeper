using Assistant_Storekeeper.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assistant_Storekeeper.Repository
{
    interface IMoveProductRepository
    {
        Task<IList<MoveProductDto>> GetMoveProducts();
        Task<MoveProductDto> GetMoveProductById(int moveProductId);
        Task<MoveProductDto> CreateUpdateMoveProduct(MoveProductDto moveProductDto);
        Task<bool> DeleteProduct(int moveProductId);
    }
}
