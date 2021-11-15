// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.10586.0")]
    public partial struct PROCESS_MEMORY_EXHAUSTION_INFO
    {
        public ushort Version;

        public ushort Reserved;

        public PROCESS_MEMORY_EXHAUSTION_TYPE Type;

        [NativeTypeName("ULONG_PTR")]
        public nuint Value;
    }
}