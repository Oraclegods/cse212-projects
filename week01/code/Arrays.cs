public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan:
        // 1. Create a new array of doubles called 'multiples' with a size of 'length'.
        // 2. Create a loop that starts at 0 and goes up to 'length'.
        // 3. Inside the loop, calculate the multiple: number * (index + 1).
        //    (We use +1 because the first multiple is number * 1, but the index starts at 0).
        // 4. Assign that value to the current index in the array.
        // 5. Return the completed array.


        // Step 1: Create the array
        double[] multiples = new double[length];

        // Step 2 & 3: Loop and calculate
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 5: Return
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Plan:
        // 1. Identify the split point by subtracting 'amount' from the total count of the list.
        // 2. Use GetRange to capture the elements from the split point to the end of the list.
        // 3. Use RemoveRange to delete those same elements from the back of the original list.
        // 4. Use InsertRange to place those captured elements at the very beginning (index 0).

        // Only rotate if the list has data and the amount is valid

    if (data.Count > 0)
        {
            // Step 1: Find where to cut (e.g., if count is 9 and amount is 3, start at index 6)
            int splitIndex = data.Count - amount;

            // Step 2: Slice the end part
            List<int> endPart = data.GetRange(splitIndex, amount);

            // Step 3: Remove that part from the back
            data.RemoveRange(splitIndex, amount);

            // Step 4: Move it to the front
            data.InsertRange(0, endPart);
        }
    }
}

