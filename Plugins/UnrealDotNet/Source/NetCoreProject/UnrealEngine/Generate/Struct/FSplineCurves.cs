using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSplineCurves : NativeStructWrapper
	{
		internal FSplineCurves(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSplineCurves() :
			base(E_CreateStruct_FSplineCurves(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplineCurves();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FSplineCurves_GetSplineLength(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns total length along this spline </para>
		/// </summary>
		public float GetSplineLength()
			=> E_FSplineCurves_GetSplineLength(this);
		
		#endregion
		
		public static implicit operator IntPtr(FSplineCurves Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSplineCurves(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSplineCurves(Adress, false);
		}}}
