using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FWeightedBlendable : NativeStructWrapper
	{
		public FWeightedBlendable() : base(E_CreateStruct_FWeightedBlendable(), false)
		{
		}

		internal FWeightedBlendable(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendable();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern UObject E_PROP_FWeightedBlendable_Object_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWeightedBlendable_Object_SET(IntPtr Ptr, UObject Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FWeightedBlendable_Weight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWeightedBlendable_Weight_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>should be of the IBlendableInterface* type but UProperties cannot express that </para>
		/// </summary>
		public UObject Object
		{
			get => E_PROP_FWeightedBlendable_Object_GET(NativePointer);
			set => E_PROP_FWeightedBlendable_Object_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>0:no effect .. 1:full effect </para>
		/// </summary>
		public float Weight
		{
			get => E_PROP_FWeightedBlendable_Weight_GET(NativePointer);
			set => E_PROP_FWeightedBlendable_Weight_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FWeightedBlendable Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWeightedBlendable(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWeightedBlendable(Adress, false);
		}}}
