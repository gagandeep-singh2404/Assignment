/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package basicsort;

import java.util.Comparator;
import sort.Queue;
import sort.Sort;

/**
 *
 * @author gagandeepsingh
 */
public class InsertionSorter<E> extends SuperSort<E> {

    // call the constructor of the super class
    public InsertionSorter(E[] e) {
        super(e);

    }

    @Override
    public int getSize() {
        return super.getSize();
    }

    @Override
    public Queue<E> sort(Comparator comparator) {
        Queue result = new Queue();
        if (getSize() == 0) return result; 
        // currentNode is firstItem
        for (Node<E> currentNode = head.next; currentNode.next != null;) {
            boolean hasbeenSorted = true;
            // if node.next is not null and node.next equals currentNode.next. go one more to the right 
            for (Node<E> node = head; node.next != null && node.next != currentNode.next; node = node.next) {
                // if currentNode.next item is smaller than node.next.item 
                if (comparator.compare(currentNode.next.item, node.next.item) < 0) {
                    // exchange these too items
                    exchange(currentNode, node);
                    // is not sorted anymore 
                    hasbeenSorted = false;
                    break;
                }
            }
            //  move currentNode to the right
            if (hasbeenSorted) {
                currentNode = currentNode.next;
            }
        }

        // build the result Queue 
        for (Node<E> node = head; node.next != null; node = node.next) {
            result.put(node.next.item);
        }

        return result;
    }
}
