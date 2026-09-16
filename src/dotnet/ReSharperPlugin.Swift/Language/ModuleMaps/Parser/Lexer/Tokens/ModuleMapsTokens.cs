using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Keywords;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Literals;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Lexer.Tokens;

public static class ModuleMapsTokens
{
    #region Markers

    public static readonly StartOfFileToken StartOfFileToken = new();
    public const string StartOfFileId = "START_OF_FILE";
    public const int StartOfFileIndex = 101;

    public static readonly EndOfFileToken EndOfFileToken = new();
    public const string EndOfFileId = "END_OF_FILE";
    public const int EndOfFileIndex = 102;

    public static readonly EmptyToken EmptyToken = new();
    public const string EmptyId = "EMPTY";
    public const int EmptyTokenIndex = 103;

    #endregion

    #region Punctuators
  
    public static readonly OpenCurlyBracesToken OpenCurlyBracesToken = new();
    public const string OpenCurlyBracesTokenId = "PUNCTUATOR_OPEN_CURLY_BRACE";
    public const int OpenCurlyBracesTokenIndex = 901;

    public static readonly CloseCurlyBracesToken CloseCurlyBracesToken = new();
    public const string CloseCurlyBracesTokenId = "PUNCTUATOR_CLOSE_CURLY_BRACE";
    public const int CloseCurlyBracesTokenIndex = 902;

    public static readonly OpenParenthesisToken OpenParenthesisToken = new();
    public const string OpenParenthesisTokenId = "PUNCTUATOR_OPEN_PARENTHESIS";
    public const int OpenParenthesisTokenIndex = 903;

    public static readonly CloseParenthesisToken CloseParenthesisToken = new();
    public const string CloseParenthesisTokenId = "PUNCTUATOR_CLOSE_PARENTHESIS";
    public const int CloseParenthesisTokenIndex = 904;

    public static readonly OpenSquareBracketsToken OpenSquareBracketsToken = new();
    public const string OpenSquareBracketsTokenId = "PUNCTUATOR_OPEN_SQUARE_BRACKETS";
    public const int OpenSquareBracketsTokenIndex = 905;

    public static readonly CloseSquareBracketsToken CloseSquareBracketsToken = new();
    public const string CloseSquareBracketsTokenId = "PUNCTUATOR_CLOSE_SQUARE_BRACKETS";
    public const int CloseSquareBracketsTokenIndex = 906;

    public static readonly ArrowToken ArrowToken = new();
    public const string ArrowTokenId = "PUNCTUATOR_ARROW";
    public const int ArrowTokenIndex = 907;

    public static readonly PeriodToken PeriodToken = new();
    public const string PeriodTokenId = "PUNCTUATOR_PERIOD";
    public const int PeriodTokenIndex = 908;

    public static readonly IncrementToken IncrementToken = new();
    public const string IncrementTokenId = "PUNCTUATOR_INCREMENT";
    public const int IncrementTokenIndex = 909;

    public static readonly DecrementToken DecrementToken = new();
    public const string DecrementTokenId = "PUNCTUATOR_DECREMENT";
    public const int DecrementTokenIndex = 910;

    public static readonly AmpersandToken AmpersandToken = new();
    public const string AmpersandTokenId = "PUNCTUATOR_AMPERSAND";
    public const int AmpersandTokenIndex = 911;

    public static readonly AdditionToken AdditionToken = new();
    public const string AdditionTokenId = "PUNCTUATOR_ADDITION";
    public const int AdditionTokenIndex = 912;

    public static readonly IndirectionToken IndirectionToken = new();
    public const string IndirectionTokenId = "PUNCTUATOR_INDIRECTION";
    public const int IndirectionTokenIndex = 913;

    public static readonly MinusToken MinusToken = new();
    public const string MinusTokenId = "PUNCTUATOR_MINUS";
    public const int MinusTokenIndex = 914;

    public static readonly BitwiseNotToken BitwiseNotToken = new();
    public const string BitwiseNotTokenId = "PUNCTUATOR_BITWISE_NOT";
    public const int BitwiseNotTokenIndex = 915;

    public static readonly ExclamationMarkToken ExclamationMarkToken = new();
    public const string ExclamationMarkTokenId = "PUNCTUATOR_EXCLAMATION_MARK";
    public const int ExclamationMarkTokenIndex = 916;

    public static readonly DivisionToken DivisionToken = new();
    public const string DivisionTokenId = "PUNCTUATOR_DIVISION";
    public const int DivisionTokenIndex = 917;

