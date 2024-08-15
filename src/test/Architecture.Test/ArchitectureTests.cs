using NetArchTest.Rules;
using System.Reflection;

namespace Architecture.Test;

public class ArchitectureTests
{
    private const string _domainNamespace = "Ordering.Domain";
    private const string _applicationNamespace = "Ordering.Application";
    private const string _infrastructureNamespace = "Ordering.Infrastucture";
    private const string _apiNamespace = "Ordering.API";

    [Fact]
    public void Domain_Should_Not_HaveDependencyOnOtherProject()
    {
        //Arrange
        var assambly = typeof(Ordering.Domain.AssemblyReference).Assembly;
        var otherProjects = new[]
        {
            _domainNamespace,
            _applicationNamespace,
            _infrastructureNamespace,
            _apiNamespace
        };

        //Act
        var result = Types
            .InAssembly(assambly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjects)
            .GetResult();

        //Assert
        Assert.True(result.IsSuccessful);
    }

    [Fact]
    public void Application_Should_Not_HaveDependencyOnOtherProject()
    {
        //Arrange
        var assambly = typeof(Ordering.Application.AssemblyReference).Assembly;
        var otherProjects = new[]
        {
            _applicationNamespace,
            _infrastructureNamespace,
            _apiNamespace
        };

        //Act
        var result = Types
            .InAssembly(assambly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjects)
            .GetResult();

        //Assert
        Assert.True(result.IsSuccessful);
    }
    [Fact]
    public void Infrastructure_Should_Not_HaveDependencyOnOtherProject()
    {
        //Arrange
        var assambly = typeof(Ordering.Domain.AssemblyReference).Assembly;
        var otherProjects = new[]
        {
            _domainNamespace,
            _applicationNamespace,
            _infrastructureNamespace,
            _apiNamespace
        };

        //Act
        var result = Types
            .InAssembly(assambly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjects)
            .GetResult();

        //Assert
        Assert.True(result.IsSuccessful);
    }

    [Fact]
    public void Handlers_Should_Have_DependencyOnDomain()
    {
        ////Arrange
        //var assembly = typeof(Ordering.Application.AssemblyReference).Assembly;

        ////Act
        //var result = Types
        //    .InAssembly(assembly)
        //    .That()
        //    .HaveNameEndingWith("Handlers")
        //    .Should()
        //    .HaveDependencyOn(_domainNamespace)
        //    .GetResult();

        ////Assert
        //Assert.True(result.IsSuccessful);
    }
}