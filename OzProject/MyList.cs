namespace OzProject
{
    public class MyList<T> : IEnumerable<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public void AddToHead (ListNode<T> data)
        {
            if (Head == null)
            {
                Head = data;
            }
            else
            {
                data.nextNode = Head;
                Head = data;
            }
        }

        public int Contains(T data)
        {
            ListNode<T>? currentNode = Head;
            int index = 0;

            while (currentNode != null)
            {
                if (currentNode.data.Equals(data))
                {
                    return index;
                }
                currentNode = currentNode.nextNode;
                index++;
            }
            return -1;
        }

        public int GetCount()
        {
            ListNode<T>? currentNode = Head;
            int count = 0;

            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.nextNode;
            }

            return count;
        }

        public T GetElementAt(int position)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position cannot be negative.");
            }

            ListNode<T>? currentNode = Head;
            int currentPosition = 0;

            while (currentNode != null)
            {
                if (currentPosition == position)
                {
                    return currentNode.data;
                }

                currentNode = currentNode.nextNode;
                currentPosition++;
            }

            throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
        }

        public bool Remove(T data)
        {
            ListNode<T>? current = Head;
            ListNode<T>? previous = null;

            while (current != null && current.data != null)
            {
                if (current.data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.nextNode = current.nextNode;

                        if (current.nextNode == null)
                            Tail = previous;
                    }
                    else
                    {
                        Head = Head?.nextNode;

                        if (Head == null)
                            Tail = null;
                    }

                    return true;
                }

                previous = current;
                current = current.nextNode;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T>? current = Head;
            while (current != null)
            {
                yield return current.data;
                current = current.nextNode;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
