// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MFT_OUTPUT_DATA_BUFFER
    {
        [NativeTypeName("DWORD")]
        public uint dwStreamID;

        [NativeTypeName("IMFSample *")]
        public IMFSample* pSample;

        [NativeTypeName("DWORD")]
        public uint dwStatus;

        [NativeTypeName("IMFCollection *")]
        public IMFCollection* pEvents;
    }
}
