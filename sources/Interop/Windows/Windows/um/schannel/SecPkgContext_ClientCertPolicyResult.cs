// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='SecPkgContext_ClientCertPolicyResult.xml' path='doc/member[@name="SecPkgContext_ClientCertPolicyResult"]/*' />
public partial struct SecPkgContext_ClientCertPolicyResult
{
    /// <include file='SecPkgContext_ClientCertPolicyResult.xml' path='doc/member[@name="SecPkgContext_ClientCertPolicyResult.dwPolicyResult"]/*' />
    public HRESULT dwPolicyResult;

    /// <include file='SecPkgContext_ClientCertPolicyResult.xml' path='doc/member[@name="SecPkgContext_ClientCertPolicyResult.guidPolicyId"]/*' />
    public Guid guidPolicyId;
}
