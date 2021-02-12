// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public int iDeltaCrlIndicator;

        [NativeTypeName("LPFILETIME")]
        public FILETIME* pftCacheResync;

        [NativeTypeName("LPFILETIME")]
        public FILETIME* pLastSyncTime;

        [NativeTypeName("LPFILETIME")]
        public FILETIME* pMaxAgeTime;

        [NativeTypeName("PCERT_REVOCATION_CHAIN_PARA")]
        public CERT_REVOCATION_CHAIN_PARA* pChainPara;

        [NativeTypeName("PCRYPT_INTEGER_BLOB")]
        public CRYPTOAPI_BLOB* pDeltaCrlIndicator;
    }
}
