// ReSharper disable CheckNamespace
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DryIoc.Microsoft.DependencyInjection;

/// <summary>
/// Provides extension methods to integrate DryIoc with Microsoft's hosting and dependency injection systems.
/// </summary>
public static class DryIocExtensions
{
    /// <summary>
    /// Configures the <see cref="IHostBuilder"/> to use DryIoc as its dependency injection container.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="IHostBuilder"/> to configure.</param>
    /// <param name="factory">
    /// An optional <see cref="IServiceProviderFactory{TContainerBuilder}"/> instance to create the DI container. 
    /// If not provided, it will use <see cref="DryIocServiceProviderFactory"/> by default.
    /// </param>
    /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
    public static IHostBuilder UseDryIoc(this IHostBuilder hostBuilder, IServiceProviderFactory<IContainer>? factory = null)
    {
        return hostBuilder.UseServiceProviderFactory(factory ?? new DryIocServiceProviderFactory());
    }
}