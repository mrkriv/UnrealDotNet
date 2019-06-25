namespace UnrealEngine
{
    public partial class FVector2D
    {
        public static FVector2D operator +(FVector2D a, FVector2D b)
        {
            return new FVector2D(a.X + b.X, a.Y + b.Y);
        }

        public static FVector2D operator -(FVector2D a, FVector2D b)
        {
            return new FVector2D(a.X - b.X, a.Y - b.Y);
        }
        
        public static FVector2D operator *(FVector2D a, float b)
        {
            return new FVector2D(a.X * b, a.Y * b);
        }

        public static FVector2D operator +(FVector2D a, float b)
        {
            return new FVector2D(a.X + b, a.Y + b);
        }

        public static FVector2D operator -(FVector2D a, float b)
        {
            return new FVector2D(a.X - b, a.Y - b);
        }

        public static FVector2D operator /(FVector2D a, float b)
        {
            return new FVector2D(a.X / b, a.Y / b);
        }
    }
}