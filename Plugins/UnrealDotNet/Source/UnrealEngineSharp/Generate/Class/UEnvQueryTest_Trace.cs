// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Tests\EnvQueryTest_Trace.h:18

namespace UnrealEngine
{
	public partial class UEnvQueryTest_Trace : UEnvQueryTest
	{
		public UEnvQueryTest_Trace(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryTest_Trace(UObject Parent = null, string Name = "EnvQueryTest_Trace")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryTest_Trace(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_Trace_ContextHeightOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_Trace_ContextHeightOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_Trace_ItemHeightOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_Trace_ItemHeightOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_Trace_TraceData_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_Trace_TraceData_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_Trace_TraceFromContext_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_Trace_TraceFromContext_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryTest_Trace(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_Trace_RunBoxTraceFrom(IntPtr self, IntPtr itemPos, IntPtr contextPos, IntPtr itemActor, IntPtr world, byte channel, IntPtr @params, IntPtr extent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_Trace_RunBoxTraceTo(IntPtr self, IntPtr itemPos, IntPtr contextPos, IntPtr itemActor, IntPtr world, byte channel, IntPtr @params, IntPtr extent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_Trace_RunCapsuleTraceFrom(IntPtr self, IntPtr itemPos, IntPtr contextPos, IntPtr itemActor, IntPtr world, byte channel, IntPtr @params, IntPtr extent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_Trace_RunCapsuleTraceTo(IntPtr self, IntPtr itemPos, IntPtr contextPos, IntPtr itemActor, IntPtr world, byte channel, IntPtr @params, IntPtr extent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_Trace_RunLineTraceFrom(IntPtr self, IntPtr itemPos, IntPtr contextPos, IntPtr itemActor, IntPtr world, byte channel, IntPtr @params, IntPtr extent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_Trace_RunLineTraceTo(IntPtr self, IntPtr itemPos, IntPtr contextPos, IntPtr itemActor, IntPtr world, byte channel, IntPtr @params, IntPtr extent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_Trace_RunSphereTraceFrom(IntPtr self, IntPtr itemPos, IntPtr contextPos, IntPtr itemActor, IntPtr world, byte channel, IntPtr @params, IntPtr extent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_Trace_RunSphereTraceTo(IntPtr self, IntPtr itemPos, IntPtr contextPos, IntPtr itemActor, IntPtr world, byte channel, IntPtr @params, IntPtr extent);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Z offset from querier
		/// </summary>
		public FAIDataProviderFloatValue ContextHeightOffset
		{
			get => E_PROP_UEnvQueryTest_Trace_ContextHeightOffset_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_Trace_ContextHeightOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Z offset from item
		/// </summary>
		public FAIDataProviderFloatValue ItemHeightOffset
		{
			get => E_PROP_UEnvQueryTest_Trace_ItemHeightOffset_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_Trace_ItemHeightOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// trace data
		/// </summary>
		public FEnvTraceData TraceData
		{
			get => E_PROP_UEnvQueryTest_Trace_TraceData_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_Trace_TraceData_SET(NativePointer, value);
		}

		
		/// <summary>
		/// trace direction
		/// </summary>
		public FAIDataProviderBoolValue TraceFromContext
		{
			get => E_PROP_UEnvQueryTest_Trace_TraceFromContext_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_Trace_TraceFromContext_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected bool RunBoxTraceFrom(FVector itemPos, FVector contextPos, AActor itemActor, UWorld world, ECollisionChannel channel, FCollisionQueryParams @params, FVector extent)
			=> E_UEnvQueryTest_Trace_RunBoxTraceFrom(this, itemPos, contextPos, itemActor, world, (byte)channel, @params, extent);
		
		protected bool RunBoxTraceTo(FVector itemPos, FVector contextPos, AActor itemActor, UWorld world, ECollisionChannel channel, FCollisionQueryParams @params, FVector extent)
			=> E_UEnvQueryTest_Trace_RunBoxTraceTo(this, itemPos, contextPos, itemActor, world, (byte)channel, @params, extent);
		
		protected bool RunCapsuleTraceFrom(FVector itemPos, FVector contextPos, AActor itemActor, UWorld world, ECollisionChannel channel, FCollisionQueryParams @params, FVector extent)
			=> E_UEnvQueryTest_Trace_RunCapsuleTraceFrom(this, itemPos, contextPos, itemActor, world, (byte)channel, @params, extent);
		
		protected bool RunCapsuleTraceTo(FVector itemPos, FVector contextPos, AActor itemActor, UWorld world, ECollisionChannel channel, FCollisionQueryParams @params, FVector extent)
			=> E_UEnvQueryTest_Trace_RunCapsuleTraceTo(this, itemPos, contextPos, itemActor, world, (byte)channel, @params, extent);
		
		protected bool RunLineTraceFrom(FVector itemPos, FVector contextPos, AActor itemActor, UWorld world, ECollisionChannel channel, FCollisionQueryParams @params, FVector extent)
			=> E_UEnvQueryTest_Trace_RunLineTraceFrom(this, itemPos, contextPos, itemActor, world, (byte)channel, @params, extent);
		
		protected bool RunLineTraceTo(FVector itemPos, FVector contextPos, AActor itemActor, UWorld world, ECollisionChannel channel, FCollisionQueryParams @params, FVector extent)
			=> E_UEnvQueryTest_Trace_RunLineTraceTo(this, itemPos, contextPos, itemActor, world, (byte)channel, @params, extent);
		
		protected bool RunSphereTraceFrom(FVector itemPos, FVector contextPos, AActor itemActor, UWorld world, ECollisionChannel channel, FCollisionQueryParams @params, FVector extent)
			=> E_UEnvQueryTest_Trace_RunSphereTraceFrom(this, itemPos, contextPos, itemActor, world, (byte)channel, @params, extent);
		
		protected bool RunSphereTraceTo(FVector itemPos, FVector contextPos, AActor itemActor, UWorld world, ECollisionChannel channel, FCollisionQueryParams @params, FVector extent)
			=> E_UEnvQueryTest_Trace_RunSphereTraceTo(this, itemPos, contextPos, itemActor, world, (byte)channel, @params, extent);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryTest_Trace self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryTest_Trace(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryTest_Trace>(PtrDesc);
		}}}
