// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebAuthenticationCoreManagerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F4B8E804-811E-4436-B69C-44CB67B72084")]
    [NativeTypeName("struct IWebAuthenticationCoreManagerInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IWebAuthenticationCoreManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint>)(lpVtbl[1]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint>)(lpVtbl[2]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RequestTokenForWindowAsync(HWND appWindow, IInspectable* request, [NativeTypeName("const IID &")] Guid* riid, void** asyncInfo)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, HWND, IInspectable*, Guid*, void**, int>)(lpVtbl[6]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), appWindow, request, riid, asyncInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RequestTokenWithWebAccountForWindowAsync(HWND appWindow, IInspectable* request, IInspectable* webAccount, [NativeTypeName("const IID &")] Guid* riid, void** asyncInfo)
        {
            return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, HWND, IInspectable*, IInspectable*, Guid*, void**, int>)(lpVtbl[7]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), appWindow, request, webAccount, riid, asyncInfo);
        }
    }
}
