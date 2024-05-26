using System.Collections.Generic;
using System.Text;

public class ParserLab7
{
	private List<Token> Tokens;
	private int CurrentTokenIndex;
	private StringBuilder result = new StringBuilder();
	private const string sep1 = " → ";

	public ParserLab7()
	{
		Tokens = new List<Token>();
		CurrentTokenIndex = 0;
	}

	public StringBuilder Parse(List<Token> tokens)
	{
		Tokens = tokens;
		CurrentTokenIndex = 0;

		try
		{
			ParseStmt();
		}
		catch
		{
			result.Append("Syntax Error: Обнаружено незаконченное выражение.");
		}

		return result;
	}

	private void ParseStmt() // stmt -> IF exp stmt | IF exp stmt ELSE stmt | ID ASSIGN exp SEMICOLON
	{
		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.If) // IF exp stmt | IF exp stmt ELSE stmt 
		{
			result.Append("IF" + sep1);
			CurrentTokenIndex++;
			ParseIfStmt();
		}
		else if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.ID)
		{
			result.Append("ID" + sep1);
			CurrentTokenIndex++;
			ParseAssignmentStmt();
		}
		else
		{
			result.Append("Ошибка - ожидалось ключевое слово IF или переменная. ");
			CurrentTokenIndex++;
		}
	}

	private void ParseIfStmt() // IF exp stmt | IF exp stmt ELSE stmt 
	{
		ParseExp();
		ParseStmt();

		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Else) // IF exp stmt ELSE stmt
		{
			result.Append("ELSE" + sep1);
			CurrentTokenIndex++;
			ParseStmt();
		}
	}

	private void ParseAssignmentStmt() // ID ASSIGN exp SEMICOLON
	{
		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Assign)
		{
			result.Append("ASSIGN" + sep1);
			CurrentTokenIndex++;
		}
		else
		{
			result.Append("Ошибка - ожидались знаки ”==” | ”<” | ”<=” | ”>” | ”>=” | ”!=”. ");
			CurrentTokenIndex++;
			return;
		}

		ParseExp();

		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Semicolon)
		{
			result.Append(";");
			CurrentTokenIndex++;

			if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Else)
			{
				result.Append(sep1 + "ELSE" + sep1);
				CurrentTokenIndex++;
				ParseStmt();
			}
		}
		else
		{
			result.Append("Ошибка - ожидалась точка с запятой. ");
			CurrentTokenIndex++;
			if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Else)
			{
				result.Append(sep1 + "ELSE" + sep1);
				CurrentTokenIndex++;
				ParseStmt();
			}
		}
	}

	private void ParseExp()  // exp -> TRUE | FALSE | exp OR exp | exp AND exp | NOT exp
	{
		ParsePrimaryExp();

		while (CurrentTokenIndex < Tokens.Count &&
			  (Tokens[CurrentTokenIndex].Type == TokenType.Or || Tokens[CurrentTokenIndex].Type == TokenType.And))
		{
			if (Tokens[CurrentTokenIndex].Type == TokenType.Or)
			{
				result.Append("OR" + sep1);
				CurrentTokenIndex++;
				ParsePrimaryExp();
			}
			else if (Tokens[CurrentTokenIndex].Type == TokenType.And)
			{
				result.Append("AND" + sep1);
				CurrentTokenIndex++;
				ParsePrimaryExp();
			}
		}
	}

	private void ParsePrimaryExp()
	{
		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.True)
		{
			result.Append("TRUE" + sep1);
			CurrentTokenIndex++;
		}
		else if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.False)
		{
			result.Append("FALSE" + sep1);
			CurrentTokenIndex++;
		}
		else if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Not)
		{
			result.Append("NOT" + sep1);
			CurrentTokenIndex++;
			ParsePrimaryExp();
		}
		else
		{
			result.Append("Ошибка - ожидалось логическое значение (TRUE, FALSE) или NOT. ");
			CurrentTokenIndex++;
		}
	}
}

