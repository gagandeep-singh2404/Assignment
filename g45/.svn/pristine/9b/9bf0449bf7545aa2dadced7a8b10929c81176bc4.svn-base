/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package appointmentplanner.util;

/**
 *
 * @author gagandeepsingh
 */
/**
 *
 * @author GAGANDEEP
 */
public class Queue<E> {

    private int size;
    private Node<E> head;

    private static class Node<E> {

        //TODO: implement a linked list inner class.
        private Node<E> next;
        private E item;

        public Node(E item) {
            // head
            this.item = item;
        }
    }

    public Queue() {
        // dummy head
        this.head = new Node(null);
        size = 0;
    }

    public boolean isEmpty() {
        return this.size == 0;
    }

    public void put(E item) {

        if (this.isEmpty()) {
            head.next = new Node(item);
        }
        
        if (this.getSize() >= 1) {
            Node<E> lastNode = head;

            while (lastNode.next != null) {
                lastNode = lastNode.next;
            }
            lastNode.next = new Node(item); 
        }

        size++;
    }

    public E get() {

        if (this.isEmpty()) {
            return null;
        }

        E firstItem = head.next.item;
        head.next = head.next.next;
        size--;
        return firstItem;

    }

    public void removeAll() {
        head.next = null;
        size = 0;

    }

    public int getSize() {
        return size;
    }
}
