namespace prog_tasks.Tasks.Task1
{
    public class SeisTrc
    {
        private float[] samples;

        public SeisTrc(int n)
        {
            if (n <= 0)
                throw new ArgumentException("n must be greater than 0");

            samples = new float[n];
        }

        public float GetSample(int idx)
        {
            if (idx < 0 || idx >= samples.Length)
                throw new IndexOutOfRangeException("Sample index is out of range");

            return samples[idx];
        }

        public void SetSample(int idx, float val)
        {
            if (idx < 0 || idx >= samples.Length)
                throw new IndexOutOfRangeException("Sample index is out of range");

            samples[idx] = val;
        }
    }
}
