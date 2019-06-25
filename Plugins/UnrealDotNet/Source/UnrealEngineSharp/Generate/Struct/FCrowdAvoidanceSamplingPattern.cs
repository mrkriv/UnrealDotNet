// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\CrowdManager.h:113

namespace UnrealEngine
{
	public partial class FCrowdAvoidanceSamplingPattern : NativeStructWrapper
	{
		public FCrowdAvoidanceSamplingPattern(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FCrowdAvoidanceSamplingPattern() :
			base(E_CreateStruct_FCrowdAvoidanceSamplingPattern(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCrowdAvoidanceSamplingPattern();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCrowdAvoidanceSamplingPattern_AddSample(IntPtr self, float angleInDegrees, float normalizedRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCrowdAvoidanceSamplingPattern_AddSampleWithMirror(IntPtr self, float angleInDegrees, float normalizedRadius);
		
		#endregion
		
		#region ExternMethods
		public void AddSample(float angleInDegrees, float normalizedRadius)
			=> E_FCrowdAvoidanceSamplingPattern_AddSample(this, angleInDegrees, normalizedRadius);
		
		public void AddSampleWithMirror(float angleInDegrees, float normalizedRadius)
			=> E_FCrowdAvoidanceSamplingPattern_AddSampleWithMirror(this, angleInDegrees, normalizedRadius);
		
		#endregion
		
		public static implicit operator IntPtr(FCrowdAvoidanceSamplingPattern self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCrowdAvoidanceSamplingPattern(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCrowdAvoidanceSamplingPattern(adress, false);
		}}}
