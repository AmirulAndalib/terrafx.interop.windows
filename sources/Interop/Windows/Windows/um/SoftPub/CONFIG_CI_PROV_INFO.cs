// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CONFIG_CI_PROV_INFO.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO"]/*' />
public unsafe partial struct CONFIG_CI_PROV_INFO
{
    /// <include file='CONFIG_CI_PROV_INFO.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CONFIG_CI_PROV_INFO.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO.dwPolicies"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPolicies;

    /// <include file='CONFIG_CI_PROV_INFO.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO.pPolicies"]/*' />
    public CRYPT_DATA_BLOB* pPolicies;

    /// <include file='CONFIG_CI_PROV_INFO.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO.result"]/*' />
    public CONFIG_CI_PROV_INFO_RESULT result;

    /// <include file='CONFIG_CI_PROV_INFO.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO.dwScenario"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwScenario;

    /// <include file='CONFIG_CI_PROV_INFO.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO.result2"]/*' />
    public CONFIG_CI_PROV_INFO_RESULT2* result2;
}
