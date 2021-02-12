// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define MAXPNAMELEN 32")]
        public const int MAXPNAMELEN = 32;

        [NativeTypeName("#define MAXERRORLENGTH 256")]
        public const int MAXERRORLENGTH = 256;

        [NativeTypeName("#define MAX_JOYSTICKOEMVXDNAME 260")]
        public const int MAX_JOYSTICKOEMVXDNAME = 260;

        [NativeTypeName("#define TIME_MS 0x0001")]
        public const int TIME_MS = 0x0001;

        [NativeTypeName("#define TIME_SAMPLES 0x0002")]
        public const int TIME_SAMPLES = 0x0002;

        [NativeTypeName("#define TIME_BYTES 0x0004")]
        public const int TIME_BYTES = 0x0004;

        [NativeTypeName("#define TIME_SMPTE 0x0008")]
        public const int TIME_SMPTE = 0x0008;

        [NativeTypeName("#define TIME_MIDI 0x0010")]
        public const int TIME_MIDI = 0x0010;

        [NativeTypeName("#define TIME_TICKS 0x0020")]
        public const int TIME_TICKS = 0x0020;

        [NativeTypeName("#define MM_JOY1MOVE 0x3A0")]
        public const int MM_JOY1MOVE = 0x3A0;

        [NativeTypeName("#define MM_JOY2MOVE 0x3A1")]
        public const int MM_JOY2MOVE = 0x3A1;

        [NativeTypeName("#define MM_JOY1ZMOVE 0x3A2")]
        public const int MM_JOY1ZMOVE = 0x3A2;

        [NativeTypeName("#define MM_JOY2ZMOVE 0x3A3")]
        public const int MM_JOY2ZMOVE = 0x3A3;

        [NativeTypeName("#define MM_JOY1BUTTONDOWN 0x3B5")]
        public const int MM_JOY1BUTTONDOWN = 0x3B5;

        [NativeTypeName("#define MM_JOY2BUTTONDOWN 0x3B6")]
        public const int MM_JOY2BUTTONDOWN = 0x3B6;

        [NativeTypeName("#define MM_JOY1BUTTONUP 0x3B7")]
        public const int MM_JOY1BUTTONUP = 0x3B7;

        [NativeTypeName("#define MM_JOY2BUTTONUP 0x3B8")]
        public const int MM_JOY2BUTTONUP = 0x3B8;

        [NativeTypeName("#define MM_MCINOTIFY 0x3B9")]
        public const int MM_MCINOTIFY = 0x3B9;

        [NativeTypeName("#define MM_WOM_OPEN 0x3BB")]
        public const int MM_WOM_OPEN = 0x3BB;

        [NativeTypeName("#define MM_WOM_CLOSE 0x3BC")]
        public const int MM_WOM_CLOSE = 0x3BC;

        [NativeTypeName("#define MM_WOM_DONE 0x3BD")]
        public const int MM_WOM_DONE = 0x3BD;

        [NativeTypeName("#define MM_WIM_OPEN 0x3BE")]
        public const int MM_WIM_OPEN = 0x3BE;

        [NativeTypeName("#define MM_WIM_CLOSE 0x3BF")]
        public const int MM_WIM_CLOSE = 0x3BF;

        [NativeTypeName("#define MM_WIM_DATA 0x3C0")]
        public const int MM_WIM_DATA = 0x3C0;

        [NativeTypeName("#define MM_MIM_OPEN 0x3C1")]
        public const int MM_MIM_OPEN = 0x3C1;

        [NativeTypeName("#define MM_MIM_CLOSE 0x3C2")]
        public const int MM_MIM_CLOSE = 0x3C2;

        [NativeTypeName("#define MM_MIM_DATA 0x3C3")]
        public const int MM_MIM_DATA = 0x3C3;

        [NativeTypeName("#define MM_MIM_LONGDATA 0x3C4")]
        public const int MM_MIM_LONGDATA = 0x3C4;

        [NativeTypeName("#define MM_MIM_ERROR 0x3C5")]
        public const int MM_MIM_ERROR = 0x3C5;

        [NativeTypeName("#define MM_MIM_LONGERROR 0x3C6")]
        public const int MM_MIM_LONGERROR = 0x3C6;

        [NativeTypeName("#define MM_MOM_OPEN 0x3C7")]
        public const int MM_MOM_OPEN = 0x3C7;

        [NativeTypeName("#define MM_MOM_CLOSE 0x3C8")]
        public const int MM_MOM_CLOSE = 0x3C8;

        [NativeTypeName("#define MM_MOM_DONE 0x3C9")]
        public const int MM_MOM_DONE = 0x3C9;

        [NativeTypeName("#define MM_DRVM_OPEN 0x3D0")]
        public const int MM_DRVM_OPEN = 0x3D0;

        [NativeTypeName("#define MM_DRVM_CLOSE 0x3D1")]
        public const int MM_DRVM_CLOSE = 0x3D1;

        [NativeTypeName("#define MM_DRVM_DATA 0x3D2")]
        public const int MM_DRVM_DATA = 0x3D2;

        [NativeTypeName("#define MM_DRVM_ERROR 0x3D3")]
        public const int MM_DRVM_ERROR = 0x3D3;

        [NativeTypeName("#define MM_STREAM_OPEN 0x3D4")]
        public const int MM_STREAM_OPEN = 0x3D4;

        [NativeTypeName("#define MM_STREAM_CLOSE 0x3D5")]
        public const int MM_STREAM_CLOSE = 0x3D5;

        [NativeTypeName("#define MM_STREAM_DONE 0x3D6")]
        public const int MM_STREAM_DONE = 0x3D6;

        [NativeTypeName("#define MM_STREAM_ERROR 0x3D7")]
        public const int MM_STREAM_ERROR = 0x3D7;

        [NativeTypeName("#define MM_MOM_POSITIONCB 0x3CA")]
        public const int MM_MOM_POSITIONCB = 0x3CA;

        [NativeTypeName("#define MM_MCISIGNAL 0x3CB")]
        public const int MM_MCISIGNAL = 0x3CB;

        [NativeTypeName("#define MM_MIM_MOREDATA 0x3CC")]
        public const int MM_MIM_MOREDATA = 0x3CC;

        [NativeTypeName("#define MM_MIXM_LINE_CHANGE 0x3D0")]
        public const int MM_MIXM_LINE_CHANGE = 0x3D0;

        [NativeTypeName("#define MM_MIXM_CONTROL_CHANGE 0x3D1")]
        public const int MM_MIXM_CONTROL_CHANGE = 0x3D1;

        [NativeTypeName("#define MMSYSERR_BASE 0")]
        public const int MMSYSERR_BASE = 0;

        [NativeTypeName("#define WAVERR_BASE 32")]
        public const int WAVERR_BASE = 32;

        [NativeTypeName("#define MIDIERR_BASE 64")]
        public const int MIDIERR_BASE = 64;

        [NativeTypeName("#define TIMERR_BASE 96")]
        public const int TIMERR_BASE = 96;

        [NativeTypeName("#define JOYERR_BASE 160")]
        public const int JOYERR_BASE = 160;

        [NativeTypeName("#define MCIERR_BASE 256")]
        public const int MCIERR_BASE = 256;

        [NativeTypeName("#define MIXERR_BASE 1024")]
        public const int MIXERR_BASE = 1024;

        [NativeTypeName("#define MCI_STRING_OFFSET 512")]
        public const int MCI_STRING_OFFSET = 512;

        [NativeTypeName("#define MCI_VD_OFFSET 1024")]
        public const int MCI_VD_OFFSET = 1024;

        [NativeTypeName("#define MCI_CD_OFFSET 1088")]
        public const int MCI_CD_OFFSET = 1088;

        [NativeTypeName("#define MCI_WAVE_OFFSET 1152")]
        public const int MCI_WAVE_OFFSET = 1152;

        [NativeTypeName("#define MCI_SEQ_OFFSET 1216")]
        public const int MCI_SEQ_OFFSET = 1216;

        [NativeTypeName("#define MMSYSERR_NOERROR 0")]
        public const int MMSYSERR_NOERROR = 0;

        [NativeTypeName("#define MMSYSERR_ERROR (MMSYSERR_BASE + 1)")]
        public const int MMSYSERR_ERROR = (0 + 1);

        [NativeTypeName("#define MMSYSERR_BADDEVICEID (MMSYSERR_BASE + 2)")]
        public const int MMSYSERR_BADDEVICEID = (0 + 2);

        [NativeTypeName("#define MMSYSERR_NOTENABLED (MMSYSERR_BASE + 3)")]
        public const int MMSYSERR_NOTENABLED = (0 + 3);

        [NativeTypeName("#define MMSYSERR_ALLOCATED (MMSYSERR_BASE + 4)")]
        public const int MMSYSERR_ALLOCATED = (0 + 4);

        [NativeTypeName("#define MMSYSERR_INVALHANDLE (MMSYSERR_BASE + 5)")]
        public const int MMSYSERR_INVALHANDLE = (0 + 5);

        [NativeTypeName("#define MMSYSERR_NODRIVER (MMSYSERR_BASE + 6)")]
        public const int MMSYSERR_NODRIVER = (0 + 6);

        [NativeTypeName("#define MMSYSERR_NOMEM (MMSYSERR_BASE + 7)")]
        public const int MMSYSERR_NOMEM = (0 + 7);

        [NativeTypeName("#define MMSYSERR_NOTSUPPORTED (MMSYSERR_BASE + 8)")]
        public const int MMSYSERR_NOTSUPPORTED = (0 + 8);

        [NativeTypeName("#define MMSYSERR_BADERRNUM (MMSYSERR_BASE + 9)")]
        public const int MMSYSERR_BADERRNUM = (0 + 9);

        [NativeTypeName("#define MMSYSERR_INVALFLAG (MMSYSERR_BASE + 10)")]
        public const int MMSYSERR_INVALFLAG = (0 + 10);

        [NativeTypeName("#define MMSYSERR_INVALPARAM (MMSYSERR_BASE + 11)")]
        public const int MMSYSERR_INVALPARAM = (0 + 11);

        [NativeTypeName("#define MMSYSERR_HANDLEBUSY (MMSYSERR_BASE + 12)")]
        public const int MMSYSERR_HANDLEBUSY = (0 + 12);

        [NativeTypeName("#define MMSYSERR_INVALIDALIAS (MMSYSERR_BASE + 13)")]
        public const int MMSYSERR_INVALIDALIAS = (0 + 13);

        [NativeTypeName("#define MMSYSERR_BADDB (MMSYSERR_BASE + 14)")]
        public const int MMSYSERR_BADDB = (0 + 14);

        [NativeTypeName("#define MMSYSERR_KEYNOTFOUND (MMSYSERR_BASE + 15)")]
        public const int MMSYSERR_KEYNOTFOUND = (0 + 15);

        [NativeTypeName("#define MMSYSERR_READERROR (MMSYSERR_BASE + 16)")]
        public const int MMSYSERR_READERROR = (0 + 16);

        [NativeTypeName("#define MMSYSERR_WRITEERROR (MMSYSERR_BASE + 17)")]
        public const int MMSYSERR_WRITEERROR = (0 + 17);

        [NativeTypeName("#define MMSYSERR_DELETEERROR (MMSYSERR_BASE + 18)")]
        public const int MMSYSERR_DELETEERROR = (0 + 18);

        [NativeTypeName("#define MMSYSERR_VALNOTFOUND (MMSYSERR_BASE + 19)")]
        public const int MMSYSERR_VALNOTFOUND = (0 + 19);

        [NativeTypeName("#define MMSYSERR_NODRIVERCB (MMSYSERR_BASE + 20)")]
        public const int MMSYSERR_NODRIVERCB = (0 + 20);

        [NativeTypeName("#define MMSYSERR_MOREDATA (MMSYSERR_BASE + 21)")]
        public const int MMSYSERR_MOREDATA = (0 + 21);

        [NativeTypeName("#define MMSYSERR_LASTERROR (MMSYSERR_BASE + 21)")]
        public const int MMSYSERR_LASTERROR = (0 + 21);

        [NativeTypeName("#define CALLBACK_TYPEMASK 0x00070000l")]
        public const int CALLBACK_TYPEMASK = 0x00070000;

        [NativeTypeName("#define CALLBACK_NULL 0x00000000l")]
        public const int CALLBACK_NULL = 0x00000000;

        [NativeTypeName("#define CALLBACK_WINDOW 0x00010000l")]
        public const int CALLBACK_WINDOW = 0x00010000;

        [NativeTypeName("#define CALLBACK_TASK 0x00020000l")]
        public const int CALLBACK_TASK = 0x00020000;

        [NativeTypeName("#define CALLBACK_FUNCTION 0x00030000l")]
        public const int CALLBACK_FUNCTION = 0x00030000;

        [NativeTypeName("#define CALLBACK_THREAD (CALLBACK_TASK)")]
        public const int CALLBACK_THREAD = (0x00020000);

        [NativeTypeName("#define CALLBACK_EVENT 0x00050000l")]
        public const int CALLBACK_EVENT = 0x00050000;
    }
}
