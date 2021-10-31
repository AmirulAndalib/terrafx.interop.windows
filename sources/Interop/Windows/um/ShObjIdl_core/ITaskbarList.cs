// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56FDF342-FD6D-11D0-958A-006097C9A090")]
    [NativeTypeName("struct ITaskbarList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITaskbarList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITaskbarList*, Guid*, void**, int>)(lpVtbl[0]))((ITaskbarList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITaskbarList*, uint>)(lpVtbl[1]))((ITaskbarList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITaskbarList*, uint>)(lpVtbl[2]))((ITaskbarList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT HrInit()
        {
            return ((delegate* unmanaged<ITaskbarList*, int>)(lpVtbl[3]))((ITaskbarList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddTab(HWND hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList*, HWND, int>)(lpVtbl[4]))((ITaskbarList*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT DeleteTab(HWND hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList*, HWND, int>)(lpVtbl[5]))((ITaskbarList*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ActivateTab(HWND hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList*, HWND, int>)(lpVtbl[6]))((ITaskbarList*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetActiveAlt(HWND hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList*, HWND, int>)(lpVtbl[7]))((ITaskbarList*)Unsafe.AsPointer(ref this), hwnd);
        }
    }
}
