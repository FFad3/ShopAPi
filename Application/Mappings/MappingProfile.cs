﻿using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplayMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }
        private void ApplayMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes().Where(x =>
            typeof(IMap).IsAssignableFrom(x) && !x.IsInterface).ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
