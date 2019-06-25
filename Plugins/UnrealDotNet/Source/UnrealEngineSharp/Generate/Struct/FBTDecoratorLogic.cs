// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTCompositeNode.h:52

namespace UnrealEngine
{
	public partial class FBTDecoratorLogic : NativeStructWrapper
	{
		public FBTDecoratorLogic(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTDecoratorLogic() :
			base(E_CreateStruct_FBTDecoratorLogic(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTDecoratorLogic();
		
		#endregion
		
		public static implicit operator IntPtr(FBTDecoratorLogic self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTDecoratorLogic(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTDecoratorLogic(adress, false);
		}}}
