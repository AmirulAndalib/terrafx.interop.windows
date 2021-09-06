// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B7B31DF9-D515-11D3-A11C-00105A1F515A")]
    [NativeTypeName("struct IWbemShutdown : IUnknown")]
    public unsafe partial struct IWbemShutdown
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemShutdown*, Guid*, void**, int>)(lpVtbl[0]))((IWbemShutdown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemShutdown*, uint>)(lpVtbl[1]))((IWbemShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemShutdown*, uint>)(lpVtbl[2]))((IWbemShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown([NativeTypeName("LONG")] int uReason, [NativeTypeName("ULONG")] uint uMaxMilliseconds, IWbemContext* pCtx)
        {
            return ((delegate* unmanaged<IWbemShutdown*, int, uint, IWbemContext*, int>)(lpVtbl[3]))((IWbemShutdown*)Unsafe.AsPointer(ref this), uReason, uMaxMilliseconds, pCtx);
        }
    }
}
