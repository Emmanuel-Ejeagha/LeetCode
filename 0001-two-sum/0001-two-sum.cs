public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary to store the difference between target and current number
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {  // O(n)
            int complement = target - nums[i];

            // Check if the complement exists in the dictionary
            if (map.ContainsKey(complement)) { 
                // Return the indices of the current number and its complement
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        // If no solution is found, throw an exception
        throw new ArgumentException("No two sum solution");
    }
}