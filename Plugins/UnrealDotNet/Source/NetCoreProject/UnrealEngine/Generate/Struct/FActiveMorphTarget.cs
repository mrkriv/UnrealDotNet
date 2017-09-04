using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FActiveMorphTarget : NativeStructWrapper
	{
		public FActiveMorphTarget() : base(E_CreateStruct_FActiveMorphTarget(), false)
		{
		}

		internal FActiveMorphTarget(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FActiveMorphTarget();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FActiveMorphTarget_WeightIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActiveMorphTarget_WeightIndex_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Index into the array of weights for the Morph target, between 0.0 and 1.0. </para>
		/// </summary>
		public int WeightIndex
		{
			get => E_PROP_FActiveMorphTarget_WeightIndex_GET(NativePointer);
			set => E_PROP_FActiveMorphTarget_WeightIndex_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FActiveMorphTarget Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActiveMorphTarget(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActiveMorphTarget(Adress, false);
		}}}
