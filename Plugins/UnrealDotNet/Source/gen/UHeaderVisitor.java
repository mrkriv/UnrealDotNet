// Generated from C:/Users/mrkriv/Documents/Unreal Projects/UnrealDotNet/Plugins/UnrealDotNet/Source/CodeGenerator/UHeader\UHeader.g4 by ANTLR 4.7.2
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link UHeaderParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface UHeaderVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#translationUnit}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTranslationUnit(UHeaderParser.TranslationUnitContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#namespaceUnit}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNamespaceUnit(UHeaderParser.NamespaceUnitContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#namespaceName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNamespaceName(UHeaderParser.NamespaceNameContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#typePreDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTypePreDeclaration(UHeaderParser.TypePreDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#classDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitClassDeclaration(UHeaderParser.ClassDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#classOrStructOrEnum}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitClassOrStructOrEnum(UHeaderParser.ClassOrStructOrEnumContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#classOrStruct}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitClassOrStruct(UHeaderParser.ClassOrStructContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#classParentList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitClassParentList(UHeaderParser.ClassParentListContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#classAlignDefine}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitClassAlignDefine(UHeaderParser.ClassAlignDefineContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#classAlignValue}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitClassAlignValue(UHeaderParser.ClassAlignValueContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#classBody}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitClassBody(UHeaderParser.ClassBodyContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#comment}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitComment(UHeaderParser.CommentContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#enumDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumDeclaration(UHeaderParser.EnumDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#enumParent}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumParent(UHeaderParser.EnumParentContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#enumElementList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumElementList(UHeaderParser.EnumElementListContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#enumElement}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumElement(UHeaderParser.EnumElementContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#enumElementName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEnumElementName(UHeaderParser.EnumElementNameContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#unionDeclaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUnionDeclaration(UHeaderParser.UnionDeclarationContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#typeDefine}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTypeDefine(UHeaderParser.TypeDefineContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#uDefine}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUDefine(UHeaderParser.UDefineContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#uDefineName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUDefineName(UHeaderParser.UDefineNameContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#uMeta}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUMeta(UHeaderParser.UMetaContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#uMetaParametrList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUMetaParametrList(UHeaderParser.UMetaParametrListContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#uMetaParametr}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUMetaParametr(UHeaderParser.UMetaParametrContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#uMetaParamKey}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUMetaParamKey(UHeaderParser.UMetaParamKeyContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#uMetaParamValue}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUMetaParamValue(UHeaderParser.UMetaParamValueContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#undefineBlock}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUndefineBlock(UHeaderParser.UndefineBlockContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#undefineContent}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUndefineContent(UHeaderParser.UndefineContentContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#constructor}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitConstructor(UHeaderParser.ConstructorContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#constructorInitializerList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitConstructorInitializerList(UHeaderParser.ConstructorInitializerListContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#constructorInitializer}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitConstructorInitializer(UHeaderParser.ConstructorInitializerContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#method}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethod(UHeaderParser.MethodContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#methodParamsList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethodParamsList(UHeaderParser.MethodParamsListContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#methodParametr}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethodParametr(UHeaderParser.MethodParametrContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#methodParametrName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethodParametrName(UHeaderParser.MethodParametrNameContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#methodParametrDefaultValue}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethodParametrDefaultValue(UHeaderParser.MethodParametrDefaultValueContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#value}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitValue(UHeaderParser.ValueContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#methodBody}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethodBody(UHeaderParser.MethodBodyContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#methodBodyContent}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethodBodyContent(UHeaderParser.MethodBodyContentContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#methodName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethodName(UHeaderParser.MethodNameContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#methodOperator}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitMethodOperator(UHeaderParser.MethodOperatorContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#property}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProperty(UHeaderParser.PropertyContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#propertyName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPropertyName(UHeaderParser.PropertyNameContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#propertyDefaultValue}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPropertyDefaultValue(UHeaderParser.PropertyDefaultValueContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#type}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitType(UHeaderParser.TypeContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isPtrQuant}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsPtrQuant(UHeaderParser.IsPtrQuantContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isRefQuant}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsRefQuant(UHeaderParser.IsRefQuantContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#typeName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTypeName(UHeaderParser.TypeNameContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isVirtual}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsVirtual(UHeaderParser.IsVirtualContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isOverride}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsOverride(UHeaderParser.IsOverrideContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isConst}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsConst(UHeaderParser.IsConstContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isStatic}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsStatic(UHeaderParser.IsStaticContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isFriend}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsFriend(UHeaderParser.IsFriendContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isFinal}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsFinal(UHeaderParser.IsFinalContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isDestructor}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsDestructor(UHeaderParser.IsDestructorContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isDelete}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsDelete(UHeaderParser.IsDeleteContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#isArray}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitIsArray(UHeaderParser.IsArrayContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#arrayLen}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitArrayLen(UHeaderParser.ArrayLenContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#templateDefine}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTemplateDefine(UHeaderParser.TemplateDefineContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#templateParamList}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTemplateParamList(UHeaderParser.TemplateParamListContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#templateParam}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTemplateParam(UHeaderParser.TemplateParamContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#templateParamType}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTemplateParamType(UHeaderParser.TemplateParamTypeContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#templateParamLiter}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTemplateParamLiter(UHeaderParser.TemplateParamLiterContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#accessSpecifierContainer}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAccessSpecifierContainer(UHeaderParser.AccessSpecifierContainerContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#accessSpecifier}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAccessSpecifier(UHeaderParser.AccessSpecifierContext ctx);
	/**
	 * Visit a parse tree produced by {@link UHeaderParser#preprocessDerective}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPreprocessDerective(UHeaderParser.PreprocessDerectiveContext ctx);
}