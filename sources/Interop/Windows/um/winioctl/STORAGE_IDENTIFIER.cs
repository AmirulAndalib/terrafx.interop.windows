// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_IDENTIFIER
    {
        public STORAGE_IDENTIFIER_CODE_SET CodeSet;

        public STORAGE_IDENTIFIER_TYPE Type;

        [NativeTypeName("WORD")]
        public ushort IdentifierSize;

        [NativeTypeName("WORD")]
        public ushort NextOffset;

        public STORAGE_ASSOCIATION_TYPE Association;

        [NativeTypeName("BYTE [1]")]
        public fixed byte Identifier[1];
    }
}
