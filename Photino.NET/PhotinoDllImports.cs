using System.Runtime.InteropServices;

#if false
using System.Runtime.InteropServices.Marshalling;
#endif

namespace Photino.NET;

public partial class PhotinoWindow
{
    private const string DLL_NAME = "Photino.Native";

    //REGISTER

#if NET7_0_OR_GREATER
    
    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial IntPtr Photino_register_win32(IntPtr hInstance);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial IntPtr Photino_register_mac();

#else
    
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern IntPtr Photino_register_win32(IntPtr hInstance);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern IntPtr Photino_register_mac(); 

#endif


    //CTOR-DTOR

#if false
    // TODO: Check why in the native part it says received 0 bytes

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial IntPtr Photino_ctor([MarshalUsing(typeof(PhotinoNativeParametersMarshaller))]ref PhotinoNativeParameters parameters);
    //necessary? - [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)] static extern void Photino_dtor(IntPtr instance);  

#else

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern IntPtr Photino_ctor(ref PhotinoNativeParameters parameters);
    //necessary? - [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)] static extern void Photino_dtor(IntPtr instance);  

#endif


#if NET7_0_OR_GREATER
    
    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_AddCustomSchemeName(IntPtr instance, string scheme);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_Close(IntPtr instance);

#else
    
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_AddCustomSchemeName(IntPtr instance, string scheme);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_Close(IntPtr instance); 

#endif


    //GET
#if NET7_0_OR_GREATER

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial IntPtr Photino_getHwnd_win32(IntPtr instance);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_GetAllMonitors(IntPtr instance, CppGetAllMonitorsDelegate callback);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetContextMenuEnabled(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] out bool enabled);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetDevToolsEnabled(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] out bool enabled);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetFullScreen(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] out bool fullScreen);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetGrantBrowserPermissions(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] out bool grant);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetPosition(IntPtr instance, out int x, out int y);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetResizable(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] out bool resizable);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial uint Photino_GetScreenDpi(IntPtr instance);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetSize(IntPtr instance, out int width, out int height);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial IntPtr Photino_GetTitle(IntPtr instance);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetTopmost(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] out bool topmost);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetZoom(IntPtr instance, out int zoom);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetMaximized(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] out bool maximized);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    private static partial void Photino_GetMinimized(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] out bool minimized);

#else

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern IntPtr Photino_getHwnd_win32(IntPtr instance);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetAllMonitors(IntPtr instance, CppGetAllMonitorsDelegate callback);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetContextMenuEnabled(IntPtr instance, out bool enabled);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetDevToolsEnabled(IntPtr instance, out bool enabled);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetFullScreen(IntPtr instance, out bool fullScreen);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetGrantBrowserPermissions(IntPtr instance, out bool grant);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetPosition(IntPtr instance, out int x, out int y);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetResizable(IntPtr instance, out bool resizable);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern uint Photino_GetScreenDpi(IntPtr instance);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetSize(IntPtr instance, out int width, out int height);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern IntPtr Photino_GetTitle(IntPtr instance);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetTopmost(IntPtr instance, out bool topmost);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetZoom(IntPtr instance, out int zoom);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetMaximized(IntPtr instance, out bool maximized);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_GetMinimized(IntPtr instance, out bool minimized); 

#endif


    //MARSHAL CALLS FROM Non-UI Thread to UI Thread
#if NET7_0_OR_GREATER

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_Invoke(IntPtr instance, InvokeCallback callback);

#else

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_Invoke(IntPtr instance, InvokeCallback callback); 

#endif


    //NAVIGATE
#if NET7_0_OR_GREATER

    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_NavigateToString(IntPtr instance, string content);

    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_NavigateToUrl(IntPtr instance, string url);

#else

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_NavigateToString(IntPtr instance, string content);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_NavigateToUrl(IntPtr instance, string url);

#endif


    //SET
#if NET7_0_OR_GREATER

    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_setWebView2RuntimePath_win32(IntPtr instance, string webView2RuntimePath);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetContextMenuEnabled(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool enabled);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetDevToolsEnabled(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool enabled);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetFullScreen(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool fullScreen);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetGrantBrowserPermissions(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool grant);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetMaximized(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool maximized);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetMinimized(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool minimized);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetResizable(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool resizable);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetPosition(IntPtr instance, int x, int y);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetSize(IntPtr instance, int width, int height);

    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetTitle(IntPtr instance, string title);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetTopmost(IntPtr instance, int topmost);

    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetIconFile(IntPtr instance, string filename);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SetZoom(IntPtr instance, int zoom);

#else

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_setWebView2RuntimePath_win32(IntPtr instance, string webView2RuntimePath);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetContextMenuEnabled(IntPtr instance, bool enabled);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetDevToolsEnabled(IntPtr instance, bool enabled);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetFullScreen(IntPtr instance, bool fullScreen);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetGrantBrowserPermissions(IntPtr instance, bool grant);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetMaximized(IntPtr instance, bool maximized);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetMinimized(IntPtr instance, bool minimized);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetResizable(IntPtr instance, bool resizable);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetPosition(IntPtr instance, int x, int y);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetSize(IntPtr instance, int width, int height);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_SetTitle(IntPtr instance, string title);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetTopmost(IntPtr instance, int topmost);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_SetIconFile(IntPtr instance, string filename);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_SetZoom(IntPtr instance, int zoom); 

#endif


    //MISC
#if NET7_0_OR_GREATER

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_Center(IntPtr instance);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_ClearBrowserAutoFill(IntPtr instance);

    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_SendWebMessage(IntPtr instance, string message);

    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_ShowMessage(IntPtr instance, string title, string body, uint type);

    [LibraryImport(DLL_NAME, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_ShowNotification(IntPtr instance, string title, string body);

    [LibraryImport(DLL_NAME, SetLastError = true)]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    static partial void Photino_WaitForExit(IntPtr instance);

#else

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_Center(IntPtr instance);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_ClearBrowserAutoFill(IntPtr instance);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_SendWebMessage(IntPtr instance, string message);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_ShowMessage(IntPtr instance, string title, string body, uint type);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Auto)] static extern void Photino_ShowNotification(IntPtr instance, string title, string body);
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)] static extern void Photino_WaitForExit(IntPtr instance); 

#endif
}
