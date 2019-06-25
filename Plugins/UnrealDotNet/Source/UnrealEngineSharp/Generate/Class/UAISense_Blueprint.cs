// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Blueprint.h:18

namespace UnrealEngine
{
	public partial class UAISense_Blueprint : UAISense
	{
		public UAISense_Blueprint(IntPtr adress)
			: base(adress)
		{
		}

		public UAISense_Blueprint(UObject Parent = null, string Name = "AISense_Blueprint")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISense_Blueprint(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISense_Blueprint(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Blueprint_K2_OnNewPawn(IntPtr self, IntPtr newPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Blueprint_OnListenerRegistered(IntPtr self, IntPtr actorListener, IntPtr perceptionComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Blueprint_OnListenerRemovedImpl(IntPtr self, IntPtr updatedListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Blueprint_OnListenerUnregistered(IntPtr self, IntPtr actorListener, IntPtr perceptionComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Blueprint_OnListenerUpdated(IntPtr self, IntPtr actorListener, IntPtr perceptionComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Blueprint_OnListenerUpdateImpl(IntPtr self, IntPtr updatedListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Blueprint_OnNewListenerImpl(IntPtr self, IntPtr newListener);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// called when sense's instance gets notified about new pawn that has just been spawned
		/// </summary>
		public void OnNewPawn(APawn newPawn)
			=> E_UAISense_Blueprint_K2_OnNewPawn(this, newPawn);
		
		public void OnListenerRegistered(AActor actorListener, UAIPerceptionComponent perceptionComponent)
			=> E_UAISense_Blueprint_OnListenerRegistered(this, actorListener, perceptionComponent);
		
		protected void OnListenerRemovedImpl(FPerceptionListener updatedListener)
			=> E_UAISense_Blueprint_OnListenerRemovedImpl(this, updatedListener);
		
		public void OnListenerUnregistered(AActor actorListener, UAIPerceptionComponent perceptionComponent)
			=> E_UAISense_Blueprint_OnListenerUnregistered(this, actorListener, perceptionComponent);
		
		public void OnListenerUpdated(AActor actorListener, UAIPerceptionComponent perceptionComponent)
			=> E_UAISense_Blueprint_OnListenerUpdated(this, actorListener, perceptionComponent);
		
		protected void OnListenerUpdateImpl(FPerceptionListener updatedListener)
			=> E_UAISense_Blueprint_OnListenerUpdateImpl(this, updatedListener);
		
		protected void OnNewListenerImpl(FPerceptionListener newListener)
			=> E_UAISense_Blueprint_OnNewListenerImpl(this, newListener);
		
		#endregion
		
		public static implicit operator IntPtr(UAISense_Blueprint self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISense_Blueprint(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISense_Blueprint>(PtrDesc);
		}}}
