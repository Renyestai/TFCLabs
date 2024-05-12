using System.Collections.Generic;

public class LexerLab7
{
	private List<Token> Tokens;

	public List<Token> Tokenize(string input)
	{
		int i;
		string value;

		Tokens.Clear();

		for (i = 0; i < input.Length; i++)
		{
			value = string.Empty + input[i];

			if (char.IsLetter(input[i]))
			{
				int startIndex = i;

				while ((i + 1) < input.Length && char.IsLetter(input[i + 1]))
				{
					i++;
					value += input[i];
				}

				switch (value)
				{
					case "if":
						Tokens.Add(new Token(TokenType.If, value, startIndex + 1, i + 1));
						break;
					case "else":
						Tokens.Add(new Token(TokenType.Else, value, startIndex + 1, i + 1));
						break;
					case "not":
						Tokens.Add(new Token(TokenType.Not, value, startIndex + 1, i + 1));
						break;
					case "and":
						Tokens.Add(new Token(TokenType.And, value, startIndex + 1, i + 1));
						break;
					case "or":
						Tokens.Add(new Token(TokenType.Or, value, startIndex + 1, i + 1));
						break;
					case "true":
						Tokens.Add(new Token(TokenType.True, value, startIndex + 1, i + 1));
						break;
					case "false":
						Tokens.Add(new Token(TokenType.False, value, startIndex + 1, i + 1));
						break;
					default:
						Tokens.Add(new Token(TokenType.ID, value, startIndex + 1, i + 1)); // мб убрать
						break;
				}
			}
			else
			{
				if (char.IsDigit(input[i]) || char.IsLetter(input[i]))
				{
					int startIndex = i;

					while ((i + 1) < input.Length && (char.IsDigit(input[i + 1]) || char.IsLetter(input[i + 1])))
					{
						i++;
						value += input[i];
					}

					Tokens.Add(new Token(TokenType.ID, value, startIndex + 1, i + 1));
				}
				else
				{
					switch (input[i])
					{
						case '\t':
						case ' ':
							break;
						case (char)13:
							if ((i + 1) < input.Length && input[i + 1] == (char)10)
							{
								i++;
								value = "\\n";
							}
							break;
						case '>':
						case '<':
						case '!':
							if ((i + 1) < input.Length && input[i + 1] == '=')
							{
								i++;
								value += input[i];
								Tokens.Add(new Token(TokenType.Assign, value, i, i + 1));
							}
							else
							{
								if (input[i] == '!')
								{
									Tokens.Add(new Token(TokenType.Error, value, i + 1, i + 1));
								}
								else
								{
									Tokens.Add(new Token(TokenType.Assign, value, i + 1, i + 1));
								}
							}
							break;
						case '=':
							if ((i + 1) < input.Length && input[i + 1] == '=')
							{
								i++;
								value += input[i];
								Tokens.Add(new Token(TokenType.Assign, value, i, i + 1));
							}
							else
							{
								Tokens.Add(new Token(TokenType.Error, value, i, i + 1));
							}
							break;
						case ';':
							Tokens.Add(new Token(TokenType.Semicolon, value, i + 1, i + 1)); //!
							break;
						default:
							Tokens.Add(new Token(TokenType.Error, value, i + 1, i + 1));
							break;
					}
				}
			}
		}

		return Tokens;
	}

	public LexerLab7()
	{
		Tokens = new List<Token>();

	}
}
