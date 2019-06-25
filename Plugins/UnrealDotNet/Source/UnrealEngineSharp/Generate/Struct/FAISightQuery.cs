// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Sight.h:70

namespace UnrealEngine
{
	public partial class FAISightQuery : NativeStructWrapper
	{
		public FAISightQuery(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAISightQuery_Age_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAISightQuery_Age_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAISightQuery_Importance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAISightQuery_Importance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAISightQuery_LastSeenLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAISightQuery_LastSeenLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAISightQuery_Score_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAISightQuery_Score_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAISightQuery_ForgetPreviousResult(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAISightQuery_RecalcScore(IntPtr self);
		
		#endregion
		
		#region Property
		public float Age
		{
			get => E_PROP_FAISightQuery_Age_GET(NativePointer);
			set => E_PROP_FAISightQuery_Age_SET(NativePointer, value);
		}

		public float Importance
		{
			get => E_PROP_FAISightQuery_Importance_GET(NativePointer);
			set => E_PROP_FAISightQuery_Importance_SET(NativePointer, value);
		}

		public FVector LastSeenLocation
		{
			get => E_PROP_FAISightQuery_LastSeenLocation_GET(NativePointer);
			set => E_PROP_FAISightQuery_LastSeenLocation_SET(NativePointer, value);
		}

		public float Score
		{
			get => E_PROP_FAISightQuery_Score_GET(NativePointer);
			set => E_PROP_FAISightQuery_Score_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ForgetPreviousResult()
			=> E_FAISightQuery_ForgetPreviousResult(this);
		
		public void RecalcScore()
			=> E_FAISightQuery_RecalcScore(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAISightQuery self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAISightQuery(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAISightQuery(adress, false);
		}}}
