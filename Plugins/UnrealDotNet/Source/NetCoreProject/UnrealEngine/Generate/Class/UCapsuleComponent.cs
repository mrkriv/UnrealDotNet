using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\CapsuleComponent.h:16

namespace UnrealEngine
{
	public  partial class UCapsuleComponent : UShapeComponent
	{
		public UCapsuleComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UCapsuleComponent(UObject Parent = null, string Name = "CapsuleComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCapsuleComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCapsuleComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_AreSymmetricRotations(IntPtr Self, IntPtr A, IntPtr B, IntPtr Scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_CalcBoundingCylinder(IntPtr Self, float CylinderRadius, float CylinderHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleHalfHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetScaledCapsuleRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetScaledCapsuleSize(IntPtr Self, float OutRadius, float OutHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(IntPtr Self, float OutRadius, float OutHalfHeightWithoutHemisphere);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetShapeScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetUnscaledCapsuleRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetUnscaledCapsuleSize(IntPtr Self, float OutRadius, float OutHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(IntPtr Self, float OutRadius, float OutHalfHeightWithoutHemisphere);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_InitCapsuleSize(IntPtr Self, float InRadius, float InHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsZeroExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleHalfHeight(IntPtr Self, float HalfHeight, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleRadius(IntPtr Self, float Radius, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCapsuleSize(IntPtr Self, float InRadius, float InHalfHeight, bool bUpdateOverlaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_UpdateBodySetup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsNavigationRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_ShouldCollideWhenPlacing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddAngularImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddAngularImpulseInRadians(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddForce(IntPtr Self, IntPtr Force, string BoneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddForceAtLocation(IntPtr Self, IntPtr Force, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddForceAtLocationLocal(IntPtr Self, IntPtr Force, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddImpulseAtLocation(IntPtr Self, IntPtr Impulse, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddRadialForce(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddRadialImpulse(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_AreAllCollideableDescendantsRelative(IntPtr Self, bool bAllowCachedValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_CalculateMass(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_CanCharacterStepUp(IntPtr Self, IntPtr Pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_CanEditSimulatePhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_CreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_DestroyRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetAngularDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UCapsuleComponent_GetCollisionObjectType(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UCapsuleComponent_GetCollisionResponseToChannel(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCapsuleComponent_GetComponentVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetDiffuseBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetEmissiveBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCapsuleComponent_GetInertiaTensor(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_GetLightAndShadowMapMemoryUsage(IntPtr Self, int LightMapMemoryUsage, int ShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_GetLightMapResolution(IntPtr Self, int Width, int Height);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetLinearDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetMass(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCapsuleComponent_GetMassScale(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCapsuleComponent_GetNavigationBounds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UCapsuleComponent_GetNumMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_GetShadowIndirectOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_GetSquaredDistanceToCollision(IntPtr Self, IntPtr Point, float OutSquaredDistance, IntPtr OutClosestPointOnCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UCapsuleComponent_GetStaticDepthPriorityGroup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UCapsuleComponent_GetStaticLightMapResolution(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_HasValidPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_HasValidSettingsForStaticLighting(IntPtr Self, bool bOverlookInvalidComponents);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_InvalidateLightingCacheDetailed(IntPtr Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsAnyRigidBodyAwake(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsGravityEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsSimulatingPhysics(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsWorldGeometry(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_MoveComponentImpl(IntPtr Self, IntPtr Delta, IntPtr NewRotation, bool bSweep, IntPtr OutHit, byte MoveFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnActorEnableCollisionChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnAttachmentChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnComponentCollisionSettingsChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnComponentDestroyed(IntPtr Self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnDestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnRegister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnUnregister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnUpdateTransform(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostDuplicate(IntPtr Self, bool bDuplicateForPIE);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PutAllRigidBodiesToSleep(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_RegisterComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCapsuleComponent_ScaleByMomentOfInertia(IntPtr Self, IntPtr InputVector, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SendRenderTransform_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetAllMassScale(IntPtr Self, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetAllPhysicsAngularVelocity(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetAllPhysicsAngularVelocityInRadians(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetAllPhysicsLinearVelocity(IntPtr Self, IntPtr NewVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetAllPhysicsPosition(IntPtr Self, IntPtr NewPos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetAllUseCCD(IntPtr Self, bool InUseCCD);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetAngularDamping(IntPtr Self, float InDamping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCollisionObjectType(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCollisionProfileName(IntPtr Self, string InCollisionProfileName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCollisionResponseToAllChannels(IntPtr Self, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCollisionResponseToChannel(IntPtr Self, byte Channel, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetCollisionResponseToChannels(IntPtr Self, IntPtr NewReponses);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetEnableGravity(IntPtr Self, bool bGravityEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetLinearDamping(IntPtr Self, float InDamping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetMassOverrideInKg(IntPtr Self, string BoneName, float MassInKg, bool bOverrideMass);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetMassScale(IntPtr Self, string BoneName, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetNotifyRigidBodyCollision(IntPtr Self, bool bNewNotifyRigidBodyCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetSimulatePhysics(IntPtr Self, bool bSimulate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetUseCCD(IntPtr Self, bool InUseCCD, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_ShouldCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_ShouldRecreateProxyOnUpdateTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_ShouldRenderSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_SupportsStaticLighting(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_UnWeldChildren(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_UnWeldFromParent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_UpdatePhysicsToRBChannels(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_UpdatePhysicsVolume(IntPtr Self, bool bTriggerNotifiers);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_UsesOnlyUnlitMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_WakeAllRigidBodies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_WakeRigidBody(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_WeldTo(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_WeldToImplementation(IntPtr Self, IntPtr InParent, string ParentSocketName, bool bWeldSimulatedChild);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_CanAttachAsChild(IntPtr Self, IntPtr ChildComponent, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_DestroyComponent(IntPtr Self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_DetachFromComponent(IntPtr Self, IntPtr DetachmentRules);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_DetachFromParent(IntPtr Self, bool bMaintainWorldPosition, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_DoesSocketExist(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCapsuleComponent_GetSocketLocation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCapsuleComponent_GetSocketQuaternion(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCapsuleComponent_GetSocketRotation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCapsuleComponent_GetSocketTransform(IntPtr Self, string InSocketName, byte TransformSpace);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_HasAnySockets(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsAnySimulatingPhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsPrecomputedLightingValid(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsVisible(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsVisibleInEditor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnChildAttached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnChildDetached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnHiddenInGameChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnVisibilityChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PropagateLightingScenarioChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetRelativeScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_ShouldCreateRenderState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_Activate(IntPtr Self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_Deactivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_GetComponentClassCanReplicate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UCapsuleComponent_GetReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_InitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsReadyForOwnerToAutoDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnComponentCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_RequiresGameThreadEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_RequiresGameThreadEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SendRenderDynamicData_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetAutoActivate(IntPtr Self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetComponentTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_SetComponentTickEnabledAsync(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_ShouldActivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_ToggleActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_UninitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UCapsuleComponent_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UCapsuleComponent_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCapsuleComponent_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCapsuleComponent_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public override bool AreSymmetricRotations(FQuat A, FQuat B, FVector Scale3D)
			=> E_UCapsuleComponent_AreSymmetricRotations(this, A, B, Scale3D);
		
		public override void CalcBoundingCylinder(float CylinderRadius, float CylinderHalfHeight)
			=> E_UCapsuleComponent_CalcBoundingCylinder(this, CylinderRadius, CylinderHalfHeight);
		
		
		/// <summary>
		/// <para>Returns the capsule half-height scaled by the component scale. This includes both the cylinder and hemisphere cap. </para>
		/// <return>The capsule half-height scaled by the component scale. </return>
		/// </summary>
		public float GetScaledCapsuleHalfHeight()
			=> E_UCapsuleComponent_GetScaledCapsuleHalfHeight(this);
		
		
		/// <summary>
		/// <para>Returns the capsule half-height minus radius (to exclude the hemisphere), scaled by the component scale. </para>
		/// <para>From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins. </para>
		/// <return>The capsule half-height minus radius, scaled by the component scale. </return>
		/// </summary>
		public float GetScaledCapsuleHalfHeight_WithoutHemisphere()
			=> E_UCapsuleComponent_GetScaledCapsuleHalfHeight_WithoutHemisphere(this);
		
		
		/// <summary>
		/// <para>Returns the capsule radius scaled by the component scale. </para>
		/// <return>The capsule radius scaled by the component scale. </return>
		/// </summary>
		public float GetScaledCapsuleRadius()
			=> E_UCapsuleComponent_GetScaledCapsuleRadius(this);
		
		
		/// <summary>
		/// <para>Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap. </para>
		/// <param name="OutRadius">Radius of the capsule, scaled by the component scale. </param>
		/// <param name="OutHalfHeight">Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap. </param>
		/// <return>The capsule radius and half-height scaled by the component scale. </return>
		/// </summary>
		public void GetScaledCapsuleSize(float OutRadius, float OutHalfHeight)
			=> E_UCapsuleComponent_GetScaledCapsuleSize(this, OutRadius, OutHalfHeight);
		
		
		/// <summary>
		/// <para>Returns the capsule radius and half-height scaled by the component scale. Half-height excludes the hemisphere end cap. </para>
		/// <param name="OutRadius">Radius of the capsule, ignoring component scaling. </param>
		/// <param name="OutHalfHeightWithoutHemisphere">Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap. </param>
		/// <return>The capsule radius and half-height scaled by the component scale. </return>
		/// </summary>
		public void GetScaledCapsuleSize_WithoutHemisphere(float OutRadius, float OutHalfHeightWithoutHemisphere)
			=> E_UCapsuleComponent_GetScaledCapsuleSize_WithoutHemisphere(this, OutRadius, OutHalfHeightWithoutHemisphere);
		
		
		/// <summary>
		/// <para>Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling. </para>
		/// <return>the scale used by this shape. </return>
		/// </summary>
		public float GetShapeScale()
			=> E_UCapsuleComponent_GetShapeScale(this);
		
		
		/// <summary>
		/// <para>Returns the capsule half-height, ignoring component scaling. This includes the hemisphere end cap. </para>
		/// <return>The capsule radius, ignoring component scaling. </return>
		/// </summary>
		public float GetUnscaledCapsuleHalfHeight()
			=> E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight(this);
		
		
		/// <summary>
		/// <para>Returns the capsule half-height minus radius (to exclude the hemisphere), ignoring component scaling. This excludes the hemisphere end cap. </para>
		/// <para>From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins. </para>
		/// <return>The capsule half-height minus radius, ignoring component scaling. </return>
		/// </summary>
		public float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
			=> E_UCapsuleComponent_GetUnscaledCapsuleHalfHeight_WithoutHemisphere(this);
		
		
		/// <summary>
		/// <para>Returns the capsule radius, ignoring component scaling. </para>
		/// <return>the capsule radius, ignoring component scaling. </return>
		/// </summary>
		public float GetUnscaledCapsuleRadius()
			=> E_UCapsuleComponent_GetUnscaledCapsuleRadius(this);
		
		
		/// <summary>
		/// <para>Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap. </para>
		/// <param name="OutRadius">Radius of the capsule, scaled by the component scale. </param>
		/// <param name="OutHalfHeight">Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap. </param>
		/// <return>The capsule radius and half-height scaled by the component scale. </return>
		/// </summary>
		public void GetUnscaledCapsuleSize(float OutRadius, float OutHalfHeight)
			=> E_UCapsuleComponent_GetUnscaledCapsuleSize(this, OutRadius, OutHalfHeight);
		
		
		/// <summary>
		/// <para>Returns the capsule radius and half-height, ignoring component scaling. Half-height excludes the hemisphere end cap. </para>
		/// <param name="OutRadius">Radius of the capsule, ignoring component scaling. </param>
		/// <param name="OutHalfHeightWithoutHemisphere">Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap. </param>
		/// <return>The capsule radius and half-height (excluding hemisphere end cap), ignoring component scaling. </return>
		/// </summary>
		public void GetUnscaledCapsuleSize_WithoutHemisphere(float OutRadius, float OutHalfHeightWithoutHemisphere)
			=> E_UCapsuleComponent_GetUnscaledCapsuleSize_WithoutHemisphere(this, OutRadius, OutHalfHeightWithoutHemisphere);
		
		public void InitCapsuleSize(float InRadius, float InHalfHeight)
			=> E_UCapsuleComponent_InitCapsuleSize(this, InRadius, InHalfHeight);
		
		public override bool IsZeroExtent()
			=> E_UCapsuleComponent_IsZeroExtent(this);
		
		public override void PostLoad()
			=> E_UCapsuleComponent_PostLoad(this);
		
		
		/// <summary>
		/// <para>Set the capsule half-height. This is the unscaled half-height, before component scale is applied. </para>
		/// <para>If this capsule collides, updates touching array for owner actor. </para>
		/// <param name="HalfHeight">half-height, from capsule center to end of top or bottom hemisphere. </param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor. </param>
		/// </summary>
		public void SetCapsuleHalfHeight(float HalfHeight, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleHalfHeight(this, HalfHeight, bUpdateOverlaps);
		
		
		/// <summary>
		/// <para>Set the capsule radius. This is the unscaled radius, before component scale is applied. </para>
		/// <para>If this capsule collides, updates touching array for owner actor. </para>
		/// <param name="Radius">radius of end-cap hemispheres and center cylinder. </param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor. </param>
		/// </summary>
		public void SetCapsuleRadius(float Radius, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleRadius(this, Radius, bUpdateOverlaps);
		
		
		/// <summary>
		/// <para>Change the capsule size. This is the unscaled size, before component scale is applied. </para>
		/// <param name="InRadius">radius of end-cap hemispheres and center cylinder. </param>
		/// <param name="InHalfHeight">half-height, from capsule center to end of top or bottom hemisphere. </param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor. </param>
		/// </summary>
		public void SetCapsuleSize(float InRadius, float InHalfHeight, bool bUpdateOverlaps = true)
			=> E_UCapsuleComponent_SetCapsuleSize(this, InRadius, InHalfHeight, bUpdateOverlaps);
		
		public override void UpdateBodySetup()
			=> E_UCapsuleComponent_UpdateBodySetup(this);
		
		public override bool IsNavigationRelevant()
			=> E_UCapsuleComponent_IsNavigationRelevant(this);
		
		public override bool ShouldCollideWhenPlacing()
			=> E_UCapsuleComponent_ShouldCollideWhenPlacing(this);
		
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddAngularImpulse(FVector Impulse, string BoneName, bool bVelChange)
			=> E_UCapsuleComponent_AddAngularImpulse(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddAngularImpulseInRadians(FVector Impulse, string BoneName, bool bVelChange)
			=> E_UCapsuleComponent_AddAngularImpulseInRadians(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect). </param>
		/// </summary>
		public override void AddForce(FVector Force, string BoneName, bool bAccelChange)
			=> E_UCapsuleComponent_AddForce(this, Force, BoneName, bAccelChange);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location in world space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in world space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddForceAtLocation(FVector Force, FVector Location, string BoneName)
			=> E_UCapsuleComponent_AddForceAtLocation(this, Force, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location. Both Force and Location should be in body space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in component space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddForceAtLocationLocal(FVector Force, FVector Location, string BoneName)
			=> E_UCapsuleComponent_AddForceAtLocationLocal(this, Force, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddImpulse(FVector Impulse, string BoneName, bool bVelChange)
			=> E_UCapsuleComponent_AddImpulse(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body at a specific location. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="Location">Point in world space to apply impulse at. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddImpulseAtLocation(FVector Impulse, FVector Location, string BoneName)
			=> E_UCapsuleComponent_AddImpulseAtLocation(this, Impulse, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add a force to all bodies in this component, originating from the supplied world-space location. </para>
		/// <param name="Origin">Origin of force in world space. </param>
		/// <param name="Radius">Radius within which to apply the force. </param>
		/// <param name="Strength">Strength of force to apply. </param>
		/// <param name="Falloff">Allows you to control the strength of the force as a function of distance from Origin. </param>
		/// <param name="bAccelChange">If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
			=> E_UCapsuleComponent_AddRadialForce(this, Origin, Radius, Strength, (byte)Falloff, bAccelChange);
		
		
		/// <summary>
		/// <para>Add an impulse to all rigid bodies in this component, radiating out from the specified position. </para>
		/// <param name="Origin">Point of origin for the radial impulse blast, in world space </param>
		/// <param name="Radius">Size of radial impulse. Beyond this distance from Origin, there will be no affect. </param>
		/// <param name="Strength">Maximum strength of impulse applied to body. </param>
		/// <param name="Falloff">Allows you to control the strength of the impulse as a function of distance from Origin. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
			=> E_UCapsuleComponent_AddRadialImpulse(this, Origin, Radius, Strength, (byte)Falloff, bVelChange);
		
		
		/// <summary>
		/// <para>Returns true if all descendant components that we can possibly overlap with use relative location and rotation. </para>
		/// </summary>
		protected override bool AreAllCollideableDescendantsRelative(bool bAllowCachedValue)
			=> E_UCapsuleComponent_AreAllCollideableDescendantsRelative(this, bAllowCachedValue);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void BeginDestroy()
			=> E_UCapsuleComponent_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Used to detach physics objects before simulation begins. This is needed because at runtime we can't have simulated objects inside the attachment hierarchy </para>
		/// </summary>
		public override void BeginPlay()
			=> E_UCapsuleComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Returns the calculated mass in kg. This is not 100% exactly the mass physx will calculate, but it is very close ( difference < 0.1kg ). </para>
		/// </summary>
		public override float CalculateMass(string BoneName)
			=> E_UCapsuleComponent_CalculateMass(this, BoneName);
		
		
		/// <summary>
		/// <para>Return true if the given Pawn can step up onto this component. </para>
		/// <para>This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it. </para>
		/// <param name="Pawn">the Pawn that wants to step onto this component. </param>
		/// <para>@see CanCharacterStepUpOn </para>
		/// </summary>
		public override bool CanCharacterStepUp(APawn Pawn)
			=> E_UCapsuleComponent_CanCharacterStepUp(this, Pawn);
		
		
		/// <summary>
		/// <para>Determines whether or not the simulate physics setting can be edited interactively on this component </para>
		/// </summary>
		public override bool CanEditSimulatePhysics()
			=> E_UCapsuleComponent_CanEditSimulatePhysics(this);
		
		public override void CreateRenderState_Concurrent()
			=> E_UCapsuleComponent_CreateRenderState_Concurrent(this);
		
		public override void DestroyRenderState_Concurrent()
			=> E_UCapsuleComponent_DestroyRenderState_Concurrent(this);
		
		public override void FinishDestroy()
			=> E_UCapsuleComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns the angular damping of this component. </para>
		/// </summary>
		public override float GetAngularDamping()
			=> E_UCapsuleComponent_GetAngularDamping(this);
		
		
		/// <summary>
		/// <para>Gets the collision object type </para>
		/// </summary>
		public override ECollisionChannel GetCollisionObjectType()
			=> (ECollisionChannel)E_UCapsuleComponent_GetCollisionObjectType(this);
		
		
		/// <summary>
		/// <para>Gets the response type given a specific channel </para>
		/// </summary>
		public override ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel)
			=> (ECollisionResponse)E_UCapsuleComponent_GetCollisionResponseToChannel(this, (byte)Channel);
		
		public override FVector GetComponentVelocity()
			=> E_UCapsuleComponent_GetComponentVelocity(this);
		
		
		/// <summary>
		/// <para>Gets the diffuse boost for the primitive component. </para>
		/// </summary>
		public override float GetDiffuseBoost(int ElementIndex)
			=> E_UCapsuleComponent_GetDiffuseBoost(this, ElementIndex);
		
		
		/// <summary>
		/// <para>Gets the emissive boost for the primitive component. </para>
		/// </summary>
		public override float GetEmissiveBoost(int ElementIndex)
			=> E_UCapsuleComponent_GetEmissiveBoost(this, ElementIndex);
		
		
		/// <summary>
		/// <para>Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space. </para>
		/// </summary>
		public override FVector GetInertiaTensor(string BoneName)
			=> E_UCapsuleComponent_GetInertiaTensor(this, BoneName);
		
		
		/// <summary>
		/// <para>Returns the light and shadow map memory for this primitive in its out variables. </para>
		/// <para>Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one. </para>
		/// <param name="out">LightMapMemoryUsage		Memory usage in bytes for light map (either texel or vertex) data </param>
		/// <param name="out">ShadowMapMemoryUsage	Memory usage in bytes for shadow map (either texel or vertex) data </param>
		/// </summary>
		public override void GetLightAndShadowMapMemoryUsage(int LightMapMemoryUsage, int ShadowMapMemoryUsage)
			=> E_UCapsuleComponent_GetLightAndShadowMapMemoryUsage(this, LightMapMemoryUsage, ShadowMapMemoryUsage);
		
		
		/// <summary>
		/// <para>Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps. </para>
		/// <para>0 if not supported or no static shadowing. </para>
		/// <param name="Width">out]	Width of light/shadow map </param>
		/// <param name="Height">out]	Height of light/shadow map </param>
		/// <return>bool			true if LightMap values are padded, false if not </return>
		/// </summary>
		public override bool GetLightMapResolution(int Width, int Height)
			=> E_UCapsuleComponent_GetLightMapResolution(this, Width, Height);
		
		
		/// <summary>
		/// <para>Returns the linear damping of this component. </para>
		/// </summary>
		public override float GetLinearDamping()
			=> E_UCapsuleComponent_GetLinearDamping(this);
		
		
		/// <summary>
		/// <para>Returns the mass of this component in kg. </para>
		/// </summary>
		public override float GetMass()
			=> E_UCapsuleComponent_GetMass(this);
		
		
		/// <summary>
		/// <para>Returns the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public override float GetMassScale(string BoneName)
			=> E_UCapsuleComponent_GetMassScale(this, BoneName);
		
		public override FBox GetNavigationBounds()
			=> E_UCapsuleComponent_GetNavigationBounds(this);
		
		
		/// <summary>
		/// <return>number of material elements in this primitive </return>
		/// </summary>
		public override int GetNumMaterials()
			=> E_UCapsuleComponent_GetNumMaterials(this);
		
		public override bool GetShadowIndirectOnly()
			=> E_UCapsuleComponent_GetShadowIndirectOnly(this);
		
		
		/// <summary>
		/// <para>returns The square of the distance to closest Body Instance surface. </para>
		/// <param name="Point">World 3D vector </param>
		/// <param name="OutSquaredDistance">The squared distance to closest Body Instance surface. 0 if inside of the body </param>
		/// <param name="OutPointOnBody">Point on the surface of collision closest to Point </param>
		/// <return>true if a distance to the body was found and OutDistanceSquared has been populated </return>
		/// </summary>
		public override bool GetSquaredDistanceToCollision(FVector Point, float OutSquaredDistance, FVector OutClosestPointOnCollision)
			=> E_UCapsuleComponent_GetSquaredDistanceToCollision(this, Point, OutSquaredDistance, OutClosestPointOnCollision);
		
		
		/// <summary>
		/// <para>Determines the DPG the primitive's primary elements are drawn in. </para>
		/// <para>Even if the primitive's elements are drawn in multiple DPGs, a primary DPG is needed for occlusion culling and shadow projection. </para>
		/// <return>The DPG the primitive's primary elements will be drawn in. </return>
		/// </summary>
		public override byte GetStaticDepthPriorityGroup()
			=> E_UCapsuleComponent_GetStaticDepthPriorityGroup(this);
		
		
		/// <summary>
		/// <para>Returns the static lightmap resolution used for this primitive. </para>
		/// <para>0 if not supported or no static shadowing. </para>
		/// <return>int32		The StaticLightmapResolution for the component </return>
		/// </summary>
		public override int GetStaticLightMapResolution()
			=> E_UCapsuleComponent_GetStaticLightMapResolution(this);
		
		public override bool HasValidPhysicsState()
			=> E_UCapsuleComponent_HasValidPhysicsState(this);
		
		public override bool HasValidSettingsForStaticLighting(bool bOverlookInvalidComponents)
			=> E_UCapsuleComponent_HasValidSettingsForStaticLighting(this, bOverlookInvalidComponents);
		
		
		/// <summary>
		/// <para>This function is used to create hierarchical LOD for the level. You can decide to opt out if you don't want. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_UCapsuleComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns if any body in this component is currently awake and simulating. </para>
		/// </summary>
		public override bool IsAnyRigidBodyAwake()
			=> E_UCapsuleComponent_IsAnyRigidBodyAwake(this);
		
		public override bool IsEditorOnly()
			=> E_UCapsuleComponent_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is affected by gravity. Returns always false if the component is not simulated. </para>
		/// </summary>
		public override bool IsGravityEnabled()
			=> E_UCapsuleComponent_IsGravityEnabled(this);
		
		public override bool IsReadyForFinishDestroy()
			=> E_UCapsuleComponent_IsReadyForFinishDestroy(this);
		
		public override bool IsSimulatingPhysics(string BoneName)
			=> E_UCapsuleComponent_IsSimulatingPhysics(this, BoneName);
		
		public override bool IsWorldGeometry()
			=> E_UCapsuleComponent_IsWorldGeometry(this);
		
		protected override bool MoveComponentImpl(FVector Delta, FQuat NewRotation, bool bSweep, FHitResult OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
			=> E_UCapsuleComponent_MoveComponentImpl(this, Delta, NewRotation, bSweep, OutHit, (byte)MoveFlags, (byte)Teleport);
		
		public override bool NeedsLoadForClient()
			=> E_UCapsuleComponent_NeedsLoadForClient(this);
		
		public override bool NeedsLoadForServer()
			=> E_UCapsuleComponent_NeedsLoadForServer(this);
		
		public override void OnActorEnableCollisionChanged()
			=> E_UCapsuleComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Event called when AttachParent changes, to allow the scene to update its attachment state. </para>
		/// </summary>
		public override void OnAttachmentChanged()
			=> E_UCapsuleComponent_OnAttachmentChanged(this);
		
		
		/// <summary>
		/// <para>Called when the BodyInstance ResponseToChannels, CollisionEnabled or bNotifyRigidBodyCollision changes, in case subclasses want to use that information. </para>
		/// </summary>
		protected override void OnComponentCollisionSettingsChanged()
			=> E_UCapsuleComponent_OnComponentCollisionSettingsChanged(this);
		
		public override void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_UCapsuleComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		protected override void OnCreatePhysicsState()
			=> E_UCapsuleComponent_OnCreatePhysicsState(this);
		
		protected override void OnDestroyPhysicsState()
			=> E_UCapsuleComponent_OnDestroyPhysicsState(this);
		
		public override void OnRegister()
			=> E_UCapsuleComponent_OnRegister(this);
		
		public override void OnUnregister()
			=> E_UCapsuleComponent_OnUnregister(this);
		
		
		/// <summary>
		/// <para>Give the static mesh component recreate render state context access to Create/DestroyRenderState_Concurrent(). </para>
		/// </summary>
		public override void OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_UCapsuleComponent_OnUpdateTransform(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		public override void PostDuplicate(bool bDuplicateForPIE)
			=> E_UCapsuleComponent_PostDuplicate(this, bDuplicateForPIE);
		
		
		/// <summary>
		/// <para>Force all bodies in this component to sleep. </para>
		/// </summary>
		public override void PutAllRigidBodiesToSleep()
			=> E_UCapsuleComponent_PutAllRigidBodiesToSleep(this);
		
		public override void RegisterComponentTickFunctions(bool bRegister)
			=> E_UCapsuleComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object. </para>
		/// </summary>
		public override FVector ScaleByMomentOfInertia(FVector InputVector, string BoneName)
			=> E_UCapsuleComponent_ScaleByMomentOfInertia(this, InputVector, BoneName);
		
		public override void SendRenderTransform_Concurrent()
			=> E_UCapsuleComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Change the mass scale used fo all bodies in this component </para>
		/// </summary>
		public override void SetAllMassScale(float InMassScale)
			=> E_UCapsuleComponent_SetAllMassScale(this, InMassScale);
		
		
		/// <summary>
		/// <para>Set the angular velocity of all bodies in this component. </para>
		/// <param name="NewAngVel">New angular velocity to apply to physics, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies. </param>
		/// </summary>
		public override void SetAllPhysicsAngularVelocity(FVector NewAngVel, bool bAddToCurrent)
			=> E_UCapsuleComponent_SetAllPhysicsAngularVelocity(this, NewAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the angular velocity of all bodies in this component. </para>
		/// <param name="NewAngVel">New angular velocity to apply to physics, in radians per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies. </param>
		/// </summary>
		public override void SetAllPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent)
			=> E_UCapsuleComponent_SetAllPhysicsAngularVelocityInRadians(this, NewAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the linear velocity of all bodies in this component. </para>
		/// <param name="NewVel">New linear velocity to apply to physics. </param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body. </param>
		/// </summary>
		public override void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
			=> E_UCapsuleComponent_SetAllPhysicsLinearVelocity(this, NewVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the position of all bodies in this component. </para>
		/// <para>If a SkeletalMeshComponent, the root body will be placed at the desired position, and the same delta is applied to all other bodies. </para>
		/// <param name="NewPos">New position for the body </param>
		/// </summary>
		public override void SetAllPhysicsPosition(FVector NewPos)
			=> E_UCapsuleComponent_SetAllPhysicsPosition(this, NewPos);
		
		
		/// <summary>
		/// <para>Set whether all bodies in this component should use Continuous Collision Detection </para>
		/// </summary>
		public override void SetAllUseCCD(bool InUseCCD)
			=> E_UCapsuleComponent_SetAllUseCCD(this, InUseCCD);
		
		
		/// <summary>
		/// <para>Sets the angular damping of this component. </para>
		/// </summary>
		public override void SetAngularDamping(float InDamping)
			=> E_UCapsuleComponent_SetAngularDamping(this, InDamping);
		
		
		/// <summary>
		/// <para>Changes the collision channel that this object uses when it moves </para>
		/// <param name="Channel">The new channel for this component to use </param>
		/// </summary>
		public override void SetCollisionObjectType(ECollisionChannel Channel)
			=> E_UCapsuleComponent_SetCollisionObjectType(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Set Collision Profile Name </para>
		/// <para>This function is called by constructors when they set ProfileName </para>
		/// <para>This will change current CollisionProfileName to be this, and overwrite Collision Setting </para>
		/// <param name="InCollisionProfileName">New Profile Name </param>
		/// </summary>
		public override void SetCollisionProfileName(string InCollisionProfileName)
			=> E_UCapsuleComponent_SetCollisionProfileName(this, InCollisionProfileName);
		
		
		/// <summary>
		/// <para>Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse </para>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public override void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
			=> E_UCapsuleComponent_SetCollisionResponseToAllChannels(this, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Changes a member of the ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="Channel">The channel to change the response of </param>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public override void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
			=> E_UCapsuleComponent_SetCollisionResponseToChannel(this, (byte)Channel, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Changes the whole ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="NewResponses">New set of responses for this component </param>
		/// </summary>
		public override void SetCollisionResponseToChannels(FCollisionResponseContainer NewReponses)
			=> E_UCapsuleComponent_SetCollisionResponseToChannels(this, NewReponses);
		
		
		/// <summary>
		/// <para>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true. </para>
		/// </summary>
		public override void SetEnableGravity(bool bGravityEnabled)
			=> E_UCapsuleComponent_SetEnableGravity(this, bGravityEnabled);
		
		
		/// <summary>
		/// <para>Sets the linear damping of this component. </para>
		/// </summary>
		public override void SetLinearDamping(float InDamping)
			=> E_UCapsuleComponent_SetLinearDamping(this, InDamping);
		
		
		/// <summary>
		/// <para>Override the mass (in Kg) of a single physics body. </para>
		/// <para>Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group. </para>
		/// <para>Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass. </para>
		/// </summary>
		public override void SetMassOverrideInKg(string BoneName, float MassInKg, bool bOverrideMass)
			=> E_UCapsuleComponent_SetMassOverrideInKg(this, BoneName, MassInKg, bOverrideMass);
		
		
		/// <summary>
		/// <para>Change the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public override void SetMassScale(string BoneName, float InMassScale)
			=> E_UCapsuleComponent_SetMassScale(this, BoneName, InMassScale);
		
		
		/// <summary>
		/// <para>Changes the value of bNotifyRigidBodyCollision </para>
		/// <param name="bNewNotifyRigidBodyCollision">The value to assign to bNotifyRigidBodyCollision </param>
		/// </summary>
		public override void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
			=> E_UCapsuleComponent_SetNotifyRigidBodyCollision(this, bNewNotifyRigidBodyCollision);
		
		
		/// <summary>
		/// <para>Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic). </para>
		/// <para>Note that if this component is currently attached to something, beginning simulation will detach it. </para>
		/// <param name="bSimulate">New simulation state for single body </param>
		/// </summary>
		public override void SetSimulatePhysics(bool bSimulate)
			=> E_UCapsuleComponent_SetSimulatePhysics(this, bSimulate);
		
		
		/// <summary>
		/// <para>Set whether this component should use Continuous Collision Detection </para>
		/// </summary>
		public override void SetUseCCD(bool InUseCCD, string BoneName)
			=> E_UCapsuleComponent_SetUseCCD(this, InUseCCD, BoneName);
		
		public override bool ShouldCreatePhysicsState()
			=> E_UCapsuleComponent_ShouldCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Determines whether the proxy for this primitive type needs to be recreated whenever the primitive moves. </para>
		/// <return>true to recreate the proxy when UpdateTransform is called. </return>
		/// </summary>
		public override bool ShouldRecreateProxyOnUpdateTransform()
			=> E_UCapsuleComponent_ShouldRecreateProxyOnUpdateTransform(this);
		
		
		/// <summary>
		/// <return>true if the owner is selected and this component is selectable </return>
		/// </summary>
		public override bool ShouldRenderSelected()
			=> E_UCapsuleComponent_ShouldRenderSelected(this);
		
		
		/// <summary>
		/// <para>Whether the component type supports static lighting. </para>
		/// </summary>
		protected override bool SupportsStaticLighting()
			=> E_UCapsuleComponent_SupportsStaticLighting(this);
		
		
		/// <summary>
		/// <para>Unwelds the children of this component. Attachment is maintained </para>
		/// </summary>
		public override void UnWeldChildren()
			=> E_UCapsuleComponent_UnWeldChildren(this);
		
		
		/// <summary>
		/// <para>UnWelds this component from its parent component. Attachment is maintained (DetachFromParent automatically unwelds) </para>
		/// </summary>
		public override void UnWeldFromParent()
			=> E_UCapsuleComponent_UnWeldFromParent(this);
		
		
		/// <summary>
		/// <para>Internal function that updates physics objects to match the component collision settings. </para>
		/// </summary>
		protected override void UpdatePhysicsToRBChannels()
			=> E_UCapsuleComponent_UpdatePhysicsToRBChannels(this);
		
		
		/// <summary>
		/// <para>Update current physics volume for this component, if bShouldUpdatePhysicsVolume is true. Overridden to use the overlaps to find the physics volume. </para>
		/// </summary>
		public override void UpdatePhysicsVolume(bool bTriggerNotifiers)
			=> E_UCapsuleComponent_UpdatePhysicsVolume(this, bTriggerNotifiers);
		
		
		/// <summary>
		/// <return>true if only unlit materials are used for rendering, false otherwise. </return>
		/// </summary>
		public override bool UsesOnlyUnlitMaterials()
			=> E_UCapsuleComponent_UsesOnlyUnlitMaterials(this);
		
		
		/// <summary>
		/// <para>Ensure simulation is running for all bodies in this component. </para>
		/// </summary>
		public override void WakeAllRigidBodies()
			=> E_UCapsuleComponent_WakeAllRigidBodies(this);
		
		
		/// <summary>
		/// <para>'Wake' physics simulation for a single body. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body. </param>
		/// </summary>
		public override void WakeRigidBody(string BoneName)
			=> E_UCapsuleComponent_WakeRigidBody(this, BoneName);
		
		
		/// <summary>
		/// <para>Welds this component to another scene component, optionally at a named socket. Component is automatically attached if not already </para>
		/// <para>Welding allows the child physics object to become physically connected to its parent. This is useful for creating compound rigid bodies with correct mass distribution. </para>
		/// <param name="InParent">the component to be physically attached to </param>
		/// <param name="InSocketName">optional socket to attach component to </param>
		/// </summary>
		public override void WeldTo(USceneComponent InParent, string InSocketName)
			=> E_UCapsuleComponent_WeldTo(this, InParent, InSocketName);
		
		
		/// <summary>
		/// <para>Does the actual work for welding. </para>
		/// <return>true if did a true weld of shapes, meaning body initialization is not needed </return>
		/// </summary>
		public override bool WeldToImplementation(USceneComponent InParent, string ParentSocketName, bool bWeldSimulatedChild)
			=> E_UCapsuleComponent_WeldToImplementation(this, InParent, ParentSocketName, bWeldSimulatedChild);
		
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_UCapsuleComponent_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		
		/// <summary>
		/// <para>Called to see if it's possible to attach another scene component as a child. </para>
		/// <para>Note: This can be called on template component as well! </para>
		/// </summary>
		public override bool CanAttachAsChild(USceneComponent ChildComponent, string SocketName)
			=> E_UCapsuleComponent_CanAttachAsChild(this, ChildComponent, SocketName);
		
		public override void DestroyComponent(bool bPromoteChildren)
			=> E_UCapsuleComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="DetachmentRules">How to handle transforms & modification when detaching. </param>
		/// </summary>
		public override void DetachFromComponent(FDetachmentTransformRules DetachmentRules)
			=> E_UCapsuleComponent_DetachFromComponent(this, DetachmentRules);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="bMaintainWorldPosition">If true, update the relative location of the component to keep its world position the same </param>
		/// <param name="bCallModify">If true, call Modify() on the component and the current attach parent component </param>
		/// </summary>
		public override void DetachFromParentDeprecated(bool bMaintainWorldPosition, bool bCallModify)
			=> E_UCapsuleComponent_DetachFromParent(this, bMaintainWorldPosition, bCallModify);
		
		
		/// <summary>
		/// <para>return true if socket with the given name exists </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>true if the socket with the given name exists. Otherwise, return false </return>
		/// </summary>
		public override bool DoesSocketExist(string InSocketName)
			=> E_UCapsuleComponent_DoesSocketExist(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone location. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FVector GetSocketLocation(string InSocketName)
			=> E_UCapsuleComponent_GetSocketLocation(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone FQuat rotation. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FQuat GetSocketQuaternion(string InSocketName)
			=> E_UCapsuleComponent_GetSocketQuaternion(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone  FRotator rotation. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FRotator GetSocketRotation(string InSocketName)
			=> E_UCapsuleComponent_GetSocketRotation(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket transform. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FTransform GetSocketTransform(string InSocketName, ERelativeTransformSpace TransformSpace)
			=> E_UCapsuleComponent_GetSocketTransform(this, InSocketName, (byte)TransformSpace);
		
		
		/// <summary>
		/// <para>Returns true if this component has any sockets </para>
		/// </summary>
		public override bool HasAnySockets()
			=> E_UCapsuleComponent_HasAnySockets(this);
		
		
		/// <summary>
		/// <para>Returns whether the specified body is currently using physics simulation </para>
		/// </summary>
		public override bool IsAnySimulatingPhysics()
			=> E_UCapsuleComponent_IsAnySimulatingPhysics(this);
		
		public override bool IsPrecomputedLightingValid()
			=> E_UCapsuleComponent_IsPrecomputedLightingValid(this);
		
		
		/// <summary>
		/// <para>Is this component visible or not in game </para>
		/// <return>true if visible </return>
		/// </summary>
		public override bool IsVisible()
			=> E_UCapsuleComponent_IsVisible(this);
		
		
		/// <summary>
		/// <para>Return true if visible in editor </para>
		/// </summary>
		public override bool IsVisibleInEditor()
			=> E_UCapsuleComponent_IsVisibleInEditor(this);
		
		
		/// <summary>
		/// <para>Called after a child scene component is attached to this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildAttached(USceneComponent ChildComponent)
			=> E_UCapsuleComponent_OnChildAttached(this, ChildComponent);
		
		
		/// <summary>
		/// <para>Called after a child scene component is detached from this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildDetached(USceneComponent ChildComponent)
			=> E_UCapsuleComponent_OnChildDetached(this, ChildComponent);
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the hidden in game value of the component. </para>
		/// </summary>
		protected override void OnHiddenInGameChanged()
			=> E_UCapsuleComponent_OnHiddenInGameChanged(this);
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the visibility of the component. </para>
		/// </summary>
		protected override void OnVisibilityChanged()
			=> E_UCapsuleComponent_OnVisibilityChanged(this);
		
		public override void PostNetReceive()
			=> E_UCapsuleComponent_PostNetReceive(this);
		
		public override void PostRepNotifies()
			=> E_UCapsuleComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Stack of current movement scopes. </para>
		/// </summary>
		public override void PreNetReceive()
			=> E_UCapsuleComponent_PreNetReceive(this);
		
		public override void PropagateLightingScenarioChange()
			=> E_UCapsuleComponent_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// <para>Set the non-uniform scale of the component relative to its parent </para>
		/// </summary>
		public override void SetRelativeScale3D(FVector NewScale3D)
			=> E_UCapsuleComponent_SetRelativeScale3D(this, NewScale3D);
		
		
		/// <summary>
		/// <para>Return true if CreateRenderState() should be called </para>
		/// </summary>
		public override bool ShouldCreateRenderState()
			=> E_UCapsuleComponent_ShouldCreateRenderState(this);
		
		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">The value to assign to HiddenGame. </param>
		/// </summary>
		public override void Activate(bool bReset)
			=> E_UCapsuleComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UCapsuleComponent_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UCapsuleComponent_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Deactivates the SceneComponent. </para>
		/// </summary>
		public override void Deactivate()
			=> E_UCapsuleComponent_Deactivate(this);
		
		public override bool GetComponentClassCanReplicate()
			=> E_UCapsuleComponent_GetComponentClassCanReplicate(this);
		
		
		/// <summary>
		/// <para>Returns a readable name for this component, including the asset name if applicable </para>
		/// <para>By default this appends a space plus AdditionalStatObject() </para>
		/// </summary>
		public override string GetReadableName()
			=> E_UCapsuleComponent_GetReadableName(this);
		
		
		/// <summary>
		/// <para>Initializes the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// <para>Requires component to be registered, and bWantsInitializeComponent to be true. </para>
		/// </summary>
		public override void InitializeComponent()
			=> E_UCapsuleComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Returns whether the component is active or not </para>
		/// <return>The active state of the component. </return>
		/// </summary>
		public override bool IsActive()
			=> E_UCapsuleComponent_IsActive(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_UCapsuleComponent_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Overridable check for a component to indicate to its Owner that it should prevent the Actor from auto destroying when finished </para>
		/// </summary>
		public override bool IsReadyForOwnerToAutoDestroy()
			=> E_UCapsuleComponent_IsReadyForOwnerToAutoDestroy(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_UCapsuleComponent_IsSupportedForNetworking(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_UCapsuleComponent_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_UCapsuleComponent_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public override void OnComponentCreated()
			=> E_UCapsuleComponent_OnComponentCreated(this);
		
		public override void PostInitProperties()
			=> E_UCapsuleComponent_PostInitProperties(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_UCapsuleComponent_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UCapsuleComponent_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UCapsuleComponent_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame recreates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameRecreate()
			=> E_UCapsuleComponent_RequiresGameThreadEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame updates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameUpdates()
			=> E_UCapsuleComponent_RequiresGameThreadEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent()
			=> E_UCapsuleComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public override void SetActive(bool bNewActive, bool bReset)
			=> E_UCapsuleComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public override void SetAutoActivate(bool bNewAutoActivate)
			=> E_UCapsuleComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabled(bool bEnabled)
			=> E_UCapsuleComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_UCapsuleComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>"Trigger" related function. Return true if it should activate </para>
		/// </summary>
		protected override bool ShouldActivate()
			=> E_UCapsuleComponent_ShouldActivate(this);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public override void ToggleActive()
			=> E_UCapsuleComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent()
			=> E_UCapsuleComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_UCapsuleComponent_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_UCapsuleComponent_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_UCapsuleComponent_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_UCapsuleComponent_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_UCapsuleComponent_IsAsset(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_UCapsuleComponent_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_UCapsuleComponent_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_UCapsuleComponent_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_UCapsuleComponent_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_UCapsuleComponent_Modify(this, bAlwaysMarkDirty);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_UCapsuleComponent_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_UCapsuleComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_UCapsuleComponent_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UCapsuleComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_UCapsuleComponent_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_UCapsuleComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_UCapsuleComponent_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_UCapsuleComponent_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_UCapsuleComponent_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_UCapsuleComponent_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_UCapsuleComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(UCapsuleComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UCapsuleComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCapsuleComponent>(PtrDesc);
		}}}
