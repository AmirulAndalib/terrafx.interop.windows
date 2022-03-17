// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PROTECTED_SESSION_STATUS.xml' path='doc/member[@name="D3D12_PROTECTED_SESSION_STATUS"]/*' />
public enum D3D12_PROTECTED_SESSION_STATUS
{
    /// <include file='D3D12_PROTECTED_SESSION_STATUS.xml' path='doc/member[@name="D3D12_PROTECTED_SESSION_STATUS.D3D12_PROTECTED_SESSION_STATUS_OK"]/*' />
    D3D12_PROTECTED_SESSION_STATUS_OK = 0,

    /// <include file='D3D12_PROTECTED_SESSION_STATUS.xml' path='doc/member[@name="D3D12_PROTECTED_SESSION_STATUS.D3D12_PROTECTED_SESSION_STATUS_INVALID"]/*' />
    D3D12_PROTECTED_SESSION_STATUS_INVALID = 1,
}
