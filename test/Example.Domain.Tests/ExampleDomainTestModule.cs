using Example.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Example;

[DependsOn(
    typeof(ExampleEntityFrameworkCoreTestModule)
    )]
public class ExampleDomainTestModule : AbpModule
{

}
