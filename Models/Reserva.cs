namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int capacidade = Suite.Capacidade;

            int quantHospedes = hospedes.Count;

            if (quantHospedes <= capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new InvalidOperationException("Capacidade insuficiente para a quantidade de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;

            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = 0;
            }

            return valor;
        }
    }
}