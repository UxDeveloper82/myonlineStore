namespace onlineStore.Data.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }
        ICompanyRepository Company { get; }

        IOrderDetailsRepository OrderDetails { get; }

        IShoppingCartRepository ShoppingCart { get; }

        IOrderHeaderRepository OrderHeader { get; }

        IApplicationUserRepository ApplicationUser { get; }
      
        void Save();
    }
}
