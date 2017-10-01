#pragma once

typedef struct ObjectPointerDescription
{
	INT_PTR Pointer;
	INT_PTR TypeName;
	int32 TypeNameLen;
}
ObjectPointerDescription;

TQueue<INT_PTR> NeedDeleteQueue;