using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Info about one note dropped in the map during PIE.
	/// </summary>
	public partial class FDropNoteInfo
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FDropNoteInfo()
		{
			NativePointer = E_CreateStruct_FDropNoteInfo();
			IsRef = false;
		}

		internal FDropNoteInfo(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FDropNoteInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FDropNoteInfo_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDropNoteInfo_Location_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FRotator E_PROP_FDropNoteInfo_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDropNoteInfo_Rotation_SET(IntPtr Ptr, FRotator Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FDropNoteInfo_Comment_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDropNoteInfo_Comment_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
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

		public string Comment
		{
			get => E_PROP_FDropNoteInfo_Comment_GET(NativePointer);
			set => E_PROP_FDropNoteInfo_Comment_SET(NativePointer, value);
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