    public static readonly ModuloToken ModuloToken = new();
    public const string ModuloTokenId = "PUNCTUATOR_MODULO";
    public const int ModuloTokenIndex = 918;

    public static readonly BitwiseLeftShiftToken BitwiseLeftShiftToken = new();
    public const string BitwiseLeftShiftTokenId = "PUNCTUATOR_BITWISE_LEFT_SHIFT";
    public const int BitwiseLeftShiftTokenIndex = 919;

    public static readonly BitwiseRightShiftToken BitwiseRightShiftToken = new();
    public const string BitwiseRightShiftTokenId = "PUNCTUATOR_BITWISE_RIGHT_SHIFT";
    public const int BitwiseRightShiftTokenIndex = 920;

    public static readonly LessThanToken LessThanToken = new();
    public const string LessThanTokenId = "PUNCTUATOR_LESS_THAN";
    public const int LessThanTokenIndex = 921;

    public static readonly GreaterThanToken GreaterThanToken = new();
    public const string GreaterThanTokenId = "PUNCTUATOR_GREATER_THAN";
    public const int GreaterThanTokenIndex = 922;

    public static readonly LessThanOrEqualToken LessThanOrEqualToken = new();
    public const string LessThanOrEqualTokenId = "PUNCTUATOR_LESS_THAN_OR_EQUAL";
    public const int LessThanOrEqualTokenIndex = 923;

    public static readonly GreaterThanOrEqualToken GreaterThanOrEqualToken = new();
    public const string GreaterThanOrEqualTokenId = "PUNCTUATOR_GREATER_THAN_OR_EQUAL";
    public const int GreaterThanOrEqualTokenIndex = 924;

    public static readonly EqualEqualsToken EqualEqualsToken = new();
    public const string EqualEqualsTokenId = "PUNCTUATOR_EQUAL_EQUAL";
    public const int EqualEqualsTokenIndex = 925;

    public static readonly NotEqualToken NotEqualToken = new();
    public const string NotEqualTokenId = "PUNCTUATOR_NOT_EQUAL";
    public const int NotEqualTokenIndex = 926;

    public static readonly BitwiseAndToken BitwiseAndToken = new();
    public const string BitwiseAndTokenId = "PUNCTUATOR_BITWISE_AND";
    public const int BitwiseAndTokenIndex = 927;

    public static readonly BitwiseOrToken BitwiseOrToken = new();
    public const string BitwiseOrTokenId = "PUNCTUATOR_BITWISE_OR";
    public const int BitwiseOrTokenIndex = 928;

    public static readonly LogicalAndToken LogicalAndToken = new();
    public const string LogicalAndTokenId = "PUNCTUATOR_LOGICAL_AND";
    public const int LogicalAndTokenIndex = 929;

    public static readonly LogicalOrToken LogicalOrToken = new();
    public const string LogicalOrTokenId = "PUNCTUATOR_LOGICAL_OR";
    public const int LogicalOrTokenIndex = 930;

    public static readonly InterrogationMarkToken InterrogationMarkToken = new();
    public const string InterrogationMarkTokenId = "PUNCTUATOR_INTERROGATION_MARK";
    public const int InterrogationMarkTokenIndex = 931;

    public static readonly ColonToken ColonToken = new();
    public const string ColonTokenId = "PUNCTUATOR_COLON";
    public const int ColonTokenIndex = 932;

    public static readonly SemiColonToken SemiColonToken = new();
    public const string SemiColonTokenId = "PUNCTUATOR_SEMI_COLON";
    public const int SemiColonTokenIndex = 933;

    public static readonly EllipsisToken EllipsisToken = new();
    public const string EllipsisTokenId = "PUNCTUATOR_ELLIPSIS";
    public const int EllipsisTokenIndex = 934;

    public static readonly EqualToken EqualToken = new();
    public const string EqualTokenId = "PUNCTUATOR_EQUAL";
    public const int EqualTokenIndex = 935;

    public static readonly CompoundMultiplicationToken CompoundMultiplicationToken = new();
    public const string CompoundMultiplicationTokenId = "PUNCTUATOR_COMPOUND_MULTIPLICATION";
    public const int CompoundMultiplicationTokenIndex = 936;

    public static readonly CompoundDivisionToken CompoundDivisionToken = new();
    public const string CompoundDivisionTokenId = "PUNCTUATOR_COMPOUND_DIVISION";
    public const int CompoundDivisionTokenIndex = 937;

