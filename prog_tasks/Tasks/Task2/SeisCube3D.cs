using prog_tasks.Tasks.Task1;
using prog_tasks.Tasks.Task3;

namespace prog_tasks.Tasks.Task2
{
    public class SeisCube3D
    {
        private SeisTrcArray[] seisTrcCube;

        public SeisCube3D(int rows, int cols, int depths) 
        {
            if (rows <= 0 || cols <= 0 || depths <= 0) 
                throw new ArgumentException("rows, cols and depths must be greater than 0");

            seisTrcCube = new SeisTrcArray[depths];

            for (int i = 0; i < depths; i++)
            {
                seisTrcCube[i] = new SeisTrcArray(rows, cols);
            }
        }

        public SeisTrcArray GetTrcArray(int idx)
        {
            if (idx < 0 || idx >= seisTrcCube.Length)
                throw new IndexOutOfRangeException("Index is out of range");

            return seisTrcCube[idx];
        }

        //3D Cube interface: get element
        public float GetTrcSample(int row, int col, int depth)
        {
            if (row < 0 || col < 0 || depth < 0)
                throw new IndexOutOfRangeException("index out of range");

            return GetTrcArray(depth).GetTraceSample(row, col);
        }

        //3D Cube interface: set element
        public void SetTrcSample(int row, int col, int depth, float val)
        {
            if (row < 0 || col < 0 || depth < 0)
                throw new IndexOutOfRangeException("index out of range");

            GetTrcArray(depth).SetTraceSample(row, col, val);
        }
    }
}
