internal class Program {
    private static void Main(string[] args) {
        SingleLinkedList<int> list = new SingleLinkedList<int>();

        list.addFirst(1);
        list.addFirst(2);
        list.addFirst(3);
        list.addAt(55, 1);

        Console.WriteLine("Lista före borttagning:");
        list.printList();
        
        list.deleteNode(2);
        
        Console.WriteLine("Lista efter borttagning av 2:");
        list.printList();
        
        Console.WriteLine(list.inList(2) ? "Value is in the list" : "Value is not in the list");
        Console.WriteLine(list.inList(6) ? "Value is in the list" : "Value is not in the list");
    }
}