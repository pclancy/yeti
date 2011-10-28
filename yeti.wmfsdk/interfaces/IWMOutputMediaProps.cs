using System;
using System.Runtime.InteropServices;
using System.Text;
using yeti.wma.structs;

namespace yeti.wma.interfaces
{
    [ComImport]
    [Guid("96406BD7-2B2B-11d3-B36B-00C04F6108FF")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWMOutputMediaProps : IWMMediaProps
    {
        //IWMMediaProps
        new void GetType([Out] out Guid pguidType);
        new void GetMediaType( /*[out] WM_MEDIA_TYPE* */ IntPtr pType,
                                                         [In, Out] ref uint pcbType);
        new void SetMediaType([In] ref WM_MEDIA_TYPE pType);
        //IWMOutputMediaProps    
        void GetStreamGroupName([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszName,
                                [In, Out] ref ushort pcchName);

        void GetConnectionName([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszName,
                               [In, Out] ref ushort pcchName);
    }
}