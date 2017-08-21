using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class AHUD : AActor
	{
		public AHUD(IntPtr Adress)
			: base(Adress)
		{
			
		}

		#region DLLInmport
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ShowHUD(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ShowDebug(IntPtr Self, string DebugType);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ShowDebugToggleSubCategory(IntPtr Self, string Category);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_RemoveAllDebugStrings(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_RemoveDebugText(IntPtr Self, AActor SrcActor, bool bLeaveDurationText);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ReceiveDrawHUD(IntPtr Self, int SizeX, int SizeY);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ReceiveHitBoxClick(IntPtr Self, string BoxName);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_NotifyHitBoxClick(IntPtr Self, string BoxName);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ReceiveHitBoxRelease(IntPtr Self, string BoxName);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_NotifyHitBoxRelease(IntPtr Self, string BoxName);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ReceiveHitBoxBeginCursorOver(IntPtr Self, string BoxName);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_NotifyHitBoxBeginCursorOver(IntPtr Self, string BoxName);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ReceiveHitBoxEndCursorOver(IntPtr Self, string BoxName);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_NotifyHitBoxEndCursorOver(IntPtr Self, string BoxName);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_PostInitializeComponents(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_DrawSafeZoneOverlay(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_NotifyBindPostProcessEffects(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_RemovePostRenderedActor(IntPtr Self, AActor A);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_AddPostRenderedActor(IntPtr Self, AActor A);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool E_ShouldDisplayDebug(IntPtr Self, string DebugType);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_ShowDebugInfo(IntPtr Self, float YL, float YPos);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_PostRender(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_DrawHUD(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_OnLostFocusPause(IntPtr Self, bool bEnable);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_DrawDebugTextList(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern void E_HandleBugScreenShot(IntPtr Self);
		
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		private static extern bool E_AnyCurrentHitBoxHits(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public void ShowHUD()
		{
			E_ShowHUD(NativePointer);
			
		}

		public void ShowDebug(string DebugType)
		{
			E_ShowDebug(NativePointer, DebugType);
			
		}

		public void ShowDebugToggleSubCategory(string Category)
		{
			E_ShowDebugToggleSubCategory(NativePointer, Category);
			
		}

		public void RemoveAllDebugStrings()
		{
			E_RemoveAllDebugStrings(NativePointer);
			
		}

		public void RemoveDebugText(AActor SrcActor, bool bLeaveDurationText)
		{
			E_RemoveDebugText(NativePointer, SrcActor, bLeaveDurationText);
			
		}

		public void ReceiveDrawHUD(int SizeX, int SizeY)
		{
			E_ReceiveDrawHUD(NativePointer, SizeX, SizeY);
			
		}

		public void ReceiveHitBoxClick(string BoxName)
		{
			E_ReceiveHitBoxClick(NativePointer, BoxName);
			
		}

		public void NotifyHitBoxClick(string BoxName)
		{
			E_NotifyHitBoxClick(NativePointer, BoxName);
			
		}

		public void ReceiveHitBoxRelease(string BoxName)
		{
			E_ReceiveHitBoxRelease(NativePointer, BoxName);
			
		}

		public void NotifyHitBoxRelease(string BoxName)
		{
			E_NotifyHitBoxRelease(NativePointer, BoxName);
			
		}

		public void ReceiveHitBoxBeginCursorOver(string BoxName)
		{
			E_ReceiveHitBoxBeginCursorOver(NativePointer, BoxName);
			
		}

		public void NotifyHitBoxBeginCursorOver(string BoxName)
		{
			E_NotifyHitBoxBeginCursorOver(NativePointer, BoxName);
			
		}

		public void ReceiveHitBoxEndCursorOver(string BoxName)
		{
			E_ReceiveHitBoxEndCursorOver(NativePointer, BoxName);
			
		}

		public void NotifyHitBoxEndCursorOver(string BoxName)
		{
			E_NotifyHitBoxEndCursorOver(NativePointer, BoxName);
			
		}

		public void PostInitializeComponents()
		{
			E_PostInitializeComponents(NativePointer);
			
		}

		public void DrawSafeZoneOverlay()
		{
			E_DrawSafeZoneOverlay(NativePointer);
			
		}

		public void NotifyBindPostProcessEffects()
		{
			E_NotifyBindPostProcessEffects(NativePointer);
			
		}

		public void RemovePostRenderedActor(AActor A)
		{
			E_RemovePostRenderedActor(NativePointer, A);
			
		}

		public void AddPostRenderedActor(AActor A)
		{
			E_AddPostRenderedActor(NativePointer, A);
			
		}

		public bool ShouldDisplayDebug(string DebugType)
		{
			return E_ShouldDisplayDebug(NativePointer, DebugType);
			
		}

		public void ShowDebugInfo(float YL, float YPos)
		{
			E_ShowDebugInfo(NativePointer, YL, YPos);
			
		}

		public void PostRender()
		{
			E_PostRender(NativePointer);
			
		}

		public void DrawHUD()
		{
			E_DrawHUD(NativePointer);
			
		}

		public void OnLostFocusPause(bool bEnable)
		{
			E_OnLostFocusPause(NativePointer, bEnable);
			
		}

		public void DrawDebugTextList()
		{
			E_DrawDebugTextList(NativePointer);
			
		}

		public void HandleBugScreenShot()
		{
			E_HandleBugScreenShot(NativePointer);
			
		}

		public bool AnyCurrentHitBoxHits()
		{
			return E_AnyCurrentHitBoxHits(NativePointer);
			
		}

		#endregion
		
		public static explicit operator IntPtr(AHUD Self)
		{
			return Self.NativePointer;
			
		}

		public static implicit operator AHUD(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new AHUD(Adress);
			
		}

	}

}
