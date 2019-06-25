// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:713

namespace UnrealEngine
{
	public partial class UEnvQueryTypes : UObject
	{
		public UEnvQueryTypes(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryTypes(UObject Parent = null, string Name = "EnvQueryTypes")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryTypes(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEnvQueryTypes_UnlimitedStepTime_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryTypes(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEnvQueryTypes_GetShortTypeName(IntPtr self, IntPtr ob);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// special value used for executing query steps to prevent them from being time sliced
		/// </summary>
		public static float UnlimitedStepTime
		{
			get => E_PROP_UEnvQueryTypes_UnlimitedStepTime_GET();
		}

		#endregion
		
		#region ExternMethods
		public string GetShortTypeName(UObject ob)
			=> E_UEnvQueryTypes_GetShortTypeName(this, ob);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryTypes self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryTypes(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryTypes>(PtrDesc);
		}}}
