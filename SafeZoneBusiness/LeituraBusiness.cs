using SafeZoneModel;

namespace SafeZoneBusiness
{
    public class LeituraService
    {
        private static readonly List<LeituraModel> _leituras = new();
        private static int _nextId = 1;

        public List<LeituraModel> ListarTodas() => _leituras;

        public LeituraModel? ObterPorId(int id) => _leituras.FirstOrDefault(l => l.Id == id);

        public LeituraModel Criar(LeituraModel leitura)
        {
            leitura.Id = _nextId++;
            _leituras.Add(leitura);
            return leitura;
        }

        public bool Atualizar(LeituraModel leitura)
        {
            var existente = ObterPorId(leitura.Id);
            if (existente == null) return false;

            existente.DataHora = leitura.DataHora;
            existente.Temperatura = leitura.Temperatura;
            existente.Umidade = leitura.Umidade;

            return true;
        }

        public bool Remover(int id)
        {
            var leitura = ObterPorId(id);
            if (leitura == null) return false;

            _leituras.Remove(leitura);
            return true;
        }
    }
}
