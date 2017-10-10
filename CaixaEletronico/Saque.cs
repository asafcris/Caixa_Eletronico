namespace CaixaEletronico
{
    public struct Saque
    {
        private readonly int _notasDeDez;
        private readonly int _notasDeVinte;
        private readonly int _notasDeCinquenta;
        private readonly int _notasDeCem;

        public Saque(int notasDeDez, int notasDeVinte, int notasDeCinquenta, int notasDeCem)
        {
            _notasDeDez = notasDeDez;
            _notasDeVinte = notasDeVinte;
            _notasDeCinquenta = notasDeCinquenta;
            _notasDeCem = notasDeCem;
        }

        public int NotasDeDez { get { return _notasDeDez; } }

        public int NotasDeVinte { get { return _notasDeVinte; } }

        public int NotasDeCinquenta { get { return _notasDeCinquenta; } }

        public int NotasDeCem { get { return _notasDeCem; } }
    }


}
