// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_PlayAnimation.h:19

namespace UnrealEngine
{
	public partial class UBTTask_PlayAnimation : UBTTaskNode
	{
		public UBTTask_PlayAnimation(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_PlayAnimation(UObject Parent = null, string Name = "BTTask_PlayAnimation")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_PlayAnimation(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UBTTask_PlayAnimation_CachedSkelMesh_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_PlayAnimation_CachedSkelMesh_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UBTTask_PlayAnimation_MyOwnerComp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_PlayAnimation_MyOwnerComp_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_PlayAnimation(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_PlayAnimation_CleanUp(IntPtr self, IntPtr ownerComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_PlayAnimation_OnAnimationTimerDone(IntPtr self);
		
		#endregion
		
		#region Property
		public USkeletalMeshComponent CachedSkelMesh
		{
			get => E_PROP_UBTTask_PlayAnimation_CachedSkelMesh_GET(NativePointer);
			set => E_PROP_UBTTask_PlayAnimation_CachedSkelMesh_SET(NativePointer, value);
		}

		public UBehaviorTreeComponent MyOwnerComp
		{
			get => E_PROP_UBTTask_PlayAnimation_MyOwnerComp_GET(NativePointer);
			set => E_PROP_UBTTask_PlayAnimation_MyOwnerComp_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected void CleanUp(UBehaviorTreeComponent ownerComp)
			=> E_UBTTask_PlayAnimation_CleanUp(this, ownerComp);
		
		public void OnAnimationTimerDone()
			=> E_UBTTask_PlayAnimation_OnAnimationTimerDone(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_PlayAnimation self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_PlayAnimation(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_PlayAnimation>(PtrDesc);
		}}}
