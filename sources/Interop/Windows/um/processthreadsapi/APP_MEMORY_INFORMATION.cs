// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
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
