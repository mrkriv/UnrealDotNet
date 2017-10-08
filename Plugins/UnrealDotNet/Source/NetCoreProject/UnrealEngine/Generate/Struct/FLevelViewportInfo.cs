using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageLevelViewportInfo
	/// <para>Static array of level packages that have been marked by PrepareStreamedOutLevelsForGC </para>
	/// </summary>
	public  partial class FLevelViewportInfo : NativeStructWrapper
	{
		internal FLevelViewportInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLevelViewportInfo() :
			base(E_CreateStruct_FLevelViewportInfo(), false)
		{
		}

		public FLevelViewportInfo(FVector InCamPosition, FRotator InCamRotation, float InCamOrthoZoom) :
			base(E_CreateStruct_FLevelViewportInfo_FVector_FRotator_float(InCamPosition, InCamRotation, InCamOrthoZoom), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelViewportInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelViewportInfo_FVector_FRotator_float(IntPtr InCamPosition, IntPtr InCamRotation, float InCamOrthoZoom);
		
		#endregion
		
		public static implicit operator IntPtr(FLevelViewportInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLevelViewportInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelViewportInfo(Adress, false);
		}}}
