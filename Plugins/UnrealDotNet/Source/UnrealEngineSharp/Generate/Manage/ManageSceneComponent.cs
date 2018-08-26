// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:103

namespace UnrealEngine
{
	[ManageType("ManageSceneComponent")]
	public partial class ManageSceneComponent : USceneComponent
	{
		public ManageSceneComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="DetachmentRules">How to handle transforms & modification when detaching. </param>
		/// </summary>
		public override void DetachFromComponent(FDetachmentTransformRules detachmentRules) { }
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="bMaintainWorldPosition">If true, update the relative location of the component to keep its world position the same </param>
		/// <param name="bCallModify">If true, call Modify() on the component and the current attach parent component </param>
		/// </summary>
		public override void DetachFromParentDeprecated(bool bMaintainWorldPosition, bool bCallModify) { }
		
		
		/// <summary>
		/// <para>Called when AttachParent changes, to allow the scene to update its attachment state. </para>
		/// </summary>
		public override void OnAttachmentChanged() { }
		
		
		/// <summary>
		/// <para>Called after a child scene component is attached to this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildAttached(USceneComponent childComponent) { }
		
		
		/// <summary>
		/// <para>Called after a child scene component is detached from this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildDetached(USceneComponent childComponent) { }
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the hidden in game value of the component. </para>
		/// </summary>
		protected override void OnHiddenInGameChanged() { }
		
		protected override void OnUpdateTransform(EUpdateTransformFlags updateTransformFlags, ETeleportType teleport) { }
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the visibility of the component. </para>
		/// </summary>
		protected override void OnVisibilityChanged() { }
		
		public override void PropagateLightingScenarioChange() { }
		
		
		/// <summary>
		/// <para>Set the non-uniform scale of the component relative to its parent </para>
		/// </summary>
		public override void SetRelativeScale3D(FVector newScale3D) { }
		
		
		/// <summary>
		/// <para>Update the Bounds of the component. </para>
		/// </summary>
		public override void UpdateBounds() { }
		
		
		/// <summary>
		/// <para>Updates the PhysicsVolume of this SceneComponent, if bShouldUpdatePhysicsVolume is true. </para>
		/// <param name="bTriggerNotifiers">if true, send zone/volume change events </param>
		/// </summary>
		public override void UpdatePhysicsVolume(bool bTriggerNotifiers) { }
		
		public static implicit operator IntPtr(ManageSceneComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSceneComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneComponent>(PtrDesc);
		}}}
