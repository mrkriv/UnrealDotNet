#pragma once

#include "CoreMinimal.h"
#include "Engine.h"
#include "Engine.h"
#include "Engine.h"
#include "Engine/World.h"
#include "Engine/World.h"
#include "Engine.h"
#include "Engine.h"
#include "Engine.h"
#include "Math/Quat.h"
#include "Math/Rotator.h"
#include "Engine.h"
#include "Engine.h"
#include "Engine.h"
#include "Math/TransformVectorized.h"
#include "Math/Vector.h"
#include "Math/Vector2D.h"
#include "Math/Vector4.h"
#include "Engine/World.h"
#include "Engine.h"
#include "Math/Box.h"
#include "Math/Box2D.h"
#include "Engine.h"
#include "Engine/World.h"
#include "Engine.h"
#include "Engine.h"


extern "C"
{
	typedef struct
	{
		bool InstanceOnly;
	}
E_ST_FClassRedirect, *E_ST_FClassRedirect_REF;
}

FORCEINLINE E_ST_FClassRedirect CONV_ST_FClassRedirect_IN(FClassRedirect In)
{
	E_ST_FClassRedirect var;
	var.InstanceOnly = In.InstanceOnly;
	
	return var;
}

FORCEINLINE FClassRedirect CONV_ST_FClassRedirect_TO(E_ST_FClassRedirect In)
{
	FClassRedirect var;
	var.InstanceOnly = In.InstanceOnly;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FFullyLoadedPackagesInfo, *E_ST_FFullyLoadedPackagesInfo_REF;
}

FORCEINLINE E_ST_FFullyLoadedPackagesInfo CONV_ST_FFullyLoadedPackagesInfo_IN(FFullyLoadedPackagesInfo In)
{
	E_ST_FFullyLoadedPackagesInfo var;
	
	return var;
}

FORCEINLINE FFullyLoadedPackagesInfo CONV_ST_FFullyLoadedPackagesInfo_TO(E_ST_FFullyLoadedPackagesInfo In)
{
	FFullyLoadedPackagesInfo var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FGameNameRedirect, *E_ST_FGameNameRedirect_REF;
}

FORCEINLINE E_ST_FGameNameRedirect CONV_ST_FGameNameRedirect_IN(FGameNameRedirect In)
{
	E_ST_FGameNameRedirect var;
	
	return var;
}

FORCEINLINE FGameNameRedirect CONV_ST_FGameNameRedirect_TO(E_ST_FGameNameRedirect In)
{
	FGameNameRedirect var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FLevelCollection, *E_ST_FLevelCollection_REF;
}

FORCEINLINE E_ST_FLevelCollection CONV_ST_FLevelCollection_IN(FLevelCollection In)
{
	E_ST_FLevelCollection var;
	
	return var;
}

FORCEINLINE FLevelCollection CONV_ST_FLevelCollection_TO(E_ST_FLevelCollection In)
{
	FLevelCollection var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FLevelStreamingGCHelper, *E_ST_FLevelStreamingGCHelper_REF;
}

FORCEINLINE E_ST_FLevelStreamingGCHelper CONV_ST_FLevelStreamingGCHelper_IN(FLevelStreamingGCHelper In)
{
	E_ST_FLevelStreamingGCHelper var;
	
	return var;
}

FORCEINLINE FLevelStreamingGCHelper CONV_ST_FLevelStreamingGCHelper_TO(E_ST_FLevelStreamingGCHelper In)
{
	FLevelStreamingGCHelper var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FLevelStreamingStatus, *E_ST_FLevelStreamingStatus_REF;
}

FORCEINLINE E_ST_FLevelStreamingStatus CONV_ST_FLevelStreamingStatus_IN(FLevelStreamingStatus In)
{
	E_ST_FLevelStreamingStatus var;
	
	return var;
}

FORCEINLINE FLevelStreamingStatus CONV_ST_FLevelStreamingStatus_TO(E_ST_FLevelStreamingStatus In)
{
	FLevelStreamingStatus var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FNetDriverDefinition, *E_ST_FNetDriverDefinition_REF;
}

FORCEINLINE E_ST_FNetDriverDefinition CONV_ST_FNetDriverDefinition_IN(FNetDriverDefinition In)
{
	E_ST_FNetDriverDefinition var;
	
	return var;
}

FORCEINLINE FNetDriverDefinition CONV_ST_FNetDriverDefinition_TO(E_ST_FNetDriverDefinition In)
{
	FNetDriverDefinition var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FPluginRedirect, *E_ST_FPluginRedirect_REF;
}

FORCEINLINE E_ST_FPluginRedirect CONV_ST_FPluginRedirect_IN(FPluginRedirect In)
{
	E_ST_FPluginRedirect var;
	
	return var;
}

FORCEINLINE FPluginRedirect CONV_ST_FPluginRedirect_TO(E_ST_FPluginRedirect In)
{
	FPluginRedirect var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float X;
		float Y;
		float Z;
		float W;
	}
E_ST_FQuat, *E_ST_FQuat_REF;
}

FORCEINLINE E_ST_FQuat CONV_ST_FQuat_IN(FQuat In)
{
	E_ST_FQuat var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	var.W = In.W;
	
	return var;
}

FORCEINLINE FQuat CONV_ST_FQuat_TO(E_ST_FQuat In)
{
	FQuat var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	var.W = In.W;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float Pitch;
		float Yaw;
		float Roll;
	}
E_ST_FRotator, *E_ST_FRotator_REF;
}

FORCEINLINE E_ST_FRotator CONV_ST_FRotator_IN(FRotator In)
{
	E_ST_FRotator var;
	var.Pitch = In.Pitch;
	var.Yaw = In.Yaw;
	var.Roll = In.Roll;
	
	return var;
}

FORCEINLINE FRotator CONV_ST_FRotator_TO(E_ST_FRotator In)
{
	FRotator var;
	var.Pitch = In.Pitch;
	var.Yaw = In.Yaw;
	var.Roll = In.Roll;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float In;
	}
E_ST_FStatColorMapEntry, *E_ST_FStatColorMapEntry_REF;
}

FORCEINLINE E_ST_FStatColorMapEntry CONV_ST_FStatColorMapEntry_IN(FStatColorMapEntry In)
{
	E_ST_FStatColorMapEntry var;
	var.In = In.In;
	
	return var;
}

FORCEINLINE FStatColorMapEntry CONV_ST_FStatColorMapEntry_TO(E_ST_FStatColorMapEntry In)
{
	FStatColorMapEntry var;
	var.In = In.In;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FStatColorMapping, *E_ST_FStatColorMapping_REF;
}

