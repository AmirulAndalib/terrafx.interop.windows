// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7E9FB0D3-919F-4307-AB2E-9B1860310C93")]
    [NativeTypeName("struct IShellItem2 : IShellItem")]
    [NativeInheritance("IShellItem")]
    public unsafe partial struct IShellItem2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellItem2*, Guid*, void**, int>)(lpVtbl[0]))((IShellItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellItem2*, uint>)(lpVtbl[1]))((IShellItem2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellItem2*, uint>)(lpVtbl[2]))((IShellItem2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int BindToHandler(IBindCtx* pbc, [NativeTypeName("const GUID &")] Guid* bhid, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItem2*, IBindCtx*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IShellItem2*)Unsafe.AsPointer(ref this), pbc, bhid, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IShellItem2*, IShellItem**, int>)(lpVtbl[4]))((IShellItem2*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName(SIGDN sigdnName, [NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IShellItem2*, SIGDN, ushort**, int>)(lpVtbl[5]))((IShellItem2*)Unsafe.AsPointer(ref this), sigdnName, ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributes([NativeTypeName("SFGAOF")] uint sfgaoMask, [NativeTypeName("SFGAOF *")] uint* psfgaoAttribs)
        {
            return ((delegate* unmanaged<IShellItem2*, uint, uint*, int>)(lpVtbl[6]))((IShellItem2*)Unsafe.AsPointer(ref this), sfgaoMask, psfgaoAttribs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Compare(IShellItem* psi, [NativeTypeName("SICHINTF")] uint hint, int* piOrder)
        {
            return ((delegate* unmanaged<IShellItem2*, IShellItem*, uint, int*, int>)(lpVtbl[7]))((IShellItem2*)Unsafe.AsPointer(ref this), psi, hint, piOrder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItem2*, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[8]))((IShellItem2*)Unsafe.AsPointer(ref this), flags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStoreWithCreateObject(GETPROPERTYSTOREFLAGS flags, IUnknown* punkCreateObject, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItem2*, GETPROPERTYSTOREFLAGS, IUnknown*, Guid*, void**, int>)(lpVtbl[9]))((IShellItem2*)Unsafe.AsPointer(ref this), flags, punkCreateObject, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyStoreForKeys([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys, [NativeTypeName("UINT")] uint cKeys, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, uint, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(lpVtbl[10]))((IShellItem2*)Unsafe.AsPointer(ref this), rgKeys, cKeys, flags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDescriptionList([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyType, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, Guid*, void**, int>)(lpVtbl[11]))((IShellItem2*)Unsafe.AsPointer(ref this), keyType, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Update(IBindCtx* pbc)
        {
            return ((delegate* unmanaged<IShellItem2*, IBindCtx*, int>)(lpVtbl[12]))((IShellItem2*)Unsafe.AsPointer(ref this), pbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[13]))((IShellItem2*)Unsafe.AsPointer(ref this), key, ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, Guid*, int>)(lpVtbl[14]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileTime([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, FILETIME* pft)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, FILETIME*, int>)(lpVtbl[15]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetInt32([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, int* pi)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, int*, int>)(lpVtbl[16]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("LPWSTR *")] ushort** ppsz)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, ushort**, int>)(lpVtbl[17]))((IShellItem2*)Unsafe.AsPointer(ref this), key, ppsz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt32([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("ULONG *")] uint* pui)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, uint*, int>)(lpVtbl[18]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pui);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetUInt64([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("ULONGLONG *")] ulong* pull)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, ulong*, int>)(lpVtbl[19]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pull);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetBool([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("BOOL *")] int* pf)
        {
            return ((delegate* unmanaged<IShellItem2*, PROPERTYKEY*, int*, int>)(lpVtbl[20]))((IShellItem2*)Unsafe.AsPointer(ref this), key, pf);
        }
    }
}