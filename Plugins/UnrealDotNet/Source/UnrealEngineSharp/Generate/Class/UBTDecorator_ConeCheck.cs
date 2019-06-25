// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_ConeCheck.h:25

namespace UnrealEngine
{
	public partial class UBTDecorator_ConeCheck : UBTDecorator
	{
		public UBTDecorator_ConeCheck(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_ConeCheck(UObject Parent = null, string Name = "BTDecorator_ConeCheck")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_ConeCheck(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UBTDecorator_ConeCheck_ConeDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_ConeCheck_ConeDirection_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_ConeCheck_ConeHalfAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_ConeCheck_ConeHalfAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_ConeCheck_ConeHalfAngleDot_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_ConeCheck_ConeHalfAngleDot_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UBTDecorator_ConeCheck_ConeOrigin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_ConeCheck_ConeOrigin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UBTDecorator_ConeCheck_Observed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_ConeCheck_Observed_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_ConeCheck(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_ConeCheck_CalculateDirection(IntPtr self, IntPtr blackboardComp, IntPtr origin, IntPtr end, IntPtr direction);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// "None" means "use ConeOrigin's direction"
		/// </summary>
		public FBlackboardKeySelector ConeDirection
		{
			get => E_PROP_UBTDecorator_ConeCheck_ConeDirection_GET(NativePointer);
			set => E_PROP_UBTDecorator_ConeCheck_ConeDirection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Angle between cone direction and code cone edge, or a half of the total cone angle
		/// </summary>
		public float ConeHalfAngle
		{
			get => E_PROP_UBTDecorator_ConeCheck_ConeHalfAngle_GET(NativePointer);
			set => E_PROP_UBTDecorator_ConeCheck_ConeHalfAngle_SET(NativePointer, value);
		}

		public float ConeHalfAngleDot
		{
			get => E_PROP_UBTDecorator_ConeCheck_ConeHalfAngleDot_GET(NativePointer);
			set => E_PROP_UBTDecorator_ConeCheck_ConeHalfAngleDot_SET(NativePointer, value);
		}

		
		/// <summary>
		/// blackboard key selector
		/// </summary>
		public FBlackboardKeySelector ConeOrigin
		{
			get => E_PROP_UBTDecorator_ConeCheck_ConeOrigin_GET(NativePointer);
			set => E_PROP_UBTDecorator_ConeCheck_ConeOrigin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// blackboard key selector
		/// </summary>
		public FBlackboardKeySelector Observed
		{
			get => E_PROP_UBTDecorator_ConeCheck_Observed_GET(NativePointer);
			set => E_PROP_UBTDecorator_ConeCheck_Observed_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected bool CalculateDirection(UBlackboardComponent blackboardComp, FBlackboardKeySelector origin, FBlackboardKeySelector end, FVector direction)
			=> E_UBTDecorator_ConeCheck_CalculateDirection(this, blackboardComp, origin, end, direction);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_ConeCheck self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_ConeCheck(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_ConeCheck>(PtrDesc);
		}}}
