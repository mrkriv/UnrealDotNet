using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SceneCaptureComponent.h:59

namespace UnrealEngine
{
	public  partial class USceneCaptureComponent : USceneComponent
	{
		public USceneCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USceneCaptureComponent(UObject Parent = null, string Name = "SceneCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneCaptureComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ClearHiddenComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_SetCaptureSortPriority(IntPtr Self, int NewCaptureSortPriority);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_UpdateShowFlags(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clears the hidden list. </para>
		/// </summary>
		public void ClearHiddenComponents()
			=> E_USceneCaptureComponent_ClearHiddenComponents(this);
		
		
		/// <summary>
		/// <para>Changes the value of TranslucentSortPriority. </para>
		/// </summary>
		public void SetCaptureSortPriority(int NewCaptureSortPriority)
			=> E_USceneCaptureComponent_SetCaptureSortPriority(this, NewCaptureSortPriority);
		
		
		/// <summary>
		/// <para>Update the show flags from our show flags settings (ideally, you'd be able to set this more directly, but currently unable to make FEngineShowFlags a UStruct to use it as a UProperty...) </para>
		/// </summary>
		protected void UpdateShowFlags()
			=> E_USceneCaptureComponent_UpdateShowFlags(this);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneCaptureComponent>(PtrDesc);
		}}}
