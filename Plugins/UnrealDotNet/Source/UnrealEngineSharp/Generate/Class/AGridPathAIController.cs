// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\GridPathAIController.h:9

namespace UnrealEngine
{
	public partial class AGridPathAIController : AAIController
	{
		public AGridPathAIController(IntPtr adress)
			: base(adress)
		{
		}

		public AGridPathAIController(UObject Parent = null, string Name = "GridPathAIController")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGridPathAIController(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGridPathAIController(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(AGridPathAIController self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AGridPathAIController(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGridPathAIController>(PtrDesc);
		}}}
