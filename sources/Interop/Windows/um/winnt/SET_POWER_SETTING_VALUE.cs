// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SET_POWER_SETTING_VALUE
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("GUID")]
        public Guid Guid;

        public SYSTEM_POWER_CONDITION PowerCondition;

        [NativeTypeName("DWORD")]
        public uint DataLength;

        [NativeTypeName("BYTE [1]")]
        public fixed byte Data[1];
    }
}
