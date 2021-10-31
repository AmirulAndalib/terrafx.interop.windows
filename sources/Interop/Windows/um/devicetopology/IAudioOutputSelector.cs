// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB515F69-94A7-429E-8B9C-271B3F11A3AB")]
    [NativeTypeName("struct IAudioOutputSelector : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioOutputSelector
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioOutputSelector*, Guid*, void**, int>)(lpVtbl[0]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioOutputSelector*, uint>)(lpVtbl[1]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioOutputSelector*, uint>)(lpVtbl[2]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSelection(uint* pnIdSelected)
        {
            return ((delegate* unmanaged<IAudioOutputSelector*, uint*, int>)(lpVtbl[3]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this), pnIdSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetSelection(uint nIdSelect, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioOutputSelector*, uint, Guid*, int>)(lpVtbl[4]))((IAudioOutputSelector*)Unsafe.AsPointer(ref this), nIdSelect, pguidEventContext);
        }
    }
}
