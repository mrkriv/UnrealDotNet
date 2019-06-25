// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Generators\EnvQueryGenerator_Cone.h:15

namespace UnrealEngine
{
	public partial class UEnvQueryGenerator_Cone : UEnvQueryGenerator_ProjectedPoints
	{
		public UEnvQueryGenerator_Cone(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryGenerator_Cone(UObject Parent = null, string Name = "EnvQueryGenerator_Cone")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryGenerator_Cone(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryGenerator_Cone(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryGenerator_Cone_BindDataToDataProviders(IntPtr self, IntPtr queryInstance);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Binds data to data providers
		/// </summary>
		/// <param name="queryInstance">the instance of the query</param>
		public void BindDataToDataProviders(FEnvQueryInstance queryInstance)
			=> E_UEnvQueryGenerator_Cone_BindDataToDataProviders(this, queryInstance);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryGenerator_Cone self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryGenerator_Cone(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryGenerator_Cone>(PtrDesc);
		}}}
