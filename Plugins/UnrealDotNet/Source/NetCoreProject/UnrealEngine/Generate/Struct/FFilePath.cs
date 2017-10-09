using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3514

namespace UnrealEngine
{
	public  partial class FFilePath : NativeStructWrapper
	{
		internal FFilePath(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFilePath() :
			base(E_CreateStruct_FFilePath(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFilePath();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FFilePath_FilePath_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilePath_FilePath_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The path to the file. </para>
		/// </summary>
		public string FilePath
		{
			get => E_PROP_FFilePath_FilePath_GET(NativePointer);
			set => E_PROP_FFilePath_FilePath_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FFilePath Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFilePath(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFilePath(Adress, false);
		}}}
