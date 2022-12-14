namespace Lab1
{
    public class EngMer
    {
        public int f;
        public int d;
        public EngMer(int f, int d)
        {
            this.f = f;
            this.d = d;
            if (d >= 12)
            {
                int w = d / 12;
                int remainder = d % 12;
                this.f += w;
                this.d = remainder;
            }
        }
        public static EngMer operator +(EngMer x, EngMer y)
        {
            int f = x.f + y.f;
            int d = x.d + y.d;
            if (d >= 12)
            {
                int w = d / 12;
                int remainder = d % 12;
                f += w;
                d = remainder;
            }
            return new EngMer(f, d );
        }
        public static EngMer operator -(EngMer x, EngMer y)
        {
            int all_x = x.d + x.f * 12;
            int all_y = y.d + y.f * 12;
            int d = all_x - all_y;
            int w = d / 12;
            int remainder = d % 12;
            int f = w;
            d = remainder;
            return new EngMer(f, d);
        }
        public static EngMer operator *(EngMer x, int y)
        {
            int f = x.f * y;
            int d = x.d * y;
            if (d >= 12)
            {
                int w = d / 12;
                int remainder = d % 12;
                f += w;
                d = remainder;
            }
            return new EngMer(f, d);
        }
        public static EngMer operator /(EngMer x, int y)
        {
            int all = (x.d + x.f * 12) / y;
            int w = all / 12;
            int remainder = all % 12;
            int f = w;
            int d = remainder;
            return new EngMer(f, d);
        }
    }
}
