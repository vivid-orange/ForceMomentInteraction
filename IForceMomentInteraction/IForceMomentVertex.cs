using VividOrange.Taxonomy.Serialization;

namespace VividOrange.ForceMomentInteraction
{
    public interface IForceMomentVertex : ICartesianVertex<ICoordinate, Force, Moment, Moment>, ITaxonomySerializable { }
}
