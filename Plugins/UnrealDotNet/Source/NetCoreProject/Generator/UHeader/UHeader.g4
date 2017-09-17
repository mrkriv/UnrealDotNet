grammar UHeader;

/*Basic concepts*/
translationUnit
	: 
	(typePreDeclaration
	| method
	| constructor
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
	: Namespace namespaceName '{' translationUnit '}' ';'?
	;

namespaceName
	: Identifier 
	;


typePreDeclaration
	: templateDefine? classOrStructOrEnum className ';'
	| isFriend classOrStructOrEnum? className ';'
;


/* Class */

classDeclaration
	: templateDefine? classOrStruct className isFinal? (DotDot classParentList)? '{' classBody '}' classAlignDefine? ';'
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
	: accessSpecifier? className
	| accessSpecifier? className ',' classParentList
;

className
	: Identifier
	| Identifier '<' className (',' className)? '>'
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
	| comment
	| preprocessDerective)*
;

comment
	: ExportComment
	;

/* Enum */

enumDeclaration
	: Enum Class? enumName enumParent? ('{' enumElementList '}')? ';'
	| Enum '{' enumElementList '}' ';'
;

enumParent
	: DotDot className
;

enumName
	: Identifier
	;

enumElementList
	: enumElement
	| enumElement ',' enumElementList ','?
	;

enumElement
	: comment? enumElementName ( ('=' | DotDot) propertyDefaultValue )? uDefine?
	;

enumElementName
	: Identifier
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
	: type (methodParametrName ('=' methodParametrDefaultValue)?)?
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
	| Operator methodOperator?
;

methodOperator
	: ( PtrQuant | PtrQuant | SpecalSymbol | '|' | '=' | '<' | '>' | '[' | ']' | '&' | Identifier)+
;

/* Property */

property
	: (Mutable|Extern|isStatic)* type propertyName isArray? ( ('=' | DotDot) propertyDefaultValue )? ';'
;

propertyName
	: Identifier
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
	: Identifier (DotDot+ Identifier)?
	| typeTemplateName ('<' (type|Literal) (',' (type|Literal))* '>')
;

typeTemplateName
	: Identifier
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
	: templateParam
	| templateParam ',' templateParamList
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

Namespace
	: 'namespace'
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
	: DIGIT* '.'? DIGIT+ 'f'?
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