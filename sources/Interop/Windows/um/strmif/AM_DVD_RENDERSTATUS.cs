// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct AM_DVD_RENDERSTATUS
    {
        [NativeTypeName("HRESULT")]
        public int hrVPEStatus;

        [NativeTypeName("BOOL")]
        public int bDvdVolInvalid;

        [NativeTypeName("BOOL")]
        public int bDvdVolUnknown;

        [NativeTypeName("BOOL")]
        public int bNoLine21In;

        [NativeTypeName("BOOL")]
        public int bNoLine21Out;

        public int iNumStreams;

        public int iNumStreamsFailed;

        [NativeTypeName("DWORD")]
        public uint dwFailedStreamsFlag;
    }
}
