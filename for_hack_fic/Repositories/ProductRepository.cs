using for_hack_fic.Db.DbConnector;
using for_hack_fic.Db.Models;
using for_hack_fic.Models;

namespace for_hack_fic.Repositories;

public class ProductRepository
{
    private readonly HackForFicDbContext _dbContext;

    public ProductRepository(HackForFicDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Product> GetAll()
    {
        return _dbContext.Products.ToList();
    }

    public List<Product> GetFilteredProducts(ProductFilter filter)
    {
        var query = _dbContext.Products.AsQueryable();

        if (!string.IsNullOrEmpty(filter.BarcodeEan128))
            query = query.Where(p => p.BarcodeEan128 == filter.BarcodeEan128);

        if (!string.IsNullOrEmpty(filter.TypeSign))
            query = query.Where(p => p.TypeSign == filter.TypeSign);

        if (!string.IsNullOrEmpty(filter.Model))
            query = query.Where(p => p.Model == filter.Model);

        if (filter.RetailPrice.HasValue)
            query = query.Where(p => p.RetailPrice == filter.RetailPrice.Value);

        if (!string.IsNullOrEmpty(filter.SupplyNumber))
            query = query.Where(p => p.SupplyNumber == filter.SupplyNumber);

        if (!string.IsNullOrEmpty(filter.NameRu))
            query = query.Where(p => p.NameRu == filter.NameRu);

        if (!string.IsNullOrEmpty(filter.DomesticSize))
            query = query.Where(p => p.DomesticSize == filter.DomesticSize);

        if (!string.IsNullOrEmpty(filter.ManufacturerSize))
            query = query.Where(p => p.ManufacturerSize == filter.ManufacturerSize);

        if (!string.IsNullOrEmpty(filter.CompositionRu))
            query = query.Where(p => p.CompositionRu == filter.CompositionRu);

        if (!string.IsNullOrEmpty(filter.CountryOfOrigin))
            query = query.Where(p => p.CountryOfOrigin == filter.CountryOfOrigin);

        if (!string.IsNullOrEmpty(filter.ManufactureDate))
            query = query.Where(p => p.ManufactureDate == filter.ManufactureDate);

        if (!string.IsNullOrEmpty(filter.ImporterRf))
            query = query.Where(p => p.ImporterRf == filter.ImporterRf);

        if (!string.IsNullOrEmpty(filter.ManufacturerName))
            query = query.Where(p => p.ManufacturerName == filter.ManufacturerName);

        if (!string.IsNullOrEmpty(filter.ProducerName))
            query = query.Where(p => p.ProducerName == filter.ProducerName);

        if (!string.IsNullOrEmpty(filter.ProducerAddress))
            query = query.Where(p => p.ProducerAddress == filter.ProducerAddress);

        if (!string.IsNullOrEmpty(filter.BarcodeEan13))
            query = query.Where(p => p.BarcodeEan13 == filter.BarcodeEan13);

        return query.ToList();
    }
}