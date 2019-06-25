// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Composites\BTComposite_Sequence.h:15

namespace UnrealEngine
{
	public partial class UBTComposite_Sequence : UBTCompositeNode
	{
		public UBTComposite_Sequence(IntPtr adress)
			: base(adress)
		{
		}

		public UBTComposite_Sequence(UObject Parent = null, string Name = "BTComposite_Sequence")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTComposite_Sequence(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTComposite_Sequence(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTComposite_Sequence self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTComposite_Sequence(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTComposite_Sequence>(PtrDesc);
		}}}
