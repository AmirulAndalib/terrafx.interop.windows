// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28B85A3D-60A0-48BD-9BA1-5CE8D9EA3A6D")]
    [NativeTypeName("struct IDirectManipulationViewport : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectManipulationViewport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, uint>)(lpVtbl[1]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, uint>)(lpVtbl[2]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Enable()
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, int>)(lpVtbl[3]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Disable()
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, int>)(lpVtbl[4]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetContact([NativeTypeName("UINT32")] uint pointerId)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, uint, int>)(lpVtbl[5]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), pointerId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ReleaseContact([NativeTypeName("UINT32")] uint pointerId)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, uint, int>)(lpVtbl[6]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), pointerId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ReleaseAllContacts()
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, int>)(lpVtbl[7]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetStatus(DIRECTMANIPULATION_STATUS* status)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_STATUS*, int>)(lpVtbl[8]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetTag([NativeTypeName("const IID &")] Guid* riid, void** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, Guid*, void**, uint*, int>)(lpVtbl[9]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), riid, @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, IUnknown*, uint, int>)(lpVtbl[10]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetViewportRect(RECT* viewport)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, RECT*, int>)(lpVtbl[11]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), viewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetViewportRect([NativeTypeName("const RECT *")] RECT* viewport)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, RECT*, int>)(lpVtbl[12]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), viewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT ZoomToRect([NativeTypeName("const float")] float left, [NativeTypeName("const float")] float top, [NativeTypeName("const float")] float right, [NativeTypeName("const float")] float bottom, BOOL animate)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, float, float, float, float, BOOL, int>)(lpVtbl[13]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), left, top, right, bottom, animate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetViewportTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, float*, uint, int>)(lpVtbl[14]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), matrix, pointCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SyncDisplayTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, float*, uint, int>)(lpVtbl[15]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), matrix, pointCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetPrimaryContent([NativeTypeName("const IID &")] Guid* riid, void** @object)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, Guid*, void**, int>)(lpVtbl[16]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT AddContent(IDirectManipulationContent* content)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, IDirectManipulationContent*, int>)(lpVtbl[17]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT RemoveContent(IDirectManipulationContent* content)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, IDirectManipulationContent*, int>)(lpVtbl[18]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetViewportOptions(DIRECTMANIPULATION_VIEWPORT_OPTIONS options)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_VIEWPORT_OPTIONS, int>)(lpVtbl[19]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT AddConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[20]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT RemoveConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[21]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT ActivateConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[22]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetManualGesture(DIRECTMANIPULATION_GESTURE_CONFIGURATION configuration)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_GESTURE_CONFIGURATION, int>)(lpVtbl[23]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), configuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetChaining(DIRECTMANIPULATION_MOTION_TYPES enabledTypes)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_MOTION_TYPES, int>)(lpVtbl[24]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), enabledTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT AddEventHandler(HWND window, IDirectManipulationViewportEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, HWND, IDirectManipulationViewportEventHandler*, uint*, int>)(lpVtbl[25]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), window, eventHandler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT RemoveEventHandler([NativeTypeName("DWORD")] uint cookie)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, uint, int>)(lpVtbl[26]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetInputMode(DIRECTMANIPULATION_INPUT_MODE mode)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_INPUT_MODE, int>)(lpVtbl[27]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetUpdateMode(DIRECTMANIPULATION_INPUT_MODE mode)
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_INPUT_MODE, int>)(lpVtbl[28]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, int>)(lpVtbl[29]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT Abandon()
        {
            return ((delegate* unmanaged<IDirectManipulationViewport*, int>)(lpVtbl[30]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
        }
    }
}
