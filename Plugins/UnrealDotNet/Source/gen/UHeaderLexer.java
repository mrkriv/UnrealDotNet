// Generated from C:/Users/mrkriv/Documents/Unreal Projects/UnrealDotNet/Plugins/UnrealDotNet/Source/CodeGenerator/UHeader\UHeader.g4 by ANTLR 4.7.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class UHeaderLexer extends Lexer {
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
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
			"T__9", "PtrQuant", "RefQuant", "Private", "Protected", "Public", "Inline", 
			"Explicit", "Virtual", "Class", "Struct", "Enum", "Union", "Const", "Final", 
			"Static", "Extern", "Mutable", "Override", "Template", "Friend", "Operator", 
			"Typedef", "Constexpr", "BracketsOpen", "BracketsClose", "Tilda", "Delete", 
			"GCC_ALIGN", "Namespace", "Typename", "DotDot", "SingleLineDerective", 
			"MultiLineDerective", "Identifier", "NONDIGIT", "DIGIT", "Literal", "RealDIGIT", 
			"Schar", "Boolean", "SomeEscapeSequence", "SIGN", "SpecalSymbol", "Whitespace", 
			"Newline", "ExportComment", "BlockComment", "LineComment"
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


	public UHeaderLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "UHeader.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\65\u022b\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31"+
		"\t\31\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t"+
		" \4!\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t"+
		"+\4,\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64"+
		"\t\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\3\2\3\2\3"+
		"\3\3\3\3\4\3\4\3\5\3\5\3\6\3\6\3\7\3\7\3\b\3\b\3\t\3\t\3\n\3\n\3\13\3"+
		"\13\3\f\3\f\3\r\3\r\3\16\3\16\3\16\3\16\3\16\3\16\3\16\3\16\3\17\3\17"+
		"\3\17\3\17\3\17\3\17\3\17\3\17\3\17\3\17\3\20\3\20\3\20\3\20\3\20\3\20"+
		"\3\20\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21"+
		"\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21"+
		"\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\5\21\u00d0"+
		"\n\21\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\23\3\23\3\23\3\23"+
		"\3\23\3\23\3\23\3\23\3\24\3\24\3\24\3\24\3\24\3\24\3\25\3\25\3\25\3\25"+
		"\3\25\3\25\3\25\3\26\3\26\3\26\3\26\3\26\3\27\3\27\3\27\3\27\3\27\3\27"+
		"\3\30\3\30\3\30\3\30\3\30\3\30\3\31\3\31\3\31\3\31\3\31\3\31\3\32\3\32"+
		"\3\32\3\32\3\32\3\32\3\32\3\33\3\33\3\33\3\33\3\33\3\33\3\33\3\34\3\34"+
		"\3\34\3\34\3\34\3\34\3\34\3\34\3\35\3\35\3\35\3\35\3\35\3\35\3\35\3\35"+
		"\3\35\3\36\3\36\3\36\3\36\3\36\3\36\3\36\3\36\3\36\3\37\3\37\3\37\3\37"+
		"\3\37\3\37\3\37\3 \3 \3 \3 \3 \3 \3 \3 \3 \3!\3!\3!\3!\3!\3!\3!\3!\3\""+
		"\3\"\3\"\3\"\3\"\3\"\3\"\3\"\3\"\3\"\3#\3#\3$\3$\3%\3%\3&\3&\3&\3&\3&"+
		"\3&\3&\3\'\3\'\3\'\3\'\3\'\3\'\3\'\3\'\3\'\3\'\3(\3(\3(\3(\3(\3(\3(\3"+
		"(\3(\3(\3)\3)\3)\3)\3)\3)\3)\3)\3)\3*\3*\3+\3+\6+\u017f\n+\r+\16+\u0180"+
		"\3,\3,\7,\u0185\n,\f,\16,\u0188\13,\3,\3,\5,\u018c\n,\3,\6,\u018f\n,\r"+
		",\16,\u0190\3,\6,\u0194\n,\r,\16,\u0195\3-\3-\3-\3-\7-\u019c\n-\f-\16"+
		"-\u019f\13-\3.\3.\3/\3/\3\60\3\60\3\60\3\60\3\60\3\60\6\60\u01ab\n\60"+
		"\r\60\16\60\u01ac\3\60\3\60\7\60\u01b1\n\60\f\60\16\60\u01b4\13\60\3\60"+
		"\5\60\u01b7\n\60\3\61\7\61\u01ba\n\61\f\61\16\61\u01bd\13\61\3\61\5\61"+
		"\u01c0\n\61\3\61\6\61\u01c3\n\61\r\61\16\61\u01c4\3\61\5\61\u01c8\n\61"+
		"\3\61\6\61\u01cb\n\61\r\61\16\61\u01cc\3\61\3\61\5\61\u01d1\n\61\5\61"+
		"\u01d3\n\61\3\62\3\62\5\62\u01d7\n\62\3\63\3\63\3\63\3\63\3\63\3\63\3"+
		"\63\3\63\3\63\5\63\u01e2\n\63\3\64\3\64\3\64\3\64\3\64\3\64\3\64\3\64"+
		"\3\64\3\64\3\64\3\64\5\64\u01f0\n\64\3\65\3\65\3\66\3\66\3\67\6\67\u01f7"+
		"\n\67\r\67\16\67\u01f8\3\67\3\67\38\38\58\u01ff\n8\38\58\u0202\n8\38\3"+
		"8\39\39\39\39\39\79\u020b\n9\f9\169\u020e\139\39\39\39\3:\3:\3:\3:\7:"+
		"\u0217\n:\f:\16:\u021a\13:\3:\3:\3:\3:\3:\3;\3;\3;\3;\7;\u0225\n;\f;\16"+
		";\u0228\13;\3;\3;\5\u0186\u020c\u0218\2<\3\3\5\4\7\5\t\6\13\7\r\b\17\t"+
		"\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23%\24\'\25)\26+\27"+
		"-\30/\31\61\32\63\33\65\34\67\359\36;\37= ?!A\"C#E$G%I&K\'M(O)Q*S+U,W"+
		"-Y.[\2]\2_/a\2c\2e\2g\2i\2k\60m\61o\62q\63s\64u\65\3\2\n\3\2\f\f\5\2C"+
		"\\aac|\3\2\62;\6\2\f\f\17\17$$^^\4\2--//\13\2\13\f\17\17\"\"((,,\62;C"+
		"\\aac|\4\2\13\13\"\"\4\2\f\f\17\17\2\u0246\2\3\3\2\2\2\2\5\3\2\2\2\2\7"+
		"\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2"+
		"\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2"+
		"\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3\2\2\2"+
		"\2)\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63\3\2\2\2"+
		"\2\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2;\3\2\2\2\2=\3\2\2\2\2?\3\2\2\2"+
		"\2A\3\2\2\2\2C\3\2\2\2\2E\3\2\2\2\2G\3\2\2\2\2I\3\2\2\2\2K\3\2\2\2\2M"+
		"\3\2\2\2\2O\3\2\2\2\2Q\3\2\2\2\2S\3\2\2\2\2U\3\2\2\2\2W\3\2\2\2\2Y\3\2"+
		"\2\2\2_\3\2\2\2\2k\3\2\2\2\2m\3\2\2\2\2o\3\2\2\2\2q\3\2\2\2\2s\3\2\2\2"+
		"\2u\3\2\2\2\3w\3\2\2\2\5y\3\2\2\2\7{\3\2\2\2\t}\3\2\2\2\13\177\3\2\2\2"+
		"\r\u0081\3\2\2\2\17\u0083\3\2\2\2\21\u0085\3\2\2\2\23\u0087\3\2\2\2\25"+
		"\u0089\3\2\2\2\27\u008b\3\2\2\2\31\u008d\3\2\2\2\33\u008f\3\2\2\2\35\u0097"+
		"\3\2\2\2\37\u00a1\3\2\2\2!\u00cf\3\2\2\2#\u00d1\3\2\2\2%\u00da\3\2\2\2"+
		"\'\u00e2\3\2\2\2)\u00e8\3\2\2\2+\u00ef\3\2\2\2-\u00f4\3\2\2\2/\u00fa\3"+
		"\2\2\2\61\u0100\3\2\2\2\63\u0106\3\2\2\2\65\u010d\3\2\2\2\67\u0114\3\2"+
		"\2\29\u011c\3\2\2\2;\u0125\3\2\2\2=\u012e\3\2\2\2?\u0135\3\2\2\2A\u013e"+
		"\3\2\2\2C\u0146\3\2\2\2E\u0150\3\2\2\2G\u0152\3\2\2\2I\u0154\3\2\2\2K"+
		"\u0156\3\2\2\2M\u015d\3\2\2\2O\u0167\3\2\2\2Q\u0171\3\2\2\2S\u017a\3\2"+
		"\2\2U\u017c\3\2\2\2W\u0182\3\2\2\2Y\u0197\3\2\2\2[\u01a0\3\2\2\2]\u01a2"+
		"\3\2\2\2_\u01b6\3\2\2\2a\u01d2\3\2\2\2c\u01d6\3\2\2\2e\u01e1\3\2\2\2g"+
		"\u01ef\3\2\2\2i\u01f1\3\2\2\2k\u01f3\3\2\2\2m\u01f6\3\2\2\2o\u0201\3\2"+
		"\2\2q\u0205\3\2\2\2s\u0212\3\2\2\2u\u0220\3\2\2\2wx\7=\2\2x\4\3\2\2\2"+
		"yz\7.\2\2z\6\3\2\2\2{|\7*\2\2|\b\3\2\2\2}~\7+\2\2~\n\3\2\2\2\177\u0080"+
		"\7?\2\2\u0080\f\3\2\2\2\u0081\u0082\7~\2\2\u0082\16\3\2\2\2\u0083\u0084"+
		"\7>\2\2\u0084\20\3\2\2\2\u0085\u0086\7@\2\2\u0086\22\3\2\2\2\u0087\u0088"+
		"\7]\2\2\u0088\24\3\2\2\2\u0089\u008a\7_\2\2\u008a\26\3\2\2\2\u008b\u008c"+
		"\7,\2\2\u008c\30\3\2\2\2\u008d\u008e\7(\2\2\u008e\32\3\2\2\2\u008f\u0090"+
		"\7r\2\2\u0090\u0091\7t\2\2\u0091\u0092\7k\2\2\u0092\u0093\7x\2\2\u0093"+
		"\u0094\7c\2\2\u0094\u0095\7v\2\2\u0095\u0096\7g\2\2\u0096\34\3\2\2\2\u0097"+
		"\u0098\7r\2\2\u0098\u0099\7t\2\2\u0099\u009a\7q\2\2\u009a\u009b\7v\2\2"+
		"\u009b\u009c\7g\2\2\u009c\u009d\7e\2\2\u009d\u009e\7v\2\2\u009e\u009f"+
		"\7g\2\2\u009f\u00a0\7f\2\2\u00a0\36\3\2\2\2\u00a1\u00a2\7r\2\2\u00a2\u00a3"+
		"\7w\2\2\u00a3\u00a4\7d\2\2\u00a4\u00a5\7n\2\2\u00a5\u00a6\7k\2\2\u00a6"+
		"\u00a7\7e\2\2\u00a7 \3\2\2\2\u00a8\u00a9\7k\2\2\u00a9\u00aa\7p\2\2\u00aa"+
		"\u00ab\7n\2\2\u00ab\u00ac\7k\2\2\u00ac\u00ad\7p\2\2\u00ad\u00d0\7g\2\2"+
		"\u00ae\u00af\7H\2\2\u00af\u00b0\7Q\2\2\u00b0\u00b1\7T\2\2\u00b1\u00b2"+
		"\7E\2\2\u00b2\u00b3\7G\2\2\u00b3\u00b4\7K\2\2\u00b4\u00b5\7P\2\2\u00b5"+
		"\u00b6\7N\2\2\u00b6\u00b7\7K\2\2\u00b7\u00b8\7P\2\2\u00b8\u00d0\7G\2\2"+
		"\u00b9\u00ba\7H\2\2\u00ba\u00bb\7Q\2\2\u00bb\u00bc\7T\2\2\u00bc\u00bd"+
		"\7E\2\2\u00bd\u00be\7G\2\2\u00be\u00bf\7K\2\2\u00bf\u00c0\7P\2\2\u00c0"+
		"\u00c1\7N\2\2\u00c1\u00c2\7K\2\2\u00c2\u00c3\7P\2\2\u00c3\u00c4\7G\2\2"+
		"\u00c4\u00c5\7a\2\2\u00c5\u00c6\7F\2\2\u00c6\u00c7\7G\2\2\u00c7\u00c8"+
		"\7D\2\2\u00c8\u00c9\7W\2\2\u00c9\u00ca\7I\2\2\u00ca\u00cb\7I\2\2\u00cb"+
		"\u00cc\7C\2\2\u00cc\u00cd\7D\2\2\u00cd\u00ce\7N\2\2\u00ce\u00d0\7G\2\2"+
		"\u00cf\u00a8\3\2\2\2\u00cf\u00ae\3\2\2\2\u00cf\u00b9\3\2\2\2\u00d0\"\3"+
		"\2\2\2\u00d1\u00d2\7g\2\2\u00d2\u00d3\7z\2\2\u00d3\u00d4\7r\2\2\u00d4"+
		"\u00d5\7n\2\2\u00d5\u00d6\7k\2\2\u00d6\u00d7\7e\2\2\u00d7\u00d8\7k\2\2"+
		"\u00d8\u00d9\7v\2\2\u00d9$\3\2\2\2\u00da\u00db\7x\2\2\u00db\u00dc\7k\2"+
		"\2\u00dc\u00dd\7t\2\2\u00dd\u00de\7v\2\2\u00de\u00df\7w\2\2\u00df\u00e0"+
		"\7c\2\2\u00e0\u00e1\7n\2\2\u00e1&\3\2\2\2\u00e2\u00e3\7e\2\2\u00e3\u00e4"+
		"\7n\2\2\u00e4\u00e5\7c\2\2\u00e5\u00e6\7u\2\2\u00e6\u00e7\7u\2\2\u00e7"+
		"(\3\2\2\2\u00e8\u00e9\7u\2\2\u00e9\u00ea\7v\2\2\u00ea\u00eb\7t\2\2\u00eb"+
		"\u00ec\7w\2\2\u00ec\u00ed\7e\2\2\u00ed\u00ee\7v\2\2\u00ee*\3\2\2\2\u00ef"+
		"\u00f0\7g\2\2\u00f0\u00f1\7p\2\2\u00f1\u00f2\7w\2\2\u00f2\u00f3\7o\2\2"+
		"\u00f3,\3\2\2\2\u00f4\u00f5\7w\2\2\u00f5\u00f6\7p\2\2\u00f6\u00f7\7k\2"+
		"\2\u00f7\u00f8\7q\2\2\u00f8\u00f9\7p\2\2\u00f9.\3\2\2\2\u00fa\u00fb\7"+
		"e\2\2\u00fb\u00fc\7q\2\2\u00fc\u00fd\7p\2\2\u00fd\u00fe\7u\2\2\u00fe\u00ff"+
		"\7v\2\2\u00ff\60\3\2\2\2\u0100\u0101\7h\2\2\u0101\u0102\7k\2\2\u0102\u0103"+
		"\7p\2\2\u0103\u0104\7c\2\2\u0104\u0105\7n\2\2\u0105\62\3\2\2\2\u0106\u0107"+
		"\7u\2\2\u0107\u0108\7v\2\2\u0108\u0109\7c\2\2\u0109\u010a\7v\2\2\u010a"+
		"\u010b\7k\2\2\u010b\u010c\7e\2\2\u010c\64\3\2\2\2\u010d\u010e\7g\2\2\u010e"+
		"\u010f\7z\2\2\u010f\u0110\7v\2\2\u0110\u0111\7g\2\2\u0111\u0112\7t\2\2"+
		"\u0112\u0113\7p\2\2\u0113\66\3\2\2\2\u0114\u0115\7o\2\2\u0115\u0116\7"+
		"w\2\2\u0116\u0117\7v\2\2\u0117\u0118\7c\2\2\u0118\u0119\7d\2\2\u0119\u011a"+
		"\7n\2\2\u011a\u011b\7g\2\2\u011b8\3\2\2\2\u011c\u011d\7q\2\2\u011d\u011e"+
		"\7x\2\2\u011e\u011f\7g\2\2\u011f\u0120\7t\2\2\u0120\u0121\7t\2\2\u0121"+
		"\u0122\7k\2\2\u0122\u0123\7f\2\2\u0123\u0124\7g\2\2\u0124:\3\2\2\2\u0125"+
		"\u0126\7v\2\2\u0126\u0127\7g\2\2\u0127\u0128\7o\2\2\u0128\u0129\7r\2\2"+
		"\u0129\u012a\7n\2\2\u012a\u012b\7c\2\2\u012b\u012c\7v\2\2\u012c\u012d"+
		"\7g\2\2\u012d<\3\2\2\2\u012e\u012f\7h\2\2\u012f\u0130\7t\2\2\u0130\u0131"+
		"\7k\2\2\u0131\u0132\7g\2\2\u0132\u0133\7p\2\2\u0133\u0134\7f\2\2\u0134"+
		">\3\2\2\2\u0135\u0136\7q\2\2\u0136\u0137\7r\2\2\u0137\u0138\7g\2\2\u0138"+
		"\u0139\7t\2\2\u0139\u013a\7c\2\2\u013a\u013b\7v\2\2\u013b\u013c\7q\2\2"+
		"\u013c\u013d\7t\2\2\u013d@\3\2\2\2\u013e\u013f\7v\2\2\u013f\u0140\7{\2"+
		"\2\u0140\u0141\7r\2\2\u0141\u0142\7g\2\2\u0142\u0143\7f\2\2\u0143\u0144"+
		"\7g\2\2\u0144\u0145\7h\2\2\u0145B\3\2\2\2\u0146\u0147\7E\2\2\u0147\u0148"+
		"\7Q\2\2\u0148\u0149\7P\2\2\u0149\u014a\7U\2\2\u014a\u014b\7V\2\2\u014b"+
		"\u014c\7G\2\2\u014c\u014d\7Z\2\2\u014d\u014e\7R\2\2\u014e\u014f\7T\2\2"+
		"\u014fD\3\2\2\2\u0150\u0151\7}\2\2\u0151F\3\2\2\2\u0152\u0153\7\177\2"+
		"\2\u0153H\3\2\2\2\u0154\u0155\7\u0080\2\2\u0155J\3\2\2\2\u0156\u0157\7"+
		"f\2\2\u0157\u0158\7g\2\2\u0158\u0159\7n\2\2\u0159\u015a\7g\2\2\u015a\u015b"+
		"\7v\2\2\u015b\u015c\7g\2\2\u015cL\3\2\2\2\u015d\u015e\7I\2\2\u015e\u015f"+
		"\7E\2\2\u015f\u0160\7E\2\2\u0160\u0161\7a\2\2\u0161\u0162\7C\2\2\u0162"+
		"\u0163\7N\2\2\u0163\u0164\7K\2\2\u0164\u0165\7I\2\2\u0165\u0166\7P\2\2"+
		"\u0166N\3\2\2\2\u0167\u0168\7p\2\2\u0168\u0169\7c\2\2\u0169\u016a\7o\2"+
		"\2\u016a\u016b\7g\2\2\u016b\u016c\7u\2\2\u016c\u016d\7r\2\2\u016d\u016e"+
		"\7c\2\2\u016e\u016f\7e\2\2\u016f\u0170\7g\2\2\u0170P\3\2\2\2\u0171\u0172"+
		"\7v\2\2\u0172\u0173\7{\2\2\u0173\u0174\7r\2\2\u0174\u0175\7g\2\2\u0175"+
		"\u0176\7p\2\2\u0176\u0177\7c\2\2\u0177\u0178\7o\2\2\u0178\u0179\7g\2\2"+
		"\u0179R\3\2\2\2\u017a\u017b\7<\2\2\u017bT\3\2\2\2\u017c\u017e\7%\2\2\u017d"+
		"\u017f\n\2\2\2\u017e\u017d\3\2\2\2\u017f\u0180\3\2\2\2\u0180\u017e\3\2"+
		"\2\2\u0180\u0181\3\2\2\2\u0181V\3\2\2\2\u0182\u018e\7%\2\2\u0183\u0185"+
		"\n\2\2\2\u0184\u0183\3\2\2\2\u0185\u0188\3\2\2\2\u0186\u0187\3\2\2\2\u0186"+
		"\u0184\3\2\2\2\u0187\u0189\3\2\2\2\u0188\u0186\3\2\2\2\u0189\u018b\7^"+
		"\2\2\u018a\u018c\7\17\2\2\u018b\u018a\3\2\2\2\u018b\u018c\3\2\2\2\u018c"+
		"\u018d\3\2\2\2\u018d\u018f\7\f\2\2\u018e\u0186\3\2\2\2\u018f\u0190\3\2"+
		"\2\2\u0190\u018e\3\2\2\2\u0190\u0191\3\2\2\2\u0191\u0193\3\2\2\2\u0192"+
		"\u0194\n\2\2\2\u0193\u0192\3\2\2\2\u0194\u0195\3\2\2\2\u0195\u0193\3\2"+
		"\2\2\u0195\u0196\3\2\2\2\u0196X\3\2\2\2\u0197\u019d\5[.\2\u0198\u019c"+
		"\5[.\2\u0199\u019c\5]/\2\u019a\u019c\7\60\2\2\u019b\u0198\3\2\2\2\u019b"+
		"\u0199\3\2\2\2\u019b\u019a\3\2\2\2\u019c\u019f\3\2\2\2\u019d\u019b\3\2"+
		"\2\2\u019d\u019e\3\2\2\2\u019eZ\3\2\2\2\u019f\u019d\3\2\2\2\u01a0\u01a1"+
		"\t\3\2\2\u01a1\\\3\2\2\2\u01a2\u01a3\t\4\2\2\u01a3^\3\2\2\2\u01a4\u01b7"+
		"\5e\63\2\u01a5\u01b7\5a\61\2\u01a6\u01a7\7\62\2\2\u01a7\u01a8\7z\2\2\u01a8"+
		"\u01aa\3\2\2\2\u01a9\u01ab\5]/\2\u01aa\u01a9\3\2\2\2\u01ab\u01ac\3\2\2"+
		"\2\u01ac\u01aa\3\2\2\2\u01ac\u01ad\3\2\2\2\u01ad\u01b7\3\2\2\2\u01ae\u01b2"+
		"\7$\2\2\u01af\u01b1\5c\62\2\u01b0\u01af\3\2\2\2\u01b1\u01b4\3\2\2\2\u01b2"+
		"\u01b0\3\2\2\2\u01b2\u01b3\3\2\2\2\u01b3\u01b5\3\2\2\2\u01b4\u01b2\3\2"+
		"\2\2\u01b5\u01b7\7$\2\2\u01b6\u01a4\3\2\2\2\u01b6\u01a5\3\2\2\2\u01b6"+
		"\u01a6\3\2\2\2\u01b6\u01ae\3\2\2\2\u01b7`\3\2\2\2\u01b8\u01ba\5]/\2\u01b9"+
		"\u01b8\3\2\2\2\u01ba\u01bd\3\2\2\2\u01bb\u01b9\3\2\2\2\u01bb\u01bc\3\2"+
		"\2\2\u01bc\u01bf\3\2\2\2\u01bd\u01bb\3\2\2\2\u01be\u01c0\7\60\2\2\u01bf"+
		"\u01be\3\2\2\2\u01bf\u01c0\3\2\2\2\u01c0\u01c2\3\2\2\2\u01c1\u01c3\5]"+
		"/\2\u01c2\u01c1\3\2\2\2\u01c3\u01c4\3\2\2\2\u01c4\u01c2\3\2\2\2\u01c4"+
		"\u01c5\3\2\2\2\u01c5\u01c7\3\2\2\2\u01c6\u01c8\7h\2\2\u01c7\u01c6\3\2"+
		"\2\2\u01c7\u01c8\3\2\2\2\u01c8\u01d3\3\2\2\2\u01c9\u01cb\5]/\2\u01ca\u01c9"+
		"\3\2\2\2\u01cb\u01cc\3\2\2\2\u01cc\u01ca\3\2\2\2\u01cc\u01cd\3\2\2\2\u01cd"+
		"\u01ce\3\2\2\2\u01ce\u01d0\7\60\2\2\u01cf\u01d1\7h\2\2\u01d0\u01cf\3\2"+
		"\2\2\u01d0\u01d1\3\2\2\2\u01d1\u01d3\3\2\2\2\u01d2\u01bb\3\2\2\2\u01d2"+
		"\u01ca\3\2\2\2\u01d3b\3\2\2\2\u01d4\u01d7\n\5\2\2\u01d5\u01d7\5g\64\2"+
		"\u01d6\u01d4\3\2\2\2\u01d6\u01d5\3\2\2\2\u01d7d\3\2\2\2\u01d8\u01d9\7"+
		"v\2\2\u01d9\u01da\7t\2\2\u01da\u01db\7w\2\2\u01db\u01e2\7g\2\2\u01dc\u01dd"+
		"\7h\2\2\u01dd\u01de\7c\2\2\u01de\u01df\7n\2\2\u01df\u01e0\7u\2\2\u01e0"+
		"\u01e2\7g\2\2\u01e1\u01d8\3\2\2\2\u01e1\u01dc\3\2\2\2\u01e2f\3\2\2\2\u01e3"+
		"\u01e4\7^\2\2\u01e4\u01f0\7)\2\2\u01e5\u01e6\7^\2\2\u01e6\u01f0\7$\2\2"+
		"\u01e7\u01e8\7^\2\2\u01e8\u01f0\7^\2\2\u01e9\u01ea\7^\2\2\u01ea\u01f0"+
		"\7p\2\2\u01eb\u01ec\7^\2\2\u01ec\u01f0\7t\2\2\u01ed\u01ee\7^\2\2\u01ee"+
		"\u01f0\7v\2\2\u01ef\u01e3\3\2\2\2\u01ef\u01e5\3\2\2\2\u01ef\u01e7\3\2"+
		"\2\2\u01ef\u01e9\3\2\2\2\u01ef\u01eb\3\2\2\2\u01ef\u01ed\3\2\2\2\u01f0"+
		"h\3\2\2\2\u01f1\u01f2\t\6\2\2\u01f2j\3\2\2\2\u01f3\u01f4\n\7\2\2\u01f4"+
		"l\3\2\2\2\u01f5\u01f7\t\b\2\2\u01f6\u01f5\3\2\2\2\u01f7\u01f8\3\2\2\2"+
		"\u01f8\u01f6\3\2\2\2\u01f8\u01f9\3\2\2\2\u01f9\u01fa\3\2\2\2\u01fa\u01fb"+
		"\b\67\2\2\u01fbn\3\2\2\2\u01fc\u01fe\7\17\2\2\u01fd\u01ff\7\f\2\2\u01fe"+
		"\u01fd\3\2\2\2\u01fe\u01ff\3\2\2\2\u01ff\u0202\3\2\2\2\u0200\u0202\7\f"+
		"\2\2\u0201\u01fc\3\2\2\2\u0201\u0200\3\2\2\2\u0202\u0203\3\2\2\2\u0203"+
		"\u0204\b8\2\2\u0204p\3\2\2\2\u0205\u0206\7\61\2\2\u0206\u0207\7,\2\2\u0207"+
		"\u0208\7,\2\2\u0208\u020c\3\2\2\2\u0209\u020b\13\2\2\2\u020a\u0209\3\2"+
		"\2\2\u020b\u020e\3\2\2\2\u020c\u020d\3\2\2\2\u020c\u020a\3\2\2\2\u020d"+
		"\u020f\3\2\2\2\u020e\u020c\3\2\2\2\u020f\u0210\7,\2\2\u0210\u0211\7\61"+
		"\2\2\u0211r\3\2\2\2\u0212\u0213\7\61\2\2\u0213\u0214\7,\2\2\u0214\u0218"+
		"\3\2\2\2\u0215\u0217\13\2\2\2\u0216\u0215\3\2\2\2\u0217\u021a\3\2\2\2"+
		"\u0218\u0219\3\2\2\2\u0218\u0216\3\2\2\2\u0219\u021b\3\2\2\2\u021a\u0218"+
		"\3\2\2\2\u021b\u021c\7,\2\2\u021c\u021d\7\61\2\2\u021d\u021e\3\2\2\2\u021e"+
		"\u021f\b:\2\2\u021ft\3\2\2\2\u0220\u0221\7\61\2\2\u0221\u0222\7\61\2\2"+
		"\u0222\u0226\3\2\2\2\u0223\u0225\n\t\2\2\u0224\u0223\3\2\2\2\u0225\u0228"+
		"\3\2\2\2\u0226\u0224\3\2\2\2\u0226\u0227\3\2\2\2\u0227\u0229\3\2\2\2\u0228"+
		"\u0226\3\2\2\2\u0229\u022a\b;\2\2\u022av\3\2\2\2\36\2\u00cf\u0180\u0186"+
		"\u018b\u0190\u0195\u019b\u019d\u01ac\u01b2\u01b6\u01bb\u01bf\u01c4\u01c7"+
		"\u01cc\u01d0\u01d2\u01d6\u01e1\u01ef\u01f8\u01fe\u0201\u020c\u0218\u0226"+
		"\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}