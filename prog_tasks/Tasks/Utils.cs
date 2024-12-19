using prog_tasks.Tasks.Task3;

namespace prog_tasks.Tasks
{
    public static class Utils
    {
        public const float EPSILON = 0.0001f;

        public static bool IsTargetPos(Coord3D pos, Coord3D currentPos)
        {
            //dx, dy, dz needs to be within deltaEpsilon distance
            var dx = Math.Abs(pos.x_ - currentPos.x_);
            var dy = Math.Abs(pos.y_ - currentPos.y_);
            var dz = Math.Abs(pos.z_ - currentPos.z_);

            if (dx < EPSILON && dy < EPSILON && dz < EPSILON) return true;

            return false;
        }

        //Assuming straight line between two consecutive points
        public static Coord3D EstimatePos(float distLeft, Coord3D vec1, Coord3D vec2)
        {
            //Vector between the last two points,
            //pointing from vec1 to vec2
            var vec = new Coord3D()
            {
                x_ = vec2.x_ - vec1.x_,
                y_ = vec2.y_ - vec1.y_,
                z_ = vec2.z_ - vec1.z_
            };

            //Length
            var vecDist = CalcDist(vec1, vec2);

            //distance from the last data point
            var dist = vecDist - distLeft;

            //Norm than scale with the leftover dist
            var vecToAdd = new Coord3D()
            {
                x_ = vec.x_ / vecDist * dist,
                y_ = vec.y_ / vecDist * dist,
                z_ = vec.z_ / vecDist * dist
            };

            //Add this vector to the last vector
            var position = new Coord3D()
            {
                x_ = vecToAdd.x_ + vec1.x_,
                y_ = vecToAdd.y_ + vec1.y_,
                z_ = vecToAdd.z_ + vec1.z_
            };

            return position;
        }

        //calculates the distance between two vectors
        public static float CalcDist(Coord3D vec1, Coord3D vec2)
        {
            var dx = Math.Pow(vec2.x_ - vec1.x_, 2);
            var dy = Math.Pow(vec2.y_ - vec1.y_, 2);
            var dz = Math.Pow(vec2.z_ - vec1.z_, 2);

            return (float)Math.Sqrt(dx + dy + dz);
        }
    }
}
