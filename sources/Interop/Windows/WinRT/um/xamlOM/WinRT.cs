// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InitializeXamlDiagnosticsEx"]/*' />
    [DllImport("windows.ui.xaml.dll", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern HRESULT InitializeXamlDiagnosticsEx([NativeTypeName("LPCWSTR")] ushort* endPointName, [NativeTypeName("DWORD")] uint pid, [NativeTypeName("LPCWSTR")] ushort* wszDllXamlDiagnostics, [NativeTypeName("LPCWSTR")] ushort* wszTAPDllName, [NativeTypeName("CLSID")] Guid tapClsid, [NativeTypeName("LPCWSTR")] ushort* wszInitializationData);
}
