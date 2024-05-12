using System.Collections.Generic;
class Lab5Parser:Parser
{
	public Lab5Parser(string input) : base(input)
	{

	}

	public new List<ParserError> Parse()
	{
		while (position < input.Length)
		{
			StateKeywordFunction(input, ref position);
			StateFunctionID(input, ref position);
			StateLeftPar(input, ref position);
			StateFirstArgID(input, ref position);
			StateComma(input, ref position);
			StateSecondArgID(input, ref position);
			StateRightPar(input, ref position);
			StateLeftCurly(input, ref position);
			StateReturn(input, ref position);
			ParseExpression(input, ref position);									
			StateSemicolon(input, ref position);
			StateRightCurly(input, ref position);
			if (LastState) { break; }
		}

		return errors;
	}

	protected void ParseExpression(string input, ref int position)
	{
		while (position < input.Length && char.IsWhiteSpace(input[position]))
		{
			position++;
		}

		// Вызываем метод разбора E, который начинает разбор выражения
		ParseE(input, ref position);

	}

	private void ParseE(string input, ref int position)
	{
		// Вызываем метод разбора T, который разбирает операнды
		ParseT(input, ref position);

		// Проверяем, может ли следующий символ быть оператором
		while (position < input.Length && (input[position] == '+' || input[position] == '-'))
		{

			position++;

			ParseT(input, ref position);
		}
	}

	private void ParseT(string input, ref int position)
	{
		// Вызываем метод разбора O, который разбирает операнды
		ParseO(input, ref position);

		// Проверяем, может ли следующий символ быть оператором
		while (position < input.Length && (input[position] == '*' || input[position] == '/'))
		{

			position++;

			ParseO(input, ref position);
		}
	}

	private void ParseO(string input, ref int position)
	{
		// Проверяем, является ли текущий символ числом, буквой или открывающей скобкой
		if (position < input.Length && (char.IsDigit(input[position]) || char.IsLetter(input[position]) || input[position] == '('))
		{
			// Если текущий символ - число, буква или открывающая скобка, то пропускаем его
			if (input[position] == '(')
			{
				// Если символ - открывающая скобка, разбираем вложенное выражение
				position++;
				ParseE(input, ref position);

				// После завершения разбора вложенного выражения ожидаем закрывающую скобку
				if (position < input.Length && input[position] == ')')
				{
					position++;
				}
				else
				{
					errors.Add(new ParserError("Ожидалась закрывающая скобка", position, position, ErrorType.UnfinishedExpression));
				}
			}
			else
			{
				// Если текущий символ - число или буква, пропускаем его
				while (position < input.Length && (char.IsDigit(input[position]) || char.IsLetter(input[position])))
				{
					position++;
				}
			}
		}
		else
		{
			// Если текущий символ не число, буква и не открывающая скобка, добавляем ошибку
			errors.Add(new ParserError("Ожидалось число, буква или открывающая скобка", position, position));
		}
	}
}