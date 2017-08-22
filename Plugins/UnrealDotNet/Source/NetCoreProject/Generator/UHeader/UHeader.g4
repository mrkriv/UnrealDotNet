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
	: classOrStruct className classParentList? '{' classBody '}' ';'
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
	: isVirtual? type methodName '(' methodParamsList? ')' isConst? (methodBody | ';')
;

methodParamsList
	: methodParametr
	| methodParametr ',' methodParamsList
;

methodParametr
	: type methodParametrName
;

methodParametrName
	: Identifier
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

type
	: isConst? classOrStruct? AddressQuant* Identifier AddressQuant*
;

isVirtual
	: Virtual
;

isConst
	: Const
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

AddressQuant
	: '*'
	| '&'
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

Extern
	: 'extern'
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
	: DIGIT
	| Boolean
	| '"' Schar* '"'
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
	: ~[a-zA-Z_0-9\n\r \t]
;

Skiped
	: (SpecalSymbol | SIGN) -> skip
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