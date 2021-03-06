﻿namespace DefiningClassesPartTwoProblem11
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
     AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
     AllowMultiple = false)]

    public class VersionAttribute : Attribute // Problem 11
    {
        private string version;
        public string Version
        {
            get { return this.version; }
            private set { this.version = value; }
        }
        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
