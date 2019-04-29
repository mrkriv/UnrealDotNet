namespace UnrealEngine
{
    public partial class FVector
    {
        public static FVector operator +(FVector a, FVector b)
        {
            return new FVector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static FVector operator -(FVector a, FVector b)
        {
            return new FVector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        
        public static FVector operator *(FVector a, float b)
        {
            return new FVector(a.X * b, a.Y * b, a.Z * b);
        }

        public static FVector operator +(FVector a, float b)
        {
            return new FVector(a.X + b, a.Y + b, a.Z + b);
        }

        public static FVector operator -(FVector a, float b)
        {
            return new FVector(a.X - b, a.Y - b, a.Z - b);
        }

        public static FVector operator /(FVector a, float b)
        {
            return new FVector(a.X / b, a.Y / b, a.Z / b);
        }
    }
}