namespace EventDriven.Domain.ValueObjects;

public sealed class Cpf
{
    public string Value { get; private set; }

    public Cpf(string rawCpf /*NotificationContext notificationContext*/)
    {
        var cleanedCpf = Clean(rawCpf);

        if (!IsValid(cleanedCpf))
        {
            // notificationContext.AddNotification("Cpf", "O CPF informado é inválido.");

        }

        Value = cleanedCpf;
    }

    private Cpf()
    {
        Value = string.Empty;
    }

    private string Clean(string rawCpf)
    {
        if (rawCpf is null)
            return string.Empty;

        return new string(rawCpf.Where(char.IsDigit).ToArray());
    }

    private bool IsValid(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
            return false;

        if (cpf.Length != 11)
            return false;

        if (cpf.Distinct().Count() == 1)
            return false;

        int[] digits = cpf.Select(ch => ch - '0').ToArray();

        int[] weights1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int sum = 0;
        for (int i = 0; i < 9; i++)
            sum += digits[i] * weights1[i];

        int remainder = sum % 11;
        int firstCheck = remainder < 2 ? 0 : 11 - remainder;
        if (digits[9] != firstCheck)
            return false;

        int[] weights2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        sum = 0;
        for (int i = 0; i < 10; i++)
            sum += digits[i] * weights2[i];

        remainder = sum % 11;
        int secondCheck = remainder < 2 ? 0 : 11 - remainder;
        if (digits[10] != secondCheck)
            return false;

        return true;
    }
}
