// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C0-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IBinding : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBinding
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBinding*, Guid*, void**, int>)(lpVtbl[0]))((IBinding*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBinding*, uint>)(lpVtbl[1]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBinding*, uint>)(lpVtbl[2]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Abort()
        {
            return ((delegate* unmanaged<IBinding*, int>)(lpVtbl[3]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Suspend()
        {
            return ((delegate* unmanaged<IBinding*, int>)(lpVtbl[4]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Resume()
        {
            return ((delegate* unmanaged<IBinding*, int>)(lpVtbl[5]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPriority([NativeTypeName("LONG")] int nPriority)
        {
            return ((delegate* unmanaged<IBinding*, int, int>)(lpVtbl[6]))((IBinding*)Unsafe.AsPointer(ref this), nPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return ((delegate* unmanaged<IBinding*, int*, int>)(lpVtbl[7]))((IBinding*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetBindResult([NativeTypeName("CLSID *")] Guid* pclsidProtocol, [NativeTypeName("DWORD *")] uint* pdwResult, [NativeTypeName("LPOLESTR *")] ushort** pszResult, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* unmanaged<IBinding*, Guid*, uint*, ushort**, uint*, int>)(lpVtbl[8]))((IBinding*)Unsafe.AsPointer(ref this), pclsidProtocol, pdwResult, pszResult, pdwReserved);
        }
    }
}
