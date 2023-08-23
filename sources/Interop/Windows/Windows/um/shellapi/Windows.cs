// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CommandLineToArgvW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPWSTR *")]
    public static extern char** CommandLineToArgvW([NativeTypeName("LPCWSTR")] char* lpCmdLine, int* pNumArgs);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DragQueryFileA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint DragQueryFileA(HDROP hDrop, uint iFile, [NativeTypeName("LPSTR")] sbyte* lpszFile, uint cch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DragQueryFileW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint DragQueryFileW(HDROP hDrop, uint iFile, [NativeTypeName("LPWSTR")] char* lpszFile, uint cch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DragQueryPoint"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL DragQueryPoint(HDROP hDrop, POINT* ppt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DragFinish"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void DragFinish(HDROP hDrop);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DragAcceptFiles"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void DragAcceptFiles(HWND hWnd, BOOL fAccept);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellExecuteA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINSTANCE ShellExecuteA(HWND hwnd, [NativeTypeName("LPCSTR")] sbyte* lpOperation, [NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("LPCSTR")] sbyte* lpParameters, [NativeTypeName("LPCSTR")] sbyte* lpDirectory, int nShowCmd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellExecuteW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINSTANCE ShellExecuteW(HWND hwnd, [NativeTypeName("LPCWSTR")] char* lpOperation, [NativeTypeName("LPCWSTR")] char* lpFile, [NativeTypeName("LPCWSTR")] char* lpParameters, [NativeTypeName("LPCWSTR")] char* lpDirectory, int nShowCmd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindExecutableA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HINSTANCE FindExecutableA([NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("LPCSTR")] sbyte* lpDirectory, [NativeTypeName("LPSTR")] sbyte* lpResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindExecutableW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HINSTANCE FindExecutableW([NativeTypeName("LPCWSTR")] char* lpFile, [NativeTypeName("LPCWSTR")] char* lpDirectory, [NativeTypeName("LPWSTR")] char* lpResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellAboutA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int ShellAboutA(HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* szApp, [NativeTypeName("LPCSTR")] sbyte* szOtherStuff, HICON hIcon);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellAboutW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern int ShellAboutW(HWND hWnd, [NativeTypeName("LPCWSTR")] char* szApp, [NativeTypeName("LPCWSTR")] char* szOtherStuff, HICON hIcon);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DuplicateIcon"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON DuplicateIcon(HINSTANCE hInst, HICON hIcon);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtractAssociatedIconA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractAssociatedIconA(HINSTANCE hInst, [NativeTypeName("LPSTR")] sbyte* pszIconPath, [NativeTypeName("WORD *")] ushort* piIcon);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtractAssociatedIconW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractAssociatedIconW(HINSTANCE hInst, [NativeTypeName("LPWSTR")] char* pszIconPath, [NativeTypeName("WORD *")] ushort* piIcon);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtractAssociatedIconExA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractAssociatedIconExA(HINSTANCE hInst, [NativeTypeName("LPSTR")] sbyte* pszIconPath, [NativeTypeName("WORD *")] ushort* piIconIndex, [NativeTypeName("WORD *")] ushort* piIconId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtractAssociatedIconExW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractAssociatedIconExW(HINSTANCE hInst, [NativeTypeName("LPWSTR")] char* pszIconPath, [NativeTypeName("WORD *")] ushort* piIconIndex, [NativeTypeName("WORD *")] ushort* piIconId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtractIconA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractIconA(HINSTANCE hInst, [NativeTypeName("LPCSTR")] sbyte* pszExeFileName, uint nIconIndex);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtractIconW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HICON ExtractIconW(HINSTANCE hInst, [NativeTypeName("LPCWSTR")] char* pszExeFileName, uint nIconIndex);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAppBarMessage"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("UINT_PTR")]
    public static extern nuint SHAppBarMessage([NativeTypeName("DWORD")] uint dwMessage, [NativeTypeName("PAPPBARDATA")] void* pData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DoEnvironmentSubstA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DoEnvironmentSubstA([NativeTypeName("LPSTR")] sbyte* pszSrc, uint cchSrc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DoEnvironmentSubstW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DoEnvironmentSubstW([NativeTypeName("LPWSTR")] char* pszSrc, uint cchSrc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtractIconExA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint ExtractIconExA([NativeTypeName("LPCSTR")] sbyte* lpszFile, int nIconIndex, HICON* phiconLarge, HICON* phiconSmall, uint nIcons);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtractIconExW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern uint ExtractIconExW([NativeTypeName("LPCWSTR")] char* lpszFile, int nIconIndex, HICON* phiconLarge, HICON* phiconSmall, uint nIcons);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFileOperationA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int SHFileOperationA([NativeTypeName("LPSHFILEOPSTRUCTA")] void* lpFileOp);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFileOperationW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int SHFileOperationW([NativeTypeName("LPSHFILEOPSTRUCTW")] void* lpFileOp);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFreeNameMappings"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHFreeNameMappings(HANDLE hNameMappings);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellExecuteExA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShellExecuteExA([NativeTypeName("SHELLEXECUTEINFOA*")] void* pExecInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellExecuteExW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ShellExecuteExW([NativeTypeName("SHELLEXECUTEINFOW*")] void* pExecInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateProcessAsUserW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SHCreateProcessAsUserW([NativeTypeName("PSHCREATEPROCESSINFOW")] void* pscpi);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEvaluateSystemCommandTemplate"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHEvaluateSystemCommandTemplate([NativeTypeName("PCWSTR")] char* pszCmdTemplate, [NativeTypeName("PWSTR *")] char** ppszApplication, [NativeTypeName("PWSTR *")] char** ppszCommandLine, [NativeTypeName("PWSTR *")] char** ppszParameters);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocCreateForClasses"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT AssocCreateForClasses([NativeTypeName("const ASSOCIATIONELEMENT *")] void* rgClasses, [NativeTypeName("ULONG")] uint cClasses, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryRecycleBinA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHQueryRecycleBinA([NativeTypeName("LPCSTR")] sbyte* pszRootPath, [NativeTypeName("LPSHQUERYRBINFO")] void* pSHQueryRBInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryRecycleBinW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHQueryRecycleBinW([NativeTypeName("LPCWSTR")] char* pszRootPath, [NativeTypeName("LPSHQUERYRBINFO")] void* pSHQueryRBInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEmptyRecycleBinA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHEmptyRecycleBinA(HWND hwnd, [NativeTypeName("LPCSTR")] sbyte* pszRootPath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEmptyRecycleBinW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHEmptyRecycleBinW(HWND hwnd, [NativeTypeName("LPCWSTR")] char* pszRootPath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryUserNotificationState"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHQueryUserNotificationState(QUERY_USER_NOTIFICATION_STATE* pquns);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetPropertyStoreForWindow"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetPropertyStoreForWindow(HWND hwnd, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Shell_NotifyIconA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL Shell_NotifyIconA([NativeTypeName("DWORD")] uint dwMessage, [NativeTypeName("PNOTIFYICONDATAA")] void* lpData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Shell_NotifyIconW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL Shell_NotifyIconW([NativeTypeName("DWORD")] uint dwMessage, [NativeTypeName("PNOTIFYICONDATAW")] void* lpData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Shell_NotifyIconGetRect"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT Shell_NotifyIconGetRect([NativeTypeName("const NOTIFYICONIDENTIFIER *")] void* identifier, RECT* iconLocation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetFileInfoA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD_PTR")]
    public static extern nuint SHGetFileInfoA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("SHFILEINFOA*")] void* psfi, uint cbFileInfo, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetFileInfoW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD_PTR")]
    public static extern nuint SHGetFileInfoW([NativeTypeName("LPCWSTR")] char* pszPath, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("SHFILEINFOW*")] void* psfi, uint cbFileInfo, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetStockIconInfo"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetStockIconInfo(SHSTOCKICONID siid, uint uFlags, [NativeTypeName("SHSTOCKICONINFO*")] void* psii);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetDiskFreeSpaceExA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetDiskFreeSpaceExA([NativeTypeName("LPCSTR")] sbyte* pszDirectoryName, ULARGE_INTEGER* pulFreeBytesAvailableToCaller, ULARGE_INTEGER* pulTotalNumberOfBytes, ULARGE_INTEGER* pulTotalNumberOfFreeBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetDiskFreeSpaceExW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetDiskFreeSpaceExW([NativeTypeName("LPCWSTR")] char* pszDirectoryName, ULARGE_INTEGER* pulFreeBytesAvailableToCaller, ULARGE_INTEGER* pulTotalNumberOfBytes, ULARGE_INTEGER* pulTotalNumberOfFreeBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetNewLinkInfoA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetNewLinkInfoA([NativeTypeName("LPCSTR")] sbyte* pszLinkTo, [NativeTypeName("LPCSTR")] sbyte* pszDir, [NativeTypeName("LPSTR")] sbyte* pszName, BOOL* pfMustCopy, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetNewLinkInfoW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHGetNewLinkInfoW([NativeTypeName("LPCWSTR")] char* pszLinkTo, [NativeTypeName("LPCWSTR")] char* pszDir, [NativeTypeName("LPWSTR")] char* pszName, BOOL* pfMustCopy, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHInvokePrinterCommandA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHInvokePrinterCommandA(HWND hwnd, uint uAction, [NativeTypeName("LPCSTR")] sbyte* lpBuf1, [NativeTypeName("LPCSTR")] sbyte* lpBuf2, BOOL fModal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHInvokePrinterCommandW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHInvokePrinterCommandW(HWND hwnd, uint uAction, [NativeTypeName("LPCWSTR")] char* lpBuf1, [NativeTypeName("LPCWSTR")] char* lpBuf2, BOOL fModal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHLoadNonloadedIconOverlayIdentifiers"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHLoadNonloadedIconOverlayIdentifiers();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHIsFileAvailableOffline"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHIsFileAvailableOffline([NativeTypeName("PCWSTR")] char* pwszPath, [NativeTypeName("DWORD *")] uint* pdwStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetLocalizedName"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetLocalizedName([NativeTypeName("PCWSTR")] char* pszPath, [NativeTypeName("PCWSTR")] char* pszResModule, int idsRes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRemoveLocalizedName"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHRemoveLocalizedName([NativeTypeName("PCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetLocalizedName"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetLocalizedName([NativeTypeName("PCWSTR")] char* pszPath, [NativeTypeName("PWSTR")] char* pszResModule, uint cch, int* pidsRes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellMessageBoxA"]/*' />
    [DllImport("shlwapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int ShellMessageBoxA(HINSTANCE hAppInst, HWND hWnd, [NativeTypeName("LPCSTR")] sbyte* lpcText, [NativeTypeName("LPCSTR")] sbyte* lpcTitle, uint fuStyle, __arglist);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellMessageBoxW"]/*' />
    [DllImport("shlwapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int ShellMessageBoxW(HINSTANCE hAppInst, HWND hWnd, [NativeTypeName("LPCWSTR")] char* lpcText, [NativeTypeName("LPCWSTR")] char* lpcTitle, uint fuStyle, __arglist);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsLFNDriveA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL IsLFNDriveA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsLFNDriveW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL IsLFNDriveW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEnumerateUnreadMailAccountsW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHEnumerateUnreadMailAccountsW(HKEY hKeyUser, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] char* pszMailAddress, int cchMailAddress);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetUnreadMailCountW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetUnreadMailCountW(HKEY hKeyUser, [NativeTypeName("LPCWSTR")] char* pszMailAddress, [NativeTypeName("DWORD *")] uint* pdwCount, FILETIME* pFileTime, [NativeTypeName("LPWSTR")] char* pszShellExecuteCommand, int cchShellExecuteCommand);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetUnreadMailCountW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetUnreadMailCountW([NativeTypeName("LPCWSTR")] char* pszMailAddress, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("LPCWSTR")] char* pszShellExecuteCommand);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHTestTokenMembership"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHTestTokenMembership(HANDLE hToken, [NativeTypeName("ULONG")] uint ulRID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetImageList"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetImageList(int iImageList, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitNetworkAddressControl"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL InitNetworkAddressControl();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetDriveMedia"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetDriveMedia([NativeTypeName("PCWSTR")] char* pszDrive, [NativeTypeName("DWORD *")] uint* pdwMediaContent);

    [NativeTypeName("#define DragQueryFile DragQueryFileW")]
    public static delegate*<HDROP, uint, char*, uint, uint> DragQueryFile => &DragQueryFileW;

    [NativeTypeName("#define ShellExecute ShellExecuteW")]
    public static delegate*<HWND, char*, char*, char*, char*, int, HINSTANCE> ShellExecute => &ShellExecuteW;

    [NativeTypeName("#define FindExecutable FindExecutableW")]
    public static delegate*<char*, char*, char*, HINSTANCE> FindExecutable => &FindExecutableW;

    [NativeTypeName("#define ShellAbout ShellAboutW")]
    public static delegate*<HWND, char*, char*, HICON, int> ShellAbout => &ShellAboutW;

    [NativeTypeName("#define ExtractAssociatedIcon ExtractAssociatedIconW")]
    public static delegate*<HINSTANCE, char*, ushort*, HICON> ExtractAssociatedIcon => &ExtractAssociatedIconW;

    [NativeTypeName("#define ExtractAssociatedIconEx ExtractAssociatedIconExW")]
    public static delegate*<HINSTANCE, char*, ushort*, ushort*, HICON> ExtractAssociatedIconEx => &ExtractAssociatedIconExW;

    [NativeTypeName("#define ExtractIcon ExtractIconW")]
    public static delegate*<HINSTANCE, char*, uint, HICON> ExtractIcon => &ExtractIconW;

    [NativeTypeName("#define ABN_STATECHANGE 0x0000000")]
    public const int ABN_STATECHANGE = 0x0000000;

    [NativeTypeName("#define ABN_POSCHANGED 0x0000001")]
    public const int ABN_POSCHANGED = 0x0000001;

    [NativeTypeName("#define ABN_FULLSCREENAPP 0x0000002")]
    public const int ABN_FULLSCREENAPP = 0x0000002;

    [NativeTypeName("#define ABN_WINDOWARRANGE 0x0000003")]
    public const int ABN_WINDOWARRANGE = 0x0000003;

    [NativeTypeName("#define ABS_AUTOHIDE 0x0000001")]
    public const int ABS_AUTOHIDE = 0x0000001;

    [NativeTypeName("#define ABS_ALWAYSONTOP 0x0000002")]
    public const int ABS_ALWAYSONTOP = 0x0000002;

    [NativeTypeName("#define ABE_LEFT 0")]
    public const int ABE_LEFT = 0;

    [NativeTypeName("#define ABE_TOP 1")]
    public const int ABE_TOP = 1;

    [NativeTypeName("#define ABE_RIGHT 2")]
    public const int ABE_RIGHT = 2;

    [NativeTypeName("#define ABE_BOTTOM 3")]
    public const int ABE_BOTTOM = 3;

    [NativeTypeName("#define DoEnvironmentSubst DoEnvironmentSubstW")]
    public static delegate*<char*, uint, uint> DoEnvironmentSubst => &DoEnvironmentSubstW;

    [NativeTypeName("#define ExtractIconEx ExtractIconExW")]
    public static delegate*<char*, int, HICON*, HICON*, uint, uint> ExtractIconEx => &ExtractIconExW;

    [NativeTypeName("#define FO_MOVE 0x0001")]
    public const int FO_MOVE = 0x0001;

    [NativeTypeName("#define FO_COPY 0x0002")]
    public const int FO_COPY = 0x0002;

    [NativeTypeName("#define FO_DELETE 0x0003")]
    public const int FO_DELETE = 0x0003;

    [NativeTypeName("#define FO_RENAME 0x0004")]
    public const int FO_RENAME = 0x0004;

    [NativeTypeName("#define PO_DELETE 0x0013")]
    public const int PO_DELETE = 0x0013;

    [NativeTypeName("#define PO_RENAME 0x0014")]
    public const int PO_RENAME = 0x0014;

    [NativeTypeName("#define PO_PORTCHANGE 0x0020")]
    public const int PO_PORTCHANGE = 0x0020;

    [NativeTypeName("#define PO_REN_PORT 0x0034")]
    public const int PO_REN_PORT = 0x0034;

    [NativeTypeName("#define SHFileOperation SHFileOperationW")]
    public static delegate*<void*, int> SHFileOperation => &SHFileOperationW;

    [NativeTypeName("#define ShellExecuteEx ShellExecuteExW")]
    public static delegate*<void*, BOOL> ShellExecuteEx => &ShellExecuteExW;

    [NativeTypeName("#define SHERB_NOCONFIRMATION 0x00000001")]
    public const int SHERB_NOCONFIRMATION = 0x00000001;

    [NativeTypeName("#define SHERB_NOPROGRESSUI 0x00000002")]
    public const int SHERB_NOPROGRESSUI = 0x00000002;

    [NativeTypeName("#define SHERB_NOSOUND 0x00000004")]
    public const int SHERB_NOSOUND = 0x00000004;

    [NativeTypeName("#define SHQueryRecycleBin SHQueryRecycleBinW")]
    public static delegate*<char*, void*, HRESULT> SHQueryRecycleBin => &SHQueryRecycleBinW;

    [NativeTypeName("#define SHEmptyRecycleBin SHEmptyRecycleBinW")]
    public static delegate*<HWND, char*, uint, HRESULT> SHEmptyRecycleBin => &SHEmptyRecycleBinW;

    [NativeTypeName("#define NIN_SELECT (WM_USER + 0)")]
    public const int NIN_SELECT = (0x0400 + 0);

    [NativeTypeName("#define NINF_KEY 0x1")]
    public const int NINF_KEY = 0x1;

    [NativeTypeName("#define NIN_KEYSELECT (NIN_SELECT | NINF_KEY)")]
    public const int NIN_KEYSELECT = ((0x0400 + 0) | 0x1);

    [NativeTypeName("#define NIN_BALLOONSHOW (WM_USER + 2)")]
    public const int NIN_BALLOONSHOW = (0x0400 + 2);

    [NativeTypeName("#define NIN_BALLOONHIDE (WM_USER + 3)")]
    public const int NIN_BALLOONHIDE = (0x0400 + 3);

    [NativeTypeName("#define NIN_BALLOONTIMEOUT (WM_USER + 4)")]
    public const int NIN_BALLOONTIMEOUT = (0x0400 + 4);

    [NativeTypeName("#define NIN_BALLOONUSERCLICK (WM_USER + 5)")]
    public const int NIN_BALLOONUSERCLICK = (0x0400 + 5);

    [NativeTypeName("#define NIN_POPUPOPEN (WM_USER + 6)")]
    public const int NIN_POPUPOPEN = (0x0400 + 6);

    [NativeTypeName("#define NIN_POPUPCLOSE (WM_USER + 7)")]
    public const int NIN_POPUPCLOSE = (0x0400 + 7);

    [NativeTypeName("#define NIM_ADD 0x00000000")]
    public const int NIM_ADD = 0x00000000;

    [NativeTypeName("#define NIM_MODIFY 0x00000001")]
    public const int NIM_MODIFY = 0x00000001;

    [NativeTypeName("#define NIM_DELETE 0x00000002")]
    public const int NIM_DELETE = 0x00000002;

    [NativeTypeName("#define NIM_SETFOCUS 0x00000003")]
    public const int NIM_SETFOCUS = 0x00000003;

    [NativeTypeName("#define NIM_SETVERSION 0x00000004")]
    public const int NIM_SETVERSION = 0x00000004;

    [NativeTypeName("#define NOTIFYICON_VERSION 3")]
    public const int NOTIFYICON_VERSION = 3;

    [NativeTypeName("#define NOTIFYICON_VERSION_4 4")]
    public const int NOTIFYICON_VERSION_4 = 4;

    [NativeTypeName("#define NIF_MESSAGE 0x00000001")]
    public const int NIF_MESSAGE = 0x00000001;

    [NativeTypeName("#define NIF_ICON 0x00000002")]
    public const int NIF_ICON = 0x00000002;

    [NativeTypeName("#define NIF_TIP 0x00000004")]
    public const int NIF_TIP = 0x00000004;

    [NativeTypeName("#define NIF_STATE 0x00000008")]
    public const int NIF_STATE = 0x00000008;

    [NativeTypeName("#define NIF_INFO 0x00000010")]
    public const int NIF_INFO = 0x00000010;

    [NativeTypeName("#define NIF_GUID 0x00000020")]
    public const int NIF_GUID = 0x00000020;

    [NativeTypeName("#define NIF_REALTIME 0x00000040")]
    public const int NIF_REALTIME = 0x00000040;

    [NativeTypeName("#define NIF_SHOWTIP 0x00000080")]
    public const int NIF_SHOWTIP = 0x00000080;

    [NativeTypeName("#define NIS_HIDDEN 0x00000001")]
    public const int NIS_HIDDEN = 0x00000001;

    [NativeTypeName("#define NIS_SHAREDICON 0x00000002")]
    public const int NIS_SHAREDICON = 0x00000002;

    [NativeTypeName("#define Shell_NotifyIcon Shell_NotifyIconW")]
    public static delegate*<uint, void*, BOOL> Shell_NotifyIcon => &Shell_NotifyIconW;

    [NativeTypeName("#define SHGetFileInfo SHGetFileInfoW")]
    public static delegate*<char*, uint, void*, uint, uint, nuint> SHGetFileInfo => &SHGetFileInfoW;

    [NativeTypeName("#define SIID_INVALID ((SHSTOCKICONID)-1)")]
    public const SHSTOCKICONID SIID_INVALID = ((SHSTOCKICONID)(-1));

    [NativeTypeName("#define SHGetDiskFreeSpace SHGetDiskFreeSpaceEx")]
    public static delegate*<char*, ULARGE_INTEGER*, ULARGE_INTEGER*, ULARGE_INTEGER*, BOOL> SHGetDiskFreeSpace => &SHGetDiskFreeSpaceExW;

    [NativeTypeName("#define SHGetDiskFreeSpaceEx SHGetDiskFreeSpaceExW")]
    public static delegate*<char*, ULARGE_INTEGER*, ULARGE_INTEGER*, ULARGE_INTEGER*, BOOL> SHGetDiskFreeSpaceEx => &SHGetDiskFreeSpaceExW;

    [NativeTypeName("#define SHGetNewLinkInfo SHGetNewLinkInfoW")]
    public static delegate*<char*, char*, char*, BOOL*, uint, BOOL> SHGetNewLinkInfo => &SHGetNewLinkInfoW;

    [NativeTypeName("#define SHGNLI_PIDL 0x000000001")]
    public const int SHGNLI_PIDL = 0x000000001;

    [NativeTypeName("#define SHGNLI_PREFIXNAME 0x000000002")]
    public const int SHGNLI_PREFIXNAME = 0x000000002;

    [NativeTypeName("#define SHGNLI_NOUNIQUE 0x000000004")]
    public const int SHGNLI_NOUNIQUE = 0x000000004;

    [NativeTypeName("#define SHGNLI_NOLNK 0x000000008")]
    public const int SHGNLI_NOLNK = 0x000000008;

    [NativeTypeName("#define SHGNLI_NOLOCNAME 0x000000010")]
    public const int SHGNLI_NOLOCNAME = 0x000000010;

    [NativeTypeName("#define SHGNLI_USEURLEXT 0x000000020")]
    public const int SHGNLI_USEURLEXT = 0x000000020;

    [NativeTypeName("#define PRINTACTION_OPEN 0")]
    public const int PRINTACTION_OPEN = 0;

    [NativeTypeName("#define PRINTACTION_PROPERTIES 1")]
    public const int PRINTACTION_PROPERTIES = 1;

    [NativeTypeName("#define PRINTACTION_NETINSTALL 2")]
    public const int PRINTACTION_NETINSTALL = 2;

    [NativeTypeName("#define PRINTACTION_NETINSTALLLINK 3")]
    public const int PRINTACTION_NETINSTALLLINK = 3;

    [NativeTypeName("#define PRINTACTION_TESTPAGE 4")]
    public const int PRINTACTION_TESTPAGE = 4;

    [NativeTypeName("#define PRINTACTION_OPENNETPRN 5")]
    public const int PRINTACTION_OPENNETPRN = 5;

    [NativeTypeName("#define PRINTACTION_DOCUMENTDEFAULTS 6")]
    public const int PRINTACTION_DOCUMENTDEFAULTS = 6;

    [NativeTypeName("#define PRINTACTION_SERVERPROPERTIES 7")]
    public const int PRINTACTION_SERVERPROPERTIES = 7;

    [NativeTypeName("#define SHInvokePrinterCommand SHInvokePrinterCommandW")]
    public static delegate*<HWND, uint, char*, char*, BOOL, BOOL> SHInvokePrinterCommand => &SHInvokePrinterCommandW;

    [NativeTypeName("#define PRINT_PROP_FORCE_NAME 0x01")]
    public const int PRINT_PROP_FORCE_NAME = 0x01;

    [NativeTypeName("#define OFFLINE_STATUS_LOCAL 0x0001")]
    public const int OFFLINE_STATUS_LOCAL = 0x0001;

    [NativeTypeName("#define OFFLINE_STATUS_REMOTE 0x0002")]
    public const int OFFLINE_STATUS_REMOTE = 0x0002;

    [NativeTypeName("#define OFFLINE_STATUS_INCOMPLETE 0x0004")]
    public const int OFFLINE_STATUS_INCOMPLETE = 0x0004;

    [NativeTypeName("#define IsLFNDrive IsLFNDriveW")]
    public static delegate*<char*, BOOL> IsLFNDrive => &IsLFNDriveW;

    [NativeTypeName("#define SHEnumerateUnreadMailAccounts SHEnumerateUnreadMailAccountsW")]
    public static delegate*<HKEY, uint, char*, int, HRESULT> SHEnumerateUnreadMailAccounts => &SHEnumerateUnreadMailAccountsW;

    [NativeTypeName("#define SHGetUnreadMailCount SHGetUnreadMailCountW")]
    public static delegate*<HKEY, char*, uint*, FILETIME*, char*, int, HRESULT> SHGetUnreadMailCount => &SHGetUnreadMailCountW;

    [NativeTypeName("#define SHSetUnreadMailCount SHSetUnreadMailCountW")]
    public static delegate*<char*, uint, char*, HRESULT> SHSetUnreadMailCount => &SHSetUnreadMailCountW;

    [NativeTypeName("#define SHIL_LARGE 0")]
    public const int SHIL_LARGE = 0;

    [NativeTypeName("#define SHIL_SMALL 1")]
    public const int SHIL_SMALL = 1;

    [NativeTypeName("#define SHIL_EXTRALARGE 2")]
    public const int SHIL_EXTRALARGE = 2;

    [NativeTypeName("#define SHIL_SYSSMALL 3")]
    public const int SHIL_SYSSMALL = 3;

    [NativeTypeName("#define SHIL_JUMBO 4")]
    public const int SHIL_JUMBO = 4;

    [NativeTypeName("#define SHIL_LAST SHIL_JUMBO")]
    public const int SHIL_LAST = 4;

    [NativeTypeName("#define NCM_GETADDRESS (WM_USER+1)")]
    public const int NCM_GETADDRESS = (0x0400 + 1);

    [NativeTypeName("#define NCM_SETALLOWTYPE (WM_USER+2)")]
    public const int NCM_SETALLOWTYPE = (0x0400 + 2);

    [NativeTypeName("#define NCM_GETALLOWTYPE (WM_USER+3)")]
    public const int NCM_GETALLOWTYPE = (0x0400 + 3);

    [NativeTypeName("#define NCM_DISPLAYERRORTIP (WM_USER+4)")]
    public const int NCM_DISPLAYERRORTIP = (0x0400 + 4);
}
