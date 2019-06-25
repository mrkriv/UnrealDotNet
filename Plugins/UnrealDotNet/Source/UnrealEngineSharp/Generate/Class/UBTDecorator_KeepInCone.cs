// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_KeepInCone.h:23

namespace UnrealEngine
{
	public partial class UBTDecorator_KeepInCone : UBTDecorator
	{
		public UBTDecorator_KeepInCone(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_KeepInCone(UObject Parent = null, string Name = "BTDecorator_KeepInCone")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_KeepInCone(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_KeepInCone_ConeHalfAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_KeepInCone_ConeHalfAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_KeepInCone_ConeHalfAngleDot_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_KeepInCone_ConeHalfAngleDot_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UBTDecorator_KeepInCone_ConeOrigin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_KeepInCone_ConeOrigin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UBTDecorator_KeepInCone_Observed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_KeepInCone_Observed_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_KeepInCone(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_KeepInCone_CalculateCurrentDirection(IntPtr self, IntPtr ownerComp, IntPtr direction);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// max allowed time for execution of underlying node
		/// </summary>
		public float ConeHalfAngle
		{
			get => E_PROP_UBTDecorator_KeepInCone_ConeHalfAngle_GET(NativePointer);
			set => E_PROP_UBTDecorator_KeepInCone_ConeHalfAngle_SET(NativePointer, value);
		}

		public float ConeHalfAngleDot
		{
			get => E_PROP_UBTDecorator_KeepInCone_ConeHalfAngleDot_GET(NativePointer);
			set => E_PROP_UBTDecorator_KeepInCone_ConeHalfAngleDot_SET(NativePointer, value);
		}

		
		/// <summary>
		/// blackboard key selector
		/// </summary>
		public FBlackboardKeySelector ConeOrigin
		{
			get => E_PROP_UBTDecorator_KeepInCone_ConeOrigin_GET(NativePointer);
			set => E_PROP_UBTDecorator_KeepInCone_ConeOrigin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// blackboard key selector
		/// </summary>
		public FBlackboardKeySelector Observed
		{
			get => E_PROP_UBTDecorator_KeepInCone_Observed_GET(NativePointer);
			set => E_PROP_UBTDecorator_KeepInCone_Observed_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected bool CalculateCurrentDirection(UBehaviorTreeComponent ownerComp, FVector direction)
			=> E_UBTDecorator_KeepInCone_CalculateCurrentDirection(this, ownerComp, direction);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_KeepInCone self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_KeepInCone(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_KeepInCone>(PtrDesc);
		}}}
