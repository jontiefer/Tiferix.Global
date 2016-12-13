/* Copyright © 2016-2017 Jonathan Tiefer - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the GNU Lesser General Public License (LGPL)
 *
 * You should have received a copy of the LGPL license with
 * this file.
 *
 * /

/*  This file is part of Tiferix.Global
*
*   Tiferix.Global is free software: you can redistribute it and/or modify
*   it under the terms of the GNU Lesser General Public License as published by
*   the Free Software Foundation, either version 3 of the License, or
*    (at your option) any later version.
*
*   Tiferix.Global is distributed in the hope that it will be useful,
*   but WITHOUT ANY WARRANTY; without even the implied warranty of
*   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*   GNU Lesser General Public License for more details.
*
*  You should have received a copy of the GNU Lesser General Public License
*   along with Tiferix.Global.  If not, see <http://www.gnu.org/licenses/>.
*/


using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tiferix.Global.Win32API
{
    #region Win32 General Enumerations

    public enum BeepType
    {
        SimpleBeep = -1,
        IconAsterisk = 0x00000040,
        IconExclamation = 0x00000030,
        IconHand = 0x00000010,
        IconQuestion = 0x00000020,
        Ok = 0x00000000,
    }

    #endregion

    #region Win32 Memory Enumerations
    public enum GMEM
    {
        GMEM_FIXED = 0x0000,
        GMEM_MOVEABLE = 0x0002,
        GMEM_NOCOMPACT = 0x0010,
        GMEM_NODISCARD = 0x0020,
        GMEM_ZEROINIT = 0x0040,
        GMEM_MODIFY = 0x0080,
        GMEM_DISCARDABLE = 0x0100,
        GMEM_NOT_BANKED = 0x1000,
        GMEM_SHARE = 0x2000,
        GMEM_DDESHARE = 0x2000,
        GMEM_NOTIFY = 0x4000,
        GMEM_LOWER = GMEM_NOT_BANKED,
        GMEM_VALID_FLAGS = 0x7F72,
        GMEM_INVALID_HANDLE = 0x8000,
    }
    #endregion

    #region Win32 Memory Structures
    #endregion

    #region Win32 Message/Window Enumerations

    public enum GWL
    {
        GWL_WNDPROC = -4,
        GWL_HINSTANCE = -6,
        GWL_HWNDPARENT = -8,
        GWL_STYLE = -16,
        GWL_EXSTYLE = -20,
        GWL_USERDATA = -21,
        GWL_ID = -12,
    }

    public enum HCBT
    {
        HCBT_MOVESIZE = 0,
        HCBT_MINMAX = 1,
        HCBT_QS = 2,
        HCBT_CREATEWND = 3,
        HCBT_DESTROYWND = 4,
        HCBT_ACTIVATE = 5,
        HCBT_CLICKSKIPPED = 6,
        HCBT_KEYSKIPPED = 7,
        HCBT_SYSCOMMAND = 8,
        HCBT_SETFOCUS = 9,
    }

    public enum WM
    {
        WM_NULL = 0x0000,
        WM_CREATE = 0x0001,
        WM_DESTROY = 0x0002,
        WM_MOVE = 0x0003,
        WM_SIZE = 0x0005,
        WM_ACTIVATE = 0x0006,
        WM_SETFOCUS = 0x0007,
        WM_KILLFOCUS = 0x0008,
        WM_ENABLE = 0x000A,
        WM_SETREDRAW = 0x000B,
        WM_SETTEXT = 0x000C,
        WM_GETTEXT = 0x000D,
        WM_GETTEXTLENGTH = 0x000E,
        WM_PAINT = 0x000F,
        WM_CLOSE = 0x0010,
        WM_QUERYENDSESSION = 0x0011,
        WM_QUIT = 0x0012,
        WM_QUERYOPEN = 0x0013,
        WM_ERASEBKGND = 0x0014,
        WM_SYSCOLORCHANGE = 0x0015,
        WM_ENDSESSION = 0x0016,
        WM_SHOWWINDOW = 0x0018,
        WM_WININICHANGE = 0x001A,
        WM_SETTINGCHANGE = WM_WININICHANGE,
        WM_DEVMODECHANGE = 0x001B,
        WM_ACTIVATEAPP = 0x001C,
        WM_FONTCHANGE = 0x001D,
        WM_TIMECHANGE = 0x001E,
        WM_CANCELMODE = 0x001F,
        WM_SETCURSOR = 0x0020,
        WM_MOUSEACTIVATE = 0x0021,
        WM_CHILDACTIVATE = 0x0022,
        WM_QUEUESYNC = 0x0023,
        WM_GETMINMAXINFO = 0x0024,
        WM_PAINTICON = 0x0026,
        WM_ICONERASEBKGND = 0x0027,
        WM_NEXTDLGCTL = 0x0028,
        WM_SPOOLERSTATUS = 0x002A,
        WM_DRAWITEM = 0x002B,
        WM_MEASUREITEM = 0x002C,
        WM_DELETEITEM = 0x002D,
        WM_VKEYTOITEM = 0x002E,
        WM_CHARTOITEM = 0x002F,
        WM_SETFONT = 0x0030,
        WM_GETFONT = 0x0031,
        WM_SETHOTKEY = 0x0032,
        WM_GETHOTKEY = 0x0033,
        WM_QUERYDRAGICON = 0x0037,
        WM_COMPAREITEM = 0x0039,
        WM_GETOBJECT = 0x003D,
        WM_COMPACTING = 0x0041,
        WM_COMMNOTIFY = 0x0044,
        WM_WINDOWPOSCHANGING = 0x0046,
        WM_WINDOWPOSCHANGED = 0x0047,
        WM_COPYDATA = 0x004A,
        WM_CANCELJOURNAL = 0x004B,
        WM_NOTIFY = 0x004E,
        WM_INPUTLANGCHANGEREQUEST = 0x0050,
        WM_INPUTLANGCHANGE = 0x0051,
        WM_TCARD = 0x0052,
        WM_HELP = 0x0053,
        WM_USERCHANGED = 0x0054,
        WM_NOTIFYFORMAT = 0x0055,
        WM_CONTEXTMENU = 0x007B,
        WM_STYLECHANGING = 0x007C,
        WM_STYLECHANGED = 0x007D,
        WM_DISPLAYCHANGE = 0x007E,
        WM_GETICON = 0x007F,
        WM_SETICON = 0x0080,
        WM_NCCREATE = 0x0081,
        WM_NCDESTROY = 0x0082,
        WM_NCCALCSIZE = 0x0083,
        WM_NCHITTEST = 0x0084,
        WM_NCPAINT = 0x0085,
        WM_NCACTIVATE = 0x0086,
        WM_GETDLGCODE = 0x0087,
        WM_SYNCPAINT = 0x0088,
        WM_NCMOUSEMOVE = 0x00A0,
        WM_NCLBUTTONDOWN = 0x00A1,
        WM_NCLBUTTONUP = 0x00A2,
        WM_NCLBUTTONDBLCLK = 0x00A3,
        WM_NCRBUTTONDOWN = 0x00A4,
        WM_NCRBUTTONUP = 0x00A5,
        WM_NCRBUTTONDBLCLK = 0x00A6,
        WM_NCMBUTTONDOWN = 0x00A7,
        WM_NCMBUTTONUP = 0x00A8,
        WM_NCMBUTTONDBLCLK = 0x00A9,
        WM_KEYFIRST = 0x0100,
        WM_KEYDOWN = 0x0100,
        WM_KEYUP = 0x0101,
        WM_CHAR = 0x0102,
        WM_DEADCHAR = 0x0103,
        WM_SYSKEYDOWN = 0x0104,
        WM_SYSKEYUP = 0x0105,
        WM_SYSCHAR = 0x0106,
        WM_SYSDEADCHAR = 0x0107,
        WM_KEYLAST = 0x0108,
        WM_IME_STARTCOMPOSITION = 0x010D,
        WM_IME_ENDCOMPOSITION = 0x010E,
        WM_IME_COMPOSITION = 0x010F,
        WM_IME_KEYLAST = 0x010F,
        WM_INITDIALOG = 0x0110,
        WM_COMMAND = 0x0111,
        WM_SYSCOMMAND = 0x0112,
        WM_TIMER = 0x0113,
        WM_HSCROLL = 0x0114,
        WM_VSCROLL = 0x0115,
        WM_INITMENU = 0x0116,
        WM_INITMENUPOPUP = 0x0117,
        WM_MENUSELECT = 0x011F,
        WM_MENUCHAR = 0x0120,
        WM_ENTERIDLE = 0x0121,
        WM_MENURBUTTONUP = 0x0122,
        WM_MENUDRAG = 0x0123,
        WM_MENUGETOBJECT = 0x0124,
        WM_UNINITMENUPOPUP = 0x0125,
        WM_MENUCOMMAND = 0x0126,
        WM_CTLCOLORMSGBOX = 0x0132,
        WM_CTLCOLOREDIT = 0x0133,
        WM_CTLCOLORLISTBOX = 0x0134,
        WM_CTLCOLORBTN = 0x0135,
        WM_CTLCOLORDLG = 0x0136,
        WM_CTLCOLORSCROLLBAR = 0x0137,
        WM_CTLCOLORSTATIC = 0x0138,
        WM_MOUSEFIRST = 0x0200,
        WM_MOUSEMOVE = 0x0200,
        WM_LBUTTONDOWN = 0x0201,
        WM_LBUTTONUP = 0x0202,
        WM_LBUTTONDBLCLK = 0x0203,
        WM_RBUTTONDOWN = 0x0204,
        WM_RBUTTONUP = 0x0205,
        WM_RBUTTONDBLCLK = 0x0206,
        WM_MBUTTONDOWN = 0x0207,
        WM_MBUTTONUP = 0x0208,
        WM_MBUTTONDBLCLK = 0x0209,
        WM_MOUSEWHEEL = 0x020A,
        WM_MOUSELAST = 0x020A,
        WM_MOUSELAST2 = 0x0209,
        WM_PARENTNOTIFY = 0x0210,
        WM_ENTERMENULOOP = 0x0211,
        WM_EXITMENULOOP = 0x0212,
        WM_NEXTMENU = 0x0213,
        WM_SIZING = 0x0214,
        WM_CAPTURECHANGED = 0x0215,
        WM_MOVING = 0x0216,
        WM_DEVICECHANGE = 0x0219,
        WM_MDICREATE = 0x0220,
        WM_MDIDESTROY = 0x0221,
        WM_MDIACTIVATE = 0x0222,
        WM_MDIRESTORE = 0x0223,
        WM_MDINEXT = 0x0224,
        WM_MDIMAXIMIZE = 0x0225,
        WM_MDITILE = 0x0226,
        WM_MDICASCADE = 0x0227,
        WM_MDIICONARRANGE = 0x0228,
        WM_MDIGETACTIVE = 0x0229,
        WM_MDISETMENU = 0x0230,
        WM_ENTERSIZEMOVE = 0x0231,
        WM_EXITSIZEMOVE = 0x0232,
        WM_DROPFILES = 0x0233,
        WM_MDIREFRESHMENU = 0x0234,
        WM_IME_SETCONTEXT = 0x0281,
        WM_IME_NOTIFY = 0x0282,
        WM_IME_CONTROL = 0x0283,
        WM_IME_COMPOSITIONFULL = 0x0284,
        WM_IME_SELECT = 0x0285,
        WM_IME_CHAR = 0x0286,
        WM_IME_REQUEST = 0x0288,
        WM_IME_KEYDOWN = 0x0290,
        WM_IME_KEYUP = 0x0291,
        WM_MOUSEHOVER = 0x02A1,
        WM_MOUSELEAVE = 0x02A3,
        WM_CUT = 0x0300,
        WM_COPY = 0x0301,
        WM_PASTE = 0x0302,
        WM_CLEAR = 0x0303,
        WM_UNDO = 0x0304,
        WM_RENDERFORMAT = 0x0305,
        WM_RENDERALLFORMATS = 0x0306,
        WM_DESTROYCLIPBOARD = 0x0307,
        WM_DRAWCLIPBOARD = 0x0308,
        WM_PAINTCLIPBOARD = 0x0309,
        WM_VSCROLLCLIPBOARD = 0x030A,
        WM_SIZECLIPBOARD = 0x030B,
        WM_ASKCBFORMATNAME = 0x030C,
        WM_CHANGECBCHAIN = 0x030D,
        WM_HSCROLLCLIPBOARD = 0x030E,
        WM_QUERYNEWPALETTE = 0x030F,
        WM_PALETTEISCHANGING = 0x0310,
        WM_PALETTECHANGED = 0x0311,
        WM_HOTKEY = 0x0312,
        WM_PRINT = 0x0317,
        WM_PRINTCLIENT = 0x0318,
        WM_HANDHELDFIRST = 0x0358,
        WM_HANDHELDLAST = 0x035F,
        WM_AFXFIRST = 0x0360,
        WM_AFXLAST = 0x037F,
        WM_PENWINFIRST = 0x0380,
        WM_PENWINLAST = 0x038F,
        WM_APP = 0x8000,
        WM_USER = 0x0400,


    }

    public enum SC
    {
        SC_SIZE = 0xF000,
        SC_MOVE = 0xF010,
        SC_MINIMIZE = 0xF020,
        SC_MAXIMIZE = 0xF030,
        SC_NEXTWINDOW = 0xF040,
        SC_PREVWINDOW = 0xF050,
        SC_CLOSE = 0xF060,
        SC_VSCROLL = 0xF070,
        SC_HSCROLL = 0xF080,
        SC_MOUSEMENU = 0xF090,
        SC_KEYMENU = 0xF100,
        SC_ARRANGE = 0xF110,
        SC_RESTORE = 0xF120,
        SC_TASKLIST = 0xF130,
        SC_SCREENSAVE = 0xF140,
        SC_HOTKEY = 0xF150,
        SC_DEFAULT = 0xF160,
        SC_MONITORPOWER = 0xF170,
        SC_CONTEXTHELP = 0xF180,
        SC_SEPARATOR = 0xF00F,
        SC_ICON = SC_MINIMIZE,
        SC_ZOOM = SC_MAXIMIZE
    }

    public enum SWP
    {
        SWP_NOSIZE = 0x0001,
        SWP_NOMOVE = 0x0002,
        SWP_NOZORDER = 0x0004,
        SWP_NOREDRAW = 0x0008,
        SWP_NOACTIVATE = 0x0010,
        SWP_FRAMECHANGED = 0x0020,
        SWP_SHOWWINDOW = 0x0040,
        SWP_HIDEWINDOW = 0x0080,
        SWP_NOCOPYBITS = 0x0100,
        SWP_NOOWNERZORDER = 0x0200,
        SWP_NOSENDCHANGING = 0x0400,
        SWP_DRAWFRAME = SWP_FRAMECHANGED,
        SWP_NOREPOSITION = SWP_NOOWNERZORDER,
    }

    public enum HWND
    {
        HWND_TOP = 0,
        HWND_BOTTOM = 1,
        HWND_TOPMOST = -1,
        HWND_NOTOPMOST = -2,
        HWND_DESKTOP = 0,
        HWND_BROADCAST = 0x0FFFF
    }

    public enum WHEEL
    {
        WHEEL_DELTA = 120,
    }

    public enum MK
    {
        MK_LBUTTON = 0x0001,
        MK_RBUTTON = 0x0002,
        MK_SHIFT = 0x0004,
        MK_CONTROL = 0x0008,
        MK_MBUTTON = 0x0010,
        MK_ALT = 0x0020,
    }

    public enum PM
    {
        PM_NOREMOVE = 0x0000,
        PM_REMOVE = 0x0001,
        PM_NOYIELD = 0x0002,
    }

    public enum VK
    {
        VK_LBUTTON = 0x01,
        VK_RBUTTON = 0x02,
        VK_CANCEL = 0x03,
        VK_MBUTTON = 0x04,
        VK_BACK = 0x08,
        VK_TAB = 0x09,
        VK_CLEAR = 0x0C,
        VK_RETURN = 0x0D,
        VK_SHIFT = 0x10,
        VK_CONTROL = 0x11,
        VK_MENU = 0x12,
        VK_PAUSE = 0x13,
        VK_CAPITAL = 0x14,
        VK_KANA = 0x15,
        VK_HANGEUL = 0x15,
        VK_HANGUL = 0x15,
        VK_JUNJA = 0x17,
        VK_FINAL = 0x18,
        VK_HANJA = 0x19,
        VK_KANJI = 0x19,
        VK_ESCAPE = 0x1B,
        VK_CONVERT = 0x1C,
        VK_NONCONVERT = 0x1D,
        VK_ACCEPT = 0x1E,
        VK_MODECHANGE = 0x1F,
        VK_SPACE = 0x20,
        VK_PRIOR = 0x21,
        VK_NEXT = 0x22,
        VK_END = 0x23,
        VK_HOME = 0x24,
        VK_LEFT = 0x25,
        VK_UP = 0x26,
        VK_RIGHT = 0x27,
        VK_DOWN = 0x28,
        VK_SELECT = 0x29,
        VK_PRINT = 0x2A,
        VK_EXECUTE = 0x2B,
        VK_SNAPSHOT = 0x2C,
        VK_INSERT = 0x2D,
        VK_DELETE = 0x2E,
        VK_HELP = 0x2F,
        VK_LWIN = 0x5B,
        VK_RWIN = 0x5C,
        VK_APPS = 0x5D,
        VK_NUMPAD0 = 0x60,
        VK_NUMPAD1 = 0x61,
        VK_NUMPAD2 = 0x62,
        VK_NUMPAD3 = 0x63,
        VK_NUMPAD4 = 0x64,
        VK_NUMPAD5 = 0x65,
        VK_NUMPAD6 = 0x66,
        VK_NUMPAD7 = 0x67,
        VK_NUMPAD8 = 0x68,
        VK_NUMPAD9 = 0x69,
        VK_MULTIPLY = 0x6A,
        VK_ADD = 0x6B,
        VK_SEPARATOR = 0x6C,
        VK_SUBTRACT = 0x6D,
        VK_DECIMAL = 0x6E,
        VK_DIVIDE = 0x6F,
        VK_F1 = 0x70,
        VK_F2 = 0x71,
        VK_F3 = 0x72,
        VK_F4 = 0x73,
        VK_F5 = 0x74,
        VK_F6 = 0x75,
        VK_F7 = 0x76,
        VK_F8 = 0x77,
        VK_F9 = 0x78,
        VK_F10 = 0x79,
        VK_F11 = 0x7A,
        VK_F12 = 0x7B,
        VK_F13 = 0x7C,
        VK_F14 = 0x7D,
        VK_F15 = 0x7E,
        VK_F16 = 0x7F,
        VK_F17 = 0x80,
        VK_F18 = 0x81,
        VK_F19 = 0x82,
        VK_F20 = 0x83,
        VK_F21 = 0x84,
        VK_F22 = 0x85,
        VK_F23 = 0x86,
        VK_F24 = 0x87,
        VK_NUMLOCK = 0x90,
        VK_SCROLL = 0x91,
        VK_LSHIFT = 0xA0,
        VK_RSHIFT = 0xA1,
        VK_LCONTROL = 0xA2,
        VK_RCONTROL = 0xA3,
        VK_LMENU = 0xA4,
        VK_RMENU = 0xA5,
        VK_PROCESSKEY = 0xE5,
        VK_ATTN = 0xF6,
        VK_CRSEL = 0xF7,
        VK_EXSEL = 0xF8,
        VK_EREOF = 0xF9,
        VK_PLAY = 0xFA,
        VK_ZOOM = 0xFB,
        VK_NONAME = 0xFC,
        VK_PA1 = 0xFD,
        VK_OEM_CLEAR = 0xFE,
    }

    public enum RDW
    {
        RDW_INVALIDATE = 0x0001,
        RDW_INTERNALPAINT = 0x0002,
        RDW_ERASE = 0x0004,
        RDW_VALIDATE = 0x0008,
        RDW_NOINTERNALPAINT = 0x0010,
        RDW_NOERASE = 0x0020,
        RDW_NOCHILDREN = 0x0040,
        RDW_ALLCHILDREN = 0x0080,
        RDW_UPDATENOW = 0x0100,
        RDW_ERASENOW = 0x0200,
        RDW_FRAME = 0x0400,
        RDW_NOFRAME = 0x0800,
    }

    public enum WinSize
    {
        SIZE_MAXHIDE = 0x0004,
        SIZE_MAXIMIZED = 0x0002,
        SIZE_MAXSHOW = 0x0003,
        SIZE_MINIMIZED = 0x0001,
        SIZE_RESTORED = 0
    }

    #endregion

    #region Win32 Message/Window Structures

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct MSG
    {
        public IntPtr hwnd;
        public int message;
        public int wParam;
        public int lParam;
        public uint time;
        public System.Drawing.Point pt;
        public uint lPrivate;
    };

    #endregion

    #region Win32 GDI Enumerations

    public enum HS
    {
        HS_HORIZONTAL = 0,
        HS_VERTICAL = 1,
        HS_FDIAGONAL = 2,
        HS_BDIAGONAL = 3,
        HS_CROSS = 4,
        HS_DIAGCROSS = 5,
        HS_FDIAGONAL1 = 6,
        HS_BDIAGONAL1 = 7
    }

    public enum OBJ
    {
        OBJ_PEN = 1,
        OBJ_BRUSH = 2,
        OBJ_DC = 3,
        OBJ_METADC = 4,
        OBJ_PAL = 5,
        OBJ_FONT = 6,
        OBJ_BITMAP = 7,
        OBJ_REGION = 8,
        OBJ_METAFILE = 9,
        OBJ_MEMDC = 10,
        OBJ_EXTPEN = 11,
        OBJ_ENHMETADC = 12,
        OBJ_ENHMETAFILE = 13,
    }

    public enum DeviceCapsConstants
    {
        DRIVERVERSION = 0,
        TECHNOLOGY = 2,
        HORZRES = 8,
        VERTRES = 10,
        HORZSIZE = 4,
        VERTSIZE = 6,
        LOGPIXELSX = 88,
        LOGPIXELSY = 90,
        BITSPIXEL = 12,
        PLANES = 14,
        NUMBRUSHES = 16,
        NUMPENS = 18,
        NUMFONTS = 22,
        NUMCOLORS = 24,
        ASPECTX = 40,
        ASPECTY = 42,
        ASPECTXY = 44,
        PDEVICESIZE = 26,
        CLIPCAPS = 36,
        SIZEPALETTE = 104,
        NUMRESERVED = 106,
        ColorRes = 108,
        PHYSICALHEIGHT = 111,
        PHYSICALWIDTH = 110,
        PHYSICALOFFSETX = 112,
        PHYSICALOFFSETY = 113,
        VREFRESH = 116,
        DESKTOPHORZRES = 118,
        DESKTOPVERTRES = 117,
        SCALINGFACTORX = 114,
        SCALINGFACTORY = 115,
        BLTALIGNMENT = 119,
        SHADEBLENDCAPS = 120,
        RASTERCAPS = 38,
        CURVECAPS = 28,
        LINECAPS = 30,
        POLYGONALCAPS = 32,
        TEXTCAPS = 34
    }

    public enum FLOODFILLBORDER
    {
        FLOODFILLBORDER = 0,
        FLOODFILLSURFACE = 1,
    }

    public enum IMAGE
    {
        IMAGE_BITMAP = 0,
        IMAGE_ICON = 1,
        IMAGE_CURSOR = 2,
    }

    public enum LR
    {
        LR_DEFAULTCOLOR = 0x0000,
        LR_MONOCHROME = 0x0001,
        LR_COLOR = 0x0002,
        LR_COPYRETURNORG = 0x0004,
        LR_COPYDELETEORG = 0x0008,
        LR_LOADFROMFILE = 0x0010,
        LR_LOADTRANSPARENT = 0x0020,
        LR_DEFAULTSIZE = 0x0040,
        LR_VGACOLOR = 0x0080,
        LR_LOADMAP3DCOLORS = 0x1000,
        LR_CREATEDIBSECTION = 0x2000,
        LR_COPYFROMRESOURCE = 0x4000,
        LR_SHARED = 0x8000
    }

    public enum AC
    {
        AC_SRC_OVER = 0x00,
        AC_SRC_NO_PREMULT_ALPHA = 0x01,
        AC_SRC_NO_ALPHA = 0x02,
        AC_DST_NO_PREMULT_ALPHA = 0x10,
        AC_DST_NO_ALPHA = 0x20,
    }

    public enum APIRasterOpConstants
    {
        SRCCOPY = 0x00CC0020,
        SRCPAINT = 0x00EE0086,
        SRCAND = 0x008800C6,
        SRCINVERT = 0x00660046,
        SRCERASE = 0x00440328,
        NOTSRCCOPY = 0x00330008,
        NOTSRCERASE = 0x001100A6,
        MERGECOPY = 0x00C000CA,
        MERGEPAINT = 0x00BB0226,
        PATCOPY = 0x00F00021,
        PATPAINT = 0x00FB0A09,
        PATINVERT = 0x005A0049,
        DSTINVERT = 0x00550009,
        BLACKNESS = 0x00000042,
        WHITENESS = 0x00FF0062
    }

    public enum STRETCH
    {
        STRETCH_ANDSCANS = WinAPI.BLACKONWHITE,
        STRETCH_ORSCANS = WinAPI.WHITEONBLACK,
        STRETCH_DELETESCANS = WinAPI.COLORONCOLOR,
        STRETCH_HALFTONE = WinAPI.HALFTONE,
    }

    public enum PS
    {
        PS_SOLID = 0,
        PS_DASH = 1,
        PS_DOT = 2,
        PS_DASHDOT = 3,
        PS_DASHDOTDOT = 4,
        PS_NULL = 5,
        PS_INSIDEFRAME = 6,
        PS_USERSTYLE = 7,
        PS_ALTERNATE = 8,
        PS_STYLE_MASK = 0x0000000F,
        PS_ENDCAP_ROUND = 0x00000000,
        PS_ENDCAP_SQUARE = 0x00000100,
        PS_ENDCAP_FLAT = 0x00000200,
        PS_ENDCAP_MASK = 0x00000F00,
        PS_JOIN_ROUND = 0x00000000,
        PS_JOIN_BEVEL = 0x00001000,
        PS_JOIN_MITER = 0x00002000,
        PS_JOIN_MASK = 0x0000F000,
        PS_COSMETIC = 0x00000000,
        PS_GEOMETRIC = 0x00010000,
        PS_TYPE_MASK = 0x000F0000
    }

    public enum RGN
    {
        //RGN_ERROR = ERROR,
        RGN_AND = 1,
        RGN_OR = 2,
        RGN_XOR = 3,
        RGN_DIFF = 4,
        RGN_COPY = 5,
        RGN_MIN = RGN_AND,
        RGN_MAX = RGN_COPY
    }

    public enum DrawTextFormats
    {
        DT_TOP = 0x00000000,
        DT_LEFT = 0x00000000,
        DT_CENTER = 0x00000001,
        DT_RIGHT = 0x00000002,
        DT_VCENTER = 0x00000004,
        DT_BOTTOM = 0x00000008,
        DT_WORDBREAK = 0x00000010,
        DT_SINGLELINE = 0x00000020,
        DT_EXPANDTABS = 0x00000040,
        DT_TABSTOP = 0x00000080,
        DT_NOCLIP = 0x00000100,
        DT_EXTERNALLEADING = 0x00000200,
        DT_CALCRECT = 0x00000400,
        DT_NOPREFIX = 0x00000800,
        DT_INTERNAL = 0x00001000,
        DT_EDITCONTROL = 0x00002000,
        DT_PATH_ELLIPSIS = 0x00004000,
        DT_END_ELLIPSIS = 0x00008000,
        DT_MODIFYSTRING = 0x00010000,
        DT_RTLREADING = 0x00020000,
        DT_WORD_ELLIPSIS = 0x00040000,
        DT_PLOTTER = 0,
        DT_RASDISPLAY = 1,
        DT_RASPRINTER = 2,
        DT_RASCAMERA = 3,
        DT_CHARSTREAM = 4,
        DT_METAFILE = 5,
        DT_DISPFILE = 6,
    }

    #endregion

    #region Win32 GDI Structures

    public struct POINTAPI
    {
        public int x;
        public int y;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct POINTAPIFLOAT
    {
        public float x;
        public float y;
    };

    public struct RECTAPI
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    };

    public struct RECTFLOAT
    {
        public float Left;
        public float Top;
        public float Right;
        public float Bottom;
    };

    public struct SizeAPI
    {
        public int cx;
        public int cy;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct BITMAPINFOHEADER
    {
        public uint biSize;
        public int biWidth;
        public int biHeight;
        public short biPlanes;
        public short biBitCount;
        public uint biCompression;
        public uint biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public uint biClrUsed;
        public uint biClrImportant;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct RGBQUAD
    {
        public byte rgbBlue;
        public byte rgbGreen;
        public byte rgbRed;
        public byte rgbReserved;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct BITMAPINFO
    {
        public BITMAPINFOHEADER bmiHeader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public RGBQUAD[] bmiColors;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct BITMAP
    {
        public int bmType;
        public int bmWidth;
        public int bmHeight;
        public int bmWidthBytes;
        public short bmPlanes;
        public short bmBitsPixel;
        public Byte[] bmBits;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct BLENDFUNCTION
    {
        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct PAINTSTRUCT
    {
        public IntPtr hdc;
        public int fErase;
        //public System.Drawing.Rectangle rcPaint;
        public RECTAPI rcPaint;
        public int fRestore;
        public int fIncUpdate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] rgbReserved;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct LOGBRUSH
    {
        public int lbStyle;
        public int lbColor;
        public int lbHatch;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct RGNDATAHEADER
    {
        public uint dwSize;
        public uint iType;
        public uint nCount;
        public uint nRgnSize;
        public RECTAPI rcBound;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct RGNDATA
    {
        public RGNDATAHEADER rdh;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public char[] Buffer;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct XFORM
    {
        public float eM11;
        public float eM12;
        public float eM21;
        public float eM22;
        public float eDx;
        public float eDy;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct DRAWTEXTPARAMS
    {
        public int cbSize;
        public int iTabLength;
        public int iLeftMargin;
        public int iRightMargin;
        public int uiLengthDrawn;
    };

    #region Unused
    /*
	public struct DEVMODE
	{
		public char dmDeviceName = new char[CCHDEVICENAME];
		public short dmSpecVersion;
		public short dmDriverVersion;
		public short dmSize;
		public short dmDriverExtra;
		public int dmFields;				
		public short dmOrientation;
		public short dmPaperSize;
		public short dmPaperLength;
		public short dmPaperWidth;		
		public PointAPI dmPosition;		
		public short dmScale;
		public short dmCopies;
		public short dmDefaultSource;
		public short dmPrintQuality;
		public short dmColor;
		public short dmDuplex;
		public short dmYResolution;
		public short dmTTOption;
		public short dmCollate;
		public char  dmFormName = new char[CCHFORMNAME];
		//     WORD   dmLogPixels;
		//     DWORD  dmBitsPerPel;
		//     DWORD  dmPelsWidth;
		//     DWORD  dmPelsHeight;
		//     DWORD  dmDisplayFlags;
		//     DWORD  dmDisplayFrequency;
		//     DWORD  dmICMMethod;
		//     DWORD  dmICMIntent;
		//     DWORD  dmMediaType;
		//     DWORD  dmDitherType;
		//     DWORD  dmReserved1;
		//     DWORD  dmReserved2;
		//     DWORD  dmPanningWidth;
		//     DWORD  dmPanningHeight;
		// } DEVMODEA, *PDEVMODEA, *NPDEVMODEA, *LPDEVMODEA;
		// *****************************

		// *****************************
		// * Nested elements not supported
		// *****************************
		// typedef struct _devicemodeW {
		//     WCHAR  dmDeviceName[CCHDEVICENAME];
		//     WORD dmSpecVersion;
		//     WORD dmDriverVersion;
		//     WORD dmSize;
		//     WORD dmDriverExtra;
		//     DWORD dmFields;
		//     union {
		//       struct {
		//         short dmOrientation;
		//         short dmPaperSize;
		//         short dmPaperLength;
		//         short dmPaperWidth;
		//       };
		//       POINTL dmPosition;
		//     };
		//     short dmScale;
		//     short dmCopies;
		//     short dmDefaultSource;
		//     short dmPrintQuality;
		//     short dmColor;
		//     short dmDuplex;
		//     short dmYResolution;
		//     short dmTTOption;
		//     short dmCollate;
		//     WCHAR  dmFormName[CCHFORMNAME];
		//     WORD   dmLogPixels;
		//     DWORD  dmBitsPerPel;
		//     DWORD  dmPelsWidth;
		//     DWORD  dmPelsHeight;
		//     DWORD  dmDisplayFlags;
		//     DWORD  dmDisplayFrequency;
		//     DWORD  dmICMMethod;
		//     DWORD  dmICMIntent;
		//     DWORD  dmMediaType;
		//     DWORD  dmDitherType;
		//     DWORD  dmReserved1;
		//     DWORD  dmReserved2;
		//     DWORD  dmPanningWidth;
		//     DWORD  dmPanningHeight;
	}*/
    #endregion

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public class LOGFONT
    {
        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public int lfWeight;
        public byte lfItalic;
        public byte lfUnderline;
        public byte lfStrikeOut;
        public byte lfCharSet;
        public byte lfOutPrecision;
        public byte lfClipPrecision;
        public byte lfQuality;
        public byte lfPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = WinAPI.LF_FACESIZE)]
        public char[] lfFaceName = new char[WinAPI.LF_FACESIZE];
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    public struct TEXTMETRIC
    {
        public int tmHeight;
        public int tmAscent;
        public int tmDescent;
        public int tmInternalLeading;
        public int tmExternalLeading;
        public int tmAveCharWidth;
        public int tmMaxCharWidth;
        public int tmWeight;
        public int tmOverhang;
        public int tmDigitizedAspectX;
        public int tmDigitizedAspectY;
        public byte tmFirstChar;
        public byte tmLastChar;
        public byte tmDefaultChar;
        public byte tmBreakChar;
        public byte tmItalic;
        public byte tmUnderlined;
        public byte tmStruckOut;
        public byte tmPitchAndFamily;
        public byte tmCharSet;
    };

    #endregion

    #region Win32 Hook Enumerations

    public enum HookProcType
    {
        WH_MIN = -1,
        WH_MSGFILTER = -1,
        WH_JOURNALRECORD = 0,
        WH_JOURNALPLAYBACK = 1,
        WH_KEYBOARD = 2,
        WH_GETMESSAGE = 3,
        WH_CALLWNDPROC = 4,
        WH_CBT = 5,
        WH_SYSMSGFILTER = 6,
        WH_MOUSE = 7,
        WH_HARDWARE = 8,
        WH_DEBUG = 9,
        WH_SHELL = 10,
        WH_FOREGROUNDIDLE = 11,
        WH_CALLWNDPROCRET = 12,
        WH_KEYBOARD_LL = 13,
        WH_MOUSE_LL = 14,
        WH_MAX3 = 14,
        WH_MAX2 = 12,
        WH_MAX = 11,
        WH_MINHOOK = WH_MIN,
        WH_MAXHOOK = WH_MAX,
    }

    public enum HC
    {
        HC_ACTION = 0,
        HC_GETNEXT = 1,
        HC_SKIP = 2,
        HC_NOREMOVE = 3,
        HC_NOREM = HC_NOREMOVE,
        HC_SYSMODALON = 4,
        HC_SYSMODALOFF = 5,
    }

    #endregion

    #region Win32 Error Enumerations

    public enum FORMAT
    {
        FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100,
        FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200,
        FORMAT_MESSAGE_FROM_STRING = 0x00000400,
        FORMAT_MESSAGE_FROM_HMODULE = 0x00000800,
        FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000,
        FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000,
        FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF,
    }
    #endregion

    #region Win32 Security-Related Structures

    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        public UInt32 nLength;
        public IntPtr lpSecurityDescriptor;
        public bool bInheritHandle;
    }

    #endregion

    /// <summary>
    /// Summary description for WinAPI.
    /// </summary>
    public class WinAPI
    {
        #region Win32 GDI Constants

        public const int CCHDEVICENAME = 32;
        public const int CCHFORMNAME = 32;

        public const int GM_ADVANCED = 2;
        public const int MWT_IDENTITY = 1;

        public const int ABSOLUTE = 1;
        public const int RELATIVE = 2;
        public const int WHITE_BRUSH = 0;
        public const int LTGRAY_BRUSH = 1;
        public const int GRAY_BRUSH = 2;
        public const int DKGRAY_BRUSH = 3;
        public const int BLACK_BRUSH = 4;
        public const int NULL_BRUSH = 5;
        public const int HOLLOW_BRUSH = NULL_BRUSH;
        public const int WHITE_PEN = 6;
        public const int BLACK_PEN = 7;
        public const int NULL_PEN = 8;
        public const int OEM_FIXED_FONT = 10;
        public const int SYSTEM_FONT = 13;
        public const int DEVICE_DEFAULT_FONT = 14;
        public const int DEFAULT_PALETTE = 15;
        public const int SYSTEM_FIXED_FONT = 16;
        public const int DEFAULT_GUI_FONT = 17;

        public const int TRANSPARENT = 1;
        public const int OPAQUE = 2;
        public const int BKMODE_LAST = 2;

        public const int BLACKONWHITE = 1;
        public const int WHITEONBLACK = 2;
        public const int COLORONCOLOR = 3;
        public const int HALFTONE = 4;

        public const int LF_FACESIZE = 32;
        public const int LF_FULLFACESIZE = 64;

        public const int DEFAULT_CHARSET = 1;

        #endregion

        #region Win32 Window Constants

        public const int SW_HIDE = 0;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_NORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_MAXIMIZE = 3;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_SHOW = 5;
        public const int SW_MINIMIZE = 6;
        public const int SW_SHOWMINNOACTIVE = 7;
        public const int SW_SHOWNA = 8;
        public const int SW_RESTORE = 9;
        public const int SW_SHOWDEFAULT = 10;
        public const int SW_FORCEMINIMIZE = 11;
        public const int SW_MAX = 11;

        public const int WS_EX_ACCEPTFILES = 0x10;
        public const int WS_EX_APPWINDOW = 0x40000;
        public const int WS_EX_CLIENTEDGE = 0x200;
        public const int WS_EX_CONTEXTHELP = 0x400;
        public const int WS_EX_CONTROLPARENT = 0x10000;
        public const int WS_EX_DLGMODALFRAME = 0x1;
        public const int WS_EX_LAYERED = 0x80000;
        public const int WS_EX_LAYOUTRTL = 0x400000;
        public const int WS_EX_LEFT = 0x0;
        public const int WS_EX_LEFTSCROLLBAR = 0x4000;
        public const int WS_EX_LTRREADING = 0x0;
        public const int WS_EX_MDICHILD = 0x40;
        public const int WS_EX_NOACTIVATE = 0x8000000;
        public const int WS_EX_NOINHERITLAYOUT = 0x100000;
        public const int WS_EX_NOPARENTNOTIFY = 0x4;
        public const int WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE);
        public const int WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST);
        public const int WS_EX_RIGHT = 0x1000;
        public const int WS_EX_RIGHTSCROLLBAR = 0x0;
        public const int WS_EX_RTLREADING = 0x2000;
        public const int WS_EX_STATICEDGE = 0x20000;
        public const int WS_EX_TOOLWINDOW = 0x80;
        public const int WS_EX_TOPMOST = 0x8;
        public const int WS_EX_TRANSPARENT = 0x20;
        public const int WS_EX_WINDOWEDGE = 0x100;

        public const int GW_HWNDFIRST = 0;
        public const int GW_HWNDLAST = 1;
        public const int GW_HWNDNEXT = 2;
        public const int GW_HWNDPREV = 3;
        public const int GW_OWNER = 4;
        public const int GW_CHILD = 5;
        public const int GW_MAX = 5;
        public const int GW_ENABLEDPOPUP = 6;
        //public const int GW_MAX = 6;

        #endregion

        #region Win32 Delegates

        public delegate bool WindowEnumDelegate(IntPtr hwnd, int lParam);

        #endregion

        #region Win32 Proces/Thread Synchronization Constants

        public const UInt32 INFINITE = 0xFFFFFFFF;
        public const UInt32 WAIT_ABANDONED = 0x00000080;
        public const UInt32 WAIT_OBJECT_0 = 0x00000000;
        public const UInt32 WAIT_TIMEOUT = 0x00000102;

        #endregion

        private WinAPI()
        {

        }

        #region Win32 General Functions

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        [DllImport("user32.dll")]
        public static extern bool MessageBeep(BeepType beepType);

        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

        #endregion

        #region Win32 Memory Functions

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GlobalFree(IntPtr hMem);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern int GlobalFlags(IntPtr hMem);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GlobalHandle(ref Byte[] pMem);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern string lstrcpyW(string lpString1, string lpString2);

        #endregion

        #region Win32 Window/Message Functions

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SendMessageW(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int PostMessageW(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SetActiveWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowW(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowW(IntPtr lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowExW(IntPtr param0, IntPtr param1, string param2, string param3);

        [DllImport("user32.dll")]
        public static extern int EnumChildWindows(IntPtr hwnd, WindowEnumDelegate del, int lParam);

        public delegate int WndProcDelegate(IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// This helper static method is required because the 32-bit version of user32.dll does not contain this API
        /// (on any versions of Windows), so linking the method will fail at run-time. The bridge dispatches the request
        /// to the correct function (GetWindowLong in 32-bit mode and GetWindowLongPtr in 64-bit mode)
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="nIndex"></param>
        /// <param name="dwNewLong"></param>
        /// <returns></returns>
        public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, WndProcDelegate delWndProc)
        {
            
            if (IntPtr.Size == 8)
                return SetWindowLongPtr64(hWnd, nIndex, delWndProc);
            else
                return new IntPtr(SetWindowLong32(hWnd, nIndex, delWndProc));
        }

        /// <summary>
        /// This helper static method is required because the 32-bit version of user32.dll does not contain this API
        /// (on any versions of Windows), so linking the method will fail at run-time. The bridge dispatches the request
        /// to the correct function (GetWindowLong in 32-bit mode and GetWindowLongPtr in 64-bit mode)
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="nIndex"></param>
        /// <param name="dwNewLong"></param>
        /// <returns></returns>
        public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {            
            if (IntPtr.Size == 8)
                return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            else
                return new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
        }

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong32(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong32(IntPtr hWnd, int nIndex, WndProcDelegate delWndProc);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, WndProcDelegate delWndProc);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
        private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

        /// <summary>
        /// This static method is required because Win32 does not support GetWindowLongPtr directly
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size == 8)
                return GetWindowLongPtr64(hWnd, nIndex);
            else
                return GetWindowLongPtr32(hWnd, nIndex);
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetWindowPos(IntPtr hWnd, Win32API.HWND hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int CallWindowProcW(IntPtr lpPrevWndFunc, IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int DefWindowProcW(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int EnableWindow(IntPtr hWnd, int bEnable);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextW(IntPtr hWnd, string lpString, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr WindowFromPoint(System.Drawing.Point Point);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetWindow(IntPtr hWnd, int uCmd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetWindowRect(IntPtr hWnd, ref RECTAPI lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetClientRect(IntPtr hWnd, ref RECTAPI lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr SetFocus(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetTopWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int PeekMessageA(ref MSG lpMsg, IntPtr hWnd, int wMsgFilterMin, int wMsgFilterMax, int wRemoveMsg);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int UpdateWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int RedrawWindow(IntPtr hWnd, ref RECTAPI lprcUpdate, IntPtr hrgnUpdate, int flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int InvalidateRect(IntPtr hWnd, ref RECTAPI lpRect, int bErase);

        [DllImport("user32.dll")]
        public static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateMDIWindowA(string lpClassName, string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hInstance, int lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateMDIWindowW(string lpClassName, string lpWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hInstance, int lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        #endregion

        #region Win32 GDI Functions

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, uint flags);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateCompatibleDC(IntPtr param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateDCW(string param0, string param1, string param2, ref object param3);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int DeleteDC(IntPtr param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        //public static extern int GetDeviceCaps (IntPtr param0, int param1);
        public static extern int GetDeviceCaps(IntPtr param0, DeviceCapsConstants nIndex);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SaveDC(IntPtr param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int RestoreDC(IntPtr param0, int param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetViewportExtEx(IntPtr param0, int param1, int param2, ref System.Drawing.Size param3);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetViewportOrgEx(IntPtr param0, int param1, int param2, ref System.Drawing.Point param3);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int DPtoLP(IntPtr param0, ref System.Drawing.Point param1, int param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SelectObject(IntPtr param0, IntPtr param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int DeleteObject(IntPtr param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern uint GetObjectType(IntPtr h);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetObjectW(IntPtr param0, int param1, ref Byte[] param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetStockObject(int param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int ExtFloodFill(IntPtr param0, int param1, int param2, int param3, int param4);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int FloodFill(IntPtr param0, int param1, int param2, int param3);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetBkMode(IntPtr param0, int param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetBkColor(IntPtr param0, int param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int Rectangle(IntPtr param0, int param1, int param2, int param3, int param4);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadImageW(IntPtr param0, string param1, int param2, int param3, int param4, int param5);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CopyImage(IntPtr param0, int param1, int param2, int param3, int param4);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadBitmapW(IntPtr hInstance, string lpBitmapName);

        [DllImport("msimg32.dll", CharSet = CharSet.Unicode)]
        public static extern int AlphaBlend(IntPtr param0, int param1, int param2, int param3, int param4, IntPtr param5, int param6, int param7, int param8, int param9, BLENDFUNCTION param10);

        [DllImport("msimg32.dll", CharSet = CharSet.Unicode)]
        public static extern int TransparentBlt(IntPtr param0, int param1, int param2, int param3, int param4, IntPtr param5, int param6, int param7, int param8, int param9, int param10);

        [DllImport("msimg32.dll", CharSet = CharSet.Unicode)]
        public static extern int TransparentDIBits(IntPtr param0, int param1, int param2, int param3, int param4, ref IntPtr param5, ref BITMAPINFO param6, int param7, int param8, int param9, int param10, int param11, int param12);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int BitBlt(IntPtr param0, int param1, int param2, int param3, int param4, IntPtr param5, int param6, int param7, uint param8);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int StretchBlt(IntPtr param0, int param1, int param2, int param3, int param4, IntPtr param5, int param6, int param7, int param8, int param9, uint param10);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetStretchBltMode(IntPtr param0, int param1);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int EndPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateBitmap(int param0, int param1, int param2, int param3, ref IntPtr param4);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateBitmapIndirect(ref BITMAP param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr param0, int param1, int param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetBitmapDimensionEx(IntPtr param0, ref System.Drawing.Size param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetPixel(IntPtr param0, int param1, int param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateBrushIndirect(ref LOGBRUSH param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateDIBPatternBrush(IntPtr param0, int param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateDIBPatternBrushPt(ref IntPtr param0, int param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateHatchBrush(int param0, int param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreatePatternBrush(IntPtr param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateSolidBrush(int param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetBrushOrgEx(IntPtr param0, ref System.Drawing.Point param1);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetSysColorBrush(int nIndex);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int PatBlt(IntPtr param0, int param1, int param2, int param3, int param4, uint param5);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetBrushOrgEx(IntPtr param0, int param1, int param2, ref System.Drawing.Point param3);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreatePen(int param0, int param1, int param2);        

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetPolyFillMode(IntPtr param0);        

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int DrawTextA(IntPtr hDC, string lpString, int nCount, ref RECTAPI lpRect, int uFormat);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int DrawTextExA(IntPtr param0, string param1, int param2, ref System.Drawing.Rectangle param3, int param4, ref DRAWTEXTPARAMS param5);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetTextColor(IntPtr param0, int param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetTextAlign(IntPtr param0, int param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetTextJustification(IntPtr param0, int param1, int param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFontIndirectA(ref LOGFONT param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFontA(int param0, int param1, int param2, int param3, int param4, uint param5, uint param6, uint param7, uint param8, uint param9, uint param10, uint param11, uint param12, string param13);

        [DllImport("gdi32.dll", CharSet = CharSet.Ansi)]
        public static extern int TextOutA(IntPtr param0, int param1, int param2, string param3, int param4);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int ExtTextOutA(IntPtr param0, int param1, int param2, int param3, ref RECTAPI param4, string param5, int param6, ref int param7);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int TabbedTextOutA(IntPtr hDC, int X, int Y, string lpString, int nCount, int nTabPositions, IntPtr lpnTabStopPositions, int nTabOrigin);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetTextMetricsA(IntPtr param0, ref TEXTMETRIC param1);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

        #endregion

        #region GDI Region  Functions

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateRectRgn(int param0, int param1, int param2, int param3);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreatePolygonRgn(System.Drawing.Point[] lppt, int cPoints, int fnPolyFillMode);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern uint GetRegionData(IntPtr param0, uint param1, ref RGNDATA param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int GetRgnBox(IntPtr param0, ref RECTAPI param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int InvertRgn(IntPtr param0, IntPtr param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int PaintRgn(IntPtr param0, IntPtr param1);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int FillRgn(IntPtr param0, IntPtr param1, IntPtr param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetRectRgn(IntPtr param0, int param1, int param2, int param3, int param4);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int OffsetRgn(IntPtr param0, int param1, int param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateRectRgnIndirect(ref RECTAPI param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr ExtCreateRegion(ref XFORM param0, uint param1, ref RGNDATA param2);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateEllipticRgn(int param0, int param1, int param2, int param3);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateEllipticRgnIndirect(ref RECTAPI param0);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int CombineRgn(IntPtr param0, IntPtr param1, IntPtr param2, int param3);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern int FrameRgn(IntPtr param0, IntPtr param1, IntPtr param2, int param3, int param4);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]          
        public static extern bool PtInRegion(IntPtr hRgn, int X, int Y);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
        public static extern bool RectInRegion(IntPtr param0, ref System.Drawing.Rectangle param1);

        #endregion

        #region Win32 Cursor Functions

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string lpFileName);

        [DllImport("user32.dll")]
        public static extern bool DestroyCursor(IntPtr hCursor);

        #endregion

        #region Win32 Hook Functions

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SetWindowsHookExA(int idHook, IntPtr lpfn, IntPtr hmod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int CallNextHookEx(IntPtr hhk, int nCode, int wParam, int lParam);


        #endregion

        #region Win32 Clipboard Functions

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool CloseClipboard();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetClipboardData(uint format);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool IsClipboardFormatAvailable(uint format);

        public const uint CF_METAFILEPICT = 3;
        public const uint CF_ENHMETAFILE = 14;

        #endregion

        #region Win32 File Functions

        // Constants that we need in the function call
        public const int SHGFI_ICON = 0x100;
        public const int SHGFI_SMALLICON = 0x1;
        public const int SHGFI_LARGEICON = 0x0;

        // This structure will contain information about the file
        public struct SHFILEINFO
        {
            // Handle to the icon representing the file
            public IntPtr hIcon;
            // Index of the icon within the image list
            public int iIcon;
            // Various attributes of the file
            public uint dwAttributes;
            // Path to the file
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szDisplayName;
            // File type
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        [DllImport("Shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, uint uFlags);

        #endregion

        #region Win32 Atom Functions

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern ushort GlobalAddAtomA(string lpString);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern ushort GlobalAddAtomW(string lpString);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern int GlobalGetAtomNameA(ushort nAtom, string lpBuffer, int nSize);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern int GlobalGetAtomNameW(ushort nAtom, string lpBuffer, int nSize);

        [DllImport("kernel32.dll")]
        public static extern ushort GlobalDeleteAtom(ushort nAtom);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern ushort GlobalFindAtomA(string lpString);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern ushort GlobalFindAtomW(string lpString);

        #endregion

        #region Win32 Keyboard Constants, Structures and Functions

        [StructLayout(LayoutKind.Explicit)]
        internal struct INPUT
        {
            [FieldOffset(0)]
            internal INPUT_TYPE type;
            [FieldOffset(4)]
            internal MOUSEINPUT mi;
            [FieldOffset(4)]
            internal KEYBDINPUT ki;
            [FieldOffset(4)]
            internal HARDWAREINPUT hi;

            public static int Size
            {
                get { return Marshal.SizeOf(typeof(INPUT)); }
            }
        }

        // The unused private fields below are required to match the native structure layout.
#pragma warning disable 0169
        public struct KEYBDINPUT
        {
            public uint type;
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public uint dwExtraInfo;
            public uint unused1;
            public uint unused2;
        }
#pragma warning restore 0169

        [StructLayout(LayoutKind.Sequential)]
        internal struct HARDWAREINPUT
        {
            internal int uMsg;
            internal short wParamL;
            internal short wParamH;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MOUSEINPUT
        {
            internal int dx;
            internal int dy;
            internal int mouseData;
            internal int dwFlags;
            internal uint time;
            internal UIntPtr dwExtraInfo;
        }

        public enum INPUT_TYPE
        {
            INPUT_KEYBOARD = 1
        }

        public const uint KEYEVENTF_KEYUP = 2;
        public const ushort VK_TAB = 0x0009;
        public const ushort VK_SHIFT = 0x0010;
        public const ushort VK_CTRL = 0x0011;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern short GetAsyncKeyState(int vKey);

        /// <summary>
        /// Synthesizes keystrokes, mouse motions, and button clicks.
        /// </summary>
        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint cInputs, /* [MarshalAs(UnmanagedType.LPArray)] */ KEYBDINPUT[] inputs, int cbSize);

        [DllImport("user32.dll")]
        public static extern short VkKeyScan(char ch);

        public static int GetKeyboardCode(char val)
        {
            byte[] scan = BitConverter.GetBytes(WinAPI.VkKeyScan(val));
            return scan[0];
        }

        public enum KeyModifiers
        {
            Control = (ushort)VK.VK_CONTROL,
            Shift = (ushort)VK.VK_SHIFT,
            Alt = (ushort)VK.VK_MENU
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="hFocusWnd"></param>
        /// <param name="keys"></param>
        /// <param name="keyModifiers"></param>
        /// <returns></returns>
        public static uint SendKeyInput(IntPtr hFocusWnd, Keys[] keys, KeyModifiers[] keyModifiers = null)
        {
            try
            {

                int iKeyInputCount = keys.Length * 2;

                if (keyModifiers != null)
                    iKeyInputCount += (keyModifiers.Length * 2);

                WinAPI.KEYBDINPUT[] inputs = new WinAPI.KEYBDINPUT[iKeyInputCount];

                for (int i = 0; i < inputs.Length; i++)
                    inputs[i].type = (ushort)WinAPI.INPUT_TYPE.INPUT_KEYBOARD;

                int iCurIndex = 0;

                if (keyModifiers != null)
                {
                    for (int i = 0; i < keyModifiers.Length; i++)
                    {
                        inputs[iCurIndex].wVk = (ushort)keyModifiers[i];
                        iCurIndex++;
                    }//next i
                }//end if

                for (int i = 0; i < keys.Length; i++)
                {
                    /*
                    if ((keys[i] >= Keys.A && keys[i] <= Keys.Z) ||
                        keys[i] >= Keys.D0 && keys[i] < Keys.D9)
                        inputs[iCurIndex].wVk = (ushort)GetKeyboardCode((char)keys[i]);
                    else
                        inputs[iCurIndex].wVk = (ushort)keys[i];
                    */
                    inputs[iCurIndex].wVk = (ushort)keys[i];

                    iCurIndex++;
                }//next i

                for (int i = keys.Length - 1; i >= 0; i--)
                {
                    /*
                    if ((keys[i] >= Keys.A && keys[i] <= Keys.Z) ||
                        keys[i] >= Keys.D0 && keys[i] < Keys.D9)
                        inputs[iCurIndex].wVk = (ushort)GetKeyboardCode((char)keys[i]);
                    else
                        inputs[iCurIndex].wVk = (ushort)keys[i];
                    */
                    inputs[iCurIndex].wVk = (ushort)keys[i];

                    inputs[iCurIndex].dwFlags = (uint)WinAPI.KEYEVENTF_KEYUP;
                    iCurIndex++;
                }//next i

                if (keyModifiers != null)
                {
                    for (int i = keyModifiers.Length - 1; i >= 0; i--)
                    {
                        inputs[iCurIndex].wVk = (ushort)keyModifiers[i];
                        inputs[iCurIndex].dwFlags = (uint)WinAPI.KEYEVENTF_KEYUP;
                        iCurIndex++;
                    }//next i
                }//end if

                WinAPI.SetForegroundWindow(hFocusWnd);
                WinAPI.SetFocus(hFocusWnd);
                return WinAPI.SendInput((uint)inputs.Length, inputs, 0x001C);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in SendKeyInput functinon WinAPI class.");
                return 0;
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="hFocusWnd"></param>
        /// <param name="keys"></param>
        /// <param name="keyModifiers"></param>
        /// <returns></returns>
        public static uint SendKeyInput(IntPtr hFocusWnd, Keys key, KeyModifiers[] keyModifiers = null)
        {
            return SendKeyInput(hFocusWnd, new Keys[] { key }, keyModifiers);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="hFocusWNd"></param>
        /// <param name="keys"></param>
        /// <param name="keyModifiers"></param>
        /// <returns></returns>
        public static uint SendKeyInput(IntPtr hFocusWnd, Keys key, KeyModifiers keyModifier)
        {
            return SendKeyInput(hFocusWnd, new Keys[] { key }, new KeyModifiers[] { keyModifier });
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="ctlFocus"></param>
        /// <param name="keys"></param>
        /// <param name="keyModifiers"></param>
        /// <returns></returns>
        public static uint SendKeyInput(Control ctlFocus, Keys[] keys, KeyModifiers[] keyModifiers = null)
        {
            try
            {

                int iKeyInputCount = keys.Length * 2;

                if (keyModifiers != null)
                    iKeyInputCount += (keyModifiers.Length * 2);

                WinAPI.KEYBDINPUT[] inputs = new WinAPI.KEYBDINPUT[iKeyInputCount];

                for (int i = 0; i < inputs.Length; i++)
                    inputs[i].type = (ushort)WinAPI.INPUT_TYPE.INPUT_KEYBOARD;

                int iCurIndex = 0;

                if (keyModifiers != null)
                {
                    for (int i = 0; i < keyModifiers.Length; i++)
                    {
                        inputs[iCurIndex].wVk = (ushort)keyModifiers[i];
                        iCurIndex++;
                    }//next i
                }//end if

                for (int i = 0; i < keys.Length; i++)
                {
                    /*
                    if ((keys[i] >= Keys.A && keys[i] <= Keys.Z) ||
                        keys[i] >= Keys.D0 && keys[i] < Keys.D9)
                        inputs[iCurIndex].wVk = (ushort)GetKeyboardCode((char)keys[i]);
                    else
                        inputs[iCurIndex].wVk = (ushort)keys[i];
                    */
                    inputs[iCurIndex].wVk = (ushort)keys[i];

                    iCurIndex++;
                }//next i

                for (int i = keys.Length - 1; i >= 0; i--)
                {
                    /*
                    if ((keys[i] >= Keys.A && keys[i] <= Keys.Z) ||
                        keys[i] >= Keys.D0 && keys[i] < Keys.D9)
                        inputs[iCurIndex].wVk = (ushort)GetKeyboardCode((char)keys[i]);
                    else
                        inputs[iCurIndex].wVk = (ushort)keys[i];
                    */
                    inputs[iCurIndex].wVk = (ushort)keys[i];

                    inputs[iCurIndex].dwFlags = (uint)WinAPI.KEYEVENTF_KEYUP;
                    iCurIndex++;
                }//next i

                if (keyModifiers != null)
                {
                    for (int i = keyModifiers.Length - 1; i >= 0; i--)
                    {
                        inputs[iCurIndex].wVk = (ushort)keyModifiers[i];
                        inputs[iCurIndex].dwFlags = (uint)WinAPI.KEYEVENTF_KEYUP;
                        iCurIndex++;
                    }//next i
                }//end if

                WinAPI.SetForegroundWindow(ctlFocus.Handle);
                ctlFocus.Focus();
                return WinAPI.SendInput((uint)inputs.Length, inputs, 0x001C);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in SendKeyInput functinon WinAPI class.");
                return 0;
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="ctlFocus"></param>
        /// <param name="keys"></param>
        /// <param name="keyModifiers"></param>
        /// <returns></returns>
        public static uint SendKeyInput(Control ctlFocus, Keys key, KeyModifiers[] keyModifiers = null)
        {
            return SendKeyInput(ctlFocus, new Keys[] { key }, keyModifiers);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="ctlFocus"></param>
        /// <param name="keys"></param>
        /// <param name="keyModifiers"></param>
        /// <returns></returns>
        public static uint SendKeyInput(Control ctlFocus, Keys key, KeyModifiers keyModifier)
        {
            return SendKeyInput(ctlFocus, new Keys[] { key }, new KeyModifiers[] { keyModifier });
        }

        #endregion

        #region Win32 Hot Key Constants, Structures, Functions
        
        public static int MOD_ALT = 0x1;
        public static int MOD_CONTROL = 0x2;
        public static int MOD_SHIFT = 0x4;
        public static int MOD_WIN = 0x8;        

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
        public static int RegisterHotKey(Form form, Keys key)
        {
            try
            {
                int modifiers = 0;

                if ((key & Keys.Alt) == Keys.Alt)
                    modifiers = modifiers | MOD_ALT;

                if ((key & Keys.Control) == Keys.Control)
                    modifiers = modifiers | MOD_CONTROL;

                if ((key & Keys.Shift) == Keys.Shift)
                    modifiers = modifiers | MOD_SHIFT;

                Keys k = key & ~Keys.Control & ~Keys.Shift & ~Keys.Alt;

                //This should be a key unique ID, modify this if you want more than one hotkey
                int iKeyId = form.GetHashCode();

                RegisterHotKey(form.Handle, iKeyId, (uint)modifiers, (uint)k);

                return iKeyId;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in RegisterHotKey function of Win32API class.");
                return -1;
            }
        }

        public static void UnregisterHotKey(Form form, int iKeyId)
        {
            try
            {
                UnregisterHotKey(form.Handle, iKeyId);
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in UnregisterHotKey function of Win32API class.");
            }
        }

        #endregion

        #region Win32 Error Functions

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern uint FormatMessageA(uint dwFlags, ref Byte[] lpSource, uint dwMessageId, uint dwLanguageId, string lpBuffer, uint nSize, IntPtr Arguments);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern uint GetLastError();

        public static string WinAPIError(int lLastDLLError)
        {
            string sBuff = "";
            uint lCount;
            byte[] lpSource = null;

            //Return the error message associated with LastDLLError:
            sBuff.PadRight(256, (char)0);
            lCount = WinAPI.FormatMessageA((uint)FORMAT.FORMAT_MESSAGE_FROM_SYSTEM | (uint)FORMAT.FORMAT_MESSAGE_IGNORE_INSERTS, ref lpSource,
                                    (uint)lLastDLLError, 0, sBuff, (uint)sBuff.Length, System.IntPtr.Zero);

            if (lCount != 0)
                return sBuff.Substring(0, (int)lCount);
            else
                return "";
        }

        #endregion

        #region Win32 Word Data Type Reading/Writing Functions

        public static int HiWord(int number)
        {
            if ((number & 0x80000000) == 0x80000000)
                return (number >> 16);
            else
                return (number >> 16) & 0xffff;
        }

        public static int LoWord(int number)
        {
            return number & 0xffff;
        }

        public static int MakeLong(int LoWord, int HiWord)
        {
            return (HiWord << 16) | (LoWord & 0xffff);
        }

        public static IntPtr MakeLParam(int LoWord, int HiWord)
        {
            return (IntPtr)((HiWord << 16) | (LoWord & 0xffff));
        }

        #endregion

        #region Win32 Process/Thread Functions

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        // When you don't want the ProcessId, use this overload and pass IntPtr.Zero for the second parameter
        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        #endregion

        #region Win32 Process/Thread Synchronization Functions

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateEvent(SECURITY_ATTRIBUTES lpSecurityAttributes, bool isManualReset, bool initialState, string name);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateEvent(IntPtr lpSecurityAttributes, bool isManualReset, bool initialState, string name);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr OpenEvent(int desiredAccess, bool inheritHandle, string name);

        [DllImport("kernel32.dll")]
        public static extern bool SetEvent(IntPtr hEvent);

        [DllImport("kernel32.dll")]
        public static extern bool ResetEvent(IntPtr hEvent);

        #endregion
    }
}
