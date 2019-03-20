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
 * my code sucks
 *
 * @author gagandeepsingh
 */
public class SelectionSorter<E> extends SuperSort<E> {

    public SelectionSorter(E[] e) {
        super(e);
    }

    @Override
    public int getSize() {
        return super.getSize();
    }

    @Override
    public Queue<E> sort(Comparator<E> comparator) {
        Queue result = new Queue();
        if (getSize() == 0)
            return result;

        // placeholder for minum
        Node<E> beforeMin;
        Node<E> heady;

        // run through the list 
        for (Node<E> currentNode = head; currentNode.next != null; currentNode = currentNode.next) {
            beforeMin = currentNode; // the node (min)
            heady = currentNode;
            
            // search Minimum
            for (Node<E> searchMin = currentNode.next; searchMin.next != null; searchMin = searchMin.next) {
                // search smallest item
                if (comparator.compare(searchMin.next.item, beforeMin.next.item) < 0)
                    // one Node before min item is safed
                    beforeMin = searchMin;
            }
            
            result.put(beforeMin.next.item); // put item in queue
            exchange(beforeMin, currentNode); // exchange the nodes
            
            // to restore the currentNode
            currentNode = heady;

        }
        return result;
    }

}
