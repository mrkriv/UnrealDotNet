using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:603

namespace UnrealEngine
{
	public partial class ManageEngine : UEngine
	{
		public ManageEngine(IntPtr Adress)
			: base(Adress)
		{
		}

		public override void FinishDestroy() { }
		
		
		/// <summary>
		/// <para>Called at shutdown, just before the exit purge. </para>
		/// </summary>
		public override void PreExit() { }
		
		public override void ShutdownAudioDeviceManager() { }
		
		
		/// <summary>
		/// <para>Start the game, separate from the initialize call to allow for post initialize configuration before the game starts. </para>
		/// </summary>
		public override void Start() { }
		
		
		/// <summary>
		/// <para>Update everything. </para>
		/// </summary>
		public override void Tick(float DeltaSeconds, bool bIdleMode) { }
		
		
		/// <summary>
		/// <para>Needs to be called when a world is added to broadcast messages. </para>
		/// </summary>
		public override void WorldAdded(UWorld World) { }
		
		
		/// <summary>
		/// <para>Needs to be called when a world is destroyed to broadcast messages. </para>
		/// </summary>
		public override void WorldDestroyed(UWorld InWorld) { }
		
		
		/// <summary>
		/// <para>Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an </para>
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy() { }
		
		public override void MarkAsEditorOnlySubobject() { }
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct() { }
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport() { }
		
		
		/// <summary>
		/// <para>Called after the C++ constructor and after the properties have been initialized, including those loaded from config. </para>
		/// <para>mainly this is to emulate some behavior of when the constructor was called after the properties were initialized. </para>
		/// </summary>
		public override void PostInitProperties() { }
		
		
		/// <summary>
		/// <para>Do any object-specific cleanup required immediately after loading an object, </para>
		/// <para>and immediately after any undo/redo. </para>
		/// </summary>
		public override void PostLoad() { }
		
		
		/// <summary>
		/// <para>Called right after receiving a bunch </para>
		/// </summary>
		public override void PostNetReceive() { }
		
		
		/// <summary>
		/// <para>Test the selection state of a UObject </para>
		/// <return>true if the object is selected, false otherwise. </return>
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		public override void PostRename(UObject OldOuter, string OldName) { }
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies() { }
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired) { }
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication() { }
		
		
		/// <summary>
		/// <para>Called right before receiving a bunch </para>
		/// </summary>
		public override void PreNetReceive() { }
		
		public override void ShutdownAfterError() { }
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject) { }
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster() { }
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill() { }
		
		public static implicit operator IntPtr(ManageEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageEngine(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageEngine>(PtrDesc);
		}}}
