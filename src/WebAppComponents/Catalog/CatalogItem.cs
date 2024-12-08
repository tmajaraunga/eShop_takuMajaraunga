namespace eShop.WebAppComponents.Catalog;

public record CatalogItem(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string PictureUrl,
    int CatalogBrandId,
    // Updating the CreateItem() in CatalogApi.cs for the new attribute, "gender"
    string gender,
    CatalogBrand CatalogBrand,
    int CatalogTypeId,
    CatalogItemType CatalogType);

public record CatalogResult(int PageIndex, int PageSize, int Count, List<CatalogItem> Data);
public record CatalogBrand(int Id, string Brand);
public record CatalogItemType(int Id, string Type);
