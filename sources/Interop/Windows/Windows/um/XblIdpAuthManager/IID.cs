// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IXblIdpAuthManager
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x08, 0xDB, 0x5D, 0xEB,
                0xBF, 0x8B,
                0x9B, 0x44,
                0xAC,
                0x21,
                0xB0,
                0x2D,
                0xDE,
                0xB3,
                0xB1,
                0x36
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXblIdpAuthTokenResult
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x25, 0x02, 0xCE, 0x46,
                0x67, 0xF2,
                0x68, 0x4D,
                0xB2,
                0x99,
                0xB2,
                0x76,
                0x25,
                0x52,
                0xDE,
                0xC1
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IXblIdpAuthTokenResult2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xB0, 0x60, 0xD7, 0x75,
                0xB9, 0x60,
                0x2D, 0x41,
                0x99,
                0x4F,
                0x26,
                0xB2,
                0xCD,
                0x5F,
                0x78,
                0x12
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
