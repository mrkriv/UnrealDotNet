// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\CoreUObject\Public\UObject\Object.h:45

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UObject(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_AbortInsideMemberFunction(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_AreNativePropertiesIdenticalTo(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_BeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CanCheckDefaultSubObjects(IntPtr self, bool bForceCheck, bool bResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CanCreateInCurrentContext(IntPtr self, IntPtr template);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CanModify(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CheckDefaultSubobjects(IntPtr self, bool bForceCheck);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_CheckDefaultSubobjectsInternal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_ConditionalBeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_ConditionalFinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_ConditionalPostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_DestroyNonNativeProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_ExecuteUbergraph(IntPtr self, int entryPoint);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_FinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UObject_GetArchetype(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetDefaultConfigFilename(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetDesc(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetDetailedInfo(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetDetailedInfoInternal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_GetGlobalUserConfigFilename(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UObject_GetWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UObject_GetWorldChecked(IntPtr self, bool bSupported);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_ImplementsGetWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsAsset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsBasedOnArchetype(IntPtr self, IntPtr someObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsEditorOnly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsFullNameStableForNetworking(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsInBlueprint(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsLocalizedResource(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsNameStableForNetworking(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsPostLoadThreadSafe(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsReadyForFinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsSafeForRootSet(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsSelected(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_IsSupportedForNetworking(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_MarkAsEditorOnlySubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_Modify(IntPtr self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_NeedsLoadForClient(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_NeedsLoadForEditorGame(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObject_NeedsLoadForServer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_OverridePerObjectConfigSection(IntPtr self, string sectionName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostCDOContruct(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostDuplicate(IntPtr self, bool bDuplicateForPIE);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostEditImport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostInitProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostRename(IntPtr self, IntPtr oldOuter, string oldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostRepNotifies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PostSaveRoot(IntPtr self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PreDestroyFromReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_PreNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_ShutdownAfterError(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObject_SourceFileTagName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_UpdateDefaultConfigFile(IntPtr self, string specificFileLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_UpdateGlobalUserConfigFile(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Abort with a member function call at the top of the callstack, helping to ensure that most platforms will stuff this object's memory into the resulting minidump.
		/// </summary>
		public void AbortInsideMemberFunction()
			=> E_UObject_AbortInsideMemberFunction(this);
		
		
		/// <summary>
		/// Returns whether native properties are identical to the one of the passed in component.
		/// </summary>
		/// <param name="other">Other component to compare against</param>
		/// <return>true</return>
		public virtual bool AreNativePropertiesIdenticalTo(UObject other)
			=> E_UObject_AreNativePropertiesIdenticalTo(this, other);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public virtual void BeginDestroy()
			=> E_UObject_BeginDestroy(this);
		
		
		/// <summary>
		/// Checks it's ok to perform subobjects check at this time.
		/// </summary>
		protected bool CanCheckDefaultSubObjects(bool bForceCheck, bool bResult)
			=> E_UObject_CanCheckDefaultSubObjects(this, bForceCheck, bResult);
		
		
		/// <summary>
		/// Determines if you can create an object from the supplied template in the current context (editor, client only, dedicated server, game/listen)
		/// <para>This calls NeedsLoadForClient & NeedsLoadForServer </para>
		/// </summary>
		public bool CanCreateInCurrentContext(UObject template)
			=> E_UObject_CanCreateInCurrentContext(this, template);
		
		
		/// <summary>
		/// Utility to allow overrides of Modify to avoid doing work if this object cannot be safely modified
		/// </summary>
		public bool CanModify()
			=> E_UObject_CanModify(this);
		
		
		/// <summary>
		/// Checks default sub-object assumptions.
		/// </summary>
		/// <param name="bForceCheck">Force checks even if not enabled globally.</param>
		/// <return>true</return>
		public bool CheckDefaultSubobjects(bool bForceCheck = false)
			=> E_UObject_CheckDefaultSubobjects(this, bForceCheck);
		
		
		/// <summary>
		/// Checks default sub-object assumptions.
		/// </summary>
		/// <return>true</return>
		protected virtual bool CheckDefaultSubobjectsInternal()
			=> E_UObject_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public bool ConditionalBeginDestroy()
			=> E_UObject_ConditionalBeginDestroy(this);
		
		
		/// <summary>
		/// Called when an object is actually destroyed, memory should never be accessed again
		/// </summary>
		public bool ConditionalFinishDestroy()
			=> E_UObject_ConditionalFinishDestroy(this);
		
		
		/// <summary>
		/// PostLoad if needed.
		/// </summary>
		public void ConditionalPostLoad()
			=> E_UObject_ConditionalPostLoad(this);
		
		
		/// <summary>
		/// Destroy properties that won't be destroyed by the native destructor
		/// </summary>
		public void DestroyNonNativeProperties()
			=> E_UObject_DestroyNonNativeProperties(this);
		
		
		/// <summary>
		/// Execute the ubergraph from a specific entry point
		/// </summary>
		public void ExecuteUbergraph(int entryPoint)
			=> E_UObject_ExecuteUbergraph(this, entryPoint);
		
		
		/// <summary>
		/// Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed.
		/// <para>@warning Because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public virtual void FinishDestroy()
			=> E_UObject_FinishDestroy(this);
		
		
		/// <summary>
		/// Return the template this object is based on.
		/// </summary>
		/// <return>the</return>
		public UObject GetArchetype()
			=> E_UObject_GetArchetype(this);
		
		
		/// <summary>
		/// Get the default config filename for the specified UObject
		/// </summary>
		public string GetDefaultConfigFilename()
			=> E_UObject_GetDefaultConfigFilename(this);
		
		
		/// <summary>
		/// Return a one line description of an object for viewing in the thumbnail view of the generic browser
		/// </summary>
		public virtual string GetDesc()
			=> E_UObject_GetDesc(this);
		
		
		/// <summary>
		/// This will return detail info about this specific object. (e.g. AudioComponent will return the name of the cue,
		/// <para>ParticleSystemComponent will return the name of the ParticleSystem)  The idea here is that in many places </para>
		/// you have a component of interest but what you really want is some characteristic that you can use to track
		/// <para>down where it came from. </para>
		/// @note	safe to call on NULL object pointers!
		/// </summary>
		public string GetDetailedInfo()
			=> E_UObject_GetDetailedInfo(this);
		
		
		/// <summary>
		/// This function actually does the work for the GetDetailedInfo() and is virtual.
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		protected virtual string GetDetailedInfoInternal()
			=> E_UObject_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// Get the global user override config filename for the specified UObject
		/// </summary>
		public string GetGlobalUserConfigFilename()
			=> E_UObject_GetGlobalUserConfigFilename(this);
		
		
		/// <summary>
		/// Returns what UWorld this object is contained within.
		/// <para>By default this will follow its Outer chain, but it should be overridden if that will not work. </para>
		/// </summary>
		public virtual UWorld GetWorld()
			=> E_UObject_GetWorld(this);
		
		
		/// <summary>
		/// Internal function used by UEngine::GetWorldFromContextObject()
		/// </summary>
		public UWorld GetWorldChecked(bool bSupported)
			=> E_UObject_GetWorldChecked(this, bSupported);
		
		
		/// <summary>
		/// Checks to see if GetWorld() is implemented on a specific class
		/// </summary>
		public bool ImplementsGetWorld()
			=> E_UObject_ImplementsGetWorld(this);
		
		
		/// <summary>
		/// Returns true if this object is considered an asset.
		/// </summary>
		public virtual bool IsAsset()
			=> E_UObject_IsAsset(this);
		
		
		/// <summary>
		/// Determine if this object has SomeObject in its archetype chain.
		/// </summary>
		public bool IsBasedOnArchetype(UObject someObject)
			=> E_UObject_IsBasedOnArchetype(this, someObject);
		
		
		/// <summary>
		/// Called during saving to determine if the object is forced to be editor only or not
		/// </summary>
		/// <return>true</return>
		public virtual bool IsEditorOnly()
			=> E_UObject_IsEditorOnly(this);
		
		
		/// <summary>
		/// IsFullNameStableForNetworking means an object can be referred to its full path name over the network
		/// </summary>
		public virtual bool IsFullNameStableForNetworking()
			=> E_UObject_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// Returns whether this object is contained in or part of a blueprint object
		/// </summary>
		public bool IsInBlueprint()
			=> E_UObject_IsInBlueprint(this);
		
		
		/// <summary>
		/// Returns true if this object is considered a localized resource.
		/// </summary>
		public virtual bool IsLocalizedResource()
			=> E_UObject_IsLocalizedResource(this);
		
		
		/// <summary>
		/// IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network
		/// </summary>
		public virtual bool IsNameStableForNetworking()
			=> E_UObject_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// Called during async load to determine if PostLoad can be called on the loading thread.
		/// </summary>
		/// <return>true</return>
		public virtual bool IsPostLoadThreadSafe()
			=> E_UObject_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the
		/// <para>potentially asynchronous object cleanup. </para>
		/// </summary>
		/// <return>True</return>
		public virtual bool IsReadyForFinishDestroy()
			=> E_UObject_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// Returns true if this object is safe to add to the root set.
		/// </summary>
		public virtual bool IsSafeForRootSet()
			=> E_UObject_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// Test the selection state of a UObject
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		/// <return>true</return>
		public bool IsSelected()
			=> E_UObject_IsSelected(this);
		
		
		/// <summary>
		/// IsSupportedForNetworking means an object can be referenced over the network
		/// </summary>
		public virtual bool IsSupportedForNetworking()
			=> E_UObject_IsSupportedForNetworking(this);
		
		
		/// <summary>
		/// Called during subobject creation to mark this component as editor only, which causes it to get stripped in packaged builds
		/// </summary>
		public virtual void MarkAsEditorOnlySubobject()
			=> E_UObject_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// Note that the object will be modified.  If we are currently recording into the
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// marks the package as needing to be saved.
		/// <para>currently recording an active undo/redo transaction </para>
		/// </summary>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't</param>
		/// <return>true</return>
		public virtual bool Modify(bool bAlwaysMarkDirty)
			=> E_UObject_Modify(this, bAlwaysMarkDirty);
		
		
		/// <summary>
		/// Called during saving to determine the load flags to save with the object.
		/// <para>If false, this object will be discarded on clients </para>
		/// </summary>
		/// <return>true</return>
		public virtual bool NeedsLoadForClient()
			=> E_UObject_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// Called during saving to include this object in client/servers running in editor builds, even if they wouldn't normally be.
		/// <para>If false, this object will still get loaded if NeedsLoadForServer/Client are true </para>
		/// </summary>
		/// <return>true</return>
		public virtual bool NeedsLoadForEditorGame()
			=> E_UObject_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// Called during saving to determine the load flags to save with the object.
		/// <para>If false, this object will be discarded on servers </para>
		/// </summary>
		/// <return>true</return>
		public virtual bool NeedsLoadForServer()
			=> E_UObject_NeedsLoadForServer(this);
		
		
		/// <summary>
		/// Allows PerObjectConfig classes, to override the ini section name used for the PerObjectConfig object.
		/// </summary>
		/// <param name="sectionName">Reference to the unmodified config section name, that can be altered/modified</param>
		public virtual void OverridePerObjectConfigSection(string sectionName)
			=> E_UObject_OverridePerObjectConfigSection(this, sectionName);
		
		
		/// <summary>
		/// Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public virtual void PostCDOContruct()
			=> E_UObject_PostCDOContruct(this);
		
		
		/// <summary>
		/// Called after duplication & serialization and before PostLoad. Used to e.g. make sure UStaticMesh's UModel gets copied as well.
		/// <para>Note: NOT called on components on actor duplication (alt-drag or copy-paste).  Use PostEditImport as well to cover that case. </para>
		/// </summary>
		public virtual void PostDuplicate(bool bDuplicateForPIE)
			=> E_UObject_PostDuplicate(this, bDuplicateForPIE);
		
		
		/// <summary>
		/// Called after importing property values for this object (paste, duplicate or .t3d import)
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// are unsupported by the script serialization
		/// </summary>
		public virtual void PostEditImport()
			=> E_UObject_PostEditImport(this);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// <para>This is called before any serialization or other setup has happened. </para>
		/// </summary>
		public virtual void PostInitProperties()
			=> E_UObject_PostInitProperties(this);
		
		
		/// <summary>
		/// Do any object-specific cleanup required immediately after loading an object.
		/// <para>This is not called for newly-created objects, and by default will always execute on the game thread. </para>
		/// </summary>
		public virtual void PostLoad()
			=> E_UObject_PostLoad(this);
		
		
		/// <summary>
		/// Called right after receiving a bunch
		/// </summary>
		public virtual void PostNetReceive()
			=> E_UObject_PostNetReceive(this);
		
		
		/// <summary>
		/// Called at the end of Rename(), but only if the rename was actually carried out
		/// </summary>
		public virtual void PostRename(UObject oldOuter, string oldName)
			=> E_UObject_PostRename(this, oldOuter, oldName);
		
		
		/// <summary>
		/// Called right after calling all OnRep notifies (called even when there are no notifies)
		/// </summary>
		public virtual void PostRepNotifies()
			=> E_UObject_PostRepNotifies(this);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/root object.
		/// <para>This function is called after the package has been saved and can perform cleanup. </para>
		/// </summary>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up</param>
		public virtual void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UObject_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// Called right before being marked for destruction due to network replication
		/// </summary>
		public virtual void PreDestroyFromReplication()
			=> E_UObject_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// Called right before receiving a bunch
		/// </summary>
		public virtual void PreNetReceive()
			=> E_UObject_PreNetReceive(this);
		
		
		/// <summary>
		/// After a critical error, perform any mission-critical cleanup, such as restoring the video mode orreleasing hardware resources.
		/// </summary>
		public virtual void ShutdownAfterError()
			=> E_UObject_ShutdownAfterError(this);
		
		
		/// <summary>
		/// Get the common tag name used for all asset source file import paths
		/// </summary>
		public string SourceFileTagName()
			=> E_UObject_SourceFileTagName(this);
		
		
		/// <summary>
		/// Saves just the section(s) for this class into the default ini file for the class (with just the changes from base)
		/// </summary>
		public void UpdateDefaultConfigFile(string specificFileLocation)
			=> E_UObject_UpdateDefaultConfigFile(this, specificFileLocation);
		
		
		/// <summary>
		/// Saves just the section(s) for this class into the global user ini file for the class (with just the changes from base)
		/// </summary>
		public void UpdateGlobalUserConfigFile()
			=> E_UObject_UpdateGlobalUserConfigFile(this);
		
		#endregion
		
		public static implicit operator IntPtr(UObject self)
		{
			return self.NativePointer;
		}

		public static implicit operator UObject(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UObject>(PtrDesc);
		}}}
