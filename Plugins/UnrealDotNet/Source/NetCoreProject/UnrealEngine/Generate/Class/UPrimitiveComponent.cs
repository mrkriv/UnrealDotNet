using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPrimitiveComponent : USceneComponent
	{
		public UPrimitiveComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPrimitiveComponent(UObject Parent = null, string Name = "PrimitiveComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPrimitiveComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPrimitiveComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_BoundsScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_BoundsScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPrimitiveComponent_CurrentTag_GET();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LastRenderTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LastRenderTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LastSubmitTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LastSubmitTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UPrimitiveComponent_LightingChannels_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LightingChannels_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_MinDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_MinDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPrimitiveComponent_VisibilityId_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_VisibilityId_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddAngularImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForce(IntPtr Self, IntPtr Force, string BoneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForceAtLocation(IntPtr Self, IntPtr Force, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForceAtLocationLocal(IntPtr Self, IntPtr Force, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddImpulseAtLocation(IntPtr Self, IntPtr Impulse, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddTorque(IntPtr Self, IntPtr Torque, string BoneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(IntPtr Self, bool bAllowCachedValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_CalculateMass(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_CanEditSimulatePhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearComponentOverlaps(IntPtr Self, bool bDoNotifies, bool bSkipNotifySelf);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearMoveIgnoreActors(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearMoveIgnoreComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_DisableNavigationRelevance(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_DispatchWakeEvents(IntPtr Self, int WakeEvent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_EnsurePhysicsStateCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetAngularDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetCenterOfMass(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPrimitiveComponent_GetCollisionProfileName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetDiffuseBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetEmissiveBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetInertiaTensor(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(IntPtr Self, int LightMapMemoryUsage, int ShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetLightMapResolution(IntPtr Self, int Width, int Height);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetLinearDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetMass(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetMassScale(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPrimitiveComponent_GetNumMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsAngularVelocity(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsLinearVelocity(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(IntPtr Self, IntPtr Point, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetShadowIndirectOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UPrimitiveComponent_GetStaticDepthPriorityGroup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPrimitiveComponent_GetStaticLightMapResolution(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_HasStaticLighting(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_HasValidSettingsForStaticLighting(IntPtr Self, bool bOverlookInvalidComponents);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsAnyRigidBodyAwake(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsAttachedToStreamingManager(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsComponentIndividuallySelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsGravityEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsWelded(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsZeroExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PushHoveredToProxy(IntPtr Self, bool bInHovered);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PushSelectionToProxy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PutAllRigidBodiesToSleep(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PutRigidBodyToSleep(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_RigidBodyIsAwake(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_ScaleByMomentOfInertia(IntPtr Self, IntPtr InputVector, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SendPhysicsTransform(IntPtr Self, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllMassScale(IntPtr Self, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(IntPtr Self, IntPtr NewVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsPosition(IntPtr Self, IntPtr NewPos);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAngularDamping(IntPtr Self, float InDamping);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetBoundsScale(IntPtr Self, float NewBoundsScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCachedMaxDrawDistance(IntPtr Self, float NewCachedMaxDrawDistance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCastShadow(IntPtr Self, bool NewCastShadow);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCenterOfMass(IntPtr Self, IntPtr CenterOfMassOffset, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionObjectType(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionProfileName(IntPtr Self, string InCollisionProfileName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionResponseToAllChannels(IntPtr Self, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionResponseToChannel(IntPtr Self, byte Channel, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCullDistance(IntPtr Self, float NewCullDistance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCustomDepthStencilValue(IntPtr Self, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(IntPtr Self, byte WriteMaskBit);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetDepthPriorityGroup(IntPtr Self, byte NewDepthPriorityGroup);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetEnableGravity(IntPtr Self, bool bGravityEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetLinearDamping(IntPtr Self, float InDamping);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetMassOverrideInKg(IntPtr Self, string BoneName, float MassInKg, bool bOverrideMass);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetMassScale(IntPtr Self, string BoneName, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetNotifyRigidBodyCollision(IntPtr Self, bool bNewNotifyRigidBodyCollision);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetOnlyOwnerSee(IntPtr Self, bool bNewOnlyOwnerSee);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetOwnerNoSee(IntPtr Self, bool bNewOwnerNoSee);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsAngularVelocity(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsLinearVelocity(IntPtr Self, IntPtr NewVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(IntPtr Self, float NewMaxAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(IntPtr Self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetReceivesDecals(IntPtr Self, bool bNewReceivesDecals);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRenderCustomDepth(IntPtr Self, bool bValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRenderInMainPass(IntPtr Self, bool bValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRenderInMono(IntPtr Self, bool bValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetSimulatePhysics(IntPtr Self, bool bSimulate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(IntPtr Self, bool bNewSingleSampleShadowFromStationaryLights);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetTranslucentSortPriority(IntPtr Self, int NewTranslucentSortPriority);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(IntPtr Self, bool bNewUseViewOwnerDepthPriorityGroup, byte NewViewOwnerDepthPriorityGroup);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldComponentAddToScene(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldRecreateProxyOnUpdateTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldRenderSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_SupportsStaticLighting(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SyncComponentToRBPhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UnWeldChildren(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UnWeldFromParent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UpdatePhysicsToRBChannels(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_UsesOnlyUnlitMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_WakeAllRigidBodies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_WakeRigidBody(IntPtr Self, string BoneName);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Scales the bounds of the object. </para>
		/// <para>This is useful when using World Position Offset to animate the vertices of the object outside of its bounds. </para>
		/// <para>Warning: Increasing the bounds of an object will reduce performance and shadow quality! </para>
		/// <para>Currently only used by StaticMeshComponent and SkeletalMeshComponent. </para>
		/// </summary>
		public float BoundsScale
		{
			get => E_PROP_UPrimitiveComponent_BoundsScale_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_BoundsScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The distance to cull this primitive at. </para>
		/// <para>A CachedMaxDrawDistance of 0 indicates that the primitive should not be culled by distance. </para>
		/// </summary>
		public float CurrentMaxDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(NativePointer, value);
		}

		public static int CurrentTag
		{
			get => E_PROP_UPrimitiveComponent_CurrentTag_GET();
		}

		
		/// <summary>
		/// <para>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3) </para>
		/// </summary>
		public int CustomDepthStencilValue
		{
			get => E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Mask used for stencil buffer writes. </para>
		/// </summary>
		public ERendererStencilMask CustomDepthStencilWriteMask
		{
			get => (ERendererStencilMask)E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_SET(NativePointer, (byte)value);
		}

		public float LastRenderTime
		{
			get => E_PROP_UPrimitiveComponent_LastRenderTime_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastRenderTime_SET(NativePointer, value);
		}

		public float LastRenderTimeOnScreen
		{
			get => E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(NativePointer, value);
		}

		public float LastSubmitTime
		{
			get => E_PROP_UPrimitiveComponent_LastSubmitTime_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastSubmitTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object. </para>
		/// </summary>
		public float DesiredMaxDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Channels that this component should be in.  Lights with matching channels will affect the component. </para>
		/// <para>These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing. </para>
		/// </summary>
		public FLightingChannels LightingChannels
		{
			get => E_PROP_UPrimitiveComponent_LightingChannels_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LightingChannels_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Multiplier used to scale the Light Propagation Volume light injection bias, to reduce light bleeding. </para>
		/// <para>Set to 0 for no bias, 1 for default or higher for increased biasing (e.g. for </para>
		/// <para>thin geometry such as walls) </para>
		/// </summary>
		public float LpvBiasMultiplier
		{
			get => E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The minimum distance at which the primitive should be rendered, </para>
		/// <para>measured in world space units from the center of the primitive's bounding sphere to the camera position. </para>
		/// </summary>
		public float MinDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_MinDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_MinDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Translucent objects with a lower sort priority draw behind objects with a higher priority. </para>
		/// <para>Translucent objects with the same priority are rendered from back-to-front based on their bounds origin. </para>
		/// <para>Ignored if the object is not translucent.  The default priority is zero. </para>
		/// <para>Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly. </para>
		/// <para>It is especially problematic on dynamic gameplay effects. </para>
		/// </summary>
		public int TranslucencySortPriority
		{
			get => E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(NativePointer, value);
		}

		public int VisibilityId
		{
			get => E_PROP_UPrimitiveComponent_VisibilityId_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_VisibilityId_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no affect). </param>
		/// </summary>
		public virtual void AddAngularImpulse(FVector Impulse, string BoneName, bool bVelChange)
			=> E_UPrimitiveComponent_AddAngularImpulse(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no affect). </param>
		/// </summary>
		public virtual void AddForce(FVector Force, string BoneName, bool bAccelChange)
			=> E_UPrimitiveComponent_AddForce(this, Force, BoneName, bAccelChange);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location in world space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in world space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public virtual void AddForceAtLocation(FVector Force, FVector Location, string BoneName)
			=> E_UPrimitiveComponent_AddForceAtLocation(this, Force, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location. Both Force and Location should be in body space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in component space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public virtual void AddForceAtLocationLocal(FVector Force, FVector Location, string BoneName)
			=> E_UPrimitiveComponent_AddForceAtLocationLocal(this, Force, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect). </param>
		/// </summary>
		public virtual void AddImpulse(FVector Impulse, string BoneName, bool bVelChange)
			=> E_UPrimitiveComponent_AddImpulse(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body at a specific location. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="Location">Point in world space to apply impulse at. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body. </param>
		/// </summary>
		public virtual void AddImpulseAtLocation(FVector Impulse, FVector Location, string BoneName)
			=> E_UPrimitiveComponent_AddImpulseAtLocation(this, Impulse, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add a torque to a single rigid body. </para>
		/// <param name="Torque">Torque to apply. Direction is axis of rotation and magnitude is strength of torque. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no affect). </param>
		/// </summary>
		public void AddTorque(FVector Torque, string BoneName, bool bAccelChange = false)
			=> E_UPrimitiveComponent_AddTorque(this, Torque, BoneName, bAccelChange);
		
		
		/// <summary>
		/// <para>Returns true if all descendant components that we can possibly overlap with use relative location and rotation. </para>
		/// </summary>
		protected virtual bool AreAllCollideableDescendantsRelative(bool bAllowCachedValue)
			=> E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(this, bAllowCachedValue);
		
		
		/// <summary>
		/// <para>Returns the calculated mass in kg. This is not 100% exactly the mass physx will calculate, but it is very close ( difference < 0.1kg ). </para>
		/// </summary>
		public virtual float CalculateMass(string BoneName)
			=> E_UPrimitiveComponent_CalculateMass(this, BoneName);
		
		
		/// <summary>
		/// <para>Determines whether or not the simulate physics setting can be edited interactively on this component </para>
		/// </summary>
		public virtual bool CanEditSimulatePhysics()
			=> E_UPrimitiveComponent_CanEditSimulatePhysics(this);
		
		
		/// <summary>
		/// <para>Ends all current component overlaps. Generally used when destroying this component or when it can no longer generate overlaps. </para>
		/// </summary>
		protected void ClearComponentOverlaps(bool bDoNotifies, bool bSkipNotifySelf)
			=> E_UPrimitiveComponent_ClearComponentOverlaps(this, bDoNotifies, bSkipNotifySelf);
		
		
		/// <summary>
		/// <para>Clear the list of actors we ignore when moving. </para>
		/// </summary>
		public void ClearMoveIgnoreActors()
			=> E_UPrimitiveComponent_ClearMoveIgnoreActors(this);
		
		
		/// <summary>
		/// <para>Clear the list of components we ignore when moving. </para>
		/// </summary>
		public void ClearMoveIgnoreComponents()
			=> E_UPrimitiveComponent_ClearMoveIgnoreComponents(this);
		
		public void DisableNavigationRelevance()
			=> E_UPrimitiveComponent_DisableNavigationRelevance(this);
		
		
		/// <summary>
		/// <para>Dispatch notification for wake events and propagate to any welded bodies </para>
		/// </summary>
		public void DispatchWakeEvents(int WakeEvent, string BoneName)
			=> E_UPrimitiveComponent_DispatchWakeEvents(this, WakeEvent, BoneName);
		
		
		/// <summary>
		/// <para>Ensure physics state created </para>
		/// </summary>
		protected void EnsurePhysicsStateCreated()
			=> E_UPrimitiveComponent_EnsurePhysicsStateCreated(this);
		
		
		/// <summary>
		/// <para>Returns the angular damping of this component. </para>
		/// </summary>
		public virtual float GetAngularDamping()
			=> E_UPrimitiveComponent_GetAngularDamping(this);
		
		
		/// <summary>
		/// <para>Get the center of mass of a single body. In the case of a welded body this will return the center of mass of the entire welded body (including its parent and children) </para>
		/// <para>Objects that are not simulated return (0,0,0) as they do not have COM </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get center of mass of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetCenterOfMass(string BoneName)
			=> E_UPrimitiveComponent_GetCenterOfMass(this, BoneName);
		
		
		/// <summary>
		/// <para>Get the collision profile name </para>
		/// </summary>
		public string GetCollisionProfileName()
			=> E_UPrimitiveComponent_GetCollisionProfileName(this);
		
		
		/// <summary>
		/// <para>Gets the diffuse boost for the primitive component. </para>
		/// </summary>
		public virtual float GetDiffuseBoost(int ElementIndex)
			=> E_UPrimitiveComponent_GetDiffuseBoost(this, ElementIndex);
		
		
		/// <summary>
		/// <para>Gets the emissive boost for the primitive component. </para>
		/// </summary>
		public virtual float GetEmissiveBoost(int ElementIndex)
			=> E_UPrimitiveComponent_GetEmissiveBoost(this, ElementIndex);
		
		
		/// <summary>
		/// <para>Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space. </para>
		/// </summary>
		public virtual FVector GetInertiaTensor(string BoneName)
			=> E_UPrimitiveComponent_GetInertiaTensor(this, BoneName);
		
		
		/// <summary>
		/// <para>Returns the light and shadow map memory for this primitive in its out variables. </para>
		/// <para>Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one. </para>
		/// <param name="out">LightMapMemoryUsage		Memory usage in bytes for light map (either texel or vertex) data </param>
		/// <param name="out">ShadowMapMemoryUsage	Memory usage in bytes for shadow map (either texel or vertex) data </param>
		/// </summary>
		public virtual void GetLightAndShadowMapMemoryUsage(int LightMapMemoryUsage, int ShadowMapMemoryUsage)
			=> E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(this, LightMapMemoryUsage, ShadowMapMemoryUsage);
		
		
		/// <summary>
		/// <para>Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps. </para>
		/// <para>0 if not supported or no static shadowing. </para>
		/// <param name="Width">out]	Width of light/shadow map </param>
		/// <param name="Height">out]	Height of light/shadow map </param>
		/// <return>bool			true if LightMap values are padded, false if not </return>
		/// </summary>
		public virtual bool GetLightMapResolution(int Width, int Height)
			=> E_UPrimitiveComponent_GetLightMapResolution(this, Width, Height);
		
		
		/// <summary>
		/// <para>Returns the linear damping of this component. </para>
		/// </summary>
		public virtual float GetLinearDamping()
			=> E_UPrimitiveComponent_GetLinearDamping(this);
		
		
		/// <summary>
		/// <para>Returns the mass of this component in kg. </para>
		/// </summary>
		public virtual float GetMass()
			=> E_UPrimitiveComponent_GetMass(this);
		
		
		/// <summary>
		/// <para>Returns the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public virtual float GetMassScale(string BoneName)
			=> E_UPrimitiveComponent_GetMassScale(this, BoneName);
		
		
		/// <summary>
		/// <return>number of material elements in this primitive </return>
		/// </summary>
		public virtual int GetNumMaterials()
			=> E_UPrimitiveComponent_GetNumMaterials(this);
		
		
		/// <summary>
		/// <para>Get the angular velocity of a single body, in degrees per second. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetPhysicsAngularVelocity(string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsAngularVelocity(this, BoneName);
		
		
		/// <summary>
		/// <para>Get the linear velocity of a single body. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetPhysicsLinearVelocity(string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsLinearVelocity(this, BoneName);
		
		
		/// <summary>
		/// <para>Get the linear velocity of a point on a single body. </para>
		/// <param name="Point">Point is specified in world space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetPhysicsLinearVelocityAtPoint(FVector Point, string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(this, Point, BoneName);
		
		public virtual bool GetShadowIndirectOnly()
			=> E_UPrimitiveComponent_GetShadowIndirectOnly(this);
		
		
		/// <summary>
		/// <para>Determines the DPG the primitive's primary elements are drawn in. </para>
		/// <para>Even if the primitive's elements are drawn in multiple DPGs, a primary DPG is needed for occlusion culling and shadow projection. </para>
		/// <return>The DPG the primitive's primary elements will be drawn in. </return>
		/// </summary>
		public virtual byte GetStaticDepthPriorityGroup()
			=> E_UPrimitiveComponent_GetStaticDepthPriorityGroup(this);
		
		
		/// <summary>
		/// <para>Returns the static lightmap resolution used for this primitive. </para>
		/// <para>0 if not supported or no static shadowing. </para>
		/// <return>int32		The StaticLightmapResolution for the component </return>
		/// </summary>
		public virtual int GetStaticLightMapResolution()
			=> E_UPrimitiveComponent_GetStaticLightMapResolution(this);
		
		
		/// <summary>
		/// <return>True if a primitive's parameters as well as its position is static during gameplay, and can thus use static lighting. </return>
		/// </summary>
		public bool HasStaticLighting()
			=> E_UPrimitiveComponent_HasStaticLighting(this);
		
		public virtual bool HasValidSettingsForStaticLighting(bool bOverlookInvalidComponents)
			=> E_UPrimitiveComponent_HasValidSettingsForStaticLighting(this, bOverlookInvalidComponents);
		
		
		/// <summary>
		/// <para>Returns if any body in this component is currently awake and simulating. </para>
		/// </summary>
		public virtual bool IsAnyRigidBodyAwake()
			=> E_UPrimitiveComponent_IsAnyRigidBodyAwake(this);
		
		
		/// <summary>
		/// <para>Whether this primitive is referenced by the streaming manager and should sent callbacks when detached or destroyed </para>
		/// </summary>
		public bool IsAttachedToStreamingManager()
			=> E_UPrimitiveComponent_IsAttachedToStreamingManager(this);
		
		
		/// <summary>
		/// <para>Component is directly selected in the editor separate from its parent actor </para>
		/// </summary>
		public bool IsComponentIndividuallySelected()
			=> E_UPrimitiveComponent_IsComponentIndividuallySelected(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is affected by gravity. Returns always false if the component is not simulated. </para>
		/// </summary>
		public virtual bool IsGravityEnabled()
			=> E_UPrimitiveComponent_IsGravityEnabled(this);
		
		
		/// <summary>
		/// <para>Returns whether we have the post physics tick enabled </para>
		/// </summary>
		public bool IsPostPhysicsComponentTickEnabled()
			=> E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(this);
		
		
		/// <summary>
		/// <para>Whether the component has been welded to another simulating component </para>
		/// </summary>
		public bool IsWelded()
			=> E_UPrimitiveComponent_IsWelded(this);
		
		
		/// <summary>
		/// <para>This isn't bound extent, but for shape component to utilize extent is 0. </para>
		/// <para>For normal primitive, this is 0, for ShapeComponent, this will have valid information </para>
		/// </summary>
		public virtual bool IsZeroExtent()
			=> E_UPrimitiveComponent_IsZeroExtent(this);
		
		
		/// <summary>
		/// <para>Utility to see if there is any form of collision (query or physics) enabled on this component. </para>
		/// </summary>
		public bool IsCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsCollisionEnabled(this);
		
		
		/// <summary>
		/// <para>Utility to see if there is any physics collision enabled on this component. </para>
		/// </summary>
		public bool IsPhysicsCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(this);
		
		
		/// <summary>
		/// <para>Utility to see if there is any query collision enabled on this component. </para>
		/// </summary>
		public bool IsQueryCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(this);
		
		
		/// <summary>
		/// <para>Called when the BodyInstance ResponseToChannels, CollisionEnabled or bNotifyRigidBodyCollision changes, in case subclasses want to use that information. </para>
		/// </summary>
		protected virtual void OnComponentCollisionSettingsChanged()
			=> E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(this);
		
		
		/// <summary>
		/// <para>Pushes new hover state to the render thread primitive proxy </para>
		/// <param name="bInHovered">true if the proxy should display as if hovered </param>
		/// </summary>
		public void PushHoveredToProxy(bool bInHovered)
			=> E_UPrimitiveComponent_PushHoveredToProxy(this, bInHovered);
		
		
		/// <summary>
		/// <para>Pushes new selection state to the render thread primitive proxy </para>
		/// </summary>
		public void PushSelectionToProxy()
			=> E_UPrimitiveComponent_PushSelectionToProxy(this);
		
		
		/// <summary>
		/// <para>Force all bodies in this component to sleep. </para>
		/// </summary>
		public virtual void PutAllRigidBodiesToSleep()
			=> E_UPrimitiveComponent_PutAllRigidBodiesToSleep(this);
		
		
		/// <summary>
		/// <para>Force a single body back to sleep. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to put to sleep. 'None' indicates root body. </param>
		/// </summary>
		public void PutRigidBodyToSleep(string BoneName)
			=> E_UPrimitiveComponent_PutRigidBodyToSleep(this, BoneName);
		
		
		/// <summary>
		/// <para>Returns if a single body is currently awake and simulating. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to return wakeful state from. 'None' indicates root body. </param>
		/// </summary>
		public bool RigidBodyIsAwake(string BoneName)
			=> E_UPrimitiveComponent_RigidBodyIsAwake(this, BoneName);
		
		
		/// <summary>
		/// <para>Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object. </para>
		/// </summary>
		public virtual FVector ScaleByMomentOfInertia(FVector InputVector, string BoneName)
			=> E_UPrimitiveComponent_ScaleByMomentOfInertia(this, InputVector, BoneName);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the physics engine </para>
		/// </summary>
		protected void SendPhysicsTransform(ETeleportType Teleport)
			=> E_UPrimitiveComponent_SendPhysicsTransform(this, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Change the mass scale used fo all bodies in this component </para>
		/// </summary>
		public virtual void SetAllMassScale(float InMassScale)
			=> E_UPrimitiveComponent_SetAllMassScale(this, InMassScale);
		
		
		/// <summary>
		/// <para>Set the linear velocity of all bodies in this component. </para>
		/// <param name="NewVel">New linear velocity to apply to physics. </param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body. </param>
		/// </summary>
		public virtual void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
			=> E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(this, NewVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the position of all bodies in this component. </para>
		/// <para>If a SkeletalMeshComponent, the root body will be placed at the desired position, and the same delta is applied to all other bodies. </para>
		/// <param name="NewPos">New position for the body </param>
		/// </summary>
		public virtual void SetAllPhysicsPosition(FVector NewPos)
			=> E_UPrimitiveComponent_SetAllPhysicsPosition(this, NewPos);
		
		
		/// <summary>
		/// <para>Sets the angular damping of this component. </para>
		/// </summary>
		public virtual void SetAngularDamping(float InDamping)
			=> E_UPrimitiveComponent_SetAngularDamping(this, InDamping);
		
		
		/// <summary>
		/// <para>Scale the bounds of this object, used for frustum culling. Useful for features like WorldPositionOffset. </para>
		/// </summary>
		public void SetBoundsScale(float NewBoundsScale)
			=> E_UPrimitiveComponent_SetBoundsScale(this, NewBoundsScale);
		
		
		/// <summary>
		/// <para>Utility to cache the max draw distance based on cull distance volumes or the desired max draw distance </para>
		/// </summary>
		public void SetCachedMaxDrawDistance(float NewCachedMaxDrawDistance)
			=> E_UPrimitiveComponent_SetCachedMaxDrawDistance(this, NewCachedMaxDrawDistance);
		
		
		/// <summary>
		/// <para>Changes the value of CastShadow. </para>
		/// </summary>
		public void SetCastShadow(bool NewCastShadow)
			=> E_UPrimitiveComponent_SetCastShadow(this, NewCastShadow);
		
		
		/// <summary>
		/// <para>Set the center of mass of a single body. This will offset the physx-calculated center of mass. </para>
		/// <para>Note that in the case where multiple bodies are attached together, the center of mass will be set for the entire group. </para>
		/// <param name="CenterOfMassOffset">User specified offset for the center of mass of this object, from the calculated location. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body. </param>
		/// </summary>
		public void SetCenterOfMass(FVector CenterOfMassOffset, string BoneName)
			=> E_UPrimitiveComponent_SetCenterOfMass(this, CenterOfMassOffset, BoneName);
		
		
		/// <summary>
		/// <para>Changes the collision channel that this object uses when it moves </para>
		/// <param name="Channel">The new channel for this component to use </param>
		/// </summary>
		public virtual void SetCollisionObjectType(ECollisionChannel Channel)
			=> E_UPrimitiveComponent_SetCollisionObjectType(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Set Collision Profile Name </para>
		/// <para>This function is called by constructors when they set ProfileName </para>
		/// <para>This will change current CollisionProfileName to be this, and overwrite Collision Setting </para>
		/// <param name="InCollisionProfileName">New Profile Name </param>
		/// </summary>
		public virtual void SetCollisionProfileName(string InCollisionProfileName)
			=> E_UPrimitiveComponent_SetCollisionProfileName(this, InCollisionProfileName);
		
		
		/// <summary>
		/// <para>Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse </para>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public virtual void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
			=> E_UPrimitiveComponent_SetCollisionResponseToAllChannels(this, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Changes a member of the ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="Channel">The channel to change the response of </param>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public virtual void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
			=> E_UPrimitiveComponent_SetCollisionResponseToChannel(this, (byte)Channel, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Changes the value of CullDistance. </para>
		/// <param name="NewCullDistance">The value to assign to CullDistance. </param>
		/// </summary>
		public void SetMaxDrawDistance(float NewCullDistance)
			=> E_UPrimitiveComponent_SetCullDistance(this, NewCullDistance);
		
		
		/// <summary>
		/// <para>Sets the CustomDepth stencil value (0 - 255) and marks the render state dirty. </para>
		/// </summary>
		public void SetCustomDepthStencilValue(int Value)
			=> E_UPrimitiveComponent_SetCustomDepthStencilValue(this, Value);
		
		
		/// <summary>
		/// <para>Sets the CustomDepth stencil write mask and marks the render state dirty. </para>
		/// </summary>
		public void SetCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit)
			=> E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(this, (byte)WriteMaskBit);
		
		
		/// <summary>
		/// <para>Changes the value of DepthPriorityGroup. </para>
		/// <param name="NewDepthPriorityGroup">The value to assign to DepthPriorityGroup. </param>
		/// </summary>
		public void SetDepthPriorityGroup(ESceneDepthPriorityGroup NewDepthPriorityGroup)
			=> E_UPrimitiveComponent_SetDepthPriorityGroup(this, (byte)NewDepthPriorityGroup);
		
		
		/// <summary>
		/// <para>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true. </para>
		/// </summary>
		public virtual void SetEnableGravity(bool bGravityEnabled)
			=> E_UPrimitiveComponent_SetEnableGravity(this, bGravityEnabled);
		
		
		/// <summary>
		/// <para>Sets the linear damping of this component. </para>
		/// </summary>
		public virtual void SetLinearDamping(float InDamping)
			=> E_UPrimitiveComponent_SetLinearDamping(this, InDamping);
		
		
		/// <summary>
		/// <para>Override the mass (in Kg) of a single physics body. </para>
		/// <para>Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group. </para>
		/// <para>Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass. </para>
		/// </summary>
		public virtual void SetMassOverrideInKg(string BoneName, float MassInKg, bool bOverrideMass)
			=> E_UPrimitiveComponent_SetMassOverrideInKg(this, BoneName, MassInKg, bOverrideMass);
		
		
		/// <summary>
		/// <para>Change the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public virtual void SetMassScale(string BoneName, float InMassScale)
			=> E_UPrimitiveComponent_SetMassScale(this, BoneName, InMassScale);
		
		
		/// <summary>
		/// <para>Changes the value of bNotifyRigidBodyCollision </para>
		/// <param name="bNewNotifyRigidBodyCollision">The value to assign to bNotifyRigidBodyCollision </param>
		/// </summary>
		public virtual void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
			=> E_UPrimitiveComponent_SetNotifyRigidBodyCollision(this, bNewNotifyRigidBodyCollision);
		
		
		/// <summary>
		/// <para>Changes the value of bOnlyOwnerSee. </para>
		/// </summary>
		public void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
			=> E_UPrimitiveComponent_SetOnlyOwnerSee(this, bNewOnlyOwnerSee);
		
		
		/// <summary>
		/// <para>Changes the value of bOwnerNoSee. </para>
		/// </summary>
		public void SetOwnerNoSee(bool bNewOwnerNoSee)
			=> E_UPrimitiveComponent_SetOwnerNoSee(this, bNewOwnerNoSee);
		
		
		/// <summary>
		/// <para>Set the angular velocity of a single body. </para>
		/// <para>This should be used cautiously - it may be better to use AddTorque or AddImpulse. </para>
		/// <param name="NewAngVel">New angular velocity to apply to body, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsAngularVelocity(FVector NewAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsAngularVelocity(this, NewAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Set the linear velocity of a single body. </para>
		/// <para>This should be used cautiously - it may be better to use AddForce or AddImpulse. </para>
		/// <param name="NewVel">New linear velocity to apply to physics. </param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsLinearVelocity(this, NewVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Set the maximum angular velocity of a single body. </para>
		/// <param name="NewMaxAngVel">New maximum angular velocity to apply to body, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewMaxAngVel is added to the existing maximum angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsMaxAngularVelocity(float NewMaxAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(this, NewMaxAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Controls if we get a post physics tick or not. If set during ticking, will take effect next frame </para>
		/// </summary>
		public void SetPostPhysicsComponentTickEnabled(bool bEnable)
			=> E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(this, bEnable);
		
		
		/// <summary>
		/// <para>Changes the value of bReceivesDecals. </para>
		/// </summary>
		public void SetReceivesDecals(bool bNewReceivesDecals)
			=> E_UPrimitiveComponent_SetReceivesDecals(this, bNewReceivesDecals);
		
		
		/// <summary>
		/// <para>Sets the bRenderCustomDepth property and marks the render state dirty. </para>
		/// </summary>
		public void SetRenderCustomDepth(bool bValue)
			=> E_UPrimitiveComponent_SetRenderCustomDepth(this, bValue);
		
		
		/// <summary>
		/// <para>Sets bRenderInMainPass property and marks the render state dirty. </para>
		/// </summary>
		public void SetRenderInMainPass(bool bValue)
			=> E_UPrimitiveComponent_SetRenderInMainPass(this, bValue);
		
		
		/// <summary>
		/// <para>Sets bRenderInMono property and marks the render state dirty. </para>
		/// </summary>
		public void SetRenderInMono(bool bValue)
			=> E_UPrimitiveComponent_SetRenderInMono(this, bValue);
		
		
		/// <summary>
		/// <para>Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic). </para>
		/// <para>Note that if this component is currently attached to something, beginning simulation will detach it. </para>
		/// <param name="bSimulate">New simulation state for single body </param>
		/// </summary>
		public virtual void SetSimulatePhysics(bool bSimulate)
			=> E_UPrimitiveComponent_SetSimulatePhysics(this, bSimulate);
		
		
		/// <summary>
		/// <para>Changes the value of bSingleSampleShadowFromStationaryLights. </para>
		/// </summary>
		public void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights)
			=> E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(this, bNewSingleSampleShadowFromStationaryLights);
		
		
		/// <summary>
		/// <para>Changes the value of TranslucentSortPriority. </para>
		/// </summary>
		public void SetTranslucentSortPriority(int NewTranslucentSortPriority)
			=> E_UPrimitiveComponent_SetTranslucentSortPriority(this, NewTranslucentSortPriority);
		
		
		/// <summary>
		/// <para>Changes the value of bUseViewOwnerDepthPriorityGroup and ViewOwnerDepthPriorityGroup. </para>
		/// <param name="bNewUseViewOwnerDepthPriorityGroup">The value to assign to bUseViewOwnerDepthPriorityGroup. </param>
		/// <param name="NewViewOwnerDepthPriorityGroup">The value to assign to ViewOwnerDepthPriorityGroup. </param>
		/// </summary>
		public void SetViewOwnerDepthPriorityGroup(bool bNewUseViewOwnerDepthPriorityGroup, ESceneDepthPriorityGroup NewViewOwnerDepthPriorityGroup)
			=> E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(this, bNewUseViewOwnerDepthPriorityGroup, (byte)NewViewOwnerDepthPriorityGroup);
		
		
		/// <summary>
		/// <para>Looking at various values of the component, determines if this </para>
		/// <para>component should be added to the scene </para>
		/// <return>true if the component is visible and should be added to the scene, false otherwise </return>
		/// </summary>
		public bool ShouldComponentAddToScene()
			=> E_UPrimitiveComponent_ShouldComponentAddToScene(this);
		
		
		/// <summary>
		/// <para>Determines whether the proxy for this primitive type needs to be recreated whenever the primitive moves. </para>
		/// <return>true to recreate the proxy when UpdateTransform is called. </return>
		/// </summary>
		public virtual bool ShouldRecreateProxyOnUpdateTransform()
			=> E_UPrimitiveComponent_ShouldRecreateProxyOnUpdateTransform(this);
		
		
		/// <summary>
		/// <return>true if the owner is selected and this component is selectable </return>
		/// </summary>
		public virtual bool ShouldRenderSelected()
			=> E_UPrimitiveComponent_ShouldRenderSelected(this);
		
		
		/// <summary>
		/// <para>Whether the component type supports static lighting. </para>
		/// </summary>
		protected virtual bool SupportsStaticLighting()
			=> E_UPrimitiveComponent_SupportsStaticLighting(this);
		
		
		/// <summary>
		/// <para>Move this component to match the physics rigid body pose. Note, a warning will be generated if you call this function on a component that is attached to something </para>
		/// </summary>
		public void SyncComponentToRBPhysics()
			=> E_UPrimitiveComponent_SyncComponentToRBPhysics(this);
		
		
		/// <summary>
		/// <para>Unwelds the children of this component. Attachment is maintained </para>
		/// </summary>
		public virtual void UnWeldChildren()
			=> E_UPrimitiveComponent_UnWeldChildren(this);
		
		
		/// <summary>
		/// <para>UnWelds this component from its parent component. Attachment is maintained (DetachFromParent automatically unwelds) </para>
		/// </summary>
		public virtual void UnWeldFromParent()
			=> E_UPrimitiveComponent_UnWeldFromParent(this);
		
		
		/// <summary>
		/// <para>Internal function that updates physics objects to match the component collision settings. </para>
		/// </summary>
		protected virtual void UpdatePhysicsToRBChannels()
			=> E_UPrimitiveComponent_UpdatePhysicsToRBChannels(this);
		
		
		/// <summary>
		/// <return>true if only unlit materials are used for rendering, false otherwise. </return>
		/// </summary>
		public virtual bool UsesOnlyUnlitMaterials()
			=> E_UPrimitiveComponent_UsesOnlyUnlitMaterials(this);
		
		
		/// <summary>
		/// <para>Ensure simulation is running for all bodies in this component. </para>
		/// </summary>
		public virtual void WakeAllRigidBodies()
			=> E_UPrimitiveComponent_WakeAllRigidBodies(this);
		
		
		/// <summary>
		/// <para>'Wake' physics simulation for a single body. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body. </param>
		/// </summary>
		public virtual void WakeRigidBody(string BoneName)
			=> E_UPrimitiveComponent_WakeRigidBody(this, BoneName);
		
		#endregion
		
		public static implicit operator IntPtr(UPrimitiveComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPrimitiveComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPrimitiveComponent>(PtrDesc);
		}}}
