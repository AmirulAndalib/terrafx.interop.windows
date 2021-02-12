// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HidP_IsSameUsageAndPage(USAGE_AND_PAGE* u1, USAGE_AND_PAGE* u2) => *(uint*)u1 == *(uint*)u2;

        public static int HidP_SetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] IntPtr PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
            HidP_SetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_UnsetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] IntPtr PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
            HidP_UnsetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_GetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] IntPtr PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
            HidP_GetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

        public static int HidP_GetButtonsEx(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USHORT")] ushort LinkCollection, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* ButtonList, [NativeTypeName("ULONG *")] uint* UsageLength, [NativeTypeName("PHIDP_PREPARSED_DATA")] IntPtr PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
            HidP_GetUsagesEx(ReportType, LinkCollection, ButtonList, UsageLength, PreparsedData, Report, ReportLength);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int HIDP_ERROR_CODES(int sev, int code) => (sev << 28) | (FACILITY_HID_ERROR_CODE << 16) | code;
    }
}
