public partial class Parser
{
	protected void StateSemicolon(string input, ref int position)
	{

		if (position >= input.Length)
		{
			errors.Add(new ParserError("Входная строка закончилась раньше, чем ожидалось 12", position, position, ErrorType.UnfinishedExpression));
			return;
		}

		int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова
		bool SemicolonMet = false;
		// Пропускаем пробелы до начала ключевого слова
		while (position < input.Length && (char.IsWhiteSpace(input[position]) || input[position] == '\n'))
		{
			position++; // Продвигаем позицию на следующий символ
		}
		char currentSymbol;

		ParserError error = new ParserError("Ожидалась точка с запятой", keywordStartPos + 1, position + 1);

		while (position < input.Length && (!char.IsWhiteSpace(input[position]) && input[position] != '}' && input[position] != '\n'))
		{

			if (position >= input.Length)
			{
				if (error.Value != string.Empty)
					errors.Add(error);
				errors.Add(new ParserError("Обнаружено незаконченное выражение", keywordStartPos, position, ErrorType.UnfinishedExpression));
				return;
			}

			currentSymbol = input[position];

			if (currentSymbol == ';')
			{
				SemicolonMet = true;
				if (error.Value != string.Empty)
					errors.Add(error);
				_ = new ParserError("Ожидалась точка с запятой", keywordStartPos + 1, position + 1);
				position++;
				break;
			}
			else
			{
				error.Value += input[position];
				error.EndIndex = position + 1;
			}

			position++;
		}

		// Если левая скобка не была найдена, добавляем сообщение об ошибке
		if (!SemicolonMet)
		{
			errors.Add(new ParserError("Не найдена точка с запятой", keywordStartPos, position, ErrorType.UnfinishedExpression));

		}


	}
}