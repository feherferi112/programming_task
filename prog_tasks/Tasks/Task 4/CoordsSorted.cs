namespace prog_tasks.Tasks.Task3
{
    public class CoordsSorted
    {
        private WellTrack track;

        public CoordsSorted(WellTrack track)
        {
            this.track = track;
        }

        //assuming that the coords in the Welltrack object are sorted in ascending order
        public float GetDistanceAlongTrack(Coord3D pos)
        {
            var dist = 0.0f;
            var curr = 0;
            var next = 1;

            while (!Utils.IsTargetPos(pos, track.Coords[curr]))
            {
                if (curr == track.Coords.Length - 1)
                    throw new ArgumentException("Position not found along the track");

                dist += Utils.CalcDist(track.Coords[curr], track.Coords[next]);

                curr++;
                next++;
            };

            return dist;
        }
    }
}