FORCEINLINE E_ST_FStatColorMapping CONV_ST_FStatColorMapping_IN(FStatColorMapping In)
{
	E_ST_FStatColorMapping var;
	
	return var;
}

FORCEINLINE FStatColorMapping CONV_ST_FStatColorMapping_TO(E_ST_FStatColorMapping In)
{
	FStatColorMapping var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FStructRedirect, *E_ST_FStructRedirect_REF;
}

FORCEINLINE E_ST_FStructRedirect CONV_ST_FStructRedirect_IN(FStructRedirect In)
{
	E_ST_FStructRedirect var;
	
	return var;
}

FORCEINLINE FStructRedirect CONV_ST_FStructRedirect_TO(E_ST_FStructRedirect In)
{
	FStructRedirect var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FTransform, *E_ST_FTransform_REF;
}

FORCEINLINE E_ST_FTransform CONV_ST_FTransform_IN(FTransform In)
{
	E_ST_FTransform var;
	
	return var;
}

FORCEINLINE FTransform CONV_ST_FTransform_TO(E_ST_FTransform In)
{
	FTransform var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float X;
		float Y;
		float Z;
	}
E_ST_FVector, *E_ST_FVector_REF;
}

FORCEINLINE E_ST_FVector CONV_ST_FVector_IN(FVector In)
{
	E_ST_FVector var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	
	return var;
}

FORCEINLINE FVector CONV_ST_FVector_TO(E_ST_FVector In)
{
	FVector var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float X;
		float Y;
	}
E_ST_FVector2D, *E_ST_FVector2D_REF;
}

FORCEINLINE E_ST_FVector2D CONV_ST_FVector2D_IN(FVector2D In)
{
	E_ST_FVector2D var;
	var.X = In.X;
	var.Y = In.Y;
	
	return var;
}

FORCEINLINE FVector2D CONV_ST_FVector2D_TO(E_ST_FVector2D In)
{
	FVector2D var;
	var.X = In.X;
	var.Y = In.Y;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float X;
		float Y;
		float Z;
		float W;
	}
E_ST_FVector4, *E_ST_FVector4_REF;
}

FORCEINLINE E_ST_FVector4 CONV_ST_FVector4_IN(FVector4 In)
{
	E_ST_FVector4 var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	var.W = In.W;
	
	return var;
}

FORCEINLINE FVector4 CONV_ST_FVector4_TO(E_ST_FVector4 In)
{
	FVector4 var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	var.W = In.W;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		int32 CurrentFrame;
	}
E_ST_FWorldAsyncTraceState, *E_ST_FWorldAsyncTraceState_REF;
}

FORCEINLINE E_ST_FWorldAsyncTraceState CONV_ST_FWorldAsyncTraceState_IN(FWorldAsyncTraceState In)
{
	E_ST_FWorldAsyncTraceState var;
	var.CurrentFrame = In.CurrentFrame;
	
	return var;
}

FORCEINLINE FWorldAsyncTraceState CONV_ST_FWorldAsyncTraceState_TO(E_ST_FWorldAsyncTraceState In)
{
	FWorldAsyncTraceState var;
	var.CurrentFrame = In.CurrentFrame;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		uint8 TravelType;
		int32 PIEInstance;
		bool RunAsDedicated;
		bool bWaitingOnOnlineSubsystem;
	}
E_ST_FWorldContext, *E_ST_FWorldContext_REF;
}

FORCEINLINE E_ST_FWorldContext CONV_ST_FWorldContext_IN(FWorldContext In)
{
	E_ST_FWorldContext var;
	var.TravelType = In.TravelType;
	var.PIEInstance = In.PIEInstance;
	var.RunAsDedicated = In.RunAsDedicated;
	var.bWaitingOnOnlineSubsystem = In.bWaitingOnOnlineSubsystem;
	
	return var;
}

FORCEINLINE FWorldContext CONV_ST_FWorldContext_TO(E_ST_FWorldContext In)
{
	FWorldContext var;
	var.TravelType = In.TravelType;
	var.PIEInstance = In.PIEInstance;
	var.RunAsDedicated = In.RunAsDedicated;
	var.bWaitingOnOnlineSubsystem = In.bWaitingOnOnlineSubsystem;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		FVector Min;
		FVector Max;
		uint8 IsValid;
	}
E_ST_FBox, *E_ST_FBox_REF;
}

FORCEINLINE E_ST_FBox CONV_ST_FBox_IN(FBox In)
{
	E_ST_FBox var;
	var.Min = In.Min;
	var.Max = In.Max;
	var.IsValid = In.IsValid;
	
	return var;
}

FORCEINLINE FBox CONV_ST_FBox_TO(E_ST_FBox In)
{
	FBox var;
	var.Min = In.Min;
	var.Max = In.Max;
	var.IsValid = In.IsValid;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		FVector2D Min;
		FVector2D Max;
		bool bIsValid;
	}
E_ST_FBox2D, *E_ST_FBox2D_REF;
}

FORCEINLINE E_ST_FBox2D CONV_ST_FBox2D_IN(FBox2D In)
{
	E_ST_FBox2D var;
	var.Min = In.Min;
	var.Max = In.Max;
	var.bIsValid = In.bIsValid;
	
	return var;
}

FORCEINLINE FBox2D CONV_ST_FBox2D_TO(E_ST_FBox2D In)
{
	FBox2D var;
	var.Min = In.Min;
	var.Max = In.Max;
	var.bIsValid = In.bIsValid;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		FVector Location;
		FRotator Rotation;
	}
E_ST_FDropNoteInfo, *E_ST_FDropNoteInfo_REF;
}

FORCEINLINE E_ST_FDropNoteInfo CONV_ST_FDropNoteInfo_IN(FDropNoteInfo In)
{
	E_ST_FDropNoteInfo var;
	var.Location = In.Location;
	var.Rotation = In.Rotation;
	
	return var;
}

FORCEINLINE FDropNoteInfo CONV_ST_FDropNoteInfo_TO(E_ST_FDropNoteInfo In)
{
	FDropNoteInfo var;
	var.Location = In.Location;
	var.Rotation = In.Rotation;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		FVector CamPosition;
		FRotator CamRotation;
		float CamOrthoZoom;
		bool CamUpdated;
	}
E_ST_FLevelViewportInfo, *E_ST_FLevelViewportInfo_REF;
}

FORCEINLINE E_ST_FLevelViewportInfo CONV_ST_FLevelViewportInfo_IN(FLevelViewportInfo In)
{
	E_ST_FLevelViewportInfo var;
	var.CamPosition = In.CamPosition;
	var.CamRotation = In.CamRotation;
	var.CamOrthoZoom = In.CamOrthoZoom;
	var.CamUpdated = In.CamUpdated;
	
	return var;
}

