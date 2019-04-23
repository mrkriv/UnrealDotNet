// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ForceFeedbackAttenuation.h:20

namespace UnrealEngine
{
	public  partial class UForceFeedbackAttenuation : UObject
	{
		public UForceFeedbackAttenuation(IntPtr Adress)
			: base(Adress)
		{
		}

		public UForceFeedbackAttenuation(UObject Parent = null, string Name = "ForceFeedbackAttenuation")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UForceFeedbackAttenuation(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UForceFeedbackAttenuation(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UForceFeedbackAttenuation self)
		{
			return self.NativePointer;
		}

		public static implicit operator UForceFeedbackAttenuation(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UForceFeedbackAttenuation>(PtrDesc);
		}}}
