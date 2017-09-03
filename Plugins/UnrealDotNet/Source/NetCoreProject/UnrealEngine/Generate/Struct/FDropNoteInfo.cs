using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageDropNoteInfo
	/// <para>Info about one note dropped in the map during PIE. </para>
	/// </summary>
	public  partial class FDropNoteInfo : NativeStructWrapper
	{
		public FDropNoteInfo() : base(E_CreateStruct_FDropNoteInfo(), false)
		{
		}

		internal FDropNoteInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FDropNoteInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FDropNoteInfo_Comment_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDropNoteInfo_Comment_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FDropNoteInfo_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDropNoteInfo_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FDropNoteInfo_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDropNoteInfo_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public string Comment
		{
			get => E_PROP_FDropNoteInfo_Comment_GET(NativePointer);
			set => E_PROP_FDropNoteInfo_Comment_SET(NativePointer, value);
		}

		public FVector Location
		{
			get => E_PROP_FDropNoteInfo_Location_GET(NativePointer);
			set => E_PROP_FDropNoteInfo_Location_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FDropNoteInfo_Rotation_GET(NativePointer);
			set => E_PROP_FDropNoteInfo_Rotation_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDropNoteInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDropNoteInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDropNoteInfo(Adress, false);
		}}}
