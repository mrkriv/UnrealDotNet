// Generated from C:/Users/mrkriv/Documents/Unreal Projects/UnrealDotNet/Plugins/UnrealDotNet/Source/CodeGenerator/UHeader\UHeader.g4 by ANTLR 4.7.2
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class UHeaderParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, PtrQuant=11, RefQuant=12, Private=13, Protected=14, Public=15, 
		Inline=16, Explicit=17, Virtual=18, Class=19, Struct=20, Enum=21, Union=22, 
		Const=23, Final=24, Static=25, Extern=26, Mutable=27, Override=28, Template=29, 
		Friend=30, Operator=31, Typedef=32, Constexpr=33, BracketsOpen=34, BracketsClose=35, 
		Tilda=36, Delete=37, GCC_ALIGN=38, Namespace=39, Typename=40, DotDot=41, 
		SingleLineDerective=42, MultiLineDerective=43, Identifier=44, Literal=45, 
		SpecalSymbol=46, Whitespace=47, Newline=48, ExportComment=49, BlockComment=50, 
		LineComment=51;
	public static final int
		RULE_translationUnit = 0, RULE_namespaceUnit = 1, RULE_namespaceName = 2, 
		RULE_typePreDeclaration = 3, RULE_classDeclaration = 4, RULE_classOrStructOrEnum = 5, 
		RULE_classOrStruct = 6, RULE_classParentList = 7, RULE_classAlignDefine = 8, 
		RULE_classAlignValue = 9, RULE_classBody = 10, RULE_comment = 11, RULE_enumDeclaration = 12, 
		RULE_enumParent = 13, RULE_enumElementList = 14, RULE_enumElement = 15, 
		RULE_enumElementName = 16, RULE_unionDeclaration = 17, RULE_typeDefine = 18, 
		RULE_uDefine = 19, RULE_uDefineName = 20, RULE_uMeta = 21, RULE_uMetaParametrList = 22, 
		RULE_uMetaParametr = 23, RULE_uMetaParamKey = 24, RULE_uMetaParamValue = 25, 
		RULE_undefineBlock = 26, RULE_undefineContent = 27, RULE_constructor = 28, 
		RULE_constructorInitializerList = 29, RULE_constructorInitializer = 30, 
		RULE_method = 31, RULE_methodParamsList = 32, RULE_methodParametr = 33, 
		RULE_methodParametrName = 34, RULE_methodParametrDefaultValue = 35, RULE_value = 36, 
		RULE_methodBody = 37, RULE_methodBodyContent = 38, RULE_methodName = 39, 
		RULE_methodOperator = 40, RULE_property = 41, RULE_propertyName = 42, 
		RULE_propertyDefaultValue = 43, RULE_type = 44, RULE_isPtrQuant = 45, 
		RULE_isRefQuant = 46, RULE_typeName = 47, RULE_isVirtual = 48, RULE_isOverride = 49, 
		RULE_isConst = 50, RULE_isStatic = 51, RULE_isFriend = 52, RULE_isFinal = 53, 
		RULE_isDestructor = 54, RULE_isDelete = 55, RULE_isArray = 56, RULE_arrayLen = 57, 
		RULE_templateDefine = 58, RULE_templateParamList = 59, RULE_templateParam = 60, 
		RULE_templateParamType = 61, RULE_templateParamLiter = 62, RULE_accessSpecifierContainer = 63, 
		RULE_accessSpecifier = 64, RULE_preprocessDerective = 65;
	private static String[] makeRuleNames() {
		return new String[] {
			"translationUnit", "namespaceUnit", "namespaceName", "typePreDeclaration", 
			"classDeclaration", "classOrStructOrEnum", "classOrStruct", "classParentList", 
			"classAlignDefine", "classAlignValue", "classBody", "comment", "enumDeclaration", 
			"enumParent", "enumElementList", "enumElement", "enumElementName", "unionDeclaration", 
			"typeDefine", "uDefine", "uDefineName", "uMeta", "uMetaParametrList", 
			"uMetaParametr", "uMetaParamKey", "uMetaParamValue", "undefineBlock", 
			"undefineContent", "constructor", "constructorInitializerList", "constructorInitializer", 
			"method", "methodParamsList", "methodParametr", "methodParametrName", 
			"methodParametrDefaultValue", "value", "methodBody", "methodBodyContent", 
			"methodName", "methodOperator", "property", "propertyName", "propertyDefaultValue", 
			"type", "isPtrQuant", "isRefQuant", "typeName", "isVirtual", "isOverride", 
			"isConst", "isStatic", "isFriend", "isFinal", "isDestructor", "isDelete", 
			"isArray", "arrayLen", "templateDefine", "templateParamList", "templateParam", 
			"templateParamType", "templateParamLiter", "accessSpecifierContainer", 
			"accessSpecifier", "preprocessDerective"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "';'", "','", "'('", "')'", "'='", "'|'", "'<'", "'>'", "'['", 
			"']'", "'*'", "'&'", "'private'", "'protected'", "'public'", null, "'explicit'", 
			"'virtual'", "'class'", "'struct'", "'enum'", "'union'", "'const'", "'final'", 
			"'static'", "'extern'", "'mutable'", "'override'", "'template'", "'friend'", 
			"'operator'", "'typedef'", "'CONSTEXPR'", "'{'", "'}'", "'~'", "'delete'", 
			"'GCC_ALIGN'", "'namespace'", "'typename'", "':'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, "PtrQuant", 
			"RefQuant", "Private", "Protected", "Public", "Inline", "Explicit", "Virtual", 
			"Class", "Struct", "Enum", "Union", "Const", "Final", "Static", "Extern", 
			"Mutable", "Override", "Template", "Friend", "Operator", "Typedef", "Constexpr", 
			"BracketsOpen", "BracketsClose", "Tilda", "Delete", "GCC_ALIGN", "Namespace", 
			"Typename", "DotDot", "SingleLineDerective", "MultiLineDerective", "Identifier", 
			"Literal", "SpecalSymbol", "Whitespace", "Newline", "ExportComment", 
			"BlockComment", "LineComment"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "UHeader.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public UHeaderParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class TranslationUnitContext extends ParserRuleContext {
		public List<TypePreDeclarationContext> typePreDeclaration() {
			return getRuleContexts(TypePreDeclarationContext.class);
		}
		public TypePreDeclarationContext typePreDeclaration(int i) {
			return getRuleContext(TypePreDeclarationContext.class,i);
		}
		public List<MethodContext> method() {
			return getRuleContexts(MethodContext.class);
		}
		public MethodContext method(int i) {
			return getRuleContext(MethodContext.class,i);
		}
		public List<ClassDeclarationContext> classDeclaration() {
			return getRuleContexts(ClassDeclarationContext.class);
		}
		public ClassDeclarationContext classDeclaration(int i) {
			return getRuleContext(ClassDeclarationContext.class,i);
		}
		public List<EnumDeclarationContext> enumDeclaration() {
			return getRuleContexts(EnumDeclarationContext.class);
		}
		public EnumDeclarationContext enumDeclaration(int i) {
			return getRuleContext(EnumDeclarationContext.class,i);
		}
		public List<PropertyContext> property() {
			return getRuleContexts(PropertyContext.class);
		}
		public PropertyContext property(int i) {
			return getRuleContext(PropertyContext.class,i);
		}
		public List<TypeDefineContext> typeDefine() {
			return getRuleContexts(TypeDefineContext.class);
		}
		public TypeDefineContext typeDefine(int i) {
			return getRuleContext(TypeDefineContext.class,i);
		}
		public List<UDefineContext> uDefine() {
			return getRuleContexts(UDefineContext.class);
		}
		public UDefineContext uDefine(int i) {
			return getRuleContext(UDefineContext.class,i);
		}
		public List<NamespaceUnitContext> namespaceUnit() {
			return getRuleContexts(NamespaceUnitContext.class);
		}
		public NamespaceUnitContext namespaceUnit(int i) {
			return getRuleContext(NamespaceUnitContext.class,i);
		}
		public List<CommentContext> comment() {
			return getRuleContexts(CommentContext.class);
		}
		public CommentContext comment(int i) {
			return getRuleContext(CommentContext.class,i);
		}
		public List<PreprocessDerectiveContext> preprocessDerective() {
			return getRuleContexts(PreprocessDerectiveContext.class);
		}
		public PreprocessDerectiveContext preprocessDerective(int i) {
			return getRuleContext(PreprocessDerectiveContext.class,i);
		}
		public TranslationUnitContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_translationUnit; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTranslationUnit(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TranslationUnitContext translationUnit() throws RecognitionException {
		TranslationUnitContext _localctx = new TranslationUnitContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_translationUnit);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(144);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Inline) | (1L << Virtual) | (1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Const) | (1L << Static) | (1L << Extern) | (1L << Mutable) | (1L << Template) | (1L << Friend) | (1L << Typedef) | (1L << Constexpr) | (1L << Namespace) | (1L << SingleLineDerective) | (1L << MultiLineDerective) | (1L << Identifier) | (1L << ExportComment))) != 0)) {
				{
				setState(142);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,0,_ctx) ) {
				case 1:
					{
					setState(132);
					typePreDeclaration();
					}
					break;
				case 2:
					{
					setState(133);
					method();
					}
					break;
				case 3:
					{
					setState(134);
					classDeclaration();
					}
					break;
				case 4:
					{
					setState(135);
					enumDeclaration();
					}
					break;
				case 5:
					{
					setState(136);
					property();
					}
					break;
				case 6:
					{
					setState(137);
					typeDefine();
					}
					break;
				case 7:
					{
					setState(138);
					uDefine();
					}
					break;
				case 8:
					{
					setState(139);
					namespaceUnit();
					}
					break;
				case 9:
					{
					setState(140);
					comment();
					}
					break;
				case 10:
					{
					setState(141);
					preprocessDerective();
					}
					break;
				}
				}
				setState(146);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class NamespaceUnitContext extends ParserRuleContext {
		public TerminalNode Namespace() { return getToken(UHeaderParser.Namespace, 0); }
		public NamespaceNameContext namespaceName() {
			return getRuleContext(NamespaceNameContext.class,0);
		}
		public TerminalNode BracketsOpen() { return getToken(UHeaderParser.BracketsOpen, 0); }
		public TranslationUnitContext translationUnit() {
			return getRuleContext(TranslationUnitContext.class,0);
		}
		public TerminalNode BracketsClose() { return getToken(UHeaderParser.BracketsClose, 0); }
		public NamespaceUnitContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_namespaceUnit; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitNamespaceUnit(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NamespaceUnitContext namespaceUnit() throws RecognitionException {
		NamespaceUnitContext _localctx = new NamespaceUnitContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_namespaceUnit);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(147);
			match(Namespace);
			setState(148);
			namespaceName();
			setState(149);
			match(BracketsOpen);
			setState(150);
			translationUnit();
			setState(151);
			match(BracketsClose);
			setState(153);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0) {
				{
				setState(152);
				match(T__0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class NamespaceNameContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public NamespaceNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_namespaceName; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitNamespaceName(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NamespaceNameContext namespaceName() throws RecognitionException {
		NamespaceNameContext _localctx = new NamespaceNameContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_namespaceName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(155);
			match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TypePreDeclarationContext extends ParserRuleContext {
		public ClassOrStructOrEnumContext classOrStructOrEnum() {
			return getRuleContext(ClassOrStructOrEnumContext.class,0);
		}
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public TemplateDefineContext templateDefine() {
			return getRuleContext(TemplateDefineContext.class,0);
		}
		public IsFriendContext isFriend() {
			return getRuleContext(IsFriendContext.class,0);
		}
		public TypePreDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_typePreDeclaration; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTypePreDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TypePreDeclarationContext typePreDeclaration() throws RecognitionException {
		TypePreDeclarationContext _localctx = new TypePreDeclarationContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_typePreDeclaration);
		int _la;
		try {
			setState(171);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Class:
			case Struct:
			case Enum:
			case Template:
				enterOuterAlt(_localctx, 1);
				{
				setState(158);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==Template) {
					{
					setState(157);
					templateDefine();
					}
				}

				setState(160);
				classOrStructOrEnum();
				setState(161);
				type();
				setState(162);
				match(T__0);
				}
				break;
			case Friend:
				enterOuterAlt(_localctx, 2);
				{
				setState(164);
				isFriend();
				setState(166);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
				case 1:
					{
					setState(165);
					classOrStructOrEnum();
					}
					break;
				}
				setState(168);
				type();
				setState(169);
				match(T__0);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ClassDeclarationContext extends ParserRuleContext {
		public ClassOrStructContext classOrStruct() {
			return getRuleContext(ClassOrStructContext.class,0);
		}
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public TerminalNode BracketsOpen() { return getToken(UHeaderParser.BracketsOpen, 0); }
		public ClassBodyContext classBody() {
			return getRuleContext(ClassBodyContext.class,0);
		}
		public TerminalNode BracketsClose() { return getToken(UHeaderParser.BracketsClose, 0); }
		public TemplateDefineContext templateDefine() {
			return getRuleContext(TemplateDefineContext.class,0);
		}
		public IsFinalContext isFinal() {
			return getRuleContext(IsFinalContext.class,0);
		}
		public TerminalNode DotDot() { return getToken(UHeaderParser.DotDot, 0); }
		public ClassParentListContext classParentList() {
			return getRuleContext(ClassParentListContext.class,0);
		}
		public ClassAlignDefineContext classAlignDefine() {
			return getRuleContext(ClassAlignDefineContext.class,0);
		}
		public ClassDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_classDeclaration; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitClassDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ClassDeclarationContext classDeclaration() throws RecognitionException {
		ClassDeclarationContext _localctx = new ClassDeclarationContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_classDeclaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(174);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Template) {
				{
				setState(173);
				templateDefine();
				}
			}

			setState(176);
			classOrStruct();
			setState(177);
			type();
			setState(179);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Final) {
				{
				setState(178);
				isFinal();
				}
			}

			setState(183);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==DotDot) {
				{
				setState(181);
				match(DotDot);
				setState(182);
				classParentList();
				}
			}

			setState(185);
			match(BracketsOpen);
			setState(186);
			classBody();
			setState(187);
			match(BracketsClose);
			setState(189);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==GCC_ALIGN) {
				{
				setState(188);
				classAlignDefine();
				}
			}

			setState(191);
			match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ClassOrStructOrEnumContext extends ParserRuleContext {
		public TerminalNode Class() { return getToken(UHeaderParser.Class, 0); }
		public TerminalNode Struct() { return getToken(UHeaderParser.Struct, 0); }
		public TerminalNode Enum() { return getToken(UHeaderParser.Enum, 0); }
		public ClassOrStructOrEnumContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_classOrStructOrEnum; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitClassOrStructOrEnum(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ClassOrStructOrEnumContext classOrStructOrEnum() throws RecognitionException {
		ClassOrStructOrEnumContext _localctx = new ClassOrStructOrEnumContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_classOrStructOrEnum);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(193);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Class) | (1L << Struct) | (1L << Enum))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ClassOrStructContext extends ParserRuleContext {
		public TerminalNode Class() { return getToken(UHeaderParser.Class, 0); }
		public TerminalNode Struct() { return getToken(UHeaderParser.Struct, 0); }
		public ClassOrStructContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_classOrStruct; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitClassOrStruct(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ClassOrStructContext classOrStruct() throws RecognitionException {
		ClassOrStructContext _localctx = new ClassOrStructContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_classOrStruct);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(195);
			_la = _input.LA(1);
			if ( !(_la==Class || _la==Struct) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ClassParentListContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public AccessSpecifierContext accessSpecifier() {
			return getRuleContext(AccessSpecifierContext.class,0);
		}
		public ClassParentListContext classParentList() {
			return getRuleContext(ClassParentListContext.class,0);
		}
		public ClassParentListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_classParentList; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitClassParentList(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ClassParentListContext classParentList() throws RecognitionException {
		ClassParentListContext _localctx = new ClassParentListContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_classParentList);
		int _la;
		try {
			setState(208);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,12,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(198);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Private) | (1L << Protected) | (1L << Public))) != 0)) {
					{
					setState(197);
					accessSpecifier();
					}
				}

				setState(200);
				type();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(202);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Private) | (1L << Protected) | (1L << Public))) != 0)) {
					{
					setState(201);
					accessSpecifier();
					}
				}

				setState(204);
				type();
				setState(205);
				match(T__1);
				setState(206);
				classParentList();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ClassAlignDefineContext extends ParserRuleContext {
		public TerminalNode GCC_ALIGN() { return getToken(UHeaderParser.GCC_ALIGN, 0); }
		public ClassAlignValueContext classAlignValue() {
			return getRuleContext(ClassAlignValueContext.class,0);
		}
		public ClassAlignDefineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_classAlignDefine; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitClassAlignDefine(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ClassAlignDefineContext classAlignDefine() throws RecognitionException {
		ClassAlignDefineContext _localctx = new ClassAlignDefineContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_classAlignDefine);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(210);
			match(GCC_ALIGN);
			setState(211);
			match(T__2);
			setState(212);
			classAlignValue();
			setState(213);
			match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ClassAlignValueContext extends ParserRuleContext {
		public List<TerminalNode> Literal() { return getTokens(UHeaderParser.Literal); }
		public TerminalNode Literal(int i) {
			return getToken(UHeaderParser.Literal, i);
		}
		public ClassAlignValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_classAlignValue; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitClassAlignValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ClassAlignValueContext classAlignValue() throws RecognitionException {
		ClassAlignValueContext _localctx = new ClassAlignValueContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_classAlignValue);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(216); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(215);
				match(Literal);
				}
				}
				setState(218); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==Literal );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ClassBodyContext extends ParserRuleContext {
		public List<AccessSpecifierContainerContext> accessSpecifierContainer() {
			return getRuleContexts(AccessSpecifierContainerContext.class);
		}
		public AccessSpecifierContainerContext accessSpecifierContainer(int i) {
			return getRuleContext(AccessSpecifierContainerContext.class,i);
		}
		public List<MethodContext> method() {
			return getRuleContexts(MethodContext.class);
		}
		public MethodContext method(int i) {
			return getRuleContext(MethodContext.class,i);
		}
		public List<ConstructorContext> constructor() {
			return getRuleContexts(ConstructorContext.class);
		}
		public ConstructorContext constructor(int i) {
			return getRuleContext(ConstructorContext.class,i);
		}
		public List<PropertyContext> property() {
			return getRuleContexts(PropertyContext.class);
		}
		public PropertyContext property(int i) {
			return getRuleContext(PropertyContext.class,i);
		}
		public List<UDefineContext> uDefine() {
			return getRuleContexts(UDefineContext.class);
		}
		public UDefineContext uDefine(int i) {
			return getRuleContext(UDefineContext.class,i);
		}
		public List<TypeDefineContext> typeDefine() {
			return getRuleContexts(TypeDefineContext.class);
		}
		public TypeDefineContext typeDefine(int i) {
			return getRuleContext(TypeDefineContext.class,i);
		}
		public List<ClassDeclarationContext> classDeclaration() {
			return getRuleContexts(ClassDeclarationContext.class);
		}
		public ClassDeclarationContext classDeclaration(int i) {
			return getRuleContext(ClassDeclarationContext.class,i);
		}
		public List<EnumDeclarationContext> enumDeclaration() {
			return getRuleContexts(EnumDeclarationContext.class);
		}
		public EnumDeclarationContext enumDeclaration(int i) {
			return getRuleContext(EnumDeclarationContext.class,i);
		}
		public List<TypePreDeclarationContext> typePreDeclaration() {
			return getRuleContexts(TypePreDeclarationContext.class);
		}
		public TypePreDeclarationContext typePreDeclaration(int i) {
			return getRuleContext(TypePreDeclarationContext.class,i);
		}
		public List<UnionDeclarationContext> unionDeclaration() {
			return getRuleContexts(UnionDeclarationContext.class);
		}
		public UnionDeclarationContext unionDeclaration(int i) {
			return getRuleContext(UnionDeclarationContext.class,i);
		}
		public List<CommentContext> comment() {
			return getRuleContexts(CommentContext.class);
		}
		public CommentContext comment(int i) {
			return getRuleContext(CommentContext.class,i);
		}
		public List<PreprocessDerectiveContext> preprocessDerective() {
			return getRuleContexts(PreprocessDerectiveContext.class);
		}
		public PreprocessDerectiveContext preprocessDerective(int i) {
			return getRuleContext(PreprocessDerectiveContext.class,i);
		}
		public ClassBodyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_classBody; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitClassBody(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ClassBodyContext classBody() throws RecognitionException {
		ClassBodyContext _localctx = new ClassBodyContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_classBody);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(234);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Private) | (1L << Protected) | (1L << Public) | (1L << Inline) | (1L << Explicit) | (1L << Virtual) | (1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Union) | (1L << Const) | (1L << Static) | (1L << Extern) | (1L << Mutable) | (1L << Template) | (1L << Friend) | (1L << Operator) | (1L << Typedef) | (1L << Constexpr) | (1L << Tilda) | (1L << SingleLineDerective) | (1L << MultiLineDerective) | (1L << Identifier) | (1L << ExportComment))) != 0)) {
				{
				setState(232);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,14,_ctx) ) {
				case 1:
					{
					setState(220);
					accessSpecifierContainer();
					}
					break;
				case 2:
					{
					setState(221);
					method();
					}
					break;
				case 3:
					{
					setState(222);
					constructor();
					}
					break;
				case 4:
					{
					setState(223);
					property();
					}
					break;
				case 5:
					{
					setState(224);
					uDefine();
					}
					break;
				case 6:
					{
					setState(225);
					typeDefine();
					}
					break;
				case 7:
					{
					setState(226);
					classDeclaration();
					}
					break;
				case 8:
					{
					setState(227);
					enumDeclaration();
					}
					break;
				case 9:
					{
					setState(228);
					typePreDeclaration();
					}
					break;
				case 10:
					{
					setState(229);
					unionDeclaration();
					}
					break;
				case 11:
					{
					setState(230);
					comment();
					}
					break;
				case 12:
					{
					setState(231);
					preprocessDerective();
					}
					break;
				}
				}
				setState(236);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class CommentContext extends ParserRuleContext {
		public TerminalNode ExportComment() { return getToken(UHeaderParser.ExportComment, 0); }
		public CommentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_comment; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitComment(this);
			else return visitor.visitChildren(this);
		}
	}

	public final CommentContext comment() throws RecognitionException {
		CommentContext _localctx = new CommentContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_comment);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(237);
			match(ExportComment);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EnumDeclarationContext extends ParserRuleContext {
		public TerminalNode Enum() { return getToken(UHeaderParser.Enum, 0); }
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public TerminalNode Class() { return getToken(UHeaderParser.Class, 0); }
		public EnumParentContext enumParent() {
			return getRuleContext(EnumParentContext.class,0);
		}
		public TerminalNode BracketsOpen() { return getToken(UHeaderParser.BracketsOpen, 0); }
		public EnumElementListContext enumElementList() {
			return getRuleContext(EnumElementListContext.class,0);
		}
		public TerminalNode BracketsClose() { return getToken(UHeaderParser.BracketsClose, 0); }
		public EnumDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enumDeclaration; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitEnumDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EnumDeclarationContext enumDeclaration() throws RecognitionException {
		EnumDeclarationContext _localctx = new EnumDeclarationContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_enumDeclaration);
		int _la;
		try {
			setState(261);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,19,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(239);
				match(Enum);
				setState(241);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,16,_ctx) ) {
				case 1:
					{
					setState(240);
					match(Class);
					}
					break;
				}
				setState(243);
				type();
				setState(245);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==DotDot) {
					{
					setState(244);
					enumParent();
					}
				}

				setState(251);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==BracketsOpen) {
					{
					setState(247);
					match(BracketsOpen);
					setState(248);
					enumElementList();
					setState(249);
					match(BracketsClose);
					}
				}

				setState(253);
				match(T__0);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(255);
				match(Enum);
				setState(256);
				match(BracketsOpen);
				setState(257);
				enumElementList();
				setState(258);
				match(BracketsClose);
				setState(259);
				match(T__0);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EnumParentContext extends ParserRuleContext {
		public TerminalNode DotDot() { return getToken(UHeaderParser.DotDot, 0); }
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public EnumParentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enumParent; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitEnumParent(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EnumParentContext enumParent() throws RecognitionException {
		EnumParentContext _localctx = new EnumParentContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_enumParent);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(263);
			match(DotDot);
			setState(264);
			type();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EnumElementListContext extends ParserRuleContext {
		public EnumElementContext enumElement() {
			return getRuleContext(EnumElementContext.class,0);
		}
		public EnumElementListContext enumElementList() {
			return getRuleContext(EnumElementListContext.class,0);
		}
		public EnumElementListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enumElementList; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitEnumElementList(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EnumElementListContext enumElementList() throws RecognitionException {
		EnumElementListContext _localctx = new EnumElementListContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_enumElementList);
		try {
			setState(273);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,21,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(266);
				enumElement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(267);
				enumElement();
				setState(268);
				match(T__1);
				setState(269);
				enumElementList();
				setState(271);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,20,_ctx) ) {
				case 1:
					{
					setState(270);
					match(T__1);
					}
					break;
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EnumElementContext extends ParserRuleContext {
		public EnumElementNameContext enumElementName() {
			return getRuleContext(EnumElementNameContext.class,0);
		}
		public List<CommentContext> comment() {
			return getRuleContexts(CommentContext.class);
		}
		public CommentContext comment(int i) {
			return getRuleContext(CommentContext.class,i);
		}
		public PropertyDefaultValueContext propertyDefaultValue() {
			return getRuleContext(PropertyDefaultValueContext.class,0);
		}
		public UDefineContext uDefine() {
			return getRuleContext(UDefineContext.class,0);
		}
		public TerminalNode DotDot() { return getToken(UHeaderParser.DotDot, 0); }
		public EnumElementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enumElement; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitEnumElement(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EnumElementContext enumElement() throws RecognitionException {
		EnumElementContext _localctx = new EnumElementContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_enumElement);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(278);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==ExportComment) {
				{
				{
				setState(275);
				comment();
				}
				}
				setState(280);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(281);
			enumElementName();
			setState(284);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__4 || _la==DotDot) {
				{
				setState(282);
				_la = _input.LA(1);
				if ( !(_la==T__4 || _la==DotDot) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(283);
				propertyDefaultValue();
				}
			}

			setState(287);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Identifier) {
				{
				setState(286);
				uDefine();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EnumElementNameContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public EnumElementNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enumElementName; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitEnumElementName(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EnumElementNameContext enumElementName() throws RecognitionException {
		EnumElementNameContext _localctx = new EnumElementNameContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_enumElementName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(289);
			match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UnionDeclarationContext extends ParserRuleContext {
		public TerminalNode Union() { return getToken(UHeaderParser.Union, 0); }
		public MethodBodyContext methodBody() {
			return getRuleContext(MethodBodyContext.class,0);
		}
		public UnionDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_unionDeclaration; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUnionDeclaration(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UnionDeclarationContext unionDeclaration() throws RecognitionException {
		UnionDeclarationContext _localctx = new UnionDeclarationContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_unionDeclaration);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(291);
			match(Union);
			setState(292);
			methodBody();
			setState(294);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0) {
				{
				setState(293);
				match(T__0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TypeDefineContext extends ParserRuleContext {
		public TerminalNode Typedef() { return getToken(UHeaderParser.Typedef, 0); }
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public TypeNameContext typeName() {
			return getRuleContext(TypeNameContext.class,0);
		}
		public TypeDefineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_typeDefine; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTypeDefine(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TypeDefineContext typeDefine() throws RecognitionException {
		TypeDefineContext _localctx = new TypeDefineContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_typeDefine);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(296);
			match(Typedef);
			setState(297);
			type();
			setState(298);
			typeName();
			setState(299);
			match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UDefineContext extends ParserRuleContext {
		public UDefineNameContext uDefineName() {
			return getRuleContext(UDefineNameContext.class,0);
		}
		public UMetaContext uMeta() {
			return getRuleContext(UMetaContext.class,0);
		}
		public UDefineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_uDefine; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUDefine(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UDefineContext uDefine() throws RecognitionException {
		UDefineContext _localctx = new UDefineContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_uDefine);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(301);
			uDefineName();
			setState(302);
			match(T__2);
			setState(303);
			uMeta();
			setState(304);
			match(T__3);
			setState(306);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0) {
				{
				setState(305);
				match(T__0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UDefineNameContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public UDefineNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_uDefineName; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUDefineName(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UDefineNameContext uDefineName() throws RecognitionException {
		UDefineNameContext _localctx = new UDefineNameContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_uDefineName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(308);
			match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UMetaContext extends ParserRuleContext {
		public UMetaParametrListContext uMetaParametrList() {
			return getRuleContext(UMetaParametrListContext.class,0);
		}
		public UMetaContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_uMeta; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUMeta(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UMetaContext uMeta() throws RecognitionException {
		UMetaContext _localctx = new UMetaContext(_ctx, getState());
		enterRule(_localctx, 42, RULE_uMeta);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(311);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Const) | (1L << Identifier) | (1L << Literal))) != 0)) {
				{
				setState(310);
				uMetaParametrList();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UMetaParametrListContext extends ParserRuleContext {
		public UMetaParametrContext uMetaParametr() {
			return getRuleContext(UMetaParametrContext.class,0);
		}
		public UMetaParametrListContext uMetaParametrList() {
			return getRuleContext(UMetaParametrListContext.class,0);
		}
		public UMetaParametrListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_uMetaParametrList; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUMetaParametrList(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UMetaParametrListContext uMetaParametrList() throws RecognitionException {
		UMetaParametrListContext _localctx = new UMetaParametrListContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_uMetaParametrList);
		try {
			setState(318);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,28,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(313);
				uMetaParametr();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(314);
				uMetaParametr();
				setState(315);
				match(T__1);
				setState(316);
				uMetaParametrList();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UMetaParametrContext extends ParserRuleContext {
		public UMetaParamKeyContext uMetaParamKey() {
			return getRuleContext(UMetaParamKeyContext.class,0);
		}
		public UMetaParamValueContext uMetaParamValue() {
			return getRuleContext(UMetaParamValueContext.class,0);
		}
		public UMetaParametrListContext uMetaParametrList() {
			return getRuleContext(UMetaParametrListContext.class,0);
		}
		public UMetaParametrContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_uMetaParametr; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUMetaParametr(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UMetaParametrContext uMetaParametr() throws RecognitionException {
		UMetaParametrContext _localctx = new UMetaParametrContext(_ctx, getState());
		enterRule(_localctx, 46, RULE_uMetaParametr);
		try {
			setState(331);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,29,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(320);
				uMetaParamKey(0);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(321);
				uMetaParamKey(0);
				setState(322);
				match(T__4);
				setState(323);
				uMetaParamValue();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(325);
				uMetaParamKey(0);
				setState(326);
				match(T__4);
				setState(327);
				match(T__2);
				setState(328);
				uMetaParametrList();
				setState(329);
				match(T__3);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UMetaParamKeyContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public ValueContext value() {
			return getRuleContext(ValueContext.class,0);
		}
		public List<UMetaParamKeyContext> uMetaParamKey() {
			return getRuleContexts(UMetaParamKeyContext.class);
		}
		public UMetaParamKeyContext uMetaParamKey(int i) {
			return getRuleContext(UMetaParamKeyContext.class,i);
		}
		public UMetaParamKeyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_uMetaParamKey; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUMetaParamKey(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UMetaParamKeyContext uMetaParamKey() throws RecognitionException {
		return uMetaParamKey(0);
	}

	private UMetaParamKeyContext uMetaParamKey(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		UMetaParamKeyContext _localctx = new UMetaParamKeyContext(_ctx, _parentState);
		UMetaParamKeyContext _prevctx = _localctx;
		int _startState = 48;
		enterRecursionRule(_localctx, 48, RULE_uMetaParamKey, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(336);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,30,_ctx) ) {
			case 1:
				{
				setState(334);
				type();
				}
				break;
			case 2:
				{
				setState(335);
				value();
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(343);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,31,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new UMetaParamKeyContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_uMetaParamKey);
					setState(338);
					if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
					setState(339);
					match(T__5);
					setState(340);
					uMetaParamKey(2);
					}
					} 
				}
				setState(345);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,31,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public static class UMetaParamValueContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public ValueContext value() {
			return getRuleContext(ValueContext.class,0);
		}
		public UMetaParamValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_uMetaParamValue; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUMetaParamValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UMetaParamValueContext uMetaParamValue() throws RecognitionException {
		UMetaParamValueContext _localctx = new UMetaParamValueContext(_ctx, getState());
		enterRule(_localctx, 50, RULE_uMetaParamValue);
		try {
			setState(348);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,32,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(346);
				type();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(347);
				value();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UndefineBlockContext extends ParserRuleContext {
		public UndefineContentContext undefineContent() {
			return getRuleContext(UndefineContentContext.class,0);
		}
		public UndefineBlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_undefineBlock; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUndefineBlock(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UndefineBlockContext undefineBlock() throws RecognitionException {
		UndefineBlockContext _localctx = new UndefineBlockContext(_ctx, getState());
		enterRule(_localctx, 52, RULE_undefineBlock);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(350);
			match(T__2);
			setState(351);
			undefineContent();
			setState(352);
			match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class UndefineContentContext extends ParserRuleContext {
		public List<UndefineContentContext> undefineContent() {
			return getRuleContexts(UndefineContentContext.class);
		}
		public UndefineContentContext undefineContent(int i) {
			return getRuleContext(UndefineContentContext.class,i);
		}
		public UndefineContentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_undefineContent; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitUndefineContent(this);
			else return visitor.visitChildren(this);
		}
	}

	public final UndefineContentContext undefineContent() throws RecognitionException {
		UndefineContentContext _localctx = new UndefineContentContext(_ctx, getState());
		enterRule(_localctx, 54, RULE_undefineContent);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(357);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << PtrQuant) | (1L << RefQuant) | (1L << Private) | (1L << Protected) | (1L << Public) | (1L << Inline) | (1L << Explicit) | (1L << Virtual) | (1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Union) | (1L << Const) | (1L << Final) | (1L << Static) | (1L << Extern) | (1L << Mutable) | (1L << Override) | (1L << Template) | (1L << Friend) | (1L << Operator) | (1L << Typedef) | (1L << Constexpr) | (1L << BracketsOpen) | (1L << BracketsClose) | (1L << Tilda) | (1L << Delete) | (1L << GCC_ALIGN) | (1L << Namespace) | (1L << Typename) | (1L << DotDot) | (1L << SingleLineDerective) | (1L << MultiLineDerective) | (1L << Identifier) | (1L << Literal) | (1L << SpecalSymbol) | (1L << Whitespace) | (1L << Newline) | (1L << ExportComment) | (1L << BlockComment) | (1L << LineComment))) != 0)) {
				{
				{
				setState(354);
				_la = _input.LA(1);
				if ( _la <= 0 || (_la==T__2 || _la==T__3) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				}
				}
				setState(359);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			{
			setState(365);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__2) {
				{
				setState(360);
				match(T__2);
				setState(361);
				undefineContent();
				setState(362);
				match(T__3);
				setState(363);
				undefineContent();
				}
			}

			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ConstructorContext extends ParserRuleContext {
		public MethodNameContext methodName() {
			return getRuleContext(MethodNameContext.class,0);
		}
		public List<TerminalNode> Explicit() { return getTokens(UHeaderParser.Explicit); }
		public TerminalNode Explicit(int i) {
			return getToken(UHeaderParser.Explicit, i);
		}
		public List<TerminalNode> Inline() { return getTokens(UHeaderParser.Inline); }
		public TerminalNode Inline(int i) {
			return getToken(UHeaderParser.Inline, i);
		}
		public List<IsVirtualContext> isVirtual() {
			return getRuleContexts(IsVirtualContext.class);
		}
		public IsVirtualContext isVirtual(int i) {
			return getRuleContext(IsVirtualContext.class,i);
		}
		public IsDestructorContext isDestructor() {
			return getRuleContext(IsDestructorContext.class,0);
		}
		public MethodParamsListContext methodParamsList() {
			return getRuleContext(MethodParamsListContext.class,0);
		}
		public IsConstContext isConst() {
			return getRuleContext(IsConstContext.class,0);
		}
		public TerminalNode DotDot() { return getToken(UHeaderParser.DotDot, 0); }
		public ConstructorInitializerListContext constructorInitializerList() {
			return getRuleContext(ConstructorInitializerListContext.class,0);
		}
		public MethodBodyContext methodBody() {
			return getRuleContext(MethodBodyContext.class,0);
		}
		public IsDeleteContext isDelete() {
			return getRuleContext(IsDeleteContext.class,0);
		}
		public ConstructorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constructor; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitConstructor(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ConstructorContext constructor() throws RecognitionException {
		ConstructorContext _localctx = new ConstructorContext(_ctx, getState());
		enterRule(_localctx, 56, RULE_constructor);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(372);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Inline) | (1L << Explicit) | (1L << Virtual))) != 0)) {
				{
				setState(370);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case Explicit:
					{
					setState(367);
					match(Explicit);
					}
					break;
				case Inline:
					{
					setState(368);
					match(Inline);
					}
					break;
				case Virtual:
					{
					setState(369);
					isVirtual();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(374);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(376);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Tilda) {
				{
				setState(375);
				isDestructor();
				}
			}

			setState(378);
			methodName();
			setState(379);
			match(T__2);
			setState(381);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Const) | (1L << Identifier))) != 0)) {
				{
				setState(380);
				methodParamsList();
				}
			}

			setState(383);
			match(T__3);
			setState(385);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,39,_ctx) ) {
			case 1:
				{
				setState(384);
				isConst();
				}
				break;
			}
			setState(389);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==DotDot) {
				{
				setState(387);
				match(DotDot);
				setState(388);
				constructorInitializerList();
				}
			}

			setState(393);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case BracketsOpen:
				{
				setState(391);
				methodBody();
				}
				break;
			case T__4:
				{
				setState(392);
				isDelete();
				}
				break;
			case T__0:
			case PtrQuant:
			case RefQuant:
			case Private:
			case Protected:
			case Public:
			case Inline:
			case Explicit:
			case Virtual:
			case Class:
			case Struct:
			case Enum:
			case Union:
			case Const:
			case Static:
			case Extern:
			case Mutable:
			case Template:
			case Friend:
			case Operator:
			case Typedef:
			case Constexpr:
			case BracketsClose:
			case Tilda:
			case SingleLineDerective:
			case MultiLineDerective:
			case Identifier:
			case ExportComment:
				break;
			default:
				break;
			}
			setState(396);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0) {
				{
				setState(395);
				match(T__0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ConstructorInitializerListContext extends ParserRuleContext {
		public ConstructorInitializerContext constructorInitializer() {
			return getRuleContext(ConstructorInitializerContext.class,0);
		}
		public ConstructorInitializerListContext constructorInitializerList() {
			return getRuleContext(ConstructorInitializerListContext.class,0);
		}
		public ConstructorInitializerListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constructorInitializerList; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitConstructorInitializerList(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ConstructorInitializerListContext constructorInitializerList() throws RecognitionException {
		ConstructorInitializerListContext _localctx = new ConstructorInitializerListContext(_ctx, getState());
		enterRule(_localctx, 58, RULE_constructorInitializerList);
		try {
			setState(403);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,43,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(398);
				constructorInitializer();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(399);
				constructorInitializer();
				setState(400);
				match(T__1);
				setState(401);
				constructorInitializerList();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ConstructorInitializerContext extends ParserRuleContext {
		public MethodParametrNameContext methodParametrName() {
			return getRuleContext(MethodParametrNameContext.class,0);
		}
		public MethodParametrDefaultValueContext methodParametrDefaultValue() {
			return getRuleContext(MethodParametrDefaultValueContext.class,0);
		}
		public UndefineBlockContext undefineBlock() {
			return getRuleContext(UndefineBlockContext.class,0);
		}
		public ConstructorInitializerContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constructorInitializer; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitConstructorInitializer(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ConstructorInitializerContext constructorInitializer() throws RecognitionException {
		ConstructorInitializerContext _localctx = new ConstructorInitializerContext(_ctx, getState());
		enterRule(_localctx, 60, RULE_constructorInitializer);
		int _la;
		try {
			setState(415);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,45,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(405);
				methodParametrName();
				setState(406);
				match(T__2);
				setState(408);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Identifier) | (1L << Literal))) != 0)) {
					{
					setState(407);
					methodParametrDefaultValue();
					}
				}

				setState(410);
				match(T__3);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(412);
				methodParametrName();
				setState(413);
				undefineBlock();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public MethodNameContext methodName() {
			return getRuleContext(MethodNameContext.class,0);
		}
		public TemplateDefineContext templateDefine() {
			return getRuleContext(TemplateDefineContext.class,0);
		}
		public List<TerminalNode> Constexpr() { return getTokens(UHeaderParser.Constexpr); }
		public TerminalNode Constexpr(int i) {
			return getToken(UHeaderParser.Constexpr, i);
		}
		public List<IsFriendContext> isFriend() {
			return getRuleContexts(IsFriendContext.class);
		}
		public IsFriendContext isFriend(int i) {
			return getRuleContext(IsFriendContext.class,i);
		}
		public List<TerminalNode> Inline() { return getTokens(UHeaderParser.Inline); }
		public TerminalNode Inline(int i) {
			return getToken(UHeaderParser.Inline, i);
		}
		public List<TerminalNode> Extern() { return getTokens(UHeaderParser.Extern); }
		public TerminalNode Extern(int i) {
			return getToken(UHeaderParser.Extern, i);
		}
		public List<IsStaticContext> isStatic() {
			return getRuleContexts(IsStaticContext.class);
		}
		public IsStaticContext isStatic(int i) {
			return getRuleContext(IsStaticContext.class,i);
		}
		public List<IsVirtualContext> isVirtual() {
			return getRuleContexts(IsVirtualContext.class);
		}
		public IsVirtualContext isVirtual(int i) {
			return getRuleContext(IsVirtualContext.class,i);
		}
		public MethodParamsListContext methodParamsList() {
			return getRuleContext(MethodParamsListContext.class,0);
		}
		public IsConstContext isConst() {
			return getRuleContext(IsConstContext.class,0);
		}
		public IsOverrideContext isOverride() {
			return getRuleContext(IsOverrideContext.class,0);
		}
		public IsFinalContext isFinal() {
			return getRuleContext(IsFinalContext.class,0);
		}
		public MethodBodyContext methodBody() {
			return getRuleContext(MethodBodyContext.class,0);
		}
		public IsDeleteContext isDelete() {
			return getRuleContext(IsDeleteContext.class,0);
		}
		public MethodContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_method; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethod(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodContext method() throws RecognitionException {
		MethodContext _localctx = new MethodContext(_ctx, getState());
		enterRule(_localctx, 62, RULE_method);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(418);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Template) {
				{
				setState(417);
				templateDefine();
				}
			}

			setState(428);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Inline) | (1L << Virtual) | (1L << Static) | (1L << Extern) | (1L << Friend) | (1L << Constexpr))) != 0)) {
				{
				setState(426);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case Constexpr:
					{
					setState(420);
					match(Constexpr);
					}
					break;
				case Friend:
					{
					setState(421);
					isFriend();
					}
					break;
				case Inline:
					{
					setState(422);
					match(Inline);
					}
					break;
				case Extern:
					{
					setState(423);
					match(Extern);
					}
					break;
				case Static:
					{
					setState(424);
					isStatic();
					}
					break;
				case Virtual:
					{
					setState(425);
					isVirtual();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(430);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(431);
			type();
			setState(432);
			methodName();
			setState(433);
			match(T__2);
			setState(435);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Const) | (1L << Identifier))) != 0)) {
				{
				setState(434);
				methodParamsList();
				}
			}

			setState(437);
			match(T__3);
			setState(439);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,50,_ctx) ) {
			case 1:
				{
				setState(438);
				isConst();
				}
				break;
			}
			setState(442);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Override) {
				{
				setState(441);
				isOverride();
				}
			}

			setState(445);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Final) {
				{
				setState(444);
				isFinal();
				}
			}

			setState(449);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case BracketsOpen:
				{
				setState(447);
				methodBody();
				}
				break;
			case T__4:
				{
				setState(448);
				isDelete();
				}
				break;
			case T__0:
			case PtrQuant:
			case RefQuant:
			case Private:
			case Protected:
			case Public:
			case Inline:
			case Explicit:
			case Virtual:
			case Class:
			case Struct:
			case Enum:
			case Union:
			case Const:
			case Static:
			case Extern:
			case Mutable:
			case Template:
			case Friend:
			case Operator:
			case Typedef:
			case Constexpr:
			case BracketsClose:
			case Tilda:
			case Namespace:
			case SingleLineDerective:
			case MultiLineDerective:
			case Identifier:
			case ExportComment:
				break;
			default:
				break;
			}
			setState(452);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0) {
				{
				setState(451);
				match(T__0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodParamsListContext extends ParserRuleContext {
		public MethodParametrContext methodParametr() {
			return getRuleContext(MethodParametrContext.class,0);
		}
		public MethodParamsListContext methodParamsList() {
			return getRuleContext(MethodParamsListContext.class,0);
		}
		public MethodParamsListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodParamsList; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethodParamsList(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodParamsListContext methodParamsList() throws RecognitionException {
		MethodParamsListContext _localctx = new MethodParamsListContext(_ctx, getState());
		enterRule(_localctx, 64, RULE_methodParamsList);
		try {
			setState(459);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,55,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(454);
				methodParametr();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(455);
				methodParametr();
				setState(456);
				match(T__1);
				setState(457);
				methodParamsList();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodParametrContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public MethodParametrNameContext methodParametrName() {
			return getRuleContext(MethodParametrNameContext.class,0);
		}
		public MethodParametrDefaultValueContext methodParametrDefaultValue() {
			return getRuleContext(MethodParametrDefaultValueContext.class,0);
		}
		public MethodParametrContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodParametr; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethodParametr(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodParametrContext methodParametr() throws RecognitionException {
		MethodParametrContext _localctx = new MethodParametrContext(_ctx, getState());
		enterRule(_localctx, 66, RULE_methodParametr);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(461);
			type();
			setState(467);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Identifier) {
				{
				setState(462);
				methodParametrName();
				setState(465);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__4) {
					{
					setState(463);
					match(T__4);
					setState(464);
					methodParametrDefaultValue();
					}
				}

				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodParametrNameContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public MethodParametrNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodParametrName; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethodParametrName(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodParametrNameContext methodParametrName() throws RecognitionException {
		MethodParametrNameContext _localctx = new MethodParametrNameContext(_ctx, getState());
		enterRule(_localctx, 68, RULE_methodParametrName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(469);
			match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodParametrDefaultValueContext extends ParserRuleContext {
		public List<ValueContext> value() {
			return getRuleContexts(ValueContext.class);
		}
		public ValueContext value(int i) {
			return getRuleContext(ValueContext.class,i);
		}
		public MethodParametrDefaultValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodParametrDefaultValue; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethodParametrDefaultValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodParametrDefaultValueContext methodParametrDefaultValue() throws RecognitionException {
		MethodParametrDefaultValueContext _localctx = new MethodParametrDefaultValueContext(_ctx, getState());
		enterRule(_localctx, 70, RULE_methodParametrDefaultValue);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(471);
			value();
			setState(476);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,58,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(472);
					match(T__1);
					setState(473);
					value();
					}
					} 
				}
				setState(478);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,58,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ValueContext extends ParserRuleContext {
		public List<TerminalNode> Identifier() { return getTokens(UHeaderParser.Identifier); }
		public TerminalNode Identifier(int i) {
			return getToken(UHeaderParser.Identifier, i);
		}
		public List<TerminalNode> Literal() { return getTokens(UHeaderParser.Literal); }
		public TerminalNode Literal(int i) {
			return getToken(UHeaderParser.Literal, i);
		}
		public IsPtrQuantContext isPtrQuant() {
			return getRuleContext(IsPtrQuantContext.class,0);
		}
		public IsRefQuantContext isRefQuant() {
			return getRuleContext(IsRefQuantContext.class,0);
		}
		public MethodParametrDefaultValueContext methodParametrDefaultValue() {
			return getRuleContext(MethodParametrDefaultValueContext.class,0);
		}
		public List<TerminalNode> SpecalSymbol() { return getTokens(UHeaderParser.SpecalSymbol); }
		public TerminalNode SpecalSymbol(int i) {
			return getToken(UHeaderParser.SpecalSymbol, i);
		}
		public List<TerminalNode> DotDot() { return getTokens(UHeaderParser.DotDot); }
		public TerminalNode DotDot(int i) {
			return getToken(UHeaderParser.DotDot, i);
		}
		public ValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_value; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ValueContext value() throws RecognitionException {
		ValueContext _localctx = new ValueContext(_ctx, getState());
		enterRule(_localctx, 72, RULE_value);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(481);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case PtrQuant:
				{
				setState(479);
				isPtrQuant();
				}
				break;
			case RefQuant:
				{
				setState(480);
				isRefQuant();
				}
				break;
			case Identifier:
			case Literal:
				break;
			default:
				break;
			}
			setState(483);
			_la = _input.LA(1);
			if ( !(_la==Identifier || _la==Literal) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			setState(490);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,61,_ctx) ) {
			case 1:
				{
				setState(485); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(484);
					_la = _input.LA(1);
					if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << DotDot) | (1L << SpecalSymbol))) != 0)) ) {
					_errHandler.recoverInline(this);
					}
					else {
						if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
						_errHandler.reportMatch(this);
						consume();
					}
					}
					}
					setState(487); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << DotDot) | (1L << SpecalSymbol))) != 0) );
				setState(489);
				_la = _input.LA(1);
				if ( !(_la==Identifier || _la==Literal) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				}
				break;
			}
			setState(497);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,63,_ctx) ) {
			case 1:
				{
				setState(492);
				match(T__2);
				setState(494);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Identifier) | (1L << Literal))) != 0)) {
					{
					setState(493);
					methodParametrDefaultValue();
					}
				}

				setState(496);
				match(T__3);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodBodyContext extends ParserRuleContext {
		public TerminalNode BracketsOpen() { return getToken(UHeaderParser.BracketsOpen, 0); }
		public MethodBodyContentContext methodBodyContent() {
			return getRuleContext(MethodBodyContentContext.class,0);
		}
		public TerminalNode BracketsClose() { return getToken(UHeaderParser.BracketsClose, 0); }
		public MethodBodyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodBody; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethodBody(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodBodyContext methodBody() throws RecognitionException {
		MethodBodyContext _localctx = new MethodBodyContext(_ctx, getState());
		enterRule(_localctx, 74, RULE_methodBody);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(499);
			match(BracketsOpen);
			setState(500);
			methodBodyContent();
			setState(501);
			match(BracketsClose);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodBodyContentContext extends ParserRuleContext {
		public List<TerminalNode> BracketsOpen() { return getTokens(UHeaderParser.BracketsOpen); }
		public TerminalNode BracketsOpen(int i) {
			return getToken(UHeaderParser.BracketsOpen, i);
		}
		public List<TerminalNode> BracketsClose() { return getTokens(UHeaderParser.BracketsClose); }
		public TerminalNode BracketsClose(int i) {
			return getToken(UHeaderParser.BracketsClose, i);
		}
		public List<MethodBodyContentContext> methodBodyContent() {
			return getRuleContexts(MethodBodyContentContext.class);
		}
		public MethodBodyContentContext methodBodyContent(int i) {
			return getRuleContext(MethodBodyContentContext.class,i);
		}
		public MethodBodyContentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodBodyContent; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethodBodyContent(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodBodyContentContext methodBodyContent() throws RecognitionException {
		MethodBodyContentContext _localctx = new MethodBodyContentContext(_ctx, getState());
		enterRule(_localctx, 76, RULE_methodBodyContent);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(506);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2) | (1L << T__3) | (1L << T__4) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << PtrQuant) | (1L << RefQuant) | (1L << Private) | (1L << Protected) | (1L << Public) | (1L << Inline) | (1L << Explicit) | (1L << Virtual) | (1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Union) | (1L << Const) | (1L << Final) | (1L << Static) | (1L << Extern) | (1L << Mutable) | (1L << Override) | (1L << Template) | (1L << Friend) | (1L << Operator) | (1L << Typedef) | (1L << Constexpr) | (1L << Tilda) | (1L << Delete) | (1L << GCC_ALIGN) | (1L << Namespace) | (1L << Typename) | (1L << DotDot) | (1L << SingleLineDerective) | (1L << MultiLineDerective) | (1L << Identifier) | (1L << Literal) | (1L << SpecalSymbol) | (1L << Whitespace) | (1L << Newline) | (1L << ExportComment) | (1L << BlockComment) | (1L << LineComment))) != 0)) {
				{
				{
				setState(503);
				_la = _input.LA(1);
				if ( _la <= 0 || (_la==BracketsOpen || _la==BracketsClose) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				}
				}
				setState(508);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			{
			setState(514);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==BracketsOpen) {
				{
				setState(509);
				match(BracketsOpen);
				setState(510);
				methodBodyContent();
				setState(511);
				match(BracketsClose);
				setState(512);
				methodBodyContent();
				}
			}

			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodNameContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public List<TerminalNode> DotDot() { return getTokens(UHeaderParser.DotDot); }
		public TerminalNode DotDot(int i) {
			return getToken(UHeaderParser.DotDot, i);
		}
		public MethodNameContext methodName() {
			return getRuleContext(MethodNameContext.class,0);
		}
		public TerminalNode Operator() { return getToken(UHeaderParser.Operator, 0); }
		public MethodOperatorContext methodOperator() {
			return getRuleContext(MethodOperatorContext.class,0);
		}
		public MethodNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodName; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethodName(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodNameContext methodName() throws RecognitionException {
		MethodNameContext _localctx = new MethodNameContext(_ctx, getState());
		enterRule(_localctx, 78, RULE_methodName);
		int _la;
		try {
			setState(524);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Identifier:
				enterOuterAlt(_localctx, 1);
				{
				setState(516);
				match(Identifier);
				setState(520);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==DotDot) {
					{
					setState(517);
					match(DotDot);
					setState(518);
					match(DotDot);
					setState(519);
					methodName();
					}
				}

				}
				break;
			case Operator:
				enterOuterAlt(_localctx, 2);
				{
				setState(522);
				match(Operator);
				setState(523);
				methodOperator();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodOperatorContext extends ParserRuleContext {
		public List<TerminalNode> PtrQuant() { return getTokens(UHeaderParser.PtrQuant); }
		public TerminalNode PtrQuant(int i) {
			return getToken(UHeaderParser.PtrQuant, i);
		}
		public List<TerminalNode> SpecalSymbol() { return getTokens(UHeaderParser.SpecalSymbol); }
		public TerminalNode SpecalSymbol(int i) {
			return getToken(UHeaderParser.SpecalSymbol, i);
		}
		public List<TerminalNode> RefQuant() { return getTokens(UHeaderParser.RefQuant); }
		public TerminalNode RefQuant(int i) {
			return getToken(UHeaderParser.RefQuant, i);
		}
		public List<TerminalNode> Identifier() { return getTokens(UHeaderParser.Identifier); }
		public TerminalNode Identifier(int i) {
			return getToken(UHeaderParser.Identifier, i);
		}
		public MethodOperatorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_methodOperator; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitMethodOperator(this);
			else return visitor.visitChildren(this);
		}
	}

	public final MethodOperatorContext methodOperator() throws RecognitionException {
		MethodOperatorContext _localctx = new MethodOperatorContext(_ctx, getState());
		enterRule(_localctx, 80, RULE_methodOperator);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(527); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(526);
				_la = _input.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Identifier) | (1L << SpecalSymbol))) != 0)) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				}
				}
				setState(529); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PtrQuant) | (1L << RefQuant) | (1L << Identifier) | (1L << SpecalSymbol))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class PropertyContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public PropertyNameContext propertyName() {
			return getRuleContext(PropertyNameContext.class,0);
		}
		public List<TerminalNode> Mutable() { return getTokens(UHeaderParser.Mutable); }
		public TerminalNode Mutable(int i) {
			return getToken(UHeaderParser.Mutable, i);
		}
		public List<TerminalNode> Extern() { return getTokens(UHeaderParser.Extern); }
		public TerminalNode Extern(int i) {
			return getToken(UHeaderParser.Extern, i);
		}
		public List<IsStaticContext> isStatic() {
			return getRuleContexts(IsStaticContext.class);
		}
		public IsStaticContext isStatic(int i) {
			return getRuleContext(IsStaticContext.class,i);
		}
		public IsArrayContext isArray() {
			return getRuleContext(IsArrayContext.class,0);
		}
		public PropertyDefaultValueContext propertyDefaultValue() {
			return getRuleContext(PropertyDefaultValueContext.class,0);
		}
		public TerminalNode DotDot() { return getToken(UHeaderParser.DotDot, 0); }
		public PropertyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_property; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitProperty(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PropertyContext property() throws RecognitionException {
		PropertyContext _localctx = new PropertyContext(_ctx, getState());
		enterRule(_localctx, 82, RULE_property);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(536);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Static) | (1L << Extern) | (1L << Mutable))) != 0)) {
				{
				setState(534);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case Mutable:
					{
					setState(531);
					match(Mutable);
					}
					break;
				case Extern:
					{
					setState(532);
					match(Extern);
					}
					break;
				case Static:
					{
					setState(533);
					isStatic();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				setState(538);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(539);
			type();
			setState(540);
			propertyName();
			setState(542);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__8) {
				{
				setState(541);
				isArray();
				}
			}

			setState(546);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__4 || _la==DotDot) {
				{
				setState(544);
				_la = _input.LA(1);
				if ( !(_la==T__4 || _la==DotDot) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(545);
				propertyDefaultValue();
				}
			}

			setState(548);
			match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class PropertyNameContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public PropertyNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_propertyName; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitPropertyName(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PropertyNameContext propertyName() throws RecognitionException {
		PropertyNameContext _localctx = new PropertyNameContext(_ctx, getState());
		enterRule(_localctx, 84, RULE_propertyName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(550);
			match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class PropertyDefaultValueContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public PropertyDefaultValueContext propertyDefaultValue() {
			return getRuleContext(PropertyDefaultValueContext.class,0);
		}
		public ValueContext value() {
			return getRuleContext(ValueContext.class,0);
		}
		public PropertyDefaultValueContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_propertyDefaultValue; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitPropertyDefaultValue(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PropertyDefaultValueContext propertyDefaultValue() throws RecognitionException {
		PropertyDefaultValueContext _localctx = new PropertyDefaultValueContext(_ctx, getState());
		enterRule(_localctx, 86, RULE_propertyDefaultValue);
		int _la;
		try {
			setState(560);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,74,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(552);
				match(Identifier);
				setState(557);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__2) {
					{
					setState(553);
					match(T__2);
					setState(554);
					propertyDefaultValue();
					setState(555);
					match(T__3);
					}
				}

				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(559);
				value();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TypeContext extends ParserRuleContext {
		public TypeNameContext typeName() {
			return getRuleContext(TypeNameContext.class,0);
		}
		public List<IsConstContext> isConst() {
			return getRuleContexts(IsConstContext.class);
		}
		public IsConstContext isConst(int i) {
			return getRuleContext(IsConstContext.class,i);
		}
		public ClassOrStructOrEnumContext classOrStructOrEnum() {
			return getRuleContext(ClassOrStructOrEnumContext.class,0);
		}
		public List<IsPtrQuantContext> isPtrQuant() {
			return getRuleContexts(IsPtrQuantContext.class);
		}
		public IsPtrQuantContext isPtrQuant(int i) {
			return getRuleContext(IsPtrQuantContext.class,i);
		}
		public List<IsRefQuantContext> isRefQuant() {
			return getRuleContexts(IsRefQuantContext.class);
		}
		public IsRefQuantContext isRefQuant(int i) {
			return getRuleContext(IsRefQuantContext.class,i);
		}
		public TypeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_type; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitType(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TypeContext type() throws RecognitionException {
		TypeContext _localctx = new TypeContext(_ctx, getState());
		enterRule(_localctx, 88, RULE_type);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(563);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Const) {
				{
				setState(562);
				isConst();
				}
			}

			setState(566);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Class) | (1L << Struct) | (1L << Enum))) != 0)) {
				{
				setState(565);
				classOrStructOrEnum();
				}
			}

			setState(570);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case PtrQuant:
				{
				setState(568);
				isPtrQuant();
				}
				break;
			case RefQuant:
				{
				setState(569);
				isRefQuant();
				}
				break;
			case Identifier:
				break;
			default:
				break;
			}
			setState(572);
			typeName();
			setState(575);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,78,_ctx) ) {
			case 1:
				{
				setState(573);
				isPtrQuant();
				}
				break;
			case 2:
				{
				setState(574);
				isRefQuant();
				}
				break;
			}
			setState(578);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,79,_ctx) ) {
			case 1:
				{
				setState(577);
				isConst();
				}
				break;
			}
			setState(582);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,80,_ctx) ) {
			case 1:
				{
				setState(580);
				isPtrQuant();
				}
				break;
			case 2:
				{
				setState(581);
				isRefQuant();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsPtrQuantContext extends ParserRuleContext {
		public TerminalNode PtrQuant() { return getToken(UHeaderParser.PtrQuant, 0); }
		public IsPtrQuantContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isPtrQuant; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsPtrQuant(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsPtrQuantContext isPtrQuant() throws RecognitionException {
		IsPtrQuantContext _localctx = new IsPtrQuantContext(_ctx, getState());
		enterRule(_localctx, 90, RULE_isPtrQuant);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(584);
			match(PtrQuant);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsRefQuantContext extends ParserRuleContext {
		public TerminalNode RefQuant() { return getToken(UHeaderParser.RefQuant, 0); }
		public IsRefQuantContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isRefQuant; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsRefQuant(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsRefQuantContext isRefQuant() throws RecognitionException {
		IsRefQuantContext _localctx = new IsRefQuantContext(_ctx, getState());
		enterRule(_localctx, 92, RULE_isRefQuant);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(586);
			match(RefQuant);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TypeNameContext extends ParserRuleContext {
		public List<TerminalNode> Identifier() { return getTokens(UHeaderParser.Identifier); }
		public TerminalNode Identifier(int i) {
			return getToken(UHeaderParser.Identifier, i);
		}
		public List<TerminalNode> DotDot() { return getTokens(UHeaderParser.DotDot); }
		public TerminalNode DotDot(int i) {
			return getToken(UHeaderParser.DotDot, i);
		}
		public List<TypeContext> type() {
			return getRuleContexts(TypeContext.class);
		}
		public TypeContext type(int i) {
			return getRuleContext(TypeContext.class,i);
		}
		public List<TerminalNode> Literal() { return getTokens(UHeaderParser.Literal); }
		public TerminalNode Literal(int i) {
			return getToken(UHeaderParser.Literal, i);
		}
		public TypeNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_typeName; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTypeName(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TypeNameContext typeName() throws RecognitionException {
		TypeNameContext _localctx = new TypeNameContext(_ctx, getState());
		enterRule(_localctx, 94, RULE_typeName);
		int _la;
		try {
			setState(611);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,85,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(588);
				match(Identifier);
				setState(592);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,81,_ctx) ) {
				case 1:
					{
					setState(589);
					match(DotDot);
					setState(590);
					match(DotDot);
					setState(591);
					match(Identifier);
					}
					break;
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(594);
				match(Identifier);
				{
				setState(595);
				match(T__6);
				setState(598);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case PtrQuant:
				case RefQuant:
				case Class:
				case Struct:
				case Enum:
				case Const:
				case Identifier:
					{
					setState(596);
					type();
					}
					break;
				case Literal:
					{
					setState(597);
					match(Literal);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(607);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__1) {
					{
					{
					setState(600);
					match(T__1);
					setState(603);
					_errHandler.sync(this);
					switch (_input.LA(1)) {
					case PtrQuant:
					case RefQuant:
					case Class:
					case Struct:
					case Enum:
					case Const:
					case Identifier:
						{
						setState(601);
						type();
						}
						break;
					case Literal:
						{
						setState(602);
						match(Literal);
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					}
					}
					setState(609);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(610);
				match(T__7);
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsVirtualContext extends ParserRuleContext {
		public TerminalNode Virtual() { return getToken(UHeaderParser.Virtual, 0); }
		public IsVirtualContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isVirtual; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsVirtual(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsVirtualContext isVirtual() throws RecognitionException {
		IsVirtualContext _localctx = new IsVirtualContext(_ctx, getState());
		enterRule(_localctx, 96, RULE_isVirtual);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(613);
			match(Virtual);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsOverrideContext extends ParserRuleContext {
		public TerminalNode Override() { return getToken(UHeaderParser.Override, 0); }
		public IsOverrideContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isOverride; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsOverride(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsOverrideContext isOverride() throws RecognitionException {
		IsOverrideContext _localctx = new IsOverrideContext(_ctx, getState());
		enterRule(_localctx, 98, RULE_isOverride);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(615);
			match(Override);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsConstContext extends ParserRuleContext {
		public TerminalNode Const() { return getToken(UHeaderParser.Const, 0); }
		public IsConstContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isConst; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsConst(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsConstContext isConst() throws RecognitionException {
		IsConstContext _localctx = new IsConstContext(_ctx, getState());
		enterRule(_localctx, 100, RULE_isConst);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(617);
			match(Const);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsStaticContext extends ParserRuleContext {
		public TerminalNode Static() { return getToken(UHeaderParser.Static, 0); }
		public IsStaticContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isStatic; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsStatic(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsStaticContext isStatic() throws RecognitionException {
		IsStaticContext _localctx = new IsStaticContext(_ctx, getState());
		enterRule(_localctx, 102, RULE_isStatic);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(619);
			match(Static);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsFriendContext extends ParserRuleContext {
		public TerminalNode Friend() { return getToken(UHeaderParser.Friend, 0); }
		public IsFriendContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isFriend; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsFriend(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsFriendContext isFriend() throws RecognitionException {
		IsFriendContext _localctx = new IsFriendContext(_ctx, getState());
		enterRule(_localctx, 104, RULE_isFriend);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(621);
			match(Friend);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsFinalContext extends ParserRuleContext {
		public TerminalNode Final() { return getToken(UHeaderParser.Final, 0); }
		public IsFinalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isFinal; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsFinal(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsFinalContext isFinal() throws RecognitionException {
		IsFinalContext _localctx = new IsFinalContext(_ctx, getState());
		enterRule(_localctx, 106, RULE_isFinal);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(623);
			match(Final);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsDestructorContext extends ParserRuleContext {
		public TerminalNode Tilda() { return getToken(UHeaderParser.Tilda, 0); }
		public IsDestructorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isDestructor; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsDestructor(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsDestructorContext isDestructor() throws RecognitionException {
		IsDestructorContext _localctx = new IsDestructorContext(_ctx, getState());
		enterRule(_localctx, 108, RULE_isDestructor);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(625);
			match(Tilda);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsDeleteContext extends ParserRuleContext {
		public TerminalNode Delete() { return getToken(UHeaderParser.Delete, 0); }
		public IsDeleteContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isDelete; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsDelete(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsDeleteContext isDelete() throws RecognitionException {
		IsDeleteContext _localctx = new IsDeleteContext(_ctx, getState());
		enterRule(_localctx, 110, RULE_isDelete);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(627);
			match(T__4);
			setState(628);
			match(Delete);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IsArrayContext extends ParserRuleContext {
		public ArrayLenContext arrayLen() {
			return getRuleContext(ArrayLenContext.class,0);
		}
		public IsArrayContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_isArray; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitIsArray(this);
			else return visitor.visitChildren(this);
		}
	}

	public final IsArrayContext isArray() throws RecognitionException {
		IsArrayContext _localctx = new IsArrayContext(_ctx, getState());
		enterRule(_localctx, 112, RULE_isArray);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(630);
			match(T__8);
			setState(631);
			arrayLen();
			setState(632);
			match(T__9);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ArrayLenContext extends ParserRuleContext {
		public TerminalNode Literal() { return getToken(UHeaderParser.Literal, 0); }
		public ArrayLenContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_arrayLen; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitArrayLen(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ArrayLenContext arrayLen() throws RecognitionException {
		ArrayLenContext _localctx = new ArrayLenContext(_ctx, getState());
		enterRule(_localctx, 114, RULE_arrayLen);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(634);
			match(Literal);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TemplateDefineContext extends ParserRuleContext {
		public TerminalNode Template() { return getToken(UHeaderParser.Template, 0); }
		public TemplateParamListContext templateParamList() {
			return getRuleContext(TemplateParamListContext.class,0);
		}
		public TemplateDefineContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_templateDefine; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTemplateDefine(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TemplateDefineContext templateDefine() throws RecognitionException {
		TemplateDefineContext _localctx = new TemplateDefineContext(_ctx, getState());
		enterRule(_localctx, 116, RULE_templateDefine);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(636);
			match(Template);
			setState(637);
			match(T__6);
			setState(639);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Identifier))) != 0)) {
				{
				setState(638);
				templateParamList();
				}
			}

			setState(641);
			match(T__7);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TemplateParamListContext extends ParserRuleContext {
		public TemplateParamContext templateParam() {
			return getRuleContext(TemplateParamContext.class,0);
		}
		public TemplateParamListContext templateParamList() {
			return getRuleContext(TemplateParamListContext.class,0);
		}
		public TemplateParamListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_templateParamList; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTemplateParamList(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TemplateParamListContext templateParamList() throws RecognitionException {
		TemplateParamListContext _localctx = new TemplateParamListContext(_ctx, getState());
		enterRule(_localctx, 118, RULE_templateParamList);
		try {
			setState(648);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,87,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(643);
				templateParam();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(644);
				templateParam();
				setState(645);
				match(T__1);
				setState(646);
				templateParamList();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TemplateParamContext extends ParserRuleContext {
		public TemplateParamTypeContext templateParamType() {
			return getRuleContext(TemplateParamTypeContext.class,0);
		}
		public TemplateParamLiterContext templateParamLiter() {
			return getRuleContext(TemplateParamLiterContext.class,0);
		}
		public PropertyDefaultValueContext propertyDefaultValue() {
			return getRuleContext(PropertyDefaultValueContext.class,0);
		}
		public TemplateParamContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_templateParam; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTemplateParam(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TemplateParamContext templateParam() throws RecognitionException {
		TemplateParamContext _localctx = new TemplateParamContext(_ctx, getState());
		enterRule(_localctx, 120, RULE_templateParam);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(650);
			templateParamType();
			setState(652);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==Identifier) {
				{
				setState(651);
				templateParamLiter();
				}
			}

			setState(656);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__4) {
				{
				setState(654);
				match(T__4);
				setState(655);
				propertyDefaultValue();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TemplateParamTypeContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public TerminalNode Class() { return getToken(UHeaderParser.Class, 0); }
		public TerminalNode Struct() { return getToken(UHeaderParser.Struct, 0); }
		public TerminalNode Enum() { return getToken(UHeaderParser.Enum, 0); }
		public TemplateParamTypeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_templateParamType; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTemplateParamType(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TemplateParamTypeContext templateParamType() throws RecognitionException {
		TemplateParamTypeContext _localctx = new TemplateParamTypeContext(_ctx, getState());
		enterRule(_localctx, 122, RULE_templateParamType);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(658);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Class) | (1L << Struct) | (1L << Enum) | (1L << Identifier))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TemplateParamLiterContext extends ParserRuleContext {
		public TerminalNode Identifier() { return getToken(UHeaderParser.Identifier, 0); }
		public TemplateParamLiterContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_templateParamLiter; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitTemplateParamLiter(this);
			else return visitor.visitChildren(this);
		}
	}

	public final TemplateParamLiterContext templateParamLiter() throws RecognitionException {
		TemplateParamLiterContext _localctx = new TemplateParamLiterContext(_ctx, getState());
		enterRule(_localctx, 124, RULE_templateParamLiter);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(660);
			match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class AccessSpecifierContainerContext extends ParserRuleContext {
		public AccessSpecifierContext accessSpecifier() {
			return getRuleContext(AccessSpecifierContext.class,0);
		}
		public TerminalNode DotDot() { return getToken(UHeaderParser.DotDot, 0); }
		public AccessSpecifierContainerContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_accessSpecifierContainer; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitAccessSpecifierContainer(this);
			else return visitor.visitChildren(this);
		}
	}

	public final AccessSpecifierContainerContext accessSpecifierContainer() throws RecognitionException {
		AccessSpecifierContainerContext _localctx = new AccessSpecifierContainerContext(_ctx, getState());
		enterRule(_localctx, 126, RULE_accessSpecifierContainer);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(662);
			accessSpecifier();
			setState(663);
			match(DotDot);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class AccessSpecifierContext extends ParserRuleContext {
		public TerminalNode Private() { return getToken(UHeaderParser.Private, 0); }
		public TerminalNode Protected() { return getToken(UHeaderParser.Protected, 0); }
		public TerminalNode Public() { return getToken(UHeaderParser.Public, 0); }
		public AccessSpecifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_accessSpecifier; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitAccessSpecifier(this);
			else return visitor.visitChildren(this);
		}
	}

	public final AccessSpecifierContext accessSpecifier() throws RecognitionException {
		AccessSpecifierContext _localctx = new AccessSpecifierContext(_ctx, getState());
		enterRule(_localctx, 128, RULE_accessSpecifier);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(665);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Private) | (1L << Protected) | (1L << Public))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class PreprocessDerectiveContext extends ParserRuleContext {
		public TerminalNode SingleLineDerective() { return getToken(UHeaderParser.SingleLineDerective, 0); }
		public TerminalNode MultiLineDerective() { return getToken(UHeaderParser.MultiLineDerective, 0); }
		public PreprocessDerectiveContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_preprocessDerective; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof UHeaderVisitor ) return ((UHeaderVisitor<? extends T>)visitor).visitPreprocessDerective(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PreprocessDerectiveContext preprocessDerective() throws RecognitionException {
		PreprocessDerectiveContext _localctx = new PreprocessDerectiveContext(_ctx, getState());
		enterRule(_localctx, 130, RULE_preprocessDerective);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(667);
			_la = _input.LA(1);
			if ( !(_la==SingleLineDerective || _la==MultiLineDerective) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 24:
			return uMetaParamKey_sempred((UMetaParamKeyContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean uMetaParamKey_sempred(UMetaParamKeyContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 1);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\65\u02a0\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4"+
		",\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64\t"+
		"\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\4<\t<\4=\t="+
		"\4>\t>\4?\t?\4@\t@\4A\tA\4B\tB\4C\tC\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3"+
		"\2\3\2\7\2\u0091\n\2\f\2\16\2\u0094\13\2\3\3\3\3\3\3\3\3\3\3\3\3\5\3\u009c"+
		"\n\3\3\4\3\4\3\5\5\5\u00a1\n\5\3\5\3\5\3\5\3\5\3\5\3\5\5\5\u00a9\n\5\3"+
		"\5\3\5\3\5\5\5\u00ae\n\5\3\6\5\6\u00b1\n\6\3\6\3\6\3\6\5\6\u00b6\n\6\3"+
		"\6\3\6\5\6\u00ba\n\6\3\6\3\6\3\6\3\6\5\6\u00c0\n\6\3\6\3\6\3\7\3\7\3\b"+
		"\3\b\3\t\5\t\u00c9\n\t\3\t\3\t\5\t\u00cd\n\t\3\t\3\t\3\t\3\t\5\t\u00d3"+
		"\n\t\3\n\3\n\3\n\3\n\3\n\3\13\6\13\u00db\n\13\r\13\16\13\u00dc\3\f\3\f"+
		"\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\7\f\u00eb\n\f\f\f\16\f\u00ee"+
		"\13\f\3\r\3\r\3\16\3\16\5\16\u00f4\n\16\3\16\3\16\5\16\u00f8\n\16\3\16"+
		"\3\16\3\16\3\16\5\16\u00fe\n\16\3\16\3\16\3\16\3\16\3\16\3\16\3\16\3\16"+
		"\5\16\u0108\n\16\3\17\3\17\3\17\3\20\3\20\3\20\3\20\3\20\5\20\u0112\n"+
		"\20\5\20\u0114\n\20\3\21\7\21\u0117\n\21\f\21\16\21\u011a\13\21\3\21\3"+
		"\21\3\21\5\21\u011f\n\21\3\21\5\21\u0122\n\21\3\22\3\22\3\23\3\23\3\23"+
		"\5\23\u0129\n\23\3\24\3\24\3\24\3\24\3\24\3\25\3\25\3\25\3\25\3\25\5\25"+
		"\u0135\n\25\3\26\3\26\3\27\5\27\u013a\n\27\3\30\3\30\3\30\3\30\3\30\5"+
		"\30\u0141\n\30\3\31\3\31\3\31\3\31\3\31\3\31\3\31\3\31\3\31\3\31\3\31"+
		"\5\31\u014e\n\31\3\32\3\32\3\32\5\32\u0153\n\32\3\32\3\32\3\32\7\32\u0158"+
		"\n\32\f\32\16\32\u015b\13\32\3\33\3\33\5\33\u015f\n\33\3\34\3\34\3\34"+
		"\3\34\3\35\7\35\u0166\n\35\f\35\16\35\u0169\13\35\3\35\3\35\3\35\3\35"+
		"\3\35\5\35\u0170\n\35\3\36\3\36\3\36\7\36\u0175\n\36\f\36\16\36\u0178"+
		"\13\36\3\36\5\36\u017b\n\36\3\36\3\36\3\36\5\36\u0180\n\36\3\36\3\36\5"+
		"\36\u0184\n\36\3\36\3\36\5\36\u0188\n\36\3\36\3\36\5\36\u018c\n\36\3\36"+
		"\5\36\u018f\n\36\3\37\3\37\3\37\3\37\3\37\5\37\u0196\n\37\3 \3 \3 \5 "+
		"\u019b\n \3 \3 \3 \3 \3 \5 \u01a2\n \3!\5!\u01a5\n!\3!\3!\3!\3!\3!\3!"+
		"\7!\u01ad\n!\f!\16!\u01b0\13!\3!\3!\3!\3!\5!\u01b6\n!\3!\3!\5!\u01ba\n"+
		"!\3!\5!\u01bd\n!\3!\5!\u01c0\n!\3!\3!\5!\u01c4\n!\3!\5!\u01c7\n!\3\"\3"+
		"\"\3\"\3\"\3\"\5\"\u01ce\n\"\3#\3#\3#\3#\5#\u01d4\n#\5#\u01d6\n#\3$\3"+
		"$\3%\3%\3%\7%\u01dd\n%\f%\16%\u01e0\13%\3&\3&\5&\u01e4\n&\3&\3&\6&\u01e8"+
		"\n&\r&\16&\u01e9\3&\5&\u01ed\n&\3&\3&\5&\u01f1\n&\3&\5&\u01f4\n&\3\'\3"+
		"\'\3\'\3\'\3(\7(\u01fb\n(\f(\16(\u01fe\13(\3(\3(\3(\3(\3(\5(\u0205\n("+
		"\3)\3)\3)\3)\5)\u020b\n)\3)\3)\5)\u020f\n)\3*\6*\u0212\n*\r*\16*\u0213"+
		"\3+\3+\3+\7+\u0219\n+\f+\16+\u021c\13+\3+\3+\3+\5+\u0221\n+\3+\3+\5+\u0225"+
		"\n+\3+\3+\3,\3,\3-\3-\3-\3-\3-\5-\u0230\n-\3-\5-\u0233\n-\3.\5.\u0236"+
		"\n.\3.\5.\u0239\n.\3.\3.\5.\u023d\n.\3.\3.\3.\5.\u0242\n.\3.\5.\u0245"+
		"\n.\3.\3.\5.\u0249\n.\3/\3/\3\60\3\60\3\61\3\61\3\61\3\61\5\61\u0253\n"+
		"\61\3\61\3\61\3\61\3\61\5\61\u0259\n\61\3\61\3\61\3\61\5\61\u025e\n\61"+
		"\7\61\u0260\n\61\f\61\16\61\u0263\13\61\3\61\5\61\u0266\n\61\3\62\3\62"+
		"\3\63\3\63\3\64\3\64\3\65\3\65\3\66\3\66\3\67\3\67\38\38\39\39\39\3:\3"+
		":\3:\3:\3;\3;\3<\3<\3<\5<\u0282\n<\3<\3<\3=\3=\3=\3=\3=\5=\u028b\n=\3"+
		">\3>\5>\u028f\n>\3>\3>\5>\u0293\n>\3?\3?\3@\3@\3A\3A\3A\3B\3B\3C\3C\3"+
		"C\2\3\62D\2\4\6\b\n\f\16\20\22\24\26\30\32\34\36 \"$&(*,.\60\62\64\66"+
		"8:<>@BDFHJLNPRTVXZ\\^`bdfhjlnprtvxz|~\u0080\u0082\u0084\2\r\3\2\25\27"+
		"\3\2\25\26\4\2\7\7++\3\2\5\6\3\2./\5\2\b\n++\60\60\3\2$%\5\2\r\16..\60"+
		"\60\4\2\25\27..\3\2\17\21\3\2,-\2\u02d6\2\u0092\3\2\2\2\4\u0095\3\2\2"+
		"\2\6\u009d\3\2\2\2\b\u00ad\3\2\2\2\n\u00b0\3\2\2\2\f\u00c3\3\2\2\2\16"+
		"\u00c5\3\2\2\2\20\u00d2\3\2\2\2\22\u00d4\3\2\2\2\24\u00da\3\2\2\2\26\u00ec"+
		"\3\2\2\2\30\u00ef\3\2\2\2\32\u0107\3\2\2\2\34\u0109\3\2\2\2\36\u0113\3"+
		"\2\2\2 \u0118\3\2\2\2\"\u0123\3\2\2\2$\u0125\3\2\2\2&\u012a\3\2\2\2(\u012f"+
		"\3\2\2\2*\u0136\3\2\2\2,\u0139\3\2\2\2.\u0140\3\2\2\2\60\u014d\3\2\2\2"+
		"\62\u0152\3\2\2\2\64\u015e\3\2\2\2\66\u0160\3\2\2\28\u0167\3\2\2\2:\u0176"+
		"\3\2\2\2<\u0195\3\2\2\2>\u01a1\3\2\2\2@\u01a4\3\2\2\2B\u01cd\3\2\2\2D"+
		"\u01cf\3\2\2\2F\u01d7\3\2\2\2H\u01d9\3\2\2\2J\u01e3\3\2\2\2L\u01f5\3\2"+
		"\2\2N\u01fc\3\2\2\2P\u020e\3\2\2\2R\u0211\3\2\2\2T\u021a\3\2\2\2V\u0228"+
		"\3\2\2\2X\u0232\3\2\2\2Z\u0235\3\2\2\2\\\u024a\3\2\2\2^\u024c\3\2\2\2"+
		"`\u0265\3\2\2\2b\u0267\3\2\2\2d\u0269\3\2\2\2f\u026b\3\2\2\2h\u026d\3"+
		"\2\2\2j\u026f\3\2\2\2l\u0271\3\2\2\2n\u0273\3\2\2\2p\u0275\3\2\2\2r\u0278"+
		"\3\2\2\2t\u027c\3\2\2\2v\u027e\3\2\2\2x\u028a\3\2\2\2z\u028c\3\2\2\2|"+
		"\u0294\3\2\2\2~\u0296\3\2\2\2\u0080\u0298\3\2\2\2\u0082\u029b\3\2\2\2"+
		"\u0084\u029d\3\2\2\2\u0086\u0091\5\b\5\2\u0087\u0091\5@!\2\u0088\u0091"+
		"\5\n\6\2\u0089\u0091\5\32\16\2\u008a\u0091\5T+\2\u008b\u0091\5&\24\2\u008c"+
		"\u0091\5(\25\2\u008d\u0091\5\4\3\2\u008e\u0091\5\30\r\2\u008f\u0091\5"+
		"\u0084C\2\u0090\u0086\3\2\2\2\u0090\u0087\3\2\2\2\u0090\u0088\3\2\2\2"+
		"\u0090\u0089\3\2\2\2\u0090\u008a\3\2\2\2\u0090\u008b\3\2\2\2\u0090\u008c"+
		"\3\2\2\2\u0090\u008d\3\2\2\2\u0090\u008e\3\2\2\2\u0090\u008f\3\2\2\2\u0091"+
		"\u0094\3\2\2\2\u0092\u0090\3\2\2\2\u0092\u0093\3\2\2\2\u0093\3\3\2\2\2"+
		"\u0094\u0092\3\2\2\2\u0095\u0096\7)\2\2\u0096\u0097\5\6\4\2\u0097\u0098"+
		"\7$\2\2\u0098\u0099\5\2\2\2\u0099\u009b\7%\2\2\u009a\u009c\7\3\2\2\u009b"+
		"\u009a\3\2\2\2\u009b\u009c\3\2\2\2\u009c\5\3\2\2\2\u009d\u009e\7.\2\2"+
		"\u009e\7\3\2\2\2\u009f\u00a1\5v<\2\u00a0\u009f\3\2\2\2\u00a0\u00a1\3\2"+
		"\2\2\u00a1\u00a2\3\2\2\2\u00a2\u00a3\5\f\7\2\u00a3\u00a4\5Z.\2\u00a4\u00a5"+
		"\7\3\2\2\u00a5\u00ae\3\2\2\2\u00a6\u00a8\5j\66\2\u00a7\u00a9\5\f\7\2\u00a8"+
		"\u00a7\3\2\2\2\u00a8\u00a9\3\2\2\2\u00a9\u00aa\3\2\2\2\u00aa\u00ab\5Z"+
		".\2\u00ab\u00ac\7\3\2\2\u00ac\u00ae\3\2\2\2\u00ad\u00a0\3\2\2\2\u00ad"+
		"\u00a6\3\2\2\2\u00ae\t\3\2\2\2\u00af\u00b1\5v<\2\u00b0\u00af\3\2\2\2\u00b0"+
		"\u00b1\3\2\2\2\u00b1\u00b2\3\2\2\2\u00b2\u00b3\5\16\b\2\u00b3\u00b5\5"+
		"Z.\2\u00b4\u00b6\5l\67\2\u00b5\u00b4\3\2\2\2\u00b5\u00b6\3\2\2\2\u00b6"+
		"\u00b9\3\2\2\2\u00b7\u00b8\7+\2\2\u00b8\u00ba\5\20\t\2\u00b9\u00b7\3\2"+
		"\2\2\u00b9\u00ba\3\2\2\2\u00ba\u00bb\3\2\2\2\u00bb\u00bc\7$\2\2\u00bc"+
		"\u00bd\5\26\f\2\u00bd\u00bf\7%\2\2\u00be\u00c0\5\22\n\2\u00bf\u00be\3"+
		"\2\2\2\u00bf\u00c0\3\2\2\2\u00c0\u00c1\3\2\2\2\u00c1\u00c2\7\3\2\2\u00c2"+
		"\13\3\2\2\2\u00c3\u00c4\t\2\2\2\u00c4\r\3\2\2\2\u00c5\u00c6\t\3\2\2\u00c6"+
		"\17\3\2\2\2\u00c7\u00c9\5\u0082B\2\u00c8\u00c7\3\2\2\2\u00c8\u00c9\3\2"+
		"\2\2\u00c9\u00ca\3\2\2\2\u00ca\u00d3\5Z.\2\u00cb\u00cd\5\u0082B\2\u00cc"+
		"\u00cb\3\2\2\2\u00cc\u00cd\3\2\2\2\u00cd\u00ce\3\2\2\2\u00ce\u00cf\5Z"+
		".\2\u00cf\u00d0\7\4\2\2\u00d0\u00d1\5\20\t\2\u00d1\u00d3\3\2\2\2\u00d2"+
		"\u00c8\3\2\2\2\u00d2\u00cc\3\2\2\2\u00d3\21\3\2\2\2\u00d4\u00d5\7(\2\2"+
		"\u00d5\u00d6\7\5\2\2\u00d6\u00d7\5\24\13\2\u00d7\u00d8\7\6\2\2\u00d8\23"+
		"\3\2\2\2\u00d9\u00db\7/\2\2\u00da\u00d9\3\2\2\2\u00db\u00dc\3\2\2\2\u00dc"+
		"\u00da\3\2\2\2\u00dc\u00dd\3\2\2\2\u00dd\25\3\2\2\2\u00de\u00eb\5\u0080"+
		"A\2\u00df\u00eb\5@!\2\u00e0\u00eb\5:\36\2\u00e1\u00eb\5T+\2\u00e2\u00eb"+
		"\5(\25\2\u00e3\u00eb\5&\24\2\u00e4\u00eb\5\n\6\2\u00e5\u00eb\5\32\16\2"+
		"\u00e6\u00eb\5\b\5\2\u00e7\u00eb\5$\23\2\u00e8\u00eb\5\30\r\2\u00e9\u00eb"+
		"\5\u0084C\2\u00ea\u00de\3\2\2\2\u00ea\u00df\3\2\2\2\u00ea\u00e0\3\2\2"+
		"\2\u00ea\u00e1\3\2\2\2\u00ea\u00e2\3\2\2\2\u00ea\u00e3\3\2\2\2\u00ea\u00e4"+
		"\3\2\2\2\u00ea\u00e5\3\2\2\2\u00ea\u00e6\3\2\2\2\u00ea\u00e7\3\2\2\2\u00ea"+
		"\u00e8\3\2\2\2\u00ea\u00e9\3\2\2\2\u00eb\u00ee\3\2\2\2\u00ec\u00ea\3\2"+
		"\2\2\u00ec\u00ed\3\2\2\2\u00ed\27\3\2\2\2\u00ee\u00ec\3\2\2\2\u00ef\u00f0"+
		"\7\63\2\2\u00f0\31\3\2\2\2\u00f1\u00f3\7\27\2\2\u00f2\u00f4\7\25\2\2\u00f3"+
		"\u00f2\3\2\2\2\u00f3\u00f4\3\2\2\2\u00f4\u00f5\3\2\2\2\u00f5\u00f7\5Z"+
		".\2\u00f6\u00f8\5\34\17\2\u00f7\u00f6\3\2\2\2\u00f7\u00f8\3\2\2\2\u00f8"+
		"\u00fd\3\2\2\2\u00f9\u00fa\7$\2\2\u00fa\u00fb\5\36\20\2\u00fb\u00fc\7"+
		"%\2\2\u00fc\u00fe\3\2\2\2\u00fd\u00f9\3\2\2\2\u00fd\u00fe\3\2\2\2\u00fe"+
		"\u00ff\3\2\2\2\u00ff\u0100\7\3\2\2\u0100\u0108\3\2\2\2\u0101\u0102\7\27"+
		"\2\2\u0102\u0103\7$\2\2\u0103\u0104\5\36\20\2\u0104\u0105\7%\2\2\u0105"+
		"\u0106\7\3\2\2\u0106\u0108\3\2\2\2\u0107\u00f1\3\2\2\2\u0107\u0101\3\2"+
		"\2\2\u0108\33\3\2\2\2\u0109\u010a\7+\2\2\u010a\u010b\5Z.\2\u010b\35\3"+
		"\2\2\2\u010c\u0114\5 \21\2\u010d\u010e\5 \21\2\u010e\u010f\7\4\2\2\u010f"+
		"\u0111\5\36\20\2\u0110\u0112\7\4\2\2\u0111\u0110\3\2\2\2\u0111\u0112\3"+
		"\2\2\2\u0112\u0114\3\2\2\2\u0113\u010c\3\2\2\2\u0113\u010d\3\2\2\2\u0114"+
		"\37\3\2\2\2\u0115\u0117\5\30\r\2\u0116\u0115\3\2\2\2\u0117\u011a\3\2\2"+
		"\2\u0118\u0116\3\2\2\2\u0118\u0119\3\2\2\2\u0119\u011b\3\2\2\2\u011a\u0118"+
		"\3\2\2\2\u011b\u011e\5\"\22\2\u011c\u011d\t\4\2\2\u011d\u011f\5X-\2\u011e"+
		"\u011c\3\2\2\2\u011e\u011f\3\2\2\2\u011f\u0121\3\2\2\2\u0120\u0122\5("+
		"\25\2\u0121\u0120\3\2\2\2\u0121\u0122\3\2\2\2\u0122!\3\2\2\2\u0123\u0124"+
		"\7.\2\2\u0124#\3\2\2\2\u0125\u0126\7\30\2\2\u0126\u0128\5L\'\2\u0127\u0129"+
		"\7\3\2\2\u0128\u0127\3\2\2\2\u0128\u0129\3\2\2\2\u0129%\3\2\2\2\u012a"+
		"\u012b\7\"\2\2\u012b\u012c\5Z.\2\u012c\u012d\5`\61\2\u012d\u012e\7\3\2"+
		"\2\u012e\'\3\2\2\2\u012f\u0130\5*\26\2\u0130\u0131\7\5\2\2\u0131\u0132"+
		"\5,\27\2\u0132\u0134\7\6\2\2\u0133\u0135\7\3\2\2\u0134\u0133\3\2\2\2\u0134"+
		"\u0135\3\2\2\2\u0135)\3\2\2\2\u0136\u0137\7.\2\2\u0137+\3\2\2\2\u0138"+
		"\u013a\5.\30\2\u0139\u0138\3\2\2\2\u0139\u013a\3\2\2\2\u013a-\3\2\2\2"+
		"\u013b\u0141\5\60\31\2\u013c\u013d\5\60\31\2\u013d\u013e\7\4\2\2\u013e"+
		"\u013f\5.\30\2\u013f\u0141\3\2\2\2\u0140\u013b\3\2\2\2\u0140\u013c\3\2"+
		"\2\2\u0141/\3\2\2\2\u0142\u014e\5\62\32\2\u0143\u0144\5\62\32\2\u0144"+
		"\u0145\7\7\2\2\u0145\u0146\5\64\33\2\u0146\u014e\3\2\2\2\u0147\u0148\5"+
		"\62\32\2\u0148\u0149\7\7\2\2\u0149\u014a\7\5\2\2\u014a\u014b\5.\30\2\u014b"+
		"\u014c\7\6\2\2\u014c\u014e\3\2\2\2\u014d\u0142\3\2\2\2\u014d\u0143\3\2"+
		"\2\2\u014d\u0147\3\2\2\2\u014e\61\3\2\2\2\u014f\u0150\b\32\1\2\u0150\u0153"+
		"\5Z.\2\u0151\u0153\5J&\2\u0152\u014f\3\2\2\2\u0152\u0151\3\2\2\2\u0153"+
		"\u0159\3\2\2\2\u0154\u0155\f\3\2\2\u0155\u0156\7\b\2\2\u0156\u0158\5\62"+
		"\32\4\u0157\u0154\3\2\2\2\u0158\u015b\3\2\2\2\u0159\u0157\3\2\2\2\u0159"+
		"\u015a\3\2\2\2\u015a\63\3\2\2\2\u015b\u0159\3\2\2\2\u015c\u015f\5Z.\2"+
		"\u015d\u015f\5J&\2\u015e\u015c\3\2\2\2\u015e\u015d\3\2\2\2\u015f\65\3"+
		"\2\2\2\u0160\u0161\7\5\2\2\u0161\u0162\58\35\2\u0162\u0163\7\6\2\2\u0163"+
		"\67\3\2\2\2\u0164\u0166\n\5\2\2\u0165\u0164\3\2\2\2\u0166\u0169\3\2\2"+
		"\2\u0167\u0165\3\2\2\2\u0167\u0168\3\2\2\2\u0168\u016f\3\2\2\2\u0169\u0167"+
		"\3\2\2\2\u016a\u016b\7\5\2\2\u016b\u016c\58\35\2\u016c\u016d\7\6\2\2\u016d"+
		"\u016e\58\35\2\u016e\u0170\3\2\2\2\u016f\u016a\3\2\2\2\u016f\u0170\3\2"+
		"\2\2\u01709\3\2\2\2\u0171\u0175\7\23\2\2\u0172\u0175\7\22\2\2\u0173\u0175"+
		"\5b\62\2\u0174\u0171\3\2\2\2\u0174\u0172\3\2\2\2\u0174\u0173\3\2\2\2\u0175"+
		"\u0178\3\2\2\2\u0176\u0174\3\2\2\2\u0176\u0177\3\2\2\2\u0177\u017a\3\2"+
		"\2\2\u0178\u0176\3\2\2\2\u0179\u017b\5n8\2\u017a\u0179\3\2\2\2\u017a\u017b"+
		"\3\2\2\2\u017b\u017c\3\2\2\2\u017c\u017d\5P)\2\u017d\u017f\7\5\2\2\u017e"+
		"\u0180\5B\"\2\u017f\u017e\3\2\2\2\u017f\u0180\3\2\2\2\u0180\u0181\3\2"+
		"\2\2\u0181\u0183\7\6\2\2\u0182\u0184\5f\64\2\u0183\u0182\3\2\2\2\u0183"+
		"\u0184\3\2\2\2\u0184\u0187\3\2\2\2\u0185\u0186\7+\2\2\u0186\u0188\5<\37"+
		"\2\u0187\u0185\3\2\2\2\u0187\u0188\3\2\2\2\u0188\u018b\3\2\2\2\u0189\u018c"+
		"\5L\'\2\u018a\u018c\5p9\2\u018b\u0189\3\2\2\2\u018b\u018a\3\2\2\2\u018b"+
		"\u018c\3\2\2\2\u018c\u018e\3\2\2\2\u018d\u018f\7\3\2\2\u018e\u018d\3\2"+
		"\2\2\u018e\u018f\3\2\2\2\u018f;\3\2\2\2\u0190\u0196\5> \2\u0191\u0192"+
		"\5> \2\u0192\u0193\7\4\2\2\u0193\u0194\5<\37\2\u0194\u0196\3\2\2\2\u0195"+
		"\u0190\3\2\2\2\u0195\u0191\3\2\2\2\u0196=\3\2\2\2\u0197\u0198\5F$\2\u0198"+
		"\u019a\7\5\2\2\u0199\u019b\5H%\2\u019a\u0199\3\2\2\2\u019a\u019b\3\2\2"+
		"\2\u019b\u019c\3\2\2\2\u019c\u019d\7\6\2\2\u019d\u01a2\3\2\2\2\u019e\u019f"+
		"\5F$\2\u019f\u01a0\5\66\34\2\u01a0\u01a2\3\2\2\2\u01a1\u0197\3\2\2\2\u01a1"+
		"\u019e\3\2\2\2\u01a2?\3\2\2\2\u01a3\u01a5\5v<\2\u01a4\u01a3\3\2\2\2\u01a4"+
		"\u01a5\3\2\2\2\u01a5\u01ae\3\2\2\2\u01a6\u01ad\7#\2\2\u01a7\u01ad\5j\66"+
		"\2\u01a8\u01ad\7\22\2\2\u01a9\u01ad\7\34\2\2\u01aa\u01ad\5h\65\2\u01ab"+
		"\u01ad\5b\62\2\u01ac\u01a6\3\2\2\2\u01ac\u01a7\3\2\2\2\u01ac\u01a8\3\2"+
		"\2\2\u01ac\u01a9\3\2\2\2\u01ac\u01aa\3\2\2\2\u01ac\u01ab\3\2\2\2\u01ad"+
		"\u01b0\3\2\2\2\u01ae\u01ac\3\2\2\2\u01ae\u01af\3\2\2\2\u01af\u01b1\3\2"+
		"\2\2\u01b0\u01ae\3\2\2\2\u01b1\u01b2\5Z.\2\u01b2\u01b3\5P)\2\u01b3\u01b5"+
		"\7\5\2\2\u01b4\u01b6\5B\"\2\u01b5\u01b4\3\2\2\2\u01b5\u01b6\3\2\2\2\u01b6"+
		"\u01b7\3\2\2\2\u01b7\u01b9\7\6\2\2\u01b8\u01ba\5f\64\2\u01b9\u01b8\3\2"+
		"\2\2\u01b9\u01ba\3\2\2\2\u01ba\u01bc\3\2\2\2\u01bb\u01bd\5d\63\2\u01bc"+
		"\u01bb\3\2\2\2\u01bc\u01bd\3\2\2\2\u01bd\u01bf\3\2\2\2\u01be\u01c0\5l"+
		"\67\2\u01bf\u01be\3\2\2\2\u01bf\u01c0\3\2\2\2\u01c0\u01c3\3\2\2\2\u01c1"+
		"\u01c4\5L\'\2\u01c2\u01c4\5p9\2\u01c3\u01c1\3\2\2\2\u01c3\u01c2\3\2\2"+
		"\2\u01c3\u01c4\3\2\2\2\u01c4\u01c6\3\2\2\2\u01c5\u01c7\7\3\2\2\u01c6\u01c5"+
		"\3\2\2\2\u01c6\u01c7\3\2\2\2\u01c7A\3\2\2\2\u01c8\u01ce\5D#\2\u01c9\u01ca"+
		"\5D#\2\u01ca\u01cb\7\4\2\2\u01cb\u01cc\5B\"\2\u01cc\u01ce\3\2\2\2\u01cd"+
		"\u01c8\3\2\2\2\u01cd\u01c9\3\2\2\2\u01ceC\3\2\2\2\u01cf\u01d5\5Z.\2\u01d0"+
		"\u01d3\5F$\2\u01d1\u01d2\7\7\2\2\u01d2\u01d4\5H%\2\u01d3\u01d1\3\2\2\2"+
		"\u01d3\u01d4\3\2\2\2\u01d4\u01d6\3\2\2\2\u01d5\u01d0\3\2\2\2\u01d5\u01d6"+
		"\3\2\2\2\u01d6E\3\2\2\2\u01d7\u01d8\7.\2\2\u01d8G\3\2\2\2\u01d9\u01de"+
		"\5J&\2\u01da\u01db\7\4\2\2\u01db\u01dd\5J&\2\u01dc\u01da\3\2\2\2\u01dd"+
		"\u01e0\3\2\2\2\u01de\u01dc\3\2\2\2\u01de\u01df\3\2\2\2\u01dfI\3\2\2\2"+
		"\u01e0\u01de\3\2\2\2\u01e1\u01e4\5\\/\2\u01e2\u01e4\5^\60\2\u01e3\u01e1"+
		"\3\2\2\2\u01e3\u01e2\3\2\2\2\u01e3\u01e4\3\2\2\2\u01e4\u01e5\3\2\2\2\u01e5"+
		"\u01ec\t\6\2\2\u01e6\u01e8\t\7\2\2\u01e7\u01e6\3\2\2\2\u01e8\u01e9\3\2"+
		"\2\2\u01e9\u01e7\3\2\2\2\u01e9\u01ea\3\2\2\2\u01ea\u01eb\3\2\2\2\u01eb"+
		"\u01ed\t\6\2\2\u01ec\u01e7\3\2\2\2\u01ec\u01ed\3\2\2\2\u01ed\u01f3\3\2"+
		"\2\2\u01ee\u01f0\7\5\2\2\u01ef\u01f1\5H%\2\u01f0\u01ef\3\2\2\2\u01f0\u01f1"+
		"\3\2\2\2\u01f1\u01f2\3\2\2\2\u01f2\u01f4\7\6\2\2\u01f3\u01ee\3\2\2\2\u01f3"+
		"\u01f4\3\2\2\2\u01f4K\3\2\2\2\u01f5\u01f6\7$\2\2\u01f6\u01f7\5N(\2\u01f7"+
		"\u01f8\7%\2\2\u01f8M\3\2\2\2\u01f9\u01fb\n\b\2\2\u01fa\u01f9\3\2\2\2\u01fb"+
		"\u01fe\3\2\2\2\u01fc\u01fa\3\2\2\2\u01fc\u01fd\3\2\2\2\u01fd\u0204\3\2"+
		"\2\2\u01fe\u01fc\3\2\2\2\u01ff\u0200\7$\2\2\u0200\u0201\5N(\2\u0201\u0202"+
		"\7%\2\2\u0202\u0203\5N(\2\u0203\u0205\3\2\2\2\u0204\u01ff\3\2\2\2\u0204"+
		"\u0205\3\2\2\2\u0205O\3\2\2\2\u0206\u020a\7.\2\2\u0207\u0208\7+\2\2\u0208"+
		"\u0209\7+\2\2\u0209\u020b\5P)\2\u020a\u0207\3\2\2\2\u020a\u020b\3\2\2"+
		"\2\u020b\u020f\3\2\2\2\u020c\u020d\7!\2\2\u020d\u020f\5R*\2\u020e\u0206"+
		"\3\2\2\2\u020e\u020c\3\2\2\2\u020fQ\3\2\2\2\u0210\u0212\t\t\2\2\u0211"+
		"\u0210\3\2\2\2\u0212\u0213\3\2\2\2\u0213\u0211\3\2\2\2\u0213\u0214\3\2"+
		"\2\2\u0214S\3\2\2\2\u0215\u0219\7\35\2\2\u0216\u0219\7\34\2\2\u0217\u0219"+
		"\5h\65\2\u0218\u0215\3\2\2\2\u0218\u0216\3\2\2\2\u0218\u0217\3\2\2\2\u0219"+
		"\u021c\3\2\2\2\u021a\u0218\3\2\2\2\u021a\u021b\3\2\2\2\u021b\u021d\3\2"+
		"\2\2\u021c\u021a\3\2\2\2\u021d\u021e\5Z.\2\u021e\u0220\5V,\2\u021f\u0221"+
		"\5r:\2\u0220\u021f\3\2\2\2\u0220\u0221\3\2\2\2\u0221\u0224\3\2\2\2\u0222"+
		"\u0223\t\4\2\2\u0223\u0225\5X-\2\u0224\u0222\3\2\2\2\u0224\u0225\3\2\2"+
		"\2\u0225\u0226\3\2\2\2\u0226\u0227\7\3\2\2\u0227U\3\2\2\2\u0228\u0229"+
		"\7.\2\2\u0229W\3\2\2\2\u022a\u022f\7.\2\2\u022b\u022c\7\5\2\2\u022c\u022d"+
		"\5X-\2\u022d\u022e\7\6\2\2\u022e\u0230\3\2\2\2\u022f\u022b\3\2\2\2\u022f"+
		"\u0230\3\2\2\2\u0230\u0233\3\2\2\2\u0231\u0233\5J&\2\u0232\u022a\3\2\2"+
		"\2\u0232\u0231\3\2\2\2\u0233Y\3\2\2\2\u0234\u0236\5f\64\2\u0235\u0234"+
		"\3\2\2\2\u0235\u0236\3\2\2\2\u0236\u0238\3\2\2\2\u0237\u0239\5\f\7\2\u0238"+
		"\u0237\3\2\2\2\u0238\u0239\3\2\2\2\u0239\u023c\3\2\2\2\u023a\u023d\5\\"+
		"/\2\u023b\u023d\5^\60\2\u023c\u023a\3\2\2\2\u023c\u023b\3\2\2\2\u023c"+
		"\u023d\3\2\2\2\u023d\u023e\3\2\2\2\u023e\u0241\5`\61\2\u023f\u0242\5\\"+
		"/\2\u0240\u0242\5^\60\2\u0241\u023f\3\2\2\2\u0241\u0240\3\2\2\2\u0241"+
		"\u0242\3\2\2\2\u0242\u0244\3\2\2\2\u0243\u0245\5f\64\2\u0244\u0243\3\2"+
		"\2\2\u0244\u0245\3\2\2\2\u0245\u0248\3\2\2\2\u0246\u0249\5\\/\2\u0247"+
		"\u0249\5^\60\2\u0248\u0246\3\2\2\2\u0248\u0247\3\2\2\2\u0248\u0249\3\2"+
		"\2\2\u0249[\3\2\2\2\u024a\u024b\7\r\2\2\u024b]\3\2\2\2\u024c\u024d\7\16"+
		"\2\2\u024d_\3\2\2\2\u024e\u0252\7.\2\2\u024f\u0250\7+\2\2\u0250\u0251"+
		"\7+\2\2\u0251\u0253\7.\2\2\u0252\u024f\3\2\2\2\u0252\u0253\3\2\2\2\u0253"+
		"\u0266\3\2\2\2\u0254\u0255\7.\2\2\u0255\u0258\7\t\2\2\u0256\u0259\5Z."+
		"\2\u0257\u0259\7/\2\2\u0258\u0256\3\2\2\2\u0258\u0257\3\2\2\2\u0259\u0261"+
		"\3\2\2\2\u025a\u025d\7\4\2\2\u025b\u025e\5Z.\2\u025c\u025e\7/\2\2\u025d"+
		"\u025b\3\2\2\2\u025d\u025c\3\2\2\2\u025e\u0260\3\2\2\2\u025f\u025a\3\2"+
		"\2\2\u0260\u0263\3\2\2\2\u0261\u025f\3\2\2\2\u0261\u0262\3\2\2\2\u0262"+
		"\u0264\3\2\2\2\u0263\u0261\3\2\2\2\u0264\u0266\7\n\2\2\u0265\u024e\3\2"+
		"\2\2\u0265\u0254\3\2\2\2\u0266a\3\2\2\2\u0267\u0268\7\24\2\2\u0268c\3"+
		"\2\2\2\u0269\u026a\7\36\2\2\u026ae\3\2\2\2\u026b\u026c\7\31\2\2\u026c"+
		"g\3\2\2\2\u026d\u026e\7\33\2\2\u026ei\3\2\2\2\u026f\u0270\7 \2\2\u0270"+
		"k\3\2\2\2\u0271\u0272\7\32\2\2\u0272m\3\2\2\2\u0273\u0274\7&\2\2\u0274"+
		"o\3\2\2\2\u0275\u0276\7\7\2\2\u0276\u0277\7\'\2\2\u0277q\3\2\2\2\u0278"+
		"\u0279\7\13\2\2\u0279\u027a\5t;\2\u027a\u027b\7\f\2\2\u027bs\3\2\2\2\u027c"+
		"\u027d\7/\2\2\u027du\3\2\2\2\u027e\u027f\7\37\2\2\u027f\u0281\7\t\2\2"+
		"\u0280\u0282\5x=\2\u0281\u0280\3\2\2\2\u0281\u0282\3\2\2\2\u0282\u0283"+
		"\3\2\2\2\u0283\u0284\7\n\2\2\u0284w\3\2\2\2\u0285\u028b\5z>\2\u0286\u0287"+
		"\5z>\2\u0287\u0288\7\4\2\2\u0288\u0289\5x=\2\u0289\u028b\3\2\2\2\u028a"+
		"\u0285\3\2\2\2\u028a\u0286\3\2\2\2\u028by\3\2\2\2\u028c\u028e\5|?\2\u028d"+
		"\u028f\5~@\2\u028e\u028d\3\2\2\2\u028e\u028f\3\2\2\2\u028f\u0292\3\2\2"+
		"\2\u0290\u0291\7\7\2\2\u0291\u0293\5X-\2\u0292\u0290\3\2\2\2\u0292\u0293"+
		"\3\2\2\2\u0293{\3\2\2\2\u0294\u0295\t\n\2\2\u0295}\3\2\2\2\u0296\u0297"+
		"\7.\2\2\u0297\177\3\2\2\2\u0298\u0299\5\u0082B\2\u0299\u029a\7+\2\2\u029a"+
		"\u0081\3\2\2\2\u029b\u029c\t\13\2\2\u029c\u0083\3\2\2\2\u029d\u029e\t"+
		"\f\2\2\u029e\u0085\3\2\2\2\\\u0090\u0092\u009b\u00a0\u00a8\u00ad\u00b0"+
		"\u00b5\u00b9\u00bf\u00c8\u00cc\u00d2\u00dc\u00ea\u00ec\u00f3\u00f7\u00fd"+
		"\u0107\u0111\u0113\u0118\u011e\u0121\u0128\u0134\u0139\u0140\u014d\u0152"+
		"\u0159\u015e\u0167\u016f\u0174\u0176\u017a\u017f\u0183\u0187\u018b\u018e"+
		"\u0195\u019a\u01a1\u01a4\u01ac\u01ae\u01b5\u01b9\u01bc\u01bf\u01c3\u01c6"+
		"\u01cd\u01d3\u01d5\u01de\u01e3\u01e9\u01ec\u01f0\u01f3\u01fc\u0204\u020a"+
		"\u020e\u0213\u0218\u021a\u0220\u0224\u022f\u0232\u0235\u0238\u023c\u0241"+
		"\u0244\u0248\u0252\u0258\u025d\u0261\u0265\u0281\u028a\u028e\u0292";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}