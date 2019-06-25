// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISenseEvent_Damage.h:12

namespace UnrealEngine
{
	public partial class UAISenseEvent_Damage : UAISenseEvent
	{
		public UAISenseEvent_Damage(IntPtr adress)
			: base(adress)
		{
		}

		public UAISenseEvent_Damage(UObject Parent = null, string Name = "AISenseEvent_Damage")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISenseEvent_Damage(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UAISenseEvent_Damage_Event_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseEvent_Damage_Event_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISenseEvent_Damage(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAISenseEvent_Damage_GetDamageEvent(IntPtr self);
		
		#endregion
		
		#region Property
		public FAIDamageEvent Event
		{
			get => E_PROP_UAISenseEvent_Damage_Event_GET(NativePointer);
			set => E_PROP_UAISenseEvent_Damage_Event_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public FAIDamageEvent GetDamageEvent()
			=> E_UAISenseEvent_Damage_GetDamageEvent(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAISenseEvent_Damage self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISenseEvent_Damage(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISenseEvent_Damage>(PtrDesc);
		}}}
