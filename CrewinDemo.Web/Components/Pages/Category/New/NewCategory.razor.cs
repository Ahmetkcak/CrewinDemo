using CrewinDemo.Models.Models;
using Microsoft.AspNetCore.Components;

namespace CrewinDemo.Web.Components.Pages.Category.New;

public partial class NewCategory
{
    [Inject]
    public ApiClient ApiClient { get; set; }
    private CrewinDemo.Models.Entities.Category category = new CrewinDemo.Models.Entities.Category();

    private async Task HandleSubmit()
    {
        string name = category.Name;
        await ApiClient.PostAsJsonAsync<CrewinDemo.Models.Entities.Category>("/api/Category", category);
    }
}
