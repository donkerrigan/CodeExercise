namespace CodeExercise {
    public class Exercise {
        public Exercise() { }

        public AboveBelowResult aboveBelow(int[] integers, int comparer)
        {
            AboveBelowResult result = new AboveBelowResult { above = 0, below = 0 };
            // Return the initial zero cound when array is null
            if (integers != null)
            {
                foreach (int currentNum in integers)
                {
                    // Increment below if current number is less than the compare value
                    if (currentNum < comparer)
                    {
                        result.below++;
                    }
                    // Increment aboce if current number is greater than the compare value
                    else if (currentNum > comparer)
                    {
                        result.above ++;
                    }
                    // Ignore numbers that are equal
                }
            }

            return result;
        }

        public string stringRotation(string originalString, int rotationCount)
        {
            if (originalString != null)
            {
                // When rotation count is greater than the provided length get the remainder to properly rotate
                if (rotationCount > originalString.Length)
                {
                    rotationCount = rotationCount % originalString.Length;
                }

                // Get the substring starting from the end of the string the size of the rotation count
                string frontHalf = originalString.Substring(originalString.Length - rotationCount, rotationCount);
                // Get the substring starting from the beginning of the provided value to the rotation count index back from the end
                string backHalf = originalString.Substring(0, originalString.Length - rotationCount);

                // Return reverse concatenated values
                return frontHalf + backHalf;
            }

            // Return null when the original string was null
            return null;
        }
    }

    public class AboveBelowResult {
        public int above { get; set; }
        public int below { get; set; }
    }
}