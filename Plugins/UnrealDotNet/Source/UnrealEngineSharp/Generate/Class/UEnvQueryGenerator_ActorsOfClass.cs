// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_ActorsOfClass.h:15

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_ActorsOfClass : UEnvQueryGenerator
	{
		public UEnvQueryGenerator_ActorsOfClass(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_ActorsOfClass(UObject Parent = null, string Name = "EnvQueryGenerator_ActorsOfClass")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_ActorsOfClass(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_ActorsOfClass_GenerateOnlyActorsInRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_ActorsOfClass_GenerateOnlyActorsInRadius_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryGenerator_ActorsOfClass_SearchRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryGenerator_ActorsOfClass_SearchRadius_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_ActorsOfClass(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// If true, this will only returns actors of the specified class within the SearchRadius of the SearchCenter context.  If false, it will return ALL actors of the specified class in the world.
		/// </summary>
		public FAIDataProviderBoolValue GenerateOnlyActorsInRadius
		{
			get => E_PROP_UEnvQueryGenerator_ActorsOfClass_GenerateOnlyActorsInRadius_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_ActorsOfClass_GenerateOnlyActorsInRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance of path between point and context.  NOTE: Zero and negative values will never return any results if
		/// <para>UseRadius is true.  "Within" requires Distance < Radius.  Actors ON the circle (Distance == Radius) are excluded. </para>
		/// </summary>
		public FAIDataProviderFloatValue SearchRadius
		{
			get => E_PROP_UEnvQueryGenerator_ActorsOfClass_SearchRadius_GET(NativePointer);
			set => E_PROP_UEnvQueryGenerator_ActorsOfClass_SearchRadius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_ActorsOfClass self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_ActorsOfClass(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_ActorsOfClass>(PtrDesc);
		}}}
