using DoublyLinkedList;

namespace DoublyLnkedList
{
    public class DoublLinkedList
    {
        public DoublLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Count { get; set; }

        public void PushFront(object value)
        {
            if (Head == null && Count == 0)
            {
                Head = new Node()
                {
                    Prev = null,
                    Data = value,
                    Next = null,
                };

                Tail = Head;
                Count++;
            }

            var prevHead = Head;

            Head = new Node()
            {
                Prev = null,
                Data = value,
                Next = prevHead,
            };

            prevHead.Prev = Head;

            Count++;
        }

        public void PushBack(object value)
        {
            if (Tail == null && Count == 0)
            {
                Head = new Node()
                {
                    Prev = null,
                    Data = value,
                    Next = null,
                };

                Tail = Head;
                Count++;
            }
            var prevTail = Tail;

            Tail = new Node()
            {
                Prev = Tail,
                Data = value,
                Next = null,
            };
            prevTail.Next = Tail;
            Count++;
        }

        public void PopFront()
        {
            if (Head != null && Count != 0)
            {
                Head = Head.Next;
                Head.Prev = null;
                Count--;
            }
        }

        public void PopBack()
        {
            if (Tail != null && Count != 0)
            {
                Tail = Tail.Prev;
                Tail.Next = null;
                Count--;
            }
        }

        public object GetElement(int item)
        {
            Node curr = Head;

            for (var x = 0; x < item; x++)
            {
                curr = curr.Next;
            }
            return curr.Data;
        }
        public object GetElemenByData(object item)
        {
            Node curr = Head;

            for (var x = 0; x < Count; x++)
            {
                if (curr.Data.Equals(item))
                {
                    return curr.Data;
                }
                curr = curr.Next;
            }
            return null;
        }
        public int? GetSize()
        {
            if (Head != null && Count != 0)
            {
                return Count;
            }
            return null;
        }
        public void Reverse()
        {
            var temp = Head;
            Head = Tail;
            Tail = temp;
            var curr = Head;
            Node change;
            for (var x = 0; x < Count; x++)
            {
                change = curr.Prev;
                curr.Prev = curr.Next;
                curr.Next = change;

                curr = curr.Next;
            }
        }
        public void Clear()
        {
            if (Count != 0)
            {
                Node temp = null;
                for(var x = 0; x <= Count; x++)
                 {
                    temp = Head.Next;
                    temp.Prev = null;
                    Head = temp;
                    if(Count == 1)
                    {
                        Head = null;
                    }
                    Count--;
                }
                if (Count == 1)
                {
                    Head = null;
                    Count = 0;
                }
            }
        }
        public bool IsEmpty()
        {
            if(Head != null && Count != 0)
            {
                return false;
            }
            return true;
        }
        public object[] PrintList()
        {
            var temp = Head;
            var result = new object[Count];
            for(var j = 0; j<result.Length;j++)
            {
                result[j] = temp.Data;
                temp = temp.Next;
            }
            return result;
        }
        public object[] PrintListReversed()
        {
            var temp = Tail;
            var result = new object[Count];
            for (var j = 0; j < result.Length; j++)
            {
                result[j] = temp.Data;
                temp = temp.Prev;
            }
            return result;
        }
        public void InsertIn(int index, object value)
        {
            var newNode = new Node() { Data = value };

            if (index <= Count)
            {
                var temp = Head;

                for(var x = 0; x<index; x++)
                {
                    temp = temp.Next;
                    if(x == index-1)
                    {
                        temp.Prev.Next = newNode;
                        newNode.Prev = temp.Prev;
                        newNode.Next = temp;
                    }
                }
            }
            else if (index > Count)
            {
                PushBack(value);
            }
            else
            {
                Head = newNode;
            }
            Count++;
        }
        public DoublLinkedList Copy()
        {
            DoublLinkedList result = new DoublLinkedList()
            {
                Head = Head,
                Count = Count
            };
            return result;
        }
    }
}
