//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from AdaptiveCardsTemplating.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="AdaptiveCardsTemplatingParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IAdaptiveCardsTemplatingVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdaptiveCardsTemplatingParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] AdaptiveCardsTemplatingParser.ProgContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdaptiveCardsTemplatingParser.template"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemplate([NotNull] AdaptiveCardsTemplatingParser.TemplateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>propArray</c>
	/// labeled alternative in <see cref="AdaptiveCardsTemplatingParser.prop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropArray([NotNull] AdaptiveCardsTemplatingParser.PropArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>propID</c>
	/// labeled alternative in <see cref="AdaptiveCardsTemplatingParser.prop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPropID([NotNull] AdaptiveCardsTemplatingParser.PropIDContext context);
}