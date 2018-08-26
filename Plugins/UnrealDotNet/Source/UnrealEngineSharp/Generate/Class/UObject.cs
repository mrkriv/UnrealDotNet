// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\CoreUObject\Public\UObject\Object.h:36

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
		private static extern void E_UObject_CollectDefaultSubobjects(IntPtr self, IntPtr outDefaultSubobjects, bool bIncludeNestedSubobjects);
		
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
		private static extern void E_UObject_GetArchetypeInstances(IntPtr self, IntPtr instances);
		
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
		private static extern void E_UObject_GetPreloadDependencies(IntPtr self, IntPtr outDeps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_GetPrestreamPackages(IntPtr self, IntPtr outPrestream);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_GetSubobjectsWithStableNamesForNetworking(IntPtr self, IntPtr objList);
		
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
		private static extern void E_UObject_NotifyObjectReferenceEliminated(IntPtr self);
		
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
		private static extern void E_UObject_UpdateClassesExcludedFromDedicatedClient(IntPtr self, IntPtr inClassNames, IntPtr inModulesNames);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_UpdateClassesExcludedFromDedicatedServer(IntPtr self, IntPtr inClassNames, IntPtr inModulesNames);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_UpdateDefaultConfigFile(IntPtr self, string specificFileLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObject_UpdateGlobalUserConfigFile(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public virtual bool AreNativePropertiesIdenticalTo(UObject other)
			=> E_UObject_AreNativePropertiesIdenticalTo(this, other);
		
		
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
		/// <para>Determines if you can create an object from the supplied template in the current context (editor, client only, dedicated server, game/listen) </para>
		/// <para>This calls NeedsLoadForClient & NeedsLoadForServer </para>
		/// </summary>
		public bool CanCreateInCurrentContext(UObject template)
			=> E_UObject_CanCreateInCurrentContext(this, template);
		
		
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
		/// <para>Uses the TArchiveObjectReferenceCollector to build a list of all components referenced by this object which have this object as the outer </para>
		/// <param name="OutDefaultSubobjects">the array that should be populated with the default subobjects "owned" by this object </param>
		/// <param name="bIncludeNestedSubobjects">controls whether subobjects which are contained by this object, but do not have this object </param>
		/// <para>as its direct Outer should be included </para>
		/// </summary>
		public void CollectDefaultSubobjects(TArray<UObject> outDefaultSubobjects, bool bIncludeNestedSubobjects = false)
			=> E_UObject_CollectDefaultSubobjects(this, outDefaultSubobjects, bIncludeNestedSubobjects);
		
		
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
		
		public void ExecuteUbergraph(int entryPoint)
			=> E_UObject_ExecuteUbergraph(this, entryPoint);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public virtual void FinishDestroy()
			=> E_UObject_FinishDestroy(this);
		
		
		/// <summary>
		/// <para>Return the template this object is based on. </para>
		/// <return>the archetype for this object </return>
		/// </summary>
		public UObject GetArchetype()
			=> E_UObject_GetArchetype(this);
		
		
		/// <summary>
		/// <para>Builds a list of objects which have this object in their archetype chain. </para>
		/// <param name="Instances">receives the list of objects which have this one in their archetype chain </param>
		/// </summary>
		public void GetArchetypeInstances(TArray<UObject> instances)
			=> E_UObject_GetArchetypeInstances(this, instances);
		
		
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
		
		
		/// <summary>
		/// <para>Called during cooking. Must return all objects that will be Preload()ed when this is serialized at load time. Only used by the EDL. </para>
		/// <param name="OutDeps">all objects that will be preloaded when this is serialized at load time </param>
		/// </summary>
		public virtual void GetPreloadDependencies(TArray<UObject> outDeps)
			=> E_UObject_GetPreloadDependencies(this, outDeps);
		
		
		/// <summary>
		/// <para>Called during cooking. Returns a list of objects. The packages containing those objects will be prestreamed, when the package containing this is loaded. Only used by the EDL. </para>
		/// <param name="OutPrestream">all objects that will be prestreamed when this packages is streamed </param>
		/// </summary>
		public virtual void GetPrestreamPackages(TArray<UObject> outPrestream)
			=> E_UObject_GetPrestreamPackages(this, outPrestream);
		
		
		/// <summary>
		/// <para>Returns a list of sub-objects that have stable names for networking </para>
		/// </summary>
		public virtual void GetSubobjectsWithStableNamesForNetworking(TArray<UObject> objList)
			=> E_UObject_GetSubobjectsWithStableNamesForNetworking(this, objList);
		
		public virtual UWorld GetWorld()
			=> E_UObject_GetWorld(this);
		
		public UWorld GetWorldChecked(bool bSupported)
			=> E_UObject_GetWorldChecked(this, bSupported);
		
		public bool ImplementsGetWorld()
			=> E_UObject_ImplementsGetWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public virtual bool IsAsset()
			=> E_UObject_IsAsset(this);
		
		
		/// <summary>
		/// <para>Determine if this object has SomeObject in its archetype chain. </para>
		/// </summary>
		public bool IsBasedOnArchetype(UObject someObject)
			=> E_UObject_IsBasedOnArchetype(this, someObject);
		
		
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
		
		public virtual void NotifyObjectReferenceEliminated()
			=> E_UObject_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public virtual void PostCDOContruct()
			=> E_UObject_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after duplication & serialization and before PostLoad. Used to e.g. make sure UStaticMesh's UModel gets copied as well. </para>
		/// <para>Note: NOT called on components on actor duplication (alt-drag or copy-paste).  Use PostEditImport as well to cover that case. </para>
		/// </summary>
		public virtual void PostDuplicate(bool bDuplicateForPIE)
			=> E_UObject_PostDuplicate(this, bDuplicateForPIE);
		
		
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
		public virtual void PostRename(UObject oldOuter, string oldName)
			=> E_UObject_PostRename(this, oldOuter, oldName);
		
		
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
		/// <para>Get the common tag name used for all asset source file import paths </para>
		/// </summary>
		public string SourceFileTagName()
			=> E_UObject_SourceFileTagName(this);
		
		
		/// <summary>
		/// <para>Update the list of classes that we should exclude from dedicated client builds </para>
		/// </summary>
		public void UpdateClassesExcludedFromDedicatedClient(TArray<string> inClassNames, TArray<string> inModulesNames)
			=> E_UObject_UpdateClassesExcludedFromDedicatedClient(this, inClassNames, inModulesNames);
		
		
		/// <summary>
		/// <para>Update the list of classes that we should exclude from dedicated server builds </para>
		/// </summary>
		public void UpdateClassesExcludedFromDedicatedServer(TArray<string> inClassNames, TArray<string> inModulesNames)
			=> E_UObject_UpdateClassesExcludedFromDedicatedServer(this, inClassNames, inModulesNames);
		
		
		/// <summary>
		/// <para>Saves just the section(s) for this class into the default ini file for the class (with just the changes from base) </para>
		/// </summary>
		public void UpdateDefaultConfigFile(string specificFileLocation)
			=> E_UObject_UpdateDefaultConfigFile(this, specificFileLocation);
		
		
		/// <summary>
		/// <para>Saves just the section(s) for this class into the global user ini file for the class (with just the changes from base) </para>
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
