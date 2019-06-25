// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISenseConfig.h:18

namespace UnrealEngine
{
	public partial class UAISenseConfig : UObject
	{
		public UAISenseConfig(IntPtr adress)
			: base(adress)
		{
		}

		public UAISenseConfig(UObject Parent = null, string Name = "AISenseConfig")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISenseConfig(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISenseConfig(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UAISenseConfig_GetMaxAge(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAISenseConfig_GetSenseName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAISenseConfig_IsEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISenseConfig_SetMaxAge(IntPtr self, float newMaxAge);
		
		#endregion
		
		#region ExternMethods
		public float GetMaxAge()
			=> E_UAISenseConfig_GetMaxAge(this);
		
		public string GetSenseName()
			=> E_UAISenseConfig_GetSenseName(this);
		
		public bool IsEnabled()
			=> E_UAISenseConfig_IsEnabled(this);
		
		public void SetMaxAge(float newMaxAge)
			=> E_UAISenseConfig_SetMaxAge(this, newMaxAge);
		
		#endregion
		
		public static implicit operator IntPtr(UAISenseConfig self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISenseConfig(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISenseConfig>(PtrDesc);
		}}}
