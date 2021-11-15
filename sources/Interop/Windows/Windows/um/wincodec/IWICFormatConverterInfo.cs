// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("9F34FB65-13F4-4F15-BC57-3726B5E53D9F")]
    [NativeTypeName("struct IWICFormatConverterInfo : IWICComponentInfo")]
    [NativeInheritance("IWICComponentInfo")]
    public unsafe partial struct IWICFormatConverterInfo : IWICFormatConverterInfo.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, uint>)(lpVtbl[1]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, uint>)(lpVtbl[2]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetComponentType(WICComponentType* pType)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, Guid*, int>)(lpVtbl[4]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, uint*, int>)(lpVtbl[5]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetVendorGUID(Guid* pguidVendor)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, Guid*, int>)(lpVtbl[7]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetPixelFormats(uint cFormats, [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormatGUIDs, uint* pcActual)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, uint, Guid*, uint*, int>)(lpVtbl[11]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cFormats, pPixelFormatGUIDs, pcActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateInstance(IWICFormatConverter** ppIConverter)
        {
            return ((delegate* unmanaged<IWICFormatConverterInfo*, IWICFormatConverter**, int>)(lpVtbl[12]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), ppIConverter);
        }

        public interface Interface : IWICComponentInfo.Interface
        {
            [VtblIndex(11)]
            HRESULT GetPixelFormats(uint cFormats, [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormatGUIDs, uint* pcActual);

            [VtblIndex(12)]
            HRESULT CreateInstance(IWICFormatConverter** ppIConverter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, uint, ushort*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (UINT, WICPixelFormatGUID *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, uint, Guid*, uint*, int> GetPixelFormats;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICFormatConverterInfo*, IWICFormatConverter**, int> CreateInstance;
        }
    }
}