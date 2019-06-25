// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DetourCrowdAIController.h:12

namespace UnrealEngine
{
	public partial class ADetourCrowdAIController : AAIController
	{
		public ADetourCrowdAIController(IntPtr adress)
			: base(adress)
		{
		}

		public ADetourCrowdAIController(UObject Parent = null, string Name = "DetourCrowdAIController")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ADetourCrowdAIController(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ADetourCrowdAIController(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ADetourCrowdAIController self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ADetourCrowdAIController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ADetourCrowdAIController>(PtrDesc);
		}}}
