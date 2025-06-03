using SafeZoneModel;
using System.Collections.Generic;
using System.Linq;

namespace SafeZoneBusiness
{
    public class AlertaService
    {
        private static readonly List<AlertaModel> _alertas = new();
        private static int _nextId = 1;

        public List<AlertaModel> ListarTodos() => _alertas;

        public AlertaModel? ObterPorId(int id) => _alertas.FirstOrDefault(a => a.Id == id);

        public AlertaModel Criar(AlertaModel alerta)
        {
            alerta.Id = _nextId++;
            _alertas.Add(alerta);
            return alerta;
        }

        public bool Atualizar(AlertaModel alerta)
        {
            var existente = ObterPorId(alerta.Id);
            if (existente == null) return false;

            existente.Tipo = alerta.Tipo;
            existente.Descricao = alerta.Descricao;
            existente.DataHora = alerta.DataHora;

            return true;
        }

        public bool Remover(int id)
        {
            var alerta = ObterPorId(id);
            if (alerta == null) return false;

            _alertas.Remove(alerta);
            return true;
        }
    }
}
