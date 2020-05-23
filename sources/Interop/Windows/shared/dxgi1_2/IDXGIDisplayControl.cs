// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C")]
    public unsafe partial struct IDXGIDisplayControl
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIDisplayControl* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIDisplayControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIDisplayControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsStereoEnabled(IDXGIDisplayControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetStereoEnabled(IDXGIDisplayControl* pThis, [NativeTypeName("BOOL")] int enabled);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsStereoEnabled()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsStereoEnabled>(lpVtbl->IsStereoEnabled)((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        public void SetStereoEnabled([NativeTypeName("BOOL")] int enabled)
        {
            Marshal.GetDelegateForFunctionPointer<_SetStereoEnabled>(lpVtbl->SetStereoEnabled)((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), enabled);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr IsStereoEnabled;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public IntPtr SetStereoEnabled;
        }
    }
}
