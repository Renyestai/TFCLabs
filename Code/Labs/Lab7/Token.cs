
public enum TokenType
{
	If, //
	Else, //
	True, //
	False, //
	Not, //
	Or, //
	And, //
	ID, //Б{Б|Ц}, Б – {a, b, c, ...z, A, B, …, Z}, Ц – {0, 1, …,
	Assign, // ”==” | ”<” | ”<=” | ”>” | ”>=” | ”!=”
	Semicolon, //
	Error
}
public class Token
{
	public TokenType Type { get; set; }
	public string Value { get; set; }
	public int FirstPosition { get; set; }
	public int SecondPosition { get; set; }
	public Token(TokenType type, string value, int firstposition, int secondposition)
	{
		
		Type = type;
		Value = value;
		FirstPosition = firstposition;
		SecondPosition = secondposition;
		
	}

}
