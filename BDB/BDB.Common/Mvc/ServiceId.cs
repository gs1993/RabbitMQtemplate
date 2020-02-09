using System;

namespace BDB.Common.Mvc
{
    public interface IServiceId
    {
        string Id { get; }
    }

    public class ServiceId : IServiceId
    {
        private static readonly string UniqueId = $"{Guid.NewGuid():N}";

        public string Id => UniqueId;
    }
}
