

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 8.01.0622 */
/* at Tue Jan 19 06:14:07 2038
 */
/* Compiler settings for D:\ue4\DotUnrealExample\Plugins\UnrealDotNet\Source\UnrealDotNetRuntime\Public\inc\MSCOREE.IDL:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.01.0622 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        EXTERN_C __declspec(selectany) const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif // !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, IID_IDebuggerThreadControl,0x23D86786,0x0BB5,0x4774,0x8F,0xB5,0xE3,0x52,0x2A,0xDD,0x62,0x46);


MIDL_DEFINE_GUID(IID, IID_IDebuggerInfo,0xBF24142D,0xA47D,0x4d24,0xA6,0x6D,0x8C,0x21,0x41,0x94,0x4E,0x44);


MIDL_DEFINE_GUID(IID, IID_ICLRPolicyManager,0x7D290010,0xD781,0x45da,0xA6,0xF8,0xAA,0x5D,0x71,0x1A,0x73,0x0E);


MIDL_DEFINE_GUID(IID, IID_IHostControl,0x02CA073C,0x7079,0x4860,0x88,0x0A,0xC2,0xF7,0xA4,0x49,0xC9,0x91);


MIDL_DEFINE_GUID(IID, IID_ICLRControl,0x9065597E,0xD1A1,0x4fb2,0xB6,0xBA,0x7E,0x1F,0xCE,0x23,0x0F,0x61);


MIDL_DEFINE_GUID(IID, IID_ICLRRuntimeHost,0x90F1A06C,0x7712,0x4762,0x86,0xB5,0x7A,0x5E,0xBA,0x6B,0xDB,0x02);


MIDL_DEFINE_GUID(IID, IID_ICLRRuntimeHost2,0x712AB73F,0x2C22,0x4807,0xAD,0x7E,0xF5,0x01,0xD7,0xB7,0x2C,0x2D);


MIDL_DEFINE_GUID(IID, IID_ICLRRuntimeHost4,0x64F6D366,0xD7C2,0x4F1F,0xB4,0xB2,0xE8,0x16,0x0C,0xAC,0x43,0xAF);


MIDL_DEFINE_GUID(IID, IID_ICLRExecutionManager,0x1000A3E7,0xB420,0x4620,0xAE,0x30,0xFB,0x19,0xB5,0x87,0xAD,0x1D);


MIDL_DEFINE_GUID(IID, LIBID_mscoree,0x5477469e,0x83b1,0x11d2,0x8b,0x49,0x00,0xa0,0xc9,0xb7,0xc9,0xc4);


MIDL_DEFINE_GUID(IID, IID_ITypeName,0xB81FF171,0x20F3,0x11d2,0x8D,0xCC,0x00,0xA0,0xC9,0xB0,0x05,0x22);


MIDL_DEFINE_GUID(IID, IID_ITypeNameBuilder,0xB81FF171,0x20F3,0x11d2,0x8D,0xCC,0x00,0xA0,0xC9,0xB0,0x05,0x23);


MIDL_DEFINE_GUID(IID, IID_ITypeNameFactory,0xB81FF171,0x20F3,0x11d2,0x8D,0xCC,0x00,0xA0,0xC9,0xB0,0x05,0x21);


MIDL_DEFINE_GUID(CLSID, CLSID_CLRRuntimeHost,0x90F1A06E,0x7712,0x4762,0x86,0xB5,0x7A,0x5E,0xBA,0x6B,0xDB,0x02);


MIDL_DEFINE_GUID(CLSID, CLSID_TypeNameFactory,0xB81FF171,0x20F3,0x11d2,0x8D,0xCC,0x00,0xA0,0xC9,0xB0,0x05,0x25);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif



