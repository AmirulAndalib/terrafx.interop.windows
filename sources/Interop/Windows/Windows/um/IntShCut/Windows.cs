// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateURLA"]/*' />
    [DllImport("url", ExactSpelling = true)]
    public static extern HRESULT TranslateURLA([NativeTypeName("PCSTR")] sbyte* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PSTR *")] sbyte** ppszTranslatedURL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateURLW"]/*' />
    [DllImport("url", ExactSpelling = true)]
    public static extern HRESULT TranslateURLW([NativeTypeName("PCWSTR")] char* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PWSTR *")] char** ppszTranslatedURL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLAssociationDialogA"]/*' />
    [DllImport("url", ExactSpelling = true)]
    public static extern HRESULT URLAssociationDialogA(HWND hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCSTR")] sbyte* pcszFile, [NativeTypeName("PCSTR")] sbyte* pcszURL, [NativeTypeName("PSTR")] sbyte* pszAppBuf, uint ucAppBufLen);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.URLAssociationDialogW"]/*' />
    [DllImport("url", ExactSpelling = true)]
    public static extern HRESULT URLAssociationDialogW(HWND hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCWSTR")] char* pcszFile, [NativeTypeName("PCWSTR")] char* pcszURL, [NativeTypeName("PWSTR")] char* pszAppBuf, uint ucAppBufLen);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MIMEAssociationDialogA"]/*' />
    [DllImport("url", ExactSpelling = true)]
    public static extern HRESULT MIMEAssociationDialogA(HWND hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCSTR")] sbyte* pcszFile, [NativeTypeName("PCSTR")] sbyte* pcszMIMEContentType, [NativeTypeName("PSTR")] sbyte* pszAppBuf, uint ucAppBufLen);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MIMEAssociationDialogW"]/*' />
    [DllImport("url", ExactSpelling = true)]
    public static extern HRESULT MIMEAssociationDialogW(HWND hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCWSTR")] char* pcszFile, [NativeTypeName("PCWSTR")] char* pcszMIMEContentType, [NativeTypeName("PWSTR")] char* pszAppBuf, uint ucAppBufLen);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InetIsOffline"]/*' />
    [DllImport("url", ExactSpelling = true)]
    public static extern BOOL InetIsOffline([NativeTypeName("DWORD")] uint dwFlags);

    [NativeTypeName("#define TranslateURL TranslateURLW")]
    public static delegate*<char*, uint, char**, HRESULT> TranslateURL => &TranslateURLW;

    [NativeTypeName("#define URLAssociationDialog URLAssociationDialogW")]
    public static delegate*<HWND, uint, char*, char*, char*, uint, HRESULT> URLAssociationDialog => &URLAssociationDialogW;

    [NativeTypeName("#define MIMEAssociationDialog MIMEAssociationDialogW")]
    public static delegate*<HWND, uint, char*, char*, char*, uint, HRESULT> MIMEAssociationDialog => &MIMEAssociationDialogW;
}
