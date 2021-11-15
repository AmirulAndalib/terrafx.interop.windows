// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct StorageLayout
    {
        [NativeTypeName("DWORD")]
        public uint LayoutType;

        [NativeTypeName("OLECHAR *")]
        public ushort* pwcsElementName;

        public LARGE_INTEGER cOffset;

        public LARGE_INTEGER cBytes;
    }
}