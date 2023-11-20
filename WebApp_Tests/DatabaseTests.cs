using Microsoft.Extensions.Configuration;

namespace WebApp_Tests;

public class DatabaseTests
{
    [Fact]
    public void ConnectionString_SqlServer_Should_be_a_ConnectionString_To_AzureSqlDatabase()
    {
        //Arrange
        var expected = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LovaJ\\OneDrive\\Dokument\\database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        // Act
        var result = configuration.GetConnectionString("SqlServer");

        // Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void ConnectionString_CosmosDb_Should_be_a_ConnectionString_To_AzureCosmosDB()
    {
        //Arrange
        var expected = "";

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        // Act
        var result = configuration.GetConnectionString("CosmosDb");

        // Assert
        Assert.Equal(expected, result);
    }
}
