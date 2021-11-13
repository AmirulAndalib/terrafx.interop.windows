// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AllocConsole();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FreeConsole();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL AttachConsole([NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetConsoleCP();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern uint GetConsoleOutputCP();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetConsoleMode(HANDLE hConsoleHandle, [NativeTypeName("LPDWORD")] uint* lpMode);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleMode(HANDLE hConsoleHandle, [NativeTypeName("DWORD")] uint dwMode);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetNumberOfConsoleInputEvents(HANDLE hConsoleInput, [NativeTypeName("LPDWORD")] uint* lpNumberOfEvents);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleInputA(HANDLE hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleInputW(HANDLE hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PeekConsoleInputA(HANDLE hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL PeekConsoleInputW(HANDLE hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleA(HANDLE hConsoleInput, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead, [NativeTypeName("PCONSOLE_READCONSOLE_CONTROL")] CONSOLE_READCONSOLE_CONTROL* pInputControl);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleW(HANDLE hConsoleInput, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead, [NativeTypeName("PCONSOLE_READCONSOLE_CONTROL")] CONSOLE_READCONSOLE_CONTROL* pInputControl);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleA(HANDLE hConsoleOutput, [NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleW(HANDLE hConsoleOutput, [NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleCtrlHandler([NativeTypeName("PHANDLER_ROUTINE")] delegate* unmanaged<uint, BOOL> HandlerRoutine, BOOL Add);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern HRESULT CreatePseudoConsole(COORD size, HANDLE hInput, HANDLE hOutput, [NativeTypeName("DWORD")] uint dwFlags, HPCON* phPC);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern HRESULT ResizePseudoConsole(HPCON hPC, COORD size);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void ClosePseudoConsole(HPCON hPC);

        [NativeTypeName("#define ATTACH_PARENT_PROCESS ((DWORD)-1)")]
        public const uint ATTACH_PARENT_PROCESS = unchecked((uint)(-1));

        [NativeTypeName("#define ENABLE_PROCESSED_INPUT 0x0001")]
        public const int ENABLE_PROCESSED_INPUT = 0x0001;

        [NativeTypeName("#define ENABLE_LINE_INPUT 0x0002")]
        public const int ENABLE_LINE_INPUT = 0x0002;

        [NativeTypeName("#define ENABLE_ECHO_INPUT 0x0004")]
        public const int ENABLE_ECHO_INPUT = 0x0004;

        [NativeTypeName("#define ENABLE_WINDOW_INPUT 0x0008")]
        public const int ENABLE_WINDOW_INPUT = 0x0008;

        [NativeTypeName("#define ENABLE_MOUSE_INPUT 0x0010")]
        public const int ENABLE_MOUSE_INPUT = 0x0010;

        [NativeTypeName("#define ENABLE_INSERT_MODE 0x0020")]
        public const int ENABLE_INSERT_MODE = 0x0020;

        [NativeTypeName("#define ENABLE_QUICK_EDIT_MODE 0x0040")]
        public const int ENABLE_QUICK_EDIT_MODE = 0x0040;

        [NativeTypeName("#define ENABLE_EXTENDED_FLAGS 0x0080")]
        public const int ENABLE_EXTENDED_FLAGS = 0x0080;

        [NativeTypeName("#define ENABLE_AUTO_POSITION 0x0100")]
        public const int ENABLE_AUTO_POSITION = 0x0100;

        [NativeTypeName("#define ENABLE_VIRTUAL_TERMINAL_INPUT 0x0200")]
        public const int ENABLE_VIRTUAL_TERMINAL_INPUT = 0x0200;

        [NativeTypeName("#define ENABLE_PROCESSED_OUTPUT 0x0001")]
        public const int ENABLE_PROCESSED_OUTPUT = 0x0001;

        [NativeTypeName("#define ENABLE_WRAP_AT_EOL_OUTPUT 0x0002")]
        public const int ENABLE_WRAP_AT_EOL_OUTPUT = 0x0002;

        [NativeTypeName("#define ENABLE_VIRTUAL_TERMINAL_PROCESSING 0x0004")]
        public const int ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

        [NativeTypeName("#define DISABLE_NEWLINE_AUTO_RETURN 0x0008")]
        public const int DISABLE_NEWLINE_AUTO_RETURN = 0x0008;

        [NativeTypeName("#define ENABLE_LVB_GRID_WORLDWIDE 0x0010")]
        public const int ENABLE_LVB_GRID_WORLDWIDE = 0x0010;

        [NativeTypeName("#define ReadConsoleInput ReadConsoleInputW")]
        public static delegate*<HANDLE, INPUT_RECORD*, uint, uint*, BOOL> ReadConsoleInput => &ReadConsoleInputW;

        [NativeTypeName("#define PeekConsoleInput PeekConsoleInputW")]
        public static delegate*<HANDLE, INPUT_RECORD*, uint, uint*, BOOL> PeekConsoleInput => &PeekConsoleInputW;

        [NativeTypeName("#define ReadConsole ReadConsoleW")]
        public static delegate*<HANDLE, void*, uint, uint*, CONSOLE_READCONSOLE_CONTROL*, BOOL> ReadConsole => &ReadConsoleW;

        [NativeTypeName("#define WriteConsole WriteConsoleW")]
        public static delegate*<HANDLE, void*, uint, uint*, void*, BOOL> WriteConsole => &WriteConsoleW;

        [NativeTypeName("#define CTRL_C_EVENT 0")]
        public const int CTRL_C_EVENT = 0;

        [NativeTypeName("#define CTRL_BREAK_EVENT 1")]
        public const int CTRL_BREAK_EVENT = 1;

        [NativeTypeName("#define CTRL_CLOSE_EVENT 2")]
        public const int CTRL_CLOSE_EVENT = 2;

        [NativeTypeName("#define CTRL_LOGOFF_EVENT 5")]
        public const int CTRL_LOGOFF_EVENT = 5;

        [NativeTypeName("#define CTRL_SHUTDOWN_EVENT 6")]
        public const int CTRL_SHUTDOWN_EVENT = 6;

        [NativeTypeName("#define PSEUDOCONSOLE_INHERIT_CURSOR (0x1)")]
        public const int PSEUDOCONSOLE_INHERIT_CURSOR = (0x1);
    }
}
