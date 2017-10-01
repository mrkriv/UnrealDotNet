

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


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


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif /* __RPCNDR_H_VERSION__ */

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __MSCOREE_h__
#define __MSCOREE_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IDebuggerThreadControl_FWD_DEFINED__
#define __IDebuggerThreadControl_FWD_DEFINED__
typedef interface IDebuggerThreadControl IDebuggerThreadControl;

#endif 	/* __IDebuggerThreadControl_FWD_DEFINED__ */


#ifndef __IDebuggerInfo_FWD_DEFINED__
#define __IDebuggerInfo_FWD_DEFINED__
typedef interface IDebuggerInfo IDebuggerInfo;

#endif 	/* __IDebuggerInfo_FWD_DEFINED__ */


#ifndef __ICLRPolicyManager_FWD_DEFINED__
#define __ICLRPolicyManager_FWD_DEFINED__
typedef interface ICLRPolicyManager ICLRPolicyManager;

#endif 	/* __ICLRPolicyManager_FWD_DEFINED__ */


#ifndef __IHostControl_FWD_DEFINED__
#define __IHostControl_FWD_DEFINED__
typedef interface IHostControl IHostControl;

#endif 	/* __IHostControl_FWD_DEFINED__ */


#ifndef __ICLRControl_FWD_DEFINED__
#define __ICLRControl_FWD_DEFINED__
typedef interface ICLRControl ICLRControl;

#endif 	/* __ICLRControl_FWD_DEFINED__ */


#ifndef __ICLRRuntimeHost_FWD_DEFINED__
#define __ICLRRuntimeHost_FWD_DEFINED__
typedef interface ICLRRuntimeHost ICLRRuntimeHost;

#endif 	/* __ICLRRuntimeHost_FWD_DEFINED__ */


#ifndef __ICLRRuntimeHost2_FWD_DEFINED__
#define __ICLRRuntimeHost2_FWD_DEFINED__
typedef interface ICLRRuntimeHost2 ICLRRuntimeHost2;

#endif 	/* __ICLRRuntimeHost2_FWD_DEFINED__ */


#ifndef __ICLRRuntimeHost4_FWD_DEFINED__
#define __ICLRRuntimeHost4_FWD_DEFINED__
typedef interface ICLRRuntimeHost4 ICLRRuntimeHost4;

#endif 	/* __ICLRRuntimeHost4_FWD_DEFINED__ */


#ifndef __ICLRExecutionManager_FWD_DEFINED__
#define __ICLRExecutionManager_FWD_DEFINED__
typedef interface ICLRExecutionManager ICLRExecutionManager;

#endif 	/* __ICLRExecutionManager_FWD_DEFINED__ */


#ifndef __ITypeName_FWD_DEFINED__
#define __ITypeName_FWD_DEFINED__
typedef interface ITypeName ITypeName;

#endif 	/* __ITypeName_FWD_DEFINED__ */


#ifndef __ITypeNameBuilder_FWD_DEFINED__
#define __ITypeNameBuilder_FWD_DEFINED__
typedef interface ITypeNameBuilder ITypeNameBuilder;

#endif 	/* __ITypeNameBuilder_FWD_DEFINED__ */


#ifndef __ITypeNameFactory_FWD_DEFINED__
#define __ITypeNameFactory_FWD_DEFINED__
typedef interface ITypeNameFactory ITypeNameFactory;

#endif 	/* __ITypeNameFactory_FWD_DEFINED__ */


#ifndef __CLRRuntimeHost_FWD_DEFINED__
#define __CLRRuntimeHost_FWD_DEFINED__

#ifdef __cplusplus
typedef class CLRRuntimeHost CLRRuntimeHost;
#else
typedef struct CLRRuntimeHost CLRRuntimeHost;
#endif /* __cplusplus */

#endif 	/* __CLRRuntimeHost_FWD_DEFINED__ */


#ifndef __TypeNameFactory_FWD_DEFINED__
#define __TypeNameFactory_FWD_DEFINED__

#ifdef __cplusplus
typedef class TypeNameFactory TypeNameFactory;
#else
typedef struct TypeNameFactory TypeNameFactory;
#endif /* __cplusplus */

#endif 	/* __TypeNameFactory_FWD_DEFINED__ */


/* header files for imported files */
#include "unknwn.h"
#include "ivalidator.h"

