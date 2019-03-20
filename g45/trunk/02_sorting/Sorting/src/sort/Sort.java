package sort;

import java.util.Comparator;
/**
 *
 * @author ode
 * @param <T> Type to be sorted
 */
public interface Sort<T> {
     /**
     * The sorter method, which returns a sorted queue.
     * @param comparator A comparator for the T objects
     * @return  sorted queue
     */
    Queue<T> sort(Comparator<T> comparator);
}
