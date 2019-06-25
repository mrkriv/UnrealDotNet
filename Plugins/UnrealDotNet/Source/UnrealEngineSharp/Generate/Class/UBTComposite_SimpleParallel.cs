// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Composites\BTComposite_SimpleParallel.h:54

namespace UnrealEngine
{
	public partial class UBTComposite_SimpleParallel : UBTCompositeNode
	{
		public UBTComposite_SimpleParallel(IntPtr adress)
			: base(adress)
		{
		}

		public UBTComposite_SimpleParallel(UObject Parent = null, string Name = "BTComposite_SimpleParallel")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTComposite_SimpleParallel(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTComposite_SimpleParallel(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTComposite_SimpleParallel self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTComposite_SimpleParallel(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTComposite_SimpleParallel>(PtrDesc);
		}}}
