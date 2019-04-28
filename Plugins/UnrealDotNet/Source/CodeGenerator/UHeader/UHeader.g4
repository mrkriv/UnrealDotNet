grammar UHeader;

/*Basic concepts*/
translationUnit
	: 
	(typePreDeclaration
	| method
	| classDeclaration
	| enumDeclaration
	| property
	| typeDefine
	| uDefine
	| namespaceUnit
	| comment
	| preprocessDerective)*
	 EOF
;


/* Namespace */

namespaceUnit
	: Namespace namespaceName '{' 
	 (typePreDeclaration
     	| method
     	| classDeclaration
     	| enumDeclaration
     	| property
     	| typeDefine
     	| uDefine
     	| namespaceUnit
     	| comment
     	| preprocessDerective)*
	 '}' ';'?
;

namespaceName
	: Identifier 
;


typePreDeclaration
	: templateDefine? classOrStructOrEnum type ';'
	| isFriend classOrStructOrEnum? type ';'
;

/* Class */

classDeclaration
	: templateDefine? classOrStruct type isFinal? (DotDot classParentList)? '{' classBody '}' classAlignDefine? ';'
;

classOrStructOrEnum
	: Class
	| Struct
	| Enum
;

classOrStruct
	: Class
	| Struct
;

classParentList
	: accessSpecifier? type
	| accessSpecifier? type ',' classParentList
;

classAlignDefine
	: GCC_ALIGN '(' classAlignValue ')'
	;

classAlignValue
	: Literal+
	;

classBody
	: (accessSpecifierContainer
	| method
	| constructor
	| property
	| uDefine
	| typeDefine
	| classDeclaration
	| enumDeclaration
	| typePreDeclaration
	| unionDeclaration
	| comment
	| preprocessDerective)*
;

comment
	: ExportComment
	;

/* Enum */

enumDeclaration
	: Enum Class? type enumParent? ('{' enumElementList '}')? ';'
	| Enum '{' enumElementList '}' ';'
;

enumParent
	: DotDot type
;

enumElementList
	: enumElement
	| enumElement ',' enumElementList ','?
	;

enumElement
	: comment* enumElementName ( ('=' | DotDot) propertyDefaultValue )? uDefine?
	;

enumElementName
	: Identifier
	;

/* Union */
unionDeclaration
	: Union methodBody ';'?	// skip union
;

/* typeDefine */

typeDefine
	: Typedef type typeName ';'
	;

/* UnrealDefine */

uDefine
	: uDefineName '(' uMeta ')' ';'?
;

uDefineName
	: Identifier
;

uMeta
	: uMetaParametrList?
;

uMetaParametrList
	: uMetaParametr
	| uMetaParametr ',' uMetaParametrList
;

uMetaParametr
	: uMetaParamKey
	| uMetaParamKey '=' uMetaParamValue
	| uMetaParamKey '=' '(' uMetaParametrList ')'
;

uMetaParamKey
	: type
	| value
	| uMetaParamKey '|' uMetaParamKey
;

uMetaParamValue
	: type
	| value
;

/* Undefine */

undefineBlock
	: '(' undefineContent ')'
;

undefineContent
	: ~('(' | ')')* (
		('(' undefineContent ')' undefineContent)?
	)
;

/* Method */

constructor
	: (Explicit|Inline|isVirtual)* isDestructor? methodName '(' methodParamsList? ')' isConst? (':' constructorInitializerList)?  (methodBody|isDelete)? ';'?
;

constructorInitializerList
	: constructorInitializer
	| constructorInitializer ',' constructorInitializerList
	;

constructorInitializer
	: methodParametrName '(' methodParametrDefaultValue? ')'
	| methodParametrName undefineBlock
	;

method
	: templateDefine? (Constexpr|isFriend|Inline|Extern|isStatic|isVirtual)* type methodName '(' methodParamsList? ')' isConst? isOverride? isFinal? (methodBody|isDelete)? ';'?
;

methodParamsList
	: methodParametr
	| methodParametr ',' methodParamsList
;

methodParametr
	: methodParametrMetadata? methodParametrTemplate? type (methodParametrName ('=' methodParametrDefaultValue)?)?
;

methodParametrMetadata
	: UPARAM '(' uMetaParametrList? ')'
;

methodParametrTemplate
	: Typename (type DotDot DotDot Template)?
;

methodParametrName
	: Identifier
;

methodParametrDefaultValue
	: value (',' value)*
;

value
	: (isPtrQuant | isRefQuant)? (Identifier|Literal) ((SpecalSymbol|DotDot|'<'|'>'|'|')+ (Identifier|Literal))? 
		('(' methodParametrDefaultValue? ')')?
;

methodBody
	: '{' methodBodyContent '}'
;

methodBodyContent
	: ~(BracketsOpen | BracketsClose)* (
		(BracketsOpen methodBodyContent BracketsClose methodBodyContent)?
	)
