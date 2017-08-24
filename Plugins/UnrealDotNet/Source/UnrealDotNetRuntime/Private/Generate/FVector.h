#pragma once

#include "CoreMinimal.h"
#include "Math/Vector.h"

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
	DOTNET_EXPORT E_ST_FVector E_CrossProduct(E_ST_FVector Self, E_ST_FVector A, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(A);
		auto _p1 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).CrossProduct(_p0, _p1));
	}

	DOTNET_EXPORT float E_DotProduct(E_ST_FVector Self, E_ST_FVector A, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(A);
		auto _p1 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_TO(Self).DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_Equals(E_ST_FVector Self, E_ST_FVector V, float Tolerance)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		auto _p1 = Tolerance;
		return CONV_ST_FVector_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_AllComponentsEqual(E_ST_FVector Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FVector_TO(Self).AllComponentsEqual(_p0);
	}

	DOTNET_EXPORT void E_Set(E_ST_FVector Self, float InX, float InY, float InZ)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		CONV_ST_FVector_TO(Self).Set(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_GetMax(E_ST_FVector Self)
	{
		return CONV_ST_FVector_TO(Self).GetMax();
	}

	DOTNET_EXPORT bool E_IsZero(E_ST_FVector Self)
	{
		return CONV_ST_FVector_TO(Self).IsZero();
	}

	DOTNET_EXPORT bool E_Normalize(E_ST_FVector Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FVector_TO(Self).Normalize(_p0);
	}

	DOTNET_EXPORT void E_ToDirectionAndLength(E_ST_FVector Self, E_ST_FVector OutDir, float OutLength)
	{
		auto _p0 = CONV_ST_FVector_TO(OutDir);
		auto _p1 = OutLength;
		CONV_ST_FVector_TO(Self).ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector E_GridSnap(E_ST_FVector Self, float GridSz)
	{
		auto _p0 = GridSz;
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).GridSnap(_p0));
	}

	DOTNET_EXPORT E_ST_FVector E_GetClampedToSize(E_ST_FVector Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).GetClampedToSize(_p0, _p1));
	}

	DOTNET_EXPORT void E_AddBounded(E_ST_FVector Self, E_ST_FVector V, float Radius)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		auto _p1 = Radius;
		CONV_ST_FVector_TO(Self).AddBounded(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector E_RotateAngleAxis(E_ST_FVector Self, float AngleDeg, E_ST_FVector Axis)
	{
		auto _p0 = AngleDeg;
		auto _p1 = CONV_ST_FVector_TO(Axis);
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).RotateAngleAxis(_p0, _p1));
	}

	DOTNET_EXPORT float E_CosineAngle2D(E_ST_FVector Self, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_TO(Self).CosineAngle2D(_p0);
	}

	DOTNET_EXPORT void E_FindBestAxisVectors(E_ST_FVector Self, E_ST_FVector Axis1, E_ST_FVector Axis2)
	{
		auto _p0 = CONV_ST_FVector_TO(Axis1);
		auto _p1 = CONV_ST_FVector_TO(Axis2);
		CONV_ST_FVector_TO(Self).FindBestAxisVectors(_p0, _p1);
	}

	DOTNET_EXPORT void E_UnwindEuler(E_ST_FVector Self)
	{
		CONV_ST_FVector_TO(Self).UnwindEuler();
	}

	DOTNET_EXPORT void E_CreateOrthonormalBasis(E_ST_FVector Self, E_ST_FVector XAxis, E_ST_FVector YAxis, E_ST_FVector ZAxis)
	{
		auto _p0 = CONV_ST_FVector_TO(XAxis);
		auto _p1 = CONV_ST_FVector_TO(YAxis);
		auto _p2 = CONV_ST_FVector_TO(ZAxis);
		CONV_ST_FVector_TO(Self).CreateOrthonormalBasis(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_PointsAreSame(E_ST_FVector Self, E_ST_FVector P, E_ST_FVector Q)
	{
		auto _p0 = CONV_ST_FVector_TO(P);
		auto _p1 = CONV_ST_FVector_TO(Q);
		return CONV_ST_FVector_TO(Self).PointsAreSame(_p0, _p1);
	}

	DOTNET_EXPORT bool E_PointsAreNear(E_ST_FVector Self, E_ST_FVector Point1, E_ST_FVector Point2, float Dist)
	{
		auto _p0 = CONV_ST_FVector_TO(Point1);
		auto _p1 = CONV_ST_FVector_TO(Point2);
		auto _p2 = Dist;
		return CONV_ST_FVector_TO(Self).PointsAreNear(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_PointPlaneDist(E_ST_FVector Self, E_ST_FVector Point, E_ST_FVector PlaneBase, E_ST_FVector PlaneNormal)
	{
		auto _p0 = CONV_ST_FVector_TO(Point);
		auto _p1 = CONV_ST_FVector_TO(PlaneBase);
		auto _p2 = CONV_ST_FVector_TO(PlaneNormal);
		return CONV_ST_FVector_TO(Self).PointPlaneDist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_Coplanar(E_ST_FVector Self, E_ST_FVector Base1, E_ST_FVector Normal1, E_ST_FVector Base2, E_ST_FVector Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = CONV_ST_FVector_TO(Base1);
		auto _p1 = CONV_ST_FVector_TO(Normal1);
		auto _p2 = CONV_ST_FVector_TO(Base2);
		auto _p3 = CONV_ST_FVector_TO(Normal2);
		auto _p4 = ParallelCosineThreshold;
		return CONV_ST_FVector_TO(Self).Coplanar(_p0, _p1, _p2, _p3, _p4);
	}

}
