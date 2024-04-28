public enum TokenType
{
	KeywordFunction = 1, // ключевое слово function 1
	KeywordReturn,// ключевое слово return 2
	FunctionIdentifier,    // Токен для идентификаторов функций 3
	ArgumentIdentifier,    // Токен для идентификаторов аргументов 4
	Space, // разделитель (пробел) 5
	LeftParenthesis,
	RightParenthesis,// фигурная скобка 6
	Comma, // оператор 7
	CurlyBrace,// фигурная скобка 8
	Semicolon,
	Add,
	Subtract,
	Multiply,
	Divide,// ключевое слово
	NewLine,
	Tab,
	Number, // число
	Operator,
	Unacceptable    // недопустимый символ
}

public class Token
{
	public int CodeType { get; set; } = 0;
	public TokenType Type { get; set; }
	public string Value { get; set; }
	public int FirstPosition { get; set; }
	public int SecondPosition { get; set; }
	public string ErrorString { get; set; }
	public Token(int codetype, TokenType type, string value, int firstposition, int secondposition, string errorstring)
	{
		CodeType = codetype;
		Type = type;
		Value = value;
		FirstPosition = firstposition;
		SecondPosition = secondposition;
		ErrorString = errorstring;
	}

}
