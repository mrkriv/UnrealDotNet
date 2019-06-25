// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_OnCircle.h:26

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_OnCircle : UEnvQueryGenerator_ProjectedPoints
	{
		public UEnvQueryGenerator_OnCircle(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_OnCircle(UObject Parent = null, string Name = "EnvQueryGenerator_OnCircle")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_OnCircle(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEnvQueryGenerator_OnCircle_AngleRadians_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_AngleRadians_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_OnCircle_ArcAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_ArcAngle_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_OnCircle_ArcDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_ArcDirection_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UEnvQueryGenerator_OnCircle_bIgnoreAnyContextActorsWhenGeneratingCircle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_bIgnoreAnyContextActorsWhenGeneratingCircle_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_OnCircle_CircleCenterZOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_CircleCenterZOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_OnCircle_CircleRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_CircleRadius_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_OnCircle_NumberOfPoints_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_NumberOfPoints_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UEnvQueryGenerator_OnCircle_PointOnCircleSpacingMethod_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_PointOnCircleSpacingMethod_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_OnCircle_SpaceBetween_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_SpaceBetween_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_OnCircle_TraceData_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_OnCircle_TraceData_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_OnCircle(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UEnvQueryGenerator_OnCircle_CalcDirection(IntPtr self, IntPtr queryInstance);
		
		#endregion
		
		#region Property
		public float AngleRadians
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_AngleRadians_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_AngleRadians_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If you generate items on a piece of circle you define angle of Arc cut here
		/// </summary>
		public FAIDataProviderFloatValue ArcAngle
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_ArcAngle_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_ArcAngle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If you generate items on a piece of circle you define direction of Arc cut here
		/// </summary>
		public FEnvDirection ArcDirection
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_ArcDirection_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_ArcDirection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// ignore tracing into context actors when generating the circle
		/// </summary>
		public bool bIgnoreAnyContextActorsWhenGeneratingCircle
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_bIgnoreAnyContextActorsWhenGeneratingCircle_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_bIgnoreAnyContextActorsWhenGeneratingCircle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// context offset
		/// </summary>
		public FAIDataProviderFloatValue CircleCenterZOffset
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_CircleCenterZOffset_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_CircleCenterZOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// max distance of path between point and context
		/// </summary>
		public FAIDataProviderFloatValue CircleRadius
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_CircleRadius_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_CircleRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// this many items will be generated on a circle
		/// </summary>
		public FAIDataProviderIntValue NumberOfPoints
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_NumberOfPoints_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_NumberOfPoints_SET(NativePointer, value);
		}

		
		/// <summary>
		/// how we are choosing where the points are in the circle
		/// </summary>
		public EPointOnCircleSpacingMethod PointOnCircleSpacingMethod
		{
			get => (EPointOnCircleSpacingMethod)E_PROP_UEnvQueryGenerator_OnCircle_PointOnCircleSpacingMethod_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_PointOnCircleSpacingMethod_SET(NativePointer, (byte)value);
		}

		/// <summary>
		/// items will be generated on a circle this much apart
		/// </summary>
		public FAIDataProviderFloatValue SpaceBetween
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_SpaceBetween_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_SpaceBetween_SET(NativePointer, value);
		}

		
		/// <summary>
		/// horizontal trace for nearest obstacle
		/// </summary>
		public FEnvTraceData TraceData
		{
			get => E_PROP_UEnvQueryGenerator_OnCircle_TraceData_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_OnCircle_TraceData_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected FVector CalcDirection(FEnvQueryInstance queryInstance)
			=> E_UEnvQueryGenerator_OnCircle_CalcDirection(this, queryInstance);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_OnCircle self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_OnCircle(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_OnCircle>(PtrDesc);
		}
}
}
