#pragma once

typedef struct ObjectPointerDescription
{
	INT_PTR Pointer;
	INT_PTR TypeName;
	int32 TypeNameLen;
}
ObjectPointerDescription;

typedef struct StringWrapper
{
	INT_PTR Pointer;
	int32 Len;
}
StringWrapper;

typedef struct TemplatePointerDescription
{
	INT_PTR Pointer;
	INT_PTR TypeName;
	int32 TypeNameLen;
}
TemplatePointerDescription;

typedef struct UClassWrapper
{
	INT_PTR Pointer;
	int32 Len;
} UClassWrapper;