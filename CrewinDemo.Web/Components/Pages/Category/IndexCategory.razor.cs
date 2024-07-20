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

    public BaseResponseModel BaseResponseModel { get; set; }

    protected override async Task OnInitializedAsync()
    {
        BaseResponseModel = await ApiClient.GetFromJsonAsync<BaseResponseModel>("/api/Category");
        if(BaseResponseModel != null && BaseResponseModel.Success)
        {
            Categories = JsonConvert.DeserializeObject<List<CrewinDemo.Models.Entities.Category>>(BaseResponseModel.Data.ToString());
        }
        await base.OnInitializedAsync();
    }
}
