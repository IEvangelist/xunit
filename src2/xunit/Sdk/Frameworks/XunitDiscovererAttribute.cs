﻿using System;

namespace Xunit.Sdk
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class XunitDiscovererAttribute : Attribute
    {
        public XunitDiscovererAttribute()
        {
            DiscovererType = typeof(FactDiscoverer);
        }

        public Type DiscovererType { get; set; }
    }
}