#pragma once

#include "CoreMinimal.h"
#include "Components/SplineMeshComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_USplineMeshComponent_CalculateScaleZAndMinZ(INT_PTR Self, float OutScaleZ, float OutMinZ)
	{
		auto _p0 = OutScaleZ;
		auto _p1 = OutMinZ;
		((USplineMeshComponent*)Self)->CalculateScaleZAndMinZ(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_USplineMeshComponent_GetStartPosition(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((USplineMeshComponent*)Self)->GetStartPosition());
	}

	DOTNET_EXPORT void E_USplineMeshComponent_SetStartPosition(INT_PTR Self, INT_PTR StartPos, bool bUpdateMesh)
	{
		auto _p0 = *(FVector*)StartPos;
		auto _p1 = bUpdateMesh;
		((USplineMeshComponent*)Self)->SetStartPosition(_p0, _p1);
	}

	DOTNET_EXPORT void E_USplineMeshComponent_SetStartAndEnd(INT_PTR Self, INT_PTR StartPos, INT_PTR StartTangent, INT_PTR EndPos, INT_PTR EndTangent, bool bUpdateMesh)
	{
		auto _p0 = *(FVector*)StartPos;
		auto _p1 = *(FVector*)StartTangent;
		auto _p2 = *(FVector*)EndPos;
		auto _p3 = *(FVector*)EndTangent;
		auto _p4 = bUpdateMesh;
		((USplineMeshComponent*)Self)->SetStartAndEnd(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT INT_PTR E_USplineMeshComponent_GetStartScale(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((USplineMeshComponent*)Self)->GetStartScale());
	}

	DOTNET_EXPORT void E_USplineMeshComponent_SetStartScale(INT_PTR Self, INT_PTR StartScale, bool bUpdateMesh)
	{
		auto _p0 = *(FVector2D*)StartScale;
		auto _p1 = bUpdateMesh;
		((USplineMeshComponent*)Self)->SetStartScale(_p0, _p1);
	}

	DOTNET_EXPORT float E_USplineMeshComponent_GetStartRoll(INT_PTR Self)
	{
		return ((USplineMeshComponent*)Self)->GetStartRoll();
	}

	DOTNET_EXPORT void E_USplineMeshComponent_SetStartRoll(INT_PTR Self, float StartRoll, bool bUpdateMesh)
	{
		auto _p0 = StartRoll;
		auto _p1 = bUpdateMesh;
		((USplineMeshComponent*)Self)->SetStartRoll(_p0, _p1);
	}

	DOTNET_EXPORT void E_USplineMeshComponent_SetSplineUpDir(INT_PTR Self, INT_PTR InSplineUpDir, bool bUpdateMesh)
	{
		auto _p0 = *(FVector*)InSplineUpDir;
		auto _p1 = bUpdateMesh;
		((USplineMeshComponent*)Self)->SetSplineUpDir(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_USplineMeshComponent_CalcSliceTransform(INT_PTR Self, float DistanceAlong)
	{
		auto _p0 = DistanceAlong;
		return (INT_PTR) new FTransform(((USplineMeshComponent*)Self)->CalcSliceTransform(_p0));
	}

}
