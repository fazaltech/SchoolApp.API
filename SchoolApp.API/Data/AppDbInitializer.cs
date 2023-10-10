using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SchoolApp.API.Data.Helpers;
using System.Threading.Tasks;

namespace SchoolApp.API.Data
{
	public class AppDbInitializer
	{
		public static async Task SeedRolesDb(IApplicationBuilder applicationBuilder) 
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateAsyncScope()) 
			{
				var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

				if (!await roleManager.RoleExistsAsync(UserRoles.Manager))
					await roleManager.CreateAsync(new IdentityRole(UserRoles.Manager));

				if (!await roleManager.RoleExistsAsync(UserRoles.Student))
					await roleManager.CreateAsync(new IdentityRole(UserRoles.Student));
			}
		}
	}
}
