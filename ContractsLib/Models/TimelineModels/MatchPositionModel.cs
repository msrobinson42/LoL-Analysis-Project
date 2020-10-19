namespace ContractsLib.Models.TimelineModels
{
    public class MatchPositionModel
    {
        public MatchPositionModel(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
    }
}