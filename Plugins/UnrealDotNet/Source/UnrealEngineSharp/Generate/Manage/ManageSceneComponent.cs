// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneComponent.h:106

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
		/// Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo)
		/// </summary>
		/// <param name="detachmentRules">How to handle transforms & modification when detaching.</param>
		public override void DetachFromComponent(FDetachmentTransformRules detachmentRules) { }
		
		
		/// <summary>
		/// DEPRECATED - Use DetachFromComponent() instead
		/// </summary>
		public override void DetachFromParentDeprecated(bool bMaintainWorldPosition, bool bCallModify) { }
		
		
		/// <summary>
		/// Called when AttachParent changes, to allow the scene to update its attachment state.
		/// </summary>
		public override void OnAttachmentChanged() { }
		
		
		/// <summary>
		/// Called after a child scene component is attached to this component.
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildAttached(USceneComponent childComponent) { }
		
		
		/// <summary>
		/// Called after a child scene component is detached from this component.
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildDetached(USceneComponent childComponent) { }
		
		
		/// <summary>
		/// Overridable internal function to respond to changes in the hidden in game value of the component.
		/// </summary>
		protected override void OnHiddenInGameChanged() { }
		
		
		/// <summary>
		/// Native callback when this component is moved
		/// </summary>
		protected override void OnUpdateTransform(EUpdateTransformFlags updateTransformFlags, ETeleportType teleport) { }
		
		
		/// <summary>
		/// Overridable internal function to respond to changes in the visibility of the component.
		/// </summary>
		protected override void OnVisibilityChanged() { }
		
		
		/// <summary>
		/// Updates any visuals after the lighting has changed
		/// </summary>
		public override void PropagateLightingScenarioChange() { }
		
		
		/// <summary>
		/// Set the non-uniform scale of the component relative to its parent
		/// </summary>
		public override void SetRelativeScale3D(FVector newScale3D) { }
		
		
		/// <summary>
		/// Update the Bounds of the component.
		/// </summary>
		public override void UpdateBounds() { }
		
		
		/// <summary>
		/// Updates the PhysicsVolume of this SceneComponent, if bShouldUpdatePhysicsVolume is true.
		/// </summary>
		/// <param name="bTriggerNotifiers">if true, send zone/volume change events</param>
		public override void UpdatePhysicsVolume(bool bTriggerNotifiers) { }
		
		public static implicit operator IntPtr(ManageSceneComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSceneComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneComponent>(PtrDesc);
		}}}
