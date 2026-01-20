using VividOrange.Serialization;

namespace VividOrange.ForceMomentInteraction
{
    public interface IForceMomentVertex : ICartesianVertex<ICoordinate, Force, Moment, Moment>, ITaxonomySerializable { }
}
