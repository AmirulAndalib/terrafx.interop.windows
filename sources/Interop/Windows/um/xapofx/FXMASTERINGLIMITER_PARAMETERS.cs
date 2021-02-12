// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct FXMASTERINGLIMITER_PARAMETERS
    {
        [NativeTypeName("UINT32")]
        public uint Release;

        [NativeTypeName("UINT32")]
        public uint Loudness;
    }
}
