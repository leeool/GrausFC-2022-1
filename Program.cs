double F;

Console.Write("Entre com a temperatura em °F: ");
F = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine($"{F}°F equivalem a {(F - 32) / 1.8:N2}°C = ");
