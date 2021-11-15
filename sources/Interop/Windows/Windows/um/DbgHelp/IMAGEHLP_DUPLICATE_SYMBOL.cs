// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IMAGEHLP_DUPLICATE_SYMBOL
    {
        [NativeTypeName("DWORD")]
        public uint SizeOfStruct;

        [NativeTypeName("DWORD")]
        public uint NumberOfDups;

        [NativeTypeName("PIMAGEHLP_SYMBOL")]
        public IMAGEHLP_SYMBOL* Symbol;

        [NativeTypeName("DWORD")]
        public uint SelectedSymbol;
    }
}