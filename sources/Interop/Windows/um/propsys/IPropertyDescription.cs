// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6F79D558-3E96-4549-A1D1-7D75D2288814")]
    [NativeTypeName("struct IPropertyDescription : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyDescription : IPropertyDescription.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyDescription*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescription*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyDescription*, uint>)(lpVtbl[1]))((IPropertyDescription*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyDescription*, uint>)(lpVtbl[2]))((IPropertyDescription*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPERTYKEY*, int>)(lpVtbl[3]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IPropertyDescription*, ushort**, int>)(lpVtbl[4]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
        {
            return ((delegate* unmanaged<IPropertyDescription*, ushort*, int>)(lpVtbl[5]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pvartype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
        {
            return ((delegate* unmanaged<IPropertyDescription*, ushort**, int>)(lpVtbl[6]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
        {
            return ((delegate* unmanaged<IPropertyDescription*, ushort**, int>)(lpVtbl[7]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppszInvite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetTypeFlags(PROPDESC_TYPE_FLAGS mask, PROPDESC_TYPE_FLAGS* ppdtFlags)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int>)(lpVtbl[8]))((IPropertyDescription*)Unsafe.AsPointer(ref this), mask, ppdtFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetViewFlags(PROPDESC_VIEW_FLAGS* ppdvFlags)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_VIEW_FLAGS*, int>)(lpVtbl[9]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppdvFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDefaultColumnWidth(uint* pcxChars)
        {
            return ((delegate* unmanaged<IPropertyDescription*, uint*, int>)(lpVtbl[10]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pcxChars);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetDisplayType(PROPDESC_DISPLAYTYPE* pdisplaytype)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_DISPLAYTYPE*, int>)(lpVtbl[11]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pdisplaytype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
        {
            return ((delegate* unmanaged<IPropertyDescription*, uint*, int>)(lpVtbl[12]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pcsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetGroupingRange(PROPDESC_GROUPING_RANGE* pgr)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_GROUPING_RANGE*, int>)(lpVtbl[13]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pgr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetRelativeDescriptionType(PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int>)(lpVtbl[14]))((IPropertyDescription*)Unsafe.AsPointer(ref this), prdt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int>)(lpVtbl[15]))((IPropertyDescription*)Unsafe.AsPointer(ref this), propvar1, propvar2, ppszDesc1, ppszDesc2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetSortDescription(PROPDESC_SORTDESCRIPTION* psd)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_SORTDESCRIPTION*, int>)(lpVtbl[16]))((IPropertyDescription*)Unsafe.AsPointer(ref this), psd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetSortDescriptionLabel(BOOL fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* unmanaged<IPropertyDescription*, BOOL, ushort**, int>)(lpVtbl[17]))((IPropertyDescription*)Unsafe.AsPointer(ref this), fDescending, ppszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetAggregationType(PROPDESC_AGGREGATION_TYPE* paggtype)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_AGGREGATION_TYPE*, int>)(lpVtbl[18]))((IPropertyDescription*)Unsafe.AsPointer(ref this), paggtype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetConditionType(PROPDESC_CONDITION_TYPE* pcontype, CONDITION_OPERATION* popDefault)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int>)(lpVtbl[19]))((IPropertyDescription*)Unsafe.AsPointer(ref this), pcontype, popDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyDescription*, Guid*, void**, int>)(lpVtbl[20]))((IPropertyDescription*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CoerceToCanonicalValue(PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, int>)(lpVtbl[21]))((IPropertyDescription*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int>)(lpVtbl[22]))((IPropertyDescription*)Unsafe.AsPointer(ref this), propvar, pdfFlags, ppszDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, int>)(lpVtbl[23]))((IPropertyDescription*)Unsafe.AsPointer(ref this), propvar);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetPropertyKey(PROPERTYKEY* pkey);

            [VtblIndex(4)]
            HRESULT GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName);

            [VtblIndex(5)]
            HRESULT GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype);

            [VtblIndex(6)]
            HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName);

            [VtblIndex(7)]
            HRESULT GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite);

            [VtblIndex(8)]
            HRESULT GetTypeFlags(PROPDESC_TYPE_FLAGS mask, PROPDESC_TYPE_FLAGS* ppdtFlags);

            [VtblIndex(9)]
            HRESULT GetViewFlags(PROPDESC_VIEW_FLAGS* ppdvFlags);

            [VtblIndex(10)]
            HRESULT GetDefaultColumnWidth(uint* pcxChars);

            [VtblIndex(11)]
            HRESULT GetDisplayType(PROPDESC_DISPLAYTYPE* pdisplaytype);

            [VtblIndex(12)]
            HRESULT GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags);

            [VtblIndex(13)]
            HRESULT GetGroupingRange(PROPDESC_GROUPING_RANGE* pgr);

            [VtblIndex(14)]
            HRESULT GetRelativeDescriptionType(PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt);

            [VtblIndex(15)]
            HRESULT GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2);

            [VtblIndex(16)]
            HRESULT GetSortDescription(PROPDESC_SORTDESCRIPTION* psd);

            [VtblIndex(17)]
            HRESULT GetSortDescriptionLabel(BOOL fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription);

            [VtblIndex(18)]
            HRESULT GetAggregationType(PROPDESC_AGGREGATION_TYPE* paggtype);

            [VtblIndex(19)]
            HRESULT GetConditionType(PROPDESC_CONDITION_TYPE* pcontype, CONDITION_OPERATION* popDefault);

            [VtblIndex(20)]
            HRESULT GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, void** ppv);

            [VtblIndex(21)]
            HRESULT CoerceToCanonicalValue(PROPVARIANT* ppropvar);

            [VtblIndex(22)]
            HRESULT FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay);

            [VtblIndex(23)]
            HRESULT IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, uint> Release;

            [NativeTypeName("HRESULT (PROPERTYKEY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPERTYKEY*, int> GetPropertyKey;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, ushort**, int> GetCanonicalName;

            [NativeTypeName("HRESULT (VARTYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, ushort*, int> GetPropertyType;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, ushort**, int> GetEditInvitation;

            [NativeTypeName("HRESULT (PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int> GetTypeFlags;

            [NativeTypeName("HRESULT (PROPDESC_VIEW_FLAGS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPDESC_VIEW_FLAGS*, int> GetViewFlags;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, uint*, int> GetDefaultColumnWidth;

            [NativeTypeName("HRESULT (PROPDESC_DISPLAYTYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPDESC_DISPLAYTYPE*, int> GetDisplayType;

            [NativeTypeName("HRESULT (SHCOLSTATEF *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, uint*, int> GetColumnState;

            [NativeTypeName("HRESULT (PROPDESC_GROUPING_RANGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPDESC_GROUPING_RANGE*, int> GetGroupingRange;

            [NativeTypeName("HRESULT (PROPDESC_RELATIVEDESCRIPTION_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int> GetRelativeDescriptionType;

            [NativeTypeName("HRESULT (const PROPVARIANT &, const PROPVARIANT &, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int> GetRelativeDescription;

            [NativeTypeName("HRESULT (PROPDESC_SORTDESCRIPTION *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPDESC_SORTDESCRIPTION*, int> GetSortDescription;

            [NativeTypeName("HRESULT (BOOL, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, BOOL, ushort**, int> GetSortDescriptionLabel;

            [NativeTypeName("HRESULT (PROPDESC_AGGREGATION_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPDESC_AGGREGATION_TYPE*, int> GetAggregationType;

            [NativeTypeName("HRESULT (PROPDESC_CONDITION_TYPE *, CONDITION_OPERATION *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int> GetConditionType;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, Guid*, void**, int> GetEnumTypeList;

            [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, int> CoerceToCanonicalValue;

            [NativeTypeName("HRESULT (const PROPVARIANT &, PROPDESC_FORMAT_FLAGS, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int> FormatForDisplay;

            [NativeTypeName("HRESULT (const PROPVARIANT &) __attribute__((stdcall))")]
            public delegate* unmanaged<IPropertyDescription*, PROPVARIANT*, int> IsValueCanonical;
        }
    }
}
