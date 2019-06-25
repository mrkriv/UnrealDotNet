// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:469

namespace UnrealEngine
{
	public partial class FEnvQueryItem : NativeStructWrapper
	{
		public FEnvQueryItem(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryItem() :
			base(E_CreateStruct_FEnvQueryItem(), false)
		{
		}

		public FEnvQueryItem(int inOffset) :
			base(E_CreateStruct_FEnvQueryItem_int32(inOffset), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryItem_DataOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryItem_DataOffset_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvQueryItem_Score_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryItem_Score_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryItem();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryItem_int32(int inOffset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryItem_Discard(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FEnvQueryItem_IsValid(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// raw data offset
		/// </summary>
		public int DataOffset
		{
			get => E_PROP_FEnvQueryItem_DataOffset_GET(NativePointer);
			set => E_PROP_FEnvQueryItem_DataOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// total score of item
		/// </summary>
		public float Score
		{
			get => E_PROP_FEnvQueryItem_Score_GET(NativePointer);
			set => E_PROP_FEnvQueryItem_Score_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Discard()
			=> E_FEnvQueryItem_Discard(this);
		
		public bool IsValid()
			=> E_FEnvQueryItem_IsValid(this);
		
		#endregion
		
		public static implicit operator IntPtr(FEnvQueryItem self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryItem(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryItem(adress, false);
		}}}
