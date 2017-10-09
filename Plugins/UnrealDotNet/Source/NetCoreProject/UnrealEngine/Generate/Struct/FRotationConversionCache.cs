using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRotationConversionCache : NativeStructWrapper
	{
		internal FRotationConversionCache(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRotationConversionCache() :
			base(E_CreateStruct_FRotationConversionCache(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotationConversionCache();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_GetCachedQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationConversionCache_GetCachedRotator(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Return the cached Quat. </para>
		/// </summary>
		public FQuat GetCachedQuat()
			=> E_FRotationConversionCache_GetCachedQuat(this);
		
		
		/// <summary>
		/// <para>Return the cached Rotator. </para>
		/// </summary>
		public FRotator GetCachedRotator()
			=> E_FRotationConversionCache_GetCachedRotator(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRotationConversionCache Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRotationConversionCache(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRotationConversionCache(Adress, false);
		}}}
