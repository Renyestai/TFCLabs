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
			
	private void ParseStmt() //  stmt -> IF exp stmt | IF exp stmt ELSE stmt | ID ASSIGN exp SEMICOLON
	{
		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.If) //  IF exp stmt | IF exp stmt ELSE stmt 
		{
			result.Append("IF" + sep1);
			CurrentTokenIndex++;
			ParseIfStmt();
		}
		else
		{
			result.Append("Ошибка - ожидалось ключевое слово IF. ");
			CurrentTokenIndex++;
		}

		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.ID) //  ID ASSIGN exp SEMICOLON
		{
			result.Append("ID" + sep1);
			CurrentTokenIndex++;
			ParseAssignmentStmt();
		}
		else
		{
			result.Append("Ошибка - ожидалась переменная. ");
			CurrentTokenIndex++;
		}
	}

	private void ParseIfStmt() //  IF exp stmt | IF exp stmt ELSE stmt 
	{
		// IF exp stmt 

		ParseExp();

		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Else) // Если есть ELSE, разбираем второй stmt
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
		}

        ParseExp(); 

		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Semicolon)

		{
			result.Append(";");
			CurrentTokenIndex++;
		}
		else
		{
			result.Append("Ошибка - ожидалась точка с запятой. ");
			CurrentTokenIndex++;
			return;
		}
	}

    private void ParseExp()  // exp -> TRUE | FALSE | exp OR exp | exp AND exp | NOT exp | exp
	{
		//  TRUE | FALSE | NOT exp

		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.True)// TRUE 
		{
			result.Append("TRUE" + sep1);
			CurrentTokenIndex++;
			return;
		}
        if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.False) // FALSE
		{
			result.Append("FALSE" + sep1);
			CurrentTokenIndex++;
			return;
		}
		if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Not)  // NOT 
		{
			result.Append("NOT" + sep1);
			CurrentTokenIndex++;
			ParseExp();
		}	
		else  // exp OR exp | exp AND exp | exp
		{
			ParseExp(); //  exp

			if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.Or) //  exp OR exp
			{
				result.Append("OR" + sep1);
				CurrentTokenIndex++;
				ParseExp();
			}
			else if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == TokenType.And) // exp AND exp
			{
				result.Append("AND" + sep1);
				CurrentTokenIndex++;
				ParseExp();
			}
				// Если нет ни одного оператора OR или AND, это конечное выражение
		}

	
	}
    // Методы для сопоставления текущего токена с определенным типом
    private bool Match(TokenType type)
    {
		
        if (CurrentTokenIndex < Tokens.Count && Tokens[CurrentTokenIndex].Type == type)
        {
            CurrentTokenIndex++;
            return true;
        }
		else
		{
			CurrentTokenIndex++;
			return false;
		}
        
    }

}
