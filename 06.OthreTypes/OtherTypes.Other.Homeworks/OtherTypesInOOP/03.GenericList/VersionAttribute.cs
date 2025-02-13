﻿namespace _03.GenericList
{
    using System;

    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Interface |
        AttributeTargets.Enum |
        AttributeTargets.Method)] 

    public class VersionAttribute : Attribute
    {
        private int majorVersion;
        private int minorVersion;

        public VersionAttribute(int majorVersion, int minorVersion)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        public int MajorVersion
        {
            get
            {
                return this.majorVersion; 
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("majorVersion", "Value of major version cannot be negative.");
                }

                this.majorVersion = value;
            }
        }

        public int MinorVersion
        {
            get
            {
                return this.minorVersion;               
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("minorVersion", "Value of minor version cannot be negative.");
                }

                this.minorVersion = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Version: {0}.{1}", 
                this.MajorVersion,
                this.MinorVersion.ToString("X2"));

            return result;
        }
    }
}
