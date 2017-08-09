using System;

namespace UnrealEngine{
    /// <summary>
    /// Attribute to mark a method as not invokeable by unreal engine. Unreal will never call methods with this attribute. The attribute is not inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class AssemblyRemoved : Attribute{}
}