// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CONFIRM_CONFLICT_ITEM
    {
        public IShellItem2* pShellItem;

        [NativeTypeName("LPWSTR")]
        public ushort* pszOriginalName;

        [NativeTypeName("LPWSTR")]
        public ushort* pszAlternateName;

        [NativeTypeName("LPWSTR")]
        public ushort* pszLocationShort;

        [NativeTypeName("LPWSTR")]
        public ushort* pszLocationFull;

        public SYNCMGR_CONFLICT_ITEM_TYPE nType;
    }
}