namespace BusinessRules
{
    public static class IsWeightAcceptable
    {
        public static bool Execute(decimal decWeight)
        {
            if (decWeight < 0.05M) return false;

            return true;
        }
    }
}