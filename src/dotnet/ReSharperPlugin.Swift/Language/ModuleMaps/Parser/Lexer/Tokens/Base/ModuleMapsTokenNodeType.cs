using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Exceptions;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Base;

public abstract class ModuleMapsTokenNodeType : TokenNodeType
{
    public string Name { get; }

    protected ModuleMapsTokenNodeType(string name, int index) : base(name, index)
    {
        Name = name;
        ModuleMapsNodeTypeIndexer.Instance.Add(this, index);
    }

    public abstract override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset);

    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => false;

    public virtual bool ExpressionAndTypeUsable => false;

    protected static void CheckAgainstValue(string expectedTokenValue, IBuffer buffer, string tokenId)
    {
        if (buffer.Length != expectedTokenValue.Length)
        {
            throw new InvalidLexicalBaseForElementException(tokenId, buffer, expectedTokenValue);
        }

        int i = 0;
        while (i < expectedTokenValue.Length)
        {
            if (buffer[i] != expectedTokenValue[i])
            {
                throw new InvalidLexicalBaseForElementException(tokenId, buffer, expectedTokenValue);
            }
            i++;
        }
    }
}