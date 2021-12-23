using System;

namespace Лр___6__ТОПО_
{
    public interface ISTACK<T>
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Push(T item);
        T Pop();
        T Peek();
        string PrintElements();
    }
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class NodeStack<T>:ISTACK<T>
    {
        Node<T> head;
        int count;
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Count
        {
            get { return count; }
        }
        public void Push(T item)
        {
            // увеличиваем стек
            Node<T> node = new Node<T>(item);
            node.Next = head; // переустанавливаем верхушку стека на новый элемент
            head = node;
            count++;
        }
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            Node<T> temp = head;
            head = head.Next; // переустанавливаем верхушку стека на следующий элемент
            count--;
            return temp.Data;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return head.Data;
        }
        public string PrintElements()
        {
            string s = ""; 
            Node<T> tempNode = head;
            while (tempNode != null)
            {
                s += tempNode.Data + " ";
                tempNode = tempNode.Next;
            }
            return s;
        }
    }
    public class Test
    {
        public static void Main(string[]args)
        {

        }
    }
}
