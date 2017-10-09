using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Object.h:35

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
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UObject(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CanCheckDefaultSubObjects(IntPtr Self, bool bForceCheck, bool bResult);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CanModify(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CheckDefaultSubobjects(IntPtr Self, bool bForceCheck);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_ConditionalBeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_ConditionalFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_ConditionalPostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_DestroyNonNativeProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_ExecuteUbergraph(IntPtr Self, int EntryPoint);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetDefaultConfigFilename(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetDetailedInfo(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetGlobalUserConfigFilename(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_ImplementsGetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsInBlueprint(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_UpdateDefaultConfigFile(IntPtr Self, string SpecificFileLocation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_UpdateGlobalUserConfigFile(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an </para>
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public virtual void BeginDestroy()
			=> E_UObject_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Checks it's ok to perform subobjects check at this time. </para>
		/// </summary>
		protected bool CanCheckDefaultSubObjects(bool bForceCheck, bool bResult)
			=> E_UObject_CanCheckDefaultSubObjects(this, bForceCheck, bResult);
		
		
		/// <summary>
		/// <para>Utility to allow overrides of Modify to avoid doing work if the base class is not going modify anyways. </para>
		/// </summary>
		public bool CanModify()
			=> E_UObject_CanModify(this);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <param name="bForceCheck">Force checks even if not enabled globally. </param>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public bool CheckDefaultSubobjects(bool bForceCheck = false)
			=> E_UObject_CheckDefaultSubobjects(this, bForceCheck);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		protected virtual bool CheckDefaultSubobjectsInternal()
			=> E_UObject_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an </para>
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public bool ConditionalBeginDestroy()
			=> E_UObject_ConditionalBeginDestroy(this);
		
		public bool ConditionalFinishDestroy()
			=> E_UObject_ConditionalFinishDestroy(this);
		
		
		/// <summary>
		/// <para>PostLoad if needed. </para>
		/// </summary>
		public void ConditionalPostLoad()
			=> E_UObject_ConditionalPostLoad(this);
		
		
		/// <summary>
		/// <para>Destroy properties that won't be destroyed by the native destructor </para>
		/// </summary>
		public void DestroyNonNativeProperties()
			=> E_UObject_DestroyNonNativeProperties(this);
		
		public void ExecuteUbergraph(int EntryPoint)
			=> E_UObject_ExecuteUbergraph(this, EntryPoint);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public virtual void FinishDestroy()
			=> E_UObject_FinishDestroy(this);
		
		
		/// <summary>
		/// <para>Get the default config filename for the specified UObject </para>
		/// </summary>
		public string GetDefaultConfigFilename()
			=> E_UObject_GetDefaultConfigFilename(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public virtual string GetDesc()
			=> E_UObject_GetDesc(this);
		
		
		/// <summary>
		/// <para>This will return detail info about this specific object. (e.g. AudioComponent will return the name of the cue, </para>
		/// <para>ParticleSystemComponent will return the name of the ParticleSystem)  The idea here is that in many places </para>
		/// <para>you have a component of interest but what you really want is some characteristic that you can use to track </para>
		/// <para>down where it came from. </para>
		/// <para>@note	safe to call on NULL object pointers! </para>
		/// </summary>
		public string GetDetailedInfo()
			=> E_UObject_GetDetailedInfo(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		protected virtual string GetDetailedInfoInternal()
			=> E_UObject_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Get the global user override config filename for the specified UObject </para>
		/// </summary>
		public string GetGlobalUserConfigFilename()
			=> E_UObject_GetGlobalUserConfigFilename(this);
		
		public bool ImplementsGetWorld()
			=> E_UObject_ImplementsGetWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public virtual bool IsAsset()
			=> E_UObject_IsAsset(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine if the object is forced to be editor only or not </para>
		/// <return>true if this object should never be loaded outside the editor </return>
		/// </summary>
		public virtual bool IsEditorOnly()
			=> E_UObject_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public virtual bool IsFullNameStableForNetworking()
			=> E_UObject_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns whether this object is contained in or part of a blueprint object </para>
		/// </summary>
		public bool IsInBlueprint()
			=> E_UObject_IsInBlueprint(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public virtual bool IsLocalizedResource()
			=> E_UObject_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public virtual bool IsNameStableForNetworking()
			=> E_UObject_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public virtual bool IsPostLoadThreadSafe()
			=> E_UObject_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the </para>
		/// <para>potentially asynchronous object cleanup. </para>
		/// <return>True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called. </return>
		/// </summary>
		public virtual bool IsReadyForFinishDestroy()
			=> E_UObject_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public virtual bool IsSafeForRootSet()
			=> E_UObject_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>Test the selection state of a UObject </para>
		/// <return>true if the object is selected, false otherwise. </return>
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		public bool IsSelected()
			=> E_UObject_IsSelected(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public virtual bool IsSupportedForNetworking()
			=> E_UObject_IsSupportedForNetworking(this);
		
		public virtual void MarkAsEditorOnlySubobject()
			=> E_UObject_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public virtual bool Modify(bool bAlwaysMarkDirty)
			=> E_UObject_Modify(this, bAlwaysMarkDirty);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on clients </para>
		/// <return>true if this object should be loaded on clients </return>
		/// </summary>
		public virtual bool NeedsLoadForClient()
			=> E_UObject_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will still get loaded if NeedsLoadForServer/Client are true </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public virtual bool NeedsLoadForEditorGame()
			=> E_UObject_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on servers </para>
		/// <return>true if this object should be loaded on servers </return>
		/// </summary>
		public virtual bool NeedsLoadForServer()
			=> E_UObject_NeedsLoadForServer(this);
		
		
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
		
		
		/// <summary>
		/// <para>Saves just the section(s) for this class into the default ini file for the class (with just the changes from base) </para>
		/// </summary>
		public void UpdateDefaultConfigFile(string SpecificFileLocation)
			=> E_UObject_UpdateDefaultConfigFile(this, SpecificFileLocation);
		
		
		/// <summary>
		/// <para>Saves just the section(s) for this class into the global user ini file for the class (with just the changes from base) </para>
		/// </summary>
		public void UpdateGlobalUserConfigFile()
			=> E_UObject_UpdateGlobalUserConfigFile(this);
		
		#endregion
		
		public static implicit operator IntPtr(UObject Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObject(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UObject>(PtrDesc);
		}}}
