// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_MoveTo.h:36

namespace UnrealEngine
{
	public partial class UBTTask_MoveTo : UBTTask_BlackboardBase
	{
		public UBTTask_MoveTo(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_MoveTo(UObject Parent = null, string Name = "BTTask_MoveTo")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_MoveTo(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTTask_MoveTo_AcceptableRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_MoveTo_AcceptableRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTTask_MoveTo_ObservedBlackboardValueTolerance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_MoveTo_ObservedBlackboardValueTolerance_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_MoveTo(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// fixed distance added to threshold between AI and goal location in destination reach test
		/// </summary>
		public float AcceptableRadius
		{
			get => E_PROP_UBTTask_MoveTo_AcceptableRadius_GET(NativePointer);
			set => E_PROP_UBTTask_MoveTo_AcceptableRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// if task is expected to react to changes to location represented by BB key
		/// <para>this property can be used to tweak sensitivity of the mechanism. Value is </para>
		/// recommended to be less then AcceptableRadius
		/// </summary>
		public float ObservedBlackboardValueTolerance
		{
			get => E_PROP_UBTTask_MoveTo_ObservedBlackboardValueTolerance_GET(NativePointer);
			set => E_PROP_UBTTask_MoveTo_ObservedBlackboardValueTolerance_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBTTask_MoveTo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_MoveTo(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_MoveTo>(PtrDesc);
		}}}
