// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows
{
    public static partial class FACILITY
    {
        [NativeTypeName("#define FACILITY_DWRITE 0x898")]
        public const int FACILITY_DWRITE = 0x898;
    }
}
