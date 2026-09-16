using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Keywords;

public abstract class KeywordToken(string keyword, string tokenId, int index) : ModuleMapsTokenNodeType(tokenId, index)
{
    public override bool IsKeyword => true;

    public override string TokenRepresentation => keyword;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        // TODO supposed to return an AST Node.
        throw new NotImplementedException();
    }
}