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
	| uDefine
	| preprocessDerective)*// For debug, replace with topLevelElement
	 EOF
;

/*topLevelElement
	: classPreDeclaration
	| classDeclaration
	| uDefine
	| preprocessDerective
;*/

/*classLevelElement
	: accessSpecifierContainer
	| method
	| uDefine
	| preprocessDerective
;*/

typePreDeclaration
	: classOrStructOrEnum className ';'
;

/* Class */

classDeclaration
	: templateDefine? classOrStruct className (DotDot classParentList)? '{' classBody '}' ';'
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
	| Identifier '<' Identifier '>'
;

classBody
	: (accessSpecifierContainer
	| method
	| constructor
	| property
	| uDefine
	| classDeclaration
	| enumDeclaration
	| preprocessDerective)* // For debug, replace with classLevelElement
;


/* Enum */

enumDeclaration
	: Enum Class? enumName enumParent? '{' enumElementList '}' ';'
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
	: enumElementName ( ('=' | DotDot) propertyDefaultValue )?
	;

enumElementName
	: Identifier
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
;

uMetaParamValue
	: type
	| value
;


/* Method */

constructor
	: Explicit? Inline? methodName '(' methodParamsList? ')' (':' constructorInitializerList)? methodBody? ';'?
;

constructorInitializerList
	: constructorInitializer
	| constructorInitializer ',' constructorInitializerList
	;

constructorInitializer
	: methodParametrName '(' methodParametrDefaultValue ')'
	;

method
	: templateDefine? (
		(isFriend? Inline? Extern? isStatic? isVirtual?) |
		(isFriend? isStatic? Inline? Extern? isVirtual?)
	) type methodName '(' methodParamsList? ')' isConst? Override? methodBody? ';'?
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
	: value
;

value
	: Identifier (DotDot+ Identifier)? ('(' methodParametrDefaultValue ')')?
	| Literal
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
	: ( PtrQuant | PtrQuant | SpecalSymbol | '=' | '<' | '>' )+
;


/* Property */

property
	: Extern? isStatic? type propertyName ( ('=' | DotDot) propertyDefaultValue )? ';'
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
	| typeTemplateName ('<' type '>')
;

typeTemplateName
	: Identifier
;

isVirtual
	: Virtual
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


/* Template */

templateDefine
	: Template '<' templateParamList? '>'
	;

templateParamList
	: templateParam
	| templateParam ',' templateParamList
	;

templateParam
	: templateParamType templateParamLiter
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

Static
	: 'static'
;

Extern
	: 'extern'
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

BracketsOpen
	: '{'
;

BracketsClose
	: '}'
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

BlockComment
	: '/*' .*? '*/' -> skip
;

LineComment
	: '//' ~[\r\n]* -> skip
;