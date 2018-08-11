using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\CoreUObject\Public\UObject\UObjectBaseUtility.h:23

namespace UnrealEngine
{
	public  partial class UObjectBaseUtility : UObjectBase
	{
		public UObjectBaseUtility(IntPtr Adress)
			: base(Adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_AddToRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_AppendName(IntPtr Self, string ResultString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_ClearPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObjectBaseUtility_GetFullGroupName(IntPtr Self, bool bStartWithOuter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObjectBaseUtility_GetFullName(IntPtr Self, IntPtr StopOuter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UObjectBaseUtility_GetLinkerIndex(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UObjectBaseUtility_GetLinkerUE4Version(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsDefaultSubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsIn(IntPtr Self, IntPtr SomeOuter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsNative(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsPendingKillOrUnreachable(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsRooted(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsUnreachable(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_MarkPackageDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_MarkPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_RemoveFromRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_ThisThreadAtomicallyClearedRFUnreachable(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public virtual void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_UObjectBaseUtility_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		public void AddToRoot()
			=> E_UObjectBaseUtility_AddToRoot(this);
		
		public void AppendName(string ResultString)
			=> E_UObjectBaseUtility_AppendName(this, ResultString);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public virtual bool CanBeClusterRoot()
			=> E_UObjectBaseUtility_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public virtual bool CanBeInCluster()
			=> E_UObjectBaseUtility_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Unmarks this object as PendingKill. </para>
		/// </summary>
		public void ClearPendingKill()
			=> E_UObjectBaseUtility_ClearPendingKill(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public virtual void CreateCluster()
			=> E_UObjectBaseUtility_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Walks up the chain of packages until it reaches the top level, which it ignores. </para>
		/// <param name="bStartWithOuter">whether to include this object's name in the returned string </param>
		/// <return>string containing the path name for this object, minus the outermost-package's name </return>
		/// </summary>
		public string GetFullGroupName(bool bStartWithOuter)
			=> E_UObjectBaseUtility_GetFullGroupName(this, bStartWithOuter);
		
		
		/// <summary>
		/// <para>Returns the fully qualified pathname for this object as well as the name of the class, in the format: </para>
		/// <para>'ClassName Outermost[.Outer].Name'. </para>
		/// <param name="StopOuter">if specified, indicates that the output string should be relative to this object.  if StopOuter </param>
		/// <para>does not exist in this object's Outer chain, the result would be the same as passing NULL. </para>
		/// <para>@note	safe to call on NULL object pointers! </para>
		/// </summary>
		public string GetFullName(UObject StopOuter = null)
			=> E_UObjectBaseUtility_GetFullName(this, StopOuter);
		
		
		/// <summary>
		/// <para>Returns this object's LinkerIndex. </para>
		/// <return>the index into my linker's ExportMap for the FObjectExport </return>
		/// <para>corresponding to this object. </para>
		/// </summary>
		public int GetLinkerIndex()
			=> E_UObjectBaseUtility_GetLinkerIndex(this);
		
		
		/// <summary>
		/// <para>Returns the licensee version of the linker for this object. </para>
		/// <return>the licensee version of the engine's package file when this object </return>
		/// <para>was last saved, or GPackageFileLicenseeVersion (current version) if </para>
		/// <para>this object does not have a linker, which indicates that </para>
		/// <para>a) this object is a native only class, or </para>
		/// <para>b) this object's linker has been detached, in which case it is already fully loaded </para>
		/// </summary>
		public int GetLinkerLicenseeUE4Version()
			=> E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(this);
		
		
		/// <summary>
		/// <para>Returns the UE4 version of the linker for this object. </para>
		/// <return>the UE4 version of the engine's package file when this object </return>
		/// <para>was last saved, or GPackageFileUE4Version (current version) if </para>
		/// <para>this object does not have a linker, which indicates that </para>
		/// <para>a) this object is a native only class, or </para>
		/// <para>b) this object's linker has been detached, in which case it is already fully loaded </para>
		/// </summary>
		public int GetLinkerUE4Version()
			=> E_UObjectBaseUtility_GetLinkerUE4Version(this);
		
		
		/// <summary>
		/// <para>Returns whether this component was instanced from a component/subobject template, or if it is a component/subobject template. </para>
		/// <para>This is based on a name comparison with the outer class instance lookup table </para>
		/// <return>true if this component was instanced from a template.  false if this component was created manually at runtime. </return>
		/// </summary>
		public bool IsDefaultSubobject()
			=> E_UObjectBaseUtility_IsDefaultSubobject(this);
		
		
		/// <summary>
		/// <return>true if the specified object appears somewhere in this object's outer chain. </return>
		/// </summary>
		public bool IsIn(UObject SomeOuter)
			=> E_UObjectBaseUtility_IsIn(this, SomeOuter);
		
		
		/// <summary>
		/// <para>Checks if the object is native. </para>
		/// </summary>
		public bool IsNative()
			=> E_UObjectBaseUtility_IsNative(this);
		
		
		/// <summary>
		/// <para>Checks the PendingKill flag to see if it is dead but memory still valid </para>
		/// </summary>
		public bool IsPendingKill()
			=> E_UObjectBaseUtility_IsPendingKill(this);
		
		
		/// <summary>
		/// <para>Checks if the object is pending kill or unreachable. </para>
		/// </summary>
		public bool IsPendingKillOrUnreachable()
			=> E_UObjectBaseUtility_IsPendingKillOrUnreachable(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is explicitly rooted </para>
		/// <return>true if the object was explicitly added as part of the root set. </return>
		/// </summary>
		public bool IsRooted()
			=> E_UObjectBaseUtility_IsRooted(this);
		
		
		/// <summary>
		/// <para>Checks if the object is unreachable. </para>
		/// </summary>
		public bool IsUnreachable()
			=> E_UObjectBaseUtility_IsUnreachable(this);
		
		
		/// <summary>
		/// <para>Finds the outermost package and marks it dirty. </para>
		/// <para>The editor suppresses this behavior during load as it is against policy to dirty packages simply by loading them. </para>
		/// <return>false if the request to mark the package dirty was suppressed by the editor and true otherwise. </return>
		/// </summary>
		public bool MarkPackageDirty()
			=> E_UObjectBaseUtility_MarkPackageDirty(this);
		
		
		/// <summary>
		/// <para>Marks this object as RF_PendingKill. </para>
		/// </summary>
		public void MarkPendingKill()
			=> E_UObjectBaseUtility_MarkPendingKill(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public virtual void OnClusterMarkedAsPendingKill()
			=> E_UObjectBaseUtility_OnClusterMarkedAsPendingKill(this);
		
		public void RemoveFromRoot()
			=> E_UObjectBaseUtility_RemoveFromRoot(this);
		
		
		/// <summary>
		/// <para>Atomically clear the unreachable flag </para>
		/// <return>true if we are the thread that cleared RF_Unreachable </return>
		/// </summary>
		public bool ThisThreadAtomicallyClearedRFUnreachable()
			=> E_UObjectBaseUtility_ThisThreadAtomicallyClearedRFUnreachable(this);
		
		#endregion
		
		public static implicit operator IntPtr(UObjectBaseUtility Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObjectBaseUtility(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UObjectBaseUtility>(PtrDesc);
		}}}
