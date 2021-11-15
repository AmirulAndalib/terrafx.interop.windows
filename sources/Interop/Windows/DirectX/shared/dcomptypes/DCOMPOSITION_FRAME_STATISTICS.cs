// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct DCOMPOSITION_FRAME_STATISTICS
    {
        public LARGE_INTEGER lastFrameTime;

        public DXGI_RATIONAL currentCompositionRate;

        public LARGE_INTEGER currentTime;

        public LARGE_INTEGER timeFrequency;

        public LARGE_INTEGER nextEstimatedFrameTime;
    }
}