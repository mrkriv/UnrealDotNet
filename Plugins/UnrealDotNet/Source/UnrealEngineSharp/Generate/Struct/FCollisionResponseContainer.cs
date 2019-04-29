// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:852

namespace UnrealEngine
{
	public  partial class FCollisionResponseContainer : NativeStructWrapper
	{
		internal FCollisionResponseContainer(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// This constructor will set all channels to ECR_Block
		/// </summary>
		public FCollisionResponseContainer() :
			base(E_CreateStruct_FCollisionResponseContainer(), false)
		{
		}

		public FCollisionResponseContainer(ECollisionResponse defaultResponse) :
			base(E_CreateStruct_FCollisionResponseContainer_ECollisionResponse((byte)defaultResponse), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionResponseContainer();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionResponseContainer_ECollisionResponse(byte defaultResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FCollisionResponseContainer_CreateMinContainer(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FCollisionResponseContainer_GetDefaultResponseContainer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FCollisionResponseContainer_GetResponse(IntPtr self, byte channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionResponseContainer_ReplaceChannels(IntPtr self, byte oldResponse, byte newResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionResponseContainer_SetAllChannels(IntPtr self, byte newResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionResponseContainer_SetResponse(IntPtr self, byte channel, byte newResponse);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Take two response containers and create a new container where each element is the 'min' of the two inputs (ie Ignore and Block results in Ignore)
		/// </summary>
		public FCollisionResponseContainer CreateMinContainer(FCollisionResponseContainer a, FCollisionResponseContainer b)
			=> E_FCollisionResponseContainer_CreateMinContainer(this, a, b);
		
		
		/// <summary>
		/// Returns the game-wide default collision response
		/// </summary>
		public FCollisionResponseContainer GetDefaultResponseContainer()
			=> E_FCollisionResponseContainer_GetDefaultResponseContainer(this);
		
		
		/// <summary>
		/// Returns the response set on the specified channel
		/// </summary>
		public ECollisionResponse GetResponse(ECollisionChannel channel)
			=> (ECollisionResponse)E_FCollisionResponseContainer_GetResponse(this, (byte)channel);
		
		
		/// <summary>
		/// Replace the channels matching the old response with the new response
		/// </summary>
		public void ReplaceChannels(ECollisionResponse oldResponse, ECollisionResponse newResponse)
			=> E_FCollisionResponseContainer_ReplaceChannels(this, (byte)oldResponse, (byte)newResponse);
		
		
		/// <summary>
		/// Set all channels to the specified response
		/// </summary>
		public void SetAllChannels(ECollisionResponse newResponse)
			=> E_FCollisionResponseContainer_SetAllChannels(this, (byte)newResponse);
		
		
		/// <summary>
		/// Set the response of a particular channel in the structure.
		/// </summary>
		public void SetResponse(ECollisionChannel channel, ECollisionResponse newResponse)
			=> E_FCollisionResponseContainer_SetResponse(this, (byte)channel, (byte)newResponse);
		
		#endregion
		
		public static implicit operator IntPtr(FCollisionResponseContainer self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCollisionResponseContainer(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCollisionResponseContainer(Adress, false);
		}}}
