namespace CustomList
{
     class Program
    {
        public static object myList;
        public static object Capacity;

        static void Main(string[] args)
        {
            CustomList<int> mylist = new CustomList<int>();
            Console.WriteLine(mylist.Count);
            Console.WriteLine(myList.Capacity);
            Console.WriteLine(mylist.[2]);


        }
    }
}