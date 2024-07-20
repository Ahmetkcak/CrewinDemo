using CrewinDemo.Models.Entities;
using CrewinDemo.Models.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace CrewinDemo.Web.Components.Pages.Category;

public partial class IndexCategory
{
    [Inject]
    public ApiClient ApiClient { get; set; }
    public List<CrewinDemo.Models.Entities.Category> Categories { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var res = await ApiClient.GetFromJsonAsync<BaseResponseModel>("/api/Category");
        if(res != null && res.Success)
        {
            Categories = JsonConvert.DeserializeObject<List<CrewinDemo.Models.Entities.Category>>(res.Data.ToString());
        }
        await base.OnInitializedAsync();
    }
}
