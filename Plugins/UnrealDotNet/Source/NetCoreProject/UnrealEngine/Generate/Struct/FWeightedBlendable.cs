using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FWeightedBlendable
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FWeightedBlendable()
		{
			NativePointer = E_CreateStruct_FWeightedBlendable();
			IsRef = false;
		}

		internal FWeightedBlendable(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendable();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FWeightedBlendable_Weight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWeightedBlendable_Weight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern UObject E_PROP_FWeightedBlendable_Object_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWeightedBlendable_Object_SET(IntPtr Ptr, UObject Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// 0:no effect .. 1:full effect
		/// </summary>
		public float Weight
		{
			get => E_PROP_FWeightedBlendable_Weight_GET(NativePointer);
			set => E_PROP_FWeightedBlendable_Weight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// should be of the IBlendableInterface* type but UProperties cannot express that
		/// </summary>
		public UObject Object
		{
			get => E_PROP_FWeightedBlendable_Object_GET(NativePointer);
			set => E_PROP_FWeightedBlendable_Object_SET(NativePointer, value);
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
