using Labs.Exceptions;

namespace Labs.Calcs
{
    public static class DateCalc
    {
        private const int MaxDaysLimit = 10000;

        public static int GetIntersectionDays(DateTime d1st, DateTime d1end, DateTime d2st, DateTime d2end)
        {
            if (d1end < d1st)
                throw new ValidationException("End of the first segment must not be earlier than its start.");
            if (d2end < d2st)
                throw new ValidationException("End of the second segment must not be earlier than its start.");

            DateTime start = d1st > d2st ? d1st : d2st;
            DateTime end = d1end < d2end ? d1end : d2end;
            if (start > end)
                throw new ValidationException("Cannot find power of two for intersection length 0.");

            int days = (end - start).Days + 1;
            if (days > MaxDaysLimit)
                throw new ValidationException("Intersection length exceeds maximum allowed limit.");
            return days;
        }
    }
}
