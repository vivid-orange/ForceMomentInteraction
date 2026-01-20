using VividOrange.Serialization;

namespace VividOrange.ForceMomentInteraction
{
    public interface IForceMomentMesh : ICartesianMesh<IForceMomentVertex, IForceMomentTriFace, ICoordinate, Force, Moment, Moment>, ITaxonomySerializable { }
}
