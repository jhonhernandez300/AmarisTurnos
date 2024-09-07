using Core.DTOs;
using Core.Modelos;

namespace KontrolarCloud.Mapping
{
    public class MappingTurno : AutoMapper.Profile
    {
        public MappingTurno()
        {
            CreateMap<TurnoDTO, Turno>();
        }
    }
}
