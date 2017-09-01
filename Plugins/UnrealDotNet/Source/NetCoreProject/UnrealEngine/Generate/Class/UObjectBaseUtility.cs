using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class UObjectBaseUtility : UObjectBase
	{
		public UObjectBaseUtility(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObjectBaseUtility_IsPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObjectBaseUtility_MarkPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObjectBaseUtility_IsRooted(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObjectBaseUtility_GetFullName(IntPtr Self, IntPtr StopOuter, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObjectBaseUtility_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObjectBaseUtility_GetPathName(IntPtr Self, IntPtr StopOuter, string ResultString);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObjectBaseUtility_GetFullGroupName(IntPtr Self, bool bStartWithOuter, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObjectBaseUtility_IsIn(IntPtr Self, IntPtr SomeOuter);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_UObjectBaseUtility_GetLinkerIndex(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Checks the PendingKill flag to see if it is dead but memory still valid
		/// </summary>
		public bool IsPendingKill()
			=> E_UObjectBaseUtility_IsPendingKill(NativePointer);
		
		
		/// <summary>
		/// Marks this object as RF_PendingKill.
		/// </summary>
		public void MarkPendingKill()
			=> E_UObjectBaseUtility_MarkPendingKill(NativePointer);
		
		
		/// <summary>
		/// Returns true if this object is explicitly rooted
		/// @return true if the object was explicitly added as part of the root set.
		/// </summary>
		public bool IsRooted()
			=> E_UObjectBaseUtility_IsRooted(NativePointer);
		
		
		/// <summary>
		/// Returns the fully qualified pathname for this object as well as the name of the class, in the format:
		/// 'ClassName Outermost[.Outer].Name'.
		/// @param	StopOuter	if specified, indicates that the output string should be relative to this object.  if StopOuter
		/// does not exist in this object's Outer chain, the result would be the same as passing NULL.
		/// @note	safe to call on NULL object pointers!
		/// </summary>
		public string GetFullName(UObject StopOuter = null)
			=> Marshal.PtrToStringUTF8(E_UObjectBaseUtility_GetFullName(NativePointer, StopOuter, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// Adds this objects to a GC cluster that already exists
		/// @param ClusterRootOrObjectFromCluster Object that belongs to the cluster we want to add this object to.
		/// @param Add this object to the target cluster as a mutable object without adding this object's references.
		/// </summary>
		public void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject = false)
			=> E_UObjectBaseUtility_AddToCluster(NativePointer, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// Internal version of GetPathName() that eliminates lots of copies.
		/// </summary>
		protected void GetPathName(UObject StopOuter, string ResultString)
			=> E_UObjectBaseUtility_GetPathName(NativePointer, StopOuter, ResultString);
		
		
		/// <summary>
		/// Walks up the chain of packages until it reaches the top level, which it ignores.
		/// @param	bStartWithOuter		whether to include this object's name in the returned string
		/// @return	string containing the path name for this object, minus the outermost-package's name
		/// </summary>
		public string GetFullGroupName(bool bStartWithOuter)
			=> Marshal.PtrToStringUTF8(E_UObjectBaseUtility_GetFullGroupName(NativePointer, bStartWithOuter, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// @return	true if the specified object appears somewhere in this object's outer chain.
		/// </summary>
		public bool IsIn(UObject SomeOuter)
			=> E_UObjectBaseUtility_IsIn(NativePointer, SomeOuter);
		
		
		/// <summary>
		/// Returns this object's LinkerIndex.
		/// @return	the index into my linker's ExportMap for the FObjectExport
		/// corresponding to this object.
		/// </summary>
		public int GetLinkerIndex()
			=> E_UObjectBaseUtility_GetLinkerIndex(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(UObjectBaseUtility Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObjectBaseUtility(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UObjectBaseUtility(Adress);
		}}}
