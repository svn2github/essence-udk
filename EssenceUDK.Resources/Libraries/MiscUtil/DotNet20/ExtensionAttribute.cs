﻿#if !DOTNET35
using System;

namespace EssenceUDK.Resources.Libraries.MiscUtil.DotNet20
{
    /// <summary>
    /// Attribute used by the compiler to create extension methods under .NET 2.0.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class ExtensionAttribute : Attribute
    {
    }
}
#endif