    public static readonly CompoundModuloToken CompoundModuloToken = new();
    public const string CompoundModuloTokenId = "PUNCTUATOR_COMPOUND_MODULO";
    public const int CompoundModuloTokenIndex = 938;

    public static readonly CompoundAdditionToken CompoundAdditionToken = new();
    public const string CompoundAdditionTokenId = "PUNCTUATOR_COMPOUND_ADDITION";
    public const int CompoundAdditionTokenIndex = 939;

    public static readonly CompoundSubtractionToken CompoundSubtractionToken = new();
    public const string CompoundSubtractionTokenId = "PUNCTUATOR_COMPOUND_SUBTRACTION";
    public const int CompoundSubtractionTokenIndex = 940;

    public static readonly CompoundBitwiseLeftShiftToken CompoundBitwiseLeftShiftToken = new();
    public const string CompoundBitwiseLeftShiftTokenId = "PUNCTUATOR_COMPOUND_BITWISE_LEFT_SHIFT";
    public const int CompoundBitwiseLeftShiftTokenIndex = 941;

    public static readonly CompoundBitwiseRightShiftToken CompoundBitwiseRightShiftToken = new();
    public const string CompoundBitwiseRightShiftTokenId = "PUNCTUATOR_COMPOUND_BITWISE_RIGHT_SHIFT";
    public const int CompoundBitwiseRightShiftTokenIndex = 942;

    public static readonly CompoundBitwiseAndToken CompoundBitwiseAndToken = new();
    public const string CompoundBitwiseAndTokenId = "PUNCTUATOR_COMPOUND_BITWISE_AND";
    public const int CompoundBitwiseAndTokenIndex = 943;

    public static readonly CompoundBitwiseXorToken CompoundBitwiseXorToken = new();
    public const string CompoundBitwiseXorTokenId = "PUNCTUATOR_COMPOUND_BITWISE_XOR";
    public const int CompoundBitwiseXorTokenIndex = 944;

    public static readonly CompoundBitwiseOrToken CompoundBitwiseOrToken = new();
    public const string CompoundBitwiseOrTokenId = "PUNCTUATOR_COMPOUND_BITWISE_OR";
    public const int CompoundBitwiseOrTokenIndex = 945;

    public static readonly CommaToken CommaToken = new();
    public const string CommaTokenId = "PUNCTUATOR_COMMA";
    public const int CommaTokenIndex = 946;

    public static readonly HashToken HashToken = new();
    public const string HashTokenId = "PUNCTUATOR_HASH";
    public const int HashTokenIndex = 947;

    public static readonly DoubleHashToken DoubleHashToken = new();
    public const string DoubleHashTokenId = "PUNCTUATOR_DOUBLE_HASH";
    public const int DoubleHashTokenIndex = 948;

    public static readonly DigraphOpenSquareBracketsToken DigraphOpenSquareBracketsToken = new();
    public const string DigraphOpenSquareBracketsTokenId = "PUNCTUATOR_DIGRAPH_OPEN_SQUARE_BRACKETS";
    public const int DigraphOpenSquareBracketsTokenIndex = 949;

    public static readonly DigraphCloseSquareBracketsToken DigraphCloseSquareBracketsToken = new();
    public const string DigraphCloseSquareBracketsTokenId = "PUNCTUATOR_DIGRAPH_CLOSE_SQUARE_BRACKETS";
    public const int DigraphCloseSquareBracketsTokenIndex = 950;

    public static readonly DigraphOpenCurlyBracesToken DigraphOpenCurlyBracesToken = new();
    public const string DigraphOpenCurlyBracesTokenId = "PUNCTUATOR_DIGRAPH_OPEN_CURLY_BRACES";
    public const int DigraphOpenCurlyBracesTokenIndex = 951;

    public static readonly DigraphCloseCurlyBracesToken DigraphCloseCurlyBracesToken = new();
    public const string DigraphCloseCurlyBracesTokenId = "PUNCTUATOR_DIGRAPH_CLOSE_CURLY_BRACES";
    public const int DigraphCloseCurlyBracesTokenIndex = 952;

    public static readonly DigraphHashToken DigraphHashToken = new();
    public const string DigraphHashTokenId = "PUNCTUATOR_DIGRAPH_HASH";
    public const int DigraphHashTokenIndex = 953;

    public static readonly DigraphDoubleHashToken DigraphDoubleHashToken = new();
    public const string DigraphDoubleHashTokenId = "PUNCTUATOR_DIGRAPH_DOUBLE_HASH";
    public const int DigraphDoubleHashTokenIndex = 954;

