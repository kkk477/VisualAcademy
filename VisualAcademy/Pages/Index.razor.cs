using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace VisualAcademy.Pages
{
    public partial class Index
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        protected override async Task OnAfterRenderAsync(bool forstRender)
        {
            await JSRuntime.InvokeAsync<object>("RunCarousel");
        }
    }
}
