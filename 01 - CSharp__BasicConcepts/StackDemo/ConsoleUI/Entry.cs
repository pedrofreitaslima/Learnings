namespace ConsoleUI
{
    public class Entry<T>
    {
        public Entry<T>? Next { get; set; }
        public T Data { get; set; }
        public Entry(Entry<T>? next, T data)
        {
            Next = next;
            Data = data;
        }
    }
}
