namespace OzProject
{
    public class ListNode<T>
    {
        public T data;
        
        public ListNode<T> nextNode { get; set; }
        public ListNode(T dt)
        {
            data = dt;
        }
    }
}
