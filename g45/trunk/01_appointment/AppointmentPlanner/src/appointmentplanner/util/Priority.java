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
public enum Priority {
    
    LOW(0),
    MEDIUM(1),
    HIGH(2),
    NOTOUCH(3); 

    private int priorityInt; 
    
    private Priority(int i) {
        priorityInt = i; 
    }

    public int getPriority() {
        return priorityInt;
    }

    public void setPriority(int priority) {
        this.priorityInt = priority;
    }
    
    
    
}
