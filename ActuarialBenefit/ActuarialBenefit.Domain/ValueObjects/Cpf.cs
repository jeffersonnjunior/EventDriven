namespace ActuarialBenefit.Domain.ValueObjects;

public class Cpf
{
    public string Value { get; }

    public Cpf(string value)
    {
        if (!IsValid(value))
            throw new ArgumentException("CPF inválido", nameof(value));

        Value = CleanCpf(value);
    }

    private static bool IsValid(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
            return false;

        cpf = CleanCpf(cpf);

        if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
            return false;

        return ValidateDigits(cpf);
    }

    private static string CleanCpf(string cpf)
    {
        return new string(cpf.Where(char.IsDigit).ToArray());
    }

    private static bool ValidateDigits(string cpf)
    {
        int sum = 0;
        for (int i = 0; i < 9; i++)
            sum += int.Parse(cpf[i].ToString()) * (10 - i);

        int remainder = sum % 11;
        int digit1 = remainder < 2 ? 0 : 11 - remainder;

        sum = 0;
        for (int i = 0; i < 10; i++)
            sum += int.Parse(cpf[i].ToString()) * (11 - i);

        remainder = sum % 11;
        int digit2 = remainder < 2 ? 0 : 11 - remainder;

        return cpf[9] == digit1.ToString()[0] && cpf[10] == digit2.ToString()[0];
    }

    public string GetFormatted()
    {
        return $"{Value.Substring(0, 3)}.{Value.Substring(3, 3)}.{Value.Substring(6, 3)}-{Value.Substring(9, 2)}";
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        return obj is Cpf other && Value == other.Value;
    }

    public override int GetHashCode() => Value.GetHashCode();

    public static implicit operator string(Cpf cpf) => cpf.Value;
    public static explicit operator Cpf(string value) => new(value);
}