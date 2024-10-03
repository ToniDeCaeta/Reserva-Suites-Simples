namespace Sistema_Reserva.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } //lista do tipo Pessoa, representando Hospede
        public Suite Suite { get; set; } //Suite do tipo Suite representando as suites
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)// construtor da Reserva, já exige a quantidade de dias a reservar
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite.Capacidade >= hospedes.Count()) 
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception ("O número de hóspedes, é maior que a capacidade máxima da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            int quantidadeHospedes = Hospedes.Count();
            Console.WriteLine($"A quantidade de hóspedes total, é: {quantidadeHospedes}");
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valorReserva = (DiasReservados*30);


            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            
            if (DiasReservados >= 10)
            {
                decimal desconto = (valorReserva/100)*10;
                valorReserva -= desconto;
            }

            return valorReserva;
        }
    }
}