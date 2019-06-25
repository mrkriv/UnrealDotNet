// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionStimuliSourceComponent.h:15

namespace UnrealEngine
{
	public partial class UAIPerceptionStimuliSourceComponent : UActorComponent
	{
		public UAIPerceptionStimuliSourceComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UAIPerceptionStimuliSourceComponent(UObject Parent = null, string Name = "AIPerceptionStimuliSourceComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAIPerceptionStimuliSourceComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAIPerceptionStimuliSourceComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionStimuliSourceComponent_RegisterWithPerceptionSystem(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionStimuliSourceComponent_UnregisterFromPerceptionSystem(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Registers owning actor as source of stimuli for senses specified in RegisterAsSourceForSenses.
		/// <para>Note that you don't have to do it if bAutoRegisterAsSource == true </para>
		/// </summary>
		public void RegisterWithPerceptionSystem()
			=> E_UAIPerceptionStimuliSourceComponent_RegisterWithPerceptionSystem(this);
		
		
		/// <summary>
		/// Unregister owning actor from being a source of sense stimuli
		/// </summary>
		public void UnregisterFromPerceptionSystem()
			=> E_UAIPerceptionStimuliSourceComponent_UnregisterFromPerceptionSystem(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAIPerceptionStimuliSourceComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAIPerceptionStimuliSourceComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAIPerceptionStimuliSourceComponent>(PtrDesc);
		}}}
