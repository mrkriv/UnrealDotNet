// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EQSTestingPawn.h:27

namespace UnrealEngine
{
	public partial class AEQSTestingPawn : ACharacter
	{
		public AEQSTestingPawn(IntPtr adress)
			: base(adress)
		{
		}

		public AEQSTestingPawn(UObject Parent = null, string Name = "EQSTestingPawn")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AEQSTestingPawn(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AEQSTestingPawn_HighlightMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AEQSTestingPawn_HighlightMode_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AEQSTestingPawn_StepToDebugDraw_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AEQSTestingPawn_StepToDebugDraw_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AEQSTestingPawn_TimeLimitPerStep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AEQSTestingPawn_TimeLimitPerStep_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AEQSTestingPawn(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AEQSTestingPawn_MakeOneStep(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AEQSTestingPawn_OnEditorSelectionChanged(IntPtr self, IntPtr newSelection);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AEQSTestingPawn_RunEQSQuery(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AEQSTestingPawn_UpdateDrawing(IntPtr self);
		
		#endregion
		
		#region Property
		public EEnvQueryHightlightMode HighlightMode
		{
			get => (EEnvQueryHightlightMode)E_PROP_AEQSTestingPawn_HighlightMode_GET(NativePointer);
			set => E_PROP_AEQSTestingPawn_HighlightMode_SET(NativePointer, (byte)value);
		}

		public int StepToDebugDraw
		{
			get => E_PROP_AEQSTestingPawn_StepToDebugDraw_GET(NativePointer);
			set => E_PROP_AEQSTestingPawn_StepToDebugDraw_SET(NativePointer, value);
		}

		public float TimeLimitPerStep
		{
			get => E_PROP_AEQSTestingPawn_TimeLimitPerStep_GET(NativePointer);
			set => E_PROP_AEQSTestingPawn_TimeLimitPerStep_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		protected void MakeOneStep()
			=> E_AEQSTestingPawn_MakeOneStep(this);
		
		protected void OnEditorSelectionChanged(UObject newSelection)
			=> E_AEQSTestingPawn_OnEditorSelectionChanged(this, newSelection);
		
		public void RunEQSQuery()
			=> E_AEQSTestingPawn_RunEQSQuery(this);
		
		protected void UpdateDrawing()
			=> E_AEQSTestingPawn_UpdateDrawing(this);
		
		#endregion
		
		public static implicit operator IntPtr(AEQSTestingPawn self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AEQSTestingPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AEQSTestingPawn>(PtrDesc);
		}}}
