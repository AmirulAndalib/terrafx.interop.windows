// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct TCPIP_OWNER_MODULE_BASIC_INFO
    {
        [NativeTypeName("PWCHAR")]
        public ushort* pModuleName;

        [NativeTypeName("PWCHAR")]
        public ushort* pModulePath;
    }
}