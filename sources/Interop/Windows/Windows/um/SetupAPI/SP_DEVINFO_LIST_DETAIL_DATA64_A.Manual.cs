// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_DEVINFO_LIST_DETAIL_DATA64_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public Guid ClassGuid;

    public HANDLE RemoteMachineHandle;

    [NativeTypeName("CHAR [263]")]
    public fixed sbyte RemoteMachineName[263];
}
