

/* this ALWAYS GENERATED file contains the proxy stub code */


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

#if !defined(_M_IA64) && !defined(_M_AMD64) && !defined(_ARM_)


#pragma warning( disable: 4049 )  /* more than 64k source lines */
#if _MSC_VER >= 1200
#pragma warning(push)
#endif

#pragma warning( disable: 4211 )  /* redefine extern to static */
#pragma warning( disable: 4232 )  /* dllimport identity*/
#pragma warning( disable: 4024 )  /* array to pointer mapping*/
#pragma warning( disable: 4152 )  /* function/data pointer conversion in expression */
#pragma warning( disable: 4100 ) /* unreferenced arguments in x86 call */

#pragma optimize("", off ) 

#define USE_STUBLESS_PROXY


/* verify that the <rpcproxy.h> version is high enough to compile this file*/
#ifndef __REDQ_RPCPROXY_H_VERSION__
#define __REQUIRED_RPCPROXY_H_VERSION__ 475
#endif


#include "rpcproxy.h"
#ifndef __RPCPROXY_H_VERSION__
#error this stub requires an updated version of <rpcproxy.h>
#endif /* __RPCPROXY_H_VERSION__ */


#include "MSCOREE.h"

#define TYPE_FORMAT_STRING_SIZE   3                                 
#define PROC_FORMAT_STRING_SIZE   1                                 
#define EXPR_FORMAT_STRING_SIZE   1                                 
#define TRANSMIT_AS_TABLE_SIZE    0            
#define WIRE_MARSHAL_TABLE_SIZE   0            

typedef struct _MSCOREE_MIDL_TYPE_FORMAT_STRING
    {
    short          Pad;
    unsigned char  Format[ TYPE_FORMAT_STRING_SIZE ];
    } MSCOREE_MIDL_TYPE_FORMAT_STRING;

typedef struct _MSCOREE_MIDL_PROC_FORMAT_STRING
    {
    short          Pad;
    unsigned char  Format[ PROC_FORMAT_STRING_SIZE ];
    } MSCOREE_MIDL_PROC_FORMAT_STRING;

typedef struct _MSCOREE_MIDL_EXPR_FORMAT_STRING
    {
    long          Pad;
    unsigned char  Format[ EXPR_FORMAT_STRING_SIZE ];
    } MSCOREE_MIDL_EXPR_FORMAT_STRING;


static const RPC_SYNTAX_IDENTIFIER  _RpcTransferSyntax = 
{{0x8A885D04,0x1CEB,0x11C9,{0x9F,0xE8,0x08,0x00,0x2B,0x10,0x48,0x60}},{2,0}};


extern const MSCOREE_MIDL_TYPE_FORMAT_STRING MSCOREE__MIDL_TypeFormatString;
extern const MSCOREE_MIDL_PROC_FORMAT_STRING MSCOREE__MIDL_ProcFormatString;
extern const MSCOREE_MIDL_EXPR_FORMAT_STRING MSCOREE__MIDL_ExprFormatString;



#if !defined(__RPC_WIN32__)
#error  Invalid build platform for this stub.
#endif

#if !(TARGET_IS_NT50_OR_LATER)
#error You need Windows 2000 or later to run this stub because it uses these features:
#error   /robust command line switch.
#error However, your C/C++ compilation flags indicate you intend to run this app on earlier systems.
#error This app will fail with the RPC_X_WRONG_STUB_VERSION error.
#endif


static const MSCOREE_MIDL_PROC_FORMAT_STRING MSCOREE__MIDL_ProcFormatString =
    {
        0,
        {

			0x0
        }
    };

static const MSCOREE_MIDL_TYPE_FORMAT_STRING MSCOREE__MIDL_TypeFormatString =
    {
        0,
        {
			NdrFcShort( 0x0 ),	/* 0 */

			0x0
        }
    };


/* Standard interface: __MIDL_itf_MSCOREE_0000_0000, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: IUnknown, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x46}} */


/* Object interface: IDebuggerThreadControl, ver. 1.0,
   GUID={0x23D86786,0x0BB5,0x4774,{0x8F,0xB5,0xE3,0x52,0x2A,0xDD,0x62,0x46}} */


