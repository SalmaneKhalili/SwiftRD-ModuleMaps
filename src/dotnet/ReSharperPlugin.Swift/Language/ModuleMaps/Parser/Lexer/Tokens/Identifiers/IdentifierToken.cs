using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Identifiers;

public abstract class IdentifierToken(string identifier, string tokenId, int index) : ModuleMapsTokenNodeType(tokenId, index)
{
    public override bool IsIdentifier => true;

    public override string TokenRepresentation => identifier;
    
    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        // TODO supposed to return an AST Node.
        throw new NotImplementedException();
    }
}
