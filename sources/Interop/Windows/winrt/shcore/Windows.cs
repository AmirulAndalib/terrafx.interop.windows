// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/shcore.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateRandomAccessStreamOnFile([NativeTypeName("PCWSTR")] ushort* filePath, [NativeTypeName("DWORD")] uint accessMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateRandomAccessStreamOverStream(IStream* stream, BSOS_OPTIONS options, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateStreamOverRandomAccessStream(IUnknown* randomAccessStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    }
}
