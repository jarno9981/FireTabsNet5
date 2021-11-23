//Copyright (c) Microsoft Corporation.  All rights reserved.

using FireApiCodePackShell.Internal;

namespace FireApiCodePackShell.Shell
{
    /// <summary>Represents a saved search</summary>
    public class ShellSavedSearchCollection : ShellSearchCollection
    {
        internal ShellSavedSearchCollection(IShellItem2 shellItem)
            : base(shellItem) => CoreHelpers.ThrowIfNotVista();
    }
}