// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("60E567C8-9573-4AB2-A264-637C6C161CB1")]
    [NativeTypeName("struct IShellUIHelper7 : IShellUIHelper6")]
    [NativeInheritance("IShellUIHelper6")]
    public unsafe partial struct IShellUIHelper7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, Guid*, void**, int>)(lpVtbl[0]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, uint>)(lpVtbl[1]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, uint>)(lpVtbl[2]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, uint*, int>)(lpVtbl[3]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ResetFirstBootMode()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[7]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ResetSafeMode()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[8]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RefreshOfflineDesktop()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[9]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, VARIANT*, int>)(lpVtbl[10]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL, Title);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT AddChannel([NativeTypeName("BSTR")] ushort* URL)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, int>)(lpVtbl[11]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddDesktopComponent([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Type, VARIANT* Left, VARIANT* Top, VARIANT* Width, VARIANT* Height)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[12]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL, Type, Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT IsSubscribed([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, short*, int>)(lpVtbl[13]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL, pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT NavigateAndFind([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* strQuery, VARIANT* varTargetFrame)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[14]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL, strQuery, varTargetFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT ImportExportFavorites([NativeTypeName("VARIANT_BOOL")] short fImport, [NativeTypeName("BSTR")] ushort* strImpExpPath)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, ushort*, int>)(lpVtbl[15]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fImport, strImpExpPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT AutoCompleteSaveForm(VARIANT* Form)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, VARIANT*, int>)(lpVtbl[16]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), Form);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT AutoScan([NativeTypeName("BSTR")] ushort* strSearch, [NativeTypeName("BSTR")] ushort* strFailureUrl, VARIANT* pvarTargetFrame)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[17]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), strSearch, strFailureUrl, pvarTargetFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT AutoCompleteAttach(VARIANT* Reserved)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, VARIANT*, int>)(lpVtbl[18]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), Reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT ShowBrowserUI([NativeTypeName("BSTR")] ushort* bstrName, VARIANT* pvarIn, VARIANT* pvarOut)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, VARIANT*, VARIANT*, int>)(lpVtbl[19]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrName, pvarIn, pvarOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT AddSearchProvider([NativeTypeName("BSTR")] ushort* URL)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, int>)(lpVtbl[20]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT RunOnceShown()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[21]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SkipRunOnce()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[22]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT CustomizeSettings([NativeTypeName("VARIANT_BOOL")] short fSQM, [NativeTypeName("VARIANT_BOOL")] short fPhishing, [NativeTypeName("BSTR")] ushort* bstrLocale)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, short, ushort*, int>)(lpVtbl[23]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fSQM, fPhishing, bstrLocale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SqmEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[24]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT PhishingEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[25]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT BrandImageUri([NativeTypeName("BSTR *")] ushort** pbstrUri)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort**, int>)(lpVtbl[26]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pbstrUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SkipTabsWelcome()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[27]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT DiagnoseConnection()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[28]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT CustomizeClearType([NativeTypeName("VARIANT_BOOL")] short fSet)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[29]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT IsSearchProviderInstalled([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, uint*, int>)(lpVtbl[30]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT IsSearchMigrated([NativeTypeName("VARIANT_BOOL *")] short* pfMigrated)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[31]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfMigrated);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT DefaultSearchProvider([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort**, int>)(lpVtbl[32]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT RunOnceRequiredSettingsComplete([NativeTypeName("VARIANT_BOOL")] short fComplete)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[33]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fComplete);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT RunOnceHasShown([NativeTypeName("VARIANT_BOOL *")] short* pfShown)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[34]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfShown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT SearchGuideUrl([NativeTypeName("BSTR *")] ushort** pbstrUrl)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort**, int>)(lpVtbl[35]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pbstrUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT AddService([NativeTypeName("BSTR")] ushort* URL)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, int>)(lpVtbl[36]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT IsServiceInstalled([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Verb, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, uint*, int>)(lpVtbl[37]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL, Verb, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT InPrivateFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[38]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT AddToFavoritesBar([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* Title, VARIANT* Type)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[39]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL, Title, Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT BuildNewTabPage()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[40]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT SetRecentlyClosedVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[41]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT SetActivitiesVisible([NativeTypeName("VARIANT_BOOL")] short fVisible)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[42]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT ContentDiscoveryReset()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[43]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT IsSuggestedSitesEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[44]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT EnableSuggestedSites([NativeTypeName("VARIANT_BOOL")] short fEnable)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[45]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT NavigateToSuggestedSites([NativeTypeName("BSTR")] ushort* bstrRelativeUrl)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, int>)(lpVtbl[46]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrRelativeUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT ShowTabsHelp()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[47]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT ShowInPrivateHelp()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[48]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT msIsSiteMode([NativeTypeName("VARIANT_BOOL *")] short* pfSiteMode)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[49]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfSiteMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT msSiteModeShowThumbBar()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[50]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT msSiteModeAddThumbBarButton([NativeTypeName("BSTR")] ushort* bstrIconURL, [NativeTypeName("BSTR")] ushort* bstrTooltip, VARIANT* pvarButtonID)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[51]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrIconURL, bstrTooltip, pvarButtonID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT msSiteModeUpdateThumbBarButton(VARIANT ButtonID, [NativeTypeName("VARIANT_BOOL")] short fEnabled, [NativeTypeName("VARIANT_BOOL")] short fVisible)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, VARIANT, short, short, int>)(lpVtbl[52]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), ButtonID, fEnabled, fVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT msSiteModeSetIconOverlay([NativeTypeName("BSTR")] ushort* IconUrl, VARIANT* pvarDescription)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, VARIANT*, int>)(lpVtbl[53]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), IconUrl, pvarDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT msSiteModeClearIconOverlay()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[54]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT msAddSiteMode()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[55]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT msSiteModeCreateJumpList([NativeTypeName("BSTR")] ushort* bstrHeader)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, int>)(lpVtbl[56]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT msSiteModeAddJumpListItem([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("BSTR")] ushort* bstrActionUri, [NativeTypeName("BSTR")] ushort* bstrIconUri, VARIANT* pvarWindowType)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, ushort*, VARIANT*, int>)(lpVtbl[57]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrName, bstrActionUri, bstrIconUri, pvarWindowType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT msSiteModeClearJumpList()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[58]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT msSiteModeShowJumpList()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[59]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT msSiteModeAddButtonStyle(VARIANT uiButtonID, [NativeTypeName("BSTR")] ushort* bstrIconUrl, [NativeTypeName("BSTR")] ushort* bstrTooltip, VARIANT* pvarStyleID)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, VARIANT, ushort*, ushort*, VARIANT*, int>)(lpVtbl[60]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), uiButtonID, bstrIconUrl, bstrTooltip, pvarStyleID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT msSiteModeShowButtonStyle(VARIANT uiButtonID, VARIANT uiStyleID)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, VARIANT, VARIANT, int>)(lpVtbl[61]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), uiButtonID, uiStyleID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT msSiteModeActivate()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[62]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT msIsSiteModeFirstRun([NativeTypeName("VARIANT_BOOL")] short fPreserveState, VARIANT* puiFirstRun)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, VARIANT*, int>)(lpVtbl[63]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fPreserveState, puiFirstRun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT msAddTrackingProtectionList([NativeTypeName("BSTR")] ushort* URL, [NativeTypeName("BSTR")] ushort* bstrFilterName)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, int>)(lpVtbl[64]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), URL, bstrFilterName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT msTrackingProtectionEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[65]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT msActiveXFilteringEnabled([NativeTypeName("VARIANT_BOOL *")] short* pfEnabled)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short*, int>)(lpVtbl[66]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT msProvisionNetworks([NativeTypeName("BSTR")] ushort* bstrProvisioningXml, VARIANT* puiResult)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, VARIANT*, int>)(lpVtbl[67]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrProvisioningXml, puiResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT msReportSafeUrl()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[68]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT msSiteModeRefreshBadge()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[69]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT msSiteModeClearBadge()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[70]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT msDiagnoseConnectionUILess()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[71]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT msLaunchNetworkClientHelp()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[72]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT msChangeDefaultBrowser([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[73]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT msStopPeriodicTileUpdate()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[74]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT msStartPeriodicTileUpdate(VARIANT pollingUris, VARIANT startTime, VARIANT uiUpdateRecurrence)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[75]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pollingUris, startTime, uiUpdateRecurrence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT msStartPeriodicTileUpdateBatch(VARIANT pollingUris, VARIANT startTime, VARIANT uiUpdateRecurrence)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[76]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pollingUris, startTime, uiUpdateRecurrence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT msClearTile()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[77]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT msEnableTileNotificationQueue([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[78]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT msPinnedSiteState(VARIANT* pvarSiteState)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, VARIANT*, int>)(lpVtbl[79]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pvarSiteState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT msEnableTileNotificationQueueForSquare150x150([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[80]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT msEnableTileNotificationQueueForWide310x150([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[81]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT msEnableTileNotificationQueueForSquare310x310([NativeTypeName("VARIANT_BOOL")] short fChange)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, short, int>)(lpVtbl[82]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), fChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT msScheduledTileNotification([NativeTypeName("BSTR")] ushort* bstrNotificationXml, [NativeTypeName("BSTR")] ushort* bstrNotificationId, [NativeTypeName("BSTR")] ushort* bstrNotificationTag, VARIANT startTime, VARIANT expirationTime)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, ushort*, ushort*, VARIANT, VARIANT, int>)(lpVtbl[83]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrNotificationXml, bstrNotificationId, bstrNotificationTag, startTime, expirationTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT msRemoveScheduledTileNotification([NativeTypeName("BSTR")] ushort* bstrNotificationId)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, int>)(lpVtbl[84]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrNotificationId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT msStartPeriodicBadgeUpdate([NativeTypeName("BSTR")] ushort* pollingUri, VARIANT startTime, VARIANT uiUpdateRecurrence)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, VARIANT, VARIANT, int>)(lpVtbl[85]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), pollingUri, startTime, uiUpdateRecurrence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT msStopPeriodicBadgeUpdate()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[86]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT msLaunchInternetOptions()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[87]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT SetExperimentalFlag([NativeTypeName("BSTR")] ushort* bstrFlagString, [NativeTypeName("VARIANT_BOOL")] short vfFlag)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, short, int>)(lpVtbl[88]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrFlagString, vfFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT GetExperimentalFlag([NativeTypeName("BSTR")] ushort* bstrFlagString, [NativeTypeName("VARIANT_BOOL *")] short* vfFlag)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, short*, int>)(lpVtbl[89]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrFlagString, vfFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT SetExperimentalValue([NativeTypeName("BSTR")] ushort* bstrValueString, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, uint, int>)(lpVtbl[90]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrValueString, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HRESULT GetExperimentalValue([NativeTypeName("BSTR")] ushort* bstrValueString, [NativeTypeName("DWORD *")] uint* pdwValue)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, uint*, int>)(lpVtbl[91]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrValueString, pdwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public HRESULT ResetAllExperimentalFlagsAndValues()
        {
            return ((delegate* unmanaged<IShellUIHelper7*, int>)(lpVtbl[92]))((IShellUIHelper7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HRESULT GetNeedIEAutoLaunchFlag([NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("VARIANT_BOOL *")] short* flag)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, short*, int>)(lpVtbl[93]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrUrl, flag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public HRESULT SetNeedIEAutoLaunchFlag([NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("VARIANT_BOOL")] short flag)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, short, int>)(lpVtbl[94]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrUrl, flag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HRESULT HasNeedIEAutoLaunchFlag([NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("VARIANT_BOOL *")] short* exists)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, short*, int>)(lpVtbl[95]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrUrl, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public HRESULT LaunchIE([NativeTypeName("BSTR")] ushort* bstrUrl, [NativeTypeName("VARIANT_BOOL")] short automated)
        {
            return ((delegate* unmanaged<IShellUIHelper7*, ushort*, short, int>)(lpVtbl[96]))((IShellUIHelper7*)Unsafe.AsPointer(ref this), bstrUrl, automated);
        }
    }
}
