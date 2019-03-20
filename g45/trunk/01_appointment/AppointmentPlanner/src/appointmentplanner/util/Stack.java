/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package appointmentplanner.util;

import appointmentplanner.Appointment;

/**
 *
 * @author gagandeepsingh
 */
public class Stack<Item> {

    private int size;
    private Node item;

    private static class Node<E> {

        //TODO: implement a linked list inner class.
        private Node<E> next;
        private E item;

        public Node(E item) {
            // head
            this.item = item;
            this.next = null;
        }

//        public Node(E item, Node<E> next) {
//            this.item = item;
//            this.next = next;
//        }

    }

    private Node tail;

    public Stack() {
        this.tail = new Node<>(null);
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public void push(Item item) {

        Node<Item> newItem = new Node(item);

        newItem.next = tail.next;

        tail.next = newItem;
        size++;

    }

    public int size() {
        return size;
    }

    public Item pop() {
        if (size <= 0) {
            return null;
        }

        Node<Item> tempNode = tail.next;

        if (tail.next.next == null) {
            tail.next = null;
        }else{
               tail.next = tail.next.next;
        }
        size--; 
     return tempNode.item; 
    }

}