;

methodName
	: Identifier (DotDot DotDot methodName)?
	| Operator methodOperator
;

methodOperator
	: ( PtrQuant | SpecalSymbol | '&' | Identifier)+
;

/* Property */

property
	: templateDefine? (Mutable|Extern|isStatic)* type propertyName isArray? ( ('=' | DotDot) propertyDefaultValue )? ';'
;

propertyName
    : Identifier ('<' templateParamList '>')? (DotDot DotDot propertyName)?
;

propertyDefaultValue
	: Identifier ('(' propertyDefaultValue ')')?
	| value
;


/* Type */

type
	: isConst? classOrStructOrEnum? (isPtrQuant | isRefQuant)? typeName (isPtrQuant | isRefQuant)? isConst? (isPtrQuant | isRefQuant)?
;

isPtrQuant
	: PtrQuant
;

isRefQuant
	: RefQuant
;

typeName
    : Identifier ('<' (type|Literal) (',' (type|Literal))* '>')? (DotDot DotDot typeName)?
;

isVirtual
	: Virtual
;

isOverride
	: Override
;

isConst
	: Const
;

isStatic
	: Static
;

isFriend
	: Friend
;

isFinal
	: Final
;

isDestructor
	: Tilda
;

isDelete
	: '=' Delete
;

isArray
	: '[' arrayLen ']' 
;

arrayLen
	: Literal
;


/* Template */

templateDefine
	: Template '<' templateParamList? '>'
	;

templateParamList
	: Typename? templateParam (',' templateParamList)?
	| Typename (',' templateParamList)?
	;

templateParam
	: templateParamType templateParamLiter? ('=' propertyDefaultValue)?
	;

templateParamType
	: Identifier
	| Class 
	| Struct
	| Enum
	;

templateParamLiter
	: Identifier
	;

accessSpecifierContainer
	: accessSpecifier DotDot
;

accessSpecifier
	: Private
	| Protected
	| Public
;


/*Preprocessing directives*/

preprocessDerective
	: SingleLineDerective 
	| MultiLineDerective 
;


/*Lexer*/

PtrQuant
	: '*'
;

RefQuant
	: '&'
;

Private
	: 'private'
;

Protected
	: 'protected'
;

Public
	: 'public'
;

Inline
	: 'inline'
	| 'FORCEINLINE'
	| 'FORCEINLINE_DEBUGGABLE'
;

Explicit
	: 'explicit'
	;

Virtual
	: 'virtual'
;

Class
	: 'class'
;

Struct
	: 'struct'
;

Enum
	: 'enum'
;

Union
	: 'union'
;

Const
	: 'const'
;

Final
	: 'final'
;

Static
	: 'static'
;

Extern
	: 'extern'
;

Mutable
	: 'mutable'
;

Override
	: 'override'
;

Template
	: 'template'
;

Friend
	: 'friend'
;

Operator
	: 'operator'
;

Typedef
	: 'typedef'
;

Constexpr
	: 'CONSTEXPR'
;

BracketsOpen
	: '{'
;

BracketsClose
	: '}'
;

Tilda
	: '~'
;

Delete
	: 'delete'
;

GCC_ALIGN
	: 'GCC_ALIGN'
;

UPARAM
	: 'UPARAM'
;

Namespace
	: 'namespace'
;

Typename
	: 'typename'
;

DotDot
	: ':'
;

SingleLineDerective
	: '#' ~[\n]+
;

MultiLineDerective
	: '#' (~[\n]*? '\\' '\r'? '\n')+ ~[\n]+
;

Identifier
	: NONDIGIT (NONDIGIT | DIGIT | '.')*
;

fragment
NONDIGIT
	: [a-zA-Z_]
;

fragment
DIGIT
	: [0-9]
;

Literal
	: Boolean
	| RealDIGIT
	| '0x' DIGIT+
	| '"' Schar* '"'
;

fragment
RealDIGIT
	: DIGIT* '.'? 'e-'? DIGIT+ 'f'?
	| DIGIT+ '.' 'f'?
;

fragment
Schar
	: ~["\\\r\n]
	| SomeEscapeSequence
;

fragment
Boolean
	: 'true' | 'false'
;

fragment
SomeEscapeSequence
	: '\\\''
	| '\\"'
	| '\\\\'
	| '\\n'
	| '\\r'
	| '\\t'
;

fragment
SIGN
	: [+-]
;

SpecalSymbol
	: ~[a-zA-Z_0-9\n\r \t&*]
;

Whitespace
	: [ \t]+ -> skip
;

Newline
	: ( '\r' '\n'? | '\n') -> skip
;

ExportComment
	: '/**' .*? '*/'
;

BlockComment
	: '/*' .*? '*/'  -> skip
;

LineComment
	: '//' ~[\r\n]*  -> skip
;