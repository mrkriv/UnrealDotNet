// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Touch.h:36

namespace UnrealEngine
{
	public partial class UAISense_Touch : UAISense
	{
		public UAISense_Touch(IntPtr adress)
			: base(adress)
		{
		}

		public UAISense_Touch(UObject Parent = null, string Name = "AISense_Touch")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISense_Touch(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISense_Touch(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Touch_RegisterEvent(IntPtr self, IntPtr @event);
		
		#endregion
		
		#region ExternMethods
		public void RegisterEvent(FAITouchEvent @event)
			=> E_UAISense_Touch_RegisterEvent(this, @event);
		
		#endregion
		
		public static implicit operator IntPtr(UAISense_Touch self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISense_Touch(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISense_Touch>(PtrDesc);
		}}}
