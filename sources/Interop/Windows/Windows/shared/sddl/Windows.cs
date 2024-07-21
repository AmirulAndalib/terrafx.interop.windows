// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/sddl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertSidToStringSidA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertSidToStringSidA([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR *")] sbyte** StringSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertSidToStringSidW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertSidToStringSidW([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR *")] char** StringSid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertStringSidToSidA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertStringSidToSidA([NativeTypeName("LPCSTR")] sbyte* StringSid, [NativeTypeName("PSID *")] void** Sid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertStringSidToSidW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertStringSidToSidW([NativeTypeName("LPCWSTR")] char* StringSid, [NativeTypeName("PSID *")] void** Sid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertStringSecurityDescriptorToSecurityDescriptorA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertStringSecurityDescriptorToSecurityDescriptorA([NativeTypeName("LPCSTR")] sbyte* StringSecurityDescriptor, [NativeTypeName("DWORD")] uint StringSDRevision, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** SecurityDescriptor, [NativeTypeName("PULONG")] uint* SecurityDescriptorSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertStringSecurityDescriptorToSecurityDescriptorW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertStringSecurityDescriptorToSecurityDescriptorW([NativeTypeName("LPCWSTR")] char* StringSecurityDescriptor, [NativeTypeName("DWORD")] uint StringSDRevision, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** SecurityDescriptor, [NativeTypeName("PULONG")] uint* SecurityDescriptorSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertSecurityDescriptorToStringSecurityDescriptorA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertSecurityDescriptorToStringSecurityDescriptorA([NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("DWORD")] uint RequestedStringSDRevision, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("LPSTR *")] sbyte** StringSecurityDescriptor, [NativeTypeName("PULONG")] uint* StringSecurityDescriptorLen);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertSecurityDescriptorToStringSecurityDescriptorW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertSecurityDescriptorToStringSecurityDescriptorW([NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("DWORD")] uint RequestedStringSDRevision, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("LPWSTR *")] char** StringSecurityDescriptor, [NativeTypeName("PULONG")] uint* StringSecurityDescriptorLen);

    [NativeTypeName("#define ConvertSidToStringSid ConvertSidToStringSidW")]
    public static delegate*<void*, char**, BOOL> ConvertSidToStringSid => &ConvertSidToStringSidW;

    [NativeTypeName("#define ConvertStringSidToSid ConvertStringSidToSidW")]
    public static delegate*<char*, void**, BOOL> ConvertStringSidToSid => &ConvertStringSidToSidW;

    [NativeTypeName("#define ConvertStringSecurityDescriptorToSecurityDescriptor ConvertStringSecurityDescriptorToSecurityDescriptorW")]
    public static delegate*<char*, uint, void**, uint*, BOOL> ConvertStringSecurityDescriptorToSecurityDescriptor => &ConvertStringSecurityDescriptorToSecurityDescriptorW;

    [NativeTypeName("#define ConvertSecurityDescriptorToStringSecurityDescriptor ConvertSecurityDescriptorToStringSecurityDescriptorW")]
    public static delegate*<void*, uint, uint, char**, uint*, BOOL> ConvertSecurityDescriptorToStringSecurityDescriptor => &ConvertSecurityDescriptorToStringSecurityDescriptorW;
}
