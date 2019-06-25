// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_IsAtLocation.h:17

namespace UnrealEngine
{
	public partial class UBTDecorator_IsAtLocation : UBTDecorator_BlackboardBase
	{
		public UBTDecorator_IsAtLocation(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_IsAtLocation(UObject Parent = null, string Name = "BTDecorator_IsAtLocation")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_IsAtLocation(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_IsAtLocation_AcceptableRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_IsAtLocation_AcceptableRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UBTDecorator_IsAtLocation_GeometricDistanceType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_IsAtLocation_GeometricDistanceType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UBTDecorator_IsAtLocation_ParametrizedAcceptableRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_IsAtLocation_ParametrizedAcceptableRadius_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_IsAtLocation(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UBTDecorator_IsAtLocation_GetGeometricDistanceSquared(IntPtr self, IntPtr a, IntPtr b);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// distance threshold to accept as being at location
		/// </summary>
		public float AcceptableRadius
		{
			get => E_PROP_UBTDecorator_IsAtLocation_AcceptableRadius_GET(NativePointer);
			set => E_PROP_UBTDecorator_IsAtLocation_AcceptableRadius_SET(NativePointer, value);
		}

		public FAIDistanceType GeometricDistanceType
		{
			get => (FAIDistanceType)E_PROP_UBTDecorator_IsAtLocation_GeometricDistanceType_GET(NativePointer);
			set => E_PROP_UBTDecorator_IsAtLocation_GeometricDistanceType_SET(NativePointer, (byte)value);
		}

		public FAIDataProviderFloatValue ParametrizedAcceptableRadius
		{
			get => E_PROP_UBTDecorator_IsAtLocation_ParametrizedAcceptableRadius_GET(NativePointer);
			set => E_PROP_UBTDecorator_IsAtLocation_ParametrizedAcceptableRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected float GetGeometricDistanceSquared(FVector a, FVector b)
			=> E_UBTDecorator_IsAtLocation_GetGeometricDistanceSquared(this, a, b);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_IsAtLocation self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_IsAtLocation(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_IsAtLocation>(PtrDesc);
		}}}
