// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.10586.0")]
    public partial struct APP_MEMORY_INFORMATION
    {
        [NativeTypeName("ULONG64")]
        public ulong AvailableCommit;

        [NativeTypeName("ULONG64")]
        public ulong PrivateCommitUsage;

        [NativeTypeName("ULONG64")]
        public ulong PeakPrivateCommitUsage;

        [NativeTypeName("ULONG64")]
        public ulong TotalCommitUsage;
    }
}