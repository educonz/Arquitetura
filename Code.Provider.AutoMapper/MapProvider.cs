using AutoMapper;
using Core.Map;

namespace Core.Provider.AutoMapper
{
    public class MapProvider : IMap
    {
        private readonly IMapper _mapper;

        public MapProvider(IMapper mapper) =>
            _mapper = mapper;

        public TOutput Map<TInput, TOutput>(TInput input) =>
            _mapper.Map<TInput, TOutput>(input);

        public TOutput Map<TOutput>(object source) =>
            _mapper.Map<TOutput>(source);
    }
}
