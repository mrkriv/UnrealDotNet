grammar UHeader;

/*Basic concepts*/
translationUnit
	: topLevelOutClass* EOF
;

topLevelOutClass
	: classPreDeclaration
	| classDeclaration
	| uDefine
	| preprocessDerective
;

topLevelInClass
	: accessSpecifierContainer
	| method
	| uDefine
	| preprocessDerective
;

/* Class */
classPreDeclaration
	: classType className ';'
;

classDeclaration
	: classType className classParentList? '{' classBody '}' ';'
;

classType
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
	: topLevelInClass*
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
	: type methodName '(' methodParamsList? ')' Const? (methodBody | ';')
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
	: methodBody?
;

methodName
	: Identifier
;

type
	: Const? (Class|Struct)? AddressQuant* Identifier AddressQuant*
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

SingleLineDerective
	: '#' ~[\n]+
;

MultiLineDerective
	: '#' (~[\n]*? '\\' '\r'? '\n')+ ~[\n]+
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
	| Simpleescapesequence
;

fragment
Boolean
	: 'true' | 'false'
;

fragment
Simpleescapesequence
	: '\\\''
	| '\\"'
	| '\\?'
	| '\\\\'
	| '\\a'
	| '\\b'
	| '\\f'
	| '\\n'
	| '\\r'
	| '\\t'
	| '\\v'
;

Whitespace
	: [ \t]+ -> skip
;

Newline
	: (
		'\r' '\n'?
		| '\n'
	) -> skip
;

BlockComment
	: '/*' .*? '*/' -> skip
;

LineComment
	: '//' ~[\r\n]* -> skip
;