using Example.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Example.Blazor;

public abstract class ExampleComponentBase : AbpComponentBase
{
    protected ExampleComponentBase()
    {
        LocalizationResource = typeof(ExampleResource);
    }
}
