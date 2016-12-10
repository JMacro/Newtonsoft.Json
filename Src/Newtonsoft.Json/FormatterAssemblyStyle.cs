﻿
#if DOTNET || PORTABLE40 || PORTABLE

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>
    /// Indicates the method that will be used during deserialization for locating and loading assemblies.
    /// </summary>
    public enum FormatterAssemblyStyle
    {
        /// <summary>
        /// In simple mode, the assembly used during deserialization need not match exactly the assembly used during serialization. Specifically, the version numbers need not match as the <c>LoadWithPartialName</c> method is used to load the assembly.
        /// </summary>
        Simple = 0,

        /// <summary>
        /// In full mode, the assembly used during deserialization must match exactly the assembly used during serialization. The Load method of the Assembly class is used to load the assembly.
        /// </summary>
        Full = 1
    }
}

#endif