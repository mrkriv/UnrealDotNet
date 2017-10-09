using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FCollisionResponseContainer : NativeStructWrapper
	{
		internal FCollisionResponseContainer(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>This constructor will set all channels to ECR_Block </para>
		/// </summary>
		public FCollisionResponseContainer() :
			base(E_CreateStruct_FCollisionResponseContainer(), false)
		{
		}

		public FCollisionResponseContainer(ECollisionResponse DefaultResponse) :
			base(E_CreateStruct_FCollisionResponseContainer_ECollisionResponse((byte)DefaultResponse), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionResponseContainer();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionResponseContainer_ECollisionResponse(byte DefaultResponse);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FCollisionResponseContainer_GetResponse(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionResponseContainer_ReplaceChannels(IntPtr Self, byte OldResponse, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionResponseContainer_SetAllChannels(IntPtr Self, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionResponseContainer_SetResponse(IntPtr Self, byte Channel, byte NewResponse);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns the response set on the specified channel </para>
		/// </summary>
		public ECollisionResponse GetResponse(ECollisionChannel Channel)
			=> (ECollisionResponse)E_FCollisionResponseContainer_GetResponse(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Replace the channels matching the old response with the new response </para>
		/// </summary>
		public void ReplaceChannels(ECollisionResponse OldResponse, ECollisionResponse NewResponse)
			=> E_FCollisionResponseContainer_ReplaceChannels(this, (byte)OldResponse, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Set all channels to the specified response </para>
		/// </summary>
		public void SetAllChannels(ECollisionResponse NewResponse)
			=> E_FCollisionResponseContainer_SetAllChannels(this, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Set the response of a particular channel in the structure. </para>
		/// </summary>
		public void SetResponse(ECollisionChannel Channel, ECollisionResponse NewResponse)
			=> E_FCollisionResponseContainer_SetResponse(this, (byte)Channel, (byte)NewResponse);
		
		#endregion
		
		public static implicit operator IntPtr(FCollisionResponseContainer Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FCollisionResponseContainer(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCollisionResponseContainer(Adress, false);
		}}}
