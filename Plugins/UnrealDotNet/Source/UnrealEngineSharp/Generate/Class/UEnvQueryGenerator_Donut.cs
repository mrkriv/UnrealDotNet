// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_Donut.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_Donut : UEnvQueryGenerator_ProjectedPoints
	{
		public UEnvQueryGenerator_Donut(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_Donut(UObject Parent = null, string Name = "EnvQueryGenerator_Donut")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_Donut(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_Donut_ArcAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_Donut_ArcAngle_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_Donut_ArcDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_Donut_ArcDirection_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UEnvQueryGenerator_Donut_bUseSpiralPattern_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_Donut_bUseSpiralPattern_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_Donut_InnerRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_Donut_InnerRadius_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_Donut_NumberOfRings_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_Donut_NumberOfRings_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_Donut_OuterRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_Donut_OuterRadius_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_Donut_PointsPerRing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_Donut_PointsPerRing_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_Donut(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UEnvQueryGenerator_Donut_GetArcBisectorAngle(IntPtr self, IntPtr queryInstance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryGenerator_Donut_IsAngleAllowed(IntPtr self, float testAngleRad, float bisectAngleDeg, float angleRangeDeg, bool bConstrainAngle);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// If you generate items on a piece of circle you define angle of Arc cut here
		/// </summary>
		public FAIDataProviderFloatValue ArcAngle
		{
			get => E_PROP_UEnvQueryGenerator_Donut_ArcAngle_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_Donut_ArcAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If you generate items on a piece of circle you define direction of Arc cut here
		/// </summary>
		public FEnvDirection ArcDirection
		{
			get => E_PROP_UEnvQueryGenerator_Donut_ArcDirection_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_Donut_ArcDirection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, the rings of the wheel will be rotated in a spiral pattern.  If false, they will all be at a zero
		/// <para>rotation, looking more like the spokes on a wheel. </para>
		/// </summary>
		public bool bUseSpiralPattern
		{
			get => E_PROP_UEnvQueryGenerator_Donut_bUseSpiralPattern_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_Donut_bUseSpiralPattern_SET(NativePointer, value);
		}

		
		/// <summary>
		/// min distance between point and context
		/// </summary>
		public FAIDataProviderFloatValue InnerRadius
		{
			get => E_PROP_UEnvQueryGenerator_Donut_InnerRadius_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_Donut_InnerRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// number of rings to generate
		/// </summary>
		public FAIDataProviderIntValue NumberOfRings
		{
			get => E_PROP_UEnvQueryGenerator_Donut_NumberOfRings_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_Donut_NumberOfRings_SET(NativePointer, value);
		}

		
		/// <summary>
		/// max distance between point and context
		/// </summary>
		public FAIDataProviderFloatValue OuterRadius
		{
			get => E_PROP_UEnvQueryGenerator_Donut_OuterRadius_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_Donut_OuterRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// number of items to generate for each ring
		/// </summary>
		public FAIDataProviderIntValue PointsPerRing
		{
			get => E_PROP_UEnvQueryGenerator_Donut_PointsPerRing_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_Donut_PointsPerRing_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected float GetArcBisectorAngle(FEnvQueryInstance queryInstance)
			=> E_UEnvQueryGenerator_Donut_GetArcBisectorAngle(this, queryInstance);
		
		protected bool IsAngleAllowed(float testAngleRad, float bisectAngleDeg, float angleRangeDeg, bool bConstrainAngle)
			=> E_UEnvQueryGenerator_Donut_IsAngleAllowed(this, testAngleRad, bisectAngleDeg, angleRangeDeg, bConstrainAngle);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_Donut self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_Donut(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_Donut>(PtrDesc);
		}}}
