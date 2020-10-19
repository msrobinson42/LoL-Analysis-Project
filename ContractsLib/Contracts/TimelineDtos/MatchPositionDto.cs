using ContractsLib.Models.TimelineModels;
using System.Runtime.Serialization;

namespace ContractsLib.Contracts.TimelineDtos
{
    [DataContract]
    public class MatchPositionDto
    {
        [DataMember]
        public int X { get; set; }

        [DataMember]
        public int Y { get; set; }

    }

    public static class MatchPositionDtoExtensions
    {
        public static MatchPositionModel ToMatchPositionModel(this MatchPositionDto @this)
        {
            if (@this is null)
            {
                return null;
            }

            return new MatchPositionModel(@this.X, @this.Y);
        }
    }
}