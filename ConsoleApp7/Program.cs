int[] nums1 = new int[3] { 1, 2, 3 };
int[] nums2 = new int[3] { 4, 5, 6 };
void mass2(int[] nums1, int[] nums2)
{
    int a = nums1.Length + nums2.Length;
    int[] newnums = new int[a];
    for (int i = 0; i < a; i++)
    {
        if (i < nums1.Length)
        {
            newnums[i] = nums1[i];
        }
        else
        {
            newnums[i] = nums2[i - nums1.Length];
        }
    }
    Console.Write("\nНовый массив: ");
    for (int i = 0; i < a; i++)
    {
        {
            Console.Write($"{newnums[i]} ");
        }
    }
}
mass2(nums1, nums2);