/* Standard interface: __MIDL_itf_MSCOREE_0000_0001, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: IDebuggerInfo, ver. 1.0,
   GUID={0xBF24142D,0xA47D,0x4d24,{0xA6,0x6D,0x8C,0x21,0x41,0x94,0x4E,0x44}} */


/* Standard interface: __MIDL_itf_MSCOREE_0000_0002, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: ICLRPolicyManager, ver. 1.0,
   GUID={0x7D290010,0xD781,0x45da,{0xA6,0xF8,0xAA,0x5D,0x71,0x1A,0x73,0x0E}} */


/* Standard interface: __MIDL_itf_MSCOREE_0000_0003, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: IHostControl, ver. 1.0,
   GUID={0x02CA073C,0x7079,0x4860,{0x88,0x0A,0xC2,0xF7,0xA4,0x49,0xC9,0x91}} */


/* Standard interface: __MIDL_itf_MSCOREE_0000_0004, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: ICLRControl, ver. 1.0,
   GUID={0x9065597E,0xD1A1,0x4fb2,{0xB6,0xBA,0x7E,0x1F,0xCE,0x23,0x0F,0x61}} */


/* Object interface: ICLRRuntimeHost, ver. 1.0,
   GUID={0x90F1A06C,0x7712,0x4762,{0x86,0xB5,0x7A,0x5E,0xBA,0x6B,0xDB,0x02}} */


/* Standard interface: __MIDL_itf_MSCOREE_0000_0006, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: ICLRRuntimeHost2, ver. 2.0,
   GUID={0x712AB73F,0x2C22,0x4807,{0xAD,0x7E,0xF5,0x01,0xD7,0xB7,0x2C,0x2D}} */


/* Object interface: ICLRRuntimeHost4, ver. 4.0,
   GUID={0x64F6D366,0xD7C2,0x4F1F,{0xB4,0xB2,0xE8,0x16,0x0C,0xAC,0x43,0xAF}} */


/* Object interface: ICLRExecutionManager, ver. 1.0,
   GUID={0x1000A3E7,0xB420,0x4620,{0xAE,0x30,0xFB,0x19,0xB5,0x87,0xAD,0x1D}} */


/* Standard interface: __MIDL_itf_MSCOREE_0000_0009, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Standard interface: __MIDL_itf_MSCOREE_0000_0010, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */

static const MIDL_STUB_DESC Object_StubDesc = 
    {
    0,
    NdrOleAllocate,
    NdrOleFree,
    0,
    0,
    0,
    0,
    0,
    MSCOREE__MIDL_TypeFormatString.Format,
    1, /* -error bounds_check flag */
    0x50002, /* Ndr library version */
    0,
    0x801026e, /* MIDL Version 8.1.622 */
    0,
    0,
    0,  /* notify & notify_flag routine table */
    0x1, /* MIDL flag */
    0, /* cs routines */
    0,   /* proxy/server info */
    0
    };

const CInterfaceProxyVtbl * const _MSCOREE_ProxyVtblList[] = 
{
    0
};

const CInterfaceStubVtbl * const _MSCOREE_StubVtblList[] = 
{
    0
};

PCInterfaceName const _MSCOREE_InterfaceNamesList[] = 
{
    0
};


#define _MSCOREE_CHECK_IID(n)	IID_GENERIC_CHECK_IID( _MSCOREE, pIID, n)

int __stdcall _MSCOREE_IID_Lookup( const IID * pIID, int * pIndex )
{
    UNREFERENCED_PARAMETER(pIID);
    UNREFERENCED_PARAMETER(pIndex);
    return 0;
}

const ExtendedProxyFileInfo MSCOREE_ProxyFileInfo = 
{
    (PCInterfaceProxyVtblList *) & _MSCOREE_ProxyVtblList,
    (PCInterfaceStubVtblList *) & _MSCOREE_StubVtblList,
    (const PCInterfaceName * ) & _MSCOREE_InterfaceNamesList,
    0, /* no delegation */
    & _MSCOREE_IID_Lookup, 
    0,
    2,
    0, /* table of [async_uuid] interfaces */
    0, /* Filler1 */
    0, /* Filler2 */
    0  /* Filler3 */
};
#if _MSC_VER >= 1200
#pragma warning(pop)
#endif


#endif /* !defined(_M_IA64) && !defined(_M_AMD64) && !defined(_ARM_) */

