using System.Collections.Generic;

public partial class Parser
{
	protected string input;
	protected int position;
	protected List<ParserError> errors;
	public bool IsLeftPartofParMet = false; // для скобок
	public bool IsLeftPartofCurlyMet = false; // для фигурных скобок
	public bool LastState = false; // для фигурных скобок
	public Parser(string input)
	{
		this.input = input;
		position = 0;
		errors = new List<ParserError>(); // Создаем список ошибок в конструкторе парсера

	}
	public List<ParserError> Parse()
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
			StateFirstArg(input, ref position);
			StateArifOperator(input, ref position);
			StateSecondArg(input, ref position);
			StateSemicolon(input, ref position);
			StateRightCurly(input, ref position);
			if (LastState) { break; }
		}

		return errors;
	}

}