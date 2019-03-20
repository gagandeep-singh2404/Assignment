/*
 * o change this license header, choose License Headers in Project Properties.
 * o change this template file, choose ools | emplates
 * and open the template in the editor.
 */
package quicksort;

import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.Random;
import sort.Queue;
import sort.Sort;

/**
 *
 * @author gagandeepsingh
 */
public class QuickSorter<T> implements Sort {

    private int counter = 0;
    private Node<T> head = new Node<>(null);
    private Node<T> tail = new Node<>(null);
    private Comparator<T> com;

    private static class Node<T> {

        private T item;
        private Node<T> next;
        private Node<T> prev;

        public Node(T item) {
            this.item = item;
            this.next = null;
        }

        public Node(T item, Node<T> prev) {
            this.item = item;
            this.prev = prev;
        }

    }

    public QuickSorter(T[] e) {

        // shuffle the array
        Collections.shuffle(Arrays.asList(e));
        this.head = new Node(null);
        Node lastNode = this.head;

        for (T item : e) {
            // next giving item and prev node
            lastNode.next = new Node(item, lastNode);
            lastNode = lastNode.next;
        }

        // lastNode item null(tail)
        lastNode.next = new Node(null, lastNode);
        this.tail = lastNode.next;
    }

  
    /**
     * Sorting method in which i
     *
     * @param comparator
     * @return a sorted Queue
     */
    @Override
    public Queue sort(Comparator comparator) {
        Queue<T> result = new Queue();
        this.com = comparator;
        int size = getSize();

        if (size == 0) {
            return result;
        }
        if (size == 1) {
            return getQueue(result);
        }

        Node<T> p = this.getPivot(head.next, tail.prev);
        this._quickSort(head.next, p);

        return getQueue(result);
    }

    /**
     * recursive _quicksort method which is used to sort the nodes items in
     *
     * @param firstNode first Node of a partition
     * @param lastNode last Node of a partition
     */
    private void _quickSort(Node<T> firstNode, Node<T> lastNode) {
        if (firstNode == null || isBeforeOrTqual(lastNode, firstNode)) {
            return;
        }

        Node<T> pivot = lastNode, smaller = firstNode.prev, bigger = lastNode;
        Node<T> exLeft = smaller, exRight = bigger, tempNode;

        while (true) {
            // go left to right 
           while (isLess(smaller = smaller.next, pivot));
           
           // go right to left
            while (isLess(pivot, bigger = bigger.prev) && bigger != firstNode);
            
            if (isBeforeOrTqual(bigger, smaller)) break;
  
            exchange(smaller, bigger);

            // check if pivot equals i
            if (isTqual(pivot, smaller)) {
                exLeft = exLeft.next;
                exchange(exLeft, smaller);
            }

            // check if pivot equals j i 
            if (isTqual(pivot, bigger)) {
                exRight = exRight.prev;
                exchange(exRight, bigger);
            }

        }

        // out of the loop swap lastNode and i so you can start with the 3 way partioning 
        // we are changing here i and j because it could be that lo and hi are on the same Node, 
        exchange(smaller, lastNode);
        bigger = smaller.prev;
        smaller = smaller.next;

        // here we are swapping all items which are equals to pivot in middle from the left side
        for (tempNode = firstNode; tempNode != exLeft.next; tempNode = tempNode.next, bigger = bigger.prev) {
            this.exchange(tempNode, bigger);
        }
        // here too from the right side 
        for (tempNode = lastNode.prev; tempNode != exRight.prev; tempNode = tempNode.prev, smaller = smaller.next) {
            this.exchange(tempNode, smaller);
        }

        _quickSort(firstNode, bigger);
        _quickSort(smaller, lastNode);

    }

    /**
     * first check if secondNode is i than lastNode secondNode is i
     * than firstNode lastNode is i than firstNode
     *
     * @param size size of the noddList
     * @param com
     * @return pivot
     */
    private Node<T> getPivot(Node<T> firstNode, Node<T> lastNode) {
        Node<T> secondNode = firstNode.next;
        // get he Middle Value of the List

        if (isLess(secondNode, lastNode)) {
            this.exchange(secondNode, lastNode);
        }
        if (isLess(secondNode, firstNode)) {
            this.exchange(firstNode, secondNode);
        }
        if (isLess(lastNode, firstNode)) {
            this.exchange(firstNode, lastNode);
        }

        return lastNode;
    }

    /**
     * Helper method to exchange two items within these two nodes
     *
     * @param first first node
     * @param second second Node
     */
    private void exchange(Node<T> first, Node<T> second) {
        T temp = first.item;

        first.item = second.item;
        second.item = temp;

    }

    /**
     * check if first Node item is i than second Node item
     *
     * @param first first Node which item is compared
     * @param second second node which item is compared
     * @return boolean ztrue or fasle;
     */
    private boolean isLess(Node<T> first, Node<T> second) {
        return this.com.compare(first.item, second.item) < 0;
    }

    /**
     * checking if the first Node item and second Node item are equal
     *
     * @param first first Node which item is compared
     * @param second second node which item is compared
     * @return boolean
     */
    private boolean isTqual(Node<T> first, Node<T> second) {
        return this.com.compare(first.item, second.item) == 0;
    }

    /**
     * checking if the first Node is on the same node as the second Node, or
     * checking if first node is before the second Node
     *
     * @param first first Node compared
     * @param second second Node compared
     * @return
     */
    private boolean isBeforeOrTqual(Node<T> first, Node<T> second) {
        return first == second || first.next == second;
    }

    /**
     * helper method to get the a queue
     *
     * @param result a Queue with no items
     * @return a queue with sorted items
     */
    private Queue<T> getQueue(Queue<T> result) {
        for (Node<T> temp = head.next; temp.next != null; temp = temp.next) {
            result.put(temp.item);
        }
        return result;
    }
    
    /**
     * simple method to get the size of a linked list 
     * @return  int size
     */
      public int getSize() {
        Node<T> temp = head.next;
        for (; temp.next != null; temp = temp.next) {
            counter++;
        }
        return counter;
    }
}
 