FORCEINLINE FLevelViewportInfo CONV_ST_FLevelViewportInfo_TO(E_ST_FLevelViewportInfo In)
{
	FLevelViewportInfo var;
	var.CamPosition = In.CamPosition;
	var.CamRotation = In.CamRotation;
	var.CamOrthoZoom = In.CamOrthoZoom;
	var.CamUpdated = In.CamUpdated;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		FNetDriverDefinition NetDriverDef;
	}
E_ST_FNamedNetDriver, *E_ST_FNamedNetDriver_REF;
}

FORCEINLINE E_ST_FNamedNetDriver CONV_ST_FNamedNetDriver_IN(FNamedNetDriver In)
{
	E_ST_FNamedNetDriver var;
	var.NetDriverDef = In.NetDriverDef;
	
	return var;
}

FORCEINLINE FNamedNetDriver CONV_ST_FNamedNetDriver_TO(E_ST_FNamedNetDriver In)
{
	FNamedNetDriver var;
	var.NetDriverDef = In.NetDriverDef;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float TimeToDisplay;
		float CurrentTimeDisplayed;
		FVector2D TextScale;
	}
E_ST_FScreenMessageString, *E_ST_FScreenMessageString_REF;
}

FORCEINLINE E_ST_FScreenMessageString CONV_ST_FScreenMessageString_IN(FScreenMessageString In)
{
	E_ST_FScreenMessageString var;
	var.TimeToDisplay = In.TimeToDisplay;
	var.CurrentTimeDisplayed = In.CurrentTimeDisplayed;
	var.TextScale = In.TextScale;
	
	return var;
}

FORCEINLINE FScreenMessageString CONV_ST_FScreenMessageString_TO(E_ST_FScreenMessageString In)
{
	FScreenMessageString var;
	var.TimeToDisplay = In.TimeToDisplay;
	var.CurrentTimeDisplayed = In.CurrentTimeDisplayed;
	var.TextScale = In.TextScale;
	
	return var;
}


