using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Services.SMeal;
using ApexRestaurant.Services.SMenu;
using ApexRestaurant.Services.SMenu_Item;
using ApexRestaurant.Services.SRef_Staff_Role;
using ApexRestaurant.Services.SStaff;
namespace ApexRestaurant.Services
{
 public static class ServicesModule
 {
 public static void Register(IServiceCollection services)
 {
 services.AddTransient<ICustomerService, CustomerService>();
 services.AddTransient<IMealService, MealService>();
 services.AddTransient<IMenuService, MenuService>();
 services.AddTransient<IMenu_ItemService, Menu_ItemService>();
 services.AddTransient<IRef_Staff_RoleService, Ref_Staff_RoleService>();
 services.AddTransient<IStaffService, StaffService>();
 }
}
}