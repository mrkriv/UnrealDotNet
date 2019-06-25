// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionTypes.h:291

namespace UnrealEngine
{
	public partial class FPerceptionStimuliSource : NativeStructWrapper
	{
		public FPerceptionStimuliSource(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPerceptionStimuliSource() :
			base(E_CreateStruct_FPerceptionStimuliSource(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPerceptionStimuliSource_RelevantSenses_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPerceptionStimuliSource_RelevantSenses_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPerceptionStimuliSource();
		
		#endregion
		
		#region Property
		public FPerceptionChannelWhitelist RelevantSenses
		{
			get => E_PROP_FPerceptionStimuliSource_RelevantSenses_GET(NativePointer);
			set => E_PROP_FPerceptionStimuliSource_RelevantSenses_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPerceptionStimuliSource self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPerceptionStimuliSource(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPerceptionStimuliSource(adress, false);
		}}}