extern "C"
{
	
	/*	FClassRedirect	*/
	
	
	/*	FFullyLoadedPackagesInfo	*/
	
	
	/*	FGameNameRedirect	*/
	
	
	/*	FLevelCollection	*/
	
	DOTNET_EXPORT bool E_FLevelCollection_IsVisible(E_ST_FLevelCollection Self)
	{
		return CONV_ST_FLevelCollection_TO(Self).IsVisible();
	}

	DOTNET_EXPORT void E_FLevelCollection_SetIsVisible(E_ST_FLevelCollection Self, bool bInIsVisible)
	{
		auto _p0 = bInIsVisible;
		CONV_ST_FLevelCollection_TO(Self).SetIsVisible(_p0);
	}

	
	/*	FLevelStreamingGCHelper	*/
	
	DOTNET_EXPORT void E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(E_ST_FLevelStreamingGCHelper Self)
	{
		CONV_ST_FLevelStreamingGCHelper_TO(Self).AddGarbageCollectorCallback();
	}

	DOTNET_EXPORT int32 E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(E_ST_FLevelStreamingGCHelper Self)
	{
		return CONV_ST_FLevelStreamingGCHelper_TO(Self).GetNumLevelsPendingPurge();
	}

	
	/*	FLevelStreamingStatus	*/
	
	
	/*	FNetDriverDefinition	*/
	
	
	/*	FPluginRedirect	*/
	
	
	/*	FQuat	*/
	
	DOTNET_EXPORT E_ST_FQuat E_OP_FQuat_p(E_ST_FQuat Self, E_ST_FQuat Q)
	{
		auto _p0 = CONV_ST_FQuat_TO(Q);
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).operator+(_p0));
	}

	DOTNET_EXPORT bool E_FQuat_Equals(E_ST_FQuat Self, E_ST_FQuat Q, float Tolerance)
	{
		auto _p0 = CONV_ST_FQuat_TO(Q);
		auto _p1 = Tolerance;
		return CONV_ST_FQuat_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FQuat_IsIdentity(E_ST_FQuat Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FQuat_TO(Self).IsIdentity(_p0);
	}

	DOTNET_EXPORT float E_OP_FQuat_i(E_ST_FQuat Self, E_ST_FQuat Q)
	{
		auto _p0 = CONV_ST_FQuat_TO(Q);
		return CONV_ST_FQuat_TO(Self).operator|(_p0);
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_MakeFromEuler(E_ST_FQuat Self, E_ST_FVector Euler)
	{
		auto _p0 = CONV_ST_FVector_TO(Euler);
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).MakeFromEuler(_p0));
	}

	DOTNET_EXPORT E_ST_FVector E_FQuat_Euler(E_ST_FQuat Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FQuat_TO(Self).Euler());
	}

	DOTNET_EXPORT void E_FQuat_Normalize(E_ST_FQuat Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		CONV_ST_FQuat_TO(Self).Normalize(_p0);
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_GetNormalized(E_ST_FQuat Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).GetNormalized(_p0));
	}

	DOTNET_EXPORT bool E_FQuat_IsNormalized(E_ST_FQuat Self)
	{
		return CONV_ST_FQuat_TO(Self).IsNormalized();
	}

	DOTNET_EXPORT float E_FQuat_Size(E_ST_FQuat Self)
	{
		return CONV_ST_FQuat_TO(Self).Size();
	}

	DOTNET_EXPORT void E_FQuat_ToAxisAndAngle(E_ST_FQuat Self, E_ST_FVector Axis, float Angle)
	{
		auto _p0 = CONV_ST_FVector_TO(Axis);
		auto _p1 = Angle;
		CONV_ST_FQuat_TO(Self).ToAxisAndAngle(_p0, _p1);
	}

	DOTNET_EXPORT void E_FQuat_ToSwingTwist(E_ST_FQuat Self, E_ST_FVector InTwistAxis, E_ST_FQuat OutSwing, E_ST_FQuat OutTwist)
	{
		auto _p0 = CONV_ST_FVector_TO(InTwistAxis);
		auto _p1 = CONV_ST_FQuat_TO(OutSwing);
		auto _p2 = CONV_ST_FQuat_TO(OutTwist);
		CONV_ST_FQuat_TO(Self).ToSwingTwist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT E_ST_FVector E_FQuat_RotateVector(E_ST_FQuat Self, E_ST_FVector V)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		return CONV_ST_FVector_IN(CONV_ST_FQuat_TO(Self).RotateVector(_p0));
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_Log(E_ST_FQuat Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).Log());
	}

	DOTNET_EXPORT void E_FQuat_EnforceShortestArcWith(E_ST_FQuat Self, E_ST_FQuat OtherQuat)
	{
		auto _p0 = CONV_ST_FQuat_TO(OtherQuat);
		CONV_ST_FQuat_TO(Self).EnforceShortestArcWith(_p0);
	}

	DOTNET_EXPORT E_ST_FRotator E_FQuat_Rotator(E_ST_FQuat Self)
	{
		return CONV_ST_FRotator_IN(CONV_ST_FQuat_TO(Self).Rotator());
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_FindBetween(E_ST_FQuat Self, E_ST_FVector Vector1, E_ST_FVector Vector2)
	{
		auto _p0 = CONV_ST_FVector_TO(Vector1);
		auto _p1 = CONV_ST_FVector_TO(Vector2);
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).FindBetween(_p0, _p1));
	}

	DOTNET_EXPORT float E_FQuat_Error(E_ST_FQuat Self, E_ST_FQuat Q1, E_ST_FQuat Q2)
	{
		auto _p0 = CONV_ST_FQuat_TO(Q1);
		auto _p1 = CONV_ST_FQuat_TO(Q2);
		return CONV_ST_FQuat_TO(Self).Error(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_FastLerp(E_ST_FQuat Self, E_ST_FQuat A, E_ST_FQuat B, float Alpha)
	{
		auto _p0 = CONV_ST_FQuat_TO(A);
		auto _p1 = CONV_ST_FQuat_TO(B);
		auto _p2 = Alpha;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).FastLerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_FastBilerp(E_ST_FQuat Self, E_ST_FQuat P00, E_ST_FQuat P10, E_ST_FQuat P01, E_ST_FQuat P11, float FracX, float FracY)
	{
		auto _p0 = CONV_ST_FQuat_TO(P00);
		auto _p1 = CONV_ST_FQuat_TO(P10);
		auto _p2 = CONV_ST_FQuat_TO(P01);
		auto _p3 = CONV_ST_FQuat_TO(P11);
		auto _p4 = FracX;
		auto _p5 = FracY;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).FastBilerp(_p0, _p1, _p2, _p3, _p4, _p5));
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_Slerp_NotNormalized(E_ST_FQuat Self, E_ST_FQuat Quat1, E_ST_FQuat Quat2, float Slerp)
	{
		auto _p0 = CONV_ST_FQuat_TO(Quat1);
		auto _p1 = CONV_ST_FQuat_TO(Quat2);
		auto _p2 = Slerp;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).Slerp_NotNormalized(_p0, _p1, _p2));
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_Squad(E_ST_FQuat Self, E_ST_FQuat quat1, E_ST_FQuat tang1, E_ST_FQuat quat2, E_ST_FQuat tang2, float Alpha)
	{
		auto _p0 = CONV_ST_FQuat_TO(quat1);
		auto _p1 = CONV_ST_FQuat_TO(tang1);
		auto _p2 = CONV_ST_FQuat_TO(quat2);
		auto _p3 = CONV_ST_FQuat_TO(tang2);
		auto _p4 = Alpha;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).Squad(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT void E_FQuat_CalcTangents(E_ST_FQuat Self, E_ST_FQuat PrevP, E_ST_FQuat P, E_ST_FQuat NextP, float Tension, E_ST_FQuat OutTan)
	{
		auto _p0 = CONV_ST_FQuat_TO(PrevP);
		auto _p1 = CONV_ST_FQuat_TO(P);
		auto _p2 = CONV_ST_FQuat_TO(NextP);
		auto _p3 = Tension;
		auto _p4 = CONV_ST_FQuat_TO(OutTan);
		CONV_ST_FQuat_TO(Self).CalcTangents(_p0, _p1, _p2, _p3, _p4);
	}

	
	/*	FRotator	*/
	
	DOTNET_EXPORT E_ST_FRotator E_OP_FRotator_p(E_ST_FRotator Self, E_ST_FRotator R)
	{
		auto _p0 = CONV_ST_FRotator_TO(R);
		return CONV_ST_FRotator_IN(CONV_ST_FRotator_TO(Self).operator+(_p0));
	}

	DOTNET_EXPORT E_ST_FRotator E_OP_FRotator_m(E_ST_FRotator Self, float Scale)
	{
		auto _p0 = Scale;
		return CONV_ST_FRotator_IN(CONV_ST_FRotator_TO(Self).operator*(_p0));
	}

	DOTNET_EXPORT bool E_FRotator_IsNearlyZero(E_ST_FRotator Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FRotator_TO(Self).IsNearlyZero(_p0);
	}

	DOTNET_EXPORT bool E_FRotator_IsZero(E_ST_FRotator Self)
	{
		return CONV_ST_FRotator_TO(Self).IsZero();
	}

	DOTNET_EXPORT bool E_FRotator_Equals(E_ST_FRotator Self, E_ST_FRotator R, float Tolerance)
	{
		auto _p0 = CONV_ST_FRotator_TO(R);
		auto _p1 = Tolerance;
		return CONV_ST_FRotator_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FRotator E_FRotator_Add(E_ST_FRotator Self, float DeltaPitch, float DeltaYaw, float DeltaRoll)
	{
		auto _p0 = DeltaPitch;
		auto _p1 = DeltaYaw;
		auto _p2 = DeltaRoll;
		return CONV_ST_FRotator_IN(CONV_ST_FRotator_TO(Self).Add(_p0, _p1, _p2));
	}

	DOTNET_EXPORT E_ST_FVector E_FRotator_Vector(E_ST_FRotator Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FRotator_TO(Self).Vector());
	}

	DOTNET_EXPORT E_ST_FQuat E_FRotator_Quaternion(E_ST_FRotator Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FRotator_TO(Self).Quaternion());
	}

	DOTNET_EXPORT E_ST_FVector E_FRotator_RotateVector(E_ST_FRotator Self, E_ST_FVector V)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		return CONV_ST_FVector_IN(CONV_ST_FRotator_TO(Self).RotateVector(_p0));
	}

	DOTNET_EXPORT void E_FRotator_Normalize(E_ST_FRotator Self)
	{
		CONV_ST_FRotator_TO(Self).Normalize();
	}

	DOTNET_EXPORT void E_FRotator_GetWindingAndRemainder(E_ST_FRotator Self, E_ST_FRotator Winding, E_ST_FRotator Remainder)
	{
		auto _p0 = CONV_ST_FRotator_TO(Winding);
		auto _p1 = CONV_ST_FRotator_TO(Remainder);
		CONV_ST_FRotator_TO(Self).GetWindingAndRemainder(_p0, _p1);
	}

	DOTNET_EXPORT float E_FRotator_ClampAxis(E_ST_FRotator Self, float Angle)
	{
		auto _p0 = Angle;
		return CONV_ST_FRotator_TO(Self).ClampAxis(_p0);
	}

	DOTNET_EXPORT uint8 E_FRotator_CompressAxisToByte(E_ST_FRotator Self, float Angle)
	{
		auto _p0 = Angle;
		return CONV_ST_FRotator_TO(Self).CompressAxisToByte(_p0);
	}

	DOTNET_EXPORT E_ST_FRotator E_FRotator_MakeFromEuler(E_ST_FRotator Self, E_ST_FVector Euler)
	{
		auto _p0 = CONV_ST_FVector_TO(Euler);
		return CONV_ST_FRotator_IN(CONV_ST_FRotator_TO(Self).MakeFromEuler(_p0));
	}

	
	/*	FStatColorMapEntry	*/
	
	
	/*	FStatColorMapping	*/
	
	
	/*	FStructRedirect	*/
	
	
	/*	FTransform	*/
	
	DOTNET_EXPORT void E_FTransform_DiagnosticCheckNaN_Scale3D(E_ST_FTransform Self)
	{
		CONV_ST_FTransform_TO(Self).DiagnosticCheckNaN_Scale3D();
	}

	DOTNET_EXPORT E_ST_FTransform E_FTransform_Inverse(E_ST_FTransform Self)
	{
		return CONV_ST_FTransform_IN(CONV_ST_FTransform_TO(Self).Inverse());
	}

	DOTNET_EXPORT void E_FTransform_Blend(E_ST_FTransform Self, E_ST_FTransform Atom1, E_ST_FTransform Atom2, float Alpha)
	{
		auto _p0 = CONV_ST_FTransform_TO(Atom1);
		auto _p1 = CONV_ST_FTransform_TO(Atom2);
		auto _p2 = Alpha;
		CONV_ST_FTransform_TO(Self).Blend(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_FTransform_BlendWith(E_ST_FTransform Self, E_ST_FTransform OtherAtom, float Alpha)
	{
		auto _p0 = CONV_ST_FTransform_TO(OtherAtom);
		auto _p1 = Alpha;
		CONV_ST_FTransform_TO(Self).BlendWith(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FTransform E_OP_FTransform_p(E_ST_FTransform Self, E_ST_FTransform Atom)
	{
		auto _p0 = CONV_ST_FTransform_TO(Atom);
		return CONV_ST_FTransform_IN(CONV_ST_FTransform_TO(Self).operator+(_p0));
	}

	DOTNET_EXPORT bool E_FTransform_AnyHasNegativeScale(E_ST_FTransform Self, E_ST_FVector InScale3D, E_ST_FVector InOtherScale3D)
	{
		auto _p0 = CONV_ST_FVector_TO(InScale3D);
		auto _p1 = CONV_ST_FVector_TO(InOtherScale3D);
		return CONV_ST_FTransform_TO(Self).AnyHasNegativeScale(_p0, _p1);
	}

	DOTNET_EXPORT void E_FTransform_RemoveScaling(E_ST_FTransform Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		CONV_ST_FTransform_TO(Self).RemoveScaling(_p0);
	}

	DOTNET_EXPORT float E_FTransform_GetMaximumAxisScale(E_ST_FTransform Self)
	{
		return CONV_ST_FTransform_TO(Self).GetMaximumAxisScale();
	}

	DOTNET_EXPORT E_ST_FVector4 E_FTransform_TransformFVector4(E_ST_FTransform Self, E_ST_FVector4 V)
	{
		auto _p0 = CONV_ST_FVector4_TO(V);
		return CONV_ST_FVector4_IN(CONV_ST_FTransform_TO(Self).TransformFVector4(_p0));
	}

	DOTNET_EXPORT E_ST_FVector E_FTransform_TransformPosition(E_ST_FTransform Self, E_ST_FVector V)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		return CONV_ST_FVector_IN(CONV_ST_FTransform_TO(Self).TransformPosition(_p0));
	}

	DOTNET_EXPORT E_ST_FVector E_FTransform_GetSafeScaleReciprocal(E_ST_FTransform Self, E_ST_FVector InScale, float Tolerance)
	{
		auto _p0 = CONV_ST_FVector_TO(InScale);
		auto _p1 = Tolerance;
		return CONV_ST_FVector_IN(CONV_ST_FTransform_TO(Self).GetSafeScaleReciprocal(_p0, _p1));
	}

	DOTNET_EXPORT E_ST_FVector E_FTransform_GetLocation(E_ST_FTransform Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FTransform_TO(Self).GetLocation());
	}

	DOTNET_EXPORT E_ST_FRotator E_FTransform_Rotator(E_ST_FTransform Self)
	{
		return CONV_ST_FRotator_IN(CONV_ST_FTransform_TO(Self).Rotator());
	}

	DOTNET_EXPORT bool E_FTransform_ContainsNaN(E_ST_FTransform Self)
	{
		return CONV_ST_FTransform_TO(Self).ContainsNaN();
	}

	DOTNET_EXPORT bool E_FTransform_AreRotationsEqual(E_ST_FTransform Self, E_ST_FTransform A, E_ST_FTransform B, float Tolerance)
	{
		auto _p0 = CONV_ST_FTransform_TO(A);
		auto _p1 = CONV_ST_FTransform_TO(B);
		auto _p2 = Tolerance;
		return CONV_ST_FTransform_TO(Self).AreRotationsEqual(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FTransform_RotationEquals(E_ST_FTransform Self, E_ST_FTransform Other, float Tolerance)
	{
		auto _p0 = CONV_ST_FTransform_TO(Other);
		auto _p1 = Tolerance;
		return CONV_ST_FTransform_TO(Self).RotationEquals(_p0, _p1);
	}

	DOTNET_EXPORT void E_FTransform_Multiply(E_ST_FTransform Self, E_ST_FTransform OutTransform, E_ST_FTransform A, E_ST_FTransform B)
	{
		auto _p0 = CONV_ST_FTransform_TO(OutTransform);
		auto _p1 = CONV_ST_FTransform_TO(A);
		auto _p2 = CONV_ST_FTransform_TO(B);
		CONV_ST_FTransform_TO(Self).Multiply(&_p0, &_p1, &_p2);
	}

	DOTNET_EXPORT void E_FTransform_SetComponents(E_ST_FTransform Self, E_ST_FQuat InRotation, E_ST_FVector InTranslation, E_ST_FVector InScale3D)
	{
		auto _p0 = CONV_ST_FQuat_TO(InRotation);
		auto _p1 = CONV_ST_FVector_TO(InTranslation);
		auto _p2 = CONV_ST_FVector_TO(InScale3D);
		CONV_ST_FTransform_TO(Self).SetComponents(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_FTransform_SetIdentity(E_ST_FTransform Self)
	{
		CONV_ST_FTransform_TO(Self).SetIdentity();
	}

	DOTNET_EXPORT E_ST_FVector E_FTransform_AddTranslations(E_ST_FTransform Self, E_ST_FTransform A, E_ST_FTransform B)
	{
		auto _p0 = CONV_ST_FTransform_TO(A);
		auto _p1 = CONV_ST_FTransform_TO(B);
		return CONV_ST_FVector_IN(CONV_ST_FTransform_TO(Self).AddTranslations(_p0, _p1));
	}

	DOTNET_EXPORT void E_FTransform_SetTranslationAndScale3D(E_ST_FTransform Self, E_ST_FVector NewTranslation, E_ST_FVector NewScale3D)
	{
		auto _p0 = CONV_ST_FVector_TO(NewTranslation);
		auto _p1 = CONV_ST_FVector_TO(NewScale3D);
		CONV_ST_FTransform_TO(Self).SetTranslationAndScale3D(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FQuat E_FTransform_GetRotation(E_ST_FTransform Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FTransform_TO(Self).GetRotation());
	}

	
	/*	FVector	*/
	
	DOTNET_EXPORT E_ST_FVector E_OP_FVector_u(E_ST_FVector Self, E_ST_FVector V)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).operator^(_p0));
	}

	DOTNET_EXPORT E_ST_FVector E_FVector_CrossProduct(E_ST_FVector Self, E_ST_FVector A, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(A);
		auto _p1 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).CrossProduct(_p0, _p1));
	}

	DOTNET_EXPORT float E_OP_FVector_i(E_ST_FVector Self, E_ST_FVector V)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		return CONV_ST_FVector_TO(Self).operator|(_p0);
	}

	DOTNET_EXPORT float E_FVector_DotProduct(E_ST_FVector Self, E_ST_FVector A, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(A);
		auto _p1 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_TO(Self).DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_Equals(E_ST_FVector Self, E_ST_FVector V, float Tolerance)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		auto _p1 = Tolerance;
		return CONV_ST_FVector_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_AllComponentsEqual(E_ST_FVector Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FVector_TO(Self).AllComponentsEqual(_p0);
	}

	DOTNET_EXPORT void E_FVector_Set(E_ST_FVector Self, float InX, float InY, float InZ)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		CONV_ST_FVector_TO(Self).Set(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_FVector_GetMax(E_ST_FVector Self)
	{
		return CONV_ST_FVector_TO(Self).GetMax();
	}

	DOTNET_EXPORT bool E_FVector_IsZero(E_ST_FVector Self)
	{
		return CONV_ST_FVector_TO(Self).IsZero();
	}

	DOTNET_EXPORT bool E_FVector_Normalize(E_ST_FVector Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FVector_TO(Self).Normalize(_p0);
	}

	DOTNET_EXPORT void E_FVector_ToDirectionAndLength(E_ST_FVector Self, E_ST_FVector OutDir, float OutLength)
	{
		auto _p0 = CONV_ST_FVector_TO(OutDir);
		auto _p1 = OutLength;
		CONV_ST_FVector_TO(Self).ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector E_FVector_GridSnap(E_ST_FVector Self, float GridSz)
	{
		auto _p0 = GridSz;
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).GridSnap(_p0));
	}

	DOTNET_EXPORT E_ST_FVector E_FVector_GetClampedToSize(E_ST_FVector Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).GetClampedToSize(_p0, _p1));
	}

	DOTNET_EXPORT void E_FVector_AddBounded(E_ST_FVector Self, E_ST_FVector V, float Radius)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		auto _p1 = Radius;
		CONV_ST_FVector_TO(Self).AddBounded(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector E_FVector_RotateAngleAxis(E_ST_FVector Self, float AngleDeg, E_ST_FVector Axis)
	{
		auto _p0 = AngleDeg;
		auto _p1 = CONV_ST_FVector_TO(Axis);
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).RotateAngleAxis(_p0, _p1));
	}

	DOTNET_EXPORT float E_FVector_CosineAngle2D(E_ST_FVector Self, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_TO(Self).CosineAngle2D(_p0);
	}

	DOTNET_EXPORT E_ST_FRotator E_FVector_ToOrientationRotator(E_ST_FVector Self)
	{
		return CONV_ST_FRotator_IN(CONV_ST_FVector_TO(Self).ToOrientationRotator());
	}

	DOTNET_EXPORT E_ST_FQuat E_FVector_ToOrientationQuat(E_ST_FVector Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FVector_TO(Self).ToOrientationQuat());
	}

	DOTNET_EXPORT void E_FVector_FindBestAxisVectors(E_ST_FVector Self, E_ST_FVector Axis1, E_ST_FVector Axis2)
	{
		auto _p0 = CONV_ST_FVector_TO(Axis1);
		auto _p1 = CONV_ST_FVector_TO(Axis2);
		CONV_ST_FVector_TO(Self).FindBestAxisVectors(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector_UnwindEuler(E_ST_FVector Self)
	{
		CONV_ST_FVector_TO(Self).UnwindEuler();
	}

	DOTNET_EXPORT E_ST_FVector2D E_FVector_UnitCartesianToSpherical(E_ST_FVector Self)
	{
		return CONV_ST_FVector2D_IN(CONV_ST_FVector_TO(Self).UnitCartesianToSpherical());
	}

	DOTNET_EXPORT void E_FVector_CreateOrthonormalBasis(E_ST_FVector Self, E_ST_FVector XAxis, E_ST_FVector YAxis, E_ST_FVector ZAxis)
	{
		auto _p0 = CONV_ST_FVector_TO(XAxis);
		auto _p1 = CONV_ST_FVector_TO(YAxis);
		auto _p2 = CONV_ST_FVector_TO(ZAxis);
		CONV_ST_FVector_TO(Self).CreateOrthonormalBasis(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_PointsAreSame(E_ST_FVector Self, E_ST_FVector P, E_ST_FVector Q)
	{
		auto _p0 = CONV_ST_FVector_TO(P);
		auto _p1 = CONV_ST_FVector_TO(Q);
		return CONV_ST_FVector_TO(Self).PointsAreSame(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_PointsAreNear(E_ST_FVector Self, E_ST_FVector Point1, E_ST_FVector Point2, float Dist)
	{
		auto _p0 = CONV_ST_FVector_TO(Point1);
		auto _p1 = CONV_ST_FVector_TO(Point2);
		auto _p2 = Dist;
		return CONV_ST_FVector_TO(Self).PointsAreNear(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_FVector_PointPlaneDist(E_ST_FVector Self, E_ST_FVector Point, E_ST_FVector PlaneBase, E_ST_FVector PlaneNormal)
	{
		auto _p0 = CONV_ST_FVector_TO(Point);
		auto _p1 = CONV_ST_FVector_TO(PlaneBase);
		auto _p2 = CONV_ST_FVector_TO(PlaneNormal);
		return CONV_ST_FVector_TO(Self).PointPlaneDist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_Coplanar(E_ST_FVector Self, E_ST_FVector Base1, E_ST_FVector Normal1, E_ST_FVector Base2, E_ST_FVector Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = CONV_ST_FVector_TO(Base1);
		auto _p1 = CONV_ST_FVector_TO(Normal1);
		auto _p2 = CONV_ST_FVector_TO(Base2);
		auto _p3 = CONV_ST_FVector_TO(Normal2);
		auto _p4 = ParallelCosineThreshold;
		return CONV_ST_FVector_TO(Self).Coplanar(_p0, _p1, _p2, _p3, _p4);
	}

	
	/*	FVector2D	*/
	
	DOTNET_EXPORT E_ST_FVector2D E_OP_FVector2D_p(E_ST_FVector2D Self, E_ST_FVector2D V)
	{
		auto _p0 = CONV_ST_FVector2D_TO(V);
		return CONV_ST_FVector2D_IN(CONV_ST_FVector2D_TO(Self).operator+(_p0));
	}

	DOTNET_EXPORT E_ST_FVector2D E_OP_FVector2D_m(E_ST_FVector2D Self, float Scale)
	{
		auto _p0 = Scale;
		return CONV_ST_FVector2D_IN(CONV_ST_FVector2D_TO(Self).operator*(_p0));
	}

	DOTNET_EXPORT float E_OP_FVector2D_i(E_ST_FVector2D Self, E_ST_FVector2D V)
	{
		auto _p0 = CONV_ST_FVector2D_TO(V);
		return CONV_ST_FVector2D_TO(Self).operator|(_p0);
	}

	DOTNET_EXPORT float E_FVector2D_DotProduct(E_ST_FVector2D Self, E_ST_FVector2D A, E_ST_FVector2D B)
	{
		auto _p0 = CONV_ST_FVector2D_TO(A);
		auto _p1 = CONV_ST_FVector2D_TO(B);
		return CONV_ST_FVector2D_TO(Self).DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector2D_Equals(E_ST_FVector2D Self, E_ST_FVector2D V, float Tolerance)
	{
		auto _p0 = CONV_ST_FVector2D_TO(V);
		auto _p1 = Tolerance;
		return CONV_ST_FVector2D_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector2D_Set(E_ST_FVector2D Self, float InX, float InY)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		CONV_ST_FVector2D_TO(Self).Set(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector2D_GetMax(E_ST_FVector2D Self)
	{
		return CONV_ST_FVector2D_TO(Self).GetMax();
	}

	DOTNET_EXPORT void E_FVector2D_Normalize(E_ST_FVector2D Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		CONV_ST_FVector2D_TO(Self).Normalize(_p0);
	}

	DOTNET_EXPORT bool E_FVector2D_IsNearlyZero(E_ST_FVector2D Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FVector2D_TO(Self).IsNearlyZero(_p0);
	}

	DOTNET_EXPORT void E_FVector2D_ToDirectionAndLength(E_ST_FVector2D Self, E_ST_FVector2D OutDir, float OutLength)
	{
		auto _p0 = CONV_ST_FVector2D_TO(OutDir);
		auto _p1 = OutLength;
		CONV_ST_FVector2D_TO(Self).ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector2D_IsZero(E_ST_FVector2D Self)
	{
		return CONV_ST_FVector2D_TO(Self).IsZero();
	}

	DOTNET_EXPORT E_ST_FVector2D E_FVector2D_ClampAxes(E_ST_FVector2D Self, float MinAxisVal, float MaxAxisVal)
	{
		auto _p0 = MinAxisVal;
		auto _p1 = MaxAxisVal;
		return CONV_ST_FVector2D_IN(CONV_ST_FVector2D_TO(Self).ClampAxes(_p0, _p1));
	}

	DOTNET_EXPORT void E_FVector2D_DiagnosticCheckNaN(E_ST_FVector2D Self)
	{
		CONV_ST_FVector2D_TO(Self).DiagnosticCheckNaN();
	}

	DOTNET_EXPORT E_ST_FVector E_FVector2D_SphericalToUnitCartesian(E_ST_FVector2D Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FVector2D_TO(Self).SphericalToUnitCartesian());
	}

	
	/*	FVector4	*/
	
	DOTNET_EXPORT E_ST_FVector4 E_OP_FVector4_p(E_ST_FVector4 Self, E_ST_FVector4 V)
	{
		auto _p0 = CONV_ST_FVector4_TO(V);
		return CONV_ST_FVector4_IN(CONV_ST_FVector4_TO(Self).operator+(_p0));
	}

	DOTNET_EXPORT bool E_FVector4_Equals(E_ST_FVector4 Self, E_ST_FVector4 V, float Tolerance)
	{
		auto _p0 = CONV_ST_FVector4_TO(V);
		auto _p1 = Tolerance;
		return CONV_ST_FVector4_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector4_IsUnit3(E_ST_FVector4 Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return CONV_ST_FVector4_TO(Self).IsUnit3(_p0);
	}

	DOTNET_EXPORT E_ST_FRotator E_FVector4_ToOrientationRotator(E_ST_FVector4 Self)
	{
		return CONV_ST_FRotator_IN(CONV_ST_FVector4_TO(Self).ToOrientationRotator());
	}

	DOTNET_EXPORT E_ST_FQuat E_FVector4_ToOrientationQuat(E_ST_FVector4 Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FVector4_TO(Self).ToOrientationQuat());
	}

	DOTNET_EXPORT void E_FVector4_Set(E_ST_FVector4 Self, float InX, float InY, float InZ, float InW)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		auto _p3 = InW;
		CONV_ST_FVector4_TO(Self).Set(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT float E_FVector4_Size3(E_ST_FVector4 Self)
	{
		return CONV_ST_FVector4_TO(Self).Size3();
	}

	DOTNET_EXPORT bool E_FVector4_ContainsNaN(E_ST_FVector4 Self)
	{
		return CONV_ST_FVector4_TO(Self).ContainsNaN();
	}

	DOTNET_EXPORT void E_FVector4_FindBestAxisVectors3(E_ST_FVector4 Self, E_ST_FVector4 Axis1, E_ST_FVector4 Axis2)
	{
		auto _p0 = CONV_ST_FVector4_TO(Axis1);
		auto _p1 = CONV_ST_FVector4_TO(Axis2);
		CONV_ST_FVector4_TO(Self).FindBestAxisVectors3(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector4_DiagnosticCheckNaN(E_ST_FVector4 Self)
	{
		CONV_ST_FVector4_TO(Self).DiagnosticCheckNaN();
	}

	
	/*	FWorldAsyncTraceState	*/
	
	
	/*	FWorldContext	*/
	
	DOTNET_EXPORT void E_FWorldContext_AddRef(E_ST_FWorldContext Self, UWorld& WorldPtr)
	{
		auto _p0 = WorldPtr;
		CONV_ST_FWorldContext_TO(Self).AddRef(_p0);
	}

	DOTNET_EXPORT void E_FWorldContext_SetCurrentWorld(E_ST_FWorldContext Self, UWorld* World)
	{
		auto _p0 = World;
		CONV_ST_FWorldContext_TO(Self).SetCurrentWorld(_p0);
	}

	DOTNET_EXPORT UWorld* E_FWorldContext_World(E_ST_FWorldContext Self)
	{
		return CONV_ST_FWorldContext_TO(Self).World();
	}

	
	/*	FBox	*/
	
	DOTNET_EXPORT E_ST_FVector E_OP_FBox_oc(E_ST_FBox Self, int32 Index)
	{
		auto _p0 = Index;
		return CONV_ST_FVector_IN(CONV_ST_FBox_TO(Self).operator[](_p0));
	}

	DOTNET_EXPORT float E_FBox_ComputeSquaredDistanceToPoint(E_ST_FBox Self, E_ST_FVector Point)
	{
		auto _p0 = CONV_ST_FVector_TO(Point);
		return CONV_ST_FBox_TO(Self).ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT E_ST_FVector E_FBox_GetCenter(E_ST_FBox Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FBox_TO(Self).GetCenter());
	}

	DOTNET_EXPORT void E_FBox_GetCenterAndExtents(E_ST_FBox Self, E_ST_FVector center, E_ST_FVector Extents)
	{
		auto _p0 = CONV_ST_FVector_TO(center);
		auto _p1 = CONV_ST_FVector_TO(Extents);
		CONV_ST_FBox_TO(Self).GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector E_FBox_GetClosestPointTo(E_ST_FBox Self, E_ST_FVector Point)
	{
		auto _p0 = CONV_ST_FVector_TO(Point);
		return CONV_ST_FVector_IN(CONV_ST_FBox_TO(Self).GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT float E_FBox_GetVolume(E_ST_FBox Self)
	{
		return CONV_ST_FBox_TO(Self).GetVolume();
	}

	DOTNET_EXPORT void E_FBox_Init(E_ST_FBox Self)
	{
		CONV_ST_FBox_TO(Self).Init();
	}

	DOTNET_EXPORT E_ST_FBox E_FBox_InverseTransformBy(E_ST_FBox Self, E_ST_FTransform M)
	{
		auto _p0 = CONV_ST_FTransform_TO(M);
		return CONV_ST_FBox_IN(CONV_ST_FBox_TO(Self).InverseTransformBy(_p0));
	}

	DOTNET_EXPORT bool E_FBox_IsInside(E_ST_FBox Self, E_ST_FVector In)
	{
		auto _p0 = CONV_ST_FVector_TO(In);
		return CONV_ST_FBox_TO(Self).IsInside(_p0);
	}

	DOTNET_EXPORT E_ST_FBox E_FBox_BuildAABB(E_ST_FBox Self, E_ST_FVector Origin, E_ST_FVector Extent)
	{
		auto _p0 = CONV_ST_FVector_TO(Origin);
		auto _p1 = CONV_ST_FVector_TO(Extent);
		return CONV_ST_FBox_IN(CONV_ST_FBox_TO(Self).BuildAABB(_p0, _p1));
	}

	
	/*	FBox2D	*/
	
	DOTNET_EXPORT E_ST_FVector2D E_OP_FBox2D_oc(E_ST_FBox2D Self, int32 Index)
	{
		auto _p0 = Index;
		return CONV_ST_FVector2D_IN(CONV_ST_FBox2D_TO(Self).operator[](_p0));
	}

	DOTNET_EXPORT float E_FBox2D_ComputeSquaredDistanceToPoint(E_ST_FBox2D Self, E_ST_FVector2D Point)
	{
		auto _p0 = CONV_ST_FVector2D_TO(Point);
		return CONV_ST_FBox2D_TO(Self).ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT E_ST_FBox2D E_FBox2D_ExpandBy(E_ST_FBox2D Self, float W)
	{
		auto _p0 = W;
		return CONV_ST_FBox2D_IN(CONV_ST_FBox2D_TO(Self).ExpandBy(_p0));
	}

	DOTNET_EXPORT float E_FBox2D_GetArea(E_ST_FBox2D Self)
	{
		return CONV_ST_FBox2D_TO(Self).GetArea();
	}

	DOTNET_EXPORT E_ST_FVector2D E_FBox2D_GetCenter(E_ST_FBox2D Self)
	{
		return CONV_ST_FVector2D_IN(CONV_ST_FBox2D_TO(Self).GetCenter());
	}

	DOTNET_EXPORT void E_FBox2D_GetCenterAndExtents(E_ST_FBox2D Self, E_ST_FVector2D center, E_ST_FVector2D Extents)
	{
		auto _p0 = CONV_ST_FVector2D_TO(center);
		auto _p1 = CONV_ST_FVector2D_TO(Extents);
		CONV_ST_FBox2D_TO(Self).GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector2D E_FBox2D_GetClosestPointTo(E_ST_FBox2D Self, E_ST_FVector2D Point)
	{
		auto _p0 = CONV_ST_FVector2D_TO(Point);
		return CONV_ST_FVector2D_IN(CONV_ST_FBox2D_TO(Self).GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT void E_FBox2D_Init(E_ST_FBox2D Self)
	{
		CONV_ST_FBox2D_TO(Self).Init();
	}

	DOTNET_EXPORT bool E_FBox2D_IsInside(E_ST_FBox2D Self, E_ST_FVector2D TestPoint)
	{
		auto _p0 = CONV_ST_FVector2D_TO(TestPoint);
		return CONV_ST_FBox2D_TO(Self).IsInside(_p0);
	}

	
	/*	FDropNoteInfo	*/
	
	
	/*	FLevelViewportInfo	*/
	
	
	/*	FNamedNetDriver	*/
	
	
	/*	FScreenMessageString	*/
	
}
