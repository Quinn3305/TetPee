using Microsoft.EntityFrameworkCore;
using TetPee.Repository;
using TetPee.Service.User;
using Response = TetPee.Service.Base.Response;

namespace TetPee.Service.Seller;

public class Service:  IService
{
    private readonly AppDbContext  _dbContext;

    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<Base.Response.PageResult<Response.GetSellersResponse>> GetSellers(string? searchTerm, int pageSize, int pageIndex)
    {
        var query = _dbContext.Sellers.Where(s => true);
        if (searchTerm != null)
        {
            query = query.Where(s=> s.User.FirstName.Contains(searchTerm) 
                                    || s.User.LastName.Contains(searchTerm)
                                    || s.User.Email.Contains(searchTerm));
        }
        query = query.OrderBy(s => s.User.Email);
        query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        
        var selectedQuery =  query.Select(s=> new Response.GetSellersResponse()
        {
            Id = s.Id,
            FirstName = s.User.FirstName,
            LastName = s.User.LastName,
            Email = s.User.Email,
            
            Role =  s.User.Role,
            TaxCode = s.TaxCode,
            CompanyName =  s.CompanyName,
        });
        var listResult =  await selectedQuery.ToListAsync();
        var totalItems = selectedQuery.Count();
        var result = new Base.Response.PageResult<Response.GetSellersResponse>()
        {
            Items = listResult,
            TotalItems = totalItems,
            PageSize = pageSize,
            PageIndex = pageIndex,
        };
        return result;
        
        // var query = _dbContext.Sellers.Where(s => s.User.Role);
        //
        // if (searchTerm != null)
        // {
        //     query = query.Where(x =>
        //         x.User.FirstName.Contains(searchTerm) ||
        //         x.User.LastName.Contains(searchTerm) ||
        //         x.User.Email.Contains(searchTerm));
        // }
        // query = query.OrderBy(x => x.User.Email);
        //
        // query = query
        //     .Skip((pageIndex - 1) * pageSize)
        //     .Take(pageSize);
        //
        // var selectedQuery = query
        //     .Select(x => new Response.GetSellersResponse()
        //     {
        //         Id = x.Id,
        //         Email =   x.User.Email,
        //         FirstName = x.User.FirstName,
        //         LastName = x.User.LastName,
        //         ImageUrl =  x.User.ImageUrl,
        //         Role = x.User.Role,
        //         CompanyName = x.CompanyName,
        //         TaxCode =  x.TaxCode,
        //     });
        //
        //
        // var listResult = await selectedQuery.ToListAsync<Response.GetSellersResponse>();
        // var totalItems =  listResult.Count();
        // var result = new Base.Response.PageResult<Response.GetSellersResponse>()
        // {
        //     Items =  listResult,
        //     PageIndex =  pageIndex,
        //     PageSize = pageSize,
        //     TotalItems = totalItems,
        // };
        // return result;
    }

    public async Task<Response.GetSellerByIdResponse?> GetSellerId(Guid id)
    {
        var query =  _dbContext.Sellers.Where(x => x.Id == id);
        
        var selectionQuery = query
            .Select(x => new Response.GetSellerByIdResponse()
            {
                Id = x.Id,
                Email =   x.User.Email,
                FirstName = x.User.FirstName,
                LastName = x.User.LastName,
                ImageUrl =  x.User.ImageUrl,
                PhoneNumber = x.User.PhoneNumber,
                Address = x.User.Address,
                Role = x.User.Role,
            });
        var result = await selectionQuery.FirstOrDefaultAsync();
        return result;
    }
}