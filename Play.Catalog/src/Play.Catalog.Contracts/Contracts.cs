using System;

namespace Play.Catalog.Contracts;
public class Contracts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string Description);
    public record CatalogItemDeleted(Guid ItemId);
    public record CatalogItemUpdated(Guid ItemId, string Name, string Description);
    public record CatalogItemReordered(Guid ItemId, Guid NewIndex);
    public record CatalogItemPriceUpdated(Guid ItemId, decimal Price);
    public record CatalogItemStockUpdated(Guid ItemId, Guid Stock);
    public record CatalogItemPublished(Guid ItemId);
    public record CatalogItemUnpublished(Guid ItemId);
    public record CatalogItemReviewed(Guid ItemId, bool Approved);
    public record CatalogItemReviewedV2(Guid ItemId, bool Approved, string Reviewer);
    public record CatalogItemReviewedV3(Guid ItemId, bool Approved, string Reviewer, string ReviewerEmail);
    public record CatalogItemReviewedV4(Guid ItemId, bool Approved, string Reviewer, string ReviewerEmail, string ReviewerPhone);
    public record CatalogItemReviewedV5(Guid ItemId, bool Approved, string Reviewer, string ReviewerEmail, string ReviewerPhone, string ReviewerAddress);
    public record CatalogItemReviewedV6(Guid ItemId, bool Approved, string Reviewer, string ReviewerEmail, string ReviewerPhone, string ReviewerAddress, string ReviewerCity);
    public record CatalogItemReviewedV7(Guid ItemId, bool Approved, string Reviewer, string ReviewerEmail, string ReviewerPhone, string ReviewerAddress, string ReviewerCity, string ReviewerCountry);
    public record CatalogItemReviewedV8(Guid ItemId, bool Approved, string Reviewer, string ReviewerEmail, string ReviewerPhone, string ReviewerAddress, string ReviewerCity, string ReviewerCountry, string ReviewerZipCode);
    public record CatalogItemReviewedV9(Guid ItemId, bool Approved, string Reviewer, string ReviewerEmail, string ReviewerPhone, string ReviewerAddress, string ReviewerCity, string ReviewerCountry, string ReviewerZipCode, string ReviewerState);
}
