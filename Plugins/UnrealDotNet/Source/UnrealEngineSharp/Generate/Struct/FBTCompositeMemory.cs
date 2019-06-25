// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTCompositeNode.h:16

namespace UnrealEngine
{
	public partial class FBTCompositeMemory : NativeStructWrapper
	{
		public FBTCompositeMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTCompositeMemory() :
			base(E_CreateStruct_FBTCompositeMemory(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTCompositeMemory();
		
		#endregion
		
		public static implicit operator IntPtr(FBTCompositeMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTCompositeMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTCompositeMemory(adress, false);
		}}}
