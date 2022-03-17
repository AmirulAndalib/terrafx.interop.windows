// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION"]/*' />
public enum D3D12_MEASUREMENTS_ACTION
{
    /// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION.D3D12_MEASUREMENTS_ACTION_KEEP_ALL"]/*' />
    D3D12_MEASUREMENTS_ACTION_KEEP_ALL = 0,

    /// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION.D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS"]/*' />
    D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS = (D3D12_MEASUREMENTS_ACTION_KEEP_ALL + 1),

    /// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION.D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY"]/*' />
    D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY = (D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS + 1),

    /// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION.D3D12_MEASUREMENTS_ACTION_DISCARD_PREVIOUS"]/*' />
    D3D12_MEASUREMENTS_ACTION_DISCARD_PREVIOUS = (D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY + 1),
}
