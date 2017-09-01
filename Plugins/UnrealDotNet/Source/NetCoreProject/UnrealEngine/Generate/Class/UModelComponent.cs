using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// ModelComponents are PrimitiveComponents that represent elements of BSP geometry in a ULevel object.
	/// They are used exclusively by ULevel and are not intended as general-purpose components.
	/// @see ULevel
	/// </summary>
	public partial class UModelComponent : UPrimitiveComponent
	{
		public UModelComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UModelComponent_CopyElementsFrom(IntPtr Self, IntPtr OtherModelComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UModelComponent_ApplyTempElements(IntPtr Self, bool bLightingWasSuccessful);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Copy model elements from the other component. This is used when duplicating components for PIE to guarantee correct rendering.
		/// </summary>
		public void CopyElementsFrom(UModelComponent OtherModelComponent)
			=> E_UModelComponent_CopyElementsFrom(NativePointer, OtherModelComponent);
		
		
		/// <summary>
		/// Apply all the elements that we were putting into the TempBSPElements map to
		/// the Elements arrays in all components
		/// @param bLightingWasSuccessful If true, the lighting should be applied, otherwise, the temp lighting should be cleaned up
		/// </summary>
		public void ApplyTempElements(bool bLightingWasSuccessful)
			=> E_UModelComponent_ApplyTempElements(NativePointer, bLightingWasSuccessful);
		
		#endregion
		
		public static implicit operator IntPtr(UModelComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UModelComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UModelComponent(Adress);
		}}}
