using System.Collections.Generic;
public class LexicalAnalyzer
{
	private string input;
	private int position;

	public LexicalAnalyzer(string input)
	{
		this.input = input;
		position = 0;
	}

	public List<Token> Tokenize()
	{
		List<Token> tokens = new List<Token>();

		while (position < input.Length)
		{
			char currentChar = input[position];

			if (char.IsLetter(currentChar) || currentChar == '$')
			{
				tokens.Add(ScanWord());
			}

			else if (char.IsDigit(currentChar))
			{
				tokens.Add(ScanNumber());
			}

			else if (currentChar == '(')
			{
				tokens.Add(new Token((int)TokenType.LeftParenthesis,TokenType.LeftParenthesis, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == ')')
			{
				tokens.Add(new Token((int)TokenType.RightParenthesis, TokenType.RightParenthesis, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == ',')
			{
				tokens.Add(new Token((int)TokenType.Comma, TokenType.Comma, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == ';')
			{
				tokens.Add(new Token((int)TokenType.Semicolon, TokenType.Semicolon, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == '+')
			{
				tokens.Add(new Token((int)TokenType.Operator, TokenType.Operator, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == '-')
			{
				tokens.Add(new Token((int)TokenType.Operator, TokenType.Operator, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == '*')
			{
				tokens.Add(new Token((int)TokenType.Operator, TokenType.Operator, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == '/')
			{
				tokens.Add(new Token((int)TokenType.Operator, TokenType.Operator, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == '{' || currentChar == '}')
			{
				tokens.Add(new Token((int)TokenType.CurlyBrace, TokenType.CurlyBrace, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == '\n')
			{
				tokens.Add(new Token((int)TokenType.NewLine, TokenType.NewLine, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (currentChar == '\t')
			{
				tokens.Add(new Token((int)TokenType.Tab, TokenType.Tab, currentChar.ToString(), position, position, " "));
				position++;
			}
			else if (char.IsWhiteSpace(currentChar)) // если пробел
			{
				position++;
			}
			else
			{
				// Неизвестный символ
				tokens.Add(new Token((int)TokenType.Unacceptable, TokenType.Unacceptable, currentChar.ToString(), position, position, " "));
				position++;
			}
		}

		return tokens;
	}
	

	private Token ScanWord()
	{
		string word = ""; // Инициализация строки для хранения текущего слова
		int length = 0;

		// Если текущий символ - "$", это может быть идентификатором переменной
		if (position < input.Length && input[position] == '$')
		{
			word += input[position]; // Добавляем текущий символ к строке
			position++; // Переходим к следующему символу
			length++;

			// Проверяем, следует ли за символом "$" буква или "_"
			if (position < input.Length && (char.IsLetter(input[position]) || input[position] == '_'))
			{
				// Считываем последовательность букв, цифр и "_"
				while (position < input.Length && (char.IsLetterOrDigit(input[position]) || input[position] == '_'))
				{
					word += input[position]; // Добавляем текущий символ к строке
					position++; // Переходим к следующему символу
					length++;
				}
			}
			else
			{
				// Возвращаем ошибку, если следующий символ недопустим
				return new Token((int)TokenType.Unacceptable, TokenType.Unacceptable, word, position - length, position, " ");
			}
		}
		else if (char.IsLetter(input[position]) || input[position] == '_')
		{
			// Если текущий символ - буква или "_", это может быть идентификатором функции
			while (position < input.Length && (char.IsLetterOrDigit(input[position]) || input[position] == '_'))
			{
				word += input[position]; // Добавляем текущий символ к строке
				position++; // Переходим к следующему символу
				length++;
			}
		}
		else
		{
			// Возвращаем ошибку, если последовательность символов не является корректным идентификатором
			return new Token((int)TokenType.Unacceptable, TokenType.Unacceptable, word, position - length, position, " ");
		}
		// После того, как прочитано ключевое слово, проверяем, соответствует ли оно известному ключевому слову
		switch (word)
		{
			case "function":
				return new Token((int)TokenType.KeywordFunction, TokenType.KeywordFunction, word, position - length, position, " ");
			case "return":
				return new Token((int)TokenType.KeywordReturn, TokenType.KeywordReturn, word, position - length, position, " ");
			default:
				// Если первый символ - "$", это может быть идентификатором аргумента
				if (word.Length > 0 && word[0] == '$')
				{
					return new Token((int)TokenType.ArgumentIdentifier, TokenType.ArgumentIdentifier, word, position - length, position, " ");
				}
				else
				{
					// Если последовательность символов не является ключевым словом и не начинается с "$", это может быть идентификатором функции
					return new Token((int)TokenType.FunctionIdentifier, TokenType.FunctionIdentifier, word, position - length, position, " ");
				}
		}
	}

	private Token ScanNumber()
	{
		string number = ""; // Инициализация строки для хранения числа
		int length = 0;

		// Сначала сканируем последовательность цифр и десятичных точек
		while (position < input.Length && (char.IsDigit(input[position]) || input[position] == '.'))
		{
			number += input[position]; // Добавляем текущий символ к числу
			position++; // Переходим к следующему символу
			length++;
		}

		// Затем продолжаем сканировать символы до,знака новой строки или другого неподходящего символа
		while (position < input.Length && input[position] != '\n' && char.IsWhiteSpace(input[position]))
		{
			number += input[position]; // Добавляем текущий символ к числу
			position++; // Переходим к следующему символу
			length++;
		}

		// Проверяем, является ли сканированная строка числом
		if (double.TryParse(number, out _))
		{
			return new Token((int)TokenType.Number, TokenType.Number, number, position - length, position, " ");
		}
		else
		{
			// Если строка не является числом, то считаем ее недопустимой
			return new Token((int)TokenType.Unacceptable, TokenType.Unacceptable, number, position - length, position, " ");
		}
	}
}
