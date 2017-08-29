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
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FDropNoteInfo();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_PROP_FDropNoteInfo_Location_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FDropNoteInfo_Location_SET(IntPtr Ptr, FVector Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_PROP_FDropNoteInfo_Rotation_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FDropNoteInfo_Rotation_SET(IntPtr Ptr, FRotator Value);
		
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

		#endregion
		
		#region ExternMethods
		#endregion
		
		public static implicit operator IntPtr(FDropNoteInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDropNoteInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDropNoteInfo(Adress, false);
		}}}
