using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDB.Common
{
    public interface IInitializer
    {
        Task InitializeAsync();
    }

    public interface IStartupInitializer : IInitializer
    {
        void AddInitializer(IInitializer initializer);
    }

    public class StartupInitializer : IStartupInitializer
    {
        private readonly ISet<IInitializer> _initializers = new HashSet<IInitializer>();

        public void AddInitializer(IInitializer initializer)
            => _initializers.Add(initializer);

        public async Task InitializeAsync()
            => await Task.WhenAll(_initializers.Select(i => i.InitializeAsync()));
    }
}
