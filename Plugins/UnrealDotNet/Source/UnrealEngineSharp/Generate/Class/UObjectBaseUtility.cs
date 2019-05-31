// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\CoreUObject\Public\UObject\UObjectBaseUtility.h:25

namespace UnrealEngine
{
	public  partial class UObjectBaseUtility : UObjectBase
	{
		public UObjectBaseUtility(IntPtr adress)
			: base(adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_AddToCluster(IntPtr self, IntPtr clusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_AddToRoot(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_AppendName(IntPtr self, string resultString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_CanBeClusterRoot(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_CanBeInCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_ClearPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_CreateCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObjectBaseUtility_GetFullGroupName(IntPtr self, bool bStartWithOuter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObjectBaseUtility_GetFullName(IntPtr self, IntPtr stopOuter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UObjectBaseUtility_GetLinkerIndex(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UObjectBaseUtility_GetLinkerUE4Version(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObjectBaseUtility_GetName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_GetName_o1(IntPtr self, string resultString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObjectBaseUtility_GetPathName(IntPtr self, IntPtr stopOuter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_GetPathName_o1(IntPtr self, IntPtr stopOuter, string resultString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsDefaultSubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsIn(IntPtr self, IntPtr someOuter);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsNative(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsPendingKillOrUnreachable(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsRooted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_IsUnreachable(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_MarkPackageDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_MarkPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_OnClusterMarkedAsPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBaseUtility_RemoveFromRoot(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBaseUtility_ThisThreadAtomicallyClearedRFUnreachable(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Adds this objects to a GC cluster that already exists
		/// </summary>
		/// <param name="clusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to.</param>
		/// <param name="add">this object to the target cluster as a mutable object without adding this object's references.</param>
		public void AddToCluster(UObjectBaseUtility clusterRootOrObjectFromCluster, bool bAddAsMutableObject = false)
			=> E_UObjectBaseUtility_AddToCluster(this, clusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// Add an object to the root set. This prevents the object and all
		/// <para>its descendants from being deleted during garbage collection. </para>
		/// </summary>
		public void AddToRoot()
			=> E_UObjectBaseUtility_AddToRoot(this);
		
		
		/// <summary>
		/// Optimized version of GetName that appends to an existing string
		/// </summary>
		public void AppendName(string resultString)
			=> E_UObjectBaseUtility_AppendName(this, resultString);
		
		
		/// <summary>
		/// Called after load to determine if the object can be a cluster root
		/// </summary>
		/// <return>true</return>
		public virtual bool CanBeClusterRoot()
			=> E_UObjectBaseUtility_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// Called during cluster construction if the object can be added to a cluster
		/// </summary>
		/// <return>true</return>
		public virtual bool CanBeInCluster()
			=> E_UObjectBaseUtility_CanBeInCluster(this);
		
		
		/// <summary>
		/// Unmarks this object as PendingKill.
		/// </summary>
		public void ClearPendingKill()
			=> E_UObjectBaseUtility_ClearPendingKill(this);
		
		
		/// <summary>
		/// Called after PostLoad to create UObject cluster
		/// </summary>
		public virtual void CreateCluster()
			=> E_UObjectBaseUtility_CreateCluster(this);
		
		
		/// <summary>
		/// Walks up the chain of packages until it reaches the top level, which it ignores.
		/// </summary>
		/// <param name="bStartWithOuter">whether to include this object's name in the returned string</param>
		/// <return>string</return>
		public string GetFullGroupName(bool bStartWithOuter)
			=> E_UObjectBaseUtility_GetFullGroupName(this, bStartWithOuter);
		
		
		/// <summary>
		/// Returns the fully qualified pathname for this object as well as the name of the class, in the format:
		/// <para>'ClassName Outermost[.Outer].Name'. </para>
		/// does not exist in this object's Outer chain, the result would be the same as passing NULL.
		/// <para>@note	safe to call on NULL object pointers! </para>
		/// </summary>
		/// <param name="stopOuter">if specified, indicates that the output string should be relative to this object.  if StopOuter</param>
		public string GetFullName(UObject stopOuter = null)
			=> E_UObjectBaseUtility_GetFullName(this, stopOuter);
		
		
		/// <summary>
		/// Returns this object's LinkerIndex.
		/// <para>corresponding to this object. </para>
		/// </summary>
		/// <return>the</return>
		public int GetLinkerIndex()
			=> E_UObjectBaseUtility_GetLinkerIndex(this);
		
		
		/// <summary>
		/// Returns the licensee version of the linker for this object.
		/// <para>was last saved, or GPackageFileLicenseeVersion (current version) if </para>
		/// this object does not have a linker, which indicates that
		/// <para>a) this object is a native only class, or </para>
		/// b) this object's linker has been detached, in which case it is already fully loaded
		/// </summary>
		/// <return>the</return>
		public int GetLinkerLicenseeUE4Version()
			=> E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(this);
		
		
		/// <summary>
		/// Returns the UE4 version of the linker for this object.
		/// <para>was last saved, or GPackageFileUE4Version (current version) if </para>
		/// this object does not have a linker, which indicates that
		/// <para>a) this object is a native only class, or </para>
		/// b) this object's linker has been detached, in which case it is already fully loaded
		/// </summary>
		/// <return>the</return>
		public int GetLinkerUE4Version()
			=> E_UObjectBaseUtility_GetLinkerUE4Version(this);
		
		
		/// <summary>
		/// Returns the name of this object (with no path information)
		/// </summary>
		/// <return>Name</return>
		public string GetName()
			=> E_UObjectBaseUtility_GetName(this);
		
		
		/// <summary>
		/// Optimized version of GetName that overwries an existing string
		/// </summary>
		public void GetName(string resultString)
			=> E_UObjectBaseUtility_GetName_o1(this, resultString);
		
		
		/// <summary>
		/// Returns the fully qualified pathname for this object, in the format:
		/// <para>'Outermost[.Outer].Name' </para>
		/// does not exist in this object's Outer chain, the result would be the same as passing NULL.
		/// <para>@note	safe to call on NULL object pointers! </para>
		/// </summary>
		/// <param name="stopOuter">if specified, indicates that the output string should be relative to this object.  if StopOuter</param>
		public string GetPathName(UObject stopOuter = null)
			=> E_UObjectBaseUtility_GetPathName(this, stopOuter);
		
		
		/// <summary>
		/// Internal version of GetPathName() that eliminates lots of copies.
		/// </summary>
		protected void GetPathName(UObject stopOuter, string resultString)
			=> E_UObjectBaseUtility_GetPathName_o1(this, stopOuter, resultString);
		
		
		/// <summary>
		/// Returns whether this component was instanced from a component/subobject template, or if it is a component/subobject template.
		/// <para>This is based on a name comparison with the outer class instance lookup table </para>
		/// </summary>
		/// <return>true</return>
		public bool IsDefaultSubobject()
			=> E_UObjectBaseUtility_IsDefaultSubobject(this);
		
		
		/// <summary>
		/// Returns true if the specified object appears somewhere in this object's outer chain.
		/// </summary>
		public bool IsIn(UObject someOuter)
			=> E_UObjectBaseUtility_IsIn(this, someOuter);
		
		
		/// <summary>
		/// Checks if the object is native.
		/// </summary>
		public bool IsNative()
			=> E_UObjectBaseUtility_IsNative(this);
		
		
		/// <summary>
		/// Checks the PendingKill flag to see if it is dead but memory still valid
		/// </summary>
		public bool IsPendingKill()
			=> E_UObjectBaseUtility_IsPendingKill(this);
		
		
		/// <summary>
		/// Checks if the object is pending kill or unreachable.
		/// </summary>
		public bool IsPendingKillOrUnreachable()
			=> E_UObjectBaseUtility_IsPendingKillOrUnreachable(this);
		
		
		/// <summary>
		/// Returns true if this object is explicitly rooted
		/// </summary>
		/// <return>true</return>
		public bool IsRooted()
			=> E_UObjectBaseUtility_IsRooted(this);
		
		
		/// <summary>
		/// Checks if the object is unreachable.
		/// </summary>
		public bool IsUnreachable()
			=> E_UObjectBaseUtility_IsUnreachable(this);
		
		
		/// <summary>
		/// Finds the outermost package and marks it dirty.
		/// <para>The editor suppresses this behavior during load as it is against policy to dirty packages simply by loading them. </para>
		/// </summary>
		/// <return>false</return>
		public bool MarkPackageDirty()
			=> E_UObjectBaseUtility_MarkPackageDirty(this);
		
		
		/// <summary>
		/// Marks this object as RF_PendingKill.
		/// </summary>
		public void MarkPendingKill()
			=> E_UObjectBaseUtility_MarkPendingKill(this);
		
		
		/// <summary>
		/// Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it.
		/// </summary>
		public virtual void OnClusterMarkedAsPendingKill()
			=> E_UObjectBaseUtility_OnClusterMarkedAsPendingKill(this);
		
		
		/// <summary>
		/// Remove an object from the root set.
		/// </summary>
		public void RemoveFromRoot()
			=> E_UObjectBaseUtility_RemoveFromRoot(this);
		
		
		/// <summary>
		/// Atomically clear the unreachable flag
		/// </summary>
		/// <return>true</return>
		public bool ThisThreadAtomicallyClearedRFUnreachable()
			=> E_UObjectBaseUtility_ThisThreadAtomicallyClearedRFUnreachable(this);
		
		#endregion
		
		public static implicit operator IntPtr(UObjectBaseUtility self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UObjectBaseUtility(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UObjectBaseUtility>(PtrDesc);
		}}}
