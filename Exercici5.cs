using System;
namespace ExerciceFive
{
    public class ExerciceFive
    {
        public static void Main()
        {
            int[] nums = new int[5];
            int key;
            bool itIs = false;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Order(nums);
            Console.WriteLine("Nombres en ordra descendent");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("Introdueix un nombre per buscar-lo");
            key = Convert.ToInt32(Console.ReadLine());
            search(ref nums, ref key, itIs);
            if (itIs == true)
            {
                Console.WriteLine("El nombre introduit es troba entre els introduits");
            }
            else
            {
                Console.WriteLine("No s'ha trobat el nombre introduit");
            }
        }
        public static int[] Order(int[] nums)
        {
            int changer;
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        changer = nums[i];
                        nums[i] = nums[j];
                        nums[j] = changer;
                    }
                }
            }
            return nums;
        }

        public static void search(ref int[] nums, ref int key, bool itIs)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key)
                {
                    itIs = true;
                }
            }
            return;
        }
    }
}