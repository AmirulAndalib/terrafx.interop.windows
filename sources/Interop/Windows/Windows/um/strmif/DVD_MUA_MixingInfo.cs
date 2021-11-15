// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct DVD_MUA_MixingInfo
    {
        public BOOL fMixTo0;

        public BOOL fMixTo1;

        public BOOL fMix0InPhase;

        public BOOL fMix1InPhase;

        [NativeTypeName("DWORD")]
        public uint dwSpeakerPosition;
    }
}