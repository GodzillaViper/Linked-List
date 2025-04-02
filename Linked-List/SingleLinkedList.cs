class SingleLinkedList<T> {
    private Node<T> head;
    
    public SingleLinkedList() {
        head = null;
    }
    
    public void addFirst(T data) {
        head = new Node<T>(data, head);
    }
    
    public void addLast(T data) {
        if (head == null) {
            head = new Node<T>(data);
            return;
        }

        Node<T> current = head;
        while (current.Next != null) {
            current = current.Next;
        }
        current.Next = new Node<T>(data);
    }
    
    public void addAt(T data, int position) {
        if (position == 0) {
            addFirst(data);
            return;
        }
        
        Node<T> current = head;
        for (int i = 0; current != null && i < position - 1; i++) {
            current = current.Next;
        }
        
        if (current == null) return;
        
        current.Next = new Node<T>(data, current.Next);
    }
    
    public bool inList(T value) {
        Node<T> current = head;
        while (current != null) {
            if (EqualityComparer<T>.Default.Equals(current.Data, value)) {
                return true;
            }
            current = current.Next;
        }
        return false;
    }
    
    public void deleteNode(T value) {
        if (head == null) return;
        
        if (EqualityComparer<T>.Default.Equals(head.Data, value)) {
            head = head.Next;
            return;
        }
        
        Node<T> current = head;
        while (current.Next != null && !EqualityComparer<T>.Default.Equals(current.Next.Data, value)) {
            current = current.Next;
        }
        
        if (current.Next == null) return;
        
        current.Next = current.Next.Next;
    }
    
    public void printList() {
        Node<T> temp = head;
        while (temp != null) {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}