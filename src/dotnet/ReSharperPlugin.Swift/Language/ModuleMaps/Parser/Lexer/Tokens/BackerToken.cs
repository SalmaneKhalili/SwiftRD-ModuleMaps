namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens;

public abstract class BackerToken(string value, int index)
{
    public string Value
    {
        get; 
        internal set;
    } = value;
    public int Index { get; } = index;
}
