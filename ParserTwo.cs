using System.Collections.Generic;
using System.Reflection;

public class SecParser
{
	private string input;
	private int position;
	private List<ParserError> errors;

	public SecParser(string input)
	{
		this.input = input;
		position = 0;
		errors = new List<ParserError>(); // Создаем список ошибок в конструкторе парсера
	}

	public List<ParserError> Parse()
	{
		while (position < input.Length)
		{
			StateFunction(input, ref position);
		}

		return errors;
	}
	private void StateFunction(string input, ref int position)
	{
		string expectedKeyword = "function";
		int keywordStartPos = position; // Запоминаем начальную позицию ключевого слова

		// Пропускаем пробелы до начала ключевого слова
		while (position < input.Length)
		{
			position++; // Продвигаем позицию на следующий символ
		}

		// Проверяем, начинается ли ключевое слово "function" с текущей позиции
		foreach (char c in expectedKeyword)
		{
			if (position >= input.Length || input[position] != c)
			{
				errors.Add(new ParserError("Ожидалось ключевое слово \"function\"", keywordStartPos, position));
				return;
			}
			position++; // Переходим к следующему символу
		}

		// Проверяем, следующий символ после ключевого слова
		if (position >= input.Length || (input[position] != ' ' && input[position] != '('))
		{
			errors.Add(new ParserError("После ключевого слова \"function\" ожидался пробел или открывающая скобка", keywordStartPos, position));
			return;
		}

		// Переходим к следующему состоянию
	}



	private void StateFunctionID(char currentChar) //3
	{
		// Логика для состояния StateFunctionID
	}

	private void StateLeftPar(char currentChar) //4
	{
		// Логика для состояния StateLeftPar
	}

	private void StateArgID(char currentChar) //5
	{
		// Логика для состояния StateArgID
	}

	private void StateRightPar(char currentChar) //7
	{
		// Логика для состояния StateRightPar
	}

	private void State8(char currentChar)
	{
		// Логика для состояния State8
	}

	private void State9(char currentChar)
	{
		// Логика для состояния State9
	}

	private void State1112(char currentChar)
	{
		// Логика для состояния State1112
	}

	private void State1213(char currentChar)
	{
		// Логика для состояния State1213
	}

	private void State1415(char currentChar)
	{
		// Логика для состояния State1415
	}

	private void State16(char currentChar)
	{
		// Логика для состояния State16
	}

	private void State17(char currentChar)
	{
		// Логика для состояния State17
	}

	public bool CanGetNext
	{
		get => input.Length - 1 > position;
	}

}