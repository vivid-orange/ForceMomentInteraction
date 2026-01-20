using VividOrange.Serialization;

namespace VividOrange.ForceMomentInteraction
{
    public interface IForceMomentTriFace : ICartesianTriFace<IForceMomentVertex, ICoordinate, Force, Moment, Moment>, ITaxonomySerializable { }
}
