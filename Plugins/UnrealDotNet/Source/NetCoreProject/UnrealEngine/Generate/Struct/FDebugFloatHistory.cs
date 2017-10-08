using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FDebugFloatHistory : NativeStructWrapper
	{
		internal FDebugFloatHistory(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDebugFloatHistory() :
			base(E_CreateStruct_FDebugFloatHistory(), false)
		{
		}

		public FDebugFloatHistory(float InMaxSamples, float InMinValue, float InMaxValue, bool InbAutoAdjustMinMax) :
			base(E_CreateStruct_FDebugFloatHistory_float_float_float_bool(InMaxSamples, InMinValue, InMaxValue, InbAutoAdjustMinMax), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugFloatHistory();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugFloatHistory_float_float_float_bool(float InMaxSamples, float InMinValue, float InMaxValue, bool InbAutoAdjustMinMax);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FDebugFloatHistory_AddSample(IntPtr Self, float FloatValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FDebugFloatHistory_GetMaxValue(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FDebugFloatHistory_GetMinMaxRange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FDebugFloatHistory_GetMinValue(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FDebugFloatHistory_GetNumSamples(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Record a new Sample. </para>
		/// <para>if bAutoAdjustMinMax is true, this new value will potentially adjust those bounds. </para>
		/// <para>Otherwise value will be clamped before being recorded. </para>
		/// <para>If MaxSamples is exceeded, old values will be deleted. </para>
		/// <param name="FloatValue">new sample to record. </param>
		/// </summary>
		public void AddSample(float FloatValue)
			=> E_FDebugFloatHistory_AddSample(this, FloatValue);
		
		
		/// <summary>
		/// <para>Max value. This could be either the max value recorded or max value allowed depending on 'bAutoAdjustMinMax'. </para>
		/// </summary>
		public float GetMaxValue()
			=> E_FDebugFloatHistory_GetMaxValue(this);
		
		
		/// <summary>
		/// <para>Range between Min and Max values </para>
		/// </summary>
		public float GetMinMaxRange()
			=> E_FDebugFloatHistory_GetMinMaxRange(this);
		
		
		/// <summary>
		/// <para>Min value. This could either be the min value recorded or min value allowed depending on 'bAutoAdjustMinMax'. </para>
		/// </summary>
		public float GetMinValue()
			=> E_FDebugFloatHistory_GetMinValue(this);
		
		
		/// <summary>
		/// <para>Number of Samples currently recorded </para>
		/// </summary>
		public int GetNumSamples()
			=> E_FDebugFloatHistory_GetNumSamples(this);
		
		#endregion
		
		public static implicit operator IntPtr(FDebugFloatHistory Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDebugFloatHistory(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDebugFloatHistory(Adress, false);
		}}}
