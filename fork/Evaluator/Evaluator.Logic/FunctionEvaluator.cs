namespace Evaluator.Logic;

public class FunctionEvaluator
{
    public static double Evalute(string infix)
    {
        var postfix = ToPostfix(infix);
        return Calculate(postfix);
    }

    private static double Calculate(List<string> postfix) // Cambio: List<string> en lugar de string
    {
        var stack = new Stack<double>();
        foreach (var item in postfix)
        {
            if (IsOperator(item)) // Cambio: ahora verificamos si el elemento es un operador usando string
            {
                var operator2 = stack.Pop();
                var operator1 = stack.Pop();
                stack.Push(Result(operator1, item[0], operator2));
            }
            else
            {
                stack.Push(double.Parse(item)); // Cambio: parseo de números decimales
            }
        }
        return stack.Pop();
    }

    private static double Result(double operator1, char item, double operator2)
    {
        return item switch
        {
            '+' => operator1 + operator2,
            '-' => operator1 - operator2,
            '*' => operator1 * operator2,
            '/' => operator1 / operator2,
            '^' => Math.Pow(operator1, operator2),
            _ => throw new Exception("Invalid expression"),
        };
    }

    private static List<string> ToPostfix(string infix) // Cambio: devuelve una List<string> en lugar de string
    {
        var stack = new Stack<char>();
        var postfix = new List<string>(); // Cambio: ahora usamos una lista para manejar números decimales
        var number = string.Empty; // Cambio: acumulador para números decimales

        foreach (var item in infix)
        {
            if (char.IsDigit(item) || item == '.') // Cambio: soporte para detectar números decimales
            {
                number += item; // Acumular números en forma de string
            }
            else
            {
                if (!string.IsNullOrEmpty(number)) // Cambio: agregar número acumulado a postfix
                {
                    postfix.Add(number);
                    number = string.Empty; // Reiniciar acumulador
                }

                if (IsOperator(item.ToString())) // Cambio: manejar operadores como string
                {
                    if (item == ')')
                    {
                        while (stack.Peek() != '(')
                            postfix.Add(stack.Pop().ToString());
                        stack.Pop();
                    }
                    else
                    {
                        while (stack.Count > 0 && PriorityExpression(item) <= PriorityStack(stack.Peek()))
                            postfix.Add(stack.Pop().ToString());
                        stack.Push(item);
                    }
                }
                else if (item == '(')
                {
                    stack.Push(item);
                }
            }
        }

        if (!string.IsNullOrEmpty(number)) // Cambio: agregar último número al postfix si queda alguno pendiente
        {
            postfix.Add(number);
        }

        while (stack.Count > 0)
        {
            postfix.Add(stack.Pop().ToString());
        }

        return postfix;
    }

    private static int PriorityStack(char item) =>
        item switch
        {
            '^' => 3,
            '*' => 2,
            '/' => 2,
            '+' => 1,
            '-' => 1,
            '(' => 0,
            _ => throw new Exception("Invalid expression"),
        };

    private static int PriorityExpression(char item) =>
        item switch
        {
            '^' => 4,
            '*' => 2,
            '/' => 2,
            '+' => 1,
            '-' => 1,
            '(' => 5,
            _ => throw new Exception("Invalid expression"),
        };

    private static bool IsOperator(string item) => "()^*/+-".Contains(item); // Cambio: ahora acepta strings en lugar de chars
}