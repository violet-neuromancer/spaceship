using System;
using System.Collections.Generic;

namespace Spaceship.Game.Services
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _registry = new();

        public static void Register<T>(T instance)
        {
            _registry[typeof(T)] = instance;
        }

        public static T Get<T>()
        {
            if (_registry.TryGetValue(typeof(T), out var result)) return (T)result;

            throw new InvalidOperationException($"There is no {typeof(T)} in Service Locator");
        }
    }
}