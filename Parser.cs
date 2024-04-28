using System.Collections.Generic;
public class Parser
{
	private List<Token> tokens;
	private List<Token> errorTokens;
	private int current; // для отслеживания текущего индекса в списке токенов	 
	private int currentState;
	int tokenIndex = 0; // Индекс ожидаемого токена
	int lineNumber = 1;
	public Parser(List<Token> tokens)
	{
		this.tokens = tokens;
		current = 0;
		currentState = 1;
		errorTokens = new List<Token>(); // Создаем список ошибок в конструкторе парсера
	}

	public List<Token> Parse()
	{
		TokenType[] expectedSequence = new TokenType[]
				 {
		 TokenType.KeywordFunction,
		 TokenType.FunctionIdentifier,
		 TokenType.LeftParenthesis,
		 TokenType.ArgumentIdentifier,
		 TokenType.Comma,
		 TokenType.ArgumentIdentifier,
		 TokenType.RightParenthesis,
		 TokenType.CurlyBrace,
		 TokenType.KeywordReturn,
		 TokenType.ArgumentIdentifier,
		 TokenType.Operator,
		 TokenType.ArgumentIdentifier,
		 TokenType.Semicolon,
		 TokenType.CurlyBrace
				 };

		foreach (Token token in tokens)
		{

			// Проверяем, является ли текущий токен пробелом
			if (token.Type == TokenType.NewLine)
			{
				continue; // Пропускаем пробелы
			}

			// Если достигнут конец ожидаемой последовательности, сбрасываем индекс и начинаем заново
			if (tokenIndex >= expectedSequence.Length)
			{
				tokenIndex = 0;
				lineNumber++;
			}
			if (tokenIndex >= tokens.Count)
			{

				continue;
			}
			// Проверяем, соответствует ли текущий токен ожидаемому
			if (token.Type != expectedSequence[tokenIndex])
			{

				if (token.Type == TokenType.Unacceptable)
				{
					errorTokens.Add(token);
					continue;
				}
				errorTokens.Add(token);
			}

			// Увеличиваем индекс, если текущий токен соответствует ожидаемому
			tokenIndex++;
		}

		return errorTokens;
	}
	
}
