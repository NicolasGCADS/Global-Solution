using SafeZoneModel;

namespace SafeZoneBusiness
{
    public class DispositivoService
    {
        private static readonly List<DispositivoModel> _dispositivos = new();
        private static int _nextId = 1;

        public List<DispositivoModel> ListarTodos() => _dispositivos;

        public DispositivoModel? ObterPorId(int id) =>
            _dispositivos.FirstOrDefault(d => d.Id == id);

        public DispositivoModel Criar(DispositivoModel dispositivo)
        {
            dispositivo.Id = _nextId++;
            _dispositivos.Add(dispositivo);
            return dispositivo;
        }

        public bool Atualizar(DispositivoModel dispositivo)
        {
            var existente = ObterPorId(dispositivo.Id);
            if (existente == null) return false;

            existente.Latitude = dispositivo.Latitude;
            existente.Longitude = dispositivo.Longitude;
            existente.Descricao_Local = dispositivo.Descricao_Local;
            existente.Ativo = dispositivo.Ativo;

            return true;
        }

        public bool Remover(int id)
        {
            var dispositivo = ObterPorId(id);
            if (dispositivo == null) return false;

            _dispositivos.Remove(dispositivo);
            return true;
        }
    }
}
