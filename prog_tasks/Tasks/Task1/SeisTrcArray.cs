
namespace prog_tasks.Tasks.Task1
{
    public class SeisTrcArray
    {
        private SeisTrc[] traces;

        public SeisTrcArray(int numTraces, int traceSize)
        {
            if (numTraces <= 0 || traceSize <= 0)
                throw new ArgumentException("numTraces and traceSize must be greater than 0");

            traces = new SeisTrc[numTraces];

            for(int i = 0; i < numTraces; i++)
            {
                traces[i] = new SeisTrc(traceSize);
            }
        }

        public SeisTrc GetTrace(int idx)
        {
            return traces[idx];
        }

        //2D array get interface
        public float GetTraceSample(int row, int col)
        {
            if (row < 0 || col < 0)
                throw new IndexOutOfRangeException("index out of range");


            return GetTrace(col).GetSample(row);
        }

        //2D array set interface
        public void SetTraceSample(int row, int col, float val)
        {
            if (row < 0 || col < 0)
                throw new IndexOutOfRangeException("index out of range");

            GetTrace(col).SetSample(row, val);
        }
    }
}
