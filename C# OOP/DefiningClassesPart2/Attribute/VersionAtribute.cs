﻿namespace Attribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        public int Major { get; set; }

        public int Minor { get; set; }

        public VersionAttribute(int major , int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}
