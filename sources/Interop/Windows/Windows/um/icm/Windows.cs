// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenColorProfileA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HPROFILE OpenColorProfileA([NativeTypeName("PPROFILE")] PROFILE* pProfile, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenColorProfileW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HPROFILE OpenColorProfileW([NativeTypeName("PPROFILE")] PROFILE* pProfile, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseColorProfile"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseColorProfile(HPROFILE hProfile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetColorProfileFromHandle"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetColorProfileFromHandle(HPROFILE hProfile, [NativeTypeName("PBYTE")] byte* pProfile, [NativeTypeName("PDWORD")] uint* pcbProfile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsColorProfileValid"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsColorProfileValid(HPROFILE hProfile, [NativeTypeName("PBOOL")] BOOL* pbValid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProfileFromLogColorSpaceA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern BOOL CreateProfileFromLogColorSpaceA([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* pLogColorSpace, [NativeTypeName("PBYTE *")] byte** pProfile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProfileFromLogColorSpaceW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern BOOL CreateProfileFromLogColorSpaceW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* pLogColorSpace, [NativeTypeName("PBYTE *")] byte** pProfile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCountColorProfileElements"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCountColorProfileElements(HPROFILE hProfile, [NativeTypeName("PDWORD")] uint* pnElementCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetColorProfileHeader"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetColorProfileHeader(HPROFILE hProfile, [NativeTypeName("PPROFILEHEADER")] PROFILEHEADER* pHeader);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetColorProfileElementTag"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetColorProfileElementTag(HPROFILE hProfile, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("PTAGTYPE")] uint* pTag);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsColorProfileTagPresent"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsColorProfileTagPresent(HPROFILE hProfile, [NativeTypeName("TAGTYPE")] uint tag, [NativeTypeName("PBOOL")] BOOL* pbPresent);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetColorProfileElement"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetColorProfileElement(HPROFILE hProfile, [NativeTypeName("TAGTYPE")] uint tag, [NativeTypeName("DWORD")] uint dwOffset, [NativeTypeName("PDWORD")] uint* pcbElement, [NativeTypeName("PVOID")] void* pElement, [NativeTypeName("PBOOL")] BOOL* pbReference);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetColorProfileHeader"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetColorProfileHeader(HPROFILE hProfile, [NativeTypeName("PPROFILEHEADER")] PROFILEHEADER* pHeader);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetColorProfileElementSize"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetColorProfileElementSize(HPROFILE hProfile, [NativeTypeName("TAGTYPE")] uint tagType, [NativeTypeName("DWORD")] uint pcbElement);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetColorProfileElement"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetColorProfileElement(HPROFILE hProfile, [NativeTypeName("TAGTYPE")] uint tag, [NativeTypeName("DWORD")] uint dwOffset, [NativeTypeName("PDWORD")] uint* pcbElement, [NativeTypeName("PVOID")] void* pElement);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetColorProfileElementReference"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetColorProfileElementReference(HPROFILE hProfile, [NativeTypeName("TAGTYPE")] uint newTag, [NativeTypeName("TAGTYPE")] uint refTag);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPS2ColorSpaceArray"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetPS2ColorSpaceArray(HPROFILE hProfile, [NativeTypeName("DWORD")] uint dwIntent, [NativeTypeName("DWORD")] uint dwCSAType, [NativeTypeName("PBYTE")] byte* pPS2ColorSpaceArray, [NativeTypeName("PDWORD")] uint* pcbPS2ColorSpaceArray, [NativeTypeName("PBOOL")] BOOL* pbBinary);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPS2ColorRenderingIntent"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetPS2ColorRenderingIntent(HPROFILE hProfile, [NativeTypeName("DWORD")] uint dwIntent, [NativeTypeName("PBYTE")] byte* pBuffer, [NativeTypeName("PDWORD")] uint* pcbPS2ColorRenderingIntent);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPS2ColorRenderingDictionary"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern BOOL GetPS2ColorRenderingDictionary(HPROFILE hProfile, [NativeTypeName("DWORD")] uint dwIntent, [NativeTypeName("PBYTE")] byte* pPS2ColorRenderingDictionary, [NativeTypeName("PDWORD")] uint* pcbPS2ColorRenderingDictionary, [NativeTypeName("PBOOL")] BOOL* pbBinary);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNamedProfileInfo"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern BOOL GetNamedProfileInfo(HPROFILE hProfile, [NativeTypeName("PNAMED_PROFILE_INFO")] NAMED_PROFILE_INFO* pNamedProfileInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertColorNameToIndex"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern BOOL ConvertColorNameToIndex(HPROFILE hProfile, [NativeTypeName("PCOLOR_NAME")] sbyte** paColorName, [NativeTypeName("PDWORD")] uint* paIndex, [NativeTypeName("DWORD")] uint dwCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertIndexToColorName"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern BOOL ConvertIndexToColorName(HPROFILE hProfile, [NativeTypeName("PDWORD")] uint* paIndex, [NativeTypeName("PCOLOR_NAME")] sbyte** paColorName, [NativeTypeName("DWORD")] uint dwCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDeviceLinkProfile"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDeviceLinkProfile([NativeTypeName("PHPROFILE")] HPROFILE* hProfile, [NativeTypeName("DWORD")] uint nProfiles, [NativeTypeName("PDWORD")] uint* padwIntent, [NativeTypeName("DWORD")] uint nIntents, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE *")] byte** pProfileData, [NativeTypeName("DWORD")] uint indexPreferredCMM);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateColorTransformA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HTRANSFORM CreateColorTransformA([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* pLogColorSpace, HPROFILE hDestProfile, HPROFILE hTargetProfile, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateColorTransformW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HTRANSFORM CreateColorTransformW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* pLogColorSpace, HPROFILE hDestProfile, HPROFILE hTargetProfile, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMultiProfileTransform"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HTRANSFORM CreateMultiProfileTransform([NativeTypeName("PHPROFILE")] HPROFILE* pahProfiles, [NativeTypeName("DWORD")] uint nProfiles, [NativeTypeName("PDWORD")] uint* padwIntent, [NativeTypeName("DWORD")] uint nIntents, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint indexPreferredCMM);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteColorTransform"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteColorTransform(HTRANSFORM hxform);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateBitmapBits"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TranslateBitmapBits(HTRANSFORM hColorTransform, [NativeTypeName("PVOID")] void* pSrcBits, BMFORMAT bmInput, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwInputStride, [NativeTypeName("PVOID")] void* pDestBits, BMFORMAT bmOutput, [NativeTypeName("DWORD")] uint dwOutputStride, [NativeTypeName("PBMCALLBACKFN")] delegate* unmanaged<uint, uint, LPARAM, BOOL> pfnCallBack, LPARAM ulCallbackData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckBitmapBits"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckBitmapBits(HTRANSFORM hColorTransform, [NativeTypeName("PVOID")] void* pSrcBits, BMFORMAT bmInput, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwStride, [NativeTypeName("PBYTE")] byte* paResult, [NativeTypeName("PBMCALLBACKFN")] delegate* unmanaged<uint, uint, LPARAM, BOOL> pfnCallback, LPARAM lpCallbackData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateColors"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TranslateColors(HTRANSFORM hColorTransform, [NativeTypeName("PCOLOR")] COLOR* paInputColors, [NativeTypeName("DWORD")] uint nColors, COLORTYPE ctInput, [NativeTypeName("PCOLOR")] COLOR* paOutputColors, COLORTYPE ctOutput);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckColors"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckColors(HTRANSFORM hColorTransform, [NativeTypeName("PCOLOR")] COLOR* paInputColors, [NativeTypeName("DWORD")] uint nColors, COLORTYPE ctInput, [NativeTypeName("PBYTE")] byte* paResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCMMInfo"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCMMInfo(HTRANSFORM hColorTransform, [NativeTypeName("DWORD")] uint param1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterCMMA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterCMMA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("DWORD")] uint cmmID, [NativeTypeName("PCSTR")] sbyte* pCMMdll);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterCMMW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterCMMW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("DWORD")] uint cmmID, [NativeTypeName("PCWSTR")] char* pCMMdll);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterCMMA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterCMMA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("DWORD")] uint cmmID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterCMMW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterCMMW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("DWORD")] uint cmmID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SelectCMM"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SelectCMM([NativeTypeName("DWORD")] uint dwCMMType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetColorDirectoryA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    [Obsolete("GetColorDirectoryW is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public static extern BOOL GetColorDirectoryA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("PSTR")] sbyte* pBuffer, [NativeTypeName("PDWORD")] uint* pdwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetColorDirectoryW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    [Obsolete("GetColorDirectoryA is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public static extern BOOL GetColorDirectoryW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("PWSTR")] char* pBuffer, [NativeTypeName("PDWORD")] uint* pdwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InstallColorProfileA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InstallColorProfileA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("PCSTR")] sbyte* pProfileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InstallColorProfileW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InstallColorProfileW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("PCWSTR")] char* pProfileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UninstallColorProfileA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UninstallColorProfileA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("PCSTR")] sbyte* pProfileName, BOOL bDelete);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UninstallColorProfileW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UninstallColorProfileW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("PCWSTR")] char* pProfileName, BOOL bDelete);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumColorProfilesA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumColorProfilesA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("PENUMTYPEA")] ENUMTYPEA* pEnumRecord, [NativeTypeName("PBYTE")] byte* pEnumerationBuffer, [NativeTypeName("PDWORD")] uint* pdwSizeOfEnumerationBuffer, [NativeTypeName("PDWORD")] uint* pnProfiles);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumColorProfilesW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumColorProfilesW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("PENUMTYPEW")] ENUMTYPEW* pEnumRecord, [NativeTypeName("PBYTE")] byte* pEnumerationBuffer, [NativeTypeName("PDWORD")] uint* pdwSizeOfEnumerationBuffer, [NativeTypeName("PDWORD")] uint* pnProfiles);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetStandardColorSpaceProfileA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetStandardColorSpaceProfileA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("DWORD")] uint dwProfileID, [NativeTypeName("PCSTR")] sbyte* pProfilename);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetStandardColorSpaceProfileW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetStandardColorSpaceProfileW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("DWORD")] uint dwProfileID, [NativeTypeName("PCWSTR")] char* pProfileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStandardColorSpaceProfileA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetStandardColorSpaceProfileA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("DWORD")] uint dwSCS, [NativeTypeName("PSTR")] sbyte* pBuffer, [NativeTypeName("PDWORD")] uint* pcbSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStandardColorSpaceProfileW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetStandardColorSpaceProfileW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("DWORD")] uint dwSCS, [NativeTypeName("PWSTR")] char* pBuffer, [NativeTypeName("PDWORD")] uint* pcbSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssociateColorProfileWithDeviceA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL AssociateColorProfileWithDeviceA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("PCSTR")] sbyte* pProfileName, [NativeTypeName("PCSTR")] sbyte* pDeviceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssociateColorProfileWithDeviceW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AssociateColorProfileWithDeviceW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("PCWSTR")] char* pProfileName, [NativeTypeName("PCWSTR")] char* pDeviceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DisassociateColorProfileFromDeviceA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DisassociateColorProfileFromDeviceA([NativeTypeName("PCSTR")] sbyte* pMachineName, [NativeTypeName("PCSTR")] sbyte* pProfileName, [NativeTypeName("PCSTR")] sbyte* pDeviceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DisassociateColorProfileFromDeviceW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DisassociateColorProfileFromDeviceW([NativeTypeName("PCWSTR")] char* pMachineName, [NativeTypeName("PCWSTR")] char* pProfileName, [NativeTypeName("PCWSTR")] char* pDeviceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupColorMatchingW"]/*' />
    [DllImport("icmui", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupColorMatchingW([NativeTypeName("PCOLORMATCHSETUPW")] COLORMATCHSETUPW* pcms);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupColorMatchingA"]/*' />
    [DllImport("icmui", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupColorMatchingA([NativeTypeName("PCOLORMATCHSETUPA")] COLORMATCHSETUPA* pcms);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsAssociateColorProfileWithDevice"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsAssociateColorProfileWithDevice(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PCWSTR")] char* pProfileName, [NativeTypeName("PCWSTR")] char* pDeviceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsDisassociateColorProfileFromDevice"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsDisassociateColorProfileFromDevice(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PCWSTR")] char* pProfileName, [NativeTypeName("PCWSTR")] char* pDeviceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsEnumColorProfilesSize"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsEnumColorProfilesSize(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PENUMTYPEW")] ENUMTYPEW* pEnumRecord, [NativeTypeName("PDWORD")] uint* pdwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsEnumColorProfiles"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsEnumColorProfiles(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PENUMTYPEW")] ENUMTYPEW* pEnumRecord, [NativeTypeName("PBYTE")] byte* pBuffer, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("PDWORD")] uint* pnProfiles);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsGetDefaultColorProfileSize"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsGetDefaultColorProfileSize(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PCWSTR")] char* pDeviceName, COLORPROFILETYPE cptColorProfileType, COLORPROFILESUBTYPE cpstColorProfileSubType, [NativeTypeName("DWORD")] uint dwProfileID, [NativeTypeName("PDWORD")] uint* pcbProfileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsGetDefaultColorProfile"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsGetDefaultColorProfile(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PCWSTR")] char* pDeviceName, COLORPROFILETYPE cptColorProfileType, COLORPROFILESUBTYPE cpstColorProfileSubType, [NativeTypeName("DWORD")] uint dwProfileID, [NativeTypeName("DWORD")] uint cbProfileName, [NativeTypeName("LPWSTR")] char* pProfileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsSetDefaultColorProfile"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsSetDefaultColorProfile(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PCWSTR")] char* pDeviceName, COLORPROFILETYPE cptColorProfileType, COLORPROFILESUBTYPE cpstColorProfileSubType, [NativeTypeName("DWORD")] uint dwProfileID, [NativeTypeName("LPCWSTR")] char* pProfileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsSetDefaultRenderingIntent"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsSetDefaultRenderingIntent(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("DWORD")] uint dwRenderingIntent);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsGetDefaultRenderingIntent"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsGetDefaultRenderingIntent(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PDWORD")] uint* pdwRenderingIntent);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsGetUsePerUserProfiles"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsGetUsePerUserProfiles([NativeTypeName("LPCWSTR")] char* pDeviceName, [NativeTypeName("DWORD")] uint dwDeviceClass, [NativeTypeName("PBOOL")] BOOL* pUsePerUserProfiles);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsSetUsePerUserProfiles"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsSetUsePerUserProfiles([NativeTypeName("LPCWSTR")] char* pDeviceName, [NativeTypeName("DWORD")] uint dwDeviceClass, BOOL usePerUserProfiles);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsTranslateColors"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsTranslateColors(HTRANSFORM hColorTransform, [NativeTypeName("DWORD")] uint nColors, [NativeTypeName("DWORD")] uint nInputChannels, COLORDATATYPE cdtInput, [NativeTypeName("DWORD")] uint cbInput, [NativeTypeName("PVOID")] void* pInputData, [NativeTypeName("DWORD")] uint nOutputChannels, COLORDATATYPE cdtOutput, [NativeTypeName("DWORD")] uint cbOutput, [NativeTypeName("PVOID")] void* pOutputData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsCheckColors"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WcsCheckColors(HTRANSFORM hColorTransform, [NativeTypeName("DWORD")] uint nColors, [NativeTypeName("DWORD")] uint nInputChannels, COLORDATATYPE cdtInput, [NativeTypeName("DWORD")] uint cbInput, [NativeTypeName("PVOID")] void* pInputData, [NativeTypeName("PBYTE")] byte* paResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCheckColors"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMCheckColors(HCMTRANSFORM hcmTransform, [NativeTypeName("LPCOLOR")] COLOR* lpaInputColors, [NativeTypeName("DWORD")] uint nColors, COLORTYPE ctInput, [NativeTypeName("LPBYTE")] byte* lpaResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCheckRGBs"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL CMCheckRGBs(HCMTRANSFORM hcmTransform, [NativeTypeName("LPVOID")] void* lpSrcBits, BMFORMAT bmInput, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwStride, [NativeTypeName("LPBYTE")] byte* lpaResult, [NativeTypeName("PBMCALLBACKFN")] delegate* unmanaged<uint, uint, LPARAM, BOOL> pfnCallback, LPARAM ulCallbackData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMConvertColorNameToIndex"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMConvertColorNameToIndex(HPROFILE hProfile, [NativeTypeName("PCOLOR_NAME")] sbyte** paColorName, [NativeTypeName("PDWORD")] uint* paIndex, [NativeTypeName("DWORD")] uint dwCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMConvertIndexToColorName"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMConvertIndexToColorName(HPROFILE hProfile, [NativeTypeName("PDWORD")] uint* paIndex, [NativeTypeName("PCOLOR_NAME")] sbyte** paColorName, [NativeTypeName("DWORD")] uint dwCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCreateDeviceLinkProfile"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMCreateDeviceLinkProfile([NativeTypeName("PHPROFILE")] HPROFILE* pahProfiles, [NativeTypeName("DWORD")] uint nProfiles, [NativeTypeName("PDWORD")] uint* padwIntents, [NativeTypeName("DWORD")] uint nIntents, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPBYTE *")] byte** lpProfileData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCreateMultiProfileTransform"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern HCMTRANSFORM CMCreateMultiProfileTransform([NativeTypeName("PHPROFILE")] HPROFILE* pahProfiles, [NativeTypeName("DWORD")] uint nProfiles, [NativeTypeName("PDWORD")] uint* padwIntents, [NativeTypeName("DWORD")] uint nIntents, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCreateProfileW"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CMCreateProfileW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lpColorSpace, [NativeTypeName("LPDEVCHARACTER *")] void** lpProfileData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCreateTransform"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HCMTRANSFORM CMCreateTransform([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lpColorSpace, [NativeTypeName("LPDEVCHARACTER")] void* lpDevCharacter, [NativeTypeName("LPDEVCHARACTER")] void* lpTargetDevCharacter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCreateTransformW"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HCMTRANSFORM CMCreateTransformW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lpColorSpace, [NativeTypeName("LPDEVCHARACTER")] void* lpDevCharacter, [NativeTypeName("LPDEVCHARACTER")] void* lpTargetDevCharacter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCreateTransformExt"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern HCMTRANSFORM CMCreateTransformExt([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lpColorSpace, [NativeTypeName("LPDEVCHARACTER")] void* lpDevCharacter, [NativeTypeName("LPDEVCHARACTER")] void* lpTargetDevCharacter, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCheckColorsInGamut"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CMCheckColorsInGamut(HCMTRANSFORM hcmTransform, RGBTRIPLE* lpaRGBTriple, [NativeTypeName("LPBYTE")] byte* lpaResult, uint nCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCreateProfile"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CMCreateProfile([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lpColorSpace, [NativeTypeName("LPDEVCHARACTER *")] void** lpProfileData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMTranslateRGB"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMTranslateRGB(HCMTRANSFORM hcmTransform, COLORREF ColorRef, [NativeTypeName("LPCOLORREF")] uint* lpColorRef, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMTranslateRGBs"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CMTranslateRGBs(HCMTRANSFORM hcmTransform, [NativeTypeName("LPVOID")] void* lpSrcBits, BMFORMAT bmInput, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwStride, [NativeTypeName("LPVOID")] void* lpDestBits, BMFORMAT bmOutput, [NativeTypeName("DWORD")] uint dwTranslateDirection);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMCreateTransformExtW"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern HCMTRANSFORM CMCreateTransformExtW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lpColorSpace, [NativeTypeName("LPDEVCHARACTER")] void* lpDevCharacter, [NativeTypeName("LPDEVCHARACTER")] void* lpTargetDevCharacter, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDeleteTransform"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMDeleteTransform(HCMTRANSFORM hcmTransform);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMGetInfo"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CMGetInfo([NativeTypeName("DWORD")] uint dwInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMGetNamedProfileInfo"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMGetNamedProfileInfo(HPROFILE hProfile, [NativeTypeName("PNAMED_PROFILE_INFO")] NAMED_PROFILE_INFO* pNamedProfileInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMIsProfileValid"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMIsProfileValid(HPROFILE hProfile, [NativeTypeName("LPBOOL")] BOOL* lpbValid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMTranslateColors"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMTranslateColors(HCMTRANSFORM hcmTransform, [NativeTypeName("LPCOLOR")] COLOR* lpaInputColors, [NativeTypeName("DWORD")] uint nColors, COLORTYPE ctInput, [NativeTypeName("LPCOLOR")] COLOR* lpaOutputColors, COLORTYPE ctOutput);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMTranslateRGBsExt"]/*' />
    [DllImport("icm32", ExactSpelling = true)]
    public static extern BOOL CMTranslateRGBsExt(HCMTRANSFORM hcmTransform, [NativeTypeName("LPVOID")] void* lpSrcBits, BMFORMAT bmInput, [NativeTypeName("DWORD")] uint dwWidth, [NativeTypeName("DWORD")] uint dwHeight, [NativeTypeName("DWORD")] uint dwInputStride, [NativeTypeName("LPVOID")] void* lpDestBits, BMFORMAT bmOutput, [NativeTypeName("DWORD")] uint dwOutputStride, [NativeTypeName("LPBMCALLBACKFN")] delegate* unmanaged<uint, uint, LPARAM, BOOL> lpfnCallback, LPARAM ulCallbackData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsOpenColorProfileA"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern HPROFILE WcsOpenColorProfileA([NativeTypeName("PPROFILE")] PROFILE* pCDMPProfile, [NativeTypeName("PPROFILE")] PROFILE* pCAMPProfile, [NativeTypeName("PPROFILE")] PROFILE* pGMMPProfile, [NativeTypeName("DWORD")] uint dwDesireAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationMode, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsOpenColorProfileW"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern HPROFILE WcsOpenColorProfileW([NativeTypeName("PPROFILE")] PROFILE* pCDMPProfile, [NativeTypeName("PPROFILE")] PROFILE* pCAMPProfile, [NativeTypeName("PPROFILE")] PROFILE* pGMMPProfile, [NativeTypeName("DWORD")] uint dwDesireAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationMode, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsCreateIccProfile"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HPROFILE WcsCreateIccProfile(HPROFILE hWcsProfile, [NativeTypeName("DWORD")] uint dwOptions);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsGetCalibrationManagementState"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern BOOL WcsGetCalibrationManagementState(BOOL* pbIsEnabled);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcsSetCalibrationManagementState"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    public static extern BOOL WcsSetCalibrationManagementState(BOOL bIsEnabled);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorProfileAddDisplayAssociation"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT ColorProfileAddDisplayAssociation(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PCWSTR")] char* profileName, LUID targetAdapterID, [NativeTypeName("UINT32")] uint sourceID, BOOL setAsDefault, BOOL associateAsAdvancedColor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorProfileRemoveDisplayAssociation"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT ColorProfileRemoveDisplayAssociation(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PCWSTR")] char* profileName, LUID targetAdapterID, [NativeTypeName("UINT32")] uint sourceID, BOOL dissociateAdvancedColor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorProfileSetDisplayDefaultAssociation"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT ColorProfileSetDisplayDefaultAssociation(WCS_PROFILE_MANAGEMENT_SCOPE scope, [NativeTypeName("PCWSTR")] char* profileName, COLORPROFILETYPE profileType, COLORPROFILESUBTYPE profileSubType, LUID targetAdapterID, [NativeTypeName("UINT32")] uint sourceID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorProfileGetDisplayList"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT ColorProfileGetDisplayList(WCS_PROFILE_MANAGEMENT_SCOPE scope, LUID targetAdapterID, [NativeTypeName("UINT32")] uint sourceID, [NativeTypeName("LPWSTR **")] char*** profileList, [NativeTypeName("PDWORD")] uint* profileCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorProfileGetDisplayDefault"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT ColorProfileGetDisplayDefault(WCS_PROFILE_MANAGEMENT_SCOPE scope, LUID targetAdapterID, [NativeTypeName("UINT32")] uint sourceID, COLORPROFILETYPE profileType, COLORPROFILESUBTYPE profileSubType, [NativeTypeName("LPWSTR *")] char** profileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorProfileGetDisplayUserScope"]/*' />
    [DllImport("mscms", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HRESULT ColorProfileGetDisplayUserScope(LUID targetAdapterID, [NativeTypeName("UINT32")] uint sourceID, WCS_PROFILE_MANAGEMENT_SCOPE* scope);

    [NativeTypeName("#define INTENT_PERCEPTUAL 0")]
    public const int INTENT_PERCEPTUAL = 0;

    [NativeTypeName("#define INTENT_RELATIVE_COLORIMETRIC 1")]
    public const int INTENT_RELATIVE_COLORIMETRIC = 1;

    [NativeTypeName("#define INTENT_SATURATION 2")]
    public const int INTENT_SATURATION = 2;

    [NativeTypeName("#define INTENT_ABSOLUTE_COLORIMETRIC 3")]
    public const int INTENT_ABSOLUTE_COLORIMETRIC = 3;

    [NativeTypeName("#define CLASS_MONITOR 'mntr'")]
    public const int CLASS_MONITOR = 0x6D6E7472;

    [NativeTypeName("#define CLASS_PRINTER 'prtr'")]
    public const int CLASS_PRINTER = 0x70727472;

    [NativeTypeName("#define CLASS_SCANNER 'scnr'")]
    public const int CLASS_SCANNER = 0x73636E72;

    [NativeTypeName("#define CLASS_LINK 'link'")]
    public const int CLASS_LINK = 0x6C696E6B;

    [NativeTypeName("#define CLASS_ABSTRACT 'abst'")]
    public const int CLASS_ABSTRACT = 0x61627374;

    [NativeTypeName("#define CLASS_COLORSPACE 'spac'")]
    public const int CLASS_COLORSPACE = 0x73706163;

    [NativeTypeName("#define CLASS_NAMED 'nmcl'")]
    public const int CLASS_NAMED = 0x6E6D636C;

    [NativeTypeName("#define CLASS_CAMP 'camp'")]
    public const int CLASS_CAMP = 0x63616D70;

    [NativeTypeName("#define CLASS_GMMP 'gmmp'")]
    public const int CLASS_GMMP = 0x676D6D70;

    [NativeTypeName("#define SPACE_XYZ 'XYZ '")]
    public const int SPACE_XYZ = 0x58595A20;

    [NativeTypeName("#define SPACE_Lab 'Lab '")]
    public const int SPACE_Lab = 0x4C616220;

    [NativeTypeName("#define SPACE_Luv 'Luv '")]
    public const int SPACE_Luv = 0x4C757620;

    [NativeTypeName("#define SPACE_YCbCr 'YCbr'")]
    public const int SPACE_YCbCr = 0x59436272;

    [NativeTypeName("#define SPACE_Yxy 'Yxy '")]
    public const int SPACE_Yxy = 0x59787920;

    [NativeTypeName("#define SPACE_RGB 'RGB '")]
    public const int SPACE_RGB = 0x52474220;

    [NativeTypeName("#define SPACE_GRAY 'GRAY'")]
    public const int SPACE_GRAY = 0x47524159;

    [NativeTypeName("#define SPACE_HSV 'HSV '")]
    public const int SPACE_HSV = 0x48535620;

    [NativeTypeName("#define SPACE_HLS 'HLS '")]
    public const int SPACE_HLS = 0x484C5320;

    [NativeTypeName("#define SPACE_CMYK 'CMYK'")]
    public const int SPACE_CMYK = 0x434D594B;

    [NativeTypeName("#define SPACE_CMY 'CMY '")]
    public const int SPACE_CMY = 0x434D5920;

    [NativeTypeName("#define SPACE_2_CHANNEL '2CLR'")]
    public const int SPACE_2_CHANNEL = 0x32434C52;

    [NativeTypeName("#define SPACE_3_CHANNEL '3CLR'")]
    public const int SPACE_3_CHANNEL = 0x33434C52;

    [NativeTypeName("#define SPACE_4_CHANNEL '4CLR'")]
    public const int SPACE_4_CHANNEL = 0x34434C52;

    [NativeTypeName("#define SPACE_5_CHANNEL '5CLR'")]
    public const int SPACE_5_CHANNEL = 0x35434C52;

    [NativeTypeName("#define SPACE_6_CHANNEL '6CLR'")]
    public const int SPACE_6_CHANNEL = 0x36434C52;

    [NativeTypeName("#define SPACE_7_CHANNEL '7CLR'")]
    public const int SPACE_7_CHANNEL = 0x37434C52;

    [NativeTypeName("#define SPACE_8_CHANNEL '8CLR'")]
    public const int SPACE_8_CHANNEL = 0x38434C52;

    [NativeTypeName("#define ATTRIB_TRANSPARENCY 0x00000001")]
    public const int ATTRIB_TRANSPARENCY = 0x00000001;

    [NativeTypeName("#define ATTRIB_MATTE 0x00000002")]
    public const int ATTRIB_MATTE = 0x00000002;

    [NativeTypeName("#define PROFILE_FILENAME 1")]
    public const int PROFILE_FILENAME = 1;

    [NativeTypeName("#define PROFILE_MEMBUFFER 2")]
    public const int PROFILE_MEMBUFFER = 2;

    [NativeTypeName("#define PROFILE_READ 1")]
    public const int PROFILE_READ = 1;

    [NativeTypeName("#define PROFILE_READWRITE 2")]
    public const int PROFILE_READWRITE = 2;

    [NativeTypeName("#define INDEX_DONT_CARE 0")]
    public const int INDEX_DONT_CARE = 0;

    [NativeTypeName("#define CMM_FROM_PROFILE INDEX_DONT_CARE")]
    public const int CMM_FROM_PROFILE = 0;

    [NativeTypeName("#define CMM_WINDOWS_DEFAULT 'Win '")]
    public const int CMM_WINDOWS_DEFAULT = 0x57696E20;

    [NativeTypeName("#define ET_DEVICENAME 0x00000001")]
    public const int ET_DEVICENAME = 0x00000001;

    [NativeTypeName("#define ET_MEDIATYPE 0x00000002")]
    public const int ET_MEDIATYPE = 0x00000002;

    [NativeTypeName("#define ET_DITHERMODE 0x00000004")]
    public const int ET_DITHERMODE = 0x00000004;

    [NativeTypeName("#define ET_RESOLUTION 0x00000008")]
    public const int ET_RESOLUTION = 0x00000008;

    [NativeTypeName("#define ET_CMMTYPE 0x00000010")]
    public const int ET_CMMTYPE = 0x00000010;

    [NativeTypeName("#define ET_CLASS 0x00000020")]
    public const int ET_CLASS = 0x00000020;

    [NativeTypeName("#define ET_DATACOLORSPACE 0x00000040")]
    public const int ET_DATACOLORSPACE = 0x00000040;

    [NativeTypeName("#define ET_CONNECTIONSPACE 0x00000080")]
    public const int ET_CONNECTIONSPACE = 0x00000080;

    [NativeTypeName("#define ET_SIGNATURE 0x00000100")]
    public const int ET_SIGNATURE = 0x00000100;

    [NativeTypeName("#define ET_PLATFORM 0x00000200")]
    public const int ET_PLATFORM = 0x00000200;

    [NativeTypeName("#define ET_PROFILEFLAGS 0x00000400")]
    public const int ET_PROFILEFLAGS = 0x00000400;

    [NativeTypeName("#define ET_MANUFACTURER 0x00000800")]
    public const int ET_MANUFACTURER = 0x00000800;

    [NativeTypeName("#define ET_MODEL 0x00001000")]
    public const int ET_MODEL = 0x00001000;

    [NativeTypeName("#define ET_ATTRIBUTES 0x00002000")]
    public const int ET_ATTRIBUTES = 0x00002000;

    [NativeTypeName("#define ET_RENDERINGINTENT 0x00004000")]
    public const int ET_RENDERINGINTENT = 0x00004000;

    [NativeTypeName("#define ET_CREATOR 0x00008000")]
    public const int ET_CREATOR = 0x00008000;

    [NativeTypeName("#define ET_DEVICECLASS 0x00010000")]
    public const int ET_DEVICECLASS = 0x00010000;

    [NativeTypeName("#define ET_STANDARDDISPLAYCOLOR 0x00020000")]
    public const int ET_STANDARDDISPLAYCOLOR = 0x00020000;

    [NativeTypeName("#define ET_EXTENDEDDISPLAYCOLOR 0x00040000")]
    public const int ET_EXTENDEDDISPLAYCOLOR = 0x00040000;

    [NativeTypeName("#define PROOF_MODE 0x00000001")]
    public const int PROOF_MODE = 0x00000001;

    [NativeTypeName("#define NORMAL_MODE 0x00000002")]
    public const int NORMAL_MODE = 0x00000002;

    [NativeTypeName("#define BEST_MODE 0x00000003")]
    public const int BEST_MODE = 0x00000003;

    [NativeTypeName("#define USE_RELATIVE_COLORIMETRIC 0x00020000")]
    public const int USE_RELATIVE_COLORIMETRIC = 0x00020000;

    [NativeTypeName("#define PRESERVEBLACK 0x00100000")]
    public const int PRESERVEBLACK = 0x00100000;

    [NativeTypeName("#define WCS_ALWAYS 0x00200000")]
    public const int WCS_ALWAYS = 0x00200000;

    [NativeTypeName("#define SEQUENTIAL_TRANSFORM 0x80800000")]
    public const uint SEQUENTIAL_TRANSFORM = 0x80800000;

    [NativeTypeName("#define RESERVED 0x80000000")]
    public const uint RESERVED = 0x80000000;

    [NativeTypeName("#define CSA_A 1")]
    public const int CSA_A = 1;

    [NativeTypeName("#define CSA_ABC 2")]
    public const int CSA_ABC = 2;

    [NativeTypeName("#define CSA_DEF 3")]
    public const int CSA_DEF = 3;

    [NativeTypeName("#define CSA_DEFG 4")]
    public const int CSA_DEFG = 4;

    [NativeTypeName("#define CSA_GRAY 5")]
    public const int CSA_GRAY = 5;

    [NativeTypeName("#define CSA_RGB 6")]
    public const int CSA_RGB = 6;

    [NativeTypeName("#define CSA_CMYK 7")]
    public const int CSA_CMYK = 7;

    [NativeTypeName("#define CSA_Lab 8")]
    public const int CSA_Lab = 8;

    [NativeTypeName("#define CMM_WIN_VERSION 0")]
    public const int CMM_WIN_VERSION = 0;

    [NativeTypeName("#define CMM_IDENT 1")]
    public const int CMM_IDENT = 1;

    [NativeTypeName("#define CMM_DRIVER_VERSION 2")]
    public const int CMM_DRIVER_VERSION = 2;

    [NativeTypeName("#define CMM_DLL_VERSION 3")]
    public const int CMM_DLL_VERSION = 3;

    [NativeTypeName("#define CMM_VERSION 4")]
    public const int CMM_VERSION = 4;

    [NativeTypeName("#define CMM_DESCRIPTION 5")]
    public const int CMM_DESCRIPTION = 5;

    [NativeTypeName("#define CMM_LOGOICON 6")]
    public const int CMM_LOGOICON = 6;

    [NativeTypeName("#define CMS_FORWARD 0")]
    public const int CMS_FORWARD = 0;

    [NativeTypeName("#define CMS_BACKWARD 1")]
    public const int CMS_BACKWARD = 1;

    [NativeTypeName("#define CMS_DISABLEICM 1")]
    public const int CMS_DISABLEICM = 1;

    [NativeTypeName("#define CMS_ENABLEPROOFING 2")]
    public const int CMS_ENABLEPROOFING = 2;

    [NativeTypeName("#define CMS_SETRENDERINTENT 4")]
    public const int CMS_SETRENDERINTENT = 4;

    [NativeTypeName("#define CMS_SETPROOFINTENT 8")]
    public const int CMS_SETPROOFINTENT = 8;

    [NativeTypeName("#define CMS_SETMONITORPROFILE 0x10")]
    public const int CMS_SETMONITORPROFILE = 0x10;

    [NativeTypeName("#define CMS_SETPRINTERPROFILE 0x20")]
    public const int CMS_SETPRINTERPROFILE = 0x20;

    [NativeTypeName("#define CMS_SETTARGETPROFILE 0x40")]
    public const int CMS_SETTARGETPROFILE = 0x40;

    [NativeTypeName("#define CMS_USEHOOK 0x80")]
    public const int CMS_USEHOOK = 0x80;

    [NativeTypeName("#define CMS_USEAPPLYCALLBACK 0x100")]
    public const int CMS_USEAPPLYCALLBACK = 0x100;

    [NativeTypeName("#define CMS_USEDESCRIPTION 0x200")]
    public const int CMS_USEDESCRIPTION = 0x200;

    [NativeTypeName("#define CMS_DISABLEINTENT 0x400")]
    public const int CMS_DISABLEINTENT = 0x400;

    [NativeTypeName("#define CMS_DISABLERENDERINTENT 0x800")]
    public const int CMS_DISABLERENDERINTENT = 0x800;

    [NativeTypeName("#define CMS_MONITOROVERFLOW 0x80000000L")]
    public const uint CMS_MONITOROVERFLOW = 0x80000000;

    [NativeTypeName("#define CMS_PRINTEROVERFLOW 0x40000000L")]
    public const int CMS_PRINTEROVERFLOW = 0x40000000;

    [NativeTypeName("#define CMS_TARGETOVERFLOW 0x20000000L")]
    public const int CMS_TARGETOVERFLOW = 0x20000000;

    [NativeTypeName("#define InstallColorProfile InstallColorProfileW")]
    public static delegate*<char*, char*, BOOL> InstallColorProfile => &InstallColorProfileW;

    [NativeTypeName("#define CreateColorTransform CreateColorTransformW")]
    public static delegate*<LOGCOLORSPACEW*, HPROFILE, HPROFILE, uint, HTRANSFORM> CreateColorTransform => &CreateColorTransformW;

    [NativeTypeName("#define OpenColorProfile OpenColorProfileW")]
    public static delegate*<PROFILE*, uint, uint, uint, HPROFILE> OpenColorProfile => &OpenColorProfileW;

    [NativeTypeName("#define CreateProfileFromLogColorSpace CreateProfileFromLogColorSpaceW")]
    public static delegate*<LOGCOLORSPACEW*, byte**, BOOL> CreateProfileFromLogColorSpace => &CreateProfileFromLogColorSpaceW;

    [NativeTypeName("#define RegisterCMM RegisterCMMW")]
    public static delegate*<char*, uint, char*, BOOL> RegisterCMM => &RegisterCMMW;

    [NativeTypeName("#define UnregisterCMM UnregisterCMMW")]
    public static delegate*<char*, uint, BOOL> UnregisterCMM => &UnregisterCMMW;

    [NativeTypeName("#define GetColorDirectory GetColorDirectoryW")]
    [Obsolete("GetColorDirectory is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public static delegate*<char*, char*, uint*, BOOL> GetColorDirectory => &GetColorDirectoryW;

    [NativeTypeName("#define UninstallColorProfile UninstallColorProfileW")]
    public static delegate*<char*, char*, BOOL, BOOL> UninstallColorProfile => &UninstallColorProfileW;

    [NativeTypeName("#define AssociateColorProfileWithDevice AssociateColorProfileWithDeviceW")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static delegate*<char*, char*, char*, BOOL> AssociateColorProfileWithDevice => &AssociateColorProfileWithDeviceW;

    [NativeTypeName("#define DisassociateColorProfileFromDevice DisassociateColorProfileFromDeviceW")]
    public static delegate*<char*, char*, char*, BOOL> DisassociateColorProfileFromDevice => &DisassociateColorProfileFromDeviceW;

    [NativeTypeName("#define EnumColorProfiles EnumColorProfilesW")]
    public static delegate*<char*, ENUMTYPEW*, byte*, uint*, uint*, BOOL> EnumColorProfiles => &EnumColorProfilesW;

    [NativeTypeName("#define SetStandardColorSpaceProfile SetStandardColorSpaceProfileW")]
    public static delegate*<char*, uint, char*, BOOL> SetStandardColorSpaceProfile => &SetStandardColorSpaceProfileW;

    [NativeTypeName("#define GetStandardColorSpaceProfile GetStandardColorSpaceProfileW")]
    public static delegate*<char*, uint, char*, uint*, BOOL> GetStandardColorSpaceProfile => &GetStandardColorSpaceProfileW;

    [NativeTypeName("#define SetupColorMatching SetupColorMatchingW")]
    public static delegate*<COLORMATCHSETUPW*, BOOL> SetupColorMatching => &SetupColorMatchingW;

    [NativeTypeName("#define WcsOpenColorProfile WcsOpenColorProfileW")]
    public static delegate*<PROFILE*, PROFILE*, PROFILE*, uint, uint, uint, uint, HPROFILE> WcsOpenColorProfile => &WcsOpenColorProfileW;

    [NativeTypeName("#define DONT_USE_EMBEDDED_WCS_PROFILES 0x00000001L")]
    public const int DONT_USE_EMBEDDED_WCS_PROFILES = 0x00000001;

    [NativeTypeName("#define WCS_DEFAULT 0x00000000L")]
    public const int WCS_DEFAULT = 0x00000000;

    [NativeTypeName("#define WCS_ICCONLY 0x00010000L")]
    public const int WCS_ICCONLY = 0x00010000;

    [NativeTypeName("#define WCS_EMBEDDED_TAG_SIGNATURE 'MS00'")]
    public const int WCS_EMBEDDED_TAG_SIGNATURE = 0x4D533030;

    [NativeTypeName("#define WCS_EMBEDDED_TAG_TYPE_SIGNATURE 'MS10'")]
    public const int WCS_EMBEDDED_TAG_TYPE_SIGNATURE = 0x4D533130;
}
