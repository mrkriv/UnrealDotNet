grammar UHeader;

/*Basic concepts*/
translationUnit
	: 
	(classPreDeclaration
	| classDeclaration
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

/* Class */
classPreDeclaration
	: classOrStruct className ';'
;

classDeclaration
	: templateDefine? classOrStruct className classParentList? '{' classBody '}' ';'
;

classOrStruct
	: Class
	| Struct
;

classParentList
	: ':' accessSpecifier? className
;

className
	: Identifier
;

classBody
	: (accessSpecifierContainer
	| method
	| property
	| uDefine
	| preprocessDerective)* // For debug, replace with classLevelElement
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
	| Literal
;

uMetaParamValue
	: type
	| Literal
;


/* Method */

method
	: templateDefine? isStatic? isVirtual? type methodName '(' methodParamsList? ')' isConst? (methodBody | ';')
;

methodParamsList
	: methodParametr
	| methodParametr ',' methodParamsList
;

methodParametr
	: type methodParametrName ('=' methodParametrDefaultValue)?
;

methodParametrName
	: Identifier
;

methodParametrDefaultValue
	: Identifier
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
	: Identifier
;


/* Property */

property
	: isStatic? type propertyName ( ('=' | ':') propertyDefaultValue )? ';'
;

propertyName
	: Identifier
;

propertyDefaultValue
	: Identifier
	| Literal
;


/* Type */

type
	: isConst? classOrStruct? (isPtrQuant | isRefQuant)? typeName (isPtrQuant | isRefQuant)?
;

isPtrQuant
	: PtrQuant
;

isRefQuant
	: RefQuant
;

typeName
	: Identifier
	| typeTemplateName ('<' typeName '>')
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


/* Template */

templateDefine
	: Template '<' templateParamList '>'
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
	;

templateParamLiter
	: Identifier
	;

accessSpecifierContainer
	: accessSpecifier ':'
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

Const
	: 'const'
;

Static
	: 'static'
;

Extern
	: 'extern'
;

Template
	: 'template'
;

BracketsOpen
	: '{'
;

BracketsClose
	: '}'
;

SingleLineDerective
	: '#' ~[\n]+
;

MultiLineDerective
	: '#' (~[\n]*? '\\' '\r'? '\n')+ ~[\n]+
;

Identifier
	: NONDIGIT (NONDIGIT | DIGIT)*
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

fragment
SpecalSymbol
	: ~[a-zA-Z_0-9\n\r \t&*]
;

Skiped
	: (SpecalSymbol | SIGN) /*-> skip*/
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