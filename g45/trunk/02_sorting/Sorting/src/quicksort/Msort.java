/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package quicksort;

import java.util.Comparator;

/**
 *
 * @author gagandeepsingh
 */
public class Msort {

    private final Comparator<Integer> intComparator = (o1, o2) -> {
        return o1 - 02;
    };

    private int[] temp;

    public Msort(int[] arr) {
        this.temp = arr;
    }

    public int sort(int size) {

        int pivot = size;
        int smaller = temp[0];
        int bigger = temp[temp.length - 1];

        while (true) {

            while (isLess(temp[smaller++], temp[pivot]) < 0);
            while (isLess(temp[pivot], temp[bigger--]) < 0) {
                if (bigger == pivot)
                    break;
            }

            if (smaller >= bigger)
                break;
            exchange(smaller, bigger);
        }
        
        return temp[size]; 
    }

    public void exchange(int smaller, int bigger) {
        int temp = this.temp[smaller];

        this.temp[smaller] = this.temp[bigger];
        this.temp[bigger] = temp;
    }

    public int isLess(int n1, int n2) {
        return intComparator.compare(n1, n2);
    }
    
    
    
    
    public static void main(String[] args) {
        int[] arr = {6,2,8,3,6,2,9}; 
        int size = 4; 
        
        Msort m = new Msort(arr); 
        
        m.sort(size);
        
    }
}
