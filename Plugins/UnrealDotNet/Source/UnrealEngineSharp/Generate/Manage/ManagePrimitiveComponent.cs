// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:172

namespace UnrealEngine
{
	[ManageType("ManagePrimitiveComponent")]
	public partial class ManagePrimitiveComponent : UPrimitiveComponent
	{
		public ManagePrimitiveComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddAngularImpulse(FVector impulse, string boneName, bool bVelChange) { }
		
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddAngularImpulseInRadians(FVector impulse, string boneName, bool bVelChange) { }
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect). </param>
		/// </summary>
		public override void AddForce(FVector force, string boneName, bool bAccelChange) { }
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location in world space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in world space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddForceAtLocation(FVector force, FVector location, string boneName) { }
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location. Both Force and Location should be in body space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in component space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddForceAtLocationLocal(FVector force, FVector location, string boneName) { }
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddImpulse(FVector impulse, string boneName, bool bVelChange) { }
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body at a specific location. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="Location">Point in world space to apply impulse at. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddImpulseAtLocation(FVector impulse, FVector location, string boneName) { }
		
		
		/// <summary>
		/// <para>Add a force to all bodies in this component, originating from the supplied world-space location. </para>
		/// <param name="Origin">Origin of force in world space. </param>
		/// <param name="Radius">Radius within which to apply the force. </param>
		/// <param name="Strength">Strength of force to apply. </param>
		/// <param name="Falloff">Allows you to control the strength of the force as a function of distance from Origin. </param>
		/// <param name="bAccelChange">If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialForce(FVector origin, float radius, float strength, ERadialImpulseFalloff falloff, bool bAccelChange) { }
		
		
		/// <summary>
		/// <para>Add an impulse to all rigid bodies in this component, radiating out from the specified position. </para>
		/// <param name="Origin">Point of origin for the radial impulse blast, in world space </param>
		/// <param name="Radius">Size of radial impulse. Beyond this distance from Origin, there will be no affect. </param>
		/// <param name="Strength">Maximum strength of impulse applied to body. </param>
		/// <param name="Falloff">Allows you to control the strength of the impulse as a function of distance from Origin. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialImpulse(FVector origin, float radius, float strength, ERadialImpulseFalloff falloff, bool bVelChange) { }
		
		
		/// <summary>
		/// <para>Add a torque to a single rigid body. </para>
		/// <param name="Torque">Torque to apply. Direction is axis of rotation and magnitude is strength of torque. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect). </param>
		/// </summary>
		public override void AddTorqueInRadians(FVector torque, string boneName, bool bAccelChange) { }
		
		
		/// <summary>
		/// <para>Called when the BodyInstance ResponseToChannels, CollisionEnabled or bNotifyRigidBodyCollision changes, in case subclasses want to use that information. </para>
		/// </summary>
		protected override void OnComponentCollisionSettingsChanged() { }
		
		
		/// <summary>
		/// <para>Force all bodies in this component to sleep. </para>
		/// </summary>
		public override void PutAllRigidBodiesToSleep() { }
		
		
		/// <summary>
		/// <para>Change the mass scale used fo all bodies in this component </para>
		/// </summary>
		public override void SetAllMassScale(float inMassScale) { }
		
		
		/// <summary>
		/// <para>Set the angular velocity of all bodies in this component. </para>
		/// <param name="NewAngVel">New angular velocity to apply to physics, in radians per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies. </param>
		/// </summary>
		public override void SetAllPhysicsAngularVelocityInRadians(FVector newAngVel, bool bAddToCurrent) { }
		
		
		/// <summary>
		/// <para>Set the linear velocity of all bodies in this component. </para>
		/// <param name="NewVel">New linear velocity to apply to physics. </param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body. </param>
		/// </summary>
		public override void SetAllPhysicsLinearVelocity(FVector newVel, bool bAddToCurrent) { }
		
		
		/// <summary>
		/// <para>Set the position of all bodies in this component. </para>
		/// <para>If a SkeletalMeshComponent, the root body will be placed at the desired position, and the same delta is applied to all other bodies. </para>
		/// <param name="NewPos">New position for the body </param>
		/// </summary>
		public override void SetAllPhysicsPosition(FVector newPos) { }
		
		
		/// <summary>
		/// <para>Set the rotation of all bodies in this component. </para>
		/// <para>If a SkeletalMeshComponent, the root body will be changed to the desired orientation, and the same delta is applied to all other bodies. </para>
		/// <param name="NewRot">New orienatation for the body </param>
		/// </summary>
		public override void SetAllPhysicsRotation(FRotator newRot) { }
		
		
		/// <summary>
		/// <para>Set the rotation of all bodies in this component. </para>
		/// <para>If a SkeletalMeshComponent, the root body will be changed to the desired orientation, and the same delta is applied to all other bodies. </para>
		/// <param name="NewRot">New orienatation for the body </param>
		/// </summary>
		public override void SetAllPhysicsRotation(FQuat newRot) { }
		
		
		/// <summary>
		/// <para>Set whether all bodies in this component should use Continuous Collision Detection </para>
		/// </summary>
		public override void SetAllUseCCD(bool inUseCCD) { }
		
		
		/// <summary>
		/// <para>Sets the angular damping of this component. </para>
		/// </summary>
		public override void SetAngularDamping(float inDamping) { }
		
		
		/// <summary>
		/// <para>Changes the collision channel that this object uses when it moves </para>
		/// <param name="Channel">The new channel for this component to use </param>
		/// </summary>
		public override void SetCollisionObjectType(ECollisionChannel channel) { }
		
		
		/// <summary>
		/// <para>Set Collision Profile Name </para>
		/// <para>This function is called by constructors when they set ProfileName </para>
		/// <para>This will change current CollisionProfileName to be this, and overwrite Collision Setting </para>
		/// <param name="InCollisionProfileName">New Profile Name </param>
		/// </summary>
		public override void SetCollisionProfileName(string inCollisionProfileName) { }
		
		
		/// <summary>
		/// <para>Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse </para>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public override void SetCollisionResponseToAllChannels(ECollisionResponse newResponse) { }
		
		
		/// <summary>
		/// <para>Changes a member of the ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="Channel">The channel to change the response of </param>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public override void SetCollisionResponseToChannel(ECollisionChannel channel, ECollisionResponse newResponse) { }
		
		
		/// <summary>
		/// <para>Changes the whole ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="NewResponses">New set of responses for this component </param>
		/// </summary>
		public override void SetCollisionResponseToChannels(FCollisionResponseContainer newReponses) { }
		
		
		/// <summary>
		/// <para>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true. </para>
		/// </summary>
		public override void SetEnableGravity(bool bGravityEnabled) { }
		
		
		/// <summary>
		/// <para>Sets the linear damping of this component. </para>
		/// </summary>
		public override void SetLinearDamping(float inDamping) { }
		
		
		/// <summary>
		/// <para>Override the mass (in Kg) of a single physics body. </para>
		/// <para>Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group. </para>
		/// <para>Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass. </para>
		/// </summary>
		public override void SetMassOverrideInKg(string boneName, float massInKg, bool bOverrideMass) { }
		
		
		/// <summary>
		/// <para>Change the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public override void SetMassScale(string boneName, float inMassScale) { }
		
		
		/// <summary>
		/// <para>Changes the value of bNotifyRigidBodyCollision </para>
		/// </summary>
		public override void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision) { }
		
		
		/// <summary>
		/// <para>Set the angular velocity of a single body. </para>
		/// <para>This should be used cautiously - it may be better to use AddTorque or AddImpulse. </para>
		/// <param name="NewAngVel">New angular velocity to apply to body, in radians per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public override void SetPhysicsAngularVelocityInRadians(FVector newAngVel, bool bAddToCurrent, string boneName) { }
		
		
		/// <summary>
		/// <para>Set the linear velocity of a single body. </para>
		/// <para>This should be used cautiously - it may be better to use AddForce or AddImpulse. </para>
		/// <param name="NewVel">New linear velocity to apply to physics. </param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body. </param>
		/// </summary>
		public override void SetPhysicsLinearVelocity(FVector newVel, bool bAddToCurrent, string boneName) { }
		
		
		/// <summary>
		/// <para>Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic). </para>
		/// <para>Note that if this component is currently attached to something, beginning simulation will detach it. </para>
		/// <param name="bSimulate">New simulation state for single body </param>
		/// </summary>
		public override void SetSimulatePhysics(bool bSimulate) { }
		
		
		/// <summary>
		/// <para>Set whether this component should use Continuous Collision Detection </para>
		/// </summary>
		public override void SetUseCCD(bool inUseCCD, string boneName) { }
		
		
		/// <summary>
		/// <para>Unwelds the children of this component. Attachment is maintained </para>
		/// </summary>
		public override void UnWeldChildren() { }
		
		
		/// <summary>
		/// <para>UnWelds this component from its parent component. Attachment is maintained (DetachFromParent automatically unwelds) </para>
		/// </summary>
		public override void UnWeldFromParent() { }
		
		
		/// <summary>
		/// <para>Internal function that updates physics objects to match the component collision settings. </para>
		/// </summary>
		protected override void UpdatePhysicsToRBChannels() { }
		
		
		/// <summary>
		/// <para>Ensure simulation is running for all bodies in this component. </para>
		/// </summary>
		public override void WakeAllRigidBodies() { }
		
		
		/// <summary>
		/// <para>'Wake' physics simulation for a single body. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body. </param>
		/// </summary>
		public override void WakeRigidBody(string boneName) { }
		
		
		/// <summary>
		/// <para>Welds this component to another scene component, optionally at a named socket. Component is automatically attached if not already </para>
		/// <para>Welding allows the child physics object to become physically connected to its parent. This is useful for creating compound rigid bodies with correct mass distribution. </para>
		/// <param name="InParent">the component to be physically attached to </param>
		/// <param name="InSocketName">optional socket to attach component to </param>
		/// </summary>
		public override void WeldTo(USceneComponent inParent, string inSocketName) { }
		
		public static implicit operator IntPtr(ManagePrimitiveComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManagePrimitiveComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePrimitiveComponent>(PtrDesc);
		}}}
