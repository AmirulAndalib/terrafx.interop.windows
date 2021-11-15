// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows
{
    public partial struct DiaAddressMapEntry
    {
        [NativeTypeName("DWORD")]
        public uint rva;

        [NativeTypeName("DWORD")]
        public uint rvaTo;
    }
}