    public static readonly BitwiseXorToken BitwiseXorToken = new();
    public const string BitwiseXorTokenId = "PUNCTUATOR_BITWISE_XOR";
    public const int BitwiseXorTokenIndex = 955;

    #endregion

    #region Keywords
    
    public static readonly ConfigMacrosToken ConfigMacrosToken = new();
    public const string ConfigMacrosTokenId = "KEYWORD_CONFIG_MACROS";
    public const int ConfigMacrosTokenIndex = 1001;

    public static readonly ConflictToken ConflictToken = new();
    public const string ConflictTokenId = "KEYWORD_CONFLICT";
    public const int ConflictTokenIndex = 1002;

    public static readonly ExcludeToken ExcludeToken = new();
    public const string ExcludeTokenId = "KEYWORD_EXCLUDE";
    public const int ExcludeTokenIndex = 1003;

    public static readonly ExplicitToken ExplicitToken = new();
    public const string ExplicitTokenId = "KEYWORD_EXPLICIT";
    public const int ExplicitTokenIndex = 1004;

    public static readonly ExportToken ExportToken = new();
    public const string ExportTokenId = "KEYWORD_EXPORT";
    public const int ExportTokenIndex = 1005;

    public static readonly ExportAsToken ExportAsToken = new();
    public const string ExportAsTokenId = "KEYWORD_EXPORT_AS";
    public const int ExportAsTokenIndex = 1006;

    public static readonly ExternToken ExternToken = new();
    public const string ExternTokenId = "KEYWORD_EXTERN";
    public const int ExternTokenIndex = 1007;

    public static readonly FrameworkToken FrameworkToken = new();
    public const string FrameworkTokenId = "KEYWORD_FRAMEWORK";
    public const int FrameworkTokenIndex = 1008;

    public static readonly HeaderToken HeaderToken = new();
    public const string HeaderTokenId = "KEYWORD_HEADER";
    public const int HeaderTokenIndex = 1009;

    public static readonly LinkToken LinkToken = new();
    public const string LinkTokenId = "KEYWORD_LINK";
    public const int LinkTokenIndex = 1010;

    public static readonly ModuleToken ModuleToken = new();
    public const string ModuleTokenId = "KEYWORD_MODULE";
    public const int ModuleTokenIndex = 1011;

    public static readonly PrivateToken PrivateToken = new();
    public const string PrivateTokenId = "KEYWORD_PRIVATE";
    public const int PrivateTokenIndex = 1012;

    public static readonly RequiresToken RequiresToken = new();
    public const string RequiresTokenId = "KEYWORD_REQUIRES";
    public const int RequiresTokenIndex = 1013;

    public static readonly TextualToken TextualToken = new();
    public const string TextualTokenId = "KEYWORD_TEXTUAL";
    public const int TextualTokenIndex = 1014;

    public static readonly UmbrellaToken UmbrellaToken = new();
    public const string UmbrellaTokenId = "KEYWORD_UMBRELLA";
    public const int UmbrellaTokenIndex = 1015;

    public static readonly UseToken UseToken = new();
    public const string UseTokenId = "KEYWORD_USE";
    public const int UseTokenIndex = 1016;

    #endregion

    #region WhitespaceAndComments

    public static readonly WhitespaceToken WhitespaceToken = new();
    public const string WhitespaceTokenId = "WHITE_SPACE";
    public const int WhitespaceTokenIndex = 601; 

    public static readonly LineCommentToken LineCommentsToken = new();
    public const string LineCommentsTokenId = "LINE_COMMENTS";
    public const int LineCommentsTokenIndex = 602;
    
    public static readonly BlockCommentsToken BlockCommentsToken = new();
    public const string BlockCommentsTokenId = "BLOCK_COMMENTS";
    public const int BlockCommentsTokenIndex = 603;
    
    #endregion

    #region Literals

    public static readonly IntegerLiteralToken IntegerLiteralToken = new();
    public const string IntegerLiteralTokenId = "LITERAL_INTEGER";
    public const int IntegerLiteralTokenIndex = 801;

    public static readonly StringLiteralToken StringLiteralToken = new();
    public const string StringLiteralTokenId = "LITERAL_STRING";
    public const int StringLiteralTokenIndex = 802;

    public static readonly FloatingPointLiteralToken FloatingPointLiteralToken = new();
    public const string FloatingPointLiteralTokenId = "LITERAL_FLOATING_POINT";
    public const int FloatingPointLiteralTokenIndex = 803;

    #endregion

    public static object Fl { get; set; }
}