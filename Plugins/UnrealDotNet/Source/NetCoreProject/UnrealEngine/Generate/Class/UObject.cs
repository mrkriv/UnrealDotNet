using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UObject : UObjectBaseUtility
	{
		public UObject(IntPtr Adress)
			: base(Adress)
		{
		}

		public UObject(UObject Parent = null, string Name = "Object")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UObject(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UObject(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_CanCreateInCurrentContext(IntPtr Self, IntPtr Template);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_CanModify(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObject_GetWorldChecked(IntPtr Self, bool bSupported);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_ImplementsGetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_IsSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_ShutdownAfterError(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an </para>
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public virtual void BeginDestroy()
			=> E_UObject_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Determines if you can create an object from the supplied template in the current context (editor, client only, dedicated server, game/listen) </para>
		/// <para>This calls NeedsLoadForClient & NeedsLoadForServer </para>
		/// </summary>
		public bool CanCreateInCurrentContext(UObject Template)
			=> E_UObject_CanCreateInCurrentContext(this, Template);
		
		
		/// <summary>
		/// <para>Utility to allow overrides of Modify to avoid doing work if the base class is not going modify anyways. </para>
		/// </summary>
		public bool CanModify()
			=> E_UObject_CanModify(this);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public virtual void FinishDestroy()
			=> E_UObject_FinishDestroy(this);
		
		public UWorld GetWorldChecked(bool bSupported)
			=> E_UObject_GetWorldChecked(this, bSupported);
		
		public bool ImplementsGetWorld()
			=> E_UObject_ImplementsGetWorld(this);
		
		
		/// <summary>
		/// <para>Test the selection state of a UObject </para>
		/// <return>true if the object is selected, false otherwise. </return>
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		public bool IsSelected()
			=> E_UObject_IsSelected(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public virtual void PostCDOContruct()
			=> E_UObject_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public virtual void PostEditImport()
			=> E_UObject_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor and after the properties have been initialized, including those loaded from config. </para>
		/// <para>mainly this is to emulate some behavior of when the constructor was called after the properties were initialized. </para>
		/// </summary>
		public virtual void PostInitProperties()
			=> E_UObject_PostInitProperties(this);
		
		
		/// <summary>
		/// <para>Do any object-specific cleanup required immediately after loading an object, </para>
		/// <para>and immediately after any undo/redo. </para>
		/// </summary>
		public virtual void PostLoad()
			=> E_UObject_PostLoad(this);
		
		
		/// <summary>
		/// <para>Called right after receiving a bunch </para>
		/// </summary>
		public virtual void PostNetReceive()
			=> E_UObject_PostNetReceive(this);
		
		
		/// <summary>
		/// <para>Test the selection state of a UObject </para>
		/// <return>true if the object is selected, false otherwise. </return>
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		public virtual void PostRename(UObject OldOuter, string OldName)
			=> E_UObject_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public virtual void PostRepNotifies()
			=> E_UObject_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public virtual void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UObject_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public virtual void PreDestroyFromReplication()
			=> E_UObject_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// <para>Called right before receiving a bunch </para>
		/// </summary>
		public virtual void PreNetReceive()
			=> E_UObject_PreNetReceive(this);
		
		public virtual void ShutdownAfterError()
			=> E_UObject_ShutdownAfterError(this);
		
		#endregion
		
		public static implicit operator IntPtr(UObject Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObject(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UObject ?? new UObject(Adress);
		}}}
