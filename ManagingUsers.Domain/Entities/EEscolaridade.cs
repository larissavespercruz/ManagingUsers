using System;

namespace ManagingUsers.Domain.Entities
{
    public enum EEscolaridade
    {
        Infantil = 1,
        Fundamental,
        Medio,
        Superior
    }

    public static class EEscolaridadeHelper
    {
        public static EEscolaridade ConverterDeInteiro(int valor)
        {
            if (Enum.TryParse(valor.ToString(), out EEscolaridade escolaridade))
                return escolaridade;

            throw new ArgumentOutOfRangeException("escolaridade");
        }
    }
}
