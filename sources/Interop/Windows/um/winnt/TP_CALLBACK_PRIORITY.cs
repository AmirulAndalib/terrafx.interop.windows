// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum TP_CALLBACK_PRIORITY
    {
        TP_CALLBACK_PRIORITY_HIGH,
        TP_CALLBACK_PRIORITY_NORMAL,
        TP_CALLBACK_PRIORITY_LOW,
        TP_CALLBACK_PRIORITY_INVALID,
        TP_CALLBACK_PRIORITY_COUNT = TP_CALLBACK_PRIORITY_INVALID,
    }
}
