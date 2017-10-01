#pragma once

#include "ExportUtilites.h"
#include "CoreShell.h"

template<typename T, typename R>
R ConvertForManage(T& object)
{
	return object;
}

ObjectPointerDescription ConvertForManage(UObject*& object)
{
	return MakePrtDesc(object);
}