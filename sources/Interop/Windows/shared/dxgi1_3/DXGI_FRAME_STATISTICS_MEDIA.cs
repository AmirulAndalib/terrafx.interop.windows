// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXGI_FRAME_STATISTICS_MEDIA
    {
        public uint PresentCount;

        public uint PresentRefreshCount;

        public uint SyncRefreshCount;

        public LARGE_INTEGER SyncQPCTime;

        public LARGE_INTEGER SyncGPUTime;

        public DXGI_FRAME_PRESENTATION_MODE CompositionMode;

        public uint ApprovedPresentDuration;
    }
}
