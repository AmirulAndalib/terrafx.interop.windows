// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE"]/*' />
[Flags]
public enum D3D12_DEBUG_FEATURE
{
    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_NONE"]/*' />
    D3D12_DEBUG_FEATURE_NONE = 0,

    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_ALLOW_BEHAVIOR_CHANGING_DEBUG_AIDS"]/*' />
    D3D12_DEBUG_FEATURE_ALLOW_BEHAVIOR_CHANGING_DEBUG_AIDS = 0x1,

    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_CONSERVATIVE_RESOURCE_STATE_TRACKING"]/*' />
    D3D12_DEBUG_FEATURE_CONSERVATIVE_RESOURCE_STATE_TRACKING = 0x2,

    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_DISABLE_VIRTUALIZED_BUNDLES_VALIDATION"]/*' />
    D3D12_DEBUG_FEATURE_DISABLE_VIRTUALIZED_BUNDLES_VALIDATION = 0x4,

    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_EMULATE_WINDOWS7"]/*' />
    D3D12_DEBUG_FEATURE_EMULATE_WINDOWS7 = 0x8,
}
