using Catalog.Entities;

namespace Catalog.Respositories
{

    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}