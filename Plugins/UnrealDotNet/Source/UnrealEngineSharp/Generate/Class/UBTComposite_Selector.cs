// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Composites\BTComposite_Selector.h:15

namespace UnrealEngine
{
	public partial class UBTComposite_Selector : UBTCompositeNode
	{
		public UBTComposite_Selector(IntPtr adress)
			: base(adress)
		{
		}

		public UBTComposite_Selector(UObject Parent = null, string Name = "BTComposite_Selector")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTComposite_Selector(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTComposite_Selector(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTComposite_Selector self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTComposite_Selector(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTComposite_Selector>(PtrDesc);
		}}}
