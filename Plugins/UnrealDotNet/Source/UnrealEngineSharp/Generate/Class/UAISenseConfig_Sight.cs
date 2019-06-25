// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISenseConfig_Sight.h:18

namespace UnrealEngine
{
	public partial class UAISenseConfig_Sight : UAISenseConfig
	{
		public UAISenseConfig_Sight(IntPtr adress)
			: base(adress)
		{
		}

		public UAISenseConfig_Sight(UObject Parent = null, string Name = "AISenseConfig_Sight")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISenseConfig_Sight(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAISenseConfig_Sight_AutoSuccessRangeFromLastSeenLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseConfig_Sight_AutoSuccessRangeFromLastSeenLocation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UAISenseConfig_Sight_DetectionByAffiliation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseConfig_Sight_DetectionByAffiliation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAISenseConfig_Sight_LoseSightRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseConfig_Sight_LoseSightRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAISenseConfig_Sight_PeripheralVisionAngleDegrees_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseConfig_Sight_PeripheralVisionAngleDegrees_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAISenseConfig_Sight_SightRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseConfig_Sight_SightRadius_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISenseConfig_Sight(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// If not an InvalidRange (which is the default), we will always be able to see the target that has already been seen if they are within this range of their last seen location.
		/// </summary>
		public float AutoSuccessRangeFromLastSeenLocation
		{
			get => E_PROP_UAISenseConfig_Sight_AutoSuccessRangeFromLastSeenLocation_GET(NativePointer);
			set => E_PROP_UAISenseConfig_Sight_AutoSuccessRangeFromLastSeenLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// </summary>
		public FAISenseAffiliationFilter DetectionByAffiliation
		{
			get => E_PROP_UAISenseConfig_Sight_DetectionByAffiliation_GET(NativePointer);
			set => E_PROP_UAISenseConfig_Sight_DetectionByAffiliation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum sight distance to see target that has been already seen.
		/// </summary>
		public float LoseSightRadius
		{
			get => E_PROP_UAISenseConfig_Sight_LoseSightRadius_GET(NativePointer);
			set => E_PROP_UAISenseConfig_Sight_LoseSightRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How far to the side AI can see, in degrees. Use SetPeripheralVisionAngle to change the value at runtime.
		/// <para>The value represents the angle measured in relation to the forward vector, not the whole range. </para>
		/// </summary>
		public float PeripheralVisionHalfAngleDegrees
		{
			get => E_PROP_UAISenseConfig_Sight_PeripheralVisionAngleDegrees_GET(NativePointer);
			set => E_PROP_UAISenseConfig_Sight_PeripheralVisionAngleDegrees_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum sight distance to notice a target.
		/// </summary>
		public float SightRadius
		{
			get => E_PROP_UAISenseConfig_Sight_SightRadius_GET(NativePointer);
			set => E_PROP_UAISenseConfig_Sight_SightRadius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UAISenseConfig_Sight self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISenseConfig_Sight(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISenseConfig_Sight>(PtrDesc);
		}}}
