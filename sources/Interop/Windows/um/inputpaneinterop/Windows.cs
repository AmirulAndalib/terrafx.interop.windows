// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inputpaneinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static ref readonly Guid IID_IInputPaneInterop
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x2C, 0xCF, 0x75,
                    0x95, 0x91,
                    0x31, 0x49,
                    0x83,
                    0x32,
                    0xF0,
                    0xB4,
                    0x09,
                    0xE9,
                    0x16,
                    0xAF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
