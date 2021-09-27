// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static ref readonly Guid IID_ISpatialAudioObjectForHrtf
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDE, 0x6A, 0x43, 0xD7,
                    0x78, 0x19,
                    0x14, 0x4E,
                    0xAB,
                    0xA0,
                    0x55,
                    0x5B,
                    0xD8,
                    0xEB,
                    0x83,
                    0xB4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioObjectRenderStreamForHrtf
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xEE, 0x8D, 0xE0,
                    0x63, 0x53,
                    0x6E, 0x40,
                    0x9F,
                    0xDC,
                    0x08,
                    0x0E,
                    0xE2,
                    0x47,
                    0xBB,
                    0xE0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
