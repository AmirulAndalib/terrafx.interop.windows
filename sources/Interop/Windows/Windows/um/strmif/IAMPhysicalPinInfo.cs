// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("F938C991-3029-11CF-8C44-00AA006B6814")]
    [NativeTypeName("struct IAMPhysicalPinInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMPhysicalPinInfo : IAMPhysicalPinInfo.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMPhysicalPinInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAMPhysicalPinInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMPhysicalPinInfo*, uint>)(lpVtbl[1]))((IAMPhysicalPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMPhysicalPinInfo*, uint>)(lpVtbl[2]))((IAMPhysicalPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPhysicalType([NativeTypeName("long *")] int* pType, [NativeTypeName("LPOLESTR *")] ushort** ppszType)
        {
            return ((delegate* unmanaged<IAMPhysicalPinInfo*, int*, ushort**, int>)(lpVtbl[3]))((IAMPhysicalPinInfo*)Unsafe.AsPointer(ref this), pType, ppszType);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetPhysicalType([NativeTypeName("long *")] int* pType, [NativeTypeName("LPOLESTR *")] ushort** ppszType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMPhysicalPinInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMPhysicalPinInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMPhysicalPinInfo*, uint> Release;

            [NativeTypeName("HRESULT (long *, LPOLESTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMPhysicalPinInfo*, int*, ushort**, int> GetPhysicalType;
        }
    }
}
