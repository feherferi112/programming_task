namespace prog_tasks.Tasks.Task3
{
    public class WellTrack
    {
        private Coord3D[] coords;

        public WellTrack()
        {
            coords = [];
            Coords = coords;
        }

        public Coord3D[] Coords { get; }

        public void AddPos(Coord3D pos)
        {
            //adds a position to the end of the arr
            coords = [.. coords, pos];
        }

        public Coord3D GetPos(int idx)
        {
            if (idx < 0 || idx >= coords.Length)
                throw new IndexOutOfRangeException("Index is out of range");

            return coords[idx];
        }

        //computes the position at a given distance along the well:
        public Coord3D GetPos(float distanceAlongTrack)
        {
            if (distanceAlongTrack < 0)
                throw new ArgumentException("distance must be a positive number");

            var currDist = 0.0f;
            var curr = 0;
            var next = 1;

            while (currDist < distanceAlongTrack)
            {
                currDist += Utils.CalcDist(coords[next], coords[curr]);

                //returns the coords if it is present at the given distance
                if(Math.Abs(currDist - distanceAlongTrack) < Utils.EPSILON)
                {
                    return coords[curr];
                }

                curr++;
                next++;
            }

            var distLeft = currDist - distanceAlongTrack;

            //Assuming that the distanceAlongTrack can be arbitrary,
            //thus end up between two coordinates
            return Utils.EstimatePos(distLeft, coords[curr], coords[next]);                                  
        }

    }
}
