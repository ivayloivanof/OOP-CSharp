namespace GenericListVersion.Class
{
    using System;
    [System.AttributeUsage( System.AttributeTargets.Class |
                            System.AttributeTargets.Struct |
                            System.AttributeTargets.Interface |
                            System.AttributeTargets.Enum | 
                            System.AttributeTargets.Method)]

    public class MyVersion : System.Attribute
    {
        public readonly string ver;

        public MyVersion(string version)
        {
            this.ver = version;
        }
    }
}
