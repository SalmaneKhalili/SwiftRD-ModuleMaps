namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Literals;

public abstract class TokenLiteralBacker<TValue>(TValue valueOfContents, string value, int index)
    : BackerToken(value, index)
{
    public TValue ValueOfContents { get; internal set; } = valueOfContents;
}
