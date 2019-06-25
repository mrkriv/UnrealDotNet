// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Tests\EnvQueryTest_Pathfinding.h:31

namespace UnrealEngine
{
	public partial class UEnvQueryTest_Pathfinding : UEnvQueryTest
	{
		public UEnvQueryTest_Pathfinding(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryTest_Pathfinding(UObject Parent = null, string Name = "EnvQueryTest_Pathfinding")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryTest_Pathfinding(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_Pathfinding_PathFromContext_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_Pathfinding_PathFromContext_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_Pathfinding_SkipUnreachable_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_Pathfinding_SkipUnreachable_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryTest_Pathfinding(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// pathfinding direction
		/// </summary>
		public FAIDataProviderBoolValue PathFromContext
		{
			get => E_PROP_UEnvQueryTest_Pathfinding_PathFromContext_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_Pathfinding_PathFromContext_SET(NativePointer, value);
		}

		
		/// <summary>
		/// if set, items with failed path will be invalidated (PathCost, PathLength)
		/// </summary>
		public FAIDataProviderBoolValue SkipUnreachable
		{
			get => E_PROP_UEnvQueryTest_Pathfinding_SkipUnreachable_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_Pathfinding_SkipUnreachable_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UEnvQueryTest_Pathfinding self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryTest_Pathfinding(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryTest_Pathfinding>(PtrDesc);
		}}}