#ifdef __cplusplus
extern "C"{
#endif 


/* interface __MIDL_itf_MSCOREE_0000_0000 */
/* [local] */ 

#define DECLARE_DEPRECATED 
#define DEPRECATED_CLR_STDAPI STDAPI

struct IActivationFactory;

#define	CLR_MAJOR_VERSION	( 4 )

#define	CLR_MINOR_VERSION	( 0 )

#define	CLR_BUILD_VERSION	( 22220 )

#define	CLR_ASSEMBLY_MAJOR_VERSION	( 4 )

#define	CLR_ASSEMBLY_MINOR_VERSION	( 0 )

#define	CLR_ASSEMBLY_BUILD_VERSION	( 0 )

EXTERN_GUID(CLSID_TypeNameFactory, 0xB81FF171, 0x20F3, 0x11d2, 0x8d, 0xcc, 0x00, 0xa0, 0xc9, 0xb0, 0x05, 0x25);
EXTERN_GUID(IID_ICLRPolicyManager, 0x7D290010, 0xD781, 0x45da, 0xA6, 0xF8, 0xAA, 0x5D, 0x71, 0x1A, 0x73, 0x0E);
EXTERN_GUID(IID_ICLRRuntimeHost, 0x90F1A06C, 0x7712, 0x4762, 0x86, 0xB5, 0x7A, 0x5E, 0xBA, 0x6B, 0xDB, 0x02);
EXTERN_GUID(IID_ICLRRuntimeHost2, 0x712AB73F, 0x2C22, 0x4807, 0xAD, 0x7E, 0xF5, 0x01, 0xD7, 0xb7, 0x2C, 0x2D);
EXTERN_GUID(IID_ICLRRuntimeHost4, 0x64F6D366, 0xD7C2, 0x4F1F, 0xB4, 0xB2, 0xE8, 0x16, 0x0C, 0xAC, 0x43, 0xAF);
EXTERN_GUID(IID_ICLRExecutionManager, 0x1000A3E7, 0xB420, 0x4620, 0xAE, 0x30, 0xFB, 0x19, 0xB5, 0x87, 0xAD, 0x1D);
EXTERN_GUID(IID_ITypeName, 0xB81FF171, 0x20F3, 0x11d2, 0x8d, 0xcc, 0x00, 0xa0, 0xc9, 0xb0, 0x05, 0x22);
EXTERN_GUID(IID_ITypeNameBuilder, 0xB81FF171, 0x20F3, 0x11d2, 0x8d, 0xcc, 0x00, 0xa0, 0xc9, 0xb0, 0x05, 0x23);
EXTERN_GUID(IID_ITypeNameFactory, 0xB81FF171, 0x20F3, 0x11d2, 0x8d, 0xcc, 0x00, 0xa0, 0xc9, 0xb0, 0x05, 0x21);
DEPRECATED_CLR_STDAPI GetCORSystemDirectory(_Out_writes_to_(cchBuffer, *dwLength) LPWSTR pbuffer, DWORD  cchBuffer, DWORD* dwLength);
DEPRECATED_CLR_STDAPI GetCORVersion(_Out_writes_to_(cchBuffer, *dwLength) LPWSTR pbBuffer, DWORD cchBuffer, DWORD* dwLength);
DEPRECATED_CLR_STDAPI GetFileVersion(LPCWSTR szFilename, _Out_writes_to_opt_(cchBuffer, *dwLength) LPWSTR szBuffer, DWORD cchBuffer, DWORD* dwLength);
DEPRECATED_CLR_STDAPI GetCORRequiredVersion(_Out_writes_to_(cchBuffer, *dwLength) LPWSTR pbuffer, DWORD cchBuffer, DWORD* dwLength);
DEPRECATED_CLR_STDAPI GetRequestedRuntimeInfo(LPCWSTR pExe, LPCWSTR pwszVersion, LPCWSTR pConfigurationFile, DWORD startupFlags, DWORD runtimeInfoFlags, _Out_writes_opt_(dwDirectory) LPWSTR pDirectory, DWORD dwDirectory, _Out_opt_ DWORD *dwDirectoryLength, _Out_writes_opt_(cchBuffer) LPWSTR pVersion, DWORD cchBuffer, _Out_opt_ DWORD* dwlength);
DEPRECATED_CLR_STDAPI GetRequestedRuntimeVersion(_In_ LPWSTR pExe, _Out_writes_to_(cchBuffer, *dwLength) LPWSTR pVersion, DWORD cchBuffer, _Out_ DWORD* dwLength);
DEPRECATED_CLR_STDAPI CorBindToRuntimeHost(LPCWSTR pwszVersion, LPCWSTR pwszBuildFlavor, LPCWSTR pwszHostConfigFile, VOID* pReserved, DWORD startupFlags, REFCLSID rclsid, REFIID riid, LPVOID FAR *ppv);
DEPRECATED_CLR_STDAPI CorBindToRuntimeEx(LPCWSTR pwszVersion, LPCWSTR pwszBuildFlavor, DWORD startupFlags, REFCLSID rclsid, REFIID riid, LPVOID FAR *ppv);
DEPRECATED_CLR_STDAPI CorBindToRuntimeByCfg(IStream* pCfgStream, DWORD reserved, DWORD startupFlags, REFCLSID rclsid,REFIID riid, LPVOID FAR* ppv);
DEPRECATED_CLR_STDAPI CorBindToRuntime(LPCWSTR pwszVersion, LPCWSTR pwszBuildFlavor, REFCLSID rclsid, REFIID riid, LPVOID FAR *ppv);
DEPRECATED_CLR_STDAPI CorBindToCurrentRuntime(LPCWSTR pwszFileName, REFCLSID rclsid, REFIID riid, LPVOID FAR *ppv);
DEPRECATED_CLR_STDAPI ClrCreateManagedInstance(LPCWSTR pTypeName, REFIID riid, void **ppObject);
DECLARE_DEPRECATED void STDMETHODCALLTYPE CorMarkThreadInThreadPool();
DEPRECATED_CLR_STDAPI RunDll32ShimW(HWND hwnd, HINSTANCE hinst, LPCWSTR lpszCmdLine, int nCmdShow);
DEPRECATED_CLR_STDAPI LoadLibraryShim(LPCWSTR szDllName, LPCWSTR szVersion, LPVOID pvReserved, HMODULE *phModDll);
DEPRECATED_CLR_STDAPI CallFunctionShim(LPCWSTR szDllName, LPCSTR szFunctionName, LPVOID lpvArgument1, LPVOID lpvArgument2, LPCWSTR szVersion, LPVOID pvReserved);
DEPRECATED_CLR_STDAPI GetRealProcAddress(LPCSTR pwszProcName, VOID** ppv);
DECLARE_DEPRECATED void STDMETHODCALLTYPE CorExitProcess(int exitCode);
DEPRECATED_CLR_STDAPI LoadStringRC(UINT iResouceID, _Out_writes_z_(iMax) LPWSTR szBuffer, int iMax, int bQuiet);
typedef HRESULT  (STDAPICALLTYPE *FnGetCLRRuntimeHost)(REFIID riid, IUnknown **pUnk);
typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0000_0001
    {
        HOST_TYPE_DEFAULT	= 0,
        HOST_TYPE_APPLAUNCH	= 0x1,
        HOST_TYPE_CORFLAG	= 0x2
    } 	HOST_TYPE;

STDAPI CorLaunchApplication(HOST_TYPE dwClickOnceHost, LPCWSTR pwzAppFullName, DWORD dwManifestPaths, LPCWSTR* ppwzManifestPaths, DWORD dwActivationData, LPCWSTR* ppwzActivationData, LPPROCESS_INFORMATION lpProcessInformation);
typedef HRESULT ( __stdcall *FExecuteInAppDomainCallback )( 
    void *cookie);

typedef /* [public][public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0000_0002
    {
        STARTUP_CONCURRENT_GC	= 0x1,
        STARTUP_LOADER_OPTIMIZATION_MASK	= ( 0x3 << 1 ) ,
        STARTUP_LOADER_OPTIMIZATION_SINGLE_DOMAIN	= ( 0x1 << 1 ) ,
        STARTUP_LOADER_OPTIMIZATION_MULTI_DOMAIN	= ( 0x2 << 1 ) ,
        STARTUP_LOADER_OPTIMIZATION_MULTI_DOMAIN_HOST	= ( 0x3 << 1 ) ,
        STARTUP_LOADER_SAFEMODE	= 0x10,
        STARTUP_LOADER_SETPREFERENCE	= 0x100,
        STARTUP_SERVER_GC	= 0x1000,
        STARTUP_HOARD_GC_VM	= 0x2000,
        STARTUP_SINGLE_VERSION_HOSTING_INTERFACE	= 0x4000,
        STARTUP_LEGACY_IMPERSONATION	= 0x10000,
        STARTUP_DISABLE_COMMITTHREADSTACK	= 0x20000,
        STARTUP_ALWAYSFLOW_IMPERSONATION	= 0x40000,
        STARTUP_TRIM_GC_COMMIT	= 0x80000,
        STARTUP_ETW	= 0x100000,
        STARTUP_ARM	= 0x400000,
        STARTUP_SINGLE_APPDOMAIN	= 0x800000,
        STARTUP_APPX_APP_MODEL	= 0x1000000,
        STARTUP_DISABLE_RANDOMIZED_STRING_HASHING	= 0x2000000
    } 	STARTUP_FLAGS;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0000_0003
    {
        CLSID_RESOLUTION_DEFAULT	= 0,
        CLSID_RESOLUTION_REGISTERED	= 0x1
    } 	CLSID_RESOLUTION_FLAGS;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0000_0004
    {
        RUNTIME_INFO_UPGRADE_VERSION	= 0x1,
        RUNTIME_INFO_REQUEST_IA64	= 0x2,
        RUNTIME_INFO_REQUEST_AMD64	= 0x4,
        RUNTIME_INFO_REQUEST_X86	= 0x8,
        RUNTIME_INFO_DONT_RETURN_DIRECTORY	= 0x10,
        RUNTIME_INFO_DONT_RETURN_VERSION	= 0x20,
        RUNTIME_INFO_DONT_SHOW_ERROR_DIALOG	= 0x40,
        RUNTIME_INFO_IGNORE_ERROR_MODE	= 0x1000
    } 	RUNTIME_INFO_FLAGS;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0000_0005
    {
        APPDOMAIN_SECURITY_DEFAULT	= 0,
        APPDOMAIN_SECURITY_SANDBOXED	= 0x1,
        APPDOMAIN_SECURITY_FORBID_CROSSAD_REVERSE_PINVOKE	= 0x2,
        APPDOMAIN_IGNORE_UNHANDLED_EXCEPTIONS	= 0x4,
        APPDOMAIN_FORCE_TRIVIAL_WAIT_OPERATIONS	= 0x8,
        APPDOMAIN_ENABLE_PINVOKE_AND_CLASSIC_COMINTEROP	= 0x10,
        APPDOMAIN_ENABLE_PLATFORM_SPECIFIC_APPS	= 0x40,
        APPDOMAIN_ENABLE_ASSEMBLY_LOADFILE	= 0x80,
        APPDOMAIN_DISABLE_TRANSPARENCY_ENFORCEMENT	= 0x100
    } 	APPDOMAIN_SECURITY_FLAGS;

STDAPI GetRequestedRuntimeVersionForCLSID(REFCLSID rclsid, _Out_writes_opt_(cchBuffer) LPWSTR pVersion, DWORD cchBuffer, _Out_opt_ DWORD* dwLength, CLSID_RESOLUTION_FLAGS dwResolutionFlags);
EXTERN_GUID(IID_IDebuggerThreadControl, 0x23d86786, 0x0bb5, 0x4774, 0x8f, 0xb5, 0xe3, 0x52, 0x2a, 0xdd, 0x62, 0x46);


extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0000_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0000_v0_0_s_ifspec;

#ifndef __IDebuggerThreadControl_INTERFACE_DEFINED__
#define __IDebuggerThreadControl_INTERFACE_DEFINED__

/* interface IDebuggerThreadControl */
/* [object][local][unique][helpstring][version][uuid] */ 


EXTERN_C const IID IID_IDebuggerThreadControl;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("23D86786-0BB5-4774-8FB5-E3522ADD6246")
    IDebuggerThreadControl : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE ThreadIsBlockingForDebugger( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE ReleaseAllRuntimeThreads( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE StartBlockingForDebugger( 
            DWORD dwUnused) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IDebuggerThreadControlVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IDebuggerThreadControl * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IDebuggerThreadControl * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IDebuggerThreadControl * This);
        
        HRESULT ( STDMETHODCALLTYPE *ThreadIsBlockingForDebugger )( 
            IDebuggerThreadControl * This);
        
        HRESULT ( STDMETHODCALLTYPE *ReleaseAllRuntimeThreads )( 
            IDebuggerThreadControl * This);
        
        HRESULT ( STDMETHODCALLTYPE *StartBlockingForDebugger )( 
            IDebuggerThreadControl * This,
            DWORD dwUnused);
        
        END_INTERFACE
    } IDebuggerThreadControlVtbl;

    interface IDebuggerThreadControl
    {
        CONST_VTBL struct IDebuggerThreadControlVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IDebuggerThreadControl_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IDebuggerThreadControl_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IDebuggerThreadControl_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IDebuggerThreadControl_ThreadIsBlockingForDebugger(This)	\
    ( (This)->lpVtbl -> ThreadIsBlockingForDebugger(This) ) 

#define IDebuggerThreadControl_ReleaseAllRuntimeThreads(This)	\
    ( (This)->lpVtbl -> ReleaseAllRuntimeThreads(This) ) 

#define IDebuggerThreadControl_StartBlockingForDebugger(This,dwUnused)	\
    ( (This)->lpVtbl -> StartBlockingForDebugger(This,dwUnused) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IDebuggerThreadControl_INTERFACE_DEFINED__ */


/* interface __MIDL_itf_MSCOREE_0000_0001 */
/* [local] */ 

EXTERN_GUID(IID_IDebuggerInfo, 0xbf24142d, 0xa47d, 0x4d24, 0xa6, 0x6d, 0x8c, 0x21, 0x41, 0x94, 0x4e, 0x44);


extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0001_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0001_v0_0_s_ifspec;

#ifndef __IDebuggerInfo_INTERFACE_DEFINED__
#define __IDebuggerInfo_INTERFACE_DEFINED__

/* interface IDebuggerInfo */
/* [object][local][unique][helpstring][version][uuid] */ 


EXTERN_C const IID IID_IDebuggerInfo;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("BF24142D-A47D-4d24-A66D-8C2141944E44")
    IDebuggerInfo : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE IsDebuggerAttached( 
            /* [out] */ BOOL *pbAttached) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IDebuggerInfoVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IDebuggerInfo * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IDebuggerInfo * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IDebuggerInfo * This);
        
        HRESULT ( STDMETHODCALLTYPE *IsDebuggerAttached )( 
            IDebuggerInfo * This,
            /* [out] */ BOOL *pbAttached);
        
        END_INTERFACE
    } IDebuggerInfoVtbl;

    interface IDebuggerInfo
    {
        CONST_VTBL struct IDebuggerInfoVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IDebuggerInfo_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IDebuggerInfo_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IDebuggerInfo_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IDebuggerInfo_IsDebuggerAttached(This,pbAttached)	\
    ( (This)->lpVtbl -> IsDebuggerAttached(This,pbAttached) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IDebuggerInfo_INTERFACE_DEFINED__ */


/* interface __MIDL_itf_MSCOREE_0000_0002 */
/* [local] */ 

typedef void *HDOMAINENUM;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0001
    {
        eMemoryAvailableLow	= 1,
        eMemoryAvailableNeutral	= 2,
        eMemoryAvailableHigh	= 3
    } 	EMemoryAvailable;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0002
    {
        eTaskCritical	= 0,
        eAppDomainCritical	= 1,
        eProcessCritical	= 2
    } 	EMemoryCriticalLevel;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0003
    {
        WAIT_MSGPUMP	= 0x1,
        WAIT_ALERTABLE	= 0x2,
        WAIT_NOTINDEADLOCK	= 0x4
    } 	WAIT_OPTION;

typedef UINT64 TASKID;

typedef DWORD CONNID;

typedef 
enum ETaskType
    {
        TT_DEBUGGERHELPER	= 0x1,
        TT_GC	= 0x2,
        TT_FINALIZER	= 0x4,
        TT_THREADPOOL_TIMER	= 0x8,
        TT_THREADPOOL_GATE	= 0x10,
        TT_THREADPOOL_WORKER	= 0x20,
        TT_THREADPOOL_IOCOMPLETION	= 0x40,
        TT_ADUNLOAD	= 0x80,
        TT_USER	= 0x100,
        TT_THREADPOOL_WAIT	= 0x200,
        TT_UNKNOWN	= 0x80000000
    } 	ETaskType;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0004
    {
        eSymbolReadingNever	= 0,
        eSymbolReadingAlways	= 1,
        eSymbolReadingFullTrustOnly	= 2
    } 	ESymbolReadingPolicy;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0005
    {
        DUMP_FLAVOR_Mini	= 0,
        DUMP_FLAVOR_CriticalCLRState	= 1,
        DUMP_FLAVOR_NonHeapCLRState	= 2,
        DUMP_FLAVOR_Default	= DUMP_FLAVOR_Mini
    } 	ECustomDumpFlavor;

typedef /* [public][public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0006
    {
        DUMP_ITEM_None	= 0
    } 	ECustomDumpItemKind;

typedef /* [public] */ struct __MIDL___MIDL_itf_MSCOREE_0000_0002_0007
    {
    ECustomDumpItemKind itemKind;
    union 
        {
        UINT_PTR pReserved;
        } 	;
    } 	CustomDumpItem;

#define	BucketParamsCount	( 10 )

#define	BucketParamLength	( 255 )

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0009
    {
        Parameter1	= 0,
        Parameter2	= ( Parameter1 + 1 ) ,
        Parameter3	= ( Parameter2 + 1 ) ,
        Parameter4	= ( Parameter3 + 1 ) ,
        Parameter5	= ( Parameter4 + 1 ) ,
        Parameter6	= ( Parameter5 + 1 ) ,
        Parameter7	= ( Parameter6 + 1 ) ,
        Parameter8	= ( Parameter7 + 1 ) ,
        Parameter9	= ( Parameter8 + 1 ) ,
        InvalidBucketParamIndex	= ( Parameter9 + 1 ) 
    } 	BucketParameterIndex;

typedef struct _BucketParameters
    {
    BOOL fInited;
    WCHAR pszEventTypeName[ 255 ];
    WCHAR pszParams[ 10 ][ 255 ];
    } 	BucketParameters;

typedef /* [public][public][public][public][public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0010
    {
        OPR_ThreadAbort	= 0,
        OPR_ThreadRudeAbortInNonCriticalRegion	= ( OPR_ThreadAbort + 1 ) ,
        OPR_ThreadRudeAbortInCriticalRegion	= ( OPR_ThreadRudeAbortInNonCriticalRegion + 1 ) ,
        OPR_AppDomainUnload	= ( OPR_ThreadRudeAbortInCriticalRegion + 1 ) ,
        OPR_AppDomainRudeUnload	= ( OPR_AppDomainUnload + 1 ) ,
        OPR_ProcessExit	= ( OPR_AppDomainRudeUnload + 1 ) ,
        OPR_FinalizerRun	= ( OPR_ProcessExit + 1 ) ,
        MaxClrOperation	= ( OPR_FinalizerRun + 1 ) 
    } 	EClrOperation;

typedef /* [public][public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0011
    {
        FAIL_NonCriticalResource	= 0,
        FAIL_CriticalResource	= ( FAIL_NonCriticalResource + 1 ) ,
        FAIL_FatalRuntime	= ( FAIL_CriticalResource + 1 ) ,
        FAIL_OrphanedLock	= ( FAIL_FatalRuntime + 1 ) ,
        FAIL_StackOverflow	= ( FAIL_OrphanedLock + 1 ) ,
        FAIL_AccessViolation	= ( FAIL_StackOverflow + 1 ) ,
        FAIL_CodeContract	= ( FAIL_AccessViolation + 1 ) ,
        MaxClrFailure	= ( FAIL_CodeContract + 1 ) 
    } 	EClrFailure;

typedef /* [public][public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0012
    {
        eRuntimeDeterminedPolicy	= 0,
        eHostDeterminedPolicy	= ( eRuntimeDeterminedPolicy + 1 ) 
    } 	EClrUnhandledException;

typedef /* [public][public][public][public][public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0002_0013
    {
        eNoAction	= 0,
        eThrowException	= ( eNoAction + 1 ) ,
        eAbortThread	= ( eThrowException + 1 ) ,
        eRudeAbortThread	= ( eAbortThread + 1 ) ,
        eUnloadAppDomain	= ( eRudeAbortThread + 1 ) ,
        eRudeUnloadAppDomain	= ( eUnloadAppDomain + 1 ) ,
        eExitProcess	= ( eRudeUnloadAppDomain + 1 ) ,
        eFastExitProcess	= ( eExitProcess + 1 ) ,
        eRudeExitProcess	= ( eFastExitProcess + 1 ) ,
        eDisableRuntime	= ( eRudeExitProcess + 1 ) ,
        MaxPolicyAction	= ( eDisableRuntime + 1 ) 
    } 	EPolicyAction;



extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0002_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0002_v0_0_s_ifspec;

#ifndef __ICLRPolicyManager_INTERFACE_DEFINED__
#define __ICLRPolicyManager_INTERFACE_DEFINED__

/* interface ICLRPolicyManager */
/* [object][local][unique][helpstring][version][uuid] */ 


EXTERN_C const IID IID_ICLRPolicyManager;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("7D290010-D781-45da-A6F8-AA5D711A730E")
    ICLRPolicyManager : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE SetDefaultAction( 
            /* [in] */ EClrOperation operation,
            /* [in] */ EPolicyAction action) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetTimeout( 
            /* [in] */ EClrOperation operation,
            /* [in] */ DWORD dwMilliseconds) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetActionOnTimeout( 
            /* [in] */ EClrOperation operation,
            /* [in] */ EPolicyAction action) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetTimeoutAndAction( 
            /* [in] */ EClrOperation operation,
            /* [in] */ DWORD dwMilliseconds,
            /* [in] */ EPolicyAction action) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetActionOnFailure( 
            /* [in] */ EClrFailure failure,
            /* [in] */ EPolicyAction action) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetUnhandledExceptionPolicy( 
            /* [in] */ EClrUnhandledException policy) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICLRPolicyManagerVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICLRPolicyManager * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICLRPolicyManager * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICLRPolicyManager * This);
        
        HRESULT ( STDMETHODCALLTYPE *SetDefaultAction )( 
            ICLRPolicyManager * This,
            /* [in] */ EClrOperation operation,
            /* [in] */ EPolicyAction action);
        
        HRESULT ( STDMETHODCALLTYPE *SetTimeout )( 
            ICLRPolicyManager * This,
            /* [in] */ EClrOperation operation,
            /* [in] */ DWORD dwMilliseconds);
        
        HRESULT ( STDMETHODCALLTYPE *SetActionOnTimeout )( 
            ICLRPolicyManager * This,
            /* [in] */ EClrOperation operation,
            /* [in] */ EPolicyAction action);
        
        HRESULT ( STDMETHODCALLTYPE *SetTimeoutAndAction )( 
            ICLRPolicyManager * This,
            /* [in] */ EClrOperation operation,
            /* [in] */ DWORD dwMilliseconds,
            /* [in] */ EPolicyAction action);
        
        HRESULT ( STDMETHODCALLTYPE *SetActionOnFailure )( 
            ICLRPolicyManager * This,
            /* [in] */ EClrFailure failure,
            /* [in] */ EPolicyAction action);
        
        HRESULT ( STDMETHODCALLTYPE *SetUnhandledExceptionPolicy )( 
            ICLRPolicyManager * This,
            /* [in] */ EClrUnhandledException policy);
        
        END_INTERFACE
    } ICLRPolicyManagerVtbl;

    interface ICLRPolicyManager
    {
        CONST_VTBL struct ICLRPolicyManagerVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICLRPolicyManager_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICLRPolicyManager_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICLRPolicyManager_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICLRPolicyManager_SetDefaultAction(This,operation,action)	\
    ( (This)->lpVtbl -> SetDefaultAction(This,operation,action) ) 

#define ICLRPolicyManager_SetTimeout(This,operation,dwMilliseconds)	\
    ( (This)->lpVtbl -> SetTimeout(This,operation,dwMilliseconds) ) 

#define ICLRPolicyManager_SetActionOnTimeout(This,operation,action)	\
    ( (This)->lpVtbl -> SetActionOnTimeout(This,operation,action) ) 

#define ICLRPolicyManager_SetTimeoutAndAction(This,operation,dwMilliseconds,action)	\
    ( (This)->lpVtbl -> SetTimeoutAndAction(This,operation,dwMilliseconds,action) ) 

#define ICLRPolicyManager_SetActionOnFailure(This,failure,action)	\
    ( (This)->lpVtbl -> SetActionOnFailure(This,failure,action) ) 

#define ICLRPolicyManager_SetUnhandledExceptionPolicy(This,policy)	\
    ( (This)->lpVtbl -> SetUnhandledExceptionPolicy(This,policy) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICLRPolicyManager_INTERFACE_DEFINED__ */


/* interface __MIDL_itf_MSCOREE_0000_0003 */
/* [local] */ 

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0003_0001
    {
        Event_DomainUnload	= 0,
        Event_ClrDisabled	= ( Event_DomainUnload + 1 ) ,
        Event_MDAFired	= ( Event_ClrDisabled + 1 ) ,
        Event_StackOverflow	= ( Event_MDAFired + 1 ) ,
        MaxClrEvent	= ( Event_StackOverflow + 1 ) 
    } 	EClrEvent;

typedef struct _MDAInfo
    {
    LPCWSTR lpMDACaption;
    LPCWSTR lpMDAMessage;
    LPCWSTR lpStackTrace;
    } 	MDAInfo;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0003_0002
    {
        SO_Managed	= 0,
        SO_ClrEngine	= ( SO_Managed + 1 ) ,
        SO_Other	= ( SO_ClrEngine + 1 ) 
    } 	StackOverflowType;

typedef struct _StackOverflowInfo
{
    StackOverflowType soType;
    EXCEPTION_POINTERS *pExceptionInfo;
} StackOverflowInfo;
typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0003_0003
    {
        ePolicyLevelNone	= 0,
        ePolicyLevelRetargetable	= 0x1,
        ePolicyUnifiedToCLR	= 0x2,
        ePolicyLevelApp	= 0x4,
        ePolicyLevelPublisher	= 0x8,
        ePolicyLevelHost	= 0x10,
        ePolicyLevelAdmin	= 0x20,
        ePolicyPortability	= 0x40
    } 	EBindPolicyLevels;

typedef struct _AssemblyBindInfo
    {
    DWORD dwAppDomainId;
    LPCWSTR lpReferencedIdentity;
    LPCWSTR lpPostPolicyIdentity;
    DWORD ePolicyLevel;
    } 	AssemblyBindInfo;

typedef struct _ModuleBindInfo
    {
    DWORD dwAppDomainId;
    LPCWSTR lpAssemblyIdentity;
    LPCWSTR lpModuleName;
    } 	ModuleBindInfo;

typedef 
enum _HostApplicationPolicy
    {
        HOST_APPLICATION_BINDING_POLICY	= 1
    } 	EHostApplicationPolicy;

STDAPI GetCLRIdentityManager(REFIID riid, IUnknown **ppManager);
EXTERN_GUID(IID_IHostControl, 0x02CA073C, 0x7079, 0x4860, 0x88, 0x0A, 0xC2, 0xF7, 0xA4, 0x49, 0xC9, 0x91);


extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0003_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0003_v0_0_s_ifspec;

#ifndef __IHostControl_INTERFACE_DEFINED__
#define __IHostControl_INTERFACE_DEFINED__

/* interface IHostControl */
/* [object][local][unique][helpstring][version][uuid] */ 


EXTERN_C const IID IID_IHostControl;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("02CA073C-7079-4860-880A-C2F7A449C991")
    IHostControl : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE GetHostManager( 
            /* [in] */ REFIID riid,
            /* [out] */ void **ppObject) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetAppDomainManager( 
            /* [in] */ DWORD dwAppDomainID,
            /* [in] */ IUnknown *pUnkAppDomainManager) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IHostControlVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IHostControl * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IHostControl * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IHostControl * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetHostManager )( 
            IHostControl * This,
            /* [in] */ REFIID riid,
            /* [out] */ void **ppObject);
        
        HRESULT ( STDMETHODCALLTYPE *SetAppDomainManager )( 
            IHostControl * This,
            /* [in] */ DWORD dwAppDomainID,
            /* [in] */ IUnknown *pUnkAppDomainManager);
        
        END_INTERFACE
    } IHostControlVtbl;

    interface IHostControl
    {
        CONST_VTBL struct IHostControlVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IHostControl_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IHostControl_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IHostControl_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IHostControl_GetHostManager(This,riid,ppObject)	\
    ( (This)->lpVtbl -> GetHostManager(This,riid,ppObject) ) 

#define IHostControl_SetAppDomainManager(This,dwAppDomainID,pUnkAppDomainManager)	\
    ( (This)->lpVtbl -> SetAppDomainManager(This,dwAppDomainID,pUnkAppDomainManager) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IHostControl_INTERFACE_DEFINED__ */


/* interface __MIDL_itf_MSCOREE_0000_0004 */
/* [local] */ 

EXTERN_GUID(IID_ICLRControl, 0x9065597E, 0xD1A1, 0x4fb2, 0xB6, 0xBA, 0x7E, 0x1F, 0xCE, 0x23, 0x0F, 0x61);


extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0004_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0004_v0_0_s_ifspec;

#ifndef __ICLRControl_INTERFACE_DEFINED__
#define __ICLRControl_INTERFACE_DEFINED__

/* interface ICLRControl */
/* [object][local][unique][helpstring][version][uuid] */ 


EXTERN_C const IID IID_ICLRControl;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("9065597E-D1A1-4fb2-B6BA-7E1FCE230F61")
    ICLRControl : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE GetCLRManager( 
            /* [in] */ REFIID riid,
            /* [out] */ void **ppObject) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetAppDomainManagerType( 
            /* [in] */ LPCWSTR pwzAppDomainManagerAssembly,
            /* [in] */ LPCWSTR pwzAppDomainManagerType) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICLRControlVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICLRControl * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICLRControl * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICLRControl * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetCLRManager )( 
            ICLRControl * This,
            /* [in] */ REFIID riid,
            /* [out] */ void **ppObject);
        
        HRESULT ( STDMETHODCALLTYPE *SetAppDomainManagerType )( 
            ICLRControl * This,
            /* [in] */ LPCWSTR pwzAppDomainManagerAssembly,
            /* [in] */ LPCWSTR pwzAppDomainManagerType);
        
        END_INTERFACE
    } ICLRControlVtbl;

    interface ICLRControl
    {
        CONST_VTBL struct ICLRControlVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICLRControl_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICLRControl_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICLRControl_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICLRControl_GetCLRManager(This,riid,ppObject)	\
    ( (This)->lpVtbl -> GetCLRManager(This,riid,ppObject) ) 

#define ICLRControl_SetAppDomainManagerType(This,pwzAppDomainManagerAssembly,pwzAppDomainManagerType)	\
    ( (This)->lpVtbl -> SetAppDomainManagerType(This,pwzAppDomainManagerAssembly,pwzAppDomainManagerType) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICLRControl_INTERFACE_DEFINED__ */


#ifndef __ICLRRuntimeHost_INTERFACE_DEFINED__
#define __ICLRRuntimeHost_INTERFACE_DEFINED__

/* interface ICLRRuntimeHost */
/* [object][local][unique][helpstring][version][uuid] */ 


EXTERN_C const IID IID_ICLRRuntimeHost;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("90F1A06C-7712-4762-86B5-7A5EBA6BDB02")
    ICLRRuntimeHost : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE Start( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE Stop( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetHostControl( 
            /* [in] */ IHostControl *pHostControl) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetCLRControl( 
            /* [out] */ ICLRControl **pCLRControl) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE UnloadAppDomain( 
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ BOOL fWaitUntilDone) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE ExecuteInAppDomain( 
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ FExecuteInAppDomainCallback pCallback,
            /* [in] */ void *cookie) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetCurrentAppDomainId( 
            /* [out] */ DWORD *pdwAppDomainId) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE ExecuteApplication( 
            /* [in] */ LPCWSTR pwzAppFullName,
            /* [in] */ DWORD dwManifestPaths,
            /* [in] */ LPCWSTR *ppwzManifestPaths,
            /* [in] */ DWORD dwActivationData,
            /* [in] */ LPCWSTR *ppwzActivationData,
            /* [out] */ int *pReturnValue) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE ExecuteInDefaultAppDomain( 
            /* [in] */ LPCWSTR pwzAssemblyPath,
            /* [in] */ LPCWSTR pwzTypeName,
            /* [in] */ LPCWSTR pwzMethodName,
            /* [in] */ LPCWSTR pwzArgument,
            /* [out] */ DWORD *pReturnValue) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICLRRuntimeHostVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICLRRuntimeHost * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICLRRuntimeHost * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICLRRuntimeHost * This);
        
        HRESULT ( STDMETHODCALLTYPE *Start )( 
            ICLRRuntimeHost * This);
        
        HRESULT ( STDMETHODCALLTYPE *Stop )( 
            ICLRRuntimeHost * This);
        
        HRESULT ( STDMETHODCALLTYPE *SetHostControl )( 
            ICLRRuntimeHost * This,
            /* [in] */ IHostControl *pHostControl);
        
        HRESULT ( STDMETHODCALLTYPE *GetCLRControl )( 
            ICLRRuntimeHost * This,
            /* [out] */ ICLRControl **pCLRControl);
        
        HRESULT ( STDMETHODCALLTYPE *UnloadAppDomain )( 
            ICLRRuntimeHost * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ BOOL fWaitUntilDone);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteInAppDomain )( 
            ICLRRuntimeHost * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ FExecuteInAppDomainCallback pCallback,
            /* [in] */ void *cookie);
        
        HRESULT ( STDMETHODCALLTYPE *GetCurrentAppDomainId )( 
            ICLRRuntimeHost * This,
            /* [out] */ DWORD *pdwAppDomainId);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteApplication )( 
            ICLRRuntimeHost * This,
            /* [in] */ LPCWSTR pwzAppFullName,
            /* [in] */ DWORD dwManifestPaths,
            /* [in] */ LPCWSTR *ppwzManifestPaths,
            /* [in] */ DWORD dwActivationData,
            /* [in] */ LPCWSTR *ppwzActivationData,
            /* [out] */ int *pReturnValue);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteInDefaultAppDomain )( 
            ICLRRuntimeHost * This,
            /* [in] */ LPCWSTR pwzAssemblyPath,
            /* [in] */ LPCWSTR pwzTypeName,
            /* [in] */ LPCWSTR pwzMethodName,
            /* [in] */ LPCWSTR pwzArgument,
            /* [out] */ DWORD *pReturnValue);
        
        END_INTERFACE
    } ICLRRuntimeHostVtbl;

    interface ICLRRuntimeHost
    {
        CONST_VTBL struct ICLRRuntimeHostVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICLRRuntimeHost_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICLRRuntimeHost_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICLRRuntimeHost_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICLRRuntimeHost_Start(This)	\
    ( (This)->lpVtbl -> Start(This) ) 

#define ICLRRuntimeHost_Stop(This)	\
    ( (This)->lpVtbl -> Stop(This) ) 

#define ICLRRuntimeHost_SetHostControl(This,pHostControl)	\
    ( (This)->lpVtbl -> SetHostControl(This,pHostControl) ) 

#define ICLRRuntimeHost_GetCLRControl(This,pCLRControl)	\
    ( (This)->lpVtbl -> GetCLRControl(This,pCLRControl) ) 

#define ICLRRuntimeHost_UnloadAppDomain(This,dwAppDomainId,fWaitUntilDone)	\
    ( (This)->lpVtbl -> UnloadAppDomain(This,dwAppDomainId,fWaitUntilDone) ) 

#define ICLRRuntimeHost_ExecuteInAppDomain(This,dwAppDomainId,pCallback,cookie)	\
    ( (This)->lpVtbl -> ExecuteInAppDomain(This,dwAppDomainId,pCallback,cookie) ) 

#define ICLRRuntimeHost_GetCurrentAppDomainId(This,pdwAppDomainId)	\
    ( (This)->lpVtbl -> GetCurrentAppDomainId(This,pdwAppDomainId) ) 

#define ICLRRuntimeHost_ExecuteApplication(This,pwzAppFullName,dwManifestPaths,ppwzManifestPaths,dwActivationData,ppwzActivationData,pReturnValue)	\
    ( (This)->lpVtbl -> ExecuteApplication(This,pwzAppFullName,dwManifestPaths,ppwzManifestPaths,dwActivationData,ppwzActivationData,pReturnValue) ) 

#define ICLRRuntimeHost_ExecuteInDefaultAppDomain(This,pwzAssemblyPath,pwzTypeName,pwzMethodName,pwzArgument,pReturnValue)	\
    ( (This)->lpVtbl -> ExecuteInDefaultAppDomain(This,pwzAssemblyPath,pwzTypeName,pwzMethodName,pwzArgument,pReturnValue) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICLRRuntimeHost_INTERFACE_DEFINED__ */


/* interface __MIDL_itf_MSCOREE_0000_0006 */
/* [local] */ 

#define CORECLR_HOST_AUTHENTICATION_KEY 0x1C6CA6F94025800LL
#define CORECLR_HOST_AUTHENTICATION_KEY_NONGEN 0x1C6CA6F94025801LL


extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0006_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0006_v0_0_s_ifspec;

#ifndef __ICLRRuntimeHost2_INTERFACE_DEFINED__
#define __ICLRRuntimeHost2_INTERFACE_DEFINED__

/* interface ICLRRuntimeHost2 */
/* [local][unique][helpstring][version][uuid][object] */ 


EXTERN_C const IID IID_ICLRRuntimeHost2;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("712AB73F-2C22-4807-AD7E-F501D7B72C2D")
    ICLRRuntimeHost2 : public ICLRRuntimeHost
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE CreateAppDomainWithManager( 
            /* [in] */ LPCWSTR wszFriendlyName,
            /* [in] */ DWORD dwFlags,
            /* [in] */ LPCWSTR wszAppDomainManagerAssemblyName,
            /* [in] */ LPCWSTR wszAppDomainManagerTypeName,
            /* [in] */ int nProperties,
            /* [in] */ LPCWSTR *pPropertyNames,
            /* [in] */ LPCWSTR *pPropertyValues,
            /* [out] */ DWORD *pAppDomainID) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE CreateDelegate( 
            /* [in] */ DWORD appDomainID,
            /* [in] */ LPCWSTR wszAssemblyName,
            /* [in] */ LPCWSTR wszClassName,
            /* [in] */ LPCWSTR wszMethodName,
            /* [out] */ INT_PTR *fnPtr) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE Authenticate( 
            /* [in] */ ULONGLONG authKey) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE RegisterMacEHPort( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE SetStartupFlags( 
            /* [in] */ STARTUP_FLAGS dwFlags) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE DllGetActivationFactory( 
            /* [in] */ DWORD appDomainID,
            /* [in] */ LPCWSTR wszTypeName,
            /* [out] */ IActivationFactory **factory) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE ExecuteAssembly( 
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ LPCWSTR pwzAssemblyPath,
            /* [in] */ int argc,
            /* [in] */ LPCWSTR *argv,
            /* [out] */ DWORD *pReturnValue) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICLRRuntimeHost2Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICLRRuntimeHost2 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICLRRuntimeHost2 * This);
        
        HRESULT ( STDMETHODCALLTYPE *Start )( 
            ICLRRuntimeHost2 * This);
        
        HRESULT ( STDMETHODCALLTYPE *Stop )( 
            ICLRRuntimeHost2 * This);
        
        HRESULT ( STDMETHODCALLTYPE *SetHostControl )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ IHostControl *pHostControl);
        
        HRESULT ( STDMETHODCALLTYPE *GetCLRControl )( 
            ICLRRuntimeHost2 * This,
            /* [out] */ ICLRControl **pCLRControl);
        
        HRESULT ( STDMETHODCALLTYPE *UnloadAppDomain )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ BOOL fWaitUntilDone);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteInAppDomain )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ FExecuteInAppDomainCallback pCallback,
            /* [in] */ void *cookie);
        
        HRESULT ( STDMETHODCALLTYPE *GetCurrentAppDomainId )( 
            ICLRRuntimeHost2 * This,
            /* [out] */ DWORD *pdwAppDomainId);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteApplication )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ LPCWSTR pwzAppFullName,
            /* [in] */ DWORD dwManifestPaths,
            /* [in] */ LPCWSTR *ppwzManifestPaths,
            /* [in] */ DWORD dwActivationData,
            /* [in] */ LPCWSTR *ppwzActivationData,
            /* [out] */ int *pReturnValue);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteInDefaultAppDomain )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ LPCWSTR pwzAssemblyPath,
            /* [in] */ LPCWSTR pwzTypeName,
            /* [in] */ LPCWSTR pwzMethodName,
            /* [in] */ LPCWSTR pwzArgument,
            /* [out] */ DWORD *pReturnValue);
        
        HRESULT ( STDMETHODCALLTYPE *CreateAppDomainWithManager )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ LPCWSTR wszFriendlyName,
            /* [in] */ DWORD dwFlags,
            /* [in] */ LPCWSTR wszAppDomainManagerAssemblyName,
            /* [in] */ LPCWSTR wszAppDomainManagerTypeName,
            /* [in] */ int nProperties,
            /* [in] */ LPCWSTR *pPropertyNames,
            /* [in] */ LPCWSTR *pPropertyValues,
            /* [out] */ DWORD *pAppDomainID);
        
        HRESULT ( STDMETHODCALLTYPE *CreateDelegate )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ DWORD appDomainID,
            /* [in] */ LPCWSTR wszAssemblyName,
            /* [in] */ LPCWSTR wszClassName,
            /* [in] */ LPCWSTR wszMethodName,
            /* [out] */ INT_PTR *fnPtr);
        
        HRESULT ( STDMETHODCALLTYPE *Authenticate )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ ULONGLONG authKey);
        
        HRESULT ( STDMETHODCALLTYPE *RegisterMacEHPort )( 
            ICLRRuntimeHost2 * This);
        
        HRESULT ( STDMETHODCALLTYPE *SetStartupFlags )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ STARTUP_FLAGS dwFlags);
        
        HRESULT ( STDMETHODCALLTYPE *DllGetActivationFactory )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ DWORD appDomainID,
            /* [in] */ LPCWSTR wszTypeName,
            /* [out] */ IActivationFactory **factory);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteAssembly )( 
            ICLRRuntimeHost2 * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ LPCWSTR pwzAssemblyPath,
            /* [in] */ int argc,
            /* [in] */ LPCWSTR *argv,
            /* [out] */ DWORD *pReturnValue);
        
        END_INTERFACE
    } ICLRRuntimeHost2Vtbl;

    interface ICLRRuntimeHost2
    {
        CONST_VTBL struct ICLRRuntimeHost2Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICLRRuntimeHost2_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICLRRuntimeHost2_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICLRRuntimeHost2_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICLRRuntimeHost2_Start(This)	\
    ( (This)->lpVtbl -> Start(This) ) 

#define ICLRRuntimeHost2_Stop(This)	\
    ( (This)->lpVtbl -> Stop(This) ) 

#define ICLRRuntimeHost2_SetHostControl(This,pHostControl)	\
    ( (This)->lpVtbl -> SetHostControl(This,pHostControl) ) 

#define ICLRRuntimeHost2_GetCLRControl(This,pCLRControl)	\
    ( (This)->lpVtbl -> GetCLRControl(This,pCLRControl) ) 

#define ICLRRuntimeHost2_UnloadAppDomain(This,dwAppDomainId,fWaitUntilDone)	\
    ( (This)->lpVtbl -> UnloadAppDomain(This,dwAppDomainId,fWaitUntilDone) ) 

#define ICLRRuntimeHost2_ExecuteInAppDomain(This,dwAppDomainId,pCallback,cookie)	\
    ( (This)->lpVtbl -> ExecuteInAppDomain(This,dwAppDomainId,pCallback,cookie) ) 

#define ICLRRuntimeHost2_GetCurrentAppDomainId(This,pdwAppDomainId)	\
    ( (This)->lpVtbl -> GetCurrentAppDomainId(This,pdwAppDomainId) ) 

#define ICLRRuntimeHost2_ExecuteApplication(This,pwzAppFullName,dwManifestPaths,ppwzManifestPaths,dwActivationData,ppwzActivationData,pReturnValue)	\
    ( (This)->lpVtbl -> ExecuteApplication(This,pwzAppFullName,dwManifestPaths,ppwzManifestPaths,dwActivationData,ppwzActivationData,pReturnValue) ) 

#define ICLRRuntimeHost2_ExecuteInDefaultAppDomain(This,pwzAssemblyPath,pwzTypeName,pwzMethodName,pwzArgument,pReturnValue)	\
    ( (This)->lpVtbl -> ExecuteInDefaultAppDomain(This,pwzAssemblyPath,pwzTypeName,pwzMethodName,pwzArgument,pReturnValue) ) 


#define ICLRRuntimeHost2_CreateAppDomainWithManager(This,wszFriendlyName,dwFlags,wszAppDomainManagerAssemblyName,wszAppDomainManagerTypeName,nProperties,pPropertyNames,pPropertyValues,pAppDomainID)	\
    ( (This)->lpVtbl -> CreateAppDomainWithManager(This,wszFriendlyName,dwFlags,wszAppDomainManagerAssemblyName,wszAppDomainManagerTypeName,nProperties,pPropertyNames,pPropertyValues,pAppDomainID) ) 

#define ICLRRuntimeHost2_CreateDelegate(This,appDomainID,wszAssemblyName,wszClassName,wszMethodName,fnPtr)	\
    ( (This)->lpVtbl -> CreateDelegate(This,appDomainID,wszAssemblyName,wszClassName,wszMethodName,fnPtr) ) 

#define ICLRRuntimeHost2_Authenticate(This,authKey)	\
    ( (This)->lpVtbl -> Authenticate(This,authKey) ) 

#define ICLRRuntimeHost2_RegisterMacEHPort(This)	\
    ( (This)->lpVtbl -> RegisterMacEHPort(This) ) 

#define ICLRRuntimeHost2_SetStartupFlags(This,dwFlags)	\
    ( (This)->lpVtbl -> SetStartupFlags(This,dwFlags) ) 

#define ICLRRuntimeHost2_DllGetActivationFactory(This,appDomainID,wszTypeName,factory)	\
    ( (This)->lpVtbl -> DllGetActivationFactory(This,appDomainID,wszTypeName,factory) ) 

#define ICLRRuntimeHost2_ExecuteAssembly(This,dwAppDomainId,pwzAssemblyPath,argc,argv,pReturnValue)	\
    ( (This)->lpVtbl -> ExecuteAssembly(This,dwAppDomainId,pwzAssemblyPath,argc,argv,pReturnValue) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICLRRuntimeHost2_INTERFACE_DEFINED__ */


#ifndef __ICLRRuntimeHost4_INTERFACE_DEFINED__
#define __ICLRRuntimeHost4_INTERFACE_DEFINED__

/* interface ICLRRuntimeHost4 */
/* [local][unique][helpstring][version][uuid][object] */ 


EXTERN_C const IID IID_ICLRRuntimeHost4;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("64F6D366-D7C2-4F1F-B4B2-E8160CAC43AF")
    ICLRRuntimeHost4 : public ICLRRuntimeHost2
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE UnloadAppDomain2( 
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ BOOL fWaitUntilDone,
            /* [out] */ int *pLatchedExitCode) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICLRRuntimeHost4Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICLRRuntimeHost4 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICLRRuntimeHost4 * This);
        
        HRESULT ( STDMETHODCALLTYPE *Start )( 
            ICLRRuntimeHost4 * This);
        
        HRESULT ( STDMETHODCALLTYPE *Stop )( 
            ICLRRuntimeHost4 * This);
        
        HRESULT ( STDMETHODCALLTYPE *SetHostControl )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ IHostControl *pHostControl);
        
        HRESULT ( STDMETHODCALLTYPE *GetCLRControl )( 
            ICLRRuntimeHost4 * This,
            /* [out] */ ICLRControl **pCLRControl);
        
        HRESULT ( STDMETHODCALLTYPE *UnloadAppDomain )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ BOOL fWaitUntilDone);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteInAppDomain )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ FExecuteInAppDomainCallback pCallback,
            /* [in] */ void *cookie);
        
        HRESULT ( STDMETHODCALLTYPE *GetCurrentAppDomainId )( 
            ICLRRuntimeHost4 * This,
            /* [out] */ DWORD *pdwAppDomainId);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteApplication )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ LPCWSTR pwzAppFullName,
            /* [in] */ DWORD dwManifestPaths,
            /* [in] */ LPCWSTR *ppwzManifestPaths,
            /* [in] */ DWORD dwActivationData,
            /* [in] */ LPCWSTR *ppwzActivationData,
            /* [out] */ int *pReturnValue);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteInDefaultAppDomain )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ LPCWSTR pwzAssemblyPath,
            /* [in] */ LPCWSTR pwzTypeName,
            /* [in] */ LPCWSTR pwzMethodName,
            /* [in] */ LPCWSTR pwzArgument,
            /* [out] */ DWORD *pReturnValue);
        
        HRESULT ( STDMETHODCALLTYPE *CreateAppDomainWithManager )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ LPCWSTR wszFriendlyName,
            /* [in] */ DWORD dwFlags,
            /* [in] */ LPCWSTR wszAppDomainManagerAssemblyName,
            /* [in] */ LPCWSTR wszAppDomainManagerTypeName,
            /* [in] */ int nProperties,
            /* [in] */ LPCWSTR *pPropertyNames,
            /* [in] */ LPCWSTR *pPropertyValues,
            /* [out] */ DWORD *pAppDomainID);
        
        HRESULT ( STDMETHODCALLTYPE *CreateDelegate )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ DWORD appDomainID,
            /* [in] */ LPCWSTR wszAssemblyName,
            /* [in] */ LPCWSTR wszClassName,
            /* [in] */ LPCWSTR wszMethodName,
            /* [out] */ INT_PTR *fnPtr);
        
        HRESULT ( STDMETHODCALLTYPE *Authenticate )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ ULONGLONG authKey);
        
        HRESULT ( STDMETHODCALLTYPE *RegisterMacEHPort )( 
            ICLRRuntimeHost4 * This);
        
        HRESULT ( STDMETHODCALLTYPE *SetStartupFlags )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ STARTUP_FLAGS dwFlags);
        
        HRESULT ( STDMETHODCALLTYPE *DllGetActivationFactory )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ DWORD appDomainID,
            /* [in] */ LPCWSTR wszTypeName,
            /* [out] */ IActivationFactory **factory);
        
        HRESULT ( STDMETHODCALLTYPE *ExecuteAssembly )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ LPCWSTR pwzAssemblyPath,
            /* [in] */ int argc,
            /* [in] */ LPCWSTR *argv,
            /* [out] */ DWORD *pReturnValue);
        
        HRESULT ( STDMETHODCALLTYPE *UnloadAppDomain2 )( 
            ICLRRuntimeHost4 * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ BOOL fWaitUntilDone,
            /* [out] */ int *pLatchedExitCode);
        
        END_INTERFACE
    } ICLRRuntimeHost4Vtbl;

    interface ICLRRuntimeHost4
    {
        CONST_VTBL struct ICLRRuntimeHost4Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICLRRuntimeHost4_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICLRRuntimeHost4_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICLRRuntimeHost4_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICLRRuntimeHost4_Start(This)	\
    ( (This)->lpVtbl -> Start(This) ) 

#define ICLRRuntimeHost4_Stop(This)	\
    ( (This)->lpVtbl -> Stop(This) ) 

#define ICLRRuntimeHost4_SetHostControl(This,pHostControl)	\
    ( (This)->lpVtbl -> SetHostControl(This,pHostControl) ) 

#define ICLRRuntimeHost4_GetCLRControl(This,pCLRControl)	\
    ( (This)->lpVtbl -> GetCLRControl(This,pCLRControl) ) 

#define ICLRRuntimeHost4_UnloadAppDomain(This,dwAppDomainId,fWaitUntilDone)	\
    ( (This)->lpVtbl -> UnloadAppDomain(This,dwAppDomainId,fWaitUntilDone) ) 

#define ICLRRuntimeHost4_ExecuteInAppDomain(This,dwAppDomainId,pCallback,cookie)	\
    ( (This)->lpVtbl -> ExecuteInAppDomain(This,dwAppDomainId,pCallback,cookie) ) 

#define ICLRRuntimeHost4_GetCurrentAppDomainId(This,pdwAppDomainId)	\
    ( (This)->lpVtbl -> GetCurrentAppDomainId(This,pdwAppDomainId) ) 

#define ICLRRuntimeHost4_ExecuteApplication(This,pwzAppFullName,dwManifestPaths,ppwzManifestPaths,dwActivationData,ppwzActivationData,pReturnValue)	\
    ( (This)->lpVtbl -> ExecuteApplication(This,pwzAppFullName,dwManifestPaths,ppwzManifestPaths,dwActivationData,ppwzActivationData,pReturnValue) ) 

#define ICLRRuntimeHost4_ExecuteInDefaultAppDomain(This,pwzAssemblyPath,pwzTypeName,pwzMethodName,pwzArgument,pReturnValue)	\
    ( (This)->lpVtbl -> ExecuteInDefaultAppDomain(This,pwzAssemblyPath,pwzTypeName,pwzMethodName,pwzArgument,pReturnValue) ) 


#define ICLRRuntimeHost4_CreateAppDomainWithManager(This,wszFriendlyName,dwFlags,wszAppDomainManagerAssemblyName,wszAppDomainManagerTypeName,nProperties,pPropertyNames,pPropertyValues,pAppDomainID)	\
    ( (This)->lpVtbl -> CreateAppDomainWithManager(This,wszFriendlyName,dwFlags,wszAppDomainManagerAssemblyName,wszAppDomainManagerTypeName,nProperties,pPropertyNames,pPropertyValues,pAppDomainID) ) 

#define ICLRRuntimeHost4_CreateDelegate(This,appDomainID,wszAssemblyName,wszClassName,wszMethodName,fnPtr)	\
    ( (This)->lpVtbl -> CreateDelegate(This,appDomainID,wszAssemblyName,wszClassName,wszMethodName,fnPtr) ) 

#define ICLRRuntimeHost4_Authenticate(This,authKey)	\
    ( (This)->lpVtbl -> Authenticate(This,authKey) ) 

#define ICLRRuntimeHost4_RegisterMacEHPort(This)	\
    ( (This)->lpVtbl -> RegisterMacEHPort(This) ) 

#define ICLRRuntimeHost4_SetStartupFlags(This,dwFlags)	\
    ( (This)->lpVtbl -> SetStartupFlags(This,dwFlags) ) 

#define ICLRRuntimeHost4_DllGetActivationFactory(This,appDomainID,wszTypeName,factory)	\
    ( (This)->lpVtbl -> DllGetActivationFactory(This,appDomainID,wszTypeName,factory) ) 

#define ICLRRuntimeHost4_ExecuteAssembly(This,dwAppDomainId,pwzAssemblyPath,argc,argv,pReturnValue)	\
    ( (This)->lpVtbl -> ExecuteAssembly(This,dwAppDomainId,pwzAssemblyPath,argc,argv,pReturnValue) ) 


#define ICLRRuntimeHost4_UnloadAppDomain2(This,dwAppDomainId,fWaitUntilDone,pLatchedExitCode)	\
    ( (This)->lpVtbl -> UnloadAppDomain2(This,dwAppDomainId,fWaitUntilDone,pLatchedExitCode) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICLRRuntimeHost4_INTERFACE_DEFINED__ */


#ifndef __ICLRExecutionManager_INTERFACE_DEFINED__
#define __ICLRExecutionManager_INTERFACE_DEFINED__

/* interface ICLRExecutionManager */
/* [object][local][unique][helpstring][version][uuid] */ 


EXTERN_C const IID IID_ICLRExecutionManager;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("1000A3E7-B420-4620-AE30-FB19B587AD1D")
    ICLRExecutionManager : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE Pause( 
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ DWORD dwFlags) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE Resume( 
            /* [in] */ DWORD dwAppDomainId) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ICLRExecutionManagerVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICLRExecutionManager * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICLRExecutionManager * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICLRExecutionManager * This);
        
        HRESULT ( STDMETHODCALLTYPE *Pause )( 
            ICLRExecutionManager * This,
            /* [in] */ DWORD dwAppDomainId,
            /* [in] */ DWORD dwFlags);
        
        HRESULT ( STDMETHODCALLTYPE *Resume )( 
            ICLRExecutionManager * This,
            /* [in] */ DWORD dwAppDomainId);
        
        END_INTERFACE
    } ICLRExecutionManagerVtbl;

    interface ICLRExecutionManager
    {
        CONST_VTBL struct ICLRExecutionManagerVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICLRExecutionManager_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICLRExecutionManager_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICLRExecutionManager_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ICLRExecutionManager_Pause(This,dwAppDomainId,dwFlags)	\
    ( (This)->lpVtbl -> Pause(This,dwAppDomainId,dwFlags) ) 

#define ICLRExecutionManager_Resume(This,dwAppDomainId)	\
    ( (This)->lpVtbl -> Resume(This,dwAppDomainId) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICLRExecutionManager_INTERFACE_DEFINED__ */


/* interface __MIDL_itf_MSCOREE_0000_0009 */
/* [local] */ 

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0009_0001
    {
        eNoChecks	= 0,
        eSynchronization	= 0x1,
        eSharedState	= 0x2,
        eExternalProcessMgmt	= 0x4,
        eSelfAffectingProcessMgmt	= 0x8,
        eExternalThreading	= 0x10,
        eSelfAffectingThreading	= 0x20,
        eSecurityInfrastructure	= 0x40,
        eUI	= 0x80,
        eMayLeakOnAbort	= 0x100,
        eAll	= 0x1ff
    } 	EApiCategories;

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0009_0002
    {
        eInitializeNewDomainFlags_None	= 0,
        eInitializeNewDomainFlags_NoSecurityChanges	= 0x2
    } 	EInitializeNewDomainFlags;



extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0009_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0009_v0_0_s_ifspec;


#ifndef __mscoree_LIBRARY_DEFINED__
#define __mscoree_LIBRARY_DEFINED__

/* library mscoree */
/* [helpstring][version][uuid] */ 

#define CCW_PTR int *

EXTERN_C const IID LIBID_mscoree;

#ifndef __ITypeName_INTERFACE_DEFINED__
#define __ITypeName_INTERFACE_DEFINED__

/* interface ITypeName */
/* [unique][helpstring][uuid][oleautomation][object] */ 


EXTERN_C const IID IID_ITypeName;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("B81FF171-20F3-11d2-8DCC-00A0C9B00522")
    ITypeName : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE GetNameCount( 
            /* [retval][out] */ DWORD *pCount) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetNames( 
            /* [in] */ DWORD count,
            /* [out] */ BSTR *rgbszNames,
            /* [retval][out] */ DWORD *pCount) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetTypeArgumentCount( 
            /* [retval][out] */ DWORD *pCount) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetTypeArguments( 
            /* [in] */ DWORD count,
            /* [out] */ ITypeName **rgpArguments,
            /* [retval][out] */ DWORD *pCount) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetModifierLength( 
            /* [retval][out] */ DWORD *pCount) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetModifiers( 
            /* [in] */ DWORD count,
            /* [out] */ DWORD *rgModifiers,
            /* [retval][out] */ DWORD *pCount) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetAssemblyName( 
            /* [retval][out] */ BSTR *rgbszAssemblyNames) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ITypeNameVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ITypeName * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ITypeName * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ITypeName * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetNameCount )( 
            ITypeName * This,
            /* [retval][out] */ DWORD *pCount);
        
        HRESULT ( STDMETHODCALLTYPE *GetNames )( 
            ITypeName * This,
            /* [in] */ DWORD count,
            /* [out] */ BSTR *rgbszNames,
            /* [retval][out] */ DWORD *pCount);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeArgumentCount )( 
            ITypeName * This,
            /* [retval][out] */ DWORD *pCount);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeArguments )( 
            ITypeName * This,
            /* [in] */ DWORD count,
            /* [out] */ ITypeName **rgpArguments,
            /* [retval][out] */ DWORD *pCount);
        
        HRESULT ( STDMETHODCALLTYPE *GetModifierLength )( 
            ITypeName * This,
            /* [retval][out] */ DWORD *pCount);
        
        HRESULT ( STDMETHODCALLTYPE *GetModifiers )( 
            ITypeName * This,
            /* [in] */ DWORD count,
            /* [out] */ DWORD *rgModifiers,
            /* [retval][out] */ DWORD *pCount);
        
        HRESULT ( STDMETHODCALLTYPE *GetAssemblyName )( 
            ITypeName * This,
            /* [retval][out] */ BSTR *rgbszAssemblyNames);
        
        END_INTERFACE
    } ITypeNameVtbl;

    interface ITypeName
    {
        CONST_VTBL struct ITypeNameVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ITypeName_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ITypeName_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ITypeName_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ITypeName_GetNameCount(This,pCount)	\
    ( (This)->lpVtbl -> GetNameCount(This,pCount) ) 

#define ITypeName_GetNames(This,count,rgbszNames,pCount)	\
    ( (This)->lpVtbl -> GetNames(This,count,rgbszNames,pCount) ) 

#define ITypeName_GetTypeArgumentCount(This,pCount)	\
    ( (This)->lpVtbl -> GetTypeArgumentCount(This,pCount) ) 

#define ITypeName_GetTypeArguments(This,count,rgpArguments,pCount)	\
    ( (This)->lpVtbl -> GetTypeArguments(This,count,rgpArguments,pCount) ) 

#define ITypeName_GetModifierLength(This,pCount)	\
    ( (This)->lpVtbl -> GetModifierLength(This,pCount) ) 

#define ITypeName_GetModifiers(This,count,rgModifiers,pCount)	\
    ( (This)->lpVtbl -> GetModifiers(This,count,rgModifiers,pCount) ) 

#define ITypeName_GetAssemblyName(This,rgbszAssemblyNames)	\
    ( (This)->lpVtbl -> GetAssemblyName(This,rgbszAssemblyNames) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ITypeName_INTERFACE_DEFINED__ */


#ifndef __ITypeNameBuilder_INTERFACE_DEFINED__
#define __ITypeNameBuilder_INTERFACE_DEFINED__

/* interface ITypeNameBuilder */
/* [unique][helpstring][uuid][oleautomation][object] */ 


EXTERN_C const IID IID_ITypeNameBuilder;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("B81FF171-20F3-11d2-8DCC-00A0C9B00523")
    ITypeNameBuilder : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE OpenGenericArguments( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE CloseGenericArguments( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE OpenGenericArgument( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE CloseGenericArgument( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE AddName( 
            /* [in] */ LPCWSTR szName) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE AddPointer( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE AddByRef( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE AddSzArray( void) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE AddArray( 
            /* [in] */ DWORD rank) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE AddAssemblySpec( 
            /* [in] */ LPCWSTR szAssemblySpec) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE ToString( 
            /* [retval][out] */ BSTR *pszStringRepresentation) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE Clear( void) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ITypeNameBuilderVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ITypeNameBuilder * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ITypeNameBuilder * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ITypeNameBuilder * This);
        
        HRESULT ( STDMETHODCALLTYPE *OpenGenericArguments )( 
            ITypeNameBuilder * This);
        
        HRESULT ( STDMETHODCALLTYPE *CloseGenericArguments )( 
            ITypeNameBuilder * This);
        
        HRESULT ( STDMETHODCALLTYPE *OpenGenericArgument )( 
            ITypeNameBuilder * This);
        
        HRESULT ( STDMETHODCALLTYPE *CloseGenericArgument )( 
            ITypeNameBuilder * This);
        
        HRESULT ( STDMETHODCALLTYPE *AddName )( 
            ITypeNameBuilder * This,
            /* [in] */ LPCWSTR szName);
        
        HRESULT ( STDMETHODCALLTYPE *AddPointer )( 
            ITypeNameBuilder * This);
        
        HRESULT ( STDMETHODCALLTYPE *AddByRef )( 
            ITypeNameBuilder * This);
        
        HRESULT ( STDMETHODCALLTYPE *AddSzArray )( 
            ITypeNameBuilder * This);
        
        HRESULT ( STDMETHODCALLTYPE *AddArray )( 
            ITypeNameBuilder * This,
            /* [in] */ DWORD rank);
        
        HRESULT ( STDMETHODCALLTYPE *AddAssemblySpec )( 
            ITypeNameBuilder * This,
            /* [in] */ LPCWSTR szAssemblySpec);
        
        HRESULT ( STDMETHODCALLTYPE *ToString )( 
            ITypeNameBuilder * This,
            /* [retval][out] */ BSTR *pszStringRepresentation);
        
        HRESULT ( STDMETHODCALLTYPE *Clear )( 
            ITypeNameBuilder * This);
        
        END_INTERFACE
    } ITypeNameBuilderVtbl;

    interface ITypeNameBuilder
    {
        CONST_VTBL struct ITypeNameBuilderVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ITypeNameBuilder_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ITypeNameBuilder_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ITypeNameBuilder_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ITypeNameBuilder_OpenGenericArguments(This)	\
    ( (This)->lpVtbl -> OpenGenericArguments(This) ) 

#define ITypeNameBuilder_CloseGenericArguments(This)	\
    ( (This)->lpVtbl -> CloseGenericArguments(This) ) 

#define ITypeNameBuilder_OpenGenericArgument(This)	\
    ( (This)->lpVtbl -> OpenGenericArgument(This) ) 

#define ITypeNameBuilder_CloseGenericArgument(This)	\
    ( (This)->lpVtbl -> CloseGenericArgument(This) ) 

#define ITypeNameBuilder_AddName(This,szName)	\
    ( (This)->lpVtbl -> AddName(This,szName) ) 

#define ITypeNameBuilder_AddPointer(This)	\
    ( (This)->lpVtbl -> AddPointer(This) ) 

#define ITypeNameBuilder_AddByRef(This)	\
    ( (This)->lpVtbl -> AddByRef(This) ) 

#define ITypeNameBuilder_AddSzArray(This)	\
    ( (This)->lpVtbl -> AddSzArray(This) ) 

#define ITypeNameBuilder_AddArray(This,rank)	\
    ( (This)->lpVtbl -> AddArray(This,rank) ) 

#define ITypeNameBuilder_AddAssemblySpec(This,szAssemblySpec)	\
    ( (This)->lpVtbl -> AddAssemblySpec(This,szAssemblySpec) ) 

#define ITypeNameBuilder_ToString(This,pszStringRepresentation)	\
    ( (This)->lpVtbl -> ToString(This,pszStringRepresentation) ) 

#define ITypeNameBuilder_Clear(This)	\
    ( (This)->lpVtbl -> Clear(This) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ITypeNameBuilder_INTERFACE_DEFINED__ */


#ifndef __ITypeNameFactory_INTERFACE_DEFINED__
#define __ITypeNameFactory_INTERFACE_DEFINED__

/* interface ITypeNameFactory */
/* [unique][helpstring][uuid][oleautomation][object] */ 


EXTERN_C const IID IID_ITypeNameFactory;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("B81FF171-20F3-11d2-8DCC-00A0C9B00521")
    ITypeNameFactory : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE ParseTypeName( 
            /* [in] */ LPCWSTR szName,
            /* [out] */ DWORD *pError,
            /* [retval][out] */ ITypeName **ppTypeName) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE GetTypeNameBuilder( 
            /* [retval][out] */ ITypeNameBuilder **ppTypeBuilder) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct ITypeNameFactoryVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ITypeNameFactory * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ITypeNameFactory * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ITypeNameFactory * This);
        
        HRESULT ( STDMETHODCALLTYPE *ParseTypeName )( 
            ITypeNameFactory * This,
            /* [in] */ LPCWSTR szName,
            /* [out] */ DWORD *pError,
            /* [retval][out] */ ITypeName **ppTypeName);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeNameBuilder )( 
            ITypeNameFactory * This,
            /* [retval][out] */ ITypeNameBuilder **ppTypeBuilder);
        
        END_INTERFACE
    } ITypeNameFactoryVtbl;

    interface ITypeNameFactory
    {
        CONST_VTBL struct ITypeNameFactoryVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ITypeNameFactory_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ITypeNameFactory_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ITypeNameFactory_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define ITypeNameFactory_ParseTypeName(This,szName,pError,ppTypeName)	\
    ( (This)->lpVtbl -> ParseTypeName(This,szName,pError,ppTypeName) ) 

#define ITypeNameFactory_GetTypeNameBuilder(This,ppTypeBuilder)	\
    ( (This)->lpVtbl -> GetTypeNameBuilder(This,ppTypeBuilder) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ITypeNameFactory_INTERFACE_DEFINED__ */


EXTERN_C const CLSID CLSID_CLRRuntimeHost;

#ifdef __cplusplus

class DECLSPEC_UUID("90F1A06E-7712-4762-86B5-7A5EBA6BDB02")
CLRRuntimeHost;
#endif

EXTERN_C const CLSID CLSID_TypeNameFactory;

#ifdef __cplusplus

class DECLSPEC_UUID("B81FF171-20F3-11d2-8DCC-00A0C9B00525")
TypeNameFactory;
#endif
#endif /* __mscoree_LIBRARY_DEFINED__ */

/* interface __MIDL_itf_MSCOREE_0000_0010 */
/* [local] */ 

typedef /* [public] */ 
enum __MIDL___MIDL_itf_MSCOREE_0000_0010_0001
    {
        eCurrentContext	= 0,
        eRestrictedContext	= 0x1
    } 	EContextType;

#undef DEPRECATED_CLR_STDAPI
#undef DECLARE_DEPRECATED
#undef DEPRECATED_CLR_API_MESG


extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0010_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_MSCOREE_0000_0010_v0_0_s_ifspec;

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


