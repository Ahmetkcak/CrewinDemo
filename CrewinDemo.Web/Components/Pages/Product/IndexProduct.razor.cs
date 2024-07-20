using CrewinDemo.Models.Entities;
using CrewinDemo.Models.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace CrewinDemo.Web.Components.Pages.Product;

public partial class IndexProduct
{
    [Inject]
    public ApiClient ApiClient { get; set; }

    [Parameter]
    public string CategorySlug { get; set; }
    public List<CrewinDemo.Models.Entities.Product> Products { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var res = await ApiClient.GetFromJsonAsync<BaseResponseModel>($"/api/Product?category={CategorySlug}");
        if (res != null && res.Success)
        {
            Products = JsonConvert.DeserializeObject<List<CrewinDemo.Models.Entities.Product>>(res.Data.ToString());
        }
        await base.OnInitializedAsync();
    }
}
