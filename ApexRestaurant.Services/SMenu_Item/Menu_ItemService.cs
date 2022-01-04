using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMenu_Item;
namespace ApexRestaurant.Services.SMenu_Item
{
 public class Menu_ItemService : GenericService<Menu_Item>, IMenu_ItemService
 {
 public Menu_ItemService(IMenu_ItemRepository Menu_ItemRepository) : 
 base(Menu_ItemRepository)
 {
 }
 }
}