using CrewinDemo.Models.Models;
using Microsoft.AspNetCore.Components;

namespace CrewinDemo.Web.Components.Pages.Category.New;

public partial class NewCategory
{

    [Inject]
    public ApiClient ApiClient { get; set; }

    CrewinDemo.Models.Entities.Category newCategory = new CrewinDemo.Models.Entities.Category();
    private async Task CreateNewCategoryy()
    {
        await ApiClient.PostAsJsonAsync<CrewinDemo.Models.Entities.Category>("/api/Category", newCategory);
    }
}
