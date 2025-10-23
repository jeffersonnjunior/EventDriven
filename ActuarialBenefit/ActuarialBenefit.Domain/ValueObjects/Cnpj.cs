namespace ActuarialBenefit.Domain.ValueObjects;

public class Cnpj
{
    public string Value { get; }

    public Cnpj(string value)
    {
        if (!IsValid(value))
            throw new ArgumentException("CNPJ inválido", nameof(value));

        Value = CleanCnpj(value);
    }

    private static bool IsValid(string cnpj)
    {
        if (string.IsNullOrWhiteSpace(cnpj))
            return false;

        cnpj = CleanCnpj(cnpj);

        if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
            return false;

        return ValidateDigits(cnpj);
    }

    private static string CleanCnpj(string cnpj)
    {
        return new string(cnpj.Where(char.IsDigit).ToArray());
    }

    private static bool ValidateDigits(string cnpj)
    {
        int[] weights1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] weights2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        int sum = 0;
        for (int i = 0; i < 12; i++)
            sum += int.Parse(cnpj[i].ToString()) * weights1[i];

        int remainder = sum % 11;
        int digit1 = remainder < 2 ? 0 : 11 - remainder;

        sum = 0;
        for (int i = 0; i < 13; i++)
            sum += int.Parse(cnpj[i].ToString()) * weights2[i];

        remainder = sum % 11;
        int digit2 = remainder < 2 ? 0 : 11 - remainder;

        return cnpj[12] == digit1.ToString()[0] && cnpj[13] == digit2.ToString()[0];
    }

    public string GetFormatted()
    {
        return $"{Value.Substring(0, 2)}.{Value.Substring(2, 3)}.{Value.Substring(5, 3)}/{Value.Substring(8, 4)}-{Value.Substring(12, 2)}";
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        return obj is Cnpj other && Value == other.Value;
    }

    public override int GetHashCode() => Value.GetHashCode();

    public static implicit operator string(Cnpj cnpj) => cnpj.Value;
    public static explicit operator Cnpj(string value) => new(value);
}