using MassTransit;
using Play.Common;
using Play.Inventory.Service.Entities;
using System.Threading.Tasks;
using static Play.Catalog.Contracts.Contracts;

namespace Play.Inventory.Service.Consumers;
public class CatalogItemUpdatedConsumer : IConsumer<CatalogItemUpdated>
{
    private readonly IRepository<CatalogItem> repository;

    public CatalogItemUpdatedConsumer(IRepository<CatalogItem> repository)
    {
        this.repository = repository;
    }

    public async Task Consume(ConsumeContext<CatalogItemUpdated> context)
    {
        var message = context.Message;

        var item = await repository.GetAsync(message.ItemId);

        if (item is null)
        {
            item = new CatalogItem
            {
                Id = message.ItemId,
                Description = message.Description,
                Name = message.Name
            };

            await repository.CreateAsync(item);
            return;
        }
        item.Name = message.Name;
        item.Description = message.Description;

        await repository.CreateAsync(item);
    }
}
