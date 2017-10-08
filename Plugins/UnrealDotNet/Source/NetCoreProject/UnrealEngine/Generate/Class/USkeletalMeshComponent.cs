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
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkeletalMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ClearMorphTargets(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_CreateBodySetup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetMorphTarget(IntPtr Self, string MorphTargetName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetPlayRate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetPosition(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsPlaying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Play(IntPtr Self, bool bLooping);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetMorphTarget(IntPtr Self, string MorphTargetName, float Value, bool bRemoveZeroWeight);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetPlayRate(IntPtr Self, float Rate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetPosition(IntPtr Self, float InPos, bool bFireNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Stop(IntPtr Self);
		
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
		/// <param name="bRemoveZeroWeight">Used by editor code when it should stay in the active list with zero weight </param>
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

		public static implicit operator USkeletalMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkeletalMeshComponent>(PtrDesc);
		}}}
