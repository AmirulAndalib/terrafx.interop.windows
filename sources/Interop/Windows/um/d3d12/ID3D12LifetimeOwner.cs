// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E667AF9F-CD56-4F46-83CE-032E595D70A8")]
    [NativeTypeName("struct ID3D12LifetimeOwner : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D12LifetimeOwner
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12LifetimeOwner*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12LifetimeOwner*, uint>)(lpVtbl[1]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12LifetimeOwner*, uint>)(lpVtbl[2]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState)
        {
            ((delegate* unmanaged<ID3D12LifetimeOwner*, D3D12_LIFETIME_STATE, void>)(lpVtbl[3]))((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this), NewState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12LifetimeOwner*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12LifetimeOwner*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12LifetimeOwner*, uint> Release;

            [NativeTypeName("void (D3D12_LIFETIME_STATE) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12LifetimeOwner*, D3D12_LIFETIME_STATE, void> LifetimeStateUpdated;
        }
    }
}
