// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MF_TRANSCODE_SINK_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVideoStreamID;

        [NativeTypeName("IMFMediaType *")]
        public IMFMediaType* pVideoMediaType;

        [NativeTypeName("DWORD")]
        public uint dwAudioStreamID;

        [NativeTypeName("IMFMediaType *")]
        public IMFMediaType* pAudioMediaType;
    }
}
