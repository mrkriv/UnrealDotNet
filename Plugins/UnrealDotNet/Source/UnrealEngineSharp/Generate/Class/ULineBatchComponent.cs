// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

namespace UnrealEngine
{
	public  partial class ULineBatchComponent : UPrimitiveComponent
	{
		public ULineBatchComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULineBatchComponent(UObject Parent = null, string Name = "LineBatchComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULineBatchComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ULineBatchComponent_DefaultLifeTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ULineBatchComponent_DefaultLifeTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULineBatchComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULineBatchComponent_DrawLine(IntPtr self, IntPtr start, IntPtr end, IntPtr color, byte depthPriority, float thickness, float lifeTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULineBatchComponent_DrawPoint(IntPtr self, IntPtr position, IntPtr color, float pointSize, byte depthPriority, float lifeTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ULineBatchComponent_Flush(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Default time that lines/points will draw for </para>
		/// </summary>
		public float DefaultLifeTime
		{
			get => E_PROP_ULineBatchComponent_DefaultLifeTime_GET(NativePointer);
			set => E_PROP_ULineBatchComponent_DefaultLifeTime_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public virtual void DrawLine(FVector start, FVector end, FLinearColor color, byte depthPriority, float thickness, float lifeTime)
			=> E_ULineBatchComponent_DrawLine(this, start, end, color, depthPriority, thickness, lifeTime);
		
		public virtual void DrawPoint(FVector position, FLinearColor color, float pointSize, byte depthPriority, float lifeTime)
			=> E_ULineBatchComponent_DrawPoint(this, position, color, pointSize, depthPriority, lifeTime);
		
		
		/// <summary>
		/// <para>Clear all batched lines, points and meshes </para>
		/// </summary>
		public void Flush()
			=> E_ULineBatchComponent_Flush(this);
		
		#endregion
		
		public static implicit operator IntPtr(ULineBatchComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ULineBatchComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULineBatchComponent>(PtrDesc);
		}}}
