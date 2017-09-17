using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USkeletalMeshComponent : USkinnedMeshComponent
	{
		public USkeletalMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USkeletalMeshComponent(UObject Parent = null, string Name = "SkeletalMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USkeletalMeshComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_USkeletalMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USkeletalMeshComponent_ClothBlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkeletalMeshComponent_ClothBlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_USkeletalMeshComponent_RootBoneTranslation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkeletalMeshComponent_RootBoneTranslation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkeletalMeshComponent_ClearMorphTargets(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkeletalMeshComponent_CreateBodySetup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USkeletalMeshComponent_GetMorphTarget(IntPtr Self, string MorphTargetName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USkeletalMeshComponent_GetPlayRate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USkeletalMeshComponent_GetPosition(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USkeletalMeshComponent_IsPlaying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkeletalMeshComponent_Play(IntPtr Self, bool bLooping);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkeletalMeshComponent_SetMorphTarget(IntPtr Self, string MorphTargetName, float Value, bool bRemoveZeroWeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkeletalMeshComponent_SetPlayRate(IntPtr Self, float Rate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkeletalMeshComponent_SetPosition(IntPtr Self, float InPos, bool bFireNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkeletalMeshComponent_Stop(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Temporary fix for local space kinematics. This only works for bodies that have no constraints and is needed by vehicles. Proper support will remove this flag </para>
		/// </summary>
		public bool bLocalSpaceKinematics
		{
			get => E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>On InitAnim should we set to ref pose (if false use first tick of animation data) </para>
		/// </summary>
		public bool bUseRefPoseOnInitAnim
		{
			get => E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>weight to blend between simulated results and key-framed positions </para>
		/// <para>if weight is 1.0, shows only cloth simulation results and 0.0 will show only skinned results </para>
		/// </summary>
		public float ClothBlendWeight
		{
			get => E_PROP_USkeletalMeshComponent_ClothBlendWeight_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_ClothBlendWeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Used to scale speed of all animations on this skeletal mesh. </para>
		/// </summary>
		public float GlobalAnimRateScale
		{
			get => E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_SET(NativePointer, value);
		}

		public FVector LineCheckBoundsScale
		{
			get => E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Threshold for physics asset bodies above which we use an aggregate for broadphase collisions </para>
		/// </summary>
		public int RagdollAggregateThreshold
		{
			get => E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_SET(NativePointer, value);
		}

		public FVector RootBoneTranslation
		{
			get => E_PROP_USkeletalMeshComponent_RootBoneTranslation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_RootBoneTranslation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clear all Morph Target that are set to this mesh </para>
		/// </summary>
		public void ClearMorphTargets()
			=> E_USkeletalMeshComponent_ClearMorphTargets(this);
		
		public void CreateBodySetup()
			=> E_USkeletalMeshComponent_CreateBodySetup(this);
		
		
		/// <summary>
		/// <para>Get Morph target with given name </para>
		/// </summary>
		public float GetMorphTarget(string MorphTargetName)
			=> E_USkeletalMeshComponent_GetMorphTarget(this, MorphTargetName);
		
		public float GetPlayRate()
			=> E_USkeletalMeshComponent_GetPlayRate(this);
		
		public float GetPosition()
			=> E_USkeletalMeshComponent_GetPosition(this);
		
		public bool IsPlaying()
			=> E_USkeletalMeshComponent_IsPlaying(this);
		
		public void Play(bool bLooping)
			=> E_USkeletalMeshComponent_Play(this, bLooping);
		
		
		/// <summary>
		/// <para>Set Morph Target with Name and Value(0-1) </para>
		/// <param name="bRemoveZeroWeight">: Used by editor code when it should stay in the active list with zero weight </param>
		/// </summary>
		public void SetMorphTarget(string MorphTargetName, float Value, bool bRemoveZeroWeight = true)
			=> E_USkeletalMeshComponent_SetMorphTarget(this, MorphTargetName, Value, bRemoveZeroWeight);
		
		public void SetPlayRate(float Rate)
			=> E_USkeletalMeshComponent_SetPlayRate(this, Rate);
		
		public void SetPosition(float InPos, bool bFireNotifies = true)
			=> E_USkeletalMeshComponent_SetPosition(this, InPos, bFireNotifies);
		
		public void Stop()
			=> E_USkeletalMeshComponent_Stop(this);
		
		#endregion
		
		public static implicit operator IntPtr(USkeletalMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USkeletalMeshComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USkeletalMeshComponent ?? new USkeletalMeshComponent(Adress);
		}}}
