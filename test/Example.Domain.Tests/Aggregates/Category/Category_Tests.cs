using Example.Builders.Aggregates.Category;
using Shouldly;
using System;
using Xunit;

namespace Example.Aggregates.Category;

public class Category_Tests
{
    [Fact]
    public void Register_Category_Is_Successful()
    {
        //arrange
        Guid id = Guid.NewGuid();
        string name = "first category";

        //act
        var category = new CategoryBuilder().WithId(id).WithName(name).Build();

        //assert
        category.Id.ShouldBe(id);
        category.Name.ShouldBe(name);
    }

    [Fact]
    public void Register_Category_Without_Name_Fails()
    {
        //arrange
        Guid id = Guid.NewGuid();

        //act + assert
        Should.Throw<ArgumentNullException>(() => new CategoryBuilder().WithId(id).WithoutName().Build()).Message.ShouldBe("Value cannot be null. (Parameter 'Name')");
    }

    [Fact]
    public void Register_Category_With_Empty_Name_Fails()
    {

        //arrange
        Guid id = Guid.NewGuid();

        //act + assert
        Should.Throw<ArgumentNullException>(() => new CategoryBuilder().WithId(id).WithName(string.Empty).Build()).Message.ShouldBe("Value cannot be null. (Parameter 'Name')");
    }